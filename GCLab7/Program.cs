using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace GCLab7
{
    class Program
    {
        static void Main(string[] args)
        {

            bool killswitch = true;

            while (killswitch)
            {
                ReturnNameValid();
                ReturnEmailValid();
                ReturnPhoneValid();
                ReturnDateValid();
                killswitch = ContinueLoop("Do you want to go again?");
            }


            // please enter a valid [input]
            //if it's invalid, go back and do it again
            // take the input and put it in a variable
            //if then statements to use correct validation method
            //return the validation message





        }

        static void ReturnNameValid()
        {
            while (true)
            {
                Console.WriteLine("Please enter a valid name: ");
                string userInput = Console.ReadLine();

                // put the name specific validation in here
                // return either valid or invalid message
                if (Regex.IsMatch(userInput, @"^[A-Z][a-z]{0,29}$"))
                {
                    Console.WriteLine("Name is valid.");
                    break;
                }

                else
                {
                    Console.WriteLine("Sorry, name is not valid.");
                    continue;
                }
            }
        }

        static void ReturnEmailValid()
        {
            while (true)
            {
                Console.WriteLine("Please enter a valid email: ");
                string userInput = Console.ReadLine();

                // put the name specific validation in here
                // return either valid or invalid message
                if (Regex.IsMatch(userInput, @"^[A-Za-z0-9]{5,30}@[A-Za-z0-9]{5,10}\.[A-Za-z0-9]{2,3}$"))
                {
                    Console.WriteLine("Email is valid.");
                    break;
                }

                else
                {
                    Console.WriteLine("Sorry, email is not valid.");
                    continue;
                }
            }
        }

        static void ReturnPhoneValid()
        {
            while (true)
            {
                Console.WriteLine("Please enter a valid phone number in format 000-000-0000: ");
                string userInput = Console.ReadLine();

                // put the specific validation in here
                // return either valid or invalid message
                if (Regex.IsMatch(userInput, @"\d{3}-\d{3}-\d{4}"))
                {
                    Console.WriteLine("Phone number is valid.");
                    break;
                }

                else
                {
                    Console.WriteLine("Sorry, phone number is not valid.");
                    continue;
                }
            }
        }

        static void ReturnDateValid()
        {
            while (true)
            {
                Console.WriteLine("Please enter a valid date number in format DD-MM-YYYY: ");
                string userInput = Console.ReadLine();

                // put the specific validation in here
                // return either valid or invalid message
                if (Regex.IsMatch(userInput, @"\d{2}-\d{2}-\d{4}"))
                {


                    Console.WriteLine("Date is valid.");
                    break;
                }

                // This solution is way more sensible but does not utilize regex

                // DateTime dateValid;

                //if (DateTime.TryParse(userInput, out dateValid))
                //{
                //    Console.WriteLine("Date is valid.");
                //    break;
                //}

                else
                {
                    Console.WriteLine("Sorry, date is not valid.");
                    continue;
                }
            }
        }

        static bool ContinueLoop(string prompt)
        {
            while (true)
            {
                bool userContinue;
                Console.WriteLine(prompt);
                Console.WriteLine("Y/N?");
                string userContinueInput = Console.ReadLine();

                if (userContinueInput.ToLower() == "y")
                {
                    userContinue = true;
                }

                else if (userContinueInput.ToLower() == "n")
                {
                    userContinue = false;
                }

                else
                {
                    Console.WriteLine("I'm not sure what you mean.");
                    continue;
                }


                return userContinue;

            }
        }

    }
}
