//Program 2 design a class with a public method that accesses a private field from another class in the same assembly.

using System;
using System.Reflection;

public class ClassA
{
    private int privateField = 42;
}

public class ClassB
{
    public void AccessPrivateFieldFromClassA()
    {
        ClassA objA = new ClassA();
        Type typeA = objA.GetType();

        // Use reflection to access the private field
        FieldInfo privateFieldInfo = typeA.GetField("privateField", BindingFlags.NonPublic | BindingFlags.Instance);
        int value = (int)privateFieldInfo.GetValue(objA);

        Console.WriteLine("Accessed privateField from ClassA: " + value);
    }
}

class Program
{
    static void Main()
    {
        ClassB objB = new ClassB();
        objB.AccessPrivateFieldFromClassA();
    }
}
