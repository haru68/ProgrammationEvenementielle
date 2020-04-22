using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammationEvenementielle
{
    public class ConsoleOutputLogger : OutputLogger
    {
        public override void Write(String message, DateTime? dateTime = null)
        {
            if (dateTime == null)
            {
                dateTime = DateTime.Now;
            }
            String formattedMessage = String.Format($"{dateTime} - {message}");
            Console.WriteLine(formattedMessage);
        }
    }
}
