using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysSample
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is Data Structure or Collections or a Collection Class
            //Better than doing ArrayList
            var roster = new List<string>();
            roster.Add("J. Doe");
            roster.Add("Bob Smith");
            roster.Add("Some Person");
            roster.Add("Jim");
            roster.Add("Dwight");
            roster.Sort();

            Console.WriteLine(string.Join(", ", roster));
            Console.ReadKey();



            //resizing an array manually
            int[] numbers = new int[5];
            int[] numbersBigger = new int[10];
            Array.Copy(numbers, numbersBigger, 5);

            //resize array
            Array.Resize(ref numbers, 10);

            double[] testScores = new double[3];

            //get user input
            for (int index = 0; index < testScores.Length; index++)
            {
                Console.Write("Enter next score: ");
                double score = Convert.ToDouble(Console.ReadLine());
                testScores[index] = score;
            }

            double total = 0;
            for (int i = 0; i < testScores.Length; i++)
            {
                total += testScores[i];
            }

            //echo scores
            //foreach loops, grant read access to every
            //element of an array/collection
            foreach (double num in testScores)
            {
                Console.WriteLine($"You entered {num}");
            }
            //Same as above
            for (int i = 0; i < testScores.Length; i++)
            {
                Console.WriteLine($"You entered {testScores[i]}");
            }

            double avg = total / testScores.Length;

            //interpolated string; uses the $
            //Console.WriteLine($"Your average is {avg.ToString("n2")}");
            //Same as above
            Console.WriteLine($"Your average is {avg:n2}");

            Console.ReadKey();


            var grades = new string[3] { "A", "A", "B" };

            //This initializes an array with the values all at once, this gives the array a length of 3
            string[] months = { "January", "February", "March" };

            const int Size = 10;

            string[] students = new string[Size];

            students[0] = "Joe";
            students[1] = "Bob";
            students[9] = "Last Student";
            //students[10] = "Try this"; would throw an IndexOutOfBounds Exception

            Array.Sort(students);
            //Reverses the Array order
            Array.Reverse(students);

            //prints out the array
            Console.WriteLine(string.Join(", ", students));
            Console.ReadKey();
        }
    }
}
