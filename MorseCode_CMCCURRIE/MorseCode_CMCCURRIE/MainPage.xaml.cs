using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MorseCode_CMCCURRIE
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private string dotsDashes = "";
        private string message = "";
        void DotMethod(object sender, System.EventArgs e)
        {
            dotsDashes += ".";
            dotsndashes.Text = dotsDashes;
        }

        void DashMethod(object sender, System.EventArgs e)
        {
            dotsDashes += "-";
            dotsndashes.Text = dotsDashes;
        }

        void GapMethod(object sender, System.EventArgs e)
        {
            message += Morse.MorseCoder(dotsDashes);
            english.Text = message;
            dotsDashes = ""; 
        }
    }
}