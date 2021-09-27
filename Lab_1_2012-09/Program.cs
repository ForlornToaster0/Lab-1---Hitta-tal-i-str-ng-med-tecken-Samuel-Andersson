using System;

namespace Lab_1_2012_09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("put in a long string with some numbers");       //makes sure that the user puts in a number
            string scentence = Console.ReadLine();      //reads what the user puts in 
            LookignAttTXT(scentence);       //executes the program that was assigned 
        }
        private static void LookignAttTXT(string longscentence)     //makes a void to make things eaasier to use 
        {
            long total = 0;       //makes an long to add together all the numbers
            var OGcolor = Console.ForegroundColor;      //saves the original color

            for (int StartingTXT = 0; StartingTXT < longscentence.Length; StartingTXT++)        //makes a loop to check all of the charaters in the string the user gave
            {
                if (char.IsDigit(longscentence[StartingTXT]))       //if the loop finds a number move on 
                    for (int EndingTXT = StartingTXT + 1; EndingTXT < longscentence.Length; EndingTXT++)        //when number is found check ahead 
                    {
                        if (longscentence[StartingTXT] == longscentence[EndingTXT])     //when same number is found write out
                        {
                            Console.Write(longscentence.Substring(0, StartingTXT));     //writes out the numbers before the found number 
                            Console.ForegroundColor = ConsoleColor.Green;       //changes the text color to green
                            Console.Write(longscentence.Substring(StartingTXT, EndingTXT - StartingTXT + 1));       //Writes out the number we are looking for 
                            string addnum = longscentence.Substring(StartingTXT, EndingTXT - StartingTXT + 1);      //Adds a string that can be convert later
                            long addednum = long.Parse(addnum);     //Converts the string to a long 
                            total += addednum;      //adds each number given together 
                            Console.ForegroundColor = OGcolor;      //makes the text white 
                            if (EndingTXT < longscentence.Length - 1)       //if there is a text after the number continue 
                            {
                                Console.Write(longscentence.Substring(EndingTXT + 1));      //write what comes after the number we found
                            }
                            Console.WriteLine();        //makes a new line
                            break;      //breaks out the loop
                        }
                        else if (!char.IsDigit(longscentence[EndingTXT]))       //if a letter is found
                        {
                            break;      //break out of the loop
                        }
                    }
            }
            Console.WriteLine("Your total is = {0}", total);        //writes out the tottal added number
            Console.ReadKey();      //makes sure the program doesn't clone 
        }
    }
}
