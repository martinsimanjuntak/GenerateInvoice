using System;
using RomanNumerals;
namespace GenerateInvoice
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 10982;
           Console.WriteLine(GenerateInvoice(counter)); 
        }

        private static string GenerateInvoice(int count)
        {            
            string temp1 = DateTime.Now.ToString("yyyyMM");
            string temp2 = DateTime.Now.ToString("ddd").Substring(0, 2).ToUpper();
            int day = DateTime.Now.Day;
            int year = DateTime.Now.Year;
            var roman_day = new RomanNumeral(day);
            var roman_year = new RomanNumeral(year).ToString().Substring(2);

            return $"INV/{temp1}/{temp2}/{roman_day}/{roman_year}/{++count}";
        }
      
    }
}
