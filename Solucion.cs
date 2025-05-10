using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsw2025Ej10
{
    internal class Solucion
    {
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

        public void MostrarProductosConPreciosFormateados(List<ProductoFormateado> lista)
        {
            lista.ForEach(p => { Console.WriteLine($"[+] Product: {p.Descripcion}, Precio: {p.PrecioFormateado}"); });
        }

        // 7. El producto con el precio más alto
        public decimal ProductoPrecioMaximo(List<Producto> lista)
        {
            return lista.Max(p => p.Precio);
        }

        // 8. El producto con el precio más bajo
        public decimal ProductoPrecioMinimo(List<Producto> lista)
        {
            return lista.Min(p => p.Precio);
        }

        // 9. Obtener y mostrar los productos cuyo precio sea mayor al promedio
        public void MayoresAlPrecioPromedio(List<Producto> lista)
        {
            var mayoresAlPromedio = lista.Where(p => p.Precio > (lista.Average(p => p.Precio))).ToList();
            ImprimirLista(mayoresAlPromedio);
        }

        // 10. Listar los productos ordenados por descripción de forma descendente
        public void OrdenarProductosPorDescripcion(List<Producto> lista)
        {
            var ordenadosPorDescripcion = lista.OrderByDescending(p => p.Descripcion).ToList();
            ImprimirLista(ordenadosPorDescripcion);
        }

        // Imprimir lista con nombre y precio del producto
        public void ImprimirLista(List<Producto> lista)
        {
            lista.ForEach(p => Console.WriteLine($"[+] Producto: {p.Descripcion}, Precio: {p.Precio} "));
        }

        // 11. Productos que empiezan con un string determinado
        public List<Producto> EmpiezaCon(List<Producto> lista, string X)
        {
            return lista.Where(p => p.Descripcion.StartsWith(X, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public void EjecutarSolucion(List<Producto> lista)
        {
            // 1. El primer producto
            var primerProducto = PrimerProducto(lista);
            Console.WriteLine($"[1] Primer Producto: {primerProducto.Descripcion}, Precio: {primerProducto.Precio}");

            // 2. El último producto
            var ultimoProducto = UltimoProducto(lista);
            Console.WriteLine($"[2] Último Producto: {ultimoProducto.Descripcion}, Precio: {ultimoProducto.Precio}");

            // 3. La suma de precios
            var sumaPrecios = SumarPrecios(lista);
            Console.WriteLine($"[3] Suma de Precios: {sumaPrecios}");

            // 4. El promedio de precios
            var promedioPrecios = PromedioPrecios(lista);
            Console.WriteLine($"[4] Promedio de Precios: {promedioPrecios}");

            // 5. Listar los productos con Id mayor a 15
            var productosIdMayor15 = FiltrarId15(lista);
            Console.WriteLine("[5] Productos con Id mayor a 15:");
            ImprimirLista(productosIdMayor15);

            // 6. Obtener y mostrar productos con precios formateados
            var productosFormateados = ObtenerProductosConPrecios(lista);
            Console.WriteLine("[6] Productos con precios formateados:");
            MostrarProductosConPreciosFormateados(productosFormateados);

            // 7. El producto con el precio más alto
            var precioMaximo = ProductoPrecioMaximo(lista);
            Console.WriteLine($"[7] Precio más alto: {precioMaximo}");

            // 8. El producto con el precio más bajo
            var precioMinimo = ProductoPrecioMinimo(lista);
            Console.WriteLine($"[8] Precio más bajo: {precioMinimo}");

            // 9. Productos cuyo precio es mayor al promedio
            Console.WriteLine("[9] Productos con precio mayor al promedio:");
            MayoresAlPrecioPromedio(lista);

            // 10. Productos ordenados por descripción de forma descendente
            Console.WriteLine("[10] Productos ordenados por descripción (descendente):");
            OrdenarProductosPorDescripcion(lista);

            // 11. Productos que empiezan con un string determinado (ejemplo: "A")
            var productosEmpiezanConA = EmpiezaCon(lista, "A");
            Console.WriteLine("[11] Productos que empiezan con 'A':");
            ImprimirLista(productosEmpiezanConA);
        }
    }
}