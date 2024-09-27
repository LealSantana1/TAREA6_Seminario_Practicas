using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiApp.Models;
using MiApp.Services;

namespace MiApp.Controllers
{
    public class DistritoController

    {

        private readonly IDistritoService _distritoService;



        public DistritoController (IDistritoService distritoService)

        {

            _distritoService = distritoService;

        }



        public async Task<Distrito> GetDistritoAsync(int id)

        {

            return await _distritoService.GetDistritoAsync(id);

        }



        public async Task<IEnumerable<Distrito>> GetAllDistritosAsync()

        {

            return await _distritoService.GetAllDistritosAsync();

        }



        public async Task<bool> AddDistritoAsync(Distrito distrito)

        {

            return await _distritoService.AddDistritoAsync(distrito);

        }



        public async Task<bool> UpdateDistritoAsync(Distrito distrito)

        {

            return await _distritoService.UpdateDistritoAsync(distrito);

        }



        public async Task<bool> DeleteDistritoAsync(int id)

        {

            return await _distritoService.DeleteDistritoAsync(id);

        }

    }
}
