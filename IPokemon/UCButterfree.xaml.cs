using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Control de usuario está documentada en https://go.microsoft.com/fwlink/?LinkId=234236

namespace IPokemon
{
    public sealed partial class UCButterfree : UserControl
    {
        DispatcherTimer dtTime;
        DispatcherTimer dtRelojVida;
        DispatcherTimer dtRelojEnergia;
        static double valor = 0.0;
        static double vida_actual = 100.0;
        public UCButterfree()
        {
            this.InitializeComponent();

            image.Visibility = Visibility.Collapsed;
            gota1.Visibility = Visibility.Collapsed;
            gota2.Visibility = Visibility.Collapsed;
            bolaFinal.Visibility = Visibility.Collapsed;
            bolaInicial.Visibility = Visibility.Collapsed;

            Storyboard sbaleteo = (Storyboard)this.Resources["sbAleteo"];
            sbaleteo.Begin();
        }


        //Método para activar las animaciones
        public void activarAtaque()
        {
            atacar();
        }
        public void activarDefensa()
        {
            defenderse();
        }
        public void recibirDaño()
        {
            ojosVivos();
            bajarEnergia();
        }
        public void verBolaPokemon(bool ver)
        {
            if (ver) pincharCaptura.Visibility = Visibility.Visible;
            else pincharCaptura.Visibility = Visibility.Collapsed;
        }
        
        /*----------------------------------------*/

        //Métodos para cambiar el valor de las barras de estado
        public double MyVida
        {
            get { return this.pbVida.Value; }
            set { this.pbVida.Value = value; }
        }

        public double MyEnergy
        {
            get { return this.pbEnergia.Value; }
            set { this.pbEnergia.Value = value; }
        }

        /*----------------------------------------*/

        //MétOdos que te permiten poner ocultas las barras de estado
        public void verBarraVida(bool ver)
        {
            if (ver) pbVida.Visibility = Visibility.Visible;
            else pbVida.Visibility = Visibility.Collapsed;
        }

        public void verBarraEnergia(bool ver)
        {
            if (ver) pbEnergia.Visibility = Visibility.Visible;
            else pbEnergia.Visibility = Visibility.Collapsed;
        }

        /*public void verFondo(bool ver)
        {
            if (ver) imFondo.Visibility = Visibility.Visible;
            else imFondo.Visibility = Visibility.Collapsed;
        }*/

        public void verNombre(bool ver)
        {
            if (ver) nombre.Visibility = Visibility.Visible;
            else nombre.Visibility = Visibility.Collapsed;
        }

        public void verIconos(bool ver)
        {
            if (ver)
            {
                imgPotionEnergia.Visibility = Visibility.Visible;
                imgPotionVida.Visibility = Visibility.Visible;
                imgVida.Visibility = Visibility.Visible;
                imgEnergia.Visibility = Visibility.Visible;
            }
            else
            {
                imgPotionEnergia.Visibility = Visibility.Collapsed;
                imgPotionVida.Visibility = Visibility.Collapsed;
                imgVida.Visibility = Visibility.Collapsed;
                imgEnergia.Visibility = Visibility.Collapsed;
            }

        }

        public void verAtaqueDefensa(bool ver)
        {
            if (ver)
            {
                vboxAtaque.Visibility= Visibility.Visible;
                vboxDefensa.Visibility = Visibility.Visible;
            }
            else
            {
                vboxAtaque.Visibility = Visibility.Collapsed;
                vboxDefensa.Visibility = Visibility.Collapsed;
            }
        }

        
        /*-----------------------------------*/

        //Métodos relacionados con la interacción y las animaciones
        private void imgPotionVida_PointerReleased(object sender, PointerRoutedEventArgs e)
        {
            dtTime = new DispatcherTimer();
            dtTime.Interval = TimeSpan.FromMilliseconds(100);
            dtTime.Tick += increaseHealth;
            dtTime.Start();
            this.imgPotionVida.Opacity = 0.5;

        }
        private void increaseHealth(object sender, object e)
        {
            this.pbVida.Value += 0.2;
            if (pbVida.Value >= 100)
            {
                this.dtTime.Stop();
                this.imgVida.Opacity = 1;
            }
            if (pbVida.Value >= 5)
            {
                ojosVivos();
                pbVida.Foreground = new SolidColorBrush(Windows.UI.Colors.Red);
            }
        }
        private void ojosVivos()
        {
            pupilaD.Visibility = Visibility.Visible;
            pupilaI.Visibility = Visibility.Visible;
            pupilaD2.Visibility = Visibility.Visible;
            pupilaI2.Visibility = Visibility.Visible;
            cruz1.Visibility = Visibility.Collapsed;
            cruz2.Visibility = Visibility.Collapsed;
        }

