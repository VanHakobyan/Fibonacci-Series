using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatedFibonacciSequence
{
    class Program
    {
        static IEnumerable<int> GetCalculatedFibonacciSequence()
        {
            var current = 1;
            var b = 0;
            var next = 0;
            yield return next;
            yield return current;
            while (true)
            {
                next = current + b;
                yield return next;
                b = current;
                current = next;
            }
        }
        static void Main(string[] args)
        {
            foreach (var item in GetCalculatedFibonacciSequence().Skip(0).Take(100))
            {
                Console.WriteLine(item);
            }
        }
    }
}
