namespace ChallengeApp
{
    public class EmployeeInMemory : EmployeeBase // : IEmployee
    {
        public override event GradeAddedDelegate GradeAdded;
        private List<float> grades = new List<float>();
        public EmployeeInMemory(string name, string lastname, string age, string profession)
            : base(name, lastname, age, profession)
        {
        }
        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);

                if (GradeAdded != null)
                {
                    GradeAdded(this,new EventArgs());
                }
            }
            else
            {
                throw new Exception("Invalid grade value");
            }
        }
        public override void AddGrade(double grade)
        {
            float gradesAsFloat = (float)grade;
            this.AddGrade(gradesAsFloat);
        }
        public override void AddGrade(int grade)
        {
            float gradesAsFloat = (float)grade;
            this.AddGrade(gradesAsFloat);
        }
        public override void AddGrade(char grade)
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
         public override void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float stringInFloat))
            {
                this.AddGrade(stringInFloat);
            }
            else if (!float.TryParse(grade, out float result))
            {
                switch (grade)
                {
                    case "A":
                    case "a":
                        this.AddGrade(100);
                        break;
                    case "B":
                    case "b":
                        this.AddGrade(80);
                        break;
                    case "C":
                    case "c":
                        this.AddGrade(60);
                        break;
                    case "D":
                    case "d":
                        this.AddGrade(40);
                        break;
                    case "E":
                    case "e":
                        this.AddGrade(20);
                        break;
                    default:
                        throw new Exception("Invalid Grade Value");
                }
            }
        }
        public override Statistics GetStatistics()
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
