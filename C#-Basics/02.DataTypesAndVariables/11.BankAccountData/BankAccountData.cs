using System;

class BankAccountData
{
    static void Main()
    {
        Console.WriteLine("Enter your first name: ");
        string firstName = Console.ReadLine();

        Console.WriteLine("Enter your middle name: ");
        string middleName = Console.ReadLine();

        Console.WriteLine("Enter your last name: ");
        string lastName = Console.ReadLine();

        Console.WriteLine("Enter your available amount of money (balance): ");
        decimal balance = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Enter bank name: ");
        string bankName = Console.ReadLine();

        Console.WriteLine("Enter IBAN: ");
        string iban = Console.ReadLine();

        Console.WriteLine("Enter first credit card number (12 numbers): ");
        long cardNumber1 = long.Parse(Console.ReadLine());

        if (cardNumber1 < 0 || cardNumber1 > 999999999999)
        {
            Console.WriteLine("Card number must be 12 numbers");
            cardNumber1 = long.Parse(Console.ReadLine());
        }

        Console.WriteLine("Enter second credit card number (12 numbers): ");
        long cardNumber2 = long.Parse(Console.ReadLine());

        if (cardNumber2 < 0 || cardNumber2 > 999999999999)
        {
            Console.WriteLine("Card number must be 12 numbers");
            cardNumber2 = long.Parse(Console.ReadLine());
        }

        Console.WriteLine("Enter third credit card number (12 numbers): ");
        long cardNumber3 = long.Parse(Console.ReadLine());

        if (cardNumber3 < 0 || cardNumber3 > 999999999999)
        {
            Console.WriteLine("Card number must be 12 numbers");
            cardNumber3 = long.Parse(Console.ReadLine());
        }

        Console.WriteLine(new string('-', 20));
        Console.WriteLine("Bank Account Data is:");
        Console.WriteLine();
        Console.WriteLine("First name: " + firstName);
        Console.WriteLine("Middle name: " + middleName);
        Console.WriteLine("Last name: " + lastName);
        Console.WriteLine("Balance: " + balance);
        Console.WriteLine("Bank Name: " + bankName.ToUpper());
        Console.WriteLine("IBAN: " + iban.ToUpper());
        Console.WriteLine("First credit card number: " + cardNumber1);
        Console.WriteLine("Second credit card number: " + cardNumber2);
        Console.WriteLine("Third credit card number: " + cardNumber3);
    }
}
