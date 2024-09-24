namespace Topic_4___Input_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Part1();

            //Part2();

            //Part3();

            Part5();
            
           //Part4();
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

        public static void Part4()
        {
            double num1, num2, num3;
            Console.WriteLine("Hey user. give me a number.");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ok, gimme another number");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Give me one more number");
            num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The sum of all these numbers is " + (num1 + num2 + num3) / 2);


        }
        public static void Part5()
        {
            double totalPrice, disPrice, subTotal, tax, price1, price2, item1, item2;
            
            
            Console.WriteLine("Hey, give me the name and price of an item you would like to purchase");
            double.TryParse(Console.ReadLine(), out item1);
            double.TryParse(Console.ReadLine(), out price1);
            Console.WriteLine("Okay, now give me another name and price of an item");
            double.TryParse(Console.ReadLine(), out item2);
            double.TryParse(Console.ReadLine(), out price2);
            Console.WriteLine("The total of these two items is " + price1 + price2.ToString());


        }

    }   


    
        
        
        
        
        
        
        
        
        
        
}
