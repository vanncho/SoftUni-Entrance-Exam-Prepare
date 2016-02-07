using System;
class WorkHours
{
    static void Main()
    {
        double h = int.Parse(Console.ReadLine());
        double d = int.Parse(Console.ReadLine());
        double p = int.Parse(Console.ReadLine());

        double productivityDays = d * 0.9;
        double efficientWorkHours = productivityDays * 12 * (p / 100);

        if ((int)efficientWorkHours >= h)
        {
            Console.WriteLine("Yes");
            Console.WriteLine((int)efficientWorkHours - h);
        }
        else
        {
            Console.WriteLine("No");
            Console.WriteLine((int)efficientWorkHours - h);
        }
    }
}
