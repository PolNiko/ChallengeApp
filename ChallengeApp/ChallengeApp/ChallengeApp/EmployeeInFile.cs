namespace ChallengeApp
{
    public class EmployeeInFile : EmployeeBase
    {
        private const string fileName = "EmployeeGrades.txt";

        public override event GradeAddedDelegate GradeAdded;

        private List<float> grades = new List<float>();
        public EmployeeInFile(string name, string lastname, string age, string profession) :
            base(name, lastname, age, profession)
        {
        }
        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(grade);
                }
                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
            else
            {
                throw new Exception("Invalid grade value");
            }
        }
        public override void AddGrade(double grade)
        {
            var doubleInFloat = (float)grade;
            this.AddGrade(doubleInFloat);
        }

        public override void AddGrade(int grade)
        {
            var intInFloat = (float)grade;
            this.AddGrade(intInFloat);
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
            var gradesFromFile = this.ReadGradesFromFile();
            var statistics = this.CountStatistics(gradesFromFile);
            return statistics;
        }
        private List<float> ReadGradesFromFile()
        {
            var grades = new List<float>();
            if (File.Exists($"{fileName}"))
            {
                using (var reader = File.OpenText($"{fileName}"))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        var number = float.Parse(line);
                        grades.Add(number);
                        line = reader.ReadLine();
                    }
                }
            }
            return grades;
        }
        private Statistics CountStatistics(List<float> grades)
        {
            var statistics = new Statistics();

            EmployeeInFile employeeInFile = this;
            foreach (var grade in this.grades)
            {
                statistics.AddGrade(grade);
            }
            return statistics;
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}