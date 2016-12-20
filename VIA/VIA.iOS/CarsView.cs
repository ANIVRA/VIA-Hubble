using System;
using System.Collections.Generic;
using System.Text;
using UIKit;
using VIA.iOS;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(VIA.Pages.CarsView), typeof(CarsView))]
namespace VIA.iOS
{
    public class CarsView : PageRenderer
    {
        private string SearchString
        {
            get
            {
                var srch = Element as Pages.CarsView;
                return srch == null
                    ? null
                    : srch.SearchString;
            }
        }

        protected override void OnElementChanged(VisualElementChangedEventArgs e)
        {
            base.OnElementChanged(e);

            if (e.OldElement != null || Element == null)
            {
                return;
            }
        
            try
            {
                var hostViewController = ViewController;

                var viewController = (CarViewController)CarDelegate.Storyboard.InstantiateViewController("CarViewController");
                viewController.Query = SearchString;
                hostViewController.AddChildViewController(viewController);
                hostViewController.View.Add(viewController.View);

                viewController.DidMoveToParentViewController(hostViewController);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(@" ERROR: ", ex.Message);
            }
        }
    }
}
