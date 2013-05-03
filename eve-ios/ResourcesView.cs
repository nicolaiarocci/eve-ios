using System;
using MonoTouch.Dialog;
using MonoTouch.UIKit;

namespace eveios
{
	public partial class AppDelegate {

		public void ResourcesView(){
			var root = new RootElement("Available Resources"){
				new Section(){
					new StringElement("Work in progress!")
				},
			};	

			var dv = new DialogViewController (root, true);
			navigation.PushViewController (dv, true);
		}

	}
}

