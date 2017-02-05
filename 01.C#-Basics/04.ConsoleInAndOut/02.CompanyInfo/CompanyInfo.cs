using System;

class CompanyInfo
{
    static void Main()
    {
        string companyName = Console.ReadLine();
        string companyAddress = Console.ReadLine();
        string phoneNumber = Console.ReadLine();
        string fax = Console.ReadLine();
        if (fax == null || fax == "")
        {
            fax = "(no fax)";
        }
        string webSite = Console.ReadLine();
        string managerFirstName = Console.ReadLine();
        string managerLastName = Console.ReadLine();
        int age = int.Parse(Console.ReadLine());
        string managerPhone = Console.ReadLine();


        Console.WriteLine(companyName);
        Console.WriteLine("Address: " + companyAddress);
        Console.WriteLine("Tel. " + phoneNumber);
        Console.WriteLine("Fax: " + fax );
        Console.WriteLine("Web site: " + webSite);
        Console.WriteLine("Manager: " + managerFirstName + " " + managerLastName + " (age: " + age + ", tel. " + managerPhone + ")");
    }
}
