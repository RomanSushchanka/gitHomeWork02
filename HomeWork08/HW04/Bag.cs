using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HW04
{
    internal class Bag
    {
        private string[] _item = new string[8];
        private bool _isOpen;


        public bool isOpen 
        {
            get { return _isOpen; } 
            set {  _isOpen = value; } 
        }

        public bool AddValueToArray (string value)
        {
            if (isOpen == true)
            {
                return false;
            }

            bool b = true;
            for (int i = 0; i < _item.Length; i++)
            {
                if (_item[i] == null)
                {
                    b = true;
                }
            }

            if (b == false)
            {
                throw new InvalidOperationException("Bag is full");
            }

            for (int i = 0; i < _item.Length; i++)
            {
                if (string.IsNullOrEmpty(_item[i]))
                {
                    _item[i] = value;
                    return true;
                }
            }
            return false;
        }
        
        public string TakeOutValueToArray (int index)
        {
            if (isOpen == false)
            {
                return null;
            }

            string a = _item[index];
            _item[index] = "";
            return a;

            

        }
    }
}
