using System;

class Money
{
    static void Main()
    {
        int students = int.Parse(Console.ReadLine());
        int paperSheetsForEveryStudent = int.Parse(Console.ReadLine());
        double price = double.Parse(Console.ReadLine());

        int sheetsOfPaperInOneRealm = 400;
        int totalSheetsOfPaper = students*paperSheetsForEveryStudent;
        double totalRealms = (double)totalSheetsOfPaper/sheetsOfPaperInOneRealm;

        double moneyForAllRealms = totalRealms*price;
        Console.WriteLine(moneyForAllRealms.ToString("0.000"));
    }
}
