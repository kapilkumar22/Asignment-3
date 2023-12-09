//Program 4 Create a base class with protected members and derive a class to access those members.

using System;

// Base class with protected members
public class MyBaseClass
{
    protected int protectedField = 42;

    protected void ProtectedMethod()
    {
        Console.WriteLine("ProtectedMethod in MyBaseClass");
    }
}

// Derived class accessing protected members
public class MyDerivedClass : MyBaseClass
{
    public void AccessProtectedMembers()
    {
        Console.WriteLine("Accessing protectedField from MyDerivedClass: " + protectedField);
        ProtectedMethod();
    }
}

class Program
{
    static void Main()
    {
        MyDerivedClass derivedObject = new MyDerivedClass();

        // Access protected members from the derived class
        derivedObject.AccessProtectedMembers();
    }
}
