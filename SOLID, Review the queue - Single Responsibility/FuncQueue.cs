using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID__Review_the_queue___Single_Responsibility
{
    public class FuncQueue<T> : MyQueue<T>
    {
        public void Queue(T value)
        {
            if (firstElement == array.Length - 1)
            {
                throw new StackOverflowException();
            }
            array[++firstElement] = value;
        }
    }
}
