namespace ConsoleApp1
{
    internal class collections
    {
        public static void create_collections()
        {
            int[] i = { 1, 2, 3, 4, 5 };
            //List<type>
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

            Console.WriteLine("Print");
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

            numbers.Add(6);
            numbers.Add(7);

            Console.WriteLine("Print 2");
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

            numbers.RemoveAt(0);

            Console.WriteLine("Print 3");
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

            numbers.Clear();
            numbers.ForEach(x => Console.WriteLine(x));

            numbers.AddRange(new int[] { 7, 8 });

            Console.WriteLine(numbers[0]);  // Output: 1

            //Dictionary
            Dictionary<string, int> ages = new Dictionary<string, int>();
            ages.Add("Alice", 30);
            ages.Add("Bob", 25);

            Console.WriteLine(ages["Alice"]);  // 
            if (ages.ContainsKey("Alice"))
            {
                Console.WriteLine("Alice is in the dictionary");
            }

            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Task1");
            queue.Enqueue("Task2");

            string task = queue.Dequeue();  // Removes and returns the first item
            Console.WriteLine(task);

            Stack<string> stack = new Stack<string>();
            stack.Push("First");
            stack.Push("Second");

            string topItem = stack.Pop();  // Removes and returns the last item
            Console.WriteLine(topItem);
        }
    }

    //class Car
    //{
    //    Color Color { get; set; }
    //    string Company { get; set; }
    //}

    //class Vitz : Car
    //{
    //    string Model { get; set; }
    //    String Engine { get; set; }
    //}
}
