using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
    class Program
    {
        
        static void Main(string[] args)
        {

            Message message = new Message();
            message.Log("Hi");
            message.Log("How");
            message.Log("are");
            message.Log("you");
        }

       
    }
}
