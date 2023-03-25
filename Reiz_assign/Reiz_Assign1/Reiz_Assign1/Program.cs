using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReizAssign1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hour, min;
            double hourAngle, minAngle, angle;

            Console.WriteLine("Enter hours from 0 to 12:"); //User enter hours 0 to 12
            hour = int.Parse(Console.ReadLine()); //Read input data and set to variable hour

            Console.WriteLine("Enter minutes from 0 to 59:"); //User enter minute 0 ot 59
            min = int.Parse(Console.ReadLine()); //Read input data and set to vairbale min

            //given circle = 360
            //360 degrees / 12 hours = 30 degrees per hour
            //360 degrees / 60 minutes = 6 degrees per minute

            hourAngle = (hour % 12 + (double)min / 60) * 30; //30 degrees per hour
            minAngle = min * 6; //6 degrees per minute

            angle = Math.Abs(hourAngle - minAngle);
            if (angle > 180) //getting the smaller angle
            {
                angle = 360 - angle;
            }

            Console.WriteLine($"\nThe angle between the hour and minute hands is {angle} degrees.");
            Console.ReadKey();
        }
    }
}
