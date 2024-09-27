using MiApp.Controllers;
namespace MiApp.Views;
public partial class LoginPage : ContentPage

{
  private readonly LoginController _loginController;

  public LoginPage(LoginController loginController)
  {
    InitializeComponent();

    _loginController = loginController;

  }
  private async void OnLoginButtonClicked(object sender, EventArgs e)

  {
    var nombreUsuario = NombreUsuarioEntry.Text;
    var contrasena = ContrasenaEntry.Text;
    // Validaci�n de campos vac�os
    if (string.IsNullOrWhiteSpace(nombreUsuario) || string.IsNullOrWhiteSpace(contrasena))
    {
      MensajeLabel.Text = "Por favor, complete todos los campos.";
      MensajeLabel.IsVisible = true;

      return;

    }



    // Intentar autenticaci�n

    if (await _loginController.Autenticar(nombreUsuario, contrasena))

    {

      await DisplayAlert("�xito", "�Inicio de sesi�n exitoso!", "OK");

      // Aqu� puedes redirigir a otra p�gina si es necesario

      // Redirigir a la p�gina principal u otra p�gina relevante

      await Navigation.PushAsync(new MainPage()); // Aseg�rate de tener una MainPage

    }

    else

    {

      MensajeLabel.Text = "Nombre de usuario o contrase�a incorrectos.";

      MensajeLabel.IsVisible = true;

    }

  }

  private async void OnCreateAccountButtonClicked(object sender, EventArgs e)

  {

    // Navegar a la p�gina de registro

    await Navigation.PushAsync(new RegisterPage(_loginController));

  }

}