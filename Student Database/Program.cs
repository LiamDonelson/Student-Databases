using System.Runtime.InteropServices;

namespace Student_Database
{
    internal class Program
    {
        static void Main()
        {
            // Sets up the strings for the whole program
            string[] studentNames = { "Jon", "Kurt", "Kaden", "Ell", "Elizabeth", "Dale", "Conaire", "Mike" };
            string[] studentHometown = { "Rodgers City", "Royal Oak", "Woodinville", "London", "Alpena", "Dearborn", "Marquette", "Detroit" };
            string[] studentFavFood = { "Birthday Cake", "Sandwiches", "Pizza", "Pasta", "Pancakes", "Perogi", "Hummus", "Tacos", };
            
            // this loop is for asking if they want a list of names
            while (true){
                Console.WriteLine("Today you will be learning about students. Would you like to see thier names first? Y/N");

               
                string asknames = Console.ReadLine().ToLower();
                if (asknames == "y")
                {
                    // displays names
                    Console.WriteLine("{0}", string.Join(", ", studentNames));
                }
                else if (asknames == "n")
                {
                    // just continues
                }
                else
                {
                    // repeats from the begining
                    Console.WriteLine(" Sorry im unsure of what you wanted to do. Please use Y/N");
                    continue;

                }

                Console.WriteLine("Please choose a student to learn about, input a number 1-8!");
                

                // picking the index that will select all of the other answers
                int chosenNumber = int.Parse(Console.ReadLine());


                
            if (chosenNumber>8 || chosenNumber <= 0)
            {
                Console.WriteLine("Can't do that!");
                continue;
            }

            // displaying the actual information based on an if statement while in a while loop.
                while (true)
                {
                    Console.WriteLine($"You have chosen {studentNames[chosenNumber - 1]}, would you like to learn about their hometown or favorite food?");
                    string choice = Console.ReadLine().ToLower();

                    if (choice == "hometown"|| choice == "town" || choice == "t" || choice == "h")
                    {
                        Console.WriteLine($"{studentNames[chosenNumber - 1]} is from the town of {studentHometown[chosenNumber - 1]}");
                        break;
                    }
                    else if (choice == "favorite food" || choice == "food" || choice == "f")
                    {
                        Console.WriteLine($"{studentNames[chosenNumber - 1]} has the favorite food of {studentFavFood[chosenNumber - 1]}");
                        break;
                        
                    }
                    else
                    {
                        Console.WriteLine("Uhhhh, pick again because I couldnt read your answer. Sorry!!!");
                        continue;

                    }


                }
                // run again if not break
                if (RunAgain() == false) 
                    break;
            }


            // All about asking them if they want to run the progam again
            static bool RunAgain()
            {
                Console.WriteLine("Would you like to learn about another student? Y/N");
                string restart = Console.ReadLine().ToLower();
                if (restart == "y")
                {
                    return true;
                }
                else if (restart == "n")
                {
                    // ends the program
                    Console.WriteLine("Have a great day !");
                    return false;
                }
                else
                {
                    // runs the program again
                    Console.WriteLine(" Im sorry, im not sure what that meant.");
                    return RunAgain();
                }

            }

        }
    }


}
    
