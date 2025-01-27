using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_Clase_01.Opciones
{
    public static class NumeroMayor
    {
        public static void Ejecutar()
        {
            Console.Write("Ingresa el primer numero: ");
            int numero1 = int.Parse(Console.ReadLine());

            Console.Write("Ingresa el segundo numero: ");
            int numero2 = int.Parse(Console.ReadLine());

            if (numero1 > numero2)
                Console.WriteLine("El numero mayor es: " + numero1);
            else if (numero1 < numero2)
                Console.WriteLine("El numero mayor es: " + numero2);
            else
                Console.WriteLine("Los numeros son iguales");
        }
    }
}
