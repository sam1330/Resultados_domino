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
    public partial class Login : ContentPage
    {
        private Entry usernameEntry; // Variable de clase para el Entry de usuario
        private Entry passwordEntry; // Variable de clase para el Entry de contraseña

        public Login()
       {
          InitializeComponent();

            // Imagen de fondo
            var backgroundImage = new Image
            {
                Source = "Background.png",
                Aspect = Aspect.Fill,
                Opacity = 1.6 // Ajusta la opacidad según tus preferencias
            };

            // Label para "Login"
            var loginLabel = new Label
            {
                Text = "Login",
                HorizontalOptions = LayoutOptions.Center,
                FontSize = 24,
                Margin = new Thickness(0, 20)
            };

            // Entry para el usuario
            usernameEntry = new Entry
            {
                Placeholder = "Usuario",
                Margin = new Thickness(20, 10)
            };

            // Entry para la contraseña
            passwordEntry = new Entry
            {
                Placeholder = "Contraseña",
                Margin = new Thickness(20, 10),
                IsPassword = true
            };

            // Botón de Iniciar Sesión
            var loginButton = new Button
            {
                Text = "Iniciar Sesión",
                Margin = new Thickness(20, 10),
                HorizontalOptions = LayoutOptions.FillAndExpand
            };
            loginButton.Clicked += OnLoginButtonClicked; // Asociar evento click

            // Botón de Registrar
            var registerButton = new Button
            {
                Text = "Registrar",
                Margin = new Thickness(20, 10),
                HorizontalOptions = LayoutOptions.FillAndExpand
            };
            registerButton.Clicked += OnRegisterButtonClicked; // Asociar evento click

            //Label para "O continuar con"
            var continueLabel = new Label
            {
                Text = "O continuar con",
                HorizontalOptions = LayoutOptions.Center,
                FontSize = 18,
                Margin = new Thickness(0, 30)
            };

            // Botón de Google
            var googleButton = new Button
            {
                Image = "google.png",
                WidthRequest = 1, // Ajusta el tamaño según tus necesidades
                HeightRequest = 1,
                Margin = new Thickness(1, 1),
                HorizontalOptions = LayoutOptions.Center
            };

            // Botón de Facebook
            var facebookButton = new Button
            {
                Image = "facebook.png",
                WidthRequest = 1, // Ajusta el tamaño según tus necesidades
                HeightRequest = 1,
                Margin = new Thickness(1, 1),
                HorizontalOptions = LayoutOptions.Center
            };





            // Botón "Salir"
            var salirButton = new Button
            {
                Text = "Salir",
                Margin = new Thickness(20, 10),
                HorizontalOptions = LayoutOptions.FillAndExpand
            };
            salirButton.Clicked += OnSalirButtonClicked; // Asociar evento click

            // Contenedor principal
            var mainLayout = new StackLayout
            {
                Children =
                        {
                            loginLabel,
                            usernameEntry,
                            passwordEntry,
                            loginButton,
                            //registerButton,
                            //continueLabel,
                            //googleButton,
                            //facebookButton,
                            //salirButton,
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

        // Evento click del botón "Iniciar Sesión"
        private async void OnLoginButtonClicked(object sender, EventArgs e)
            {
                string username = usernameEntry.Text;
                string password = passwordEntry.Text;

                if (username == "admin" && password == "admin")
                {
                    Application.Current.MainPage = new Dashboard(); // Cambiar la página principal a Dashboard
                }
                else
                {
                    await DisplayAlert("Error", "Usuario o Contraseña incorrecto", "OK"); // Mostrar mensaje de error
                }
            }

            private void OnRegisterButtonClicked(object sender, EventArgs e)
            {
                // Crear una instancia de la página "Registrar"
                Registrar registrarPage = new Registrar();

                // Acceder a la propiedad de navegación del objeto App actual
                App.Current.MainPage = registrarPage;
            }


        }
}




