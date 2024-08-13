using System;

public class Hoteleria
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Bienvenid@ al hotel 'El descanso' ");
        Console.WriteLine("Ingrese el tipo de habitación (normal, normal para 2, normal familiar, premium para 2 o cuatro personas): ");
        string tipo_Habitacion = Console.ReadLine(); // se almacena en la variable.

        Console.WriteLine("Ingrese la cantidad de personas: ");
        int personas = int.Parse(Console.ReadLine());    // se almacena en la variable

        Console.WriteLine("Ingrese la edad del cliente (si aplica): ");
        int Edades = int.Parse(Console.ReadLine());    // se almacena en la variable

        Console.WriteLine("Ingrese la cantidad de niños menores de 3 años: ");
        int niños_menores = int.Parse(Console.ReadLine());  // se almacena en la variable

        Console.WriteLine("Ingrese la cantidad de dias: ");
        int n_dias = int.Parse(Console.ReadLine());         // se almacena en la variable

        int costo_habitacion = 0;   // calcular costos
        int costo_Personas = 0;

        switch (tipo_Habitacion)    // bucle switch, como la nintendo xd
        {
            case "normal":
            case "normal para 2":
            case "normal familiar":
                costo_habitacion = 5000;        // -    El valor por día son $5000 por habitación normal                									
                costo_Personas = 2000;              // más $2000 por persona
                break;
            case "premium para 2 o cuatro personas":    // el premium es de $10000 
                costo_habitacion = 10000;                 // más $4000 por persona.	
                costo_Personas = 4000;
                break;
            default:
                Console.WriteLine("Tipo de habitación no válido.");
                return;
        }

        double costo_total = costo_habitacion + (costo_Personas * personas) * n_dias;

        switch (Edades)
        {
            case 60:
                costo_total *= 0.9; //  10% para personas mayores de 60 años
                break;
        }

        if (niños_menores > 0)
        {
            costo_total *= 0.95; // a los familiares que tienen hijos menores a 3 años se les hace un descuento del 5%, 
                                 //los demás se cobra precio normal. 
        }

        Console.WriteLine("Resumen: ");
        Console.WriteLine("Tipo de habitación: " + tipo_Habitacion);
        Console.WriteLine("Cantidad de personas: " + personas);
        Console.WriteLine("Numero de dias : " + n_dias);
        Console.WriteLine("Total a pagar: $" + costo_total);
    }
}