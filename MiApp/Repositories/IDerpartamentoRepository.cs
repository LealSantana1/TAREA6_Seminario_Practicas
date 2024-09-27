using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiApp.Models;

namespace MiApp.Repositories
{
    public interface IDepartamentoRepository

    {

        Task<Departamento> GetDepartamentoAsync(int id);

        Task<IEnumerable<Departamento>> GetAllDepartamentosAsync();

        Task<int> AddDepartamentoAsync(Departamento departamento);

        Task<int> UpdateDepartamentoAsync(Departamento departamento);

        Task<int> DeleteDepartamentoAsync(int id);

    }
}
