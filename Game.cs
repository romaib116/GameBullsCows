using System;
using System.Linq;


namespace Day2_HW
{
    class Game
    {
        static int[] PlayerInput()
        {
            Console.WriteLine("Please, input your solver - ");
            string tempInput = Console.ReadLine(); 
            if ( tempInput == "-1")  // If quit
            {
                Console.WriteLine("Okay, quit, game end!");
                return null;
            }
            else if (tempInput.Length != 4) //If error
            {

                Console.WriteLine("Please, retry: ");
                PlayerInput();
            }
            else //If all ok
            {
                var Result = new int[tempInput.Length];
                for (int i = 0; i < Result.Length; Result[i] =  (int)char.GetNumericValue(tempInput[i]), i++);
                return Result;
            }
            return null;
        }


        public static void StartGame()
        {
            int[] ComputerPuzzle = new int[4]; //Init array
            Random random = new Random(); //Init random
            for (int i = 0; i < ComputerPuzzle.Length; ComputerPuzzle[i] = random.Next(9), Console.WriteLine(ComputerPuzzle[i]), i++); //Fill rand
            bool WinMarker = false; 
            while (!WinMarker) //While dont win
            {
                var PlayerSolver = PlayerInput(); //Player Solver
                var Bulls = 0;
                var Cows = 0;
                if (PlayerSolver!=null) //If player game
                {
                    for (int i = 0; i < ComputerPuzzle.Length; i++) //Proccessing
                    {
                        for (int j = 0 ; j < PlayerSolver.Length; j++)
                        {
                            if (ComputerPuzzle[i] == PlayerSolver[j] && i == j) Bulls++;
                            if (ComputerPuzzle[i] == PlayerSolver[j] && i != j) Cows++;
                        }
                    }
                    Console.WriteLine("{0},{1}", Bulls, Cows);
                    WinMarker = Bulls == 4 ? true : false;
                }
                else //If player quit (returned null)
                {
                    break;
                }
            }
            if (WinMarker) Console.WriteLine("Congratulations, you won!");
        }
    }
}
