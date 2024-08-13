using System;
using System.Collections.Generic;

namespace Restaurante_caja
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al restaurante"); // Título de bienvenida

            // Precios
            double precioChurrascoItaliano = 3500;
            double precioBarraLuco = 3000;
            double precioFajitaPollo = 3000;
            double precioCompletoAleman = 2500;
            double precioCompletoItaliano = 2500;
            double precioPapasFritas = 1000;
            double precioBebidaExpress = 500;

                     // Datos del cajero
            string nombreCajero = "Juan";
            string rutCajero = "20.234.456-3";

            double totalCaja = 0;

                                 // Lista para almacenar las ventas
            List<string> ventas = new List<string>();

            while (true)
            {
                // Menú
                Console.WriteLine("---Menú---");
                Console.WriteLine("----Ingrese una Opción----");

                Console.WriteLine("1. Churrasco italiano");
                Console.WriteLine("2. Barros luco");
                Console.WriteLine("3. Fajitas de pollo");
                Console.WriteLine("4. Completo alemán");
                Console.WriteLine("5. Completo italiano");
                Console.WriteLine("6. Papas fritas");
                Console.WriteLine("7. Bebida express");
                Console.WriteLine("8. Ver caja actual");
                Console.WriteLine("9. Cerrar caja");

                if (int.TryParse(Console.ReadLine(), out int opcion))
                {
                    if (opcion >= 1 && opcion <= 7)
                    {
                        Console.WriteLine("Ingrese la cantidad:");
                        if (int.TryParse(Console.ReadLine(), out int cantidad) && cantidad > 0)
                        {
                            string producto = "";
                            double precio = 0;

                            switch (opcion) // Menú de Opciones
                            {
                                case 1:
                                    producto = "Churrasco italiano";
                                    precio = precioChurrascoItaliano;
                                    break;
                                case 2:
                                    producto = "Barros luco";
                                    precio = precioBarraLuco;
                                    break;
                                case 3:
                                    producto = "Fajitas de pollo";
                                    precio = precioFajitaPollo;
                                    break;
                                case 4:
                                    producto = "Completo alemán";
                                    precio = precioCompletoAleman;
                                    break;
                                case 5:
                                    producto = "Completo italiano";
                                    precio = precioCompletoItaliano;
                                    break;
                                case 6:
                                    producto = "Papas fritas";
                                    precio = precioPapasFritas;
                                    break;
                                case 7:
                                    producto = "Bebida express";
                                    precio = precioBebidaExpress;
                                    break;
                            }

                            totalCaja += precio * cantidad;
                            ventas.Add($"{cantidad} x {producto} - ${precio * cantidad}");
                        }
                        else
                        {
                            Console.WriteLine("Cantidad no válida.");
                        }
                    }
                    else if (opcion == 8)
                    {
                        Console.WriteLine("Total de la caja: ${0}", totalCaja);
                        Console.WriteLine("\nProductos :");
                        foreach (var venta in ventas)
                        {
                            Console.WriteLine(venta);
                        }                        
                    }

                    else if (opcion == 9)
                    {
                        Console.WriteLine("Cerrando caja...");

                        Console.WriteLine("Resumen de caja:");
                        Console.WriteLine("Fecha y hora: {0}", DateTime.Now);
                        Console.WriteLine("Cajer@: {0} {1}", nombreCajero, rutCajero);

                        Console.WriteLine("\nProductos vendidos:");
                        foreach (var venta in ventas)
                        {
                            Console.WriteLine(venta);

                        }
                        Console.WriteLine("----Total vendido----> ${0}", totalCaja);

                        return;

                    }

                    else
                    {
                        Console.WriteLine("Opción no válida.");
                    }
                }
                else
                {
                    Console.WriteLine("Por favor, ingrese un número válido.");
                }
            }
        }
    }
}
