using ChallengeApp;
using System;

Console.WriteLine("Welcome To Employees Grades System App");
Console.WriteLine("======================================");
Console.WriteLine();
Console.WriteLine("And now add Score for your Employee: ");
var employee = new EmployeeInMemory("Niko", " Post", "30yo", "Programmer");
employee.GradeAdded += EmployeeGradeAdded;
void EmployeeGradeAdded(object sender, EventArgs args)
{
    Console.WriteLine("A New Grade Added");
}

while (true)
{
    Console.WriteLine("Add Score for your Employee: ");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }
    try
    {
        employee.AddGrade(input);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Exception catched: {ex.Message}");
    }
}
var statistics = employee.GetStatistics();
Console.WriteLine();
Console.WriteLine($"{employee.Name} {employee.Lastname} {employee.Age} {employee.Profession}");
Console.WriteLine($"AvgLetter: {statistics.AverageLetter}");
Console.WriteLine($"Average: {statistics.Average}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");