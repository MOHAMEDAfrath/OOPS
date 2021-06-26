using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    abstract class AbstractDemo
    {
        public abstract string displayname();
       
    }
        class DisplayingName : AbstractDemo
    {
        public override string displayname()
        {
            return "Vijay";
        }
    }
        class DisplayCollegeName : AbstractDemo
    {
        public override string displayname()
        {
            return "VEC";
        }
    }
}
