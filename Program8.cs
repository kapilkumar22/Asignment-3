//Program 8 program to Develop a class with a private method. Provide a public method that calls the private method.

using System;

public class MyClass
{
    // Private method
    private void PrivateMethod()
    {
        Console.WriteLine("This is a private method.");
    }

    // Public method that calls the private method
    public void PublicMethod()
    {
        Console.WriteLine("This is a public method.");
        PrivateMethod(); // Call the private method
    }
}

class Program
{
    static void Main()
    {
        MyClass myObject = new MyClass();

        // Call the public method, which in turn calls the private method
        myObject.PublicMethod();
    }
}
