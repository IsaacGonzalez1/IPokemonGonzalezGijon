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
    public sealed partial class InicioIPOkemon : Page
    {
        private BitmapImage IdiomaEspInicio = new BitmapImage(new Uri("ms-appx:///Assets/Panel Nombre IPOkedex INICIO.png"));
        private BitmapImage IdiomaInglesInicio = new BitmapImage(new Uri("ms-appx:///Assets/Panel Inicio Inglés.png"));
        public InicioIPOkemon()
        {
            this.InitializeComponent();
        }

        private void BtnInicioEspañol_Click(object sender, RoutedEventArgs e)
        {
            InicioInfo.Source = IdiomaEspInicio;
        }

        private void BtnInicioIngles_Click(object sender, RoutedEventArgs e)
        {
            InicioInfo.Source = IdiomaInglesInicio;
        }
    }
}
