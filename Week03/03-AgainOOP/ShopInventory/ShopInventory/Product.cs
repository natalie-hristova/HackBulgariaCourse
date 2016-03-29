using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VatTax;

namespace ShopInventory
{
    public class Product
    {
        public double PriceBefore { get; private set; }
        public double PriceAfter { get; private set; }
        public string Country { get; private set; }
        public string Name { get; private set; }
        public int Quantity { get; private set; }
        public int ProductId { get; private set; }

        public Product(double priceBefore, string country, string name, int quantity, int productId)
        {
            this.PriceBefore = priceBefore;
            this.Name = name;
            this.PriceAfter = PriceAfterTax(priceBefore, country);
            this.Country = country;
            this.Quantity = quantity;
            this.ProductId = productId;
        }

        public double PriceAfterTax(double priceBefore, string country)
        {
            VatTax.CountryVatTax bg = new VatTax.CountryVatTax("Bulgaria", 0.2, true);
            VatTax.CountryVatTax tai = new VatTax.CountryVatTax("Taiwan", 0.05, false);
            VatTax.CountryVatTax zam = new VatTax.CountryVatTax("Zambia", 0.175, false);
            VatTax.CountryVatTax aus = new VatTax.CountryVatTax("Australia", 0.1, false);
            VatTax.CountryVatTax chil = new VatTax.CountryVatTax("Chile", 0.19, false);
            VatTax.CountryVatTax dm = new VatTax.CountryVatTax("Denmark", 0.25, false);
            var x = new List<VatTax.CountryVatTax>() { bg, tai, zam, aus, chil, dm };

            VatTax.VATTtaxCalculator calc = new VatTax.VATTtaxCalculator(x);

            double a = calc.CalculateTax(priceBefore, country);
            return (a + priceBefore);
        }

    }
}
