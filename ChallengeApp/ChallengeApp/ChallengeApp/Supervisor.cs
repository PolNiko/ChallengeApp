using System.Diagnostics;

namespace ChallengeApp
{
    public class Supervisor : IEmployee
    {
        private List<float> grades = new List<float>();
        public Supervisor(string name, string lastname, string age, string profession)
        {
            this.Name = name;
            this.Lastname = lastname;
            this.Age = age;
            this.Profession = profession;
            Profession = profession;
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
            float valueInFloat = (float)grade;
            this.AddGrade(valueInFloat);
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
            var gradeInput = grade switch
            {
                "6" => 100,
                "-6" or "6-" => 95,
                "+5" or "5+" => 85,
                "5" => 80,
                "-5" or "5-" => 75,
                "+4" or "4+" => 65,
                "4" => 60,
                "-4" or "4-" => 55,
                "+3" or "3+" => 45,
                "3" => 40,
                "-3" or "3-" => 35,
                "+2" or "2+" => 25,
                "2" => 20,
                "-2" or "2-" => 15,
                "+1" or "1+" => 10,
                "1" => 0,
                _ => throw new Exception("Wrong Valuation!"),
            };
            {
                this.AddGrade(gradeInput);
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
}
