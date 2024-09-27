using MiApp.Controllers;
using MiApp.Models;
using Microsoft.Maui.Controls;

namespace MiApp.Views
{
    public partial class Departamento_ventasEditPage : ContentPage
    {
        private Departamento_ventas _departamento_ventas;

        public Departamento_ventasEditPage(Departamento_ventas departamento_ventas = null)
        {
            InitializeComponent();
            _departamento_ventas = departamento_ventas ?? new Departamento_ventas(); // Si no se pasa producto, creamos uno nuevo
            if (_departamento_ventas.Id != 0)
            {
                NombreEntry.Text = _departamento_ventas.Nombre;


            }
        }

        private async void OnSaveClicked(object sender, EventArgs e)
        {
            // Guardamos el producto al hacer clic en "Guardar"
            _departamento_ventas.Nombre = NombreEntry.Text;


            var controller = new Departemento_ventasController();
            if (_departamento_ventas.Id == 0)
                controller.AddDepartamento_venta(_departamento_ventas);  // Crea un nuevo producto
            else
                controller.UpdateDepartamento_venta(_departamento_ventas);  // Actualiza el producto existente

            await Navigation.PopAsync();  // Vuelve a la lista de productos
        }
       
            
        

    }
}
