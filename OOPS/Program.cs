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
            inheritance.addOrMultiply(3,5);
            
           


            
        }
    }
}
