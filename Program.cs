using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2CodeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {

            LetterCounter("i", "I love biscuits and gravy. It's the best breakfast ever.");
            LetterCounter("n", "Never gonna give you up. Never gonna let you down");
            LetterCounter("s", "Sally sells seashells down by the seashore. She's from Sussex.");

            //for loop
            //create a loop for the numbers 0 to 20
            for (int i = 0; i <= 20; i++)
            {
                FizzBuzz(i);
            }

            Console.ReadKey();
        }
        static void FizzBuzz(int number)
        {
            if (number % 5 == 0 && number % 3 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (number % 5 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (number % 3 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(number);
            }
        }

        //this tells you how many charachters in a string
        static void LetterCounter(string letter, string inString)
        {

            int LowerCase = 0; // counts amount of lower case letters
            int UpperCase = 0; //counts amount of upper case letters

            for (int i = 0; i < inString.Length; i++)//loops through string
            {

                var currentLetter = inString[i].ToString();
                if (letter.ToUpper() == currentLetter)//finds and records upper case characters
                {
                    UpperCase += 1;

                }
                else if (letter.ToLower() == currentLetter)//finds and records lower case characters
                {
                    LowerCase += 1;

                }
            }
            Console.WriteLine("Input " + inString); //output
            Console.WriteLine("Number of Lowercase " + letter + "  s found: " + UpperCase);//output
            Console.WriteLine("Number of Uppercase " + letter + "  s found: " + LowerCase); //output
            Console.WriteLine("Total Number of " + letter + " s found: " + (UpperCase + LowerCase));//output
        }

        static void TextStats(string input) 
        {
            //create variables
            var numChar = input.Length;
            var numCharSplit = input.Split(' ');
            var numWords = numCharSplit.Length;
            int numVowels = 0;
            int numConsonant = 0;
            int numSpecChar = 0;

            var biggestWord = "";
            var shortestWord = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX";
            //The for loop it will print the biggest word and the shortest word
            for (int i = 0; i < numCharSplit.Length; i = i + 1) 
            {
                if (numCharSplit[i].Length > biggestWord.Length)  //Compares every character in the biggest word 
                {
                biggestWord = numCharSplit[i];  
            }
            
            }
            for (int i = 0; i < numCharSplit.Length; i = i + 1)
            {
                if (numCharSplit[i].Length < shortestWord.Length) //Compares every character in the shoretest word 
            {
                    shortestWord = numCharSplit[i];
            }
            }
            for (int i = 0; i < input.Length; i = i + 1) 
            {
            if (input[i].ToString() == "a" || input[i].ToString() == "e" || input[i].ToString() == "i" || input[i].ToString() == "o" || input [i].ToString() == "u")
            {
            numVowels = numVowels +1;
            }
            else if (input[i].ToString() == "." || input[i].ToString() == "," || input[i].ToString() == "?" || input[i].ToString() == ";")
            {
            numSpecChar = numSpecChar +1;
            }
            else if (input[i].ToString() != " ")
            {
            numConsonant = numConsonant + 1;


              }
            }
        }
    }
}