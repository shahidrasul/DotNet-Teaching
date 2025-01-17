namespace ConsoleApp1
{
    internal class Assignment_1
    {
        public static void Task_1()
        {
            //task 1
            int age = 0;

            Console.Write("Enter Your Name: ");
            string name = Console.ReadLine();

            do
            {
                Console.Write("Enter Your Age: ");
                string strAge = Console.ReadLine();

                if (!int.TryParse(strAge, out age))
                {
                    Console.WriteLine($"Invalid Age, Try again!");
                }
                else break;
            } while (true);

            if (age >= 18)
                Console.WriteLine($"{name} is eligible for voting");
            else
                Console.WriteLine($"{name} is not eligible for voting");

            Console.ReadKey(true);
        }

        public static void Task_2()
        {
            //task 2
            int SubjectArrLngth = 0;

            do
            {
                Console.Write("Enter the number of subjects: ");
                string strLength = Console.ReadLine();

                if (!int.TryParse(strLength, out SubjectArrLngth))
                {
                    Console.WriteLine("Invalid subject number. Try Again!");
                }
                else break;
            } while (true);

            int count = 1;
            float sum = 0;
            float sum2 = 0;
            for (int i = 0; i < SubjectArrLngth; i++)
            {
                do
                {
                    Console.Write($"Enter marks for subject no.{count}: ");
                    string strSubject = Console.ReadLine();

                    if (!float.TryParse(strSubject, out sum2))
                    {
                        Console.WriteLine("Invalid Marks. Try Again!");
                    }
                    else break;

                } while (true);

                sum += sum2;
                ++count;
            }

            Console.WriteLine($"Your Average Marks are: {sum / SubjectArrLngth}");
        }

        public static void Assignment()
        {
            //task 1
            int age = 0;

            Console.Write("Enter Your Name: ");
            string name = Console.ReadLine();

            do
            {
                Console.Write("Enter Your Age: ");
                string strAge = Console.ReadLine();

                if (!int.TryParse(strAge, out age))
                {
                    Console.WriteLine($"Invalid Age, Try again!");
                }
                else break;
            } while (true);

            if (age >= 18)
                Console.WriteLine($"{name} is eligible for voting");
            else
                Console.WriteLine($"{name} is not eligible for voting");

            //switch (age)
            //{
            //    case 10:
            //    case 11:
            //        Console.WriteLine($"{name} is not eligible for voting");
            //        break;
            //    case < 18:
            //        Console.WriteLine($"{name} is not eligible for voting");
            //        break;
            //}

            //task 2

            //Console.WriteLine("Enter the number of subjects: ");
            //int SubjectArrLngth = int.Parse(Console.ReadLine());
            ////int[] subjects = new int[SubjectArrLngth];
            //int count = 1;
            //float sum = 0;

            //for (int i = 0; i < SubjectArrLngth; i++)
            //{
            //    Console.Write($"Enter marks for subject no.{count}: ");
            //    sum += float.Parse(Console.ReadLine());
            //    //sum += subjects[i];
            //    ++count;
            //}

            //Console.WriteLine($"Your Average Marks are: {sum / SubjectArrLngth}");

            Console.ReadKey(true);
        }

        public static int Add(int value1, int value2)
        {
            int result = value1 + value2;
            return result;
        }

        public static bool IsEventOrOdd(int value)
        {
            return (value %= 2) == 0;
        }

        public static int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        /*public static int factorial(int number)
        {
            if (number <= 1)
                return 1;
            return number * factorial(number - 1);
        }*/
    }
}
