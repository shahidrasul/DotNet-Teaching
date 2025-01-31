namespace ConsoleApp1
{
    internal class PracticeTasks
    {
        public static void CreateAndWriteInFile()
        {
            Console.Write("Enter the name of your File: ");
            string filename = Console.ReadLine();
            filename = filename + ".txt";

            try
            {
                if (File.Exists(filename))
                {
                    throw new FileNotFoundException("File already  Exists");
                }
                File.Create(filename).Close();

                Console.Write("Enter some data in your file:");
                string data = Console.ReadLine();
                using (StreamWriter writer = new StreamWriter(filename))
                {
                    writer.WriteLine(data);
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine($"An Error Occured: {ex.Message}");

            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine($"An Error Occured: {ex.Message}");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"An Error Occured: {ex.Message}");

            }
        }

        public static void ReadContentOfFile()
        {

            Console.Write("Enter the name of the File to be Read:");

            string filename = Console.ReadLine();
            filename += ".txt";
            try
            {
                if (File.Exists(filename))
                {
                    // Read the content of the file using StreamReader
                    using (StreamReader reader = new StreamReader(filename))
                    {
                        string content = reader.ReadToEnd();


                        if (string.IsNullOrEmpty(content))
                        {
                            Console.WriteLine("The file is empty.");
                        }
                        else
                        {
                            Console.WriteLine(content);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("The specified file does not exist.");
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine($"An Error Occured: {ex.Message}");
            }

            catch (Exception ex)
            {
                Console.WriteLine($"An Error Occured: {ex.Message}");
            }

        }



        public static void AppendTextToFile()
        {
            Console.Write("Enter the name of the File in which text is to be appended: ");
            string filename = Console.ReadLine() + ".txt";

            try
            {
                if (File.Exists(filename))
                {
                    Console.Write("Enter the text to be Appended: ");
                    string content = Console.ReadLine();

                    string textToAppend = $"{content} (Appended on {DateTime.Now}){Environment.NewLine}";

                    File.AppendAllText(filename, textToAppend);
                }
                else
                {
                    Console.WriteLine("The specified file does not exist.");
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine($"The File is Locked or Inaccessible");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
            }
        }
        public static void FileCopy()
        {
            try
            {
                Console.Write("Enter the name of the File to be copied: ");
                string source_file = Console.ReadLine() + ".txt";
                if (!File.Exists(source_file))
                {
                    throw new FileNotFoundException("Source File Does Not Exists");
                }

                Console.Write("Enter the name of the new File: ");
                string dstination_file = Console.ReadLine() + ".txt";
                if (File.Exists(dstination_file))
                {
                    throw new IOException("Destination File Already Exists");
                }
                File.Copy(source_file, dstination_file);
                Console.WriteLine("File Copied SuccessFully!");


            }
            catch (Exception ex)
            {
                Console.WriteLine("Eroror: " + ex.Message);
            }

        }
        public static void DeleteFile()
        {
            Console.Write("Enter the name of the File to be deleted: ");
            string file = Console.ReadLine() + ".txt";
            try
            {
                if (!File.Exists(file))
                {
                    throw new FileNotFoundException("File Not Found!");
                }
                File.Delete(file);
                Console.WriteLine("File Deleted SuccessFully!");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine($"Error: Unauthorized access to the file. {ex.Message}");
            }
            catch (IOException ex)
            {
                Console.WriteLine($"The File is Locked or Inaccessible");

            }
        }

        public static void Main1()
        {
            bool exit = false;

            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("File Operations Menu:");
                Console.WriteLine("1. Create and Write to a File");
                Console.WriteLine("2. Read Content of a File");
                Console.WriteLine("3. Append Text to a File");
                Console.WriteLine("4. Copy a File");
                Console.WriteLine("5. Delete a File");
                Console.WriteLine("6. Exit");
                Console.Write("Please choose an option (1-6): ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Clear();
                        CreateAndWriteInFile();
                        break;
                    case "2":
                        Console.Clear();
                        ReadContentOfFile();
                        break;
                    case "3":
                        Console.Clear();
                        AppendTextToFile();
                        break;
                    case "4":
                        Console.Clear();
                        FileCopy();
                        break;
                    case "5":
                        Console.Clear();
                        DeleteFile();
                        break;
                    case "6":
                        Console.WriteLine("Exiting...");
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please choose between 1 and 6.");
                        break;
                }

                // Wait for user to press Enter before showing the menu again
                if (!exit)
                {
                    Console.WriteLine("\nPress Enter to return to the menu...");
                    Console.ReadLine();
                }
            }
        }
    }
}
