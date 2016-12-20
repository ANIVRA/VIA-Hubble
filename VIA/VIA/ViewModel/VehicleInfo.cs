using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using VIA.Model;
using VIA.Services;
using MvvmHelpers;
using Xamarin.Forms;
using VIA.Helpers;
using VIA.Pages;
using System.Windows.Input;

namespace VIA.ViewModel
{
    public class VehicleInfoViewModel //: INotifyPropertyChanged
    {
    //    //Interface implementation members
    //    public event PropertyChangedEventHandler PropertyChanged;
    //    public void OnPropertyChanged([CallerMemberName]string name = "") =>
    //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));


    //    private CarService svcCar = new CarService();
    //    private ImageSearch imgCar = new ImageSearch();
    //    private RecallSearch rclCar = new RecallSearch();

    //    ObservableRangeCollection<ImageResult> _carList { get; set; }

    //    public ICommand ImageListCommand { get; private set; }
    //    public string ImageTitle { get; set; }
    //    public string ImageLink { get; set; }

    //    public List<string> Years { get; set; }


    //    //private async void SelectedIndexChanged(object sender, EventArgs e)
    //    //{

    //    //    Picker pk = (Picker)sender;


    //    //    if (string.Compare(pk.Title, "Years") == 0)
    //    //    {
    //    //        //Picker makes = Content.FindByName<Picker>("pickerMakes");

    //    //        List<string> mks = await svcCar.GetMakes(pk.Items[pk.SelectedIndex]);

    //    //        foreach (string m in mks)
    //    //        {
    //    //            if (m != null)
    //    //                makes.Items.Add(m);
    //    //        }
    //    //    }

    //    //    if (string.Compare(pk.Title, "Makes") == 0)
    //    //    {
    //    //        Picker years = Content.FindByName<Picker>("pickerYears");
    //    //        Picker models = Content.FindByName<Picker>("pickerModels");
    //    //        List<string> mdl =
    //    //            await svcCar.GetModels(years.Items[years.SelectedIndex],
    //    //                                   pk.Items[pk.SelectedIndex]);

    //    //        foreach (string m in mdl)
    //    //        {
    //    //            if (m != null)
    //    //                models.Items.Add(m);
    //    //        }
    //    //    }

    //    //    if (string.Compare(pk.Title, "Models") == 0)
    //    //    {
    //    //        Picker years = Content.FindByName<Picker>("pickerYears");
    //    //        Picker makes = Content.FindByName<Picker>("pickerMakes");
    //    //        Picker trims = Content.FindByName<Picker>("pickerTrims");
    //    //        List<string> trm =
    //    //            await svcCar.GetTrims(years.Items[years.SelectedIndex],
    //    //                                  makes.Items[makes.SelectedIndex],
    //    //                                  pk.Items[pk.SelectedIndex]);

    //    //        foreach (string t in trm)
    //    //        {
    //    //            if (t != null)
    //    //                trims.Items.Add(t);
    //    //        }

    //    //    }

    //    //    if (string.Compare(pk.Title, "Trims") == 0)
    //    //    {
    //    //        Picker years = Content.FindByName<Picker>("pickerYears");
    //    //        Picker makes = Content.FindByName<Picker>("pickerMakes");
    //    //        Picker models = Content.FindByName<Picker>("pickerModels");
    //    //        ObservableRangeCollection<ImageResult> result =
    //    //            await imgCar.SearchForImagesAsync(years.Items[years.SelectedIndex] + " " +
    //    //                                              makes.Items[makes.SelectedIndex] + " " +
    //    //                                              models.Items[models.SelectedIndex] + " " +
    //    //                                              pk.Items[pk.SelectedIndex]);
    //    //        _carList = result;
    //    //        ImageResult car = result.FirstOrDefault();

    //    //        //carLabel.Text = car.Title;
    //    //        //carImage.Source = car.ImageLink;

    //    //        ImageTitle = car.Title;
    //    //        ImageLink = car.ImageLink;
    //    //    }

    //    //}

    //    async void OnRecallsClicked(object sender, EventArgs e)
    //    {
    //        //await Navigation.PushAsync(new Recalls(), false);
    //    }

    //    async void OnImagesClicked()
    //    {

    //        //await Navigation.PushAsync(new ImageList(_carList), false);
    //    }

    //    async void OnPreviousPageButtonClicked(object sender, EventArgs e)
    //    {
    //        // Page appearance not animated
    //        //await Navigation.PopAsync(false);
    //    }

    //    async void OnRootPageButtonClicked(object sender, EventArgs e)
    //    {
    //        // Page appearance not animated
    //        //await Navigation.PopToRootAsync(false);
    //    }

    }
}
