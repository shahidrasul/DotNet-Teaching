namespace ConsoleApp12
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
        case6:
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
                        else Console.WriteLine($"{firstNumber} / {secondNumber} = {(N1) / secondNumber}");
                        break;
                    case "5":
                        goto case6;
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

        public static void RunTasks()
        {
            bool flag = true;
            while (flag)
            {
                Console.Clear();
                Console.WriteLine("2nd Assignment Tasks\n1.Calculator\n2.Second Larget Number in an Array\n3.Find Prime Number\n4.Exit");
                Console.Write("Enter Choice: ");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Calculator();
                        break;
                    case "2":
                        FindSecondLargestNumber();
                        break;
                    case "3":
                        Console.Clear();
                        int number = GetInputAndValidate("a");
                        if (FindPrime(number))
                        {
                            Console.WriteLine($"{number} is a Prime Number");
                        }
                        else
                            Console.WriteLine($"{number} is not a Prime Number");
                        Console.WriteLine("Press Any Key To Continue");
                        Console.ReadKey(true);
                        break;
                    case "4":
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Option. Press Any Key Try Again!");
                        Console.ReadKey(true);
                        break;
                }
            }
        }
    }
}