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
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace IPokemon
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class CapturaPokemon : Page
    {
        public CapturaPokemon()
        {
            this.InitializeComponent();
            BtnVolverCaptura.Visibility = Visibility.Collapsed;
            this.ucFuegococoCapturar.verIconos(false);
            this.ucButterfreeCapturar.verAtaqueDefensa(false);
        }


        private void btnVolverCaptura_click(object sender, RoutedEventArgs e)
        {
            btnCapButterfree.Visibility = Visibility.Visible;
            btnCapFuecoco.Visibility = Visibility.Visible;
            btnCapPregunta.Visibility = Visibility.Visible;
            ucButterfreeCapturar.Visibility = Visibility.Collapsed;
            ucFuegococoCapturar.Visibility = Visibility.Collapsed;
            BtnVolverCaptura.Visibility = Visibility.Collapsed;
        }

        private void btnCapturarButterfree_Click(object sender, RoutedEventArgs e)
        {
            btnCapButterfree.Visibility = Visibility.Collapsed;
            btnCapFuecoco.Visibility = Visibility.Collapsed;
            btnCapPregunta.Visibility = Visibility.Collapsed;
            ucButterfreeCapturar.Visibility = Visibility.Visible;
            BtnVolverCaptura.Visibility = Visibility.Visible;
        }

        private void btnCapturarFuecoco_Click(object sender, RoutedEventArgs e)
        {
            btnCapButterfree.Visibility = Visibility.Collapsed;
            btnCapFuecoco.Visibility = Visibility.Collapsed;
            btnCapPregunta.Visibility = Visibility.Collapsed;
            ucFuegococoCapturar.Visibility = Visibility.Visible;
            BtnVolverCaptura.Visibility = Visibility.Visible;
        }
    }
}
