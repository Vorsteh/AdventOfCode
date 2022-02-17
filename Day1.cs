using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aoc
{
    internal class Day1
    {
        public int part1(List<int> list)
        {
            int result = 0;
            for (int i = 1; i < list.Count; i++)
            {
                if (list[i] > list[i - 1]) { result++; }
            }
            return result;
        }
        public int part2(List<int> list)
        {
            int result = 0;
            int prev = 9999;
            for (int i = 2; i < list.Count; i++)
            {

                if (list[i] + list[i - 1] + list[i - 2] > prev) { result++; }
                prev = list[i] + list[i - 1] + list[i - 2];
            }
            return result;
        }
    }
}
