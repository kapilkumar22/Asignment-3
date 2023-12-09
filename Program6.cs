//Program 6.	Create a class with a public property. Derive another class and try to access the property.

using System;

// Base class with a public property
public class MyBaseClass
{
    // Public property
    public string MyProperty { get; set; }
}

// Derived class
public class MyDerivedClass : MyBaseClass
{
    public void AccessBaseProperty()
    {
        // Access the public property from the base class
        Console.WriteLine("Accessing MyProperty from MyDerivedClass: " + MyProperty);
    }
}

class Program
{
    static void Main()
    {
        MyDerivedClass derivedObject = new MyDerivedClass();
        
        // Set the property value
        derivedObject.MyProperty = "Hello, World!";
        
        // Access the property using the derived class
        derivedObject.AccessBaseProperty();
    }
}



