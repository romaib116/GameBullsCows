using System;

namespace BullsCows
{
    /// <summary>
    /// BullsCowsGame
    /// </summary>
    public class Game
    {
        static int[] PlayerInput()
        {
            Console.WriteLine("Please, input your solver - ");
            string tempInput = Console.ReadLine();
            // If quit
            if ( tempInput == "-1")
            {
                Console.WriteLine("Okay, quit, game end!");
                return null;
            }
            //If error
            else if (tempInput.Length != 4)
            {
                Console.WriteLine("Please, retry: ");
                PlayerInput();
            }
            //If all ok
            else
            {
                var Result = new int[tempInput.Length];
                for (int i = 0; i < Result.Length; Result[i] =  (int)char.GetNumericValue(tempInput[i]), i++);
                return Result;
            }
            return null;
        }


        public static void StartGame()
        {
            int[] computerPuzzle = new int[4]; //Init array
            Random random = new Random(); //Init random
            for (int i = 0; i < computerPuzzle.Length; i++) //Generate unique array
            {
                bool matchesCheck = true; //Checker
                while (matchesCheck) //While have matches generate new random number
                {
                    computerPuzzle[i] = random.Next(1, 9); 
                    var counter = 0; //Count of matches
                    for (int j = 0; j < computerPuzzle.Length; j++) //Check for matches
                    {
                        if (computerPuzzle[i]== computerPuzzle[j])
                        {
                            counter++;
                        }
                    }
                    matchesCheck = counter > 1 ? true : false; //If have matches go generate new number
                }
                Console.WriteLine(computerPuzzle[i]);
            }
            bool winMarker = false;
            //While dont win
            while (!winMarker) 
            {
                //Player Solver
                var playerSolver = PlayerInput();
                var Bulls = 0;
                var Cows = 0;
                //If game dont stoped
                if (playerSolver != null)
                {
                    for (int i = 0; i < computerPuzzle.Length; i++)
                    {
                        for (int j = 0 ; j < playerSolver.Length; j++)
                        {
                            if (computerPuzzle[i] == playerSolver[j] && i == j) 
                                Bulls++;
                            if (computerPuzzle[i] == playerSolver[j] && i != j) 
                                Cows++;
                        }
                    }
                    Console.WriteLine("{0},{1}", Bulls, Cows);
                    winMarker = Bulls == 4 ? true : false;
                }
                //If player quit (returned null)
                else
                {
                    break;
                }
            }
            if (winMarker) 
                Console.WriteLine("Congratulations, you won!");
        }
    }
}
