namespace ProyectoBaseAppMoviles.Vistas;

public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();
    }

    private void btnIniciarSesion_Clicked(object sender, EventArgs e)
    {
        Dictionary<string, string> usuariosContrase�as = new Dictionary<string, string>();
        usuariosContrase�as.Add("estudiante2024", "uisrael2024");
        usuariosContrase�as.Add("examen1", "parcial1");
        usuariosContrase�as.Add("NombreEstudiante", "2024");

        string usuario = TxtUsuario.Text;
        string clave = TxtContrasena.Text;
        if (clave == usuariosContrase�as[usuario])
        {
            Navigation.PushAsync(new Vistas.Registro(usuario));
        }
        else
        {
            DisplayAlert("Alerta", "Usuario o contrase�a incorrectos", "Cerrar");
            TxtContrasena.Text = "";
            TxtUsuario.Text = "";
        }
        
    }
}