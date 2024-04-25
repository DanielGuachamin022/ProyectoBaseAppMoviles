using PassKit;

namespace ProyectoBaseAppMoviles.Vistas;

public partial class Registro : ContentPage
{
	public Registro(string usuario)
	{
		InitializeComponent();
        lblUsuarioConectado.Text = "Bienvenido " + usuario;
    }

    private void btnCalcularPagoMensual_Clicked(object sender, EventArgs e)
    {
        double monto = Convert.ToDouble(TxtMontoInicial.Text);
        double residuo = 3000 - monto;
        double cuota = residuo / 3;
        double valorfinal = cuota + (3000 * 0.05);
        double valorTotal = monto + (valorfinal * 3);

        TxtPagoMensual.Text = valorfinal.ToString();
    }

    private void btnVerResumen_Clicked(object sender, EventArgs e)
    {
        string nombre = TxtNombre.Text;
        string apellido = TxtApellido.Text;
        int edad = Convert.ToInt32(TxtEdad.Text);
        DateTime fecha = dpFecha.Date;
        string pais = pkPaises.SelectedItem.ToString();
        string ciudad = pkCiudades.SelectedItem.ToString();
        double montoInicial = Convert.ToDouble(TxtMontoInicial.Text);
        double pagoMensual = Convert.ToDouble(TxtPagoMensual.Text);

        //await Navigation.PushAsync(new ResumenPage(nombre, apellido, edad, fecha, pais, ciudad, montoInicial, pagoMensual));
    }
}