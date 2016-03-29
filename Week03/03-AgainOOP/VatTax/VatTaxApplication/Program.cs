using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VatTaxApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            VatTax.CountryVatTax bg = new VatTax.CountryVatTax("Bulgaria",0.2,true);
            VatTax.CountryVatTax tai = new VatTax.CountryVatTax("Taiwan",0.05, false);
            VatTax.CountryVatTax zam = new VatTax.CountryVatTax("Zambia", 0.175, false);
            VatTax.CountryVatTax aus = new VatTax.CountryVatTax("Australia", 0.1, false);
            VatTax.CountryVatTax chil = new VatTax.CountryVatTax("Chile", 0.19, false);
            VatTax.CountryVatTax dm= new VatTax.CountryVatTax("Denmark", 0.25, false);
            var x = new List<VatTax.CountryVatTax>() { bg, tai, zam,aus,chil,dm };
            VatTax.VATTtaxCalculator calc = new VatTax.VATTtaxCalculator(x);
            Console.WriteLine(calc.CalculateTax(12 ));
        }
    }
}
