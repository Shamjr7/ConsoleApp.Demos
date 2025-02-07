// See https://aka.ms/new-console-template for more information

// Different datatypes
/*
    text - sring
    integers - int
    decimal - double, float, decimal
    logical - bool
 */

string name = "Sham";

Console.WriteLine("I am " + name); // String concatenation
Console.WriteLine($"They call me {name}"); // String interpolation
Console.WriteLine("I was given this name {0}", name); // Formatted String

int age = 24;
int retirementYearsleft = 36;
int retirementAge = age + retirementYearsleft;

Console.WriteLine("my age is " + age);
Console.WriteLine("my retirment age is " + retirementAge);

bool isRetired = false;
Console.WriteLine("Are you retired? " + isRetired);
