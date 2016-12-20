using Foundation;
using System;
using UIKit;

namespace VIA.iOS
{
    public partial class SingleCarController : UITableViewController
    {
        public SingleCarController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            ShowCar();
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        private void ShowCar()
        {
            // Display new car
            //https://imganuncios.mitula.net/2015_bmw_3_series_328i_xdrive_orion_silver_metallic_in_lionshead_lake_new_jersey_5900006459364697014.jpg
            CarView.Image = UIImage.LoadFromData(NSData.FromUrl(new NSUrl ("https://imganuncios.mitula.net/2015_bmw_3_series_328i_xdrive_orion_silver_metallic_in_lionshead_lake_new_jersey_5900006459364697014.jpg")));
            //CarView.Image = UIImage.FromFile(string.Format("Cat{0:00}.jpg", PageNumber + 1));
        }
    }
}