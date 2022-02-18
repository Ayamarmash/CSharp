using System;
namespace App
{
    class Program
    {
        static void Main()
        {
            int choice = 0;
            Console.WriteLine("1: Find Largest Number Among given numbers");
            Console.WriteLine("2: reverse a given number");
            Console.WriteLine("3: find the largest digit of a number");

            switch (choice)
            {
                case 1:
                    int[] Numbers = new int[] { 0 };
                    int i = 0;
                    char Stop = 'z';
                    while (Stop == 'y')
                    {
                        Numbers[i] = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Press y if you want to add another number.");
                        Stop = Convert.ToChar(Console.ReadLine());
                    }
                    LargestNumber x = new LargestNumber ();
                    x.FindLargestNumber(Numbers);
                    break;

                    case 2:
                    int num = 0;
                    num = Convert.ToInt32(Console.ReadLine());
                    ReversedNumber y = new ReversedNumber();
                    y.Reverse(num);
                    break;

                    case 3:
                    int n = 0;
                    n = Convert.ToInt32(Console.ReadLine());
                    FindLargestDigit z = new FindLargestDigit();
                    z.LargestDigit(n);
                    break;

            }
        }
    }
    class LargestNumber
    {
        public int FindLargestNumber(int[] Arr)
        {
            int Max = Arr[0];
            for (int i = 0; i < Arr.Length; i++) 
            {
                if (Arr[i] > Max)
                {
                    Max = Arr[i];
                }
            }
            return Max;
        }
    }
    class ReversedNumber
    {
        public int Reverse(int x)
        {
            int NewX = 0;
            while (x != 0)
            {
                NewX = (NewX * 10) + (x % 10);
                x = x % 10;
            }
            return NewX;
        }
    }
    class FindLargestDigit
    {
        public int LargestDigit(int x)
        {
            int Max = x%10;
            x = x / 10;
            int Temp = x%10;
            while (x != 0)
            {
                if (Temp > Max) Max = Temp;
                x = x / 10;
                Temp = x%10;
            }
            return Max;
        }
    }



}