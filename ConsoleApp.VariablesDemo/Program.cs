// See https://aka.ms/new-console-template for more information
//Different data types
/* 
    text - string
    integer - int
    decimal - decimal,float,double
    logical - bool
 */

string name = "Test";

Console.WriteLine(name);
Console.WriteLine("String concatenation" + name);
Console.WriteLine($"String interpolation {name}");
Console.WriteLine("Formatted string {0}", name);

int age = 54;
int retirementYearsLeft = 11;
int retirementAge = age + retirementYearsLeft;

Console.WriteLine("My age is " + age);
Console.WriteLine("My retirement age is " + retirementAge);

bool isRetired = false;
Console.WriteLine("Am i retirement " + isRetired);
