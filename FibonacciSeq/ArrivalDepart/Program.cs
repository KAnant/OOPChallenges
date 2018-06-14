using System;

namespace ArrivalDepart
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter h1");
            int arrivalHour = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter m1");
            int arrivalMin = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter h2");
            int departureHour = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter m2");
            int departureMin = Convert.ToInt32(Console.ReadLine());
            TimeSpan t1 = new TimeSpan(arrivalHour,arrivalMin,0);
            TimeSpan t2 = new TimeSpan(departureHour,departureMin,0);
            TimeSpan totaltime = t1+t2;
            Console.WriteLine(totaltime);
            Console.ReadLine();


        }
    }
}
