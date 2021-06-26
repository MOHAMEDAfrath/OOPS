using System;

namespace OOPS
{
    class Program
    {
        static void Main(string[] args)
        {
            Inheritance inheritance = new Multiplication();
            Console.WriteLine(inheritance.addOrMultiply(5, 3));
            inheritance = new Inheritance();
            Console.WriteLine(inheritance.addOrMultiply(3,5));
            OverloadingMethod overloadingMethod = new OverloadingMethod();
            Console.WriteLine(overloadingMethod.addNumbers(1, 2));
            Console.WriteLine(overloadingMethod.addNumbers(1, 2,3));







        }
    }
}
