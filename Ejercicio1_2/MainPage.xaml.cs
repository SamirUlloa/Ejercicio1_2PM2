using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ejercicio1_2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public MainPage(DateTime date)
        {
            InitializeComponent();
        }

        private async void btnEnviar_Clicked(object sender, EventArgs e)
        {
            var emple = new Models.Empleado
            {
                nombre = txtNombre.Text,
                apellido = txtApellido.Text,
                edad = txtEdad.Text,
                correo = txtCorreo.Text
            };

            var segunda = new SegundaPage();
            segunda.BindingContext = emple;

            await Navigation.PushAsync(segunda);
        }
    }
}
