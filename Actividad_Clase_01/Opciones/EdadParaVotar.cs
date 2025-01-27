using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_Clase_01.Opciones
{
    public static class EdadParaVotar
    {
        public static void Ejecutar()
        {
            bool continuar = true; //Variable de control del bucle

            while (continuar) //Mientras continuar sea true el ciclo no termina
            {
                Console.Write("Ingresa tu edad: ");
                int edad;

                if (int.TryParse(Console.ReadLine(), out edad))
                {
                    //Se verifica si es mayor o menor de edad
                    if (edad >= 18)
                    {
                        Console.WriteLine("Puedes votar");
                        continuar = false;
                    }
                    else
                    {
                        Console.WriteLine("No puedes votar");
                        continuar = false;
                    }
                }
                else
                {
                    Console.WriteLine("Ingresa una edad correcta");
                }
            }
        }


        public static void EjecutarConIf()
        {
            Console.Write("Ingresa tu edad: ");
            int edad = int.Parse(Console.ReadLine());

            //A traves de un if, se verifica si es mayor o menor de edad 
            if (edad >= 18)
            {
                Console.WriteLine("Puedes votar.");
            }
            else
            {
                Console.WriteLine("No puedes votar.");
            }
        }
    }
}
