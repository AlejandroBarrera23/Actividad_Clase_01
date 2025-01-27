using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_Clase_01.Opciones
{
    public static class CalificacionLetra
    {
        public static void Ejecutar()
        {
            Console.Write("Ingresa tu calificacion del 0 al 100: ");
            int calificacion = int.Parse(Console.ReadLine());

            if (calificacion >= 90)
                Console.WriteLine("Obtuviste una A");
            else if (calificacion >= 80)
                Console.WriteLine("Obtuviste una B");
            else if (calificacion >= 70)
                Console.WriteLine("Obtuviste una C");
            else if (calificacion >= 60)
                Console.WriteLine("Obtuviste una D");
            else
                Console.WriteLine("Obtuviste una F");
        }

        public static void EjecutarConSwitch()
        {
            Console.Write("Ingresa tu calificacion del 0 al 100: ");
            int calificacion = int.Parse(Console.ReadLine());

            switch (calificacion / 10)
            {
                case 10:
                case 9:
                    Console.WriteLine("Obtuviste una A");
                    break;
                case 8:
                    Console.WriteLine("Obtuviste una B");
                    break;
                case 7:
                    Console.WriteLine("Obtuviste una C");
                    break;
                case 6:
                    Console.WriteLine("Obtuviste una D");
                    break;
                default:
                    Console.WriteLine("Obtuviste una F");
                    break;
            }
        }
    }
}
