using System;
using CoreGraphics;
using Foundation;
using UIKit;

namespace NavigationSample
{
	public partial class NavController : UINavigationController
	{
		public NavController() : base((string)null, null)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			
			// Perform any additional setup after loading the view, typically from a nib.
		}
	}
}

