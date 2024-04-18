using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Practice_modul_10_part_01_ua
{
    internal class Task3
    {
        public T Sum<T>(T[] mas)
        {

            dynamic sum = default(T);

            foreach (var item in mas)
            {
                sum += item;
            }

            return sum;

        }
    }
}
