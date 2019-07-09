using System;
using System.Linq;

namespace MyFisrtConsoleAppUsingGitHub
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Alter Text For Example!");

            Teste teste = new Teste();

            Console.WriteLine($"{teste?.Pointer}");

            var returnFindPrime = PrimeNumber(9999999);

            Console.ReadKey();
        }

        public class Teste
        {
            public int? Pointer { get; set; } = null;
        }

        static System.Collections.Generic.List<int> PrimeNumber(long num)
        {
            var resultPrime  = Enumerable.Range(0,(int)(Math.Floor(2.52 * Math.Sqrt(num) / Math.Log(num)))).Aggregate(
            Enumerable.Range(2,(int)(num - 1.0)).ToList(),
            (result, index) => {
                var bp = result[index]; var sqr = bp * bp;
                result.RemoveAll(i => i >= sqr && i % bp == 0);
                return result;
            }
        );

            return resultPrime;
        }

    }
}
