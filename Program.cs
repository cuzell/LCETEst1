using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LCETEst1
{
    class Program
    {

        // david@headspring.com
        //2000000000
        static void Main(string[] args)
        {
            var fizzyBuzzy = new LCETEst1.FizzBuzz { start = 1, stop = 200 };

            var l = fizzyBuzzy.writeNumbers();
            foreach (var s in l)
                Console.WriteLine(s);
            Console.ReadLine();

            // Different Output text
            fizzyBuzzy.Fizz = "By three";
            fizzyBuzzy.Buzz = "By five";
            l = fizzyBuzzy.writeNumbers();
            foreach (var s in l)
                Console.WriteLine(s);
            Console.ReadLine();

            // Legacy\Backward compatible
            Console.WriteLine(fizzyBuzzy.writeNumbers(1, 2000000000));

            Console.ReadLine();
        }
    }
}
