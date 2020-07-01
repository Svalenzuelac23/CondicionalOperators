using System;
using System.Collections.Generic;
using System.Linq;

namespace CondicionalOperators
{
    class Program
    {
        static void Main(string[] args)
        {

            //documentacion
            //https://docs.microsoft.com/es-es/dotnet/csharp/language-reference/operators/member-access-operators#null-conditional-operators--and-

            double sumar(List<double[]> numeros, int indexaSumar)
            {
                return numeros?[indexaSumar]?.Count() ?? double.NaN;
            }

            var suma1 = sumar(null, 0);

            var numerosLista = new List<double[]>
            {
                new[] {1.0,5.0,2.0,3.0,1.0},
                new[] {1.0,2.0},
                null
            };

            var suma2 = sumar(numerosLista, 1);

            var suma3 = sumar(numerosLista, 2); 
            
            Console.WriteLine(suma1);
            Console.WriteLine(suma2);
            Console.WriteLine(suma3);
            Console.Read();
        }
    }
}
