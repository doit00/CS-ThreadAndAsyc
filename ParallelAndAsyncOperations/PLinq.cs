using System;
using System.Linq;
using System.Threading.Tasks;

namespace Demos
{
    class PLinq
    {
        public static void ParallelOperations()
        {
            Parallel.For(1, 10, (i) => Console.WriteLine(i));
        }

        public static void PLinqCollections()
        {

            var numbers = Enumerable.Range(1, 10000);
            var q1 = numbers.AsParallel().Where(n => n % 10 == 0);
            //q1.ForAll(n => Console.WriteLine(n));
            var q2 = numbers.AsParallel().WithDegreeOfParallelism(2);
            //q2.ForAll(n => Console.WriteLine(n));

            var q3 = numbers.AsParallel().AsOrdered().Where(n => n % 10 == 0);
            //q3.ForAll(n => Console.WriteLine(n));
            foreach (var n in q3)
            {
                Console.WriteLine(n);
            }


        }

    }
}
