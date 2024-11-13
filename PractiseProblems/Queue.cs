using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseProblems
{
    internal class Queue
    {
        public int[] Quueue;
        private int size = 0;
        private int Index { get; set; }
        public Queue()
        {
            Quueue = new int[size];
            Index = -1;
        }

        private void IncreseSize()
        {
            if( size == 0 )
            {
                Index++;
            }
            size++;
            Quueue = new int[size];
        }
        public void Enqueue(int item)
        {
            IncreseSize();
            Quueue[size - 1] = item;
            
        }
        private void DecreaseSize()
        {
            Index++;

        }
        public void Dequeue()
        {
            DecreaseSize();
        }

        public int Peek()
        {
            return Quueue[Index];
        }

        public int Size()
        {
            return size - Index;
        }

    }
}
