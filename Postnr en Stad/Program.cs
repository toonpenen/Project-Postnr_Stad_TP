using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Postnr_en_Stad
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                #region Input variabelen
                int[] postCode = { 9300, 2000, 1000, 9200, 9000, 8500, 9700, 2300 };
                string[] stad = { "Aalst", "Antwerpen", "Brussel", "Dendermonde", "Gent", "Kortrijk", "Oudenaarde", "Turnhout" };
                #endregion

                #region Data input gebruiker
                Console.WriteLine("Geef de postcode in");
                string line = new String('*',50);
                Console.WriteLine(line);
                #endregion

                #region controle en output
                int value = int.Parse(Console.ReadLine());
                int pos = Array.IndexOf(postCode, value);

                Console.WriteLine($"De stad van die postcode is: {stad[pos]}");
                #endregion

            }
        }
    }
}
