using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App10
{
    public partial class MainPage : CarouselPage
    {
        int un;
        int op = 0;

        public MainPage()
        {
            InitializeComponent();
            Ab.Source = new UriImageSource
            {
                Uri = new Uri("https://queeselalcoholismo.files.wordpress.com/2012/07/mickey-mouse.jpg")
            };
            fg.Source = new UriImageSource
            {
                Uri = new Uri("https://i.pinimg.com/736x/c1/2f/ec/c12fecf035f52d502a3f05e86745894c--babyshower-cute-giraffe.jpg")
            };
            hi.Source = new UriImageSource
            {
                Uri = new Uri("https://i.pinimg.com/736x/f3/68/83/f36883f77619c6563f50ebf0a3f89c2e--cat-clipart-animals-and-birds.jpg")
            };

        }
        private void gus1_Clicked(object sender, EventArgs o)
        {
            op = op + 1;
           
            op = int.Parse(caja.Text);
            caja.Text = null;
        }
        private void gus2_Clicked(object sender, EventArgs o)
        {
            
        }
        private void gus3_Clicked(object sender, EventArgs o)
        {
            

        }
        private void gus4_Clicked(object sender, EventArgs o)
        {
            op = op + 1;

        }
        private void gus5_Clicked(object sender, EventArgs o)
        {
            op = op + 1;

        }
        private void gus6_Clicked(object sender, EventArgs o)
        {
            op = op + 1;

        }
        private void gus7_Clicked(object sender, EventArgs o)
        {
            op = op + 1;

        }
        private void gus8_Clicked(object sender, EventArgs o)
        {
            op = op + 1;

        }
        private void gus9_Clicked(object sender, EventArgs o)
        {
            op = op + 1;

        }
        private void gus10_Clicked(object sender, EventArgs o)
        {
            op = op + 1;

        }
        private void nogus1_Clicked(object sender, EventArgs o)
        {
            un = un + 1;

        }
        private void nogus2_Clicked(object sender, EventArgs o)
        {
            un = un + 1;

        }
        private void nogus3_Clicked(object sender, EventArgs o)
        {
            un = un + 1;

        }
        private void nogus4_Clicked(object sender, EventArgs o)
        {
            un = un + 1;

        }
        private void nogus5_Clicked(object sender, EventArgs o)
        {
            un = un + 1;

        }
        private void nogus6_Clicked(object sender, EventArgs o)
        {
            un = un + 1;

        }
        private void nogus7_Clicked(object sender, EventArgs o)
        {
            un = un + 1;

        }
        private void nogus8_Clicked(object sender, EventArgs o)
        {
            un = un + 1;

        }
        private void nogus9_Clicked(object sender, EventArgs o)
        {
            un = un + 1;

        }
        private void nogus10_Clicked(object sender, EventArgs o)
        {
            un = un + 1;

        }


    }
}
