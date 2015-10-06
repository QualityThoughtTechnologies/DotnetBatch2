using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
    class Message
    {

        
        MessageConsole messageConsole;
        public Message()
        {
            messageConsole = //new MessageConsole(LogMessage);
                //anonymous method syntax
                delegate(string message)
                {
                    Console.WriteLine("{0}---->{1}", DateTime.Now, message);
                };
             messageConsole += Console.WriteLine;
        }
        public void Log(string mesage)
        {
            messageConsole(mesage);

        }

        public delegate void MessageConsole(string s);
        void LogMessage(string message)
        {
            Console.WriteLine("{0}---->{1}", DateTime.Now, message);
        }
    }
}
