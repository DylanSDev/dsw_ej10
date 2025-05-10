using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsw2025Ej10
{
    internal class Solucion
    {
        /* A partir de la lista de productos que se obtiene de Producto.CrearListaDeEjemplo()
             * Resolver:
             * 4.
             * 5.
             * 6.
             *
             * 8. El producto con el precio más bajo
             * 9. Obtener y mostrar los productos cuyo precio sea mayor al promedio
             * 10. Listar los productos ordenados por descripción de forma descendente
             * Cada punto se debe realizar en un método distinto, en una nueva clase llamada Solucion
             */

        // 1. El primer producto
        public Producto PrimerProducto(List<Producto> lista)
        {
            return lista.First();
        }

        // 2. El último producto
        public Producto UltimoProducto(List<Producto> lista)
        {
            return lista.Last();
        }

        // 3. La suma de precios
        public decimal SumarPrecios(List<Producto> lista)
        {
            return lista.Sum(x => x.Precio);
        }

        // 4. El promedio de precios
        public decimal PromedioPrecios(List<Producto> lista)
        {
            return lista.Average(x => x.Precio);
        }

        // 5. Listar los productos con Id mayor a 15
        public List<Producto> FiltrarId15(List<Producto> lista)
        {
            return lista.Where(p => p.Id > 15).ToList();
        }

        // 6. Obtener una lista de cada producto con su nombre y el precio en formato moneda, luego mostrar los elementos
        public record ProductoFormateado(string Descripcion, string PrecioFormateado);

        public List<ProductoFormateado> ObtenerProductosConPrecios(List<Producto> lista)
        {
            return lista.ConvertAll(p => new ProductoFormateado(p.Descripcion, p.Precio.ToString("C2")));
        }

        public void MostrarProductosConPrecios(List<ProductoFormateado> lista)
        {
            lista.ForEach(p => { Console.WriteLine($"[+] Nombre: {p.Descripcion}, Precio: {p.PrecioFormateado}"); });
        }

        // 7. El producto con el precio más alto

        // 11. Productos que empiezan con un string determinado
        public List<Producto> EmpiezaCon(List<Producto> lista, string X)
        {
            return lista.Where(p => p.Descripcion.StartsWith(X, StringComparison.OrdinalIgnoreCase)).ToList();
        }
    }
}