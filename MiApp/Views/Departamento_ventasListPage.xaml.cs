using Microsoft.Maui.Controls;
using MiApp.Controllers;
using MiApp.Models;

namespace MiApp.Views
{
    public partial class Departamento_ventasListPage : ContentPage
    {
        private Departemento_ventasController _controller;

        public Departamento_ventasListPage()
        {
            InitializeComponent();
            _controller = new Departemento_ventasController();
            LoadDepartamento_ventas();
        }

        private async void LoadDepartamento_ventas()
        {
           Departamentos_ventasListView.ItemsSource = await _controller.GetAllDepartamento_ventas();
        }

        private async void OnProductTapped(object sender, ItemTappedEventArgs e)
        {
            var departamento_ventas = (Departamento_ventas)e.Item;
            await Navigation.PushAsync(new Departamento_ventasEditPage(departamento_ventas));
        }

        private async void OnAddProductClicked(object sender, EventArgs e)
        {
            // Redirige a la vista para agregar un nuevo producto
            await Navigation.PushAsync(new Departamento_ventasEditPage());
        }
    }
}
