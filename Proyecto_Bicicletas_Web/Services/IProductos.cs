using Proyecto_Bicicletas_Web.Models;

namespace Proyecto_Bicicletas_Web.Services
{
    public interface IProductos
{
        Task<List<Productos>> ObtenerProductos();
        Task<Productos> AgregarProducto(Productos productos);
        Task BorrarProducto(int id);
        Task<Productos> ModificarProducto(Productos producto);
        Task<Productos> ObtenerProducto(int id);
}
}
