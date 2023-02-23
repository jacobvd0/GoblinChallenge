
using System.Data.Common;

namespace ArrayChallenge
{
    internal class Program
    {

        //start with a goblin class
        class Goblin
        {
            //a goblin!
        }

        static void Main(string[] args)
        {

            Goblin[] goblins = new Goblin[6]; //create a goblin array with six slots

            //intialise our array

            goblins[0] = null;
            goblins[1] = new Goblin();
            goblins[2] = null;
            goblins[3] = new Goblin();
            goblins[4] = null;
            goblins[5] = new Goblin();

            //CHALLENGE: sort the array so that the null values are at the bottom

            Console.WriteLine("---Before sort---");
            PrintArray();

            SecretSort(); //special secret sort happens here

            Console.WriteLine("---After sort---");
            PrintArray();



            void PrintArray()
            {
                foreach (Goblin goblin in goblins)
                {
                    string label = goblin == null ? "null" : "goblin!";
                    Console.WriteLine(label);
                }
            }

            // Sorts goblin array
            void SecretSort()
            {
                // Variables used for the loops
                var totalGoblins = 0;
                var nullGoblins = 0;
                var progress = 0;

                // Check how many null and normal goblins there are
                foreach (Goblin goblin in goblins)
                {
                    if (goblin == null)
                    {
                        nullGoblins++;
                    }
                    else
                    {
                        totalGoblins++;
                    }
                }

                // Add the normal goblins
                for (int i = 0; i < totalGoblins; progress++)
                {
                    goblins[progress] = new Goblin();
                    i++;
                }

                // Add the null goblins
                for (int i = 0; i < nullGoblins; progress++)
                {
                    goblins[progress] = null;
                    i++;
                }
            }

        }
    }
}
