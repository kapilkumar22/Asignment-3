//Program 3 implement a class with an internal field and access it from a different assembly.

using System;
using AssemblyA;

class Program
{
    static void Main()
    {
        MyClass myObject = new MyClass();

        // Access the internal field from AssemblyA
        int value = myObject.internalField;

        Console.WriteLine("Accessed internalField from AssemblyB: " + value);
    }
}


//we will arite this code in another program


using System;

[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("AssemblyB")]

namespace AssemblyA
{
    internal class MyClass
    {
        internal int internalField = 42;
    }
}
