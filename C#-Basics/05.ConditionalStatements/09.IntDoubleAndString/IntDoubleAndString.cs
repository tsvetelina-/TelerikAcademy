using System;

class IntDoubleAndString
{
    static void Main()
    {
        string intStringOrDouble = Console.ReadLine();
        string value = Console.ReadLine();

        switch (intStringOrDouble)
        {
            case "integer":
                Console.WriteLine((int.Parse(value) + 1)); break;

            case "real":
                Console.WriteLine((double.Parse(value) + 1).ToString("0.00")); break;
            case "text":
                Console.WriteLine("{0}*", value); break;
        }

        //if (intStringOrDouble == "integer")
        //{
        //    int intNum = int.Parse(value) + 1;
        //    Console.WriteLine(intNum);
        //}
        //else if (intStringOrDouble == "real")
        //{
        //    double doubleNum = double.Parse(value) + 1;
        //    Console.WriteLine(doubleNum.ToString("0.00"));
        //}
        //else if (intStringOrDouble == "text")
        //{
        //    Console.WriteLine("{0}*", value);
        //}

    }
}
