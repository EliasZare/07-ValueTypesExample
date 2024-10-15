// See https://aka.ms/new-console-template for more information
using _07_ValueTypesExample;

Console.WriteLine("Hello, World!");
Struct struct1 = new Struct(1, "Elias");
Console.WriteLine(struct1.GetName());

Extension exception = new Extension();
Console.WriteLine(exception.GetHashCode());
Console.WriteLine(struct1.GetHashCode());
Console.ReadKey();


// Boxing and Unboxing 

// Boxing : ValueType to RefrenceType
int age  = 10;
object test = age;

//UnBoxing : RefrenceType to ValueType
object test1 = 10;
int age1 = (int)test;
