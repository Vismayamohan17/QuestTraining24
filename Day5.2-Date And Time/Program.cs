
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5._2_Date_And_Time
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Local date and time
            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);

            //UTC Time
            DateTime dtu = DateTime.UtcNow;
            Console.WriteLine(dtu);

            Console.WriteLine($"Day: {dt.Day}");
            Console.WriteLine($"Month: {dt.Month}");
            Console.WriteLine($"Year: {dt.Year}");

            Console.WriteLine($"Hour: {dt.Hour}");
            Console.WriteLine($"Minute: {dt.Minute}");
            Console.WriteLine($"Second: {dt.Second}");
            Console.WriteLine($"Millisecond: {dt.Millisecond}");



            Console.WriteLine($"Day: {dtu.Day}");
            Console.WriteLine($"Month: {dtu.Month}");
            Console.WriteLine($"Year: {dtu.Year}");

            Console.WriteLine($"Hour: {dtu.Hour}");
            Console.WriteLine($"Minute: {dtu.Minute}");
            Console.WriteLine($"Second: {dtu.Second}");
            Console.WriteLine($"Millisecond: {dtu.Millisecond}");

            //Date Time Operations
            var tenDaysFromNow = dt.AddDays(10);
            Console.WriteLine(tenDaysFromNow);

            var tenDaysAndTwentyHoursFromNow = dt.AddDays(10).AddHours(20);
            Console.WriteLine( tenDaysAndTwentyHoursFromNow);


            //Formatting the output
            Console.WriteLine("---------------");
            Console.WriteLine($"Standard Output: {dt}");
            Console.WriteLine(dt.ToString("dd-MM-yyyy hh:mm:ss"));
            Console.WriteLine(dt.ToString("MM-dd-yyyy"));
            Console.WriteLine(dt.ToString("hh:mm:ss"));

            //Constructing Date Time
            var myDt = new DateTime(year:2024, month:10, day:7, hour:12, minute:50, second:59);
            Console.WriteLine($"My Date And Time : {myDt}");
        }
    }
}
