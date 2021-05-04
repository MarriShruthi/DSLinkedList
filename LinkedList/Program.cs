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
           // list.InsertLast(56);
           // list.InsertLast(30);
           // list.InsertLast(70);

           // list.InsertFront(70); // Adding data in list //UC2
           // list.InsertFront(30);// Adding data in list //UC2
           // list.InsertFront(56);

            //list.Appending(56);// Adding data in list //UC3
            //list.Appending(30);// Adding data in list //UC3
            //list.Appending(70);

            list.InsertFront(70); // Adding data in list //UC4            
            list.InsertFront(56); // Adding data in list //UC4
            list.InsertAtParticularPosition(2, 30);//UC4
            list.Display();

            Console.ReadLine();
        }
    }
}
