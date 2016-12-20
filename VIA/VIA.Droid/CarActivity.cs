using System;
using Android.App;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Support.V7.Widget;
using VIA.Droid.Adapters;
using Acr.UserDialogs;
using VIA.ViewModel;


namespace VIA.Droid
{
    [Activity(Icon = "@drawable/icon")]
    public class CarActivity : BaseActivity
    {
        RecyclerView recyclerView;
        RecyclerView.LayoutManager layoutManager;
        ImageAdapter adapter;
        ProgressBar progressBar;

        ImageSearchViewModel viewModel;

        protected override int LayoutResource
        {
            get { return Resource.Layout.main; }
        }

        private string _query;

        public async void FillImageCells()
        {
            progressBar = FindViewById<ProgressBar>(Resource.Id.my_progress);

            progressBar.Visibility = ViewStates.Visible;

            await viewModel.SearchForImagesAsync(_query);

            progressBar.Visibility = ViewStates.Gone;

        }

        public void RecyclerView()
        {
            adapter = new ImageAdapter(this, viewModel);

            recyclerView = FindViewById<RecyclerView>(Resource.Id.recyclerView);

            recyclerView.SetAdapter(adapter);

            layoutManager = new GridLayoutManager(this, 2);

            recyclerView.SetLayoutManager(layoutManager);
        }

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            viewModel = new ImageSearchViewModel();

            _query = Intent.GetStringExtra("Query") ?? "Data not available";

            //Setup RecyclerView
            RecyclerView();

            //Get additional images
            FillImageCells();

            UserDialogs.Init(this);
            SupportActionBar.SetDisplayHomeAsUpEnabled(false);
            SupportActionBar.SetHomeButtonEnabled(false);

        }
    }
}