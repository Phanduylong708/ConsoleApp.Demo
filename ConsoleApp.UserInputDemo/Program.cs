//Declare variables
string? firstName = String.Empty;
string lastName = String.Empty;
int age = 0;
int retirementAge = 65;
decimal salary = 0;
char gender = char.MinValue;
bool isWorking = false;

//Prompt the user for input
Console.Write("Please enter your first name: ");
firstName = Console.ReadLine();

Console.Write("Please enter your last name: ");
lastName = Console.ReadLine();

Console.Write("Please enter your age: ");
age = Convert.ToInt32(Console.ReadLine());

Console.Write("Please enter your salary: ");
salary = Convert.ToDecimal(Console.ReadLine());

Console.Write("Please enter your gender (M or F): ");
gender = Convert.ToChar(Console.ReadLine());

Console.Write("Are you working (true or false): ");
isWorking = Convert.ToBoolean(Console.ReadLine());

//Process the data
int workingYearsRemain = retirementAge - age;

//Output the result to users
Console.WriteLine($"Full name: {firstName} {lastName}");
Console.WriteLine($"Age: {age}");
Console.WriteLine($"Salary: {salary}");
Console.WriteLine($"Gender: {gender}");
Console.WriteLine($"Working: {isWorking}");
Console.WriteLine($"Working years remaining: {workingYearsRemain}");

