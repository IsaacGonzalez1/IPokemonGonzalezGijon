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
    public sealed partial class InfoFuecoco : Page
    {
        public InfoFuecoco()
        {
            this.InitializeComponent();
        }

        private void BtnVolverPokedex_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(PokeDexPage));
        }

        private async void pinFuecoco(object sender, PointerRoutedEventArgs e)
        {
            SecondaryTile myTile = new SecondaryTile("Favorito", "Dos", "Tres",
           new Uri("ms-appx:///Assets/Fuecoco.png"),
           Windows.UI.StartScreen.TileSize.Square150x150);
            myTile.DisplayName = "Fuecoco";
            myTile.VisualElements.ShowNameOnSquare150x150Logo = true;
            await myTile.RequestCreateAsync();
        }

        private void idiomaIngClick1(object sender, RoutedEventArgs e)
        {
            alturaTextEsp.Visibility = Visibility.Collapsed;
            alturaTextIng.Visibility = Visibility.Visible;
            pesoTextEsp.Visibility = Visibility.Collapsed;
            pesoTextIng.Visibility = Visibility.Visible;
            sexoTextEsp.Visibility = Visibility.Collapsed;
            sexoTextIng.Visibility = Visibility.Visible;
            catTextEsp.Visibility = Visibility.Collapsed;
            catTextIng.Visibility = Visibility.Visible;
            habTextEsp.Visibility = Visibility.Collapsed;
            habTextIng.Visibility = Visibility.Visible;
            debilTextEsp.Visibility = Visibility.Collapsed;
            debilTextIng.Visibility = Visibility.Visible;
            evlTextEsp.Visibility = Visibility.Collapsed;
            evlTextIng.Visibility = Visibility.Visible;
            tipoTextEsp.Visibility = Visibility.Collapsed;
            tipoTextIng.Visibility = Visibility.Visible;
            fuegoEsp.Visibility = Visibility.Collapsed;
            fuegoIng.Visibility = Visibility.Visible;
            masculinoEsp.Visibility = Visibility.Collapsed;
            masculinoIng.Visibility = Visibility.Visible;
            aguaEsp.Visibility = Visibility.Collapsed;
            aguaIng.Visibility = Visibility.Visible;
            tierraEsp.Visibility = Visibility.Collapsed;
            tierraIng.Visibility = Visibility.Visible;
            rocaTextEsp.Visibility = Visibility.Collapsed;
            rocaTextIng.Visibility = Visibility.Visible;
            ascuasTextEsp.Visibility = Visibility.Collapsed;
            ascuasTextIng.Visibility = Visibility.Visible;
            alturaEsp.Visibility = Visibility.Collapsed;
            alturaIng.Visibility = Visibility.Visible;
            kilosEsp.Visibility = Visibility.Collapsed;
            kilosIng.Visibility = Visibility.Visible;
            fuegodriloEsp.Visibility = Visibility.Collapsed;
            fuegodriloIng.Visibility = Visibility.Visible;
            BtnVolverPokedex.Visibility = Visibility.Collapsed;
            BtnVolverPokedexIng.Visibility = Visibility.Visible;

        }

        private void btnVolverPokedexIngClick(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(PokeDexPage));
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
            fuegoEsp.Visibility = Visibility.Visible;
            fuegoIng.Visibility = Visibility.Collapsed;
            masculinoEsp.Visibility = Visibility.Visible;
            masculinoIng.Visibility = Visibility.Collapsed;
            aguaEsp.Visibility = Visibility.Visible;
            aguaIng.Visibility = Visibility.Collapsed;
            tierraEsp.Visibility = Visibility.Visible;
            tierraIng.Visibility = Visibility.Collapsed;
            rocaTextEsp.Visibility = Visibility.Visible;
            rocaTextIng.Visibility = Visibility.Collapsed;
            ascuasTextEsp.Visibility = Visibility.Visible;
            ascuasTextIng.Visibility = Visibility.Collapsed;
            alturaEsp.Visibility = Visibility.Visible;
            alturaIng.Visibility = Visibility.Collapsed;
            kilosEsp.Visibility = Visibility.Visible;
            kilosIng.Visibility = Visibility.Collapsed;
            fuegodriloEsp.Visibility = Visibility.Visible;
            fuegodriloIng.Visibility = Visibility.Collapsed;
            BtnVolverPokedex.Visibility = Visibility.Visible;
            BtnVolverPokedexIng.Visibility = Visibility.Collapsed;

        }

        private void btnPlacajeIngClick(object sender, RoutedEventArgs e)
        {
            ucFuecocoPokedex.placaje();
        }

        private void btnAscuasIngClick(object sender, RoutedEventArgs e)
        {
            ucFuecocoPokedex.ascuas();
        }

        private void btnDanzaIngClick(object sender, RoutedEventArgs e)
        {
            ucFuecocoPokedex.danza();
        }

        private void btnMordiscoIngClick(object sender, RoutedEventArgs e)
        {
            ucFuecocoPokedex.mordisco();
        }

        private void btnDanioIngClick(object sender, RoutedEventArgs e)
        {
            ucFuecocoPokedex.recibirdaño();
        }
    }
  
}
