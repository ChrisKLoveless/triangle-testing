using System;

namespace Triangle
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Input Sides of a Triangle [num,num,num]");
            string userInput = Console.ReadLine();
            string[] userArray = userInput.Split(",");
            foreach (string ua in userArray) {
                int intCheck = 0;
                if (int.TryParse(ua, out intCheck) == false) {
                    Console.WriteLine("Invalid Input");
                    Environment.Exit(1);
                }
            }
            if (userArray.Length != 3) {
                Console.WriteLine("Invalid Input");
                Environment.Exit(1);
            }
            Tri newTri = new Tri(int.Parse(userArray[0]), int.Parse(userArray[1]), int.Parse(userArray[2]));

            if (newTri.IsTriangle() == false)
            {
                Console.WriteLine("That is NOT a Triangle");
                Environment.Exit(2);
            }
            else if (newTri.AllSidesEqual())
            {
                Console.WriteLine("That is an Equilateral Triangle");
            }
            else if (newTri.TwoEqual())
            {
                Console.WriteLine("That is an Isosceles Triangle");
            }
            else if (newTri.NoSidesEqual())
            {
                Console.WriteLine("That is an Scalene Triangle");
            }
        }
    }
}