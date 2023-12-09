//Program 7.	Build a class with a private property and provide a public method to modify its value. Test the functionality.

using System;

public class MyClass
{
    // Private property
    private string privateProperty;

    // Constructor to initialize the private property
    public MyClass(string initialValue)
    {
        privateProperty = initialValue;
    }

    // Public method to modify the private property
    public void ModifyProperty(string newValue)
    {
        privateProperty = newValue;
    }

    // Public method to retrieve the value of the private property
    public string GetPropertyValue()
    {
        return privateProperty;
    }
}

class Program
{
    static void Main()
    {
        // Create an instance of MyClass
        MyClass myObject = new MyClass("Initial Value");

        // Display the initial value of the private property
        Console.WriteLine("Initial Value: " + myObject.GetPropertyValue());

        // Modify the private property using the public method
        myObject.ModifyProperty("New Value");

        // Display the modified value of the private property
        Console.WriteLine("Modified Value: " + myObject.GetPropertyValue());
    }
}
