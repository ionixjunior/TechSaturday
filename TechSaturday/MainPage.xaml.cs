using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AppCenter.Analytics;
using Xamarin.Forms;

namespace TechSaturday
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void VerParticipantesClicked(System.Object sender, System.EventArgs e)
        {
            Analytics.TrackEvent("Ver participantes");
        }

        void NaoCliqueClicked(System.Object sender, System.EventArgs e)
        {
            var random = new Random();
            if (random.Next(1, 10) <= 2)
                throw new Exception("Falei para não clicar!");

            Analytics.TrackEvent("Não clique!");
        }

        void VerOnlineClicked(System.Object sender, System.EventArgs e)
        {
            Analytics.TrackEvent("Ver online");
        }
    }
}
