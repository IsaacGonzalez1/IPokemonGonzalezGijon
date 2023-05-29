using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.ViewManagement;
using Microsoft.Toolkit.Uwp.Notifications;
using Windows.UI.Notifications;
using Windows.UI.StartScreen;


// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0xc0a

namespace IPokemon
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();


            SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility =
            AppViewBackButtonVisibility.Visible;
            SystemNavigationManager.GetForCurrentView().BackRequested += opcionVolver;

            ApplicationView.GetForCurrentView().SetPreferredMinSize (new Size(320, 320));
            ApplicationView.GetForCurrentView().VisibleBoundsChanged += MainPage_VisibleBoundsChanged;

            saludo_inicial();
        }



        private void MainPage_VisibleBoundsChanged(Windows.UI.ViewManagement.ApplicationView
            sender, object args)
        {
            var Width = ApplicationView.GetForCurrentView().VisibleBounds.Width;
            //grande: menú abierto y lo demás
            if (Width >= 720)
            {
                sView.DisplayMode = SplitViewDisplayMode.CompactInline;
                sView.IsPaneOpen = true;
            }
            //se oculta el menú
            else if (Width >= 360)
            {
                sView.DisplayMode = SplitViewDisplayMode.CompactOverlay;
                sView.IsPaneOpen = false;
            }
            //se ocultan los iconos de menú
            else
            {
                sView.DisplayMode = SplitViewDisplayMode.Overlay;
                sView.IsPaneOpen = false;
            }
        }

        //Mensaje de voz al iniciar
        private async void saludo_inicial()
        {
            MediaElement mediaElement = new MediaElement();
            var synth = new Windows.Media.SpeechSynthesis.SpeechSynthesizer();
            Windows.Media.SpeechSynthesis.SpeechSynthesisStream stream = await
           synth.SynthesizeTextToStreamAsync("Estás en la aplicación de " +
           "IPO Pokemon dos mil veintitrés. Bienvenido, disfruta!!! You are in the app of IPO Pokemon " +
           "two thousand twenty three Welcome, enjoy!!");
            mediaElement.SetSource(stream, stream.ContentType);
            mediaElement.Play();
        }

        //Para Windows:
        private void incializar()
        {
            TileContent content = new TileContent()
            {
                Visual = new TileVisual()
                {
                    TileMedium = new TileBinding()
                    {
                        Content = new TileBindingContentAdaptive()
                        {
                            Children =
                            {
                                 new AdaptiveText()
                            {
                        Text = "IPOkemon", HintStyle = AdaptiveTextStyle.Subtitle
                            },
                            new AdaptiveText()
                            {
                                Text = "Un proyecto de IPO2",
                    HintStyle = AdaptiveTextStyle.CaptionSubtle
                     },
                     }
                        }
                    },
                    TileWide = new TileBinding()
                    {
                        Branding = TileBranding.NameAndLogo,
                        DisplayName = "Version 1.0",
                        Content = new TileBindingContentAdaptive()
                        {
                            Children = {
                 new AdaptiveText()
                {
                 Text = "IPOkemon",
                 HintStyle = AdaptiveTextStyle.Subtitle
                 },
                 new AdaptiveText()
                 {
                 Text = "Un Proyecto de IPO2",
                 HintStyle = AdaptiveTextStyle.CaptionSubtle
                 },
                 new AdaptiveText()
                 {
                 Text = "Una aplicación sobre Pokemon hecha con tecnología UWP",
                HintWrap = true,
                 }
                 }
                        }
                    },
                    TileLarge = new TileBinding()
                    {
                        Content = new TileBindingContentAdaptive()
                        {
                            Children = {
                 new AdaptiveText()
                {
                 Text = "IPOkemon",
                HintStyle = AdaptiveTextStyle.Subtitle
                 },
                 new AdaptiveText()
                 {
                 Text = "Un Proyecto de IPO2",
                HintStyle = AdaptiveTextStyle.CaptionSubtle
                 },
                 new AdaptiveText()
                {
                 Text = "Una aplicación sobre Pokemon hecha con tecnología UWP",
                 HintStyle = AdaptiveTextStyle.CaptionSubtle
                 }
                 }
                        }
                    },
                }
            };
            var notification = new TileNotification(content.GetXml());
            notification.ExpirationTime = DateTimeOffset.UtcNow.AddSeconds(30);
            var updater = TileUpdateManager.CreateTileUpdaterForApplication();
            updater.Update(notification);
        }


        private void opcionVolver(object sender, BackRequestedEventArgs e)
        {
            if (fmMain.BackStack.Any())
            {
                fmMain.GoBack();
            }
        }

        private void BtnMenuPrincipal_Click(object sender, RoutedEventArgs e)
        {
            sView.IsPaneOpen = !sView.IsPaneOpen;
        }

        private void BtnInicio_Click_1(object sender, RoutedEventArgs e)
        {
            fmMain.Navigate(typeof(InicioIPOkemon));
        }

        private void BtnPokedex_Click_1(object sender, RoutedEventArgs e)
        {
            fmMain.Navigate(typeof(PokeDexPage));
        }

        private void BtnCombate_Click_1(object sender, RoutedEventArgs e)
        {
            fmMain.Navigate(typeof(CombatePage));
        }

        private void BtnCaptura_Click(object sender, RoutedEventArgs e)
        {
            fmMain.Navigate(typeof(CapturaPokemon));
        }

        private void BtnManual_Click(object sender, RoutedEventArgs e)
        {
            fmMain.Navigate(typeof(ManualDelJuego));
        }

        
    }
}
