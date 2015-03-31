using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequenceList
{
    class Program
    {
        static void Main(string[] args)
        {
            //IntSqListTest();
            StrSqListTest();
        }

        private static void IntSqListTest()
        {
            SequenceList<int> intSqList = new SequenceList<int>(10);
            for (int i = 1; i <= 10; i++)
            {
                intSqList.Append(i * 2);
            }
            intSqList.Print();
            Console.WriteLine("元素3的位置是{0}", intSqList.Locate(3));
            Console.WriteLine("元素8的位置是{0}", intSqList.Locate(8));
            intSqList.InsertElem(3, 99);
            Console.WriteLine("第7个元素的值是{0}", intSqList.GetElem(7));
            int deletedElem = intSqList.DeleteElem(7);
            Console.WriteLine("已删除第7个元素——{0}", deletedElem);
            intSqList.Print();
            Console.WriteLine("现在顺序表的长度是{0}", intSqList.GetLength());
            intSqList.InsertElem(6, 99);
            intSqList.Print();
            intSqList.Reverse();
            Console.WriteLine("反转后的顺序表：");
            intSqList.Print();
            Console.ReadLine();
        }

        private static void StrSqListTest()
        {
            SequenceList<string> strSqList = new SequenceList<string>(6);
            strSqList.Append("a");
            strSqList.Append("b");
            strSqList.Append("c");
            strSqList.Append("d");
            strSqList.Append("e");
            strSqList.Append("f");
            strSqList.Print();
            Console.WriteLine("元素x的位置是{0}", strSqList.Locate("x"));
            Console.WriteLine("元素e的位置是{0}", strSqList.Locate("e"));
            strSqList.InsertElem(3, "x");
            Console.WriteLine("第11个元素的值是{0}", strSqList.GetElem(11));
            Console.WriteLine("第4个元素的值是{0}", strSqList.GetElem(4));
            string deletedElem = strSqList.DeleteElem(1);
            Console.WriteLine("已删除第1个元素——{0}", deletedElem);
            strSqList.Print();
            Console.WriteLine("现在顺序表的长度是{0}", strSqList.GetLength());
            strSqList.InsertElem(3, "w");
            strSqList.Print();
            strSqList.Reverse();
            Console.WriteLine("反转后的顺序表：");
            strSqList.Print();
            Console.ReadLine();
        }
    }
}
