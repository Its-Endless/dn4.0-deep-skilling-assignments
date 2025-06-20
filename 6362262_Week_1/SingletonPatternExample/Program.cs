using System;

namespace SingletonPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing Logger Singleton...\n");

            Logger logger1 = Logger.GetInstance();
            logger1.Log("This is the first log message.");

            Logger logger2 = Logger.GetInstance();
            logger2.Log("This is the second log message.");

            if (logger1 == logger2)
            {
                Console.WriteLine("\nLogger is a Singleton: Both instances are the same.");
            }
            else
            {
                Console.WriteLine("\nLogger is NOT a Singleton: Instances are different.");
            }

            Console.ReadLine();
        }
    }
}
