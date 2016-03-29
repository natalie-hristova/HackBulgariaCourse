using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VatTax
{
    public class CountryVatTax
    {
        public readonly string countryId;
        public readonly double VATTax;
        public readonly bool IsDefault;

        public CountryVatTax(string countryId, double VATTax,bool IsDefault)
        {
            this.countryId = countryId;
            this.VATTax = VATTax;
            this.IsDefault = IsDefault;
        }
    }
}
