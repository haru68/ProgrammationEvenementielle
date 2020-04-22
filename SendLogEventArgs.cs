using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammationEvenementielle
{
    public class SendLogEventArgs
    {
        public String Message;
        public DateTime DateTime;

        public SendLogEventArgs(String message, DateTime dateTime)
        {
            Message = message;
            DateTime = dateTime;
        }
    }
}
