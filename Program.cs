/* 
 Project: Assignment 3a
 Author: Jared Krachenfels
 Class: ISM 3400 Tavis
 Date: 9/24/2020
 */

using System;

namespace TechProject_3a_JKrachenfels
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter you name: ");
            // This variable gathers data from the user
            string input = Console.ReadLine();

            // Call Method
            printName(input);
        } // End of Main

        // Create method for user to input their name and prints name to console
        private static void printName(string name)
        {
            // If statement to give different responses based on user's input
            if (name == "Jared")
                Console.WriteLine("Hello " + name + " - Go Giants");
            else if (name == "Travis")
                Console.WriteLine("Hello Professor " + name + " - You are the greatest!");
            // Else applies to anyone's name that does not qualify if the if statement
            else
                Console.WriteLine("Hello " + name + " - You should consider being a Giants fan.");
        }  // End of method printName
    } // End of Class
} // End of Namespace