        private void imgPotionEnergia_PointerReleased(object sender, PointerRoutedEventArgs e)
        {
            dtTime = new DispatcherTimer();
            dtTime.Interval = TimeSpan.FromMilliseconds(100);
            dtTime.Tick += increaseEnergy;
            dtTime.Start();
            this.imgPotionEnergia.Opacity = 0.5;
            pbVida.Foreground = new SolidColorBrush(Windows.UI.Colors.Pink);
        }
        private void increaseEnergy(object sender, object e)
        {
            this.pbEnergia.Value += 0.2;
            if (pbEnergia.Value >= 100)
            {
                this.dtTime.Stop();
                this.imgEnergia.Opacity = 1;
            }
            if (pbEnergia.Value >= 5)
            {
                sudor.Visibility = Visibility.Collapsed;
                pbEnergia.Foreground = new SolidColorBrush(Windows.UI.Colors.Yellow);
            }
        }


        private void animarPataI(object sender, PointerRoutedEventArgs e)
        {
            hacerCosquillasPataI();
        }

        private void hacerCosquillasPataI()
        {
            DoubleAnimation da = new DoubleAnimation();
            Storyboard sb = new Storyboard();
            sb.Duration = new Duration(TimeSpan.FromMilliseconds(300));
            sb.Children.Add(da);
            sb.BeginTime = TimeSpan.FromSeconds(0);
            pataI.RenderTransform = (Transform)new ScaleTransform();
            Storyboard.SetTarget(da, pataI.RenderTransform);
            Storyboard.SetTargetProperty(da, "ScaleY");
            da.From = 1;
            da.To = 1.5;
            sb.AutoReverse = true;
            sb.RepeatBehavior = new RepeatBehavior(3);
            sb.Begin();
        }

        private void defendersepinchar(object sender, PointerRoutedEventArgs e)
        {
            defenderse();
        }

        private void defenderse()
        {
            Storyboard sbVolar = (Storyboard)this.Resources["sbVolar"];
            sbVolar.Begin();

            Storyboard sbojoD = (Storyboard)this.pupilaD.Resources["StbPupilaDRoja"];
            sbojoD.Begin();

            Storyboard sbojoI = (Storyboard)this.pupilaI.Resources["StbPupilaIRoja"];
            sbojoI.Begin();

            bajarVida();
        }

        private void atacarpinchar(object sender, PointerRoutedEventArgs e)
        {
            atacar();

        }

        private void atacar()
        {
            image.Visibility = Visibility.Visible;

            Storyboard sbVeneno = (Storyboard)this.Resources["sbVeneno"];
            sbVeneno.Begin();

            Storyboard sbGotas = (Storyboard)this.Resources["sbGotas"];
            sbGotas.Begin();

            bajarEnergia();
        }

        private void bajarEnergia()
        {
            dtRelojEnergia = new DispatcherTimer();
            dtRelojEnergia.Interval = TimeSpan.FromMilliseconds(100);
            dtRelojEnergia.Tick += reducirBarraEnergia;
            dtRelojEnergia.Start();
        }

        private void reducirBarraEnergia(object sender, object e)
        {
            this.pbEnergia.Value -= 0.1;
            if (pbEnergia.Value == 0)
            {
                dtRelojEnergia.Stop();
            }
            if (pbEnergia.Value <= 5)
            {
                pbEnergia.Foreground = new SolidColorBrush(Windows.UI.Colors.Gray);
                sudor.Visibility = Visibility.Visible;
            }
        }
        private void bajarVida()
        {
            dtRelojVida = new DispatcherTimer();
            dtRelojVida.Interval = TimeSpan.FromMilliseconds(100);
            dtRelojVida.Tick += reducirBarraVida;
            dtRelojVida.Start();
        }

        private void reducirBarraVida(object sender, object e)
        {
            this.pbVida.Value -= 0.1;
            if (pbVida.Value == 0)
            {
                dtRelojVida.Stop();
            }
            if (pbVida.Value <= 5)
            {
                pbVida.Foreground = new SolidColorBrush(Windows.UI.Colors.Gray);
            }
            if (pbVida.Value == 0)
            {
                ojosMuertos();
            }
        }

        private void ojosMuertos()
        {
            pupilaD.Visibility = Visibility.Collapsed;
            pupilaI.Visibility = Visibility.Collapsed;
            pupilaD2.Visibility = Visibility.Collapsed;
            pupilaI2.Visibility = Visibility.Collapsed;
            cruz1.Visibility = Visibility.Visible;
            cruz2.Visibility = Visibility.Visible;
        }

        private void CapturarClick(object sender, PointerRoutedEventArgs e)
        {
            capturar();

        }

        private void capturar()
        {
            bolaInicial.Visibility = Visibility.Visible;
            //pincharCaptura.Visibility = Visibility.Collapsed;

            Storyboard sbCapturar = (Storyboard)this.Resources["sbCapturar"];
            sbCapturar.Begin();

        }
    }
}
