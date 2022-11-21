using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhaseOneWorkShop
{
    public class interpolation
    {
        public static void Interpolation()
        {
            Console.WriteLine("=> String interpolation:\a");
            // Some local variables we will plug into our larger string
            int age = 4;
            string name = "Soren";
            // Using curly-bracket syntax.
            string greeting = string.Format("Hello {0} you are {1} years old.", name, age);
            Console.WriteLine(greeting);
            // Using string interpolation
            string greeting2 = $"Hello {name} you are {age} years old.";
            Console.WriteLine(greeting2);
        }
    }
}
