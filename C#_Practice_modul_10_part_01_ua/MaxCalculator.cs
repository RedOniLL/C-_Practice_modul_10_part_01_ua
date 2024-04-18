using System;
using System.Collections.Generic;

namespace C__Practice_modul_10_part_01_ua
{
    internal class MaxCalculator<T>
    {
        public T FindMax<T>(T num1, T num2, T num3) where T : IComparable<T>
        {
            T max = num1;

            if (num2.CompareTo(max) > 0)
            {
                max = num2;
            }

            if (num3.CompareTo(max) > 0)
            {
                max = num3;
            }

            return max;
        }
    }
}
