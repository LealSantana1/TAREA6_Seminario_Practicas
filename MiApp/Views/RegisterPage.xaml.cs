using MiApp.Controllers;
namespace MiApp.Views;
public partial class RegisterPage : ContentPage
{
    private readonly LoginController _loginController;
    public RegisterPage(LoginController loginController)
    {
        InitializeComponent();

        _loginController = loginController;

    }
    private async void OnRegisterButtonClicked(object sender, EventArgs e)
    {
        var nombreUsuario = NombreUsuarioEntry.Text;
        var contrasena = ContrasenaEntry.Text;

        if (string.IsNullOrWhiteSpace(nombreUsuario) || string.IsNullOrWhiteSpace(contrasena))
        {
            MensajeLabel.Text = "Todos los campos son obligatorios.";
            MensajeLabel.IsVisible = true;
            return;
        }

        var resultado = await _loginController.Registrar(nombreUsuario, contrasena);



        if (resultado)

        {

            await DisplayAlert("�xito", "�Registro exitoso!", "OK");

            // Navegar a la p�gina de inicio de sesi�n o alguna otra p�gina

            await Navigation.PushAsync(new LoginPage(_loginController));

        }

        else

        {

            MensajeLabel.Text = "El nombre de usuario ya existe.";

            MensajeLabel.IsVisible = true;

        }

    }

}