﻿using System;
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
    public sealed partial class UCFuecoco : UserControl
    {
        DispatcherTimer dtReloj;
        DispatcherTimer dtStamina;

        public UCFuecoco()
        {
            this.InitializeComponent();
            //this.UserControl.MyVida = 80.0;
            animacionBase();

        }
        void animacionBase()
        {
            Storyboard sb = (Storyboard)this.Resources["AnimacionInicio"];
            sb.RepeatBehavior = RepeatBehavior.Forever;
            sb.Begin();
        }

        //VIDA
        private void Image_PointerReleased(object sender, PointerRoutedEventArgs e)
        {
            Storyboard sbCurado = (Storyboard)this.Resources["EstadoCurado"];
            sbCurado.Begin();
            dtReloj = new DispatcherTimer();
            dtReloj.Interval = TimeSpan.FromMilliseconds(100);
            dtReloj.Tick += increaseHealth;
            dtReloj.Start();
            this.PocionRoja.Opacity = 0.5;


        }
        private void increaseHealth(object sender, object e)
        {
            Storyboard sbCurado = (Storyboard)this.Resources["EstadoCurado"];
            Storyboard sb = (Storyboard)this.Resources["AnimacionInicio"];
            this.pbHealth.Value += 2;

            if (pbHealth.Value == 100)
            {
                this.dtReloj.Stop();
                sbCurado.Stop();
                sb.Begin();

                this.PocionRoja.Opacity = 1;
            }
        }

        //STAMINA
        private void PocionStamina_PointerReleased(object sender, PointerRoutedEventArgs e)
        {
            dtStamina = new DispatcherTimer();
            dtStamina.Interval = TimeSpan.FromMilliseconds(100);
            dtStamina.Tick += increaseStamina;
            dtStamina.Start();

            this.PocionStamina.Opacity = 0.5;

        }
        private void increaseStamina(object sender, object e)
        {
            this.pbStamina.Value += 2;
            if (pbStamina.Value == 100)
            {
                this.dtStamina.Stop();
                this.PocionStamina.Opacity = 1;
            }
        }


        void reducirBarra()

        {

            pbHealth.Value -= 10;
            Storyboard sbMuerto = (Storyboard)this.Resources["EstadoMuerto"];
            Storyboard sb = (Storyboard)this.Resources["AnimacionInicio"];
            Storyboard sbHerido = (Storyboard)this.Resources["EstadoHerido"];
            sb.Stop();

            if (pbHealth.Value == 0)
            {
                sbHerido.Stop();
                sb.Stop();
                sbMuerto.Begin();


            }


        }


        //PLACAJE
        private void BtnPlacaje_Click(object sender, RoutedEventArgs e)
        {
            this.pbStamina.Value -= 10;
            Storyboard sbPlacaje = (Storyboard)this.Resources["PlacajeFuecoco"];
            Storyboard sb = (Storyboard)this.Resources["AnimacionInicio"];
            sb.Stop();
            sbPlacaje.Begin();

            sbPlacaje.Completed += finMovimientoPlacaje;
        }
        void finMovimientoPlacaje(object sender, object e)
        {
            Storyboard sb = (Storyboard)this.Resources["AnimacionInicio"];
            Storyboard sbPlacaje = (Storyboard)sender;
            sbPlacaje.Completed -= finMovimientoPlacaje;
            sbPlacaje.Stop();
            sb.Begin();
        }

        //ASCUAS
        private void BtnAscuas_Click(object sender, RoutedEventArgs e)
        {
            this.pbStamina.Value -= 10;
            Storyboard sbAscuas = (Storyboard)this.Resources["Ascuas"];
            Storyboard sb = (Storyboard)this.Resources["AnimacionInicio"];
            sb.Stop();
            sbAscuas.Begin();

            sbAscuas.Completed += finMovimientoAscuas;



        }
        void finMovimientoAscuas(object sender, object e)
        {
            Storyboard sb = (Storyboard)this.Resources["AnimacionInicio"];
            Storyboard sbAscuas = (Storyboard)sender;
            sbAscuas.Completed -= finMovimientoAscuas;
            sbAscuas.Stop();
            sb.Begin();
        }




        //DANZA MARACA
        private void BtnDanza_Click(object sender, RoutedEventArgs e)
        {
            this.pbStamina.Value -= 10;
            Storyboard sbDanza = (Storyboard)this.Resources["DanzaMaraca"];
            Storyboard sb = (Storyboard)this.Resources["AnimacionInicio"];
            sb.Stop();
            sbDanza.Begin();

            sbDanza.Completed += finMovimientoDanza;

        }

        void finMovimientoDanza(object sender, object e)
        {
            Storyboard sb = (Storyboard)this.Resources["AnimacionInicio"];
            Storyboard sbDanza = (Storyboard)sender;
            sbDanza.Completed -= finMovimientoDanza;
            sbDanza.Stop();
            sb.Begin();
        }




        //MORDISCO

        private void BtnMordisco_Click(object sender, RoutedEventArgs e)
        {
            this.pbStamina.Value -= 10;
            Storyboard sbMordisco = (Storyboard)this.Resources["Mordisco"];
            Storyboard sb = (Storyboard)this.Resources["AnimacionInicio"];
            sb.Stop();
            sbMordisco.Begin();

            sbMordisco.Completed += finMovimientoMordisco;




        }
        void finMovimientoMordisco(object sender, object e)
        {
            Storyboard sb = (Storyboard)this.Resources["AnimacionInicio"];
            Storyboard sbMordisco = (Storyboard)sender;
            sbMordisco.Completed -= finMovimientoMordisco;
            sbMordisco.Stop();
            sb.Begin();
        }

        //RECIBIR DAÑO
        private void BtnRecibirDaño_Click(object sender, RoutedEventArgs e)
        {

            Storyboard sbHerido = (Storyboard)this.Resources["EstadoHerido"];
            Storyboard sb = (Storyboard)this.Resources["AnimacionInicio"];
            sb.Stop();
            sbHerido.Begin();
            reducirBarra();

            sbHerido.Completed += finEstadoHerido;
        }

        void finEstadoHerido(object sender, object e)
        {
            Storyboard sb = (Storyboard)this.Resources["AnimacionInicio"];
            Storyboard sbHerido = (Storyboard)sender;
            sbHerido.Completed -= finEstadoHerido;
            sbHerido.Stop();
            sb.Begin();
        }
        public double MyVida
        {
            get
            {
                return this.pbHealth.Value;
            }
            set
            {
                this.pbHealth.Value = value;
            }
        }

        private void BtnPokeball_Click(object sender, RoutedEventArgs e)
        {
            Storyboard sbCaptura = (Storyboard)this.Resources["Captura"];
            Storyboard sb = (Storyboard)this.Resources["AnimacionInicio"];
            sb.Stop();
            sbCaptura.Begin();

            sbCaptura.Completed += finCaptura;
        }
        void finCaptura(object sender, object e)
        {
            Storyboard sb = (Storyboard)this.Resources["AnimacionInicio"];
            Storyboard sbCaptura = (Storyboard)sender;
            sbCaptura.Completed -= finCaptura;
            sbCaptura.Stop();
            sb.Begin();
        }
    }
}
