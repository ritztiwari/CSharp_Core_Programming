using System;

namespace Core_Programming.Programming_Elements.Level_02
{
    internal class DistanceTravelled
    {
        public void Travel()
        {
            string name = Console.ReadLine();
            string fromCity = Console.ReadLine();
            string viaCity = Console.ReadLine();
            string toCity = Console.ReadLine();

            double fromToVia = Convert.ToDouble(Console.ReadLine());
            double viaToFinalCity = Convert.ToDouble(Console.ReadLine());
            double timeTaken = Convert.ToDouble(Console.ReadLine());

            double totalDistance = fromToVia + viaToFinalCity;
            double averageSpeed = totalDistance / timeTaken;
            double weightedResult = fromToVia + viaToFinalCity * timeTaken;

            Console.WriteLine(
                $"The results of the trip are: {totalDistance}, {averageSpeed}, and {weightedResult}"
            );
        }
    }
}
