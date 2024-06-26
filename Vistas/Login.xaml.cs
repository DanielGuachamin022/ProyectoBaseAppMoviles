namespace ProyectoBaseAppMoviles.Vistas;

public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();
    }

    private void btnIniciarSesion_Clicked(object sender, EventArgs e)
    {
        Dictionary<string, string> usuariosContraseņas = new Dictionary<string, string>();
        usuariosContraseņas.Add("estudiante2024", "uisrael2024");
        usuariosContraseņas.Add("examen1", "parcial1");
        usuariosContraseņas.Add("NombreEstudiante", "2024");

        string usuario = TxtUsuario.Text;
        string clave = TxtContrasena.Text;
        if (clave == usuariosContraseņas[usuario])
        {
            Navigation.PushAsync(new Vistas.Registro(usuario));
        }
        else
        {
            DisplayAlert("Alerta", "Usuario o contraseņa incorrectos", "Cerrar");
            TxtContrasena.Text = "";
            TxtUsuario.Text = "";
        }
        
    }
}