using VIA.Model;
using VIA.Services;
using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using VIA.Helpers;
using VIA.Pages;
using System.Windows.Input;

namespace VIA
{
    public partial class MainPage : ContentPage
    {
        private CarService svcCar = new CarService();
        private ImagesSearch imgCar = new ImagesSearch();
        private RecallSearch rclCar = new RecallSearch();
        ImageResult car { get; set; }
        private string _searchForCar = string.Empty;

        ObservableRangeCollection<ImageResult> _carList { get; set; }

        public MainPage()
        {
            InitializeComponent();

            pickerYears.SelectedIndexChanged += SelectedIndexChanged;
            pickerMakes.SelectedIndexChanged += SelectedIndexChanged;
            pickerModels.SelectedIndexChanged += SelectedIndexChanged;

            // Accomodate iPhone status bar.
            Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 5);

        }

        private async void SelectedIndexChanged(object sender, EventArgs e)
        {

            Picker pk = (Picker)sender;


            if (string.Compare(pk.Title, "Years") == 0)
            {
                Picker makes = Content.FindByName<Picker>("pickerMakes");
                List<string> mks = await svcCar.GetMakes(pk.Items[pk.SelectedIndex]);

                foreach (string m in mks)
                {
                    if (m != null)
                        makes.Items.Add(m);
                }
            }

            else if (string.Compare(pk.Title, "Makes") == 0)
            {
                Picker years = Content.FindByName<Picker>("pickerYears");
                Picker models = Content.FindByName<Picker>("pickerModels");
                List<string> mods = new List<string>();

                List<string> mdl =
                    await svcCar.GetModels(years.Items[years.SelectedIndex],
                                           pk.Items[pk.SelectedIndex]);

                var ic = models.Items.Count();
                if (ic > 0)
                {
                    for(int i=0; i < ic; i++)
                    {
                        models.Items.RemoveAt(0);
                    }
                }

                if (mdl.Count() == 1)
                {
                    models.Items.Add("");
                }
                else
                {
                    foreach (string m in mdl)
                    {
                        if ((m != null && m != "via NHTSA") && (m != null && m != "via CUSTOM"))
                            models.Items.Add(m);
                    }
                }

                modelSource.Text = mdl.Last();
            }

            else if (string.Compare(pk.Title, "Models") == 0)
            {
                Picker years = Content.FindByName<Picker>("pickerYears");
                Picker makes = Content.FindByName<Picker>("pickerMakes");
                Picker trims = Content.FindByName<Picker>("pickerTrims");
                ActivityIndicator busy = Content.FindByName<ActivityIndicator>("busyIndicator");

                _searchForCar = "new " + years.Items[years.SelectedIndex] + " " +
                         makes.Items[makes.SelectedIndex] + " " +
                         pk.Items[pk.SelectedIndex];

                busy.IsRunning = true;
                busy.IsVisible = true;

                ObservableRangeCollection<ImageResult> result = await imgCar.SearchForImagesAsync(_searchForCar);
                _carList = result;
                car = result.FirstOrDefault();


                carLabel.Text = car.Title;
                carImage.Source = car.ImageLink;

                busy.IsRunning = false;
                busy.IsVisible = false;

            }

            //Disable the current SelectList
            pk.IsEnabled = false;
        }

        async void OnRecallsClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RecallsPage(car.Title), true);
        }

        async void OnImagesClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CarsView(_searchForCar));
        }

        async void OnRefreshClicked(object sender, EventArgs e)
        {
            //await Navigation.PushAsync(new MainPage());
            InitializeComponent();

            pickerYears.SelectedIndexChanged += SelectedIndexChanged;
            pickerMakes.SelectedIndexChanged += SelectedIndexChanged;
            pickerModels.SelectedIndexChanged += SelectedIndexChanged;

            // Accomodate iPhone status bar.
            Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 5);

            CarService svcCar = new CarService();

            List<string> yrs = await svcCar.GetYears();

            foreach (string y in yrs)
            {
                if (y != null)
                    pickerYears.Items.Add(y);
            }

        }

        async void OnPreviousPageButtonClicked(object sender, EventArgs e)
        {
            // Page appearance not animated
            await Navigation.PopAsync(false);
        }

        async void OnRootPageButtonClicked(object sender, EventArgs e)
        {
            // Page appearance not animated
            await Navigation.PopToRootAsync(false);
        }
    }
}
