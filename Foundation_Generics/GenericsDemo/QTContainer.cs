using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo
{
    class QTContainer<T> : IQTContainer<T> 
    {
        public QTContainer()
        {
            innerList = new List<T>();
        }

        IList<T> innerList;

        public T GetItem(int index)
        {
            return innerList[index];
        }

        public void SetItem(int index, T item)
        {
            //innerList[index] = item;
            innerList.Add(item);
        }

        public int MaxSize
        {
            get;
            set;
        }
    }
}
