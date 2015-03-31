using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequenceList
{
    public class SequenceList<T>
    {
        private T[] data;
        private int maxSize;
        //注意lastIndex是data数组的最后一个实际元素的下标，取值是从0开始的，而SequenceList是从1开始的
        //也就是说lastIndex == -1时list才为空，list中元素对外的下标区间是1到lastIndex+1
        //而lastIndex的区间是0到maxSize-1，从lastIndex+1到maxSize-1的data数组中的值都为0
        private int lastIndex;

        public T this[int index]
        {
            get { return data[index]; }
            set { data[index] = value; }
        }

        public int MaxSize
        {
            get { return maxSize; }
            set { maxSize = value; }
        }

        public int LastIndex
        {
            get { return lastIndex; }
        }

        public SequenceList(int size)
        {
            data = new T[size];
            maxSize = size;
            lastIndex = -1;
        }

        public bool IsEmpty()
        {
            return lastIndex == -1;
        }

        public bool IsFull()
        {
            return lastIndex == maxSize - 1;
        }

        //List的实际元素区间是1~lastIndex+1
        public T GetElem(int index)
        {
            T result = default(T);
            if (IsEmpty())
            {
                Console.WriteLine("顺序表为空！");
            }
            else if (index < 1 || index > lastIndex + 1)
            {
                Console.WriteLine("获取元素位置错误！");
            }
            else
            {
                result = data[index - 1];
            }
            return result;
        }

        public void InsertElem(int index, T elem)
        {
            if (IsFull())
            {
                Console.WriteLine("顺序表已满！");
            }
            else if (index < 1 || index > lastIndex + 2)
            {
                Console.WriteLine("插入元素位置错误！");
            }
            else if (index == lastIndex + 2)
            {
                data[++lastIndex] = elem;
            }
            else
            {
                //注意index是对于list而言的，对于data数组来说是index - 1
                //即要插在list第1个实际上是插在data数组的第0个
                for (int i = lastIndex; i >= index - 1; i--)
                {
                    data[i + 1] = data[i];
                }
                data[index - 1] = elem;//同上为index - 1
                lastIndex++;
            }
        }

        public T DeleteElem(int index)
        {
            T result = default(T);
            if (IsEmpty())
            {
                Console.WriteLine("顺序表为空！");
            }
            else if (index < 1 || index > lastIndex + 1)
            {
                Console.WriteLine("删除元素位置错误！");
            }
            else if (index == lastIndex + 1)
            {
                result = data[lastIndex];
                lastIndex--;
            }
            else
            {
                result = data[index - 1];
                for (int i = index - 1; i < lastIndex; i++)
                {
                    data[i] = data[i + 1];
                }
                lastIndex--;
            }
            return result;
        }
    }
}
