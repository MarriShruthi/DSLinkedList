using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedListNode list = new LinkedListNode();
            //list.InsertData(56);
            //list.InsertData(30);
            // list.InsertData(70);
            //Calling InsertFront 
            list.InserFront(56);
            list.InserFront(30);
            list.InserFront(40);
            list.InserFront(70);
            list.Display();
            //list.InsertAtParticularPosition(2, 30);
            //Console.WriteLine("\nAdd after 30 : 40");
            // list.InsertAfter(3 ,40);
            //list.Search(30);
            //list.DeleteAnyData(30);
            Console.WriteLine("After Sorting");
            list.head = list.LinkedListSorted(list.head);
            list.Display();
            Console.WriteLine("Count of LinkedList" + list.Count());
            Console.ReadLine();
        }
    }
}
