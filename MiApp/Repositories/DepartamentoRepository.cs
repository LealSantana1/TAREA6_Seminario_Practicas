using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiApp.Models;
using SQLite;

namespace MiApp.Repositories
{
    public class DepartamentoRepository : IDepartamentoRepository

    {

        private readonly SQLiteConnection _connection;



        public DepartamentoRepository(SQLiteConnection connection)

        {

            _connection = connection;

            _connection.CreateTable<Departamento>();

        }



        public Task<Departamento> GetDepartamentoAsync(int id)

        {

            return Task.FromResult(_connection.Table<Departamento>().FirstOrDefault(d => d.Id == id));

        }



        public Task<IEnumerable<Departamento>> GetAllDepartamentosAsync()

        {

            return Task.FromResult(_connection.Table<Departamento>().AsEnumerable());

        }



        public Task<int> AddDepartamentoAsync(Departamento departamento)

        {

            return Task.FromResult(_connection.Insert(departamento));

        }



        public Task<int> UpdateDepartamentoAsync(Departamento departamento)

        {

            return Task.FromResult(_connection.Update(departamento));

        }



        public Task<int> DeleteDepartamentoAsync(int id)

        {

            var departamento = _connection.Table<Departamento>().FirstOrDefault(d => d.Id == id);

            if (departamento != null)

            {

                return Task.FromResult(_connection.Delete(departamento));

            }

            return Task.FromResult(0);

        }

    }
}
