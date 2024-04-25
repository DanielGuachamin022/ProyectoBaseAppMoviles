namespace ProyectoBaseAppMoviles.Vistas;

public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();
    }

    private void btnIniciarSesion_Clicked(object sender, EventArgs e)
    {
        Dictionary<string, string> usuariosContraseñas = new Dictionary<string, string>();
        usuariosContraseñas.Add("estudiante2024", "uisrael2024");
        usuariosContraseñas.Add("examen1", "parcial1");
        usuariosContraseñas.Add("NombreEstudiante", "2024");

        string usuario = TxtUsuario.Text;
        string clave = TxtContrasena.Text;
        if (clave == usuariosContraseñas[usuario])
        {
            Navigation.PushAsync(new Vistas.Registro(usuario));
        }
        else
        {
            DisplayAlert("Alerta", "Usuario o contraseña incorrectos", "Cerrar");
            TxtContrasena.Text = "";
            TxtUsuario.Text = "";
        }
        
    }
}