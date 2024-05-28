using Microsoft.EntityFrameworkCore;
using Proyecto_Bicicletas_Web.Data;
using Proyecto_Bicicletas_Web.Models;

namespace Proyecto_Bicicletas_Web.Services
{
    public class ProductosService(ApplicationDbContext context) : IProductos
    {
        public async Task<Productos> AgregarProducto(Productos producto) {
            context.Productos.Add(producto);
            await context.SaveChangesAsync();
            return producto;
        }
        
        public async Task BorrarProducto(int id)
        {
            var producto = await context.Productos.FindAsync(id);
            if (producto != null)
            {
                context.Productos.Remove(producto);
                await context.SaveChangesAsync();
            }
        }

        public async Task<Productos> ModificarProducto(Productos producto)
        {
            context.Productos.Update(producto);
            await context.SaveChangesAsync();
            return producto;
        }

        public async Task<Productos> ObtenerProducto(int id)
        {
            var producto = await context.Productos.FindAsync(id);
            return producto;
        }
        
        public async Task<List<Productos>> ObtenerProductos()
        {
            List<Productos> products = new List<Productos>();
            products = await context.Productos.ToListAsync();
            return products;
        }
    }
}
