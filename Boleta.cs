using System;

namespace Boleta
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------Tola de la compra---------");

            string producto;
            int precio, cantidad;
            int totalCompra = 0;
            
            var boleta = new System.Text.StringBuilder();
            boleta.Append("producto\tCantidad\tPrecio\tTotal\n");

            while (true)
            {
                Console.Write("Ingrese el nombre del producto ( Escrtiba 'salir' para finalizar): ");
                producto = Console.ReadLine();

                if (producto.Equals("salir", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }

                Console.Write("Ingrese cantidad: ");
                cantidad = int.Parse(Console.ReadLine());

                Console.Write("Ingrese el precion por unidad: ");
                precio = int.Parse(Console.ReadLine()); 

                int totalProducto = cantidad * precio;
                totalCompra += totalProducto;

                boleta.Append($"{producto}\t\t{cantidad}\t\t{precio}\t\t{totalProducto}\n");


            }
            boleta.Append("---------------------------\n");
            boleta.Append($"Total de la compra:\t{totalCompra}\n");

            Console.WriteLine(boleta.ToString());

        }
    }
}