using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Craps
{
    class Queue
    {
        private int[] items;
        private int front;
        private int rear;
        private int max;
        private int count;

        public Queue(int size)
        {
            items = new int[size];
            front = 0;
            rear = -1;
            max = size;
            count = 0;
        }

        public void Insert(int item)
        {
            if (count == max)
            {
                Delete();
            }

            rear = (rear + 1) % max;
            items[rear] = item;

            count++;
        }

        public void Delete()
        {
            front = (front + 1) % max;
            count--;
        }

        public bool CheckQ(int x)
        {
            int i = 0;
            int j = 0;
            int n = 0;

            for (i = front; j < count;)
            {
                if(items[i] == x)
                {
                    n++;
                    if (n >= 2)
                    {
                        return false;
                    }
                }

                i = (i + 1) % max;
                j++;


            }
            return true;
        }

        public void PrintQ()
        {
            int i = 0;
            int j = 0;

            for (i = front; j < count;)
            {
                Form1.q += " / " + items[i].ToString();
                i = (i + 1) % max;
                j++;

            }
        }
    }
}
