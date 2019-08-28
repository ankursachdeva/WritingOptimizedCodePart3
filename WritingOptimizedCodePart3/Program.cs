using System;
using System.Diagnostics;
using System.Text;

namespace WritingOptimizedCodePart3
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sbOutput = new StringBuilder();
            Console.Title = "Ankur Tech Center | Hanumantey Software Solutions";
            int patternLength = 26;
            Console.Write("Enter the " +
                "Desired Pattern Length: ");
            int.TryParse(Console.ReadLine()
                , out patternLength);
            Console.WriteLine("Displaying pattern" +
                $" using Method 1 of {patternLength}" +
                " pattern length 5 times.");
            Stopwatch sw1 ;
            for (int i = 0; i < 5; i++)
            {
                sw1 = new Stopwatch();
                sw1.Start();
                DisplayPatternMethod1(patternLength);
                sw1.Stop();
                sbOutput.AppendLine(
                    "Displaying pattern with " +
                "Method 1 took " +
                $"{sw1.ElapsedMilliseconds} ms.");
                
            }
            Console.WriteLine("Displaying pattern " +
                "using Method 2 of " +
                $"{patternLength} pattern length 5 times.");
            Stopwatch sw2;
            for (int i = 0; i < 5; i++)
            {
                sw2 = new Stopwatch();
                sw2.Start();
                DisplayPatternMethod2(patternLength);
                sw2.Stop();
                sbOutput.AppendLine(
                "Displaying pattern with" +
                " Method 2 took " +
                $"{sw2.ElapsedMilliseconds} ms.");
            }
            Console.WriteLine(sbOutput.ToString()
                );
            
            Console.ReadLine();
        }
        static void DisplayPatternMethod1(int patternLength)
        {
            int leftSpacer = 0;
            int middleSpacer = patternLength - 2;
            for (int rows = 0;
                rows < patternLength/2; rows++)
            {
                for (int initialSpaces = 0; 
                    initialSpaces < leftSpacer; 
                    initialSpaces++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                for (int spaces = 0; 
                    spaces <= middleSpacer;
                    spaces++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                leftSpacer++;
                middleSpacer -= 2;
                Console.WriteLine();
            }
            //Reseting variables for bottom pattern
            if (patternLength%2==0)
            {
                leftSpacer =
                    patternLength / 2 - 1;
            }
            else
            {
                leftSpacer = 
                    patternLength / 2;
            }
            
            middleSpacer = 0;
            for (int rows = 0; 
                rows < patternLength / 2; rows++)
            {
                for (int initialSpaces = 0;
                    initialSpaces < leftSpacer;
                    initialSpaces++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                for (int spaces = 0;
                    spaces < middleSpacer; 
                    spaces++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                leftSpacer--;
                middleSpacer += 2;
                Console.WriteLine();
            }
        }
        static void DisplayPatternMethod2(int patternLength)
        {
            for (int rows = 0; 
                rows < patternLength; rows++)
            {
                for (int cols = 0; 
                    cols < patternLength; cols++)
                {
                    if (rows!=cols 
                        && 
                        rows+cols+1!=patternLength)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("*");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
