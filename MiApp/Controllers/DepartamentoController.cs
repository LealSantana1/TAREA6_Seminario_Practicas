using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiApp.Models;
using MiApp.Services;

namespace MiApp.Controllers
{
    public class DepartamentoController

    {

        private readonly IDepartamentoService _departamentoService;



        public DepartamentoController(IDepartamentoService departamentoService)

        {

            _departamentoService = departamentoService;

        }



        public async Task<Departamento> GetDepartamentoAsync(int id)

        {

            return await _departamentoService.GetDepartamentoAsync(id);

        }



        public async Task<IEnumerable<Departamento>> GetAllDepartamentosAsync()

        {

            return await _departamentoService.GetAllDepartamentosAsync();

        }



        public async Task<bool> AddDepartamentoAsync(Departamento departamento)

        {

            return await _departamentoService.AddDepartamentoAsync(departamento);

        }



        public async Task<bool> UpdateDepartamentoAsync(Departamento departamento)

        {

            return await _departamentoService.UpdateDepartamentoAsync(departamento);

        }



        public async Task<bool> DeleteDepartamentoAsync(int id)

        {

            return await _departamentoService.DeleteDepartamentoAsync(id);

        }

    }
}
