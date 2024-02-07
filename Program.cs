using System;
using System.Text;

namespace StringExercises
{
    public class Program
    {
        public static void Main()
        {
            
        }
        
        //Write a program and ask the user to enter a few numbers separated by a hyphen. Work out if the numbers are
        //consecutive. For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", display a message: "Consecutive";
        //otherwise, display "Not Consecutive".

        public static void Exercise1()
        {
            Console.WriteLine("Enter a few numbers separated by a hyphen.");
            var input = Console.ReadLine();
            var numList = new List<int>();
            var array = input.Split('-');
            foreach (var num in array)
            {
                numList.Add(Convert.ToInt32(num));
            }

            var isConsecutive = false;

            for(var i = 0; i<=numList.Count -2; i++)
            {
                if (numList[i] + 1 == numList[i + 1] || numList[i] - 1 == numList[i + 1])
                {
                    isConsecutive = true;
                }
                else
                {
                    isConsecutive = false;
                    break;
                }

                
            }
            
            if (isConsecutive == true)
            {
                Console.WriteLine("Consecutive");
            }
            else
            {
                Console.WriteLine("Not Consecutive"); 
            }
            
        }
        
        //Write a program and ask the user to enter a few numbers separated by a hyphen. If the user simply presses
        //Enter, without supplying an input, exit immediately; otherwise, check to see if there are duplicates.
        //If so, display "Duplicate" on the console.

        public static void Exercise2()
        {
            Console.WriteLine("Enter a few numbers separated by a hyphen.");
            var input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                
            }
            else
            {
                var numList = new List<int>();
                var array = input.Split('-');
                foreach (var num in array)
                {
                    numList.Add(Convert.ToInt32(num));
                }

                for (var i = 0; i <= numList.Count - 1; i++)
                {
                    var working = numList[i];
                    numList.Remove(working);

                    if (numList.Contains(working))
                    {
                        Console.WriteLine("Duplicate");
                        break;
                    }

                }
            }
        }
        
        //Write a program and ask the user to enter a time value in the 24-hour time format (e.g. 19:00).
        //A valid time should be between 00:00 and 23:59. If the time is valid, display "Ok"; otherwise,
        //display "Invalid Time". If the user doesn't provide any values, consider it as invalid time.

        public static void Exercise3()
        {
            Console.WriteLine("Enter a time value in the 24-hour time format (e.g. 19:00).");
            var input = Console.ReadLine();
            if (!input.Contains(':'))
            {
                Console.WriteLine("Invalid Time");
            }
            else
            {
                var array = input.Split(':');
                var hour = Convert.ToInt32(array[0]);
                var minute = Convert.ToInt32(array[1]);

                if ((hour < 0 || hour > 23) || (minute <0 || minute > 59))
                {
                    Console.WriteLine("Invalid Time");
                }
                else
                {
                    Console.WriteLine("Valid Time");
                }
            }
        }
        
        //Write a program and ask the user to enter a few words separated by a space. Use the words to create a variable
        //name with PascalCase. For example, if the user types: "number of students", display "NumberOfStudents". Make
        //sure that the program is not dependent on the input. So, if the user types "NUMBER OF STUDENTS", the program
        //should still display "NumberOfStudents".

        public static void Exercise4()
        {
            Console.WriteLine("Enter a few words separated by a space.");
            var input = Console.ReadLine().ToLower();
            var array = input.Split(' ');
            var list = new List<string>();
            var builder = new StringBuilder();
            for(var i = 0; i<=array.Length -1; i++)
            {
                var word = array[i].Trim();
                string newWord;
                if (i == 0)
                {
                    newWord = word.Trim();
                }
                else
                {
                    newWord = word[0].ToString().ToUpper() + word.Substring(1);
                }
                
                list.Add(newWord);
            }

            foreach (var i in list)
            {
                builder.Append(i);
            }

            Console.WriteLine(builder);
        }

        //Write a program and ask the user to enter an English word. Count the number of vowels (a, e, o, u, i) in the
        //word. So, if the user enters "inadequate", the program should display 6 on the console.
        
        public static void Exercise5()
        {
            Console.WriteLine("Enter an English word.");
            var input = Console.ReadLine().Trim();
            var vowelCount = 0;
            foreach (var character in input)
            {
                var letter = character.ToString();
                if (letter == "a" || letter == "e" || letter == "o" || letter == "u" || letter == "i")
                {
                    vowelCount += 1;
                }
            }

            Console.WriteLine($"There are {vowelCount} vowels in {input.Trim()}.");
        }
    }
}