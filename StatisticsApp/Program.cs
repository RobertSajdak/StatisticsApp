using StatisticsApp;

var employee = new Employee("Robert", "Sajdak");
employee.AddGrade("Michael");
employee.AddGrade("200");
employee.AddGrade(2.3);
employee.AddGrade(1);
employee.AddGrade(2);
employee.AddGrade(3);

/*var statistics = employee.GetStatistics();
Console.WriteLine($"min: {statistics.Min}");
Console.WriteLine($"max: {statistics.Max}");
Console.WriteLine($"average: {statistics.Average:N2}");
*/

Console.WriteLine();
var statistics1 = employee.GetStatisticsWithForEach();
Console.WriteLine("Wyniki dla pętli 'foreach':");
Console.WriteLine($"Min: {statistics1.Min}");
Console.WriteLine($"Max: {statistics1.Max}");
Console.WriteLine($"Average: {statistics1.Average:N2}");

Console.WriteLine();
var statistics2 = employee.GetStatisticsWithFor();
Console.WriteLine("Wyniki dla pętli 'for':");
Console.WriteLine($"Min: {statistics2.Min}");
Console.WriteLine($"Max: {statistics2.Max}");
Console.WriteLine($"Average: {statistics2.Average:N2}");

Console.WriteLine();
var statistics3 = employee.GetStatisticsWithDoWhile();
Console.WriteLine("Wyniki dla pętli 'do-while':");
Console.WriteLine($"Min: {statistics3.Min}");
Console.WriteLine($"Max: {statistics3.Max}");
Console.WriteLine($"Average: {statistics3.Average:N2}");

Console.WriteLine();
var statistics4 = employee.GetStatisticsWithWhile();
Console.WriteLine("Wyniki dla pętli 'while':");
Console.WriteLine($"Min: {statistics4.Min}");
Console.WriteLine($"Max: {statistics4.Max}");
Console.WriteLine($"Average: {statistics4.Average:N2}");
