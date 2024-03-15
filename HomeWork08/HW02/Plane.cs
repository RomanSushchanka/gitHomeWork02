using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW02
{
    public class Plane : Transport
    {

        public override void Move()
        {
            Console.WriteLine("Самолет летит.");
            Engine?.Start();
        }
    }
}
