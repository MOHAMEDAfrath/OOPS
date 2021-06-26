using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    class EncapsulationDemo
    {
        private int age;
        public int myage
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
    }
}
