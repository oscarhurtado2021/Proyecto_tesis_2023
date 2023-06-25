﻿using System.Collections.Generic;
using System.Threading.Tasks;
using FFImageLoading.Forms;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Xamarin.Forms.Xaml;

namespace Proyecto_tesis_2023.View.Tabbed
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Inicio : ContentPage
    {
        private List<string> gifUrls = new List<string>
        {
            "futbol_inicio.gif",
            "voley_inicio.gif",
            "squash_inicio.gif",
            "pinpong_inicio.gif"
        };
        private int currentIndex = 0;

        public Inicio()
        {
            InitializeComponent();
            ChangeImageAfterDelay();
        }

        private async Task ChangeImageAfterDelay()
        {
            while (true)
            {
                await Task.Delay(3000); // Espera 3 segundos

                Device.BeginInvokeOnMainThread(() =>
                {
                    mainImage.Source = ImageSource.FromFile(gifUrls[currentIndex]); // Cambia la imagen

                    currentIndex++;
                    if (currentIndex >= gifUrls.Count)
                        currentIndex = 0;
                });
            }
        }

        private  async void btn_dots_Clicked(object sender, System.EventArgs e)
        {
            await DisplayAlert("Mensaje","Mensaje de prueba","Cancelar"); 
        }

       
    }
}