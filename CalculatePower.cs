using System;
using System.Collections.Generic;
using System.Text;

namespace Day2_HW
{
    class CalculatePower
    {
        static int CalculatePositivePower(int Number, int Power)
        {
            if (Power == 1)
            {
                return Number;
            }
            else
            {
                return Number * CalculatePositivePower(Number, --Power);
            }
        }

        static int CalculateNegativePower(int Number, int Power)
        {
            if (Power == -1)
            {
                return Number;
            }
            else
            {
                return Number * CalculateNegativePower(Number, ++Power);
            }
        }

        public static void Calculate(int Number, int Power)
        {
            if (Number == 0)
            {
                Console.WriteLine("End! Result = 0");
            }
            else
            {
                if (Power == 0)
                {
                    Console.WriteLine("Result = 1");
                }
                else if (Power > 0)
                {
                    Console.WriteLine(CalculatePositivePower(Number, Power));
                }
                else if (Power < 0)
                {
                    Console.WriteLine("1/" + CalculateNegativePower(Number, Power));
                }
            }
        }
    }
}
