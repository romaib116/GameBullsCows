using System;

namespace Day2_HW
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Task 1; Enter Num and Power: ");
            CalculatePower.Calculate( 
                Convert.ToInt32(Console.ReadLine()) , 
                Convert.ToInt32(Console.ReadLine()) 
                );

            Console.WriteLine("Task 2; Game!");
            Game.StartGame();
        }
    }
}
