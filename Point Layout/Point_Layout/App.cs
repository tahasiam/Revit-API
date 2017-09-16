/*
 * Created by SharpDevelop.
 * User: t.siamwala
 * Date: 7/4/2017
 * Time: 1:47 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using Autodesk.Revit.UI;
using System.Reflection;
using System.Windows.Media.Imaging;

namespace Point_Layout
{
	/// <summary>
	/// Description of MyClass.
	/// </summary>
	public class App : IExternalApplication
	{
		#region IExternalApplication implementation
		public Result OnStartup(UIControlledApplication application)
		{
			// Creation of Button in the Ribbon
			RibbonPanel ribbonPanel = application.CreateRibbonPanel("Point Layout");
			string assemblypath = Assembly.GetExecutingAssembly().Location;
			
			
			PushButtonData createPoint = new PushButtonData("cmdCreateButton", "Create", assemblypath, "Point_Layout.Command_Create");
			PushButtonData movePoint = new PushButtonData("cmdMoveButton", "Move", assemblypath, "Point_Layout.Command_Move");
			
			PushButton createButton = ribbonPanel.AddItem(createPoint) as PushButton;
			PushButton moveButton = ribbonPanel.AddItem(movePoint) as PushButton;
			
			// Addition of image to the button
			Uri createIcon = new Uri(@"C:\Users\t.siamwala\Documents\SharpDevelop Projects\Point_Layout\Point_Layout\Create.png");
			Uri moveIcon = new Uri(@"C:\Users\t.siamwala\Documents\SharpDevelop Projects\Point_Layout\Point_Layout\Move.png");
			
			BitmapImage createImage = new BitmapImage(createIcon);
			BitmapImage moveImage = new BitmapImage(moveIcon);
			
			createButton.LargeImage = createImage;
			
			moveButton.LargeImage = moveImage;
			
			return Result.Succeeded;
		}
		public Result OnShutdown(UIControlledApplication application)
		{
			return Result.Succeeded;
		}
		#endregion
		
	}
}