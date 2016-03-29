using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VatTax
{
    public class VATTtaxCalculator
    {
        List<CountryVatTax> vattaxes;
        public VATTtaxCalculator(List<CountryVatTax> x)
        {
            this.vattaxes = x;
        }

        public double CalculateTax(double prise, string countryId)
        {
            double x = -1;
            for (int i = 0; i < vattaxes.Count; i++)
            {
                if (vattaxes[i].countryId.Contains(countryId))
                    x = vattaxes[i].VATTax;
            }
            if (x == -1)
            {
                throw new NotSupportedCountryException("Error in choosing the country");
            }
            return x * prise;
        }

        public double CalculateTax(double prise)
        {
            double x = -1;
            for (int i = 0; i < vattaxes.Count; i++)
            {
                if (vattaxes[i].IsDefault == true)
                {
                    x = vattaxes[i].VATTax * prise;
                    return x;
                }
            }
            return -1;
        }
    }
}
