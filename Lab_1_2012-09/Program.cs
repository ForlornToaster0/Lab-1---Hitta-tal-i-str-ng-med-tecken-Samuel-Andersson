using System;

namespace Lab_1_2012_09
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("put in a long string with some numbers");       //makes sure that the user puts in a number
            string scentence = Console.ReadLine();      //reads what the user puts in 
            LookignAttTXT(scentence);       //executs the program that was assigned 
        }
        public static long total = 0;       //makes an long to add together all the numbers
        private static void LookignAttTXT(string longscentence)     //makes a void to make things eaasier to use 
        {


            for (int StartingTXT = 0; StartingTXT < longscentence.Length; StartingTXT++)        //makes a loop to check all of the charaters in the stritng the user gave
            {
                if (char.IsDigit(longscentence[StartingTXT]))       //if the loop finds a number move on 
                    for (int EndingTXT = StartingTXT + 1; EndingTXT < longscentence.Length; EndingTXT++)        //when number is found check ahead 
                    {
                        if (longscentence[StartingTXT] == longscentence[EndingTXT])     //when same number is found write out
                        {
                            var OGcolor = Console.ForegroundColor;      //saves the original color
                            Console.Write(longscentence.Substring(0, StartingTXT));
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write(longscentence.Substring(StartingTXT, EndingTXT - StartingTXT + 1));
                            string addnum = longscentence.Substring(StartingTXT, EndingTXT - StartingTXT + 1);
                            long addednum = long.Parse(addnum);

                            total += addednum;
                            Console.ForegroundColor = OGcolor;

                            if (EndingTXT < longscentence.Length - 1)
                            {
                                Console.Write(longscentence.Substring(EndingTXT + 1));
                            }
                            Console.WriteLine();


                            break;
                        }
                        else if (!char.IsDigit(longscentence[EndingTXT]))
                        {
                            break;
                        }
                    }
            }
            Console.WriteLine("Your total is = {0}", total);
        }
    }
}


