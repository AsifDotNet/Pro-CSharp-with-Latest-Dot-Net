using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhaseOneWorkShop
{
    public class EscapeChars
    {
        public static void EscapeChar()
        {
            Console.WriteLine("=> Escape characters:");
            string strWithTabs = "Model\tColor\tSpeed\tPet Name ";
            Console.WriteLine(strWithTabs);
            Console.WriteLine("Everyone loves \"Hello World\" ");
            Console.WriteLine("C:\\MyApp\\bin\\Debug ");
            // Adds a total of 4 blank lines (3 escaped, 1 from WriteLine).
            Console.WriteLine("All finished.\n\n\n ");
            Console.WriteLine();
        }
    }
}
