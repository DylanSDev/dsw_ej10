using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsw2025Ej10
{
    internal class Producto
    {
        public int Id { get; private set; }
        public string Descripcion { get; private set; }
        public decimal Precio { get; private set; }

        public Producto(int id, string descripcion, decimal precio)
        {
            Id = id;
            Descripcion = descripcion;
            Precio = precio;
        }

        public static List<Producto> CrearListaDeEjemplo()
        {
            return
            [
                new (1, "Laptop Dell XPS 13", 1200.99m),
                new (2, "Smartphone Samsung Galaxy S23", 999.99m),
                new (3, "Tablet Apple iPad Pro", 799.99m),
                new (4, "Monitor LG UltraWide", 349.99m),
                new (5, "Teclado Mecánico Logitech", 129.99m),
                new (6, "Mouse Inalámbrico Microsoft", 49.99m),
                new (7, "Auriculares Sony WH-1000XM5", 299.99m),
                new (8, "Cámara Canon EOS R6", 2499.99m),
                new (9, "Impresora HP LaserJet Pro", 199.99m),
                new (10, "Disco Duro Externo Seagate 2TB", 89.99m),
                new (11, "Memoria USB Kingston 64GB", 19.99m),
                new (12, "Smartwatch Apple Watch Series 8", 399.99m),
                new (13, "Consola PlayStation 5", 499.99m),
                new (14, "Televisor Samsung QLED 55\"", 1099.99m),
                new (15, "Barra de Sonido Bose", 249.99m),
                new (16, "Router WiFi TP-Link", 59.99m),
                new (17, "Cargador Portátil Anker 20000mAh", 39.99m),
                new (18, "Altavoz Bluetooth JBL", 99.99m),
                new (19, "Cámara de Seguridad Ring", 149.99m),
                new (20, "Lámpara Inteligente Philips Hue", 49.99m),
                new (21, "Drone DJI Mini 3 Pro", 759.99m),
                new (22, "Proyector Epson Home Cinema", 599.99m),
                new (23, "Silla Gamer Razer", 399.99m),
                new (24, "Microondas Panasonic", 129.99m),
                new (25, "Refrigerador LG InstaView", 1999.99m),
                new (26, "Cafetera Nespresso Vertuo", 179.99m),
                new (27, "Aspiradora Dyson V15", 699.99m),
                new (28, "Purificador de Aire Xiaomi", 129.99m),
                new (29, "Bicicleta Eléctrica Specialized", 2499.99m),
                new (30, "Patinete Eléctrico Segway", 499.99m)
            ];
        }
    }
}