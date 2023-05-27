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
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace IPokemon
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class ManualDelJuego : Page
    {
        private BitmapImage IdiomaEsp = new BitmapImage(new Uri("ms-appx:///Assets/Manual iPOkemon.png"));
        private BitmapImage IdiomaIngles = new BitmapImage(new Uri("ms-appx:///Assets/Manual iPokemon INGLES.png"));
        public ManualDelJuego()
        {
            this.InitializeComponent();
        }

        private void BtnVolverInicio_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(InicioIPOkemon));
        }

        private void BtnEspañol_Click(object sender, RoutedEventArgs e)
        {
            ManualJuego.Source = IdiomaEsp;
            
        }

        private void BtnInglés_Click(object sender, RoutedEventArgs e)
        {
            ManualJuego.Source = IdiomaIngles;
        }
    }
}
