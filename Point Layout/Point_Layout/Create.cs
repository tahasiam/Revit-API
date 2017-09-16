/*
 * Created by SharpDevelop.
 * User: t.siamwala
 * Date: 7/4/2017
 * Time: 2:16 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using Autodesk.Revit.UI;
using Autodesk.Revit.DB;
using System.IO;

namespace Point_Layout
{
	/// <summary>
	/// Description of Create.
	/// </summary>
	public partial class Create : System.Windows.Forms.Form
	{
		public const string familyName = "JC10_Survey Points";
		
		/// <summary>
		/// Current UI document
		/// </summary>
		UIDocument docUI1;
		/// <summary>
		/// Current revit document
		/// </summary>
		Document doc1;
		/// <summary>
		/// Object for Function class
		/// </summary>
		Function funct;
		
		public Create(ExternalCommandData ecommandData)
		{
			InitializeComponent();
			funct = new Function();
			doc1 = ecommandData.Application.ActiveUIDocument.Document;
		}
		
		void Btn_CreateClick(object sender, EventArgs e)
		{
			
			Autodesk.Revit.DB.Family family = funct.FindFamilyByName(doc1,typeof(Family),familyName) as Autodesk.Revit.DB.Family;
			
			if(null == family)
			{
				TaskDialog.Show("Error","The family is not loaded!",TaskDialogCommonButtons.Ok,TaskDialogResult.Ok);
			}
			else
			{
				
				double x = 0;
				double y = 0;
				double z = 0;
				
				if(double.TryParse(txt_X1.Text,out x) && double.TryParse(txt_Y1.Text,out y) && double.TryParse(txt_Z1.Text,out z))
				{
					if(rdbtn_meter.Checked)
					{
						x = UnitUtils.Convert(x, DisplayUnitType.DUT_METERS,DisplayUnitType.DUT_FEET_FRACTIONAL_INCHES);
						y = UnitUtils.Convert(y, DisplayUnitType.DUT_METERS,DisplayUnitType.DUT_FEET_FRACTIONAL_INCHES);
						z = UnitUtils.Convert(z, DisplayUnitType.DUT_METERS,DisplayUnitType.DUT_FEET_FRACTIONAL_INCHES);
					}
					
					
					// Step 1 : Get the Project Base Point (PBP).
					Tuple<XYZ,double> basePoint = funct.GetProjectBasePoint(doc1);
					
					//Step 2 : Determine the relative distance of the palcement point with respect to the PBP
					XYZ relativePoint = funct.GetRelativeDistanceTobasePoint(basePoint,new XYZ(x,y,z));
					
					// Step 3 : Incase the True North is rotated, As the Co-Ordinate asis is fixed, we need to move the point in clockwise direction.
					XYZ rotated = funct.RotatePointClockwise(relativePoint.X,relativePoint.Y,relativePoint.Z,basePoint.Item2);
					
					
					Autodesk.Revit.DB.FamilySymbol fs = funct.GetFamilySymbol(doc1);
					
					try {
						using (Transaction tx = new Transaction(doc1)) {
							
							tx.Start("Create Adaptive Component");
							funct.CreateOrMoveAdaptiveComponent(doc1,rotated,fs);
							tx.Commit();
						}

						Clean_Text();
						string result;
						
						if(rdbtn_meter.Checked)
						{
							result = "Point created @  " + "(" + UnitUtils.Convert(rotated.X, DisplayUnitType.DUT_FEET_FRACTIONAL_INCHES,DisplayUnitType.DUT_METERS).ToString("#.000") + " m " + "," + UnitUtils.Convert(rotated.Y, DisplayUnitType.DUT_FEET_FRACTIONAL_INCHES,DisplayUnitType.DUT_METERS).ToString("#.000") + " m " + "," + UnitUtils.Convert(rotated.Z, DisplayUnitType.DUT_FEET_FRACTIONAL_INCHES,DisplayUnitType.DUT_METERS).ToString("#.000")+ " m "+ ")" ;
						}
						else
						{
							result = "Point created @ " + "(" + (rotated.X).ToString("#.000")+ "'" + "," + (rotated.Y).ToString("#.000") + "'" + "," + (rotated.Z).ToString("#.000")+ "'"+ ")";
						}
						
						Status(result,false);

					} catch (Exception) {
						
						Status("Failed to create point",true);
					}
				}
				else
				{
					TaskDialog.Show("Error","Please enter the X,Y and Z Co-Ordinates.",TaskDialogCommonButtons.Ok,TaskDialogResult.Ok);
				}
			}
		}

		void Btn_LoadFamilyClick(object sender, EventArgs e)
		{
			// Check if the family is loaded in the project
			Autodesk.Revit.DB.Family family = funct.FindFamilyByName(doc1,typeof(Family),familyName) as Autodesk.Revit.DB.Family;
			
			if(null == family)
			{
				funct.LoadFamilyinRevit(doc1,GetFilePath(),family);
				Status("Point family loaded.",false);
			}
			else
			{
				TaskDialog.Show("Info","The family is already present in the project!",TaskDialogCommonButtons.Ok,TaskDialogResult.Ok);
			}
		}
		
		public string GetFilePath()
		{
			OpenFileDialog fileDialog = new OpenFileDialog();
			fileDialog.Multiselect = false;
			string filePath = String.Empty;
			if (fileDialog.ShowDialog() == DialogResult.OK)
			{
				filePath = fileDialog.FileName;
			}
			return filePath;

		}
		
		public void Status(string text, bool IsError)
		{
			if(IsError)
			{
				toolStrip_Status.ForeColor = System.Drawing.Color.Red;
				toolStrip_Status.Text = text;
			}
			else
			{
				toolStrip_Status.ForeColor = System.Drawing.Color.Green;
				toolStrip_Status.Text = text;
			}
		}
		
		void Btn_OkClick(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
			this.Close();
		}
		
		void Btn_CancelClick(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}
		
		void Clean_Text()
		{
			txt_X1.Clear();
			txt_Y1.Clear();
			txt_Z1.Clear();
		}

	}
}
