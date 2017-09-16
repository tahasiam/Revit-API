/*
 * Created by SharpDevelop.
 * User: t.siamwala
 * Date: 7/4/2017
 * Time: 1:48 PM
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
	/// Description of Cmd.
	/// </summary>
	/// 
	[Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.Manual)]
	public class Command_Create :IExternalCommand
	{
		public Command_Create()
		{
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
				using (Create newDialog = new Create(commandData)) {
					
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
