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
    public partial class Registrar : ContentPage
    {
        public Registrar()
        {
            InitializeComponent();

            // Imagen de fondo
            var backgroundImage = new Image
            {
                Source = "Background.png",
                Aspect = Aspect.Fill,
                Opacity = 1.6 // Ajusta la opacidad según tus preferencias
            };

            // Label para "Registro"
            var registerLabel = new Label
            {
                Text = "Registro",
                HorizontalOptions = LayoutOptions.Center,
                FontSize = 24,
                Margin = new Thickness(0, 20)
            };

            // Entry para el nombre de usuario
            var usernameEntry = new Entry
            {
                Placeholder = "Nombre de usuario",
                Margin = new Thickness(20, 10)
            };

            // Entry para la contraseña
            var passwordEntry = new Entry
            {
                Placeholder = "Contraseña",
                Margin = new Thickness(20, 10),
                IsPassword = true
            };

            // Entry para confirmar la contraseña
            var confirmPasswordEntry = new Entry
            {
                Placeholder = "Confirmar contraseña",
                Margin = new Thickness(20, 10),
                IsPassword = true
            };

            // Botón de Registrarse
            var registerButton = new Button
            {
                Text = "Registrarse",
                Margin = new Thickness(20, 10),
                HorizontalOptions = LayoutOptions.FillAndExpand
            };
            registerButton.Clicked += OnRegisterButtonClicked; // Asociar evento click

            // Botón de Volver
            var backButton = new Button
            {
                Text = "Volver",
                Margin = new Thickness(20, 10),
                HorizontalOptions = LayoutOptions.FillAndExpand
            };
            backButton.Clicked += OnBackButtonClicked; // Asociar evento click

            // Contenedor principal
            var mainLayout = new StackLayout
            {
                Children =
                {
                    registerLabel,
                    usernameEntry,
                    passwordEntry,
                    confirmPasswordEntry,
                    registerButton,
                    backButton
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

        // Evento click del botón "Registrarse"
        private void OnRegisterButtonClicked(object sender, EventArgs e)
        {
            // Lógica para el proceso de registro
        }

        // Evento click del botón "Volver"
        // Evento click del botón de retroceso
        private void OnBackButtonClicked(object sender, EventArgs e)
        {
            // Acceder a la propiedad de navegación del objeto App actual
            App.Current.MainPage = new Login();
        }

    }
}