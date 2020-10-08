using System;
using System.Collections.Generic;
using System.Text;

namespace ModelLib
{
    public class FilterItem
    {
        private int _lowQuantity;
        private int _highQuantity;


        public FilterItem(int lowQuantity, int highQuantity)
        {
            _lowQuantity = lowQuantity;
            _highQuantity = highQuantity;
        }

        public FilterItem()
        {

        }

        public int LowQuantity
        {
            get => _lowQuantity;
            set => _lowQuantity = value;
        }

        public int HighQuantity
        {
            get => _highQuantity;
            set => _highQuantity = value;
        }

        public override string ToString()
        {
            return $"{nameof(LowQuantity)}: {LowQuantity}, {nameof(HighQuantity)}: {HighQuantity}";
        }
    }
}
