using System;

class Printing
{
    static void Main()
    {
        int nStudents = int.Parse(Console.ReadLine());
        int sPaperSheets = int.Parse(Console.ReadLine());
        double pPrice = double.Parse(Console.ReadLine());

        //int sheetsOfPaperInOneRealm = 500;
        int totalSheetsOfPaper = nStudents*sPaperSheets;

        double totalRealms = totalSheetsOfPaper / (double)500;

        double result = totalRealms*pPrice;
        Console.WriteLine(result.ToString("0.00"));

    }
}