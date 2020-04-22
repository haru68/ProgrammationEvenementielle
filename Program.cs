using System;

namespace ProgrammationEvenementielle
{
    class Program
    {
        static void Main(string[] args)
        {
            while(Console.ReadKey().Key == ConsoleKey.Enter)
            {
                Publisher publisher = new Publisher();
                publisher.Run();
                if(Console.ReadKey().Key == ConsoleKey.D)
                {
                    FileOutputLogger.DeleteFile();
                }
            }

        }
    }
}
