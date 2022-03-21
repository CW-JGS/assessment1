using System;

namespace challenge1
{
    class Program 
    {
        public static void Main(string[] args) 
        {
            List<int> diceValues = new List<int>();
            Random random = new Random();
            bool isRunning = true;
            while(isRunning)
            {
                diceValues.Clear();
                int numberOfDice = 0;
                string diceValuesString = "";
                string runAgain = "";
                Console.Write("\n How Many Dice Would You Like To Roll? : ");
                // cheeky error handling to stop dodgey blokes
                bool isInputValid = int.TryParse(Console.ReadLine(), out numberOfDice);
                if (isInputValid)
                {
                    if(numberOfDice<=2500)
                    {
                        for (int i = 0; i < numberOfDice; i++)
                        {
                            int tempNumber = random.Next(1,7);
                            diceValues.Add(tempNumber);

                        }
                        diceValuesString = string.Join(", ", diceValues);
                        Console.WriteLine("\n [ {0} ]",diceValuesString);
                        while (true)
                        {
                            Console.Write("\n Would You Like To Roll Again? (Y/N) : ");
                            runAgain = Console.ReadLine();
                            if (runAgain.ToUpper() =="Y" || runAgain.ToUpper() == "YES" || runAgain.ToUpper() =="N" || runAgain.ToUpper() == "NO")
                            {
                                if (runAgain.ToUpper() == "Y" || runAgain.ToUpper() == "YES")
                                {
                                    break;
                                }
                                else if (runAgain.ToUpper() == "N" || runAgain.ToUpper() == "NO")
                                {
                                    Console.WriteLine("\n Thank You Have A Great Day");
                                    isRunning = false;
                                    break;
                                }
                            }
                            else
                            {
                                isInputValid = false;
                                Console.WriteLine("\n Invalid Input - Please Try Again");
                            }

                        }
                    }
                } 
                if (!isInputValid)
                {
                    Console.WriteLine("\n Invalid Input - Please Try Again");
                }
            }
        }
    }

}
