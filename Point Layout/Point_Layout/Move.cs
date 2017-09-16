/*
 * Created by SharpDevelop.
 * User: t.siamwala
 * Date: 7/31/2017
 * Time: 11:10 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using Autodesk.Revit.UI;
using Autodesk.Revit.DB;

namespace Point_Layout
{
	/// <summary>
	/// Description of Move.
	/// </summary>
	public partial class Move : System.Windows.Forms.Form
	{
		public const string familyName = "JC10_Survey Points_Station";
		/// <summary>
		/// Current UI document
		/// </summary>
		UIDocument docUI;
		/// <summary>
		/// Current revit document
		/// </summary>
		Document doc;
		/// <summary>
		/// Object for Function class
		/// </summary>
		Function funct;
		
		XYZ oldPoint  = null;
		
		Reference selectedElement = null;
		
		public Move(ExternalCommandData commandData,Reference elementReference)
		{
			InitializeComponent();
			docUI = commandData.Application.ActiveUIDocument;
			doc = commandData.Application.ActiveUIDocument.Document;
			
			// Get the Selected element reference.
			selectedElement = elementReference;
			
			//Instantiate the function class
			funct = new Function();
			
			//Get the location of the selected element  
			XYZ  existingLocation = funct.GetAdaptivePointLocation(doc,selectedElement);
			
			oldPoint = PointManipulation(existingLocation);
			
			//Display the Existing Co-Ordinates to the user
			txt_X1.Text = (oldPoint.X).ToString("#.000");
			txt_Y1.Text = (oldPoint.Y).ToString("#.000");
			txt_Z1.Text = (oldPoint.Z).ToString("#.000");
		}
		
		public void Status(string text)
		{
			toolStrip_Status.Text = text;
		}
		
		void Btn_MoveClick(object sender, EventArgs e)
		{
			
			double x = 0;
			double y = 0;
			double z = 0;
			
			if(double.TryParse(txt_X2.Text,out x) && double.TryParse(txt_Y2.Text,out y) && double.TryParse(txt_Z2.Text,out z))
			{
				if(rdbtn_meter.Checked)
				{
					x = UnitUtils.Convert(x, DisplayUnitType.DUT_METERS,DisplayUnitType.DUT_FEET_FRACTIONAL_INCHES);
					y = UnitUtils.Convert(y, DisplayUnitType.DUT_METERS,DisplayUnitType.DUT_FEET_FRACTIONAL_INCHES);
					z = UnitUtils.Convert(z, DisplayUnitType.DUT_METERS,DisplayUnitType.DUT_FEET_FRACTIONAL_INCHES);
				}

				// Step 1 : Get the Project Base Point (PBP).
				Tuple<XYZ,double> basePoint = funct.GetProjectBasePoint(doc);
				
				//Step 2 : Determine the relative distance of the palcement point with respect to the PBP
				XYZ relativePoint = funct.GetRelativeDistanceTobasePoint(basePoint,new Autodesk.Revit.DB.XYZ(x,y,z));
				
				// Step 3 : Incase the True North is rotated, make the necessary correction.
				XYZ rotated = funct.RotatePointAntiClockwise(relativePoint.X,relativePoint.Y,relativePoint.Z,basePoint.Item2);
				
				using (Transaction tx = new Transaction(doc))
				{
					tx.Start("Move Adaptive Component");
					funct.CreateOrMoveAdaptiveComponent(doc,rotated,null,selectedElement.ElementId);
					tx.Commit();
				}
			}
		}
		
		void Btn_CancelClick(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}
		
		XYZ PointManipulation(XYZ xyz)
		{

			
			double x = 0;
			double y = 0;
			double z = 0;
			
			// Step 1 : Get the Project Base Point (PBP).
			Tuple<XYZ,double> basePoint = funct.GetProjectBasePoint(doc);
			
			// Step 2 : Incase the True North is rotated, make the necessary correction.
			XYZ rotated = funct.RotatePointAntiClockwise(xyz.X,xyz.Y,xyz.Z,basePoint.Item2);

			//Step 3 : Determine the relative distance of the palcement point with respect to the PBP
			XYZ relativePoint = funct.GetRelativeDistanceTobasePoint2(basePoint,rotated);
			
			if(rdbtn_meter.Checked)
			{
				x = UnitUtils.Convert((relativePoint.X), DisplayUnitType.DUT_FEET_FRACTIONAL_INCHES,DisplayUnitType.DUT_METERS);
				y = UnitUtils.Convert((relativePoint.Y), DisplayUnitType.DUT_FEET_FRACTIONAL_INCHES,DisplayUnitType.DUT_METERS);
				z = UnitUtils.Convert((relativePoint.Z), DisplayUnitType.DUT_FEET_FRACTIONAL_INCHES,DisplayUnitType.DUT_METERS);
			}

			return new XYZ(x,y,z);
		}
		
		void Btn_OkClick(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
			this.Close();
		}
		
		void Rdbtn_feetCheckedChanged(object sender, EventArgs e)
		{
			if(null != oldPoint)
			{
				//Display the Existing Co-Ordinates to the user
				txt_X1.Text = UnitUtils.Convert((oldPoint.X), DisplayUnitType.DUT_METERS,DisplayUnitType.DUT_FEET_FRACTIONAL_INCHES).ToString("#.000");
				txt_Y1.Text = UnitUtils.Convert((oldPoint.Y), DisplayUnitType.DUT_METERS,DisplayUnitType.DUT_FEET_FRACTIONAL_INCHES).ToString("#.000");
				txt_Z1.Text = UnitUtils.Convert((oldPoint.Z), DisplayUnitType.DUT_METERS,DisplayUnitType.DUT_FEET_FRACTIONAL_INCHES).ToString("#.000");
			}
		}
		
		void Rdbtn_meterCheckedChanged(object sender, EventArgs e)
		{
			if(null != oldPoint)
			{
				
				txt_X1.Text = (oldPoint.X).ToString("#.000");
				txt_Y1.Text = (oldPoint.Y).ToString("#.000");
				txt_Z1.Text = (oldPoint.Z).ToString("#.000");
			}
		}
	}
	
}
