// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace VIA.iOS
{
    [Register ("SingleCarController")]
    partial class SingleCarController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView CarView { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (CarView != null) {
                CarView.Dispose ();
                CarView = null;
            }
        }
    }
}