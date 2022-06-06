using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsWithLoopsAndConditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! My name is... oh wait... I'm a computer. I don't have a name.");
            Console.WriteLine("As a computer, I've got some cool skills. I can count super fast. Watch closely or you may miss it!");
            PrintThousand();
            Console.WriteLine("Incase that didn't impress you, I can count in threes too!");
            Threes();
           
            Console.WriteLine("Let's try something else... give me a number.");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Give me a number again.");
            int b = int.Parse(Console.ReadLine());
            IsEqual(a, b);
            int c = a - b;
            Console.WriteLine($"{a} minus {b} equals {c}");
            Console.WriteLine($"Two fun facts about {c}....");
            OddEven(c);
            PositiveNumber(c);

            Console.WriteLine("I'm a computer, so I can do harder math too. Don't beleive me? Watch me multiply!");
            Multiplication();

            Console.WriteLine("I think I've proved how smart I am. But, you know what? They still don't let me vote. Crazy, huh?");
            AgeChecker();

            Console.WriteLine("Enough keeping you. I'll let you get on with your day. But first, why don't you try and read my mind.");
            Range();







            

             
            

        }

        public static void PrintThousand ()
        {
            for(int i = 1000; i >= -1000; i-- )
            {
                Console.WriteLine(i); 
            }
        }

        public static void Threes ()
        {
            for(int k = 3; k<=999; k+=3)
            {
                Console.WriteLine(k);
            }
        }

        public static bool IsEqual(int a, int b)
        {
            if (a == b)
                Console.WriteLine("You gave me the same number!");
                return true;

            if (a != b)
                Console.WriteLine("Oh good, two differnet numbers. You aren't trying to trick me.");
                return false;
               
        }

        public static void OddEven(int c)
        {
            if (c % 2 == 0)
                Console.WriteLine($" {c} is an even number");
            else
                Console.WriteLine($" {c} is an odd number");
        }

        public static void PositiveNumber(int c)
        {
            if (c >= 1)
                Console.WriteLine($" {c} positive nuber.");
            else if (c <= -1)
                Console.WriteLine($"I am positive this {c} a negative number.");
            else
                Console.WriteLine($"{c} is not negative OR positive. {c} just is.");
        }

        public static void AgeChecker()
        {
            
            Console.WriteLine("How old are you?");
            int age = int.Parse(Console.ReadLine());

            if (age < 21)
                Console.WriteLine("So they don't let you vote either... I feel a littl better. ");
            else
                Console.WriteLine("That means they let you vote! Use this power wisely.");
            
        }
        
        public static void Range()
        {
            Console.WriteLine("I'm thinking of 20 numbers... let's see if you can guess one!");
            Console.WriteLine("Type our guess.");
            int number = int.Parse(Console.ReadLine());

            if (number <= 10 && number >= -10) 
                Console.WriteLine("Congrats! You guessed right.");
            else
                Console.WriteLine("Better luck next time... That wasn't one of them.");

        }

        public static void Multiplication()
        {
            Console.WriteLine("Give me a number");
            int imput = int.Parse(Console.ReadLine());

            for (int i = imput; i <= imput * 6; i += imput)
            {
                Console.WriteLine($"{i}");
            }

        }

    }
}
