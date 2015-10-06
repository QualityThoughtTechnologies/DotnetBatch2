using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo
{
    interface IQTContainer<T> 
    {
        T GetItem(int index);

        void SetItem(int index, T item);

        int MaxSize { set; get; }
    }
}
