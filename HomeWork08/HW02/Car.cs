using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW02
{
    public class Car : Transport
    {
        public override void Move()
        {
            Console.WriteLine("Автомобиль движется.");
            Engine?.Start();
        }
    }
}
