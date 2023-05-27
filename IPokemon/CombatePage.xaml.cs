using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace IPokemon
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class CombatePage : Page
    {
       
        public CombatePage()
        {
            this.InitializeComponent();

            this.UCButterfreeCombate.verNombre(false);
            this.UCFuecocoCombate.verIconos(false);
            this.UCButterfreeCombate.verIconos(false);

            this.UCFuecocoCombate.MyVida = 100.0;
            this.UCButterfreeCombate.MyVida = 100.0;

            this.UCButterfreeCombate.verBolaPokemon(false);
            this.UCFuecocoCombate.verBolaPokemon(false);

        }

        private async Task winButterfree()
        {


            if (this.UCFuecocoCombate.MyVida <= 0.0)
            {
                UCFuecocoCombate.verIconos(false);
                await Task.Delay(TimeSpan.FromSeconds(5));
                ganaFuecoco.Visibility= Visibility.Collapsed;
                btnRepetirCombate.Visibility = Visibility.Visible;
                
            }
            
        }
        private async Task winFuecoco()
        {


            if (this.UCButterfreeCombate.MyVida <= 0.0)
            {
                UCButterfreeCombate.verIconos(false);
                await Task.Delay(TimeSpan.FromSeconds(5));
                ganaButterfree.Visibility = Visibility.Visible;
                btnRepetirCombate.Visibility = Visibility.Visible;
                UCFuecocoCombate.celebrarVictoria();

            }
        }

        private void FuecoAtaqueClick(object sender, RoutedEventArgs e)
        {
            UCFuecocoCombate.activarAtaque();
            UCButterfreeCombate.recibirDaño();

            if (this.UCButterfreeCombate.MyVida <= 0.0)
            {
                winFuecoco();
            }
            if (this.UCButterfreeCombate.MyEnergy <= 0.0)
            {
                winFuecoco();
            }

         }

        private void ataqueButterfreeClick(object sender, RoutedEventArgs e)
        {
            UCButterfreeCombate.activarAtaque();
            UCFuecocoCombate.recibirDaño();

            if (this.UCFuecocoCombate.MyVida <= 0.0)
            {
                winButterfree();
            }
            if(this.UCFuecocoCombate.MyEnergy<= 0.0)
            {
                winButterfree();
            }
        }

        private void defensaFuecocoClick(object sender, RoutedEventArgs e)
        {
            UCFuecocoCombate.activarDefensa();
        }

        private void defensaButterfreeClick(object sender, RoutedEventArgs e)
        {
            UCButterfreeCombate.activarDefensa();
        }

        private void btnRepetirClick(object sender, RoutedEventArgs e)
        {
            ganaButterfree.Visibility   = Visibility.Collapsed;
            ganaFuecoco.Visibility = Visibility.Collapsed;  
            btnRepetirCombate.Visibility = Visibility.Collapsed;
            this.UCFuecocoCombate.MyVida = 100.0;
            this.UCButterfreeCombate.MyVida = 100.0;
        }
    }
}
