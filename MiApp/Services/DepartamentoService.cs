using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiApp.Models;
using MiApp.Repositories;

namespace MiApp.Services
{
    public class DepartamentoService : IDepartamentoService
    {
        private readonly IDepartamentoRepository _departamentoRepository;
        public DepartamentoService(IDepartamentoRepository departamentoRepository)
        {
            _departamentoRepository = departamentoRepository;
        }
        public async Task<Departamento> GetDepartamentoAsync(int id)
        {
            return await _departamentoRepository.GetDepartamentoAsync(id);
        }
        public async Task<IEnumerable<Departamento>> GetAllDepartamentosAsync()
        {

            return await _departamentoRepository.GetAllDepartamentosAsync();

        }



        public async Task<bool> AddDepartamentoAsync(Departamento departamento)

        {

            var result = await _departamentoRepository.AddDepartamentoAsync(departamento);

            return result > 0;

        }



        public async Task<bool> UpdateDepartamentoAsync(Departamento departamento)

        {

            var result = await _departamentoRepository.UpdateDepartamentoAsync(departamento);

            return result > 0;

        }



        public async Task<bool> DeleteDepartamentoAsync(int id)

        {

            var result = await _departamentoRepository.DeleteDepartamentoAsync(id);

            return result > 0;

        }

    }
}
