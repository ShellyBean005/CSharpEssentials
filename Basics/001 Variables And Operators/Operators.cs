//Use this file to store your work to demonstrate your understanding of operators
//Make sure your work is different from the instructors examples or your peers
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
  //input a word

            Console.WriteLine("What's the longest word you know off the top of your head?");

            string wordOne = Console.ReadLine();

            int length = wordOne.Length;

            Console.WriteLine("That word is " + length + " letters long");

            Console.WriteLine("Give me a word longer than that");

  //Input second word

            string wordtwo = Console.ReadLine();

            int secondLength = wordtwo.Length;

            int answer = length - secondLength;

  //Was the second word longer?

            if (answer > 0)
            {
                Console.WriteLine("That word is " + answer + " longer than the first. Well done");
                    }
            else if (answer < 0) 
            { 
                Console.WriteLine("That word is " + answer + " shorter than the first. Use google next time i guess");
                    }
            else
            {
                Console.WriteLine("That word is the same length as the first one....");
                    }
           Console.ReadLine(); //This is here so the app doesn't close
        }
    }
}