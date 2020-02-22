using Microsoft.AspNet.SignalR.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TestSignalR
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Task.Delay(1000).ContinueWith((a,b)=>
            {
                SetupSignalR();
            }, null);
        }
        
        private async void SetupSignalR()
        {
            var Cnn = new HubConnection("https://www.66un.net/");

            //next line cause Cnn.Start() throw exception
            Cnn.Headers.Add("User-Agent", "Mozilla/5.0 (iPhone; CPU iPhone OS 13_3 like Mac OS X) AppleWebKit/605.1.15 (KHTML, like Gecko) Mobile/15E148");

            Cnn.Headers.Add("Cookie", "ARRAffinity=301635a774435c46751addf8f5bd10e1dfe31d791e68e3dac07c260a6dc85432; .ASPXAUTH=WzSNDvw5iw9dYbAzePNw5kdjAoNaUv1ba8O7yLa%2B14ZpZPjn7kRIV8DkPMxncIBbDy%2BdR9PXrYqHCBtzEhEKEw%3D%3D; .ASPXAUTH.member=; .ASPXAUTH.user=lyF9fVgHS3TGk8xzRtFiBWpyx6%2FKQ8ZvJuuZokOWwW4%3D");

            await Cnn.Start();  //iOS throw exception: null reference
        }
    }
}
