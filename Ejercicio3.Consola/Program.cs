using Ejercicio3.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            double kilometros=0,milla=0;
            Kilómetros kilómetros = new Kilómetros(kilometros);
            Millas millas = new Millas(milla);

            Console.Write("ingrese kilometros:");
            kilometros= double.Parse(Console.ReadLine());
            Console.Write("ingrese Millas:");
            milla = double.Parse(Console.ReadLine());

            var Sumar = milla + kilometros;
            var Restar = milla - kilometros;
            Console.WriteLine($"suma: {Sumar} ");
            Console.WriteLine($"resta: {Restar} ");


            Kilómetros kilómetros1 = new Kilómetros(33);
            Kilómetros kilómetros2 = new Kilómetros(33);
            if (kilómetros1==kilómetros2)
            {
                Console.WriteLine("son Iguales");
            }
            else
            {
                Console.WriteLine("son distinto");
            }
            Console.ReadLine();
        }
    }
}
