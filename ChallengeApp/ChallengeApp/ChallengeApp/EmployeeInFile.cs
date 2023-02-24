namespace ChallengeApp
{
    public class EmployeeInFile : EmployeeBase
    {
        private const string fileName = "EmpGrades.txt";

        public override event GradeAddedDelegate GradeAdded;

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
            using (var writer = File.AppendText(fileName))

                switch (grade)
                {
                    case 'A':
                    case 'a':
                        writer.WriteLine(100);
                        break;
                    case 'B':
                    case 'b':
                        writer.WriteLine(80);
                        break;
                    case 'C':
                    case 'c':
                        writer.WriteLine(60);
                        break;
                    case 'D':
                    case 'd':
                        writer.WriteLine(40);
                        break;
                    case 'E':
                    case 'e':
                        writer.WriteLine(20);
                        break;
                    default:
                        throw new Exception("Wrong letter");
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
            var result = this.CountStatistics(gradesFromFile);
            return result;
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
            foreach (var grade in grades)
            {
                statistics.AddGrade(grade);
            }
            return statistics;

        }
    }
}