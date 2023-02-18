using ChallengeApp;
using System;
Console.WriteLine("Welcome To Employees Grades System App");
Console.WriteLine("======================================");
Console.WriteLine();
Console.WriteLine("Score a Employee");

var employee = new Employee();
while (true)
{
    Console.WriteLine("Add next Score for your Employee: ");
    var input = Console.ReadLine();
    if(input == "q")
    {
        break;
    }
    employee.AddGrade(input);
}

var statistics = employee.GetStatistics();
Console.WriteLine($"AvgLetter: {statistics.AverageLetter}");
Console.WriteLine($"Average: {statistics.Average}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
