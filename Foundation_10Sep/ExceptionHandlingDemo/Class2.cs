using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingDemo
{
    class Class2:IDisposable
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
