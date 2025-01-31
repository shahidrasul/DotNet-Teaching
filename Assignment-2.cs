using System.Text;

namespace ConsoleApp1
{
    internal class Assignment_2
    {
        static public int GetInputAndValidate(string message)
        {
            do
            {
                Console.Write(message);

                string n1str = Console.ReadLine();
                if (!int.TryParse(n1str, out int inupt))
                {
                    Console.WriteLine("Invaild Number Try Again!");
                }
                return inupt;
            } while (true);
        }

        public static void Calculator()
        {
            Console.Clear();
            int firstNumber = GetInputAndValidate("Enter Frist Number: ");
            int secondNumber = GetInputAndValidate("Enter Second Number: ");

            do
            {
                Console.Clear();
                Console.Write("1.Add\n2.Subtract\n3.Multiply\n4.Divide\n5.Enter New Numbers\n6.Exit\n");
                Console.Write("Enter Choice: ");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}");
                        break;
                    case "2":
                        Console.WriteLine($"{firstNumber} - {secondNumber} = {firstNumber - secondNumber}");
                        break;
                    case "3":
                        Console.WriteLine($"{firstNumber} x {secondNumber} = {firstNumber * secondNumber}");
                        break;
                    case "4":
                        float N1 = firstNumber;
                        if (secondNumber == 0)
                        {
                            Console.WriteLine("Division Not Possible!");
                        }
                        else Console.WriteLine($"{firstNumber} / {secondNumber} = {(N1) / 0}");
                        break;
                    case "5":
                        Console.Clear();
                        firstNumber = GetInputAndValidate("Enter Frist Number: ");
                        secondNumber = GetInputAndValidate("Enter Second Number: ");
                        break;
                    case "6":
                        return;
                    default:
                        Console.WriteLine("Invalid Option. Press Any Key Try Again!");
                        Console.ReadKey(true);
                        continue;
                }

                Console.WriteLine("Press Any Key To Continue");
                Console.ReadKey(true);
            } while (true);
        }

        public static void FindSecondLargestNumber()
        {
            int length = GetInputAndValidate("Enter the Length of your Array: ");
            int[] arr = new int[length];
            for (int i = 0; i < length; i++)
            {
                arr[i] = GetInputAndValidate($"Enter input of Number {i + 1}: ");
            }

            //var sortedNumbers = arr.OrderByDescending(x => x).ToArray();
            //Console.WriteLine($"Second Largest Number is: {sortedNumbers[1]} ");

            int largestNumber = arr[0];
            int secondLargetNumber = largestNumber;
            for (int i = 1; i < length; i++)
            {
                if (arr[i] > largestNumber)
                {
                    secondLargetNumber = largestNumber;
                    largestNumber = arr[i];
                }
            }

            Console.WriteLine($"Second Largest Number is: {secondLargetNumber} ");
            Console.WriteLine("Press Any Key To Continue");
            Console.ReadKey(true);
        }

        public static bool FindPrime(int number)
        {
            if (number <= 1)
            {
                return false;
            }
            else
            {
                for (int i = 3; i < number; i += 2)
                {
                    if (number % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
        }

        //public static int GetFactorial(int number)
        //{
        //    int result = 1;
        //    for (int i = number; i >= 1; i--)
        //    {
        //        result = result * i;
        //    }
        //    return result;
        //}

        public static int GetFactorial(int number)
        {
            if (number <= 1)
                return number;
            return number * GetFactorial(number - 1);
        }

        public static void FibonacciSeries(int index)
        {
            int firstValue = 0;
            int secondValue = 0;
            int fibonacciValue = 0;

            for (int i = 0; i < index; i++)
            {
                if (i == 1)
                    firstValue = i; //for the first increament in fibonacci series 

                fibonacciValue = firstValue + secondValue;
                Console.WriteLine(fibonacciValue);
                firstValue = secondValue; //to keep a track of previous value of the previous value
                secondValue = fibonacciValue; //to keep the track of previous value
            }
        }

        public static void FibonacciSeriesRecurssive(int index, int firstValue = 0, int secondValue = 1, int currentIndex = 0)
        {
            if (currentIndex >= index) //To  break out of the function when given index is reached
            {
                return;
            }

            Console.WriteLine(firstValue);
            // replacing first value with second and second value  with the fibonacci number and incresing the current index
            FibonacciSeriesRecurssive(index, secondValue, firstValue + secondValue, currentIndex + 1);
        }


        public static string ReverseString(string originalString)
        {
            StringBuilder reversedString = new StringBuilder();
            for (int i = originalString.Length - 1; i >= 0; i--) //i is for iteration and thus assigned the length of original String
            {
                reversedString.Append(originalString[i]);

            }
            return reversedString.ToString();

        }

        public static void ReverseStringRecurssive(string originalString, int currentIndex, string reversedString = "")
        {
            if (currentIndex < 0)//the condition was not set <= due to the fact that strings start from index 0
            {
                Console.WriteLine(reversedString);
                return;
            }
            reversedString += originalString[currentIndex];

            ReverseStringRecurssive(originalString, currentIndex - 1, reversedString);
        }

        public static void RunTasks()
        {
            bool flag = true;
            while (flag)
            {
                Console.Clear();
                Console.WriteLine("Assignment Tasks Menu");
                Console.WriteLine("1. Fibonacci Series (Iterative)");
                Console.WriteLine("2. Fibonacci Series (Recursive)");
                Console.WriteLine("3. Reverse String");
                Console.WriteLine("4. Reverse String (Recursive)");
                Console.WriteLine("5. Calculator");
                Console.WriteLine("6. Exit");
                Console.Write("Enter Choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Clear();

                        int index = GetInputAndValidate("Enter the number of terms for Fibonacci Series: ");
                        FibonacciSeries(index);
                        Console.WriteLine("Press Any Key To Continue");
                        Console.ReadKey(true);
                        break;

                    case "2":
                        Console.Clear();
                        index = GetInputAndValidate("Enter the number of terms for Fibonacci Series  (Recursive): ");
                        FibonacciSeriesRecurssive(index);
                        Console.WriteLine("Press Any Key To Continue");
                        Console.ReadKey(true);
                        break;

                    case "3":
                        Console.Clear();
                        Console.Write("Enter string to reverse: ");
                        string str = Console.ReadLine();
                        Console.WriteLine($"Reversed String: {ReverseString(str)}");
                        Console.WriteLine("Press Any Key To Continue");
                        Console.ReadKey(true);
                        break;

                    case "4":
                        Console.Clear();
                        Console.Write("Enter string to reverse recursively: ");
                        str = Console.ReadLine();
                        ReverseStringRecurssive(str, str.Length - 1);
                        Console.WriteLine("Press Any Key To Continue");
                        Console.ReadKey(true);
                        break;
                    case "5":
                        Console.Clear();
                        Calculator();
                        break;
                    case "6":
                        flag = false;
                        break;

                    default:
                        Console.WriteLine("Invalid Option. Press Any Key to Try Again!");
                        Console.ReadKey(true);
                        break;
                }
            }
        }
    }
}