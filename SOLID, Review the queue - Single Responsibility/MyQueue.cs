using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID__Review_the_queue___Single_Responsibility
{
    public class MyQueue<T>
    {
        public T[] array = new T[10];
        public int firstElement;
    }
}
