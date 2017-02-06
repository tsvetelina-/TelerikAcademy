using System;

class EmployeeData
{
    static void Main()
    {
        Console.WriteLine("Enter the first name of employee: ");
        string firstName = Console.ReadLine();

        Console.WriteLine("Enter the last name of employee: ");
        string lastName = Console.ReadLine();

        Console.WriteLine("Enter the age of the employee: ");
        int age = int.Parse(Console.ReadLine());

        if (age < 0 || age > 100)
        {
            Console.WriteLine("Age must be in rage [0 - 100]");
            age = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Enter gender: ");
        string gender = Console.ReadLine();

        if (gender != "m" && gender != "f")
        {
            Console.WriteLine("Enter your gender (m or f): ");
            gender = Console.ReadLine();
        }

        Console.WriteLine("Enter your personal ID Number: ");
        long personalIDNumber = long.Parse(Console.ReadLine());

        long employeeNumber = long.Parse(Console.ReadLine());
        if (employeeNumber < 27560000 || employeeNumber > 27569999)
        {
            Console.WriteLine("Your employee number must be in range [27560000 - 27569999]");
            employeeNumber = long.Parse(Console.ReadLine());
        }

        Console.WriteLine(new string('-', 20));
        Console.WriteLine("Employee Data is:");
        Console.WriteLine();
        Console.WriteLine("First name: " + firstName);
        Console.WriteLine("Last name: " + lastName);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Gender: " + gender);
        Console.WriteLine("Personal ID number: " + personalIDNumber);
        Console.WriteLine("Unique employee number: " + employeeNumber);
    }
}
