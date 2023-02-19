namespace ChallengeApp;
public class Employee
{
    private readonly char sex = 'M';

    private List<float> grades = new List<float>();
    public Employee(string name, string lastname, string age, string profession)
    {
        this.Name = name;
        this.Lastname = lastname;
        this.Age = age;
        this.Profession = profession;
        this.sex = 'K';
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
            throw new Exception("Invalid grade value");
        }
    }
    public void AddGrade(double grade)
    {
        float gradesAsFloat = (float)grade;
        this.AddGrade(gradesAsFloat);
    }
    public void AddGrade(int grade)
    {
        float gradesAsFloat = (float)grade;
        this.AddGrade(gradesAsFloat);
    }
    public void AddGrade(char grade)
    {
        switch (grade)
        {
            case 'A':
            case 'a':
                this.grades.Add(100);
                break;
            case 'B':
            case 'b':
                this.grades.Add(80);
                break;
            case 'C':
            case 'c':
                this.grades.Add(60);
                break;
            case 'D':
            case 'd':
                this.grades.Add(50);
                break;
            case 'E':
            case 'e':
                this.grades.Add(40);
                break;
            case 'F':
            case 'f':
                this.grades.Add(20);
                break;
            default:
                throw new Exception("Wrong Letter");
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
            throw new Exception("String is not float");
        }
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
        switch (statistics.Average)
        {
            case var average when average >= 80:
                statistics.AverageLetter = 'A';
                break;
            case var average when average >= 60:
                statistics.AverageLetter = 'B';
                break;
            case var average when average >= 65:
                statistics.AverageLetter = 'C';
                break;
            case var average when average >= 50:
                statistics.AverageLetter = 'D';
                break;
            case var average when average >= 40:
                statistics.AverageLetter = 'E';
                break;
            case var average when average >= 30:
                statistics.AverageLetter = 'F';
                break;
            default:
                statistics.AverageLetter = 'J';
                break;
        }
        return statistics;
    }
}