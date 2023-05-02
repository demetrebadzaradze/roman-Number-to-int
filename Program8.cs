//roman Number to int
using System;
using System.Collections;

namespace Csharpproject
{
    class Program
    {
        public static void Main(string[] args)
        {
            string number = "";
            int num;
            
            Console.WriteLine("Enter number in roman");
            number = Console.ReadLine();

            num = RomanToInt(number);

            Console.WriteLine(num);
        }
        public static int RomanToInt(string s)
        {
            int result = 0;
             int prevValue = 0;

              for (int i = s.Length - 1; i >= 0; i--)
             {
                int curValue = SingleChar(s, i);

                if (curValue < prevValue)
               {
                    result -= curValue;
                 }
                else
             {
            result += curValue;
                }

            prevValue = curValue;
        }

    return result;
    }

public static int SingleChar(string s, int i)
{
    switch (s[i])
    {
        case 'I':
            return 1;
        case 'V':
            return 5;
        case 'X':
            return 10;
        case 'L':
            return 50;
        case 'C':
            return 100;
        case 'D':
            return 500;
        case 'M':
            return 1000;
        default:
            throw new ArgumentException("Invalid character in input string");
    }
}

    }
}