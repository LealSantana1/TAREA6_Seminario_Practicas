using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiApp.Models;

namespace MiApp.Services
{
    public interface IDistritoService

    {

        Task<Distrito> GetDistritoAsync(int id);

        Task<IEnumerable<Distrito>> GetAllDistritosAsync();

        Task<bool> AddDistritoAsync(Distrito distrito);

        Task<bool> UpdateDistritoAsync(Distrito distrito);

        Task<bool> DeleteDistritoAsync(int id);

    }
}
