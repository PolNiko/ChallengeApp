using System.Diagnostics;

namespace ChallengeApp.Tests;

public class EmployeeTests
{
    [Test]
    public void WhenOnlyLettersAddingShowTheAverage()
    {
        // arrange
        var employee = new Employee();
        employee.AddGrade('a');
        employee.AddGrade('B');
        employee.AddGrade('c');
        employee.AddGrade('D');

        // act
        var statistics = employee.GetStatistics();

        //assert
        Assert.AreEqual(statistics.Average, 72,5);
    }
    [Test]
    public void WhenCalculationsWithCharsAndNumbersIsCorrectShowAverages()
    {
        // arrange
        var employee = new Employee();
        employee.AddGrade('A');
        employee.AddGrade(45);
        employee.AddGrade(99);
        employee.AddGrade('c');
        employee.AddGrade(91);

        // act
        var statistics = employee.GetStatistics();

        //assert
        Assert.AreNotEqual(statistics.AverageLetter, 'C');
        Assert.AreEqual(statistics.Average, 79);
    }
    [Test]
    public void WhenCalculationWithCharsAndNumbersIsCorrectShowEquals()
    {
        // arrange
        var employee = new Employee();
        employee.AddGrade('A');
        employee.AddGrade(45);
        employee.AddGrade(99);
        employee.AddGrade('c');
        employee.AddGrade(91);

        // act
        var statistics = employee.GetStatistics();

        //assert
        Assert.AreEqual(statistics.AverageLetter, 'B');
        Assert.AreEqual(79, statistics.Average);
        Assert.AreEqual(100,statistics.Max);
        Assert.AreEqual(45, statistics.Min);
    }
}