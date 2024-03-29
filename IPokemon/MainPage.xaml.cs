﻿using System;
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
            Windows.UI.ViewManagement.ApplicationView.GetForCurrentView().SetPreferredMinSize (new Size(320, 320));
            Windows.UI.ViewManagement.ApplicationView.GetForCurrentView().VisibleBoundsChanged += MainPage_VisibleBoundsChanged;

        }

        private void MainPage_VisibleBoundsChanged(Windows.UI.ViewManagement.ApplicationView
sender, object args)
        {
            var Width =
           Windows.UI.ViewManagement.ApplicationView.GetForCurrentView().VisibleBounds.Width;
            if (Width >= 720)
            {
                sView.DisplayMode = SplitViewDisplayMode.CompactInline;
                sView.IsPaneOpen = true;
            }
            else if (Width >= 360)
            {
                sView.DisplayMode = SplitViewDisplayMode.CompactOverlay;
                sView.IsPaneOpen = false;
            }
            else
            {
                sView.DisplayMode = SplitViewDisplayMode.Overlay;
                sView.IsPaneOpen = false;
            }
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
