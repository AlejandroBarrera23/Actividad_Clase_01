using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_Clase_01.Opciones
{
    public static class ParImpar
    {
        public static void Ejecutar()
        {
            Console.Write("Ingresa un numero entero: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
                Console.WriteLine("El numero es par");
            else
                Console.WriteLine("El numero es impar");
        }
    }
}
