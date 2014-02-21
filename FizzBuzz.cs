using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LCETEst1
{
    public class FizzBuzz
    {
        public int start { get; set; }
        public int stop { get; set; }
        public string Fizz { get; set; }
        public string Buzz { get; set; }

        public FizzBuzz() 
        {
            setDefaults();
        }

        public IEnumerable<String> writeNumbers()
        {
            validateProperties();
            for (var x = start; x <= stop; x++)
            {
                if ((x % 3 == 0) && (x % 5 == 0))
                    yield return String.Format("{0} {1}", Fizz, Buzz); 
                else if (x % 3 == 0)
                    yield return Fizz;
                else if (x % 5 == 0)
                    yield return Buzz;
                else
                    yield return (x.ToString());
            }
        }

        public string writeNumbers(int st, int en)
        {
            setDefaults();
            start = st;
            stop = en;
            validateProperties();
            StringBuilder sb = new StringBuilder();
            try
            {
                foreach (var s in writeNumbers())
                    sb.AppendLine(s);
            }
            catch (OutOfMemoryException ex)
            {
                throw new ApplicationException("The data is too large, please use IEnumerable overload", ex);
            }
            return sb.ToString();
        }

        void validateProperties()
        {
            if (start > stop)
                throw new ApplicationException("Bad Range");
        }
        void setDefaults()
        {
            start = 1;
            stop = 100;
            Fizz = "Fizz";
            Buzz = "Buzz";
        }
    }
}
