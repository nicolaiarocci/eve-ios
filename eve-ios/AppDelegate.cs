using System;
using System.Collections.Generic;
using System.Linq;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.Dialog;

namespace eveios
{
	// The UIApplicationDelegate for the application. This class is responsible for launching the 
	// User Interface of the application, as well as listening (and optionally responding) to 
	// application events from iOS.
	[Register ("AppDelegate")]
	public partial class AppDelegate : UIApplicationDelegate
	{
		// class-level declarations
		UIWindow window;
		UINavigationController navigation;

		//
		// This method is invoked when the application has loaded and is ready to run. In this 
		// method you should instantiate the window, load the UI into it and then make the window
		// visible.
		//
		// You have 17 seconds to return from this method, or iOS will terminate your application.
		//
		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			// create a new window instance based on the screen size
			window = new UIWindow (UIScreen.MainScreen.Bounds);
			
			var rootVC = new DialogViewController(CreateRoot());
			navigation = new  UINavigationController(rootVC);
			window.RootViewController = navigation;

			// make the window visible
			window.MakeKeyAndVisible ();
			
			return true;
		}

		RootElement CreateRoot(){
			var rootElement = new RootElement("Eve iOS"){
				new Section(){
					new StyledMultilineElement("This app will consume a Eve-powered REST API. To get started, enter the API entry point in the field below.")
					{
						Font = UIFont.FromName ("Helvetica", 14f)
					}

				},
				new Section(){
					new EntryElement("URL", "API entry point URL", "http://eve-demo.herokuapp.com/")
				},
				new Section(){
					new StringElement("Go!", ResourcesView){
						Alignment = UITextAlignment.Center,
					}
				},
			};
			return rootElement;
		}
	}
}

