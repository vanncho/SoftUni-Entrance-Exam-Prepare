using System;
using System.Numerics;

class DailyCalorieIntake
{
    static void Main()
    {
        int weightInPounds = int.Parse(Console.ReadLine());
        int heightInInches = int.Parse(Console.ReadLine());
        int age = int.Parse(Console.ReadLine());
        char gender = char.Parse(Console.ReadLine());
        int workoutsPerWeek = int.Parse(Console.ReadLine());

        double weightInKg = weightInPounds / 2.2d;
        double heightInCm = heightInInches * 2.54d;
        double BMR = 0;
        double DCI = 0;

        if (gender == 'm')
        {
            BMR = 66.5d + (13.75d * weightInKg) + (5.003d * heightInCm) - (6.755d * age);
        }
        else
        {
            BMR = 655 + (9.563d * weightInKg) + (1.850d * heightInCm) - (4.676d * age);
        }

        if (workoutsPerWeek <= 0)
        {
            DCI = BMR * 1.2;
        }
        else if (workoutsPerWeek >= 1 && workoutsPerWeek <= 3)
        {
            DCI = BMR * 1.375;
        }
        else if (workoutsPerWeek >= 4 && workoutsPerWeek <= 6)
        {
            DCI = BMR * 1.55;
        }
        else if (workoutsPerWeek >= 7 && workoutsPerWeek <= 9)
        {
            DCI = BMR * 1.725;
        }
        else
        {
            DCI = BMR * 1.9;
        }

        Console.WriteLine(Math.Floor(DCI));
    }
}
