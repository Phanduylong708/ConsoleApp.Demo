Console.WriteLine("Please enter the first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please enter the second number:");
int num2 = 0;
string numberEntered = Console.ReadLine();
num2 = Convert.ToInt32(numberEntered);

//Add number
int sum = num1 + num2;

//Multiplyy
int product = num1 * num2;

//Division
int quotient = num1 / num2;

//Subtraction
int difference = num1 - num2;

//Modulus
int mod = num1 % num2;

Console.WriteLine($"Sum: {sum}");
Console.WriteLine($"Product: {product}");
Console.WriteLine($"Quotient: {quotient}");
Console.WriteLine($"Difference: {difference}");
Console.WriteLine($"Modulus: {mod}");

/*
    Logics Operations and Operators
 */

bool isGreaterThan = num1 > num2;
bool isLessThan = num1 < num2;
bool isGreaterThanOrEqual = num1 >= num2;
bool isLessThanOrEqual = num1 <= num2;
bool isEqual = num1 == num2;
bool isNotEqual = num1 != num2;

Console.WriteLine("**** Logic Results *****");
Console.WriteLine();
Console.WriteLine($"Is greater than : {isGreaterThan}");
Console.WriteLine($"Is less than : {isLessThan}");
Console.WriteLine($"Is greater than or equal : {isGreaterThanOrEqual}");
Console.WriteLine($"Is less than or equal : {isLessThanOrEqual}");
Console.WriteLine($"Is equal: {isEqual}");
Console.WriteLine($"Is not equal : {isNotEqual}");