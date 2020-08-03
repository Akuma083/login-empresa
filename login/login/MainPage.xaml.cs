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

        private void Entry_Unfocused(object sender, FocusEventArgs e) => Empresa.Stroke = Color.FromHex("#c7cdd2");


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

        private void ModifyStrokeColor()
        {

        }
        private void EntryTextChanged(object sender, TextChangedEventArgs e) => Validate();
       
        
        private void Validate() => buttonlogin.IsEnabled = ValidateField(EntryEmpresa.Text)
                && ValidateField(EntryPass.Text)
                && ValidateField(EntryUser.Text);

        //para q se active el button apartir de 3 caracteres

        // asignando la cantidad d caracteres
        private bool ValidateField(string field) => !string.IsNullOrWhiteSpace(field) && field.Trim().Length >= 5;

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e) => Xamarin.Essentials.Browser.OpenAsync("https://www.google.com");

        private void buttonlogin_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage.Navigation.PushAsync(new Page());
        }
    }

}
