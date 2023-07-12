using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID__Review_the_queue___Single_Responsibility
{
    public class FuncPeek<T> : MyQueue<T>
    {
        public T Peek()
        {
            if (firstElement == -1)
            {
                throw new InvalidOperationException();
            }
            return array[firstElement];
        }
    }
}
