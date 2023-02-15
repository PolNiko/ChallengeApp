using ChallengeApp;
using System;
{
    Console.WriteLine("Employees Grades System 0-100");
}
var employee = new Employee("Niko", " Post", " 30yo", "Programmer");
employee.AddGrade("Adam");
employee.AddGrade("4000");
employee.AddGrade(2);
employee.AddGrade(6);
employee.AddGrade(7.26);
employee.AddGrade(98.99);

var statistics = employee.GetStatisticsWhithForeach();
Console.WriteLine("ForeachLoop: ");
Console.WriteLine($"{employee.Name} {employee.Lastname} {employee.Age} {employee.Profession}");
Console.WriteLine($"Average: {statistics.Average}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");

statistics = employee.GetStatisticsWhithFor();
Console.WriteLine("ForLoop: ");
Console.WriteLine($"Average: {statistics.Average}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");

statistics = employee.GetStatisticsWhithDoWhile();
Console.WriteLine("Do-WhileLoop: ");
Console.WriteLine($"Average: {statistics.Average}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");

statistics = employee.GetStatisticsWhithWhile();
Console.WriteLine("WhileLoop: ");
Console.WriteLine($"Average: {statistics.Average}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
