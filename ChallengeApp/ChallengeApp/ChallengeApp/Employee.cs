using System;
using System.Reflection;

namespace ChallengeApp;
public class Employee
{
    private List<float> grades = new List<float>();
    public Employee(string name, string lastname, string age, string profession)
    {
        this.Name = name;
        this.Lastname = lastname;
        this.Age = age;
        this.Profession = profession;
    }
    public string Name { get; private set; }
    public string Lastname { get; private set; }
    public string Age { get; private set; }
    public string Profession { get; private set; }


    public void AddGrade(float grade)
    {
        if (grade >= 0 && grade <= 100)
        {
            this.grades.Add(grade);
        }
        else
        {
            Console.WriteLine("Invalid grade value");
        }
    }
    public void AddGrade(string grade)
    {
        if (float.TryParse(grade, out float result))
        {
            this.AddGrade(result);
        }
        else
        {
            Console.WriteLine("String is not float");
        }
    }
    public void AddGrade(double grade)
    {
        float result = (float)grade;
        this.AddGrade(result);
    }
    public void AddGrade(decimal grade)
    {
        float result = (float)grade;
        this.AddGrade(result);
    }
    public void AddGrade(int grade)
    {
        float result = (float)grade;
        int valueInInt = (int)grade;
    }
    public Statistics GetStatisticsWhithForeach()
    {
        var statistics = new Statistics();
        statistics.Average = 0;
        statistics.Max = float.MinValue;
        statistics.Min = float.MaxValue;

        foreach (var grade in this.grades)
        {
            statistics.Max = Math.Max(statistics.Max, grade);
            statistics.Min = Math.Min(statistics.Min, grade);
            statistics.Average += grade;
        }
        if (statistics.Average < 50)
        {
            Console.WriteLine("Good");
        }
        else
        {
            Console.WriteLine("Bad");
        }
        statistics.Average /= this.grades.Count;
        return statistics;
    }
    public Statistics GetStatisticsWhithFor()
    {
        var statistics = new Statistics();
        statistics.Average = 0;
        statistics.Max = float.MinValue;
        statistics.Min = float.MaxValue;

        for (int i = 0; i < this.grades.Count; i++)
        {
            statistics.Max = Math.Max(statistics.Max, this.grades[i]);
            statistics.Min = Math.Min(statistics.Min, this.grades[i]);
            statistics.Average += this.grades[i];
        }
        statistics.Average /= this.grades.Count;
        return statistics;
    }
    public Statistics GetStatisticsWhithDoWhile()
    {
        var statistics = new Statistics();
        statistics.Average = 0;
        statistics.Max = float.MinValue;
        statistics.Min = float.MaxValue;
        var index = 0;

        do
        {
            statistics.Max = Math.Max(statistics.Max, this.grades[index]);
            statistics.Min = Math.Min(statistics.Min, this.grades[index]);
            statistics.Average += this.grades[index];
            index++;
        }
        while (index < this.grades.Count);
        statistics.Average /= this.grades.Count;
        return statistics;
    }
    public Statistics GetStatisticsWhithWhile()
    {
        var statistics = new Statistics();
        statistics.Average = 0;
        statistics.Max = float.MinValue;
        statistics.Min = float.MaxValue;
        var index = 0;

        while (index < this.grades.Count)
        {
            statistics.Max = Math.Max(statistics.Max, this.grades[index]);
            statistics.Min = Math.Min(statistics.Min, this.grades[index]);
            statistics.Average += this.grades[index];
            index++;
        }
        statistics.Average /= this.grades.Count;
        return statistics;
    }

}