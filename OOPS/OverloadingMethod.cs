using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    class OverloadingMethod
    {
        public int addNumbers(int number1,int number2)
        {
            return number1 + number2;
        }
        public int addNumbers(int number1, int number2,int number3)
        {
            return number1 + number2+number3;
        }
    }
}
