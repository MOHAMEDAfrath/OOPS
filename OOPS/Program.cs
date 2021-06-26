using System;

namespace OOPS
{
    class Program
    {
        static void Main(string[] args)
        {
            Inheritance inheritance = new Multiplication();
            Console.WriteLine("Multiplied :"+ inheritance.addOrMultiply(5, 3));
            inheritance = new Inheritance();
            Console.WriteLine("Added :" +inheritance.addOrMultiply(3,5));
            OverloadingMethod overloadingMethod = new OverloadingMethod();
            Console.WriteLine("Added Two numbers: "+overloadingMethod.addNumbers(1, 2));
            Console.WriteLine("Added Three Numbers: "+overloadingMethod.addNumbers(1, 2,3));
            DisplayingName displayingName = new DisplayingName();
            Console.WriteLine("My Name:"+displayingName.displayname());
            DisplayCollegeName displayCollegeName = new DisplayCollegeName();
            Console.WriteLine("My College name: "+displayCollegeName.displayname());
            EncapsulationDemo encapsulationDemo = new EncapsulationDemo();
            encapsulationDemo.myage = 21;
            Console.WriteLine("My Age: "+encapsulationDemo.myage);
            Console.WriteLine("static Demo with concatenation example: "+StaticDemo.concatenate());
            









        }
    }
}
