using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Demo01Windows
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            ConvertButton.Clicked += ConvertButton_Clicked;
        }

        private void ConvertButton_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(PesosEntry.Text))
            {
                DisplayAlert("Error", "You mus a value in pesos.", "Accept");
                return;
            }

            //Conver Values
            var pesos = decimal.Parse(PesosEntry.Text);
            var dollars = pesos / 2976.19048M; //Se utiliza la letra "M" formato currency para no usar conversiones
            var euros = pesos / 3504.19643M;
            var pounds = pesos / 3883.3333M;

            // Show results
            DollarsEntry.Text = string.Format("{0:C2}", dollars);
            PoundsEntry.Text = string.Format("{0:C2}", pounds);
            EurosEntry.Text = string.Format("{0:C2}", euros);
        }
    }
}
