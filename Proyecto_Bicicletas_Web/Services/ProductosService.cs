using Microsoft.EntityFrameworkCore;
using Proyecto_Bicicletas_Web.Data;
using Proyecto_Bicicletas_Web.Models;

namespace Proyecto_Bicicletas_Web.Services
{
    public class ProductosService(ApplicationDbContext context) : IProductos
    {
        Task IProductos.BorrarProducto(int id)
        {
            throw new NotImplementedException();
        }

        Task<Productos> IProductos.ModificarProducto(Productos producto)
        {
            throw new NotImplementedException();
        }

        Task<Productos> IProductos.ObtenerProducto(int id)
        {
            throw new NotImplementedException();
        }

        Task<List<Productos>> IProductos.ObtenerProductos()
        {
            throw new NotImplementedException();
        }
    }
}
