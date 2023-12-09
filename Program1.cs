//Program 1 Create a class with a private field and a public method to set its value.

using System;

public class MyClass
{
    private int myField; // Private field

    // Public method to set the value of the private field
    public void SetValue(int value)
    {
        myField = value;
    }

    // Public method to get the value of the private field (optional)
    public int GetValue()
    {
        return myField;
    }
}

class Program
{
    static void Main()
    {
        MyClass myObject = new MyClass();

        // Set the value of the private field using the public method
        myObject.SetValue(42);

        // Get and display the value of the private field (optional)
        int value = myObject.GetValue();
        Console.WriteLine("The value of myField is: " + value);
    }
}

