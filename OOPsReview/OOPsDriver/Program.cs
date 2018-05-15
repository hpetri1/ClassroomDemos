using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsDriver
{
    class Program
    {
        static void Main(string[] args)
        {
            //create the instances of our objects to be used in this program

            //you can check for additional namespaces that may be needed to use your objects

            //we need to have a structure that will allow one to hold an unknown number of instances 
            //of a variable 
            //List<T> is an object that holds x number of datatype instances
            //THe new List<T> physically creates the instance of List<T> in memory.
            //The constructor of List<T> is called
            List<Turn> gameTurns = new List<Turn>();

            //create 2 instances of the Die object
            Die Player1Dice = new Die();                //default contructor
            Die Player2Dice = new Die(6, "green");      //greedy constructor

            string menuChoice = "";
            do
            {
                Console.WriteLine("Game Menu: \n");
                Console.WriteLine("A) Set Die side count");
                Console.WriteLine("B) Roll the dice");
                Console.WriteLine("C) Display all game turn results");
                Console.WriteLine("X) Exit");
                Console.Write("Enter menu choice: ");
                menuChoice = Console.ReadLine();

                switch (menuChoice.ToUpper())
                {
                    case "A":
                        {
                            //logic can de done using a method
                            //Console.WriteLine("You selected A");
                            //the method will need to have the local variables Player1Dice and Player2Dice passed to it
                            //Objects are passed as references
                            SetDiceSides(Player1Dice, Player2Dice);
                            break;
                        }
                    case "B":
                        {
                            //logic can be done actually inside the case
                            //one does not have to always call a method
                            //Console.WriteLine("You selected B");

                            //Roll the dice for each player
                            //The dot operator is used with your instance to access a Property of a Behaviour
                            Player1Dice.Roll();
                            Player2Dice.Roll();

                            //record the result of the roll for this turn
                            //we need to create a new instance of the Turn class
                            Turn aturn = new Turn();

                            //assign the facevalue of each dice to the Turn instance
                            //     SET                      GET
                            aturn.Player1DiceValue = Player1Dice.FaceValue;
                            aturn.Player2DiceValue = Player2Dice.FaceValue;

                            //determine your battle results
                            //it does not matter in this logic whether we use the values from aturn or the Die variables
                            if(aturn.Player1DiceValue > Player2Dice.FaceValue)
                            {
                                aturn.TurnWinner = "Player1";
                            }
                            else if (aturn.Player2DiceValue > aturn.Player1DiceValue) //or Player1Dice.FaceValue instead of aturn.Player1DiceValue as an example
                            {
                                aturn.TurnWinner = "Player2";
                            }
                            else
                            {
                                aturn.TurnWinner = "Draw";
                            }

                            //Display teh results to teh user
                            Console.WriteLine("Results: Player1 rolled {0}" + " Player2 rolled {1}" + " Winner: {2}", aturn.Player1DiceValue, aturn.Player2DiceValue, aturn.TurnWinner);
                            //add the aturn instance to the List<T>
                            gameTurns.Add(aturn);
                            break;
                        }
                    case "C":
                        {
                            //Console.WriteLine("You selected C");
                            //display the current standing in the game
                            //foreach loop
                            //this loop will start processing your collection from the 1st instance to the last instance, moving automatically to the next instance

                            //C# will strongly datatype variables at compile time when the datatype is used in declaring the variable
                            //C# also has a datatype called var
                            //var datatype is set at execution time BUT is still strongly datatyped on its FIRST execution
                            foreach (var thisTurn in gameTurns)
                            {
                                Console.WriteLine("Results: Player1 rolled {0}" + " Player2 rolled {1}" + " Winner: {2}", thisTurn.Player1DiceValue, thisTurn.Player2DiceValue, thisTurn.TurnWinner);
                            }
                            Console.WriteLine("\n");
                            break;
                        }
                    case "X":
                        {
                            Console.WriteLine("Thank you for playing. Come again.");
                            break;
                            //Add foreeach loop that will walt through the collection
                            //Own if statement
                            //COunt all wins for Player1, wins for Player2, and count for Draws
                        }
                    default:
                        {
                            Console.WriteLine("Invalid menu choice. Try again.");
                            break;
                        }

                }
            } while (menuChoice.ToUpper() != "X");
            Console.ReadKey();
        }//end of main program eom

        public static void SetDiceSides(Die player1dice, Die player2dice)  //local variable are lower case
        {
            string indicesize = "";
            int dicesize = 6;

            Console.WriteLine("Set dice face count of 6 -20");
            Console.WriteLine("An invalid entry will default to 6");
            Console.Write("Enter number of sides: ");
            indicesize = Console.ReadLine();

            //VAlidation
            //a) did the user enter a number
            if (!int.TryParse(indicesize, out dicesize))
            {
                Console.WriteLine("Die size is invalid. Die size will be set to 6.");
                dicesize = 6;
            }
            else
            {
                //b) is integer between 6 and 20
                if (dicesize < 6 || dicesize > 20)
                {
                    Console.WriteLine("Die size is invalid. Die size will be set to 6.");
                    dicesize = 6;
                }
                else  //this else statement is actually not needed
                {
                    Console.WriteLine("Die size will be set to {0}.", dicesize);
                }
            }
            player1dice.SetSides(dicesize);
            player2dice.SetSides(dicesize);
        }
    }
}
