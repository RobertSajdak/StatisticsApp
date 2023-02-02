namespace StatisticsApp
{
    public class Employee
    {
        private List<float> grades = new List<float>();

        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public string Name { get; private set; }

        public string Surname { get; private set; }

        public void AddGrade(float grade)
        {
            int valueInInt = (int)grade; // rzutowanie zmiennej 'float' na 'int'
                                         //float f = valueInInt; rzutowanie zmiennej 'int' na 'float' 

            if (grade >= 0 && grade <= 100)
            {
            this.grades.Add(grade);
            }
            else
            {
                Console.WriteLine("Invalid grade value!");
            }           
        }

        public void AddGrade(string grade)
        {
            if(float.TryParse(grade, out float result))
            {
                this.AddGrade(result);                
            }
            else
            {
                Console.WriteLine("String is not float.");
            }
        }

        public void AddGrade(double grade)
        {
            float gradeAsFloat = (float)grade;
            this.AddGrade(gradeAsFloat);
        }

        public void AddGrade(int grade)
        {
            float gradeAsFloat = grade;
            this.AddGrade(gradeAsFloat);
        }

        public void AddGrade(long grade)
        {
            float gradeAsFloat = (long)grade;
            this.AddGrade(gradeAsFloat);
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Min = float.MaxValue;
            statistics.Max = float.MinValue;
            statistics.Average = 0;

            foreach(var grade in this.grades)
            {
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Average += grade;
            }

            statistics.Average /= this.grades.Count;
            return statistics;
        }
    }
}
