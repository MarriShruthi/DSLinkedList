﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class LinkedListNode
    {
        public Node head;
        public void InsertLast(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
                this.head = node;
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into the linked list", node.data);
        }

        public void InsertFront(int new_data)
        {
            Node new_node = new Node(new_data);//create new node then new node point to the head of the linked list
            new_node.next = this.head;// add any node at the front point head 
            this.head = new_node; // The Previous Head is now the second node of linked List the new node is added at the
            Console.WriteLine($"Inserted into front {new_node.data}"); //print

        }

        public void Appending(int value)
        {
            InsertLast(value);
        }

        public Node InsertAtParticularPosition(int position, int data)
        {
            if (position < 1)
            {
                Console.WriteLine($"Invalid Position{ position}");
            }
            if (position == 1)
            {
                var newNode = new Node(data); //create object and passing data
                newNode.next = this.head;
                head = newNode;
            }
            else
            {
                while (position-- != 0)
                {
                    if (position == 1)
                    {
                        Node node = new Node(data);
                        node.next = this.head.next;
                        head.next = node;
                        break;
                    }
                    head = head.next;
                }
                if (position != 1)
                {
                    Console.WriteLine($"Position Out Of Range{ position}");
                }
            }
            return head;
        }

        public void DeleteFirstNode()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked List is Empty");
                return;
            }
            head = temp.next;
            Console.WriteLine($"Successfully Delete First Element {temp.data}");

        }

        public void DeleteLastNode()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked List is Empty");
                return;
            }
            else
            {
                while (temp.next.next != null)
                {
                    temp = temp.next;
                }

                Console.WriteLine($"Successfully Delete Last Element {temp.next.data}");
                temp.next = null;
            }

        }

        public int Search(int value)
        {
            int count = 0;
            Node temp = this.head;
            while (temp != null)
            {
                if (temp.data == value)
                {
                    Console.WriteLine($"{value} Searching Element Present in Linked List");
                    return count;
                }

                temp = temp.next;
                count++;
            }
            Console.WriteLine($"{value} Element Not Found in Linked List");
            return count;
        }

        public void InsertAtAfterValue(int after, int data)
        {

            if (head == null)
            {
                Console.WriteLine("Linked list is Empty");
            }
            else
            {
                Node temp = head;

                while (temp != null)
                {
                    if (temp.data == after)
                    {
                        Node node = new Node(data);
                        node.next = temp.next;
                        temp.next = node;
                        break;
                    }
                    temp = temp.next;
                }
                Console.WriteLine($"Successfully added Element {after} After {data}");


            }
        }

        internal void Display()
        {
             Node temp = this.head;
             if (temp == null)
             {
                  Console.WriteLine("Linked list is empty");
                  return;
             }
             while (temp != null)
             {
                 Console.Write(temp.data + " ");
                 temp = temp.next; //temp=null
             }
                Console.WriteLine();
            }

    }
}
