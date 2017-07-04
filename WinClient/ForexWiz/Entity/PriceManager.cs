using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeoStudio.Entity
{
    class PriceAlerter
    {

        public PriceAlerter()
        {
            
        }




    }

    public struct Currency
    {
        public string Symbol;
        float[] Price;
        public Currency(string s)
        {
            this.Symbol = s;
            Price = new float[3] { 0, 0, 0 };
        }
    }
}
