namespace ChallengeApp;
public class Employee
{
    private List<float> grades = new List<float>();
    public Employee(string name, string lastname)
    {
        this.Name = name;
        this.Lastname = lastname;
    }
    public string Name { get; private set; }
    public string Lastname { get; private set; }

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
    public Statistics GetStatistics()
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

        statistics.Average /= this.grades.Count;
        return statistics;
    }
}