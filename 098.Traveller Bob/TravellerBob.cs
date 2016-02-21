using System;

class TravellerBob
{
    static void Main()
    {
        string year = Console.ReadLine();
        int contractMonths = int.Parse(Console.ReadLine());
        int familyMonths = int.Parse(Console.ReadLine());

        int travelsInContractMonths = 4 * 3 * (contractMonths);
        int travelsInFamilyMonths = 2 * 2 * (familyMonths);

        int normalMonths = 12 - (contractMonths + familyMonths);
        double travelsInNoramlMonths = (12 * normalMonths) * 0.60;

        double totalTravels = travelsInContractMonths + travelsInFamilyMonths + travelsInNoramlMonths;

        if (year == "leap")
        {
            totalTravels += totalTravels * 0.05;
            Console.WriteLine((int)totalTravels);
        }
        else
        {
            Console.WriteLine((int)totalTravels);
        }
    }
}
