//Program 9.	Implement a class with a protected method. Derive a class and access the protected method.

using System;

// Base class with a protected method
public class MyBaseClass
{
    protected void ProtectedMethod()
    {
        Console.WriteLine("This is a protected method in MyBaseClass.");
    }
}

// Derived class
public class MyDerivedClass : MyBaseClass
{
    public void AccessProtectedMethod()
    {
        Console.WriteLine("Calling a protected method from MyDerivedClass.");
        ProtectedMethod(); // Access the protected method from the base class
    }
}

class Program
{
    static void Main()
    {
        MyDerivedClass derivedObject = new MyDerivedClass();

        // Call the public method in the derived class, which accesses the protected method
        derivedObject.AccessProtectedMethod();
    }
}





