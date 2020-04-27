using System;

namespace PracticalAssessmentWeek3
{
    class Program
    {
        static void Main(string[] args)
        {
            const int maxHeat = 85;
            const int minCool = 60;
            int currentTemp = 70;
            while (true)
            {
                Console.Write($"Current Temp is '{currentTemp}'. What is desired new Temp? ");
                int newTemp = Convert.ToInt32(Console.ReadLine());
                string doWhat = "Heat";
                if (newTemp < currentTemp)
                {
                    doWhat = "Cool";
                }
                while (currentTemp != newTemp)
                {
                    if (currentTemp == maxHeat || currentTemp == minCool)
                    {
                        Console.WriteLine($"Current Temp of {currentTemp} max/min reached.");
                        break;
                    }
                    currentTemp = AdjustTemperature(currentTemp, doWhat);
                    Console.WriteLine($"After adjusting Temp, current Temp is: {currentTemp}");
                }
            }
        }
        static int AdjustTemperature(int currentTemp, string doWhat)
        {
            if (doWhat == "Heat")
            {
                return ++currentTemp;
            }
            else
            {
                return --currentTemp;
            }
        }
    }
}




