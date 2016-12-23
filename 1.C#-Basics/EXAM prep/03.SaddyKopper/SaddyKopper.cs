using System;
using System.Numerics;

class SaddyKopper
{
    static void Main()
    {
        string strNumber = Console.ReadLine();

        int transCount = 0;
        while (strNumber.Length > 1)
        {
            BigInteger product = 1;

            while (strNumber.Length > 0)
            {
                strNumber = strNumber.Substring(0, strNumber.Length - 1);
                
                long sum = 0;
                for (int i = 0; i < strNumber.Length; i += 2)
                {
                    sum += (strNumber[i] - '0');

                }
                product *= sum != 0 ? sum : 1;
                    // ako sumata e razlichna ot nula umnoji go po sumata (sum) , ako ne e go umnoji po 1  
                //ternaren operator
            }
            transCount++;
            strNumber = product.ToString();
        }
        if (transCount < 10)
        {
            Console.WriteLine(transCount);
        }

        Console.WriteLine(strNumber);
    }
}
