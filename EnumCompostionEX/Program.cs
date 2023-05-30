using EnumCompostionEX.Entities;
using EnumCompostionEX.Entities.Enums;

Console.Write("Enter department's name: ");
string departmentsName = Console.ReadLine();
Console.WriteLine("Enter worker data: ");
Console.Write("Name: ");
string name = Console.ReadLine();
Console.Write("Level (Junior/MidLevel/Senior): ");
WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());

Console.Write("Base salary: ");
double baseSalary = double.Parse(Console.ReadLine());

Department dept = new Department(departmentsName);
Worker worker = new Worker(name, level, baseSalary, dept);

Console.Write("How many contracts to this worker? ");
int numberOfContracts = int.Parse(Console.ReadLine());

for (int i = 1; i <= numberOfContracts; i++)
{
    Console.WriteLine($"Enter #{i} contract data:");
    Console.Write("Date (MM/DD/YYYY): ");
    DateTime date = DateTime.Parse(Console.ReadLine());
    Console.Write("Value per hour: ");
    double valuePerHour = double.Parse(Console.ReadLine());
    Console.Write("Duration (hours): ");
    int hours = int.Parse(Console.ReadLine());
    HourContract contract = new HourContract(date, valuePerHour, hours);
    worker.AddContract(contract);
}

Console.Write("\nEnter month and year to calculate income (MM/YYYY): ");
string[] monthAndYear = Console.ReadLine().Split('/');
int month = int.Parse(monthAndYear[0]);
int year = int.Parse(monthAndYear[1]);
Console.WriteLine($"Name: {worker.Name}");
Console.WriteLine($"Department: {worker.Department.Name}");
Console.WriteLine($"Income for {month:00}/{year}: {worker.Income(year, month):F2}");