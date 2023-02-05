using StatisticsApp;

var employee = new Employee("Robert", "Sajdak");
employee.AddGrade("Michael");
employee.AddGrade("200");
employee.AddGrade(2.3);
employee.AddGrade(1);
employee.AddGrade(2);
employee.AddGrade(3);

var statistics = employee.GetStatistics();
Console.WriteLine($"min: {statistics.Min}");
Console.WriteLine($"max: {statistics.Max}");
Console.WriteLine($"average: {statistics.Average:N2}");
