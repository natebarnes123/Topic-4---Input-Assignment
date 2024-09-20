namespace Topic_4___Input_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Part1();

            Part2();

            //Part3();
        }

        public static void Part2()
        {
            string name, login;
            int ID, grade;
           
           
            double average;
            Console.WriteLine("Hello, what is your full name?");
            name = Console.ReadLine();
            Console.WriteLine("What is your grade?");
            grade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What's your student ID?");
            ID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What's your login?");
            login = Console.ReadLine();
            Console.WriteLine("What is your average?");
            double.TryParse(Console.ReadLine(), out average);
            Console.WriteLine("Nice! " + average + "% Is pretty good");
        }


        public static void Part1()
        {
            string name;
            int age;
            double money;
            Console.WriteLine("Hello, what is your name?");
            name = Console.ReadLine();
            Console.WriteLine("Nice to meet you, " + name + ", How old are you?");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("So you're " + age + " eh? Thats not old at all! How much do you make " + name + "?");
            double.TryParse(Console.ReadLine(), out money);
            Console.WriteLine(money.ToString("C") + "! I hope thats per hour and not per year");
        }




        public static void Part3()
        {
            string name;
            int age;
            Console.WriteLine("Hello. What is your name?");
            name = Console.ReadLine();
            Console.WriteLine("Hey " + name + " How old are you?");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Did you know that in five years you will be " + (age + 5) + " years old? And five years ago you were " + (age - 5) + "! Imagine that!");
        }
    }
}
