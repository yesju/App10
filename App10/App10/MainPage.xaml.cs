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
        int imagA;
        int imagBB;
        int imagC;
        int imagCB;
        int imagD;
        int imagDB;
        int imagE;
        int imagEB;
        int imagF;
        int imagFB;
        int imagG;
        int imagGB;
        int imagH;
        int imagHB;
        int imagI;
        int imagIB;
        int imagJ;
        int imagJB;
        int imagK;
        int imagKB;
        int resultado;

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
            imagA = 1;
            if (imagA == 1)
            {
                resultado = resultado + 1;


            }
        }
        private void gus2_Clicked(object sender, EventArgs o)
        {
            imagC = 1;
            if (imagC == 1)
            {
                resultado = resultado + 1;


            }
        }
        private void gus3_Clicked(object sender, EventArgs o)
        {
            imagD = 1;
            if (imagD == 1)
            {
                resultado = resultado + 1;


            }

        }
        private void gus4_Clicked(object sender, EventArgs o)
        {
            imagE = 1;
            if (imagE == 1)
            {
                resultado = resultado + 1;


            }

        }
        private void gus5_Clicked(object sender, EventArgs o)
        {
            imagF = 1;
            if (imagF == 1)
            {
                resultado = resultado + 1;


            }

        }
        private void gus6_Clicked(object sender, EventArgs o)
        {
            imagG = 1;
            if (imagG == 1)
            {
                resultado = resultado + 1;


            }

        }
        private void gus7_Clicked(object sender, EventArgs o)
        {
            imagH = 1;
            if (imagH == 1)
            {
                resultado = resultado + 1;


            }

        }
        private void gus8_Clicked(object sender, EventArgs o)
        {
            imagI = 1;
            if (imagI == 1)
            {
                resultado = resultado + 1;


            }

        }
        private void gus9_Clicked(object sender, EventArgs o)
        {
            imagJ = 1;
            if (imagJ == 1)
            {
                resultado = resultado + 1;


            }

        }
        private void gus10_Clicked(object sender, EventArgs o)
        {
            imagK = 1;
            if (imagK == 1)
            {
                resultado = resultado + 1;


            }

        }
        private void nogus1_Clicked(object sender, EventArgs o)
        {
            imagBB = 0;
            if (imagBB == 0)
            {
                resultado = resultado + 0;
            }

        }
        private void nogus2_Clicked(object sender, EventArgs o)
        {
            imagCB = 0;
            if (imagCB == 0)
            {
                resultado = resultado + 0;
            }

        }
        private void nogus3_Clicked(object sender, EventArgs o)
        {
            imagDB = 0;
            if (imagDB == 0)
            {
                resultado = resultado + 0;
            }

        }
        private void nogus4_Clicked(object sender, EventArgs o)
        {
            imagEB = 0;
            if (imagEB == 0)
            {
                resultado = resultado + 0;
            }

        }
        private void nogus5_Clicked(object sender, EventArgs o)
        {
            imagFB = 0;
            if (imagFB == 0)
            {
                resultado = resultado + 0;
            }

        }
        private void nogus6_Clicked(object sender, EventArgs o)
        {
            imagGB = 0;
            if (imagGB == 0)
            {
                resultado = resultado + 0;
            }

        }
        private void nogus7_Clicked(object sender, EventArgs o)
        {
            imagHB = 0;
            if (imagHB == 0)
            {
                resultado = resultado + 0;
            }
        }
        private void nogus8_Clicked(object sender, EventArgs o)
        {
            imagIB = 0;
            if (imagIB == 0)
            {
                resultado = resultado + 0;
            }

        }
        private void nogus9_Clicked(object sender, EventArgs o)
        {
            imagJB = 0;
            if (imagJB == 0)
            {
                resultado = resultado + 0;
            }

        }
        private void nogus10_Clicked(object sender, EventArgs o)
        {
            imagKB = 0;
            if (imagKB == 0)
            {
                resultado = resultado + 0;
            }

        }
        private void Evaluar_Clicked(object sender, EventArgs e)
        {
            if (imagA == 1)
            {
                DisplayAlert("", "Imagen 1 Me Gusta", "OK");
            }
            else
            {
                DisplayAlert("", "Imagen 1 Sin dato", "OK");
            }


            if (imagC == 1)
            {
                DisplayAlert("", "Imagen 2 Me Gusta", "OK");
            }
            else
            {
                DisplayAlert("", "Imagen 2 Sin dato", "OK");
            }

            if (imagD == 1)
            {
                DisplayAlert("", "Imagen 3 Me Gusta", "OK");
            }
            else
            {
                DisplayAlert("", "Imagen 3 Sin dato", "OK");
            }
            if (imagE == 1)
            {
                DisplayAlert("", "Imagen 4 Me Gusta", "OK");
            }
            else
            {
                DisplayAlert("", "Imagen 4 Sin dato", "OK");
            }
            if (imagF == 1)
            {
                DisplayAlert("", "Imagen 5 Me Gusta", "OK");
            }
            else
            {
                DisplayAlert("", "Imagen 5 Sin dato", "OK");
            }
            if (imagG == 1)
            {
                DisplayAlert("", "Imagen 6 Me Gusta", "OK");
            }
            else
            {
                DisplayAlert("", "Imagen 6 Sin dato", "OK");
            }
            if (imagH == 1)
            {
                DisplayAlert("", "Imagen 7 Me Gusta", "OK");
            }
            else
            {
                DisplayAlert("", "Imagen 7 Sin dato", "OK");
            }
            if (imagI == 1)
            {
                DisplayAlert("", "Imagen 8 Me Gusta", "OK");
            }
            else
            {
                DisplayAlert("", "Imagen 8 Sin dato", "OK");
            }
            if (imagJ == 1)
            {
                DisplayAlert("", "Imagen 9 Me Gusta", "OK");
            }
            else
            {
                DisplayAlert("", "Imagen 9 Sin dato", "OK");
            }
            if (imagK == 1)
            {
                DisplayAlert("", "Imagen 10 Me Gusta", "OK");
            }
            else
            {
                DisplayAlert("", "Imagen 10 Sin dato", "OK");
            }

        }

        private void EvaluarDL_Clicked(object sender, EventArgs e)
        {
            if (imagBB == 0)
            {
                DisplayAlert("", "Imagen 1 No Me Gusta", "OK");
            }
            else
            {
                DisplayAlert("", "Imagen 1 Sin dato", "OK");
            }

            if (imagCB == 0)
            {
                DisplayAlert("", "Imagen 2 No Me Gusta", "OK");
            }
            else
            {
                DisplayAlert("", "Imagen 2 Sin dato", "OK");
            }

            if (imagDB == 0)
            {
                DisplayAlert("", "Imagen 3 No Me Gusta", "OK");
            }
            else
            {
                DisplayAlert("", "Imagen 3 Sin dato", "OK");
            }

            if (imagEB == 0)
            {
                DisplayAlert("", "Imagen 4 No Me Gusta", "OK");
            }
            else
            {
                DisplayAlert("", "Imagen 4 Sin dato", "OK");
            }

            if (imagFB == 0)
            {
                DisplayAlert("", "Imagen 5 No Me Gusta", "OK");
            }
            else
            {
                DisplayAlert("", "Imagen 5 Sin dato", "OK");
            }

            if (imagGB == 0)
            {
                DisplayAlert("", "Imagen 6 No Me Gusta", "OK");
            }
            else
            {
                DisplayAlert("", "Imagen 6 Sin dato", "OK");
            }

            if (imagHB == 0)
            {
                DisplayAlert("", "Imagen 7 No Me Gusta", "OK");
            }
            else
            {
                DisplayAlert("", "Imagen 7 Sin dato", "OK");
            }

            if (imagIB == 0)
            {
                DisplayAlert("", "Imagen 8 No Me Gusta", "OK");
            }
            else
            {
                DisplayAlert("", "Imagen 9 Sin dato", "OK");
            }

            if (imagJB == 0)
            {
                DisplayAlert("", "Imagen 9 No Me Gusta", "OK");
            }
            else
            {
                DisplayAlert("", "Imagen 9 Sin dato", "OK");
            }

            if (imagKB == 0)
            {
                DisplayAlert("", "Imagen 10 No Me Gusta", "OK");
            }
            else
            {
                DisplayAlert("", "Imagen 10 Sin dato", "OK");
            }


        }



    }
}
