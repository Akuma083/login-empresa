using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace login
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Entry_Focused(object sender, FocusEventArgs e)
        {
            Empresa.Stroke = Color.FromHex("#ce6767");
        }

        private void Entry_Unfocused(object sender, FocusEventArgs e)
        {
            Empresa.Stroke = Color.FromHex("#c7cdd2");
        }

        private void Entry_Focused_1(object sender, FocusEventArgs e)
        {
            Usuario.Stroke = Color.FromHex("#ce6767");
        }

        private void Entry_Unfocused_1(object sender, FocusEventArgs e)
        {
            Usuario.Stroke = Color.FromHex("#c7cdd2");
        }

        private void Entry_Focused_2(object sender, FocusEventArgs e)
        {
            Password.Stroke = Color.FromHex("#ce6767");
        }

        private void Entry_Unfocused_2(object sender, FocusEventArgs e)
        {
            Password.Stroke = Color.FromHex("#c7cdd2");
        }
    }
}
