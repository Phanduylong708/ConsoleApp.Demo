//Declare variables
string name = String.Empty;
int age = 0;
int retirementAge = 65;

//Prompt the user for input
Console.WriteLine("Please enter your name: ");
name = Console.ReadLine();

Console.WriteLine("Please enter your age: ");
age = Convert.ToInt32(Console.ReadLine());

//Process the data
int workingYearsRemain = retirementAge - age;

//Output the result to users
Console.WriteLine($"Full name: {name}");
Console.WriteLine($"Age: {age}");
Console.WriteLine($"Working years remaining: {workingYearsRemain}");