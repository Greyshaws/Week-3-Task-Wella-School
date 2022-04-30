using System;

namespace Week3Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number...");
            int num = int.Parse(Console.ReadLine());
            int a = 0; // to check if the number is a prime number or not
            for(int i = 1; i <= num; i++) {
                if (num % i == 0) {
                    a++;
                }
            }
            if (a == 2) {
                Console.WriteLine("It is a prime number", a);
            } else {
                Console.WriteLine("Not a prime number");
            }
            Console.ReadLine();
        }
    }
}
