using System;

public class Employee
{
    public string Department { get; set; }
    public string Name { get; set; }
    public string Location { get; set; }
    public bool IsOnVacation { get; set; }

    public Employee(string department, string name, string location)
    {
        Department = department;
        Name = name;
        Location = location;
        IsOnVacation = false;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Employee financeEmployee = new Employee("Finance", "Sam", "Seattle");
        Employee marketingEmployee = new Employee("Marketing", "Jane", "Miami");

        DisplayEmployeeInfo(financeEmployee);
        DisplayVacationStatus(financeEmployee, false);
        DisplayVacationStatus(financeEmployee, true);
        DisplayVacationStatus(financeEmployee, false);

        DisplayEmployeeInfo(marketingEmployee);
        DisplayVacationStatus(marketingEmployee, false);
        DisplayVacationStatus(marketingEmployee, true);
        DisplayVacationStatus(marketingEmployee, false);
    }

    public static void DisplayEmployeeInfo(Employee employee)
    {
        Console.WriteLine($"{employee.Department}Employee info: Department - {employee.Department}, Name - {employee.Name}, Location - {employee.Location}");
    }

    public static void DisplayVacationStatus(Employee employee, bool isOnVacation)
    {
        if (isOnVacation)
        {
            Console.WriteLine($"{employee.Name} is on vacation");
        }
        else
        {
            Console.WriteLine($"{employee.Name} is not on vacation");
        }

        Console.WriteLine("Switching");
    }
}
