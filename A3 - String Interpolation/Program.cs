using System.Collections.Concurrent;
using static System.Net.Mime.MediaTypeNames;

namespace A3___String_Interpolation
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var Date = new DateOnly(2019, 1, 22);
            var DT = new DateTime(2019, 1, 22, 23, 01, 27);
            var pi = Math.PI;

            Console.WriteLine("Part 1");
            Console.WriteLine("");
            // 1
            Console.WriteLine($"{Date,40:M}" + " ," + $"{Date:yyyy}");
            // 2
            Console.WriteLine($"{Date:yyyy}" + "." + $"{Date:MM}" + "." + $"{Date:dd}");
            // 3
            Console.WriteLine("Day " + $"{Date:dd}" + " of " + $"{Date:MMMM}" + ", " + $"{Date:yyyy}");
            // 4
            Console.WriteLine("Year: " + $"{Date:yyyy}" + ", Month: " + $"{Date:MM}" + ", Day: " + $"{Date:dd}");
            // 5
            Console.WriteLine($"{Date,17:dddd}");
            // 6
            Console.WriteLine($"{DT,10:t}" + $"{DT,10:dddd}");
            // 7
            Console.WriteLine("h:" + $"{DT:hh}" + ", m:" + $"{DT:mm}" + ", s:" + $"{DT:ss}");
            //8
            Console.WriteLine($"{DT:yyyy}" + "." + $"{DT:MM}" + "." + $"{DT:dd}" + "." + $"{DT:hh}" + "." + $"{DT:mm}" + "." + $"{DT:ss}");


            Console.WriteLine("");
            Console.WriteLine("");
            //part 2 start
            Console.WriteLine("Part 2");
            Console.WriteLine("");

            Console.WriteLine($"{pi:C2}");

            //Output as right-aligned (10 spaces), number with 3 decimal places
            //i wasnt sure about the wording "10 spaces" since number 1 used "40 character field"
            //so i used a 14 character field since there are 4 digits displayed leaving 10 blank spaces
            Console.WriteLine($"{pi,14:n3}");

        }
    }
}