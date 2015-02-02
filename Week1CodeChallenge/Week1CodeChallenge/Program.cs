using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1CodeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            //taking a loop of 1-20 and calling FizzBuzz
            int number = 0;

            for (int i = 0; i <=20; i++)
            {
                FizzBuzz(i);
            }

            //takeing a loop of 92 - 79
           
            for (int i = 92; i >= 79; i--)
            {
                FizzBuzz(i);
            }

            //Yodaizer - "I like code" to "code like I"

            string text = "I like code";
            Console.WriteLine(Yodaizer(text));
           

            //#4 Count everything

            string input = "Colts shouda won";
            TextStats(input);
           

            //IsPrime checking if 1 - 25 (only odd numbers) are prime numbers

              for (int i = 1; i <= 25; i += 2)
              {
                
                  if (IsPrime(i))
                  {
                      Console.WriteLine(i + " is a Prime number!");
                  }
                  else
                  {
                      Console.WriteLine(i);
                  }
                
              }

            //DashInsert checking to see if 454793 adds the right amount of dashes

              
              Console.WriteLine(DashInsert(454793));

              Console.WriteLine(DashInsert(8675309));
           


        }
       
        /// <summary>
        /// Taking a number and seeing if it is diviable by 3 and 5, by 3 or by 5. 
        /// </summary>
        /// <param name="number">any number</param>
        /// <returns> FizzBuzz, Fizz or Buzz</returns>
        public static string FizzBuzz(int number)
       
        {
            //taking a number and testing to see if it has a remainder after dividing by 3 or 5
            if (number % 3 == 0 && number % 5 ==0)
            {
                return "FizzBuzz";
            }
            else if (number %3 == 0)
            {
                return "Buzz";
            } 
            else if (number %5 == 0)
            {
                return "Fizz";
            }
            return number.ToString();
        }

       /// <summary>
       /// Making the words in a string reverse in order "I Love Lucy" to "Lucy Love I"
       /// </summary>
       /// <param name="text">any string of words</param>
       /// <returns>that sting of words in reverse!</returns>
        
        public static string Yodaizer(string text)
        {
            //split my string into seperate strings in an array
            string[] newList = text.Split(' ');
            
            //defining where I want to put the result from my text.split
            string returnString = "";

            //for loop for taking the string and counting backwards
            for (int i = newList.Length - 1; i >= 0; i--)
            {
                //taking the info from my for loop and putting into my new string returnString
                returnString += newList[i];
                
                //making sure that there is more "words" in the array
                if (i > 0)
                {
                    //if there isn't!  take that data and add a space into it.  
                    returnString += ' ';
                }
            }
               //returning the information info the proper format 
            return returnString;
        }
        
        /// <summary>
        /// finding information about a sting ie: number of char, number of words, number of vowels etc. 
        /// </summary>
        /// <param name="input">string of words to check</param>
        public static void TextStats(string input)
        {

          //defining the number of characters in a string
           int numberOfCharacters = 0;
           int numberOfWords = 0;
           int numberOfVowels = 0;
           int numberOfConsonants = 0;
           int numberOfSpecial = 0;
            
               //starting my loop to count the number of Characters
               for (int i = 0; i < input.Length; i++)
               {
                    
                   //taking the for loop info and putting it into my new oneLetter var
                   string oneLetter = input[i].ToString();
                   numberOfCharacters++;
                   //taking the oneLetter returned form the for loop and seeing if it is a vowel
                   if (oneLetter == "a" || oneLetter == "e" || oneLetter == "i" || oneLetter == "o" || oneLetter == "u")
                   {
                       numberOfVowels++;
                   }
                   //taking the oneLetter returned from the for loop and seeing if it has a special character
                   else if (oneLetter == " " || oneLetter == "." || oneLetter == "?")
                   {
                       numberOfSpecial++;
                   }
                   //if all else fails then count the oneLetter as a consonant!  
                   else
                   {
                       numberOfConsonants++;
                   }
               }
                numberOfWords = input.Split(' ').Length;

            //output to the console

                Console.WriteLine("The number of characters is " + numberOfCharacters);
                Console.WriteLine("The number of words is " + numberOfWords);
                Console.WriteLine("The number of vowels is " + numberOfVowels);
                Console.WriteLine("The number of consonants is " + numberOfConsonants);
                Console.WriteLine("The number of special characters is " + numberOfSpecial);
          }
                       
        /// <summary>
        /// checking any number to see if it is a prime number or not
        /// </summary>
        /// <param name="number">any number</param>
        /// <returns> true of false statement</returns>
        public static bool IsPrime(int number)
        {
            
            //evaulating the number based on if it is divisable by 2.  No prime number is divisable by 2.
            if (number > 2 && number % 2 == 0)
            {
                
                //if it is?  not a prime
                return false;
            }

            //evaulating the number in a loop to see if it is greater than 2, and an odd number divisable by i
            for (int i = 3; i < number; i += 2)
            {
                if (number % i == 0)
                {
                   // if it has no remainder then it still is not a prime number                    
                    return false;
                }

            }

            //if it does not meet the above conditions, then wala!  It is a prime!   
            return true;

        }
               
        
        /// <summary>
        /// Adding a "-" into a string of numbers, seperating two congoining odd numbers
        /// </summary>
        /// <param name="number">string of any numbers</param>
        /// <returns>that same string of numbers with the appropriate dashes inserted</returns>
        public static string DashInsert(int number)
        {
           //initializing my vaiables.  I need an empty string first, a place to put the numbers into the string
           // and a bool statement so that I can evauate the result to see if I get not just one odd but two in a row
           string result  =  "";
           string myNumber = number.ToString();
           bool lastOdd = false;

            //for loop to go through the length of my string
           for (int i = 0; i < myNumber.Length; i++)
           {
               //taking the string and identifying the index.  also identifying it is a number
               //so that we can do math to it!!
               if (int.Parse(myNumber[i].ToString()) % 2 != 0)
               {
                  //found odd number and you start with lastOdd as a bool = false.  you want to start there since 
                   //you only might have one odd number.  You need to have two.  

                   if (lastOdd)
                   {
                       // two odds in a row, so add a dash
                       result += "-" + myNumber[i];
                   }
                   else
                   {
                       result += myNumber[i];
                   }
                   lastOdd = true;
                   
               }
               else
               {
                   // even number
                   result += myNumber[i];
                   lastOdd = false;
               }
           }
           return result;
        }
    }
}
