using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
namespace Cola_
{
    class Cola_para_ULEAM
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            int numero = 0;
            bool encontrado = false;
            
    
            Console.Title = "Esta es un ejemplo del TAD COLA PARA LA ULEAM";
            Queue mifila = new Queue();
            do
            {
                Console.WriteLine("\t\t\t///////COLA\\\\\\");
                Console.WriteLine("1-Insertar");
                Console.WriteLine("2-Eliminar");
                Console.WriteLine("3-Eliminar Todo");
                Console.WriteLine("4-Buscar en la Cola");
                Console.WriteLine("5-Salir");
                Console.WriteLine("Eliga una opcion: ");
                opcion = int.Parse(Console.ReadLine());
                if (opcion == 1)
                {
                    Console.WriteLine("Digite el valor a introducir: ");
                    numero = int.Parse(Console.ReadLine());
                    mifila.Enqueue(numero);
                }
                if (opcion == 2)
                {
                    numero = (int)mifila.Dequeue();
                    Console.WriteLine("El valor obtenido es: " + numero);
                }
                if (opcion == 3)
                {
                    mifila.Clear();
                }
                if (opcion == 4)
                {
                    Console.WriteLine("Digite el valor a encontrar: ");
                    numero = int.Parse(Console.ReadLine());
                    encontrado = mifila.Contains(numero);
                    Console.WriteLine("El valor es :" + encontrado);
                }
                Console.WriteLine("La cola tiene {0} elementos", mifila.Count);
                foreach (int n in mifila)
                    Console.Write("  {0}, ", n);
                Console.WriteLine("");
                Console.WriteLine("_____________");
            } while (opcion != 5);
        }
    }
}