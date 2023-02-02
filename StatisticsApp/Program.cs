using StatisticsApp;

var employee = new Employee("Robert", "Sajdak");
employee.AddGrade("Michael");
employee.AddGrade("200");
employee.AddGrade(9L);
employee.AddGrade(8f);
employee.AddGrade(2);
employee.AddGrade(6);

var statistics = employee.GetStatistics();

Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Average: {statistics.Average:N2}");
