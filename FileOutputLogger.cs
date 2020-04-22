using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ProgrammationEvenementielle
{
    public class FileOutputLogger : OutputLogger
    {
        public override void Write(String message, DateTime? dateTime = null)
        {
            String path = @"./Logs.txt";
            List<String> formattedMessages = new List<string>() { String.Format($"{dateTime} - {message}") };
            File.AppendAllLines(path, formattedMessages);
        }

        public static void DeleteFile()
        {
            File.Delete(@"./Logs.txt");
        }
    }
}
