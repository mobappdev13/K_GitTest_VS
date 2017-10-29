using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proprieta
{
    public class SaleItem
    {
        private string _nameItem;
        private double _priceItem;

        public SaleItem(string nameItem, double priceItem)
        {
            _nameItem = nameItem;
            _priceItem = priceItem;
        }


        //properties public
        public string NameItem {
            get {return _nameItem; }
            private set {_nameItem = value; }
        }

        public double PriceItem {
            get { return _priceItem; }
            private set {_priceItem = value; }
        }

    }
}
