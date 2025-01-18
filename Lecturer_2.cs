using System.Text;

namespace ConsoleApp1
{
    internal class Lecturer_2
    {
        public static void two_dim_array()
        {
            int[,] matrix2 = new int[1, 2];
            matrix2[0, 1] = 100;
            Console.WriteLine(matrix2[0, 1]);

            int[,] matrix = { { 1, 2, 3 }, { 3, 4, 5 }, { 5, 6, 3 } };
            Console.WriteLine(matrix[1, 2]);

            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[] { 1, 2, 3 };
            jaggedArray[1] = new int[] { 4, 5 };
            jaggedArray[2] = new int[] { 6, 7, 8, 44, 100 };

            Console.WriteLine(jaggedArray[1][0]);
        }

        public static void string_manipulation()
        {
            string name = "     Jareer Umar Alvi_     ";

            //name = string.Concat("1", "2", "3", "4", "5");
            Console.WriteLine(name);

            string firstName = "John";
            string lastName = "Doe";

            //name = $"{firstName} {lastName}";
            Console.WriteLine(name);

            Console.WriteLine(name.ToLower());

            Console.WriteLine(name.IndexOf(" "));

            Console.WriteLine(name.Substring(name.IndexOf(" ") + 1));

            Console.WriteLine(name.Substring(0, name.IndexOf(" ")));

            //Console.Write(name.LastIndexOf(" "));

            string strMiddleName = name.Substring(name.IndexOf(" ") + 1);

            Console.WriteLine(strMiddleName.Substring(0, strMiddleName.IndexOf(" ")));

            name = name.Replace("Alv", "Alvi");
            Console.WriteLine(name);

            string[] studentName = name.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine(studentName.Length);

            Console.WriteLine(studentName[0]);
            Console.WriteLine(studentName[1]);
            Console.WriteLine(studentName[2]);

            name = name.Trim();
            Console.WriteLine(name);

            name = name.Trim(new char[] { '_', '*', ',', '/' });
            Console.WriteLine(name);

            StringBuilder html = new StringBuilder("fafa fafadf dfafa");
            html.Append("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
            html.Append("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");

            Console.WriteLine(html.ToString());
        }
    }
}
