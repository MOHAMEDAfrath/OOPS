using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    public class Inheritance
    {
        public virtual int addOrMultiply(int number1,int number2)
        {
            return number1 + number2;
        }

    }
    class Multiplication : Inheritance
    {
        public override int addOrMultiply(int number1,int number2)
        {
            return number2 * number1;
        }
    }
}
