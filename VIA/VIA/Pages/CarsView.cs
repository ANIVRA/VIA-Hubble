using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace VIA.Pages
{
    public class CarsView : ContentPage
    {
        public readonly string SearchString;

        public CarsView(string search)
        {
            SearchString = search;
        }
    }
}
