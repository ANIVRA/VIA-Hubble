using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace VIA.Pages
{
    public partial class RecallsPage : ContentPage
    {
        public RecallsPage(string car)
        {
            InitializeComponent();
            infoFor.Text += car;
            
        }
    }
}
