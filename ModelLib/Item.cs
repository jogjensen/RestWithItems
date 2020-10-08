using System;
using System.Collections.Generic;

namespace ModelLib
{
    public class Item
    {
        
        #region Instance fields
        private int _id;
        public string _name;
        public string _quality;
        public double _quantity;
        #endregion

        public Item(int id, string name, string quality, double quantity)
        {
            _id = id;
            _name = name;
            _quality = quality;
            _quantity = quantity;
        }

        public Item()
        {

        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Quality
        {
            get { return _quality; }
            set { _quality = value; }
        }

        public double Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }

        #region Methods

        public override string ToString()
        {
            return $"{nameof(Id)}: {Id}, {nameof(Name)}: {Name}, {nameof(Quality)}: {Quality}, {nameof(Quantity)}: {Quantity}";
        }


        #endregion


    }
}
