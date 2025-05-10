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
        public Producto ProductoPrecioMaximo(List<Producto> lista)
        {
            return lista.OrderByDescending(p => p.Precio).First();
        }

        // 8. El producto con el precio más bajo
        public Producto ProductoPrecioMinimo(List<Producto> lista)
        {
            return lista.OrderBy(p => p.Precio).First();
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
            Console.WriteLine("═══════════════════════════════════════════");
            Console.WriteLine("          ANÁLISIS DE PRODUCTOS           ");
            Console.WriteLine("═══════════════════════════════════════════\n");

            // 1. El primer producto
            var primerProducto = PrimerProducto(lista);
            Console.WriteLine("[1] Primer Producto:");
            Console.WriteLine($"  • Descripción: {primerProducto.Descripcion}");
            Console.WriteLine($"  • Precio: {primerProducto.Precio:C2}\n");

            // 2. El último producto
            var ultimoProducto = UltimoProducto(lista);
            Console.WriteLine("[2] Último Producto:");
            Console.WriteLine($"  • Descripción: {ultimoProducto.Descripcion}");
            Console.WriteLine($"  • Precio: {ultimoProducto.Precio:C2}\n");

            // 3. La suma de precios
            var sumaPrecios = SumarPrecios(lista);
            Console.WriteLine($"[3] Suma de Precios: {sumaPrecios:C2}\n");

            // 4. El promedio de precios
            var promedioPrecios = PromedioPrecios(lista);
            Console.WriteLine($"[4] Promedio de Precios: {promedioPrecios:C2}\n");
            EsperarEnter();

            // 5. Listar los productos con Id mayor a 15
            Console.Clear();
            Console.WriteLine("═══════════════════════════════════════════");
            Console.WriteLine(" PRODUCTOS CON ID MAYOR A 15 ");
            Console.WriteLine("═══════════════════════════════════════════\n");
            var productosIdMayor15 = FiltrarId15(lista);
            foreach (var p in productosIdMayor15)
            {
                Console.WriteLine($"  • ID: {p.Id} - {p.Descripcion} ({p.Precio:C2})");
            }
            EsperarEnter();

            // 6. Productos con precios formateados
            Console.Clear();
            Console.WriteLine("═══════════════════════════════════════════");
            Console.WriteLine(" PRECIOS FORMATEADOS ");
            Console.WriteLine("═══════════════════════════════════════════\n");
            var productosFormateados = ObtenerProductosConPrecios(lista);
            MostrarProductosConPreciosFormateados(productosFormateados);
            EsperarEnter();

            // 7. y 8. Precios máximo y mínimo
            Console.Clear();
            Console.WriteLine("═══════════════════════════════════════════");
            Console.WriteLine(" PRECIOS EXTREMOS ");
            Console.WriteLine("═══════════════════════════════════════════\n");
            var productoMaximo = ProductoPrecioMaximo(lista);
            Console.WriteLine($"[7] Precio más alto: {productoMaximo.Precio}");
            Console.WriteLine($"\t[+] Producto: {productoMaximo.Descripcion}");

            var productoMinimo = ProductoPrecioMinimo(lista);
            Console.WriteLine($"[8] Precio más bajo: {productoMinimo.Precio}");
            Console.WriteLine($"\t[+] Producto: {productoMinimo.Descripcion}");

            EsperarEnter();

            // 9. Productos con precio mayor al promedio
            Console.Clear();
            Console.WriteLine("═══════════════════════════════════════════");
            Console.WriteLine($" PRODUCTOS SOBRE EL PROMEDIO ({promedioPrecios:C2}) ");
            Console.WriteLine("═══════════════════════════════════════════\n");
            MayoresAlPrecioPromedio(lista);
            EsperarEnter();

            // 10. Productos ordenados por descripción
            Console.Clear();
            Console.WriteLine("═══════════════════════════════════════════");
            Console.WriteLine(" ORDEN DESCENDENTE POR DESCRIPCIÓN ");
            Console.WriteLine("═══════════════════════════════════════════\n");
            OrdenarProductosPorDescripcion(lista);
            EsperarEnter();

            // 11. Productos que empiezan con "A"
            Console.Clear();
            Console.WriteLine("═══════════════════════════════════════════");
            Console.WriteLine(" PRODUCTOS QUE COMIENZAN CON 'A' ");
            Console.WriteLine("═══════════════════════════════════════════\n");
            var productosEmpiezanConA = EmpiezaCon(lista, "A");
            foreach (var p in productosEmpiezanConA)
            {
                Console.WriteLine($"  • {p.Descripcion} (ID: {p.Id})");
            }
            EsperarEnter();
        }

        private void EsperarEnter()
        {
            Console.WriteLine("\nPresiona Enter para continuar...");
            Console.ReadLine();
        }
    }
}