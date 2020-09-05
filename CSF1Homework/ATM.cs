using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class ATM
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Welcome to the ATM");
            Console.Title = "<============ ATM ==========>";

            string accountNbr = "12345";
           
            int attempt = 0;
            bool isCorrect = false;

            while (attempt <=4 && isCorrect == false)
            { 
                Console.WriteLine("Please enter your 5 digit account number: ");
                string userInput = Console.ReadLine();

                attempt++;

                if(userInput == accountNbr)
                {
                    isCorrect = true;
                }

            }

            string pin = "1234";

            int pinAttempt = 0;
            bool isPin = false;

            while (pinAttempt <= 4 && isPin == false)
            {
                Console.WriteLine("Please enter your 4 digit pin number: ");
                string pinInput = Console.ReadLine();

                pinAttempt++;

                if (pinInput == pin)
                {
                    isPin = true;
                }
            }

            //Once the user has successfully given their account and pin numbers, prompt the user with a menu and ask them if they want to do a deposit, a withdrawal, or exit the application. 

            bool returnMenu = true;

            while (returnMenu == true)
            {
                Console.WriteLine("\n\nPelase choose from the following options.\nWould you like to \n1)Deposit \n2)Withdrawal \nExit");
                                 
                string userOption = Console.ReadLine().ToUpper();
                switch (userOption)
                {
                    case "1":
                    case "DEPOSIT":
                    case "D":
                        Console.WriteLine("Please enter the amount you would like to deposit.");
                        string deposit = Console.ReadLine();
                        decimal depositA = decimal.Parse(deposit);
                        Console.WriteLine($"{depositA:c} has been deposited into account # 12345.");
                        Console.WriteLine("Would you like to execute another transaction? Y/N");
                        string response = Console.ReadLine().ToUpper();
                        if (response == "Y")
                        {
                            returnMenu = true;
                        }
                        else if (response == "N")
                        {
                            returnMenu = false;
                            Console.WriteLine("Thank you, come again!");
                        }

                        break;
                    case "2":
                    case "W":
                    case "WITHDRAWAL":
                        Console.WriteLine("Please enter the amount you would like to deposit.");
                        string withdrawal = Console.ReadLine();
                        decimal withdrawalA = decimal.Parse(withdrawal);
                        Console.WriteLine($"{withdrawalA:c} has been withdrawn from account # 12345.");
                        Console.WriteLine("Would you like to do another withdrawal?");
                        Console.WriteLine("Would you like to execute another transaction? Y/N");
                        string response2 = Console.ReadLine().ToUpper();
                        if (response2 == "Y")
                        {
                            returnMenu = true;
                        }
                        else if (response2 == "N")
                        {
                            returnMenu = false;
                            Console.WriteLine("Thank you, come again!");
                        }
                        break;
                    case "3":
                    case "X":
                    case "EXIT":
                    case "E":
                        Console.WriteLine("Thank you for visiting!");
                        returnMenu = false;
                        break;
                }
            }


        }//end Main ()
    }//end Class
}//end Namespace
