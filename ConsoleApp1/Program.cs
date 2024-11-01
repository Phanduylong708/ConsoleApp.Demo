Console.Write("Please enter student's grade: ");
int grade = Convert.ToInt32(Console.ReadLine());

if(grade >50)
{
    Console.WriteLine("Students have passed");
}

else
{
    Console.WriteLine("Student has failed");
    Console.WriteLine("Please recommend student to student affair's office");
}

Console.WriteLine("Thank you");

Console.WriteLine("*********** Complex IF..ELSE IF Results *********");

Console.WriteLine("*********** Ternary Operator Results *********");

string passStatus = grade < 50 ? "Failed" : "Passed";
Console.WriteLine($"Student status: {passStatus}");
Console.WriteLine("*********** Ternary Operator Results End *********");

//The rest of the application
Console.WriteLine("Thank you for using this program");

