using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace KxamarinToolkit
{
    public partial class MediaElementPage : ContentPage
    {
        
        public MediaElementPage()
        {

            
            InitializeComponent();
        }
        
        void OnMediaOpened(object sender, EventArgs e) => Console.WriteLine("Media opened.");

        void OnMediaFailed(object sender, EventArgs e) => Console.WriteLine("Media failed.");

        void OnMediaEnded(object sender, EventArgs e) => Console.WriteLine("Media ended.");

        void OnSeekCompleted(object sender, EventArgs e) => Console.WriteLine("Seek completed.");

        void OnResetClicked(object sender, EventArgs e) => mediaElement.Source = null;


        async Task OnPipAsync(object sender, EventArgs e) {
            _ = await DependencyService.Get<IPipService>().ActivePip(mediaElement);

        }


        private void Slider_DragCompleted(object sender, EventArgs e)
        {
            mediaElement.Speed = MainSlider.Value;
        }

        async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            if(Device.RuntimePlatform== Device.Android)
            {
                _ = await DependencyService.Get<IPipService>().ActivePip(mediaElement);

            }

        }
    }
}
