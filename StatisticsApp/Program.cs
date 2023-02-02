using StatisticsApp;

var employee = new Employee("Robert", "Sajdak");
employee.AddGrade(8);
employee.AddGrade(3);
employee.AddGrade(6);

var statistics = employee.GetStatistics();

Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Average: {statistics.Average:N2}");
