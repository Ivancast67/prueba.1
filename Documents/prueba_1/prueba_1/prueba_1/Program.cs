using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>();
            int numero;
            int suma = 0;
            int mayor = int.MinValue;
            int menor = int.MaxValue;

            Console.WriteLine("Introduce números (un número negativo para terminar):");

            while (true)
            {
                // Leer el número //
                numero = int.Parse(Console.ReadLine());

                // Si el número es negativo, salir del bucle
                if (numero < 0)
                {
                    break;
                }

                // Agregar el número a la lista //
                numeros.Add(numero);

                // Sumar el número //
                suma += numero;

                // Actualizar el mayor y menor número
                if (numero > mayor)
                {
                    mayor = numero;
                }

                if (numero < menor)
                {
                    menor = numero;
                }
            }

            // resultados // 
            Console.WriteLine($"Suma de los números: {suma}");
            Console.WriteLine($"Mayor número: {mayor}");
            Console.WriteLine($"Menor número: {menor}");
        }
    }
}
        
    

