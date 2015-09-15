using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileDemo
{
    interface IConvertor<T,V>
    {
        V ConvertTo(T t);
        T ConvertFrom(V v);
    }
}
