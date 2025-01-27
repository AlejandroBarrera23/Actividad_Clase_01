
using System;
using Actividad_Clase_01.Opciones;

namespace Actividad_Clase_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion; //Variable para almacenar la opcion seleccionada

            do
            {
                // Mostramos el menu principal
                Console.WriteLine("\n============= Menu Principal =============");
                Console.WriteLine("1. Adivina el numero");
                Console.WriteLine("2. Verifica si puedes votar");
                Console.WriteLine("3. Convierte calificacion a letra");
                Console.WriteLine("4. Determina si un numero es par o impar");
                Console.WriteLine("5. Encuentra el numero mayor");
                Console.WriteLine("6. Determina si puedes votar con if");
                Console.WriteLine("7. Dia de la semana con numeros");
                Console.WriteLine("8. Calificacion con switch");
                Console.WriteLine("0. Salir");
                Console.Write("Elige una opcion: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        AdivinaNumero.Ejecutar();
                        break;
                    case 2:
                        EdadParaVotar.Ejecutar();
                        break;
                    case 3:
                        CalificacionLetra.Ejecutar();
                        break;
                    case 4:
                        ParImpar.Ejecutar();
                        break;
                    case 5:
                        NumeroMayor.Ejecutar();
                        break;
                    case 6:
                        EdadParaVotar.EjecutarConIf();
                        break;
                    case 7:
                        DiaDeLaSemana.Ejecutar();
                        break;
                    case 8:
                        CalificacionLetra.EjecutarConSwitch();
                        break;
                    case 0:
                        Console.WriteLine("Fin del programa");
                        break;
                    default:
                        Console.WriteLine("Opcion no valida");
                        break;
                }
            } while (opcion != 0); //Se repite el menu hasta que el usuario ingrese 0
        }
    }
}
