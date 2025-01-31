namespace ConsoleApp1
{
    enum Day { Sunday = 1, Monday = 4, Tuesday = 10, Wednesday, Thursday, Friday, Saturday }
    enum User { Admin, Student, Principal, Teacher, Director }

    [Flags]
    enum Permissions
    {
        None = 0,
        Read = 1,
        Write = 2,
        Execute = 4
    }

    class Lecturer_5
    {
        static string[] days = { "Friday", "Saturday" };

        public static void PrintEnum(Day today1)
        {
            Console.WriteLine(Day.Sunday);

            //Day today = Day.Saturday;
            //Console.WriteLine(today);

            DateTime today = DateTime.Now;
            if (today.DayOfWeek.ToString() == "Monday")
            {
                Console.WriteLine("Today is monday");
            }
            else if (today.DayOfWeek.ToString() == Day.Friday.ToString())
            {
                Console.WriteLine("Today is Friday");
            }

            if (today.DayOfWeek.ToString() == days[1])
            {
                Console.WriteLine("Today is monday");
            }
            else if (today.DayOfWeek.ToString() == days[0])
            {
                Console.WriteLine("Today is Friday");
            }

            int dayNumber = (int)Day.Monday;
            Console.WriteLine(dayNumber);

            Permissions userPermissions = Permissions.Read | Permissions.Write;
            Console.WriteLine(userPermissions);
        }
    }
}
