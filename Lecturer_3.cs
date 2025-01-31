using ConsoleApp2.IO.Utilities;

namespace ConsoleApp1
{
    internal class Lecturer_3
    {
        public static void exception_handling()
        {
            bool[] arr123 = new bool[2];
            arr123[0] = true;
            arr123[1] = false;

            try
            {
                Console.WriteLine("error");
                Console.WriteLine(arr123[2]);
                //error occured
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Something wrong, contact with admin.");

                //send email to developer.
                throw new InvalidOperationException("Operation is not valid 2");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Something wrong, contact with admin. gen");

                //send email to developer
                throw;
            }
            finally
            {
                //file close
                Console.WriteLine("finally");
            }

            Console.WriteLine(arr123[0]);
        }

        public static void file_handling()
        {
            Class1.Print("test");

            string filePath = "D:\\Shared\\file1.txt";
            //if (!File.Exists(filePath))
            //{
            //    //Console.WriteLine("File not exist");
            //    File.Create(filePath);
            //    //return;
            //}

            //File.Delete(filePath);

            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine("Hello, World!");
            }

            //using (StreamReader reader = new StreamReader(filePath))
            //{
            //    string line;
            //    while ((line = reader.ReadLine()) != null)
            //    {
            //        Console.WriteLine(line);
            //    }
            //}

            string text = File.ReadAllText(filePath);
            Console.WriteLine(text);

        }
    }
}
