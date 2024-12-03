namespace IterationStatements
{
    public class Program
    {
        // LukeWarm Section: Implement the following methods        
        // 1. Write a method that prints all numbers from 1000 down to -1000 to the console.
        //    - Method Signature: void PrintNumbers()
        public static void PrintNumbers1000()
        {
            for(int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
           }
        }
        
        // 2. Write a method that prints every third number from 3 to 999 to the console.
        //    - Method Signature: void PrintEveryThirdNumber()
        public static void PrintEveryThirdNumber()
        {
            for(int num = 3; num <= 999; num += 3)
            {
                Console.WriteLine(num);
            }
        }
        
        // 3. Write a method that accepts two integers as parameters and checks whether they are equal.
        //    - Method Signature: bool AreNumbersEqual(int num1, int num2)
        //    - Returns true if the numbers are equal, false otherwise.

        public static void AreNumbersEqual(int num1, int num2)
        {
            if(num1 == num2)
            {
                Console.WriteLine($"{num1} and {num2} are the same.");
            }
            else
            {
                Console.WriteLine($"{num1} and {num2} are not the same.");
            }


        
        }
        
        // 4. Write a method that checks if a given number is even or odd.
        //    - Method Signature: bool IsEven(int number)
        //    - Returns true if the number is even, false if odd.
        public static bool IsEven(int number)
        {
            if(number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        // 5. Write a method that checks if a given number is positive or negative.
        //    - Method Signature: bool IsPositive(int number)
        //    - Returns true if the number is positive, false if negative.

        public static void IsPositive(int num3)
        {
            if (num3 < 0)
            {
                Console.WriteLine($"FALSE");
            }
            else
            {
                Console.WriteLine($"TRUE");
            }

        }
        
        // 6. Write a method that reads the age of a candidate and determines if they are eligible to vote.
        //    - Method Signature: bool CanVote(int age)
        //    - Returns true if the candidate can vote, false otherwise.
        //    - Hint: Use `int.Parse()` or the safer `int.TryParse()` for extra practice in handling user input.
        public static void CanVote()
        {
            Console.WriteLine($"How old are you?");
            var canParse = int.TryParse(Console.ReadLine(), out int userAge);

            while(canParse == false)
            {
                Console.WriteLine("Please enter a valid age");
                canParse = int.TryParse(Console.ReadLine(), out int age);
            }

            if (userAge >= 18)
            {
                Console.WriteLine($"Congratulations, you are old enough to vote!");
            }
            else
            {
                Console.WriteLine($"Unfortunately you are not old enough to vote yet.");
            }

           
        }
        
        // Heatin' Up Section:
        // 1. Write a method that checks if an integer (provided by the user) is within the range of -10 to 10.
        //    - Method Signature: bool IsInRange(int number)
        //    - Returns true if the number is within the range, false otherwise.

        public static void IsInRange()
        {
            Console.WriteLine($"Please provide a number.");
            var canParse = int.TryParse(Console.ReadLine(), out int userNumber);

            while (!canParse)
            {
                Console.WriteLine("Please enter a valid number");
                canParse = int.TryParse(Console.ReadLine(),out userNumber);
            }

            if(userNumber <= 10 && userNumber >= -10)
            {
                Console.WriteLine($"{userNumber} is in the range.");
            }
            else
            {
                Console.WriteLine($"{userNumber} is not in the range.");
            }
        }
        
        // 2. Write a method that displays the multiplication table (from 1 to 12) for a given integer.
        //    - Method Signature: void DisplayMultiplicationTable(int number)
        //    - Should print each line in the format: "1 * number = result"
        public static void DisplayMultiplicationTable(int num)
        {
            for(int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{i} x {num} = {i * num}");
            }
        }

        // In the Main method below, call each of your methods to test them.
        // Use various test cases to ensure they work as expected.        
        static void Main(string[] args)
        {
            //PrintNumbers1000();
            //PrintEveryThirdNumber();
            //AreNumbersEqual (1, 2);
            //IsEven(47);
            //IsPositive(-844);
            //CanVote();
            //IsInRange();
            DisplayMultiplicationTable(12);
        }
    }
}
