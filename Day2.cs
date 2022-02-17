using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aoc
{
    internal class Day2
    {
        public int part1(List<string> list)
        {
            int x = 0, y = 0;
            foreach(string s in list)
            {
                string[] commands = s.Split(' ');
                switch (commands[0])
                {
                    case "forward":
                        x += int.Parse(commands[1]);
                        break;
                    case "down":
                        y += int.Parse(commands[1]);
                        break;
                    case "up":
                        y -= int.Parse(commands[1]);
                        break;
                    default:
                        Console.WriteLine("None");
                        break;
                }
            }
            return x * y;
        }

        public int part2(List<String> list)
        {
            int x = 0, y = 0, aim = 0;
            foreach (string s in list)
            {
                string[] commands = s.Split(' ');
                switch (commands[0])
                {
                    case "forward":
                        x += int.Parse(commands[1]);
                        y += int.Parse(commands[1]) * aim;
                        break;
                    case "down":
                        aim += int.Parse(commands[1]);
                        break;
                    case "up":
                        aim -= int.Parse(commands[1]);
                        break;
                    default:
                        Console.WriteLine("None");
                        break;
                }
            }
            return x * y;
        }

    }
}
