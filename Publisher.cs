using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammationEvenementielle
{
    public class Publisher
    {
        public event EventHandler<SendLogEventArgs> OnSendLog;

        public void Run()
        {
            var fileLogger = new FileOutputLogger();
            var standardLogger = new ConsoleOutputLogger();
            fileLogger.Subscribe(this);
            standardLogger.Subscribe(this);
            var eventArgs = new SendLogEventArgs("LogEvent published", DateTime.Now);
            if(this.OnSendLog != null)
            {
                this.OnSendLog(this, eventArgs);
            }
        }
    }
}
