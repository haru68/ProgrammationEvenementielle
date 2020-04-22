using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammationEvenementielle
{
    public class OutputLogger
    {
        public void Subscribe(Publisher publisher)
        {
            publisher.OnSendLog += OnLogSent;
        }

        public void OnLogSent(object sender, SendLogEventArgs args)
        {
            Write(args.Message, args.DateTime);
        }

        public virtual void Write(String message, DateTime? dateTime = null)
        { }
    }
}
