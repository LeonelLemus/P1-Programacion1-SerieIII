using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Programa1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¡Hola! Bienvenido.");
            Console.WriteLine("Ingrese el valor de 3 productos:");

            double sumaValores = 0;
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Producto {i + 1}: Q");
                double ingresoValor = double.Parse(Console.ReadLine());
                sumaValores += ingresoValor;

               
            }
            Console.WriteLine($"El total es {sumaValores}");

            if ( sumaValores > 500 ) 
            {
                double descuento = sumaValores * 0.10;
                double condescuento = sumaValores - descuento;
                Console.WriteLine("Tu monto total excede los 500, por lo que tienes un descuento del 10%");
                Console.WriteLine($"hora tu monto total es de : {condescuento}");


                    }
            Console.ReadLine();



        }
    }
}
