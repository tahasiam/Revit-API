/*
 * Created by SharpDevelop.
 * User: t.siamwala
 * Date: 7/18/2017
 * Time: 7:37 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;
using Autodesk.Revit.UI;
using Autodesk.Revit.DB;
using System.Collections.Generic;
using System.Linq;

namespace Point_Layout
{
	/// <summary>
	/// Description of Function.
	/// </summary>
	public class Function
	{
		public const string familyName = "JC10_Survey Points";
		public const string typeName = "JC10_AsBuilt_Station";
		const string _family_ext = "rfa";
		
		public Function()
		{
		}
		
		public Autodesk.Revit.DB.Reference SelectElement(Document doc, UIDocument UIdoc)
		{
			Reference selectedelement = null;
			try {
				
				Autodesk.Revit.UI.Selection.Selection choice = UIdoc.Selection;
				selectedelement = choice.PickObject(Autodesk.Revit.UI.Selection.ObjectType.Element);
				
			} catch (Exception) {
				
				throw;
			}
			
			return selectedelement;
		}
		
		public XYZ RotatePointAntiClockwise(double x, double y, double z, double angle)
		{
			// Clockwise - +ve and AntiClockwise - -ve (Angle)
			//The inout angle is in Radians
			
			double x1 = (x*Math.Cos(angle)) + (y*Math.Sin(angle));
			double y1 = -(x*Math.Sin(angle)) + (y*Math.Cos(angle));
			
			return new XYZ(x1,y1,z);

		}
		
		public XYZ RotatePointClockwise(double x, double y, double z, double angle)
		{
			// Clockwise - +ve and AntiClockwise - -ve (Angle)
			//The inout angle is in Radians
			
			double x1 = (x*Math.Cos(angle)) - (y*Math.Sin(angle));
			double y1 = (x*Math.Sin(angle)) + (y*Math.Cos(angle));
			
			return new XYZ(x1,y1,z);

		}
		
		private  double DegreeToRadian(double angle)
		{
			return Math.PI * angle / 180.0;
		}
		
		public Tuple<XYZ, double> GetProjectBasePoint(Autodesk.Revit.DB.Document doc)
		{
			double x = 0;
			double y = 0;
			double z = 0;
			double angle = 0;
			
			ElementCategoryFilter filter = new ElementCategoryFilter(BuiltInCategory.OST_ProjectBasePoint);
			FilteredElementCollector collector = new FilteredElementCollector(doc);
			IList<Element> elements = collector.WherePasses(filter).ToElements();

			foreach (Element element in elements)
			{
				x = element.get_Parameter(BuiltInParameter.BASEPOINT_EASTWEST_PARAM).AsDouble();
				y = element.get_Parameter(BuiltInParameter.BASEPOINT_NORTHSOUTH_PARAM).AsDouble();
				z = element.get_Parameter(BuiltInParameter.BASEPOINT_ELEVATION_PARAM).AsDouble();
				angle = element.get_Parameter(BuiltInParameter.BASEPOINT_ANGLETON_PARAM).AsDouble();
			}
			return new Tuple<XYZ, double>(new XYZ(x,y,z),angle);
		}
		
		public XYZ GetRelativeDistanceTobasePoint(Tuple<XYZ, double> basePoint, XYZ inputPoint)
		{
			double x = 0;
			double y = 0;
			
			x = inputPoint.X - basePoint.Item1.X;
			y = inputPoint.Y - basePoint.Item1.Y;
			
			return new XYZ(x,y,inputPoint.Z);
		}
		
		public XYZ GetRelativeDistanceTobasePoint2(Tuple<XYZ, double> basePoint, XYZ inputPoint)
		{
			double x = 0;
			double y = 0;
			
			x = inputPoint.X + basePoint.Item1.X;
			y = inputPoint.Y + basePoint.Item1.Y;
			
			return new XYZ(x,y,inputPoint.Z);
		}
		
		public Autodesk.Revit.DB.FamilySymbol GetFamilySymbol(Autodesk.Revit.DB.Document doc)
		{
			Autodesk.Revit.DB.FamilySymbol familySymbol = null;
			Autodesk.Revit.DB.FilteredElementCollector col = new Autodesk.Revit.DB.FilteredElementCollector(doc)
				.WherePasses(new Autodesk.Revit.DB.ElementClassFilter(typeof(Autodesk.Revit.DB.FamilySymbol)))
				.WherePasses(new Autodesk.Revit.DB.ElementCategoryFilter(BuiltInCategory.OST_Site));
			
			foreach (var fs in col) {
				
				if(typeName == fs.Name)
					
				{
					familySymbol = fs as Autodesk.Revit.DB.FamilySymbol;
				}
				
				
			}
			return familySymbol;
			
		}
		
		public Result LoadFamilyinRevit(Autodesk.Revit.DB.Document document,string familyPath,Autodesk.Revit.DB.Family family)
		{
			if(null == familyPath)
			{
				familyPath = Path.Combine(familyPath,familyName);
				familyPath = Path.ChangeExtension(familyPath,_family_ext);
			}
			if(!File.Exists(familyPath))
			{
				TaskDialog.Show("Error", "Please ensure that the family :"+ familyName+ "exist in the given path :" + familyPath,TaskDialogCommonButtons.Close,TaskDialogResult.Close);
				return Result.Failed;
			}
			
			using (Transaction trans = new Autodesk.Revit.DB.Transaction(document)) {
				
				trans.Start("LoadFamily");
				document.LoadFamily(familyPath, out family );
				trans.Commit();
				
			}
			return Result.Succeeded;
			
		}
		
		public Element FindFamilyByName(Autodesk.Revit.DB.Document document, Type targetType, string targetName)
		{
			return new Autodesk.Revit.DB.FilteredElementCollector(document)
				.OfClass(targetType)
				.FirstOrDefault<Element>(e => e.Name.Equals(targetName));
		}
		
		public void CreateOrMoveAdaptiveComponent(Autodesk.Revit.DB.Document document, XYZ placementPoint,Autodesk.Revit.DB.FamilySymbol symbol = null, ElementId elementToMove = null)
		{
			
			Autodesk.Revit.DB.FamilyInstance instance = null;
			
			if(elementToMove == null)
			{
				// Create a new instance of an adaptive component family
				instance = AdaptiveComponentInstanceUtils.CreateAdaptiveComponentInstance(document, symbol);
			}
			else
			{
				instance = document.GetElement(elementToMove) as Autodesk.Revit.DB.FamilyInstance;
			}


			// Get the placement points of this instance
			IList<Autodesk.Revit.DB.ElementId> placePointIds = new List<Autodesk.Revit.DB.ElementId>();
			placePointIds = AdaptiveComponentInstanceUtils.GetInstancePlacementPointElementRefIds(instance);

			// Set the position of each placement point
			foreach (Autodesk.Revit.DB.ElementId id in placePointIds)
			{
				ReferencePoint point = document.GetElement(id) as ReferencePoint;
				point.Position = placementPoint;

			}
		}
		
		public XYZ GetAdaptivePointLocation(Document document,Reference elementReference)
		{
			// Get the family instance of the selected element
			Autodesk.Revit.DB.FamilyInstance instance = document.GetElement(elementReference.ElementId) as Autodesk.Revit.DB.FamilyInstance;
			
			// Get the placement points of this instance
			
			ElementId placePointIds = (AdaptiveComponentInstanceUtils.GetInstancePlacementPointElementRefIds(instance)).First();
			
			ReferencePoint point = document.GetElement(placePointIds) as ReferencePoint;
			
			return point.Position;
			
		}
		
		
	}
}
