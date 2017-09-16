/*
 * Created by SharpDevelop.
 * User: t.siamwala
 * Date: 7/31/2017
 * Time: 1:30 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using Autodesk.Revit.UI;
using Autodesk.Revit.DB;
using System.Collections.Generic;

namespace Point_Layout
{
	/// <summary>
	/// Description of Command_Move.
	/// </summary>
	[Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.Manual)]
	public class Command_Move:IExternalCommand
	{
		Function funct = null;
		Reference selectedElementReference = null;
		
		public Command_Move()
		{
			funct = new Function();
		}

		#region IExternalCommand implementation

		public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
		{
			try
			{
				if(null == commandData)
				{
					return Autodesk.Revit.UI.Result.Failed;
				}
				
				UIDocument docUI = commandData.Application.ActiveUIDocument;
				Document doc = commandData.Application.ActiveUIDocument.Document;
				
				try
				{
					//Select the element from Revit before passing the control to the Windows Form. As you will not be able to select element once the Form isinitiated.
					selectedElementReference = funct.SelectElement(doc,docUI);

				}
				catch (NullReferenceException e)
				{
					
					message = e.Message;
					return Autodesk.Revit.UI.Result.Cancelled;
				}
				
				using (Move newDialog = new Move(commandData,selectedElementReference)) {
					
					if(newDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK) return Result.Succeeded;
				}
				return Autodesk.Revit.UI.Result.Cancelled;
				
			}
			catch (Exception e)
			{
				
				message = e.Message;
				return Autodesk.Revit.UI.Result.Failed;
			}
		}

		#endregion
	}
}
