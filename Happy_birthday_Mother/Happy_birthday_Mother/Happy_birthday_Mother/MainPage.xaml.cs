using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Happy_birthday_Mother
{
    public partial class MainPage : ContentPage
    {
        public string[] iMAGEmINIONS = new string[] { "hhfghf.jpg",
                                                    "Cakes.jpg" , "dad.jpg" , " " };
        public MainPage()
        {
            InitializeComponent();

            ImageSlide.ItemsSource = iMAGEmINIONS;

            ImageSlide.PositionChanged += ImageSlide_PositionChanged;


        }

        private void ImageSlide_PositionChanged(object sender, PositionChangedEventArgs e)
        {
            MinionsGIF.IsVisible = e.CurrentPosition == iMAGEmINIONS.Length - 1;
        }
    }
}
