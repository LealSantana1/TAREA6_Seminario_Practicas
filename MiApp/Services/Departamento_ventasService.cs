using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MiApp.Models;

namespace MiApp.Services
{
    public class Departamento_venstasService
    {
        private Database _database;
        public Departamento_venstasService(string dbPath)
        {
            _database = new Database(dbPath);
        }
        public Task<List<Departamento_ventas>> GetAll() => _database.GetAllDepartamento_ventasAsync();
        public Task Add(Departamento_ventas departamento_ventas) => _database.SaveDepartamento_ventaAsync(departamento_ventas);
        public Task Update(Departamento_ventas departamento_ventas) => _database.SaveDepartamento_ventaAsync(departamento_ventas);
        public Task Delete(int id) => _database.DeleteDepartamento_ventaAsync(id);
    }
}
