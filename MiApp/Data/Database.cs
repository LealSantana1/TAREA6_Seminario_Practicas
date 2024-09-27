using SQLite;
using System.IO;
using System.Threading.Tasks;
using System.Collections.Generic;
using MiApp.Models;
using Microsoft.Maui.Controls;

public class Database
{
    private SQLiteAsyncConnection _database;

    public Database(string dbPath)
    {
        _database = new SQLiteAsyncConnection(dbPath);
        _database.CreateTableAsync<Departamento_ventas>().Wait();

        _database.CreateTableAsync<Categoria>().Wait();
        _database.CreateTableAsync<Producto>().Wait();
        _database.CreateTableAsync<Bolsa>().Wait();
    }
        //departemento_venta

        public Task<List<Departamento_ventas>> GetAllDepartamento_ventasAsync()
    {
        return _database.Table<Departamento_ventas>().ToListAsync();
    }

    public Task<Departamento_ventas> GetDepartamento_ventaAsync(int id)
    {
        return _database.Table<Departamento_ventas>().FirstOrDefaultAsync(p => p.Id == id);
    }

    public Task<int> SaveDepartamento_ventaAsync(Departamento_ventas departamento_ventas)
    {
        if (departamento_ventas.Id != 0)
            return _database.UpdateAsync(departamento_ventas);
        else
            return _database.InsertAsync(departamento_ventas);
    }

    public Task<int> DeleteDepartamento_ventaAsync(int id)
    {
        return _database.DeleteAsync<Departamento_ventas>(id);
    }
    //categoria
    public Task<List<Categoria>> GetAllCategoriasAsync()
    {
        return _database.Table<Categoria>().ToListAsync();
    }

    public Task<Categoria> GetCategoriaAsync(int id)
    {
        return _database.Table<Categoria>().FirstOrDefaultAsync(c => c.Id == id);
    }

    public Task<int> SaveCategoriaAsync(Categoria categoria)
    {
        if (categoria.Id != 0)
            return _database.UpdateAsync(categoria);
        else
            return _database.InsertAsync(categoria);
    }

    public Task<int> DeleteCategoriaAsync(int id)
    {
        return _database.DeleteAsync<Categoria>(id);
    }
    //produtos
    public Task<List<Producto>> GetAllProductosAsync()
    {
        return _database.Table<Producto>().ToListAsync();
    }

    public Task<Producto> GetProductoAsync(int id)
    {
        return _database.Table<Producto>().FirstOrDefaultAsync(p => p.Id == id);
    }

    public Task<int> SaveProductoAsync(Producto producto)
    {
        if (producto.Id != 0)
            return _database.UpdateAsync(producto);
        else
            return _database.InsertAsync(producto);
    }

    public Task<int> DeleteProductoAsync(int id)
    {
        return _database.DeleteAsync<Producto>(id);
    }

    //bolsa
    public Task<List<Bolsa>> GetAllBolsasAsync()
    {
        return _database.Table<Bolsa>().ToListAsync();
    }

    public Task<Bolsa> GetBolsaAsync(int id)
    {
        return _database.Table<Bolsa>().FirstOrDefaultAsync(p => p.Id == id);
    }

    public Task<int> SaveBolsaAsync(Bolsa bolsa)
    {
        if (bolsa.Id != 0)
            return _database.UpdateAsync(bolsa);
        else
            return _database.InsertAsync(bolsa);
    }

    public Task<int> DeleteBolsaAsync(int id)
    {
        return _database.DeleteAsync<Bolsa>(id);
    }

    public override bool Equals(object? obj)
    {
        return base.Equals(obj);
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }

    public override string? ToString()
    {
        return base.ToString();
    }
}
