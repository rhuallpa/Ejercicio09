using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ejercicio09
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            tareacss.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new tareacss());
            };
            ExplicitC.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new ExplicitControlDemo());
            };
            Explicit.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new ExplicitDemo());
            };
            ImplicitC.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new ImplicitControlDemo());
            };
            Implicit.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new ImplicitDemo());
            };
            Global.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new globaldemo());
            };
            Inherente.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new InheritanceDemo());
            };
            Dynamic.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new DynamicDemo());
            };
        }
    }
}
