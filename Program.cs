/*
* Author: Rhomill Orina
* Description: Testing Conditional Statements with If statements.
*
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_BatSolution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int FirstNumber;
            int SecondNumber;

            Console.Write("\n\n");
            Console.Write("Check whether two integers are equal or not:\n");
            Console.Write("-------------------------------------------");
            Console.Write("\n\n");


            Console.Write("Input 1st number: ");
            ///I will try to find the solution to the If statement.
            FirstNumber = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Input 2nd number: ");
            ///Parseing intger to numerial numbers.
            SecondNumber = Convert.ToInt32(Console.ReadLine());

            /// <summary>
            /// If the first number equals the second number, they will match.
            /// or else they wouldn't match. 
            /// </summary>
            ///<param>First and Second number parameters.</param>
            if (FirstNumber == SecondNumber)
            {
                Console.WriteLine("They Match!");
            }
            else
            {
                Console.WriteLine("They do not Match!");
            }    
        }
    }
}
