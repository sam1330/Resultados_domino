using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Resultados_domino
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Dashboard : ContentPage
    {
        public Dashboard()
        {
            //InitializeComponent();

            // Imagen de fondo
            var backgroundImage = new Image
            {
                Source = "Background.png",
                Aspect = Aspect.Fill,
                Opacity = 1.6 // Ajusta la opacidad según tus preferencias
            };

            // Label "Menu Principal"
            var MenuPrincipal = new Label
            {
                Text = "Menu Principal",
                HorizontalOptions = LayoutOptions.Center,
                FontSize = 28,
                Margin = new Thickness(0, 20)
            };


            // Label "Tipo de juego"
            var tipoDeJuegoLabel = new Label
            {
                Text = "Tipo de juego",
                HorizontalOptions = LayoutOptions.Center,
                FontSize = 24,
                Margin = new Thickness(0, 20)
            };

            // Label "Seleccione"
            var seleccioneLabel = new Label
            {
                Text = "Seleccione",
                HorizontalOptions = LayoutOptions.Center,
                FontSize = 18,
                Margin = new Thickness(0, 10)
            };

            // Botón "1 Vs. 1"
            var unoVsUnoButton = new Button
            {
                Text = "1 Vs. 1",
                Margin = new Thickness(20, 10),
                HorizontalOptions = LayoutOptions.FillAndExpand,
                BorderRadius = 20 // Hace el botón redondo ajustando el valor del radio de borde
            };

            // Botón "Por equipos"
            var porEquiposButton = new Button
            {
                Text = "Por equipos",
                Margin = new Thickness(20, 10),
                HorizontalOptions = LayoutOptions.FillAndExpand,
                BorderRadius = 20 // Hace el botón redondo ajustando el valor del radio de borde
            };
            var Historial = new Button
            {
                Text = "Historial de partidas",
                Margin = new Thickness(20, 10),
                HorizontalOptions = LayoutOptions.FillAndExpand,
                BorderRadius = 20 // Hace el botón redondo ajustando el valor del radio de borde
            };

            //// Botón "Salir"
            //var salirButton = new Button
            //{
            //    Text = "Salir",
            //    Margin = new Thickness(20, 10),
            //    HorizontalOptions = LayoutOptions.FillAndExpand
            //};
            //salirButton.Clicked += OnSalirButtonClicked; // Asociar evento click

            // Contenedor principal
            var mainLayout = new StackLayout
            {
                Children =
                {
                    tipoDeJuegoLabel,
                    MenuPrincipal,
                    seleccioneLabel,
                    unoVsUnoButton,
                    porEquiposButton,
                    Historial
                    //salirButton
                }
            };

            // Contenedor para imagen de fondo y contenido principal
            var backgroundLayout = new RelativeLayout();
            backgroundLayout.Children.Add(backgroundImage, Constraint.Constant(0), Constraint.Constant(0),
                Constraint.RelativeToParent(parent => parent.Width), Constraint.RelativeToParent(parent => parent.Height));
            backgroundLayout.Children.Add(mainLayout,
                Constraint.RelativeToParent(parent => (parent.Width - mainLayout.Width) / 2),
                Constraint.RelativeToParent(parent => (parent.Height - mainLayout.Height) / 2));

            Content = backgroundLayout;
        }

        private void OnSalirButtonClicked(object sender, EventArgs e)
        {
            // Cerrar la aplicación
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }
    }
}