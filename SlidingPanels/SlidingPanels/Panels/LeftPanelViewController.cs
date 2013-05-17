/// Copyright (C) 2013 Pat Laplante & Franc Caico
///
///	Permission is hereby granted, free of charge, to  any person obtaining a copy 
/// of this software and associated documentation files (the "Software"), to deal 
/// in the Software without  restriction, including without limitation the rights 
/// to use, copy,  modify,  merge, publish,  distribute,  sublicense, and/or sell 
/// copies of the  Software,  and  to  permit  persons  to   whom the Software is 
/// furnished to do so, subject to the following conditions:
///
///		The above  copyright notice  and this permission notice shall be included 
///     in all copies or substantial portions of the Software.
///
///		THE  SOFTWARE  IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS
///     OR   IMPLIED,   INCLUDING  BUT   NOT  LIMITED   TO   THE   WARRANTIES  OF 
///     MERCHANTABILITY,  FITNESS  FOR  A PARTICULAR PURPOSE AND NONINFRINGEMENT. 
///     IN NO EVENT SHALL  THE AUTHORS  OR COPYRIGHT  HOLDERS  BE  LIABLE FOR ANY 
///     CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT 
///     OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION  WITH THE SOFTWARE OR 
///     THE USE OR OTHER DEALINGS IN THE SOFTWARE.
/// -----------------------------------------------------------------------------

using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using SlidingPanels.Lib;

namespace SlidingPanels.Panels
{
	public partial class LeftPanelViewController : UIViewController, IPanelView
	{
		public LeftPanelViewController () : base ("LeftPanelViewController", null)
		{
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			
			// Perform any additional setup after loading the view, typically from a nib.
		}

		partial void ShowScreenA (MonoTouch.Foundation.NSObject sender)
		{
			TopViewSwapped(this, new TopViewSwappedEventArgs(new UINavigationController(new ExampleContentA())));
		}

		partial void ShowScreenB (MonoTouch.Foundation.NSObject sender)
		{
			TopViewSwapped(this, new TopViewSwappedEventArgs(new UINavigationController(new ExampleContentB())));
		}

		#region IPanel implementation

		public event EventHandler TopViewSwapped;

		public void RefreshContent ()
		{
		}

		public SizeF Size
		{
			get
			{
				// This panel will appear on the left side.  The associated container doesn't
				// care about the height so we set it to an arbitrary value of -1.
				return new System.Drawing.SizeF (250, -1);
			}
		}		

		#endregion

	}
}

