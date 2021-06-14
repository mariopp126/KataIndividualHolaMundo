using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace kataIndividualHolaMundo
{
    class Program
    {
        static void Main(string[] args)
        {
            var holaMundo = "Hola Mundo";
            var noSpaces = Regex.Replace(holaMundo, @"\s", "");
            Console.WriteLine("{0}", noSpaces);
        }
    }
}
