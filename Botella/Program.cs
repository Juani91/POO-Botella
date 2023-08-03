using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Botella
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int r, monto = 100;

            Botella B1 = new Botella("Plástico", "Transparente");

            Console.WriteLine("El material de la botella es: " + B1.Material);
            Console.WriteLine("El color de la botella es: " + B1.Color);
            Console.WriteLine("La capacidad de la botella es: " + B1.Capacidad + "ml");
            Console.WriteLine("La cantidad actual de la botella es: " + B1.CantidadActual + "ml");


            //B1.Recargar(monto);
            r = B1.Recargar(monto); // ESTABAS RECARGANDO 2 VECES! AL PONER "R=" TAMBIEN ESTABAS CITANDO A QUE SE RECARGUE DENUEVO

            Console.WriteLine(" ");
            Console.WriteLine("Recargamos..");
            Console.WriteLine("La cantidad actual de la botella es: " + B1.CantidadActual + "ml");
            Console.WriteLine("El monto de la recarga es de: " + r);

            B1.Beber();

            Console.WriteLine(" ");
            Console.WriteLine("Bebemos..");
            Console.WriteLine("La cantidad actual de la botella es: " + B1.CantidadActual + "ml");

            //B1.Recargar(monto);
            r = B1.Recargar(monto);

            Console.WriteLine(" ");
            Console.WriteLine("Recargamos..");
            Console.WriteLine("La cantidad actual de la botella es: " + B1.CantidadActual + "ml");
            Console.WriteLine("El monto de la recarga es de: " + r);

            Console.ReadKey();
        }
    }
}
