using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_Clase_01.Opciones
{
    public static class AdivinaNumero
    {
        public static void Ejecutar()
        {
            Random random = new Random();
            int numeroAleatorio = random.Next(1, 101); //Se genera un numero entre 1 y 100
            int intento; //Variable para guardar el numero ingresado

            Console.WriteLine("He generado un numero entre 1 y 100 ¡Adivina el numero!");

            do
            {
                Console.Write("Ingresa tu suposicion: ");
                intento = int.Parse(Console.ReadLine()); //Se convierte el ingreso del dato en un entero

                //A traves de un if, se compara el numero ingresado con el generado
                if (intento < numeroAleatorio)
                {
                    Console.WriteLine("El numero es mayor");
                }
                else if (intento > numeroAleatorio)
                {
                    Console.WriteLine("El numero es menor");
                }
                else
                {
                    Console.WriteLine("¡Excelente! Adivinaste el numero");
                }
            } while (intento != numeroAleatorio); //El ciclo se mantiene hasta quee se adivine el numero
        }
    }
}
