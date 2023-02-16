using StatisticsApp;

Console.WriteLine("Witaj w Programie XYZ do oceny pracowników!");
Console.WriteLine("-------------------------------------------");
Console.WriteLine();

Console.WriteLine("Instrukcja:");
Console.WriteLine("Wprowadź dane kierownika lub pracownika wraz z ocenami w skali 0 -> 100.");
Console.WriteLine("Program zakończysz wraz z podsumowaniem wprowadzonych ocen, wciskając klawisz 'Q' na klawiaturze.");
Console.WriteLine("W podsumowaniu pracownik uzyska ocenę wg skali literowej A -> E, gdzie A to najwyższa, E najniższa ocena.");
Console.WriteLine();

Console.WriteLine("Podaj imię: ");
string inputName = Console.ReadLine();

Console.WriteLine("Podaj nazwisko: ");
string inputSurname = Console.ReadLine();

Console.WriteLine("Podaj wiek: ");
int inputAge = Convert.ToInt32(Console.ReadLine());

var employee = new Employee(inputName, inputSurname);
var supervisor = new Supervisor(inputName, inputSurname);

while (true)
{
    Console.WriteLine("Podaj ocenę pracownika lub zakończ program wciskając klawisz 'Q + Enter': ");

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

while (true)
{
    Console.WriteLine("Podaj ocenę kierownika lub zakończ program wciskając klawisz 'Q': ");

    var input = Console.ReadLine();

    if (input == "q")
    {
        break;
    }
    try
    {
        supervisor.AddGrade(input);
    }
    catch (Exception exception)
    {
        Console.WriteLine($"Exception catched: {exception.Message}");
    }
}

var statisticsEmployee = employee.GetStatistics();

Console.WriteLine();
Console.WriteLine("Podsumowanie: ");
Console.Write($"Imię i nazwisko pracownika: {inputName} {inputSurname}\n");

Console.WriteLine($"Ocena min.: {statisticsEmployee.Min}");
Console.WriteLine($"Ocena max.: {statisticsEmployee.Max}");
Console.WriteLine($"Średnia z uzyskanych ocen: {statisticsEmployee.Average:N2}");
Console.WriteLine($"Ocena wg skali literowej: {statisticsEmployee.AverageLetter}");

var statisticsSupervisor = supervisor.GetStatistics();

Console.WriteLine();
Console.WriteLine("Podsumowanie: ");
Console.Write($"Imię i nazwisko kierownika: {inputName} {inputSurname}\n");

Console.WriteLine($"Ocena min.: {statisticsSupervisor.Min}");
Console.WriteLine($"Ocena max.: {statisticsSupervisor.Max}");
Console.WriteLine($"Średnia z uzyskanych ocen: {statisticsSupervisor.Average:N2}");
Console.WriteLine($"Ocena wg skali literowej: {statisticsSupervisor.AverageLetter}");
