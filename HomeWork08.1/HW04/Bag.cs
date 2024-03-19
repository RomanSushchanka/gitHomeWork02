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

        public void SetIsOpen(bool value)
        {
            _isOpen = value;
        }

        //public bool isOpen
        //{
        //    get { return _isOpen; }
        //    set { _isOpen = value; }
        //}



        public bool AddValueToArray (string value)
        {
            if (_isOpen == false)
            {
                //return false;
                throw new InvalidOperationException("Сумка закрыта!");
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
                throw new InvalidOperationException("Сумка заполнена!");
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
            if (_isOpen == false)
            {
                //return null;
                throw new InvalidOperationException("Сумка закрыта!");
            }

            string a = _item[index];
            _item[index] = "";
            return a;

            

        }
    }
}
