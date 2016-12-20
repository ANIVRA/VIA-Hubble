using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms.Platform.Android;
using Android.Graphics;
using VIA.Droid;

[assembly: ExportRenderer(typeof(VIA.Pages.CarsView), typeof(CarsView))]
namespace VIA.Droid
{
    class CarsView : PageRenderer, TextureView.ISurfaceTextureListener
    {
        public void OnSurfaceTextureAvailable(SurfaceTexture surface, int width, int height)
        {
            throw new NotImplementedException();
        }

        public bool OnSurfaceTextureDestroyed(SurfaceTexture surface)
        {
            throw new NotImplementedException();
        }

        public void OnSurfaceTextureSizeChanged(SurfaceTexture surface, int width, int height)
        {
            throw new NotImplementedException();
        }

        public void OnSurfaceTextureUpdated(SurfaceTexture surface)
        {
            throw new NotImplementedException();
        }


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

        protected override void OnElementChanged(ElementChangedEventArgs<Page> e)
        {

            base.OnElementChanged(e);

            var activity = Context as Activity;

            var carImages = new Intent(activity, typeof(CarActivity));

            carImages.PutExtra("Query", SearchString);

            activity.StartActivity(carImages);

        }

    }
}
