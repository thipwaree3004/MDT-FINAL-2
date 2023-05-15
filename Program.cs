using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.Write("Enter the tank capacity: ");
        double tankCapacity = double.Parse(Console.ReadLine());

        Console.Write("Enter the average drinking volume during breaks: ");
        double averageDrinkingVolume = double.Parse(Console.ReadLine());

        Console.Write("Enter the refill volume per refill cycle: ");
        double refillVolume = double.Parse(Console.ReadLine());

 
        Console.Write("Enter the break duration: ");
        int breakDuration = int.Parse(Console.ReadLine());

        Console.Write("Enter the refill cycle duration: ");
        int refillCycleDuration = int.Parse(Console.ReadLine());

        Console.Write("Enter the total duration of the activity in hours: ");
        int totalDuration = int.Parse(Console.ReadLine());

       
        double totalDrinkingVolume = averageDrinkingVolume * (totalDuration / (breakDuration + refillCycleDuration));
        double remainingWater = tankCapacity - totalDrinkingVolume;

        
        if (remainingWater >= 0)
        {
            Console.WriteLine("Enough Water, {0} left", remainingWater);
        }
        else
        {
            if (refillCycleDuration == breakDuration)
            {
                Console.WriteLine("Not Enough Water");
            }
            else
            {
                Console.WriteLine("Overflow Water");
            }
        }
    }
}

