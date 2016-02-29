using System;

class Firefighters
{
    static void Main()
    {
        int firefighters = int.Parse(Console.ReadLine());

        int savedK = 0;
        int savedA = 0;
        int savedS = 0;
        int firefightersLeft = firefighters;

        while (true)
        {
            string peoples = Console.ReadLine();

            if (peoples == "rain")
            {
                break;
            }
            else
            {
                char[] currentPeoples = peoples.ToCharArray();

                firefighters = firefightersLeft;
                int countOfPeoplesInBuilding = currentPeoples.Length;

                while (firefighters > 0)
                {
                    // K
                    int indexOfK = Array.IndexOf(currentPeoples, 'K');
                    if (indexOfK >= 0)
                    {
                        currentPeoples[indexOfK] = '\0';
                        savedK++;
                        firefighters--;
                        countOfPeoplesInBuilding--;
                        if (firefighters <= 0 || countOfPeoplesInBuilding <= 0)
                        {
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }

                    // A
                    int indexOfA = Array.IndexOf(currentPeoples, 'A');
                    if (indexOfA >= 0)
                    {
                        currentPeoples[indexOfA] = '\0';
                        savedA++;
                        firefighters--;
                        countOfPeoplesInBuilding--;
                        if (firefighters <= 0 || countOfPeoplesInBuilding <= 0)
                        {
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }

                    // S
                    int indexOfS = Array.IndexOf(currentPeoples, 'S');
                    if (indexOfS >= 0)
                    {
                        currentPeoples[indexOfS] = '\0';
                        savedS++;
                        firefighters--;
                        countOfPeoplesInBuilding--;
                        if (firefighters <= 0 || countOfPeoplesInBuilding <= 0)
                        {
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
            }
        }

        Console.WriteLine("Kids: {0}", savedK);
        Console.WriteLine("Adults: {0}", savedA);
        Console.WriteLine("Seniors: {0}", savedS);
    }
}
