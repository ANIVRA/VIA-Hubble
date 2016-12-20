using System;
using Foundation;
using UIKit;
using SDWebImage;
using VIA.ViewModel;

namespace VIA.iOS
{
    public partial class CarViewController : UIViewController, IUICollectionViewDataSource
	{

        ImageSearchViewModel viewModel;

        private string _query;
        public string Query
        {
            get { return _query; }
            set { _query = value; }
        }

		public CarViewController (IntPtr handle) : base (handle)
		{
		}

        public async void FillImageCells()
        {
            viewModel = new ImageSearchViewModel();
            CollectionViewImages.WeakDataSource = this;


            ActivityIsLoading.StartAnimating();

            await viewModel.SearchForImagesAsync(_query);
            CollectionViewImages.ReloadData();

            ActivityIsLoading.StopAnimating();
        }

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

            CarNavBar.Title = _query.Substring(4);
            FillImageCells();
        }

        public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}

        public nint GetItemsCount(UICollectionView collectionView, nint section) => 
            viewModel.Images.Count;

        public UICollectionViewCell GetCell(UICollectionView collectionView, NSIndexPath indexPath)
        {
            var cell = collectionView.DequeueReusableCell("imagecell", indexPath) as ImageCell;

            var item = viewModel.Images[indexPath.Row];

            //cell.Caption.Text = item.Title;

            cell.Image.SetImage(new NSUrl(item.ThumbnailLink));


            return cell;
        }
    }
}

