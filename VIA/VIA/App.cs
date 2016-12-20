using VIA.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using VIA.ViewModel;

namespace VIA
{
    public class App : Application
    {
        MainPage mp = new MainPage();
        public App()
        {
            //mp.BindingContext = new VehicleInfoViewModel();

            // The root page of your application
            //mp.BackgroundColor = Color.FromHex("fffc7c1a");
            MainPage = new NavigationPage(mp);
        }

        protected async override void OnStart()
        {
            // Handle when your app starts
            Picker years = mp.Content.FindByName<Picker>("pickerYears");

            CarService svcCar = new CarService();

            List<string> yrs = await svcCar.GetYears();

            foreach (string y in yrs)
            {
                if (y != null)
                    years.Items.Add(y);
            }

        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
