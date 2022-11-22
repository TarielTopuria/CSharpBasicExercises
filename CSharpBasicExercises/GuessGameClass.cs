using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicExercises
{
    public class GuessGameClass
    {
        public  static void GuessGame()
        {
            Random random = new Random();
            int correctNumber = (Int32)random.NextInt64(1, 20);
            int inputedNumber;
            int counter = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter Number: ");
                inputedNumber = Int32.Parse(Console.ReadLine());
                counter++;

                if (inputedNumber > correctNumber)
                {
                    Console.WriteLine("The entered number is greater than the assumed number");
                }
                else if (inputedNumber < correctNumber)
                {
                    Console.WriteLine("The entered number is less than the assumed number");
                }
                else
                {
                    Console.WriteLine("You won!");
                    break;
                }

                if (counter == 5)
                    Console.WriteLine("You Lose!");
            }
        }
    }
}
