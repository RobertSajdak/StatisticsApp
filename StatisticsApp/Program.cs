using StatisticsApp;

Console.WriteLine("Witaj w Programie XYZ do oceny pracowników!");
Console.WriteLine("-------------------------------------------");
Console.WriteLine();

Console.WriteLine("Instrukcja:");
Console.WriteLine("Wprowadź dane nowego pracownika wraz z ocenami w skali 0 -> 100.");
Console.WriteLine("Program zakończysz wraz z podsumowaniem wprowadzonych ocen, wciskając klawisz 'Q' na klawiaturze.");
Console.WriteLine("W podsumowaniu pracownik uzyska ocenę wg skali literowej A -> E, gdzie A to najwyższa, E najniższa ocena.");
Console.WriteLine();

Console.WriteLine("Podaj imię pracownika: ");
string inputName = Console.ReadLine();

Console.WriteLine("Podaj nazwisko pracownika: ");
string inputSurname = Console.ReadLine();

var employee = new Employee(inputName, inputSurname);

while (true)
{
    Console.WriteLine("Podaj ocenę pracownika lub zakończ program wciskając klawisz 'Q': ");
    var input = Console.ReadLine();
    if(input == "q")
    {
        break;
    }
    try
    {
        employee.AddGrade(input);
    }
    catch (Exception exception)
    {
        Console.WriteLine($"Exception catched: {exception.Message}");
    }    
}

var statistics = employee.GetStatistics();

Console.WriteLine();
Console.WriteLine("Podsumowanie: ");
Console.Write($"Imię i nazwisko pracownika: {inputName} {inputSurname}\n");


Console.WriteLine($"Ocena min.: {statistics.Min}");
Console.WriteLine($"Ocena max.: {statistics.Max}");
Console.WriteLine($"Średnia z uzyskanych ocen: {statistics.Average:N2}");
Console.WriteLine($"Ocena wg skali literowej: {statistics.AverageLetter}");
