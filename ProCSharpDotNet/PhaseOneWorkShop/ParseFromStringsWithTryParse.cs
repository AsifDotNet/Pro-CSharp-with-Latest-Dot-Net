using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhaseOneWorkShop
{
    public class ParseFromStringsWithTryParse
    {
        public static void ParseFromStringsWithTryParse1()
        {
            Console.WriteLine("-----Using TryParse to Parse Values from String Dat---");
            Console.WriteLine("Data type parsing with TryParse:");
            if (bool.TryParse("True", out bool b))
            {
                Console.WriteLine("Value of b: {0}", b);
            }        
            else
            {
                Console.WriteLine("Default value of b: {0}", b);
            }
            string value = "Hello";
            if (double.TryParse(value, out double d))
            {
                Console.WriteLine("Value of d: {0}", d);
            }
            else
            {
                Console.WriteLine("Failed to convert the input ({0}) to a double and the variable was ", value,d);
            }
            
        }
    }
}
