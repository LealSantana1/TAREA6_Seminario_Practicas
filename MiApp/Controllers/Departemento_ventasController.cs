using System.IO;
using Microsoft.Maui.Controls;
using MiApp.Models;
using MiApp.Services;
using MiApp;
using MiApp.Controllers;

namespace MiApp.Controllers
{
    public class Departemento_ventasController
    {

        private readonly Departamento_venstasService _departamento_ventasService;

        public Departemento_ventasController()
        {
            var dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "productos.db3");
            _departamento_ventasService = new Departamento_venstasService(dbPath);
        }

        public async Task<List<Departamento_ventas>> GetAllDepartamento_ventas()
        {
            return await _departamento_ventasService.GetAll();
        }

        public async void AddDepartamento_venta(Departamento_ventas departamento_ventas)
        {
            await _departamento_ventasService.Add(departamento_ventas);
        }

        public async void UpdateDepartamento_venta(Departamento_ventas departamento_ventas)
        {
            await _departamento_ventasService.Update(departamento_ventas);
        }

        public async 
        Task
DeleteDepartamento_venta(int id)
        {
            await _departamento_ventasService.Delete(id);
        }


    }
}
   