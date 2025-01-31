namespace ConsoleApp1
{
    internal class Assignment_3
    {
        public static int StringVowelCounter(string input)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

            int counter = 0;
            string Input = input.ToLower();//Storing the original string with lower case to avoid multiple uppercase cheks too
            for (int i = 0; i < Input.Length; i++)
            {
                if (vowels.Contains(Input[i])) //Checking if the vowels array contains the char at this particular index of Input
                    counter++;
            }
            return counter;
        }

        public static bool AnagramChecker(string Input1, string Input2)
        {
            //Triming from extra spaces and replacing spaces with empty inputs to avoid lengthv issues because of the sapaces in between
            string input1 = Input1.Replace(" ", "").Trim();
            string input2 = Input2.Replace(" ", "").Trim();
            if (input1.Length != input2.Length) //if the length doesnt matches we can quit at this point avoid unecessary iterations
                return false;
            for (int i = 0; i < input1.Length; i++)
            {
                if (!input2.Contains(input1[i])) //if 2nd string doesnt contains a particular char of string 1 we can simply return false
                    return false;
            }

            return true;
        }

        public static void RunTasks()
        {
            bool flag = true;
            while (flag)
            {
                Console.Clear();
                Console.WriteLine("Assignment Tasks Menu");
                Console.WriteLine("1.Vowels Counter");
                Console.WriteLine("2.Anagram Checker");
                Console.Write("Enter Choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Clear();

                        Console.Write("Enter the string of whom's vowels are to be counted: ");
                        string input = Console.ReadLine();
                        Console.WriteLine($"The number of vowels in your string are {StringVowelCounter(input)}");
                        Console.WriteLine("Press Any Key To Continue");
                        Console.ReadKey(true);
                        break;

                    case "2":
                        Console.Clear();
                        ; Console.Write("Enter the string number 1: ");
                        string string1 = Console.ReadLine();
                        ; Console.Write("Enter the string number 2: ");
                        string string2 = Console.ReadLine();
                        if (AnagramChecker(string1, string2))
                        {
                            Console.WriteLine($"\"{string1}\" and \"{string2}\" are anagrams");
                        }
                        else
                        {
                            Console.WriteLine($"\"{string1}\" and \"{string2}\" are not anagrams");

                        }
                        Console.WriteLine("Press Any Key To Continue");
                        Console.ReadKey(true);
                        break;

                    default:
                        Console.WriteLine("Invalid Option. Press Any Key to Try Again!");
                        Console.ReadKey(true);
                        break;
                }
            }

            Console.ReadKey(true);
        }
    }
}
