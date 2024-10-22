//Declare variables
string firstName = String.Empty;
string lastName = String.Empty;
int age = 0;
int retirementAge = 65;

//Prompt the user for input
Console.WriteLine("Please enter your first name: ");
firstName = Console.ReadLine();

Console.WriteLine("Please enter your last name: ");
lastName = Console.ReadLine();

Console.WriteLine("Please enter your ageaa: ");
age = Convert.ToInt32(Console.ReadLine());

//Process the data
int workingYearsRemain = retirementAge - age;

//Output the result to users
Console.WriteLine($"Full name: {firstName} {lastName}");
Console.WriteLine($"Age: {age}");
Console.WriteLine($"Working years remaining: {workingYearsRemain}");