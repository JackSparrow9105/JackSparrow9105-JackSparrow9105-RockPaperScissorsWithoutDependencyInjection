using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class GameManager
    {
        Random _rng = new Random();

        public RoundResult PlayRound()
        {
            //Player1 Human
            Choice P1;
            do
            {
                Console.Write("Enter Choice: (R)ock, (P)aper, (S)cissors: ");
                string input = Console.ReadLine().ToUpper();
                if (input == "R")
                {
                    P1 = Choice.Rock;
                    break;
                }
                else if (input == "P")
                {
                    P1 = Choice.Paper;
                    break;
                }
                else if (input == "S")
                {
                    P1 = Choice.Scissors;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Choice, try again");
                }
            }
            while (true);
               Choice P2 = (Choice)_rng.Next(0,3);
                Console.WriteLine($"Player 2 picked {P2.ToString()}");
                if (P1 == P2)
                {
                    return RoundResult.Draw;
                }
                if (P1 == Choice.Rock && P2 == Choice.Scissors || 
                    P1 == Choice.Paper && P2 == Choice.Rock ||
                    P1 == Choice.Scissors && P2 == Choice.Paper)
                {
                    return RoundResult.Player1Win;
                }   
                return RoundResult.Player2Win;
            
        }
    }

    public enum Choice
    {
        Rock,
        Paper,
        Scissors
    }
    public enum RoundResult
    {
        Player1Win, Player2Win, Draw
    }
}
