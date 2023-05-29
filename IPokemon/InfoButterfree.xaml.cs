using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.StartScreen;
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
    public sealed partial class InfoButterfree : Page
    {
        public InfoButterfree()
        {
            this.InitializeComponent();
        }

        private void BtnVolverPokedex_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(PokeDexPage));
        }

        private async void pinButterfree(object sender, PointerRoutedEventArgs e)
        {
            SecondaryTile myTile = new SecondaryTile("Favorito", "Dos", "Tres",
           new Uri("ms-appx:///Assets/butterfree.png"),
           Windows.UI.StartScreen.TileSize.Square150x150);
            myTile.DisplayName = "Butterfree";
            myTile.VisualElements.ShowNameOnSquare150x150Logo = true;
            await myTile.RequestCreateAsync();
        }

        private void idiomaIngClick(object sender, RoutedEventArgs e)
        {
            alturaTextEsp.Visibility= Visibility.Collapsed;
            alturaTextIng.Visibility = Visibility.Visible;
            pesoTextEsp.Visibility= Visibility.Collapsed;
            pesoTextIng.Visibility = Visibility.Visible;
            sexoTextEsp.Visibility= Visibility.Collapsed;
            sexoTextIng.Visibility = Visibility.Visible;
            catTextEsp.Visibility= Visibility.Collapsed;
            catTextIng.Visibility= Visibility.Visible;
            habTextEsp.Visibility= Visibility.Collapsed;
            habTextIng.Visibility = Visibility.Visible;
            debilTextEsp.Visibility= Visibility.Collapsed;
            debilTextIng.Visibility= Visibility.Visible;
            evlTextEsp.Visibility= Visibility.Collapsed;
            evlTextIng.Visibility= Visibility.Visible;
            tipoTextEsp.Visibility= Visibility.Collapsed;
            tipoTextIng.Visibility= Visibility.Visible;
            bichoCuadroEsp.Visibility= Visibility.Collapsed;
            bichoCuadroIng.Visibility= Visibility.Visible;
            hembraTextEsp.Visibility= Visibility.Collapsed;
            hembraTextIng.Visibility = Visibility.Visible;
            hieloEsp.Visibility= Visibility.Collapsed;
            hieloIng.Visibility= Visibility.Visible;
            fuegoEsp.Visibility= Visibility.Collapsed;
            fuegoIng.Visibility= Visibility.Visible;
            rocaEsp.Visibility= Visibility.Collapsed;
            rocaIng.Visibility= Visibility.Visible;
            alturaEsp.Visibility= Visibility.Collapsed;
            alturaIng.Visibility = Visibility.Visible;
            voladorEsp.Visibility= Visibility.Collapsed;
            voladorIng.Visibility= Visibility.Visible;
            kilosEsp.Visibility= Visibility.Collapsed;
            kilosIng.Visibility = Visibility.Visible;
            mariposaEsp.Visibility= Visibility.Collapsed;
            mariposaIng.Visibility= Visibility.Visible;
            ojocompEsp.Visibility= Visibility.Collapsed;
            ojocompIng.Visibility= Visibility.Visible;
            BtnVolverPokedexEsp.Visibility= Visibility.Collapsed;
            BtnVolverPokedexIng.Visibility = Visibility.Visible;
        }

        private void idiomaEspClick(object sender, RoutedEventArgs e)
        {
            alturaTextEsp.Visibility = Visibility.Visible;
            alturaTextIng.Visibility = Visibility.Collapsed;
            pesoTextEsp.Visibility = Visibility.Visible;
            pesoTextIng.Visibility = Visibility.Collapsed;
            sexoTextEsp.Visibility = Visibility.Visible;
            sexoTextIng.Visibility = Visibility.Collapsed;
            catTextEsp.Visibility = Visibility.Visible;
            catTextIng.Visibility = Visibility.Collapsed;
            habTextEsp.Visibility = Visibility.Visible;
            habTextIng.Visibility = Visibility.Collapsed;
            debilTextEsp.Visibility = Visibility.Visible;
            debilTextIng.Visibility = Visibility.Collapsed;
            evlTextEsp.Visibility = Visibility.Visible;
            evlTextIng.Visibility = Visibility.Collapsed;
            tipoTextEsp.Visibility = Visibility.Visible;
            tipoTextIng.Visibility = Visibility.Collapsed;
            bichoCuadroEsp.Visibility = Visibility.Visible;
            bichoCuadroIng.Visibility = Visibility.Collapsed;
            hembraTextEsp.Visibility = Visibility.Visible;
            hembraTextIng.Visibility = Visibility.Collapsed;
            hieloEsp.Visibility = Visibility.Visible;
            hieloIng.Visibility = Visibility.Collapsed;
            fuegoEsp.Visibility = Visibility.Visible;
            fuegoIng.Visibility = Visibility.Collapsed;
            rocaEsp.Visibility = Visibility.Visible;
            rocaIng.Visibility = Visibility.Collapsed;
            alturaEsp.Visibility = Visibility.Visible;
            alturaIng.Visibility = Visibility.Collapsed;
            voladorEsp.Visibility = Visibility.Visible;
            voladorIng.Visibility = Visibility.Collapsed;
            kilosEsp.Visibility = Visibility.Visible;
            kilosIng.Visibility = Visibility.Collapsed;
            mariposaEsp.Visibility = Visibility.Visible;
            mariposaIng.Visibility = Visibility.Collapsed;
            ojocompEsp.Visibility = Visibility.Visible;
            ojocompIng.Visibility = Visibility.Collapsed;
            BtnVolverPokedexEsp.Visibility = Visibility.Visible;
            BtnVolverPokedexIng.Visibility = Visibility.Collapsed;
        }

        private void BtnVolverPokedexIng_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(PokeDexPage));
        }
    }
}
