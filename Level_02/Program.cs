using System;
namespace Core_Programming.Methods.Level_02
{
    class Program
    {
        static void Main(string[] args)
        {
            //FindFactors obj1 =  new FindFactors();
            //int number = 12;
            //int[] factors = FindFactors.FindAllFactors(number);
            //Console.WriteLine("Factors of " + number + " are: " + string.Join(", ", factors));
            //int sum =obj1.SumOfFactors(factors);
            //Console.WriteLine("Sum of factors: " + sum);
            //int product = obj1.ProductOfFactors(factors);
            //Console.WriteLine("Product of factors: " + product);
            //double sumOfSquares = obj1.SumOfSquareOfFactors(factors);
            //Console.WriteLine("Sum of squares of factors: " + sumOfSquares);

            //FindSumNatural obj2 = new FindSumNatural();
            //int n = Convert.ToInt32(Console.ReadLine());
            //obj2.CompareResults(n);

            //CheckLeapYear obj3 = new CheckLeapYear();
            //int year = Convert.ToInt32(Console.ReadLine());
            //bool isLeap = obj3.IsLeapYear(year);
            //if (isLeap)
            //{
            //    Console.WriteLine(year + " is a leap year.");
            //}
            //else
            //{
            //    Console.WriteLine(year + " is not a leap year.");
            //}

            //StudentVoteChecker obj4 = new StudentVoteChecker();
            //int[] ages = { 15, 18, 20, 17, 22, -4, 16, 67,-8,12 };
            //foreach (int age in ages)
            //{
            //    bool canVote = obj4.CanStudentVote(age);
            //    if (canVote)
            //    {
            //        Console.WriteLine("Student with age " + age + " is eligible to vote.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Student with age " + age + " is not eligible to vote.");
            //    }
            //}

            //FindYoungestAndTallest obj5 = new FindYoungestAndTallest();
            //int[] ages = new int[3];
            //double[] heights = new double[3];
            //Console.WriteLine("Enter ages of three students: ");
            //for(int i=0; i<3; i++)
            //{
            //    ages[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //Console.WriteLine("Enter heights of three students: ");
            //for (int i = 0; i < 3; i++)
            //{
            //    heights[i] = Convert.ToDouble(Console.ReadLine());
            //}
            //obj5.FindYoungest(ages);
            //obj5.FindTallest(heights);


            // using UnitConverter class to convert units
            //double km = 10.0;
            //double miles = UnitConverter.ConvertKmToMiles(km);
            //Console.WriteLine($"{km} kilometers is equal to {miles} miles.");
            //miles = 6.21;
            //km = UnitConverter.ConvertMilesToKm(miles);
            //Console.WriteLine($"{miles} miles is equal to {km} kilometers.");
            //double meters = 100.0;
            //double feet = UnitConverter.ConvertMetersToFeet(meters);
            //Console.WriteLine($"{meters} meters is equal to {feet} feet.");
            //feet = 328.08;
            //meters = UnitConverter.ConvertFeetToMeters(feet);
            //Console.WriteLine($"{feet} feet is equal to {meters} meters.");

            //int[] nums = { 1, 2, 3, -4, 5 };
            //FindPosNeg obj6 = new FindPosNeg();
            //foreach(int i in nums)
            //{
            //    if(obj6.PosNeg(i)==1)
            //    {
            //        if(obj6.IsEvenOdd(i)==1)
            //        {
            //            Console.WriteLine($"Number {i} is positive and even");
            //        }
            //        else
            //        {
            //            Console.WriteLine($"Number {i} is positive and odd");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Number {i} is negative");
            //    }
            //}
            //int res = obj6.Compare(nums[0], nums[nums.Length - 1]);
            //if (res == 1) {
            //    Console.WriteLine($"{nums[0]} is greater than {nums[nums.Length-1]}");
            //}
            //else if(res == -1)
            //{
            //    Console.WriteLine($"{nums[0]} is smaller than {nums[nums.Length - 1]}");
            //}
            //else
            //{
            //    Console.WriteLine($"{nums[0]} is equal to {nums[nums.Length - 1]}");
            //}

            //double[,] data = new double[10, 2];
            //for(int i=0; i<data.GetLength(0); i++)
            //{
            //    for(int j=0; j<data.GetLength(1); j++)
            //    {
            //        data[i, j] = Convert.ToDouble(Console.ReadLine());
            //    }
            //}
            //BMI obj7 = new BMI();
            //obj7.FindBMI(data);


            // using UnitConverter02 for converting units
            //double yards = 200;
            //double feet = UnitConverter02.ConvertYardsToFeet(yards);
            //Console.WriteLine($"{yards} yards is equal to {feet} feet.");
            //feet = 200;
            //yards = UnitConverter02.ConvertFeetToYards(feet);
            //Console.WriteLine($"{feet} feet is equal to {yards} yards.");
            //double meters = 20;
            //double inches = UnitConverter02.ConvertMetersToInches(meters);
            //Console.WriteLine($"{meters} m is equal to {inches} inches.");
            //inches = 200;
            //meters = UnitConverter02.ConvertInchesToMeters(inches);
            //Console.WriteLine($"{inches} inches is equal to {meters} m.");

            //RandomClass obj8 = new RandomClass();
            //int[] numbers = obj8.Generate4DigitRandomArray(5);
            //Console.WriteLine("random numbers are: "+string.Join(", ",numbers));
            //obj8.FindAverageMinMax(numbers);

            Quadratic obj9 = new Quadratic();
            obj9.FindRoots(2, 3, 4);




        }
    }
}