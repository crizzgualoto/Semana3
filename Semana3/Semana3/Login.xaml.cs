using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Semana3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnIniciar_Clicked(object sender, EventArgs e)
        {
            string usuario = "Cristhian";
            string contraseña = "12345";
            
            if(usuario==txtUsuario.Text && contraseña == txtContraseña.Text)
            {
                Navigation.PushAsync(new Registro(usuario));

            }
            else
            {
                DisplayAlert("alerta","USUARIO/CONTRASEÑA INCORRECTA","cerrar");

            }
            
        }
    }
}