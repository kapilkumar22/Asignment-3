//Program 5.	Develop a class with a protected internal member and create an instance in a different assembly to access it.

using System;
using AssemblyA;

class Program
{
    static void Main()
    {
        MyClass myObject = new MyClass();

        // Access the protected internal field from AssemblyB
        int value = myObject.protectedInternalField;

        Console.WriteLine("Accessed protectedInternalField from AssemblyB: " + value);
    }
}




//we will write this code for another assembly

using System;

[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("AssemblyB")]

namespace AssemblyA
{
    public class MyClass
    {
        protected internal int protectedInternalField = 42;
    }
}




