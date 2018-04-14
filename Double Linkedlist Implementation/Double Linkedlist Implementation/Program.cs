using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Double_Linkedlist_Implementation
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                DoubleLinkedlist doubleLinkedlist = new DoubleLinkedlist();
                while (true)
                {
                    Console.WriteLine();
                    Console.WriteLine("Please Select Following Option");
                    Console.WriteLine("1: Insert Node At Head");
                    Console.WriteLine("2: Insert Node At Tail");
                    Console.WriteLine("3: Print Data In LinkedList");
                    Console.WriteLine("4: Print Data In LinkedList in Reverse Order");
                    Console.WriteLine("5: Print LinkedList Length");
                    int input = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    if (input>0 && input <5)
                    {
                        switch (input)
                        {
                            case 1:
                                Console.WriteLine("Please Enter the data to be inserted");
                                doubleLinkedlist.InsertAtHead(int.Parse(Console.ReadLine()));
                                break;
                            case 2:
                                Console.WriteLine("Please Enter the data to be inserted");
                                doubleLinkedlist.InsertAtEnd(int.Parse(Console.ReadLine()));
                                break;
                            case 3:
                                doubleLinkedlist.PrintData();
                                Console.WriteLine();
                                break;
                            case 4:
                                doubleLinkedlist.PrintReverse();
                                Console.WriteLine();
                                break;
                            case 5:
                                Console.WriteLine(doubleLinkedlist.LinkedListLength());
                                break;
                        } 
                    }
                    else
                    {
                        Console.WriteLine("Please select proper value");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
         
        }
    }
    class Node
    {
        public int Data;
        public Node Next;
        public Node Previous;
    }

    class DoubleLinkedlist
    {
        public static Node Head;
        public static int count;

        public DoubleLinkedlist()
        {
            count = 0;
        }

        public Node GetNode(int data)
        {
            Node temp = new Node();
            try
            {
                temp.Data = data;
                temp.Next = null;
                temp.Previous = null;
                return temp;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return temp;
            }
 
        }

        public void InsertAtHead(int data)
        {
            try
            {
                Node newNode = GetNode(data);
                if (Head == null)
                {
                    Head = newNode;
                }
                else
                {
                    newNode.Next = Head;
                    Head.Previous = newNode;
                    Head = newNode;
                }
                count++;
                Console.WriteLine("Node Inserted");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void InsertAtEnd(int data)
        {
            try
            {
                Node newNode = GetNode(data);
                if (Head == null)
                {
                    Head = newNode;
                }
                else
                {
                    Node temp = Head;
                    while (temp.Next != null)
                    {
                        temp = temp.Next;
                    }
                    temp.Next = newNode;
                    newNode.Previous = temp;
                }
                count++;
                Console.WriteLine("Node Inserted");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void PrintData()
        {
            try
            {
                if (Head == null)
                {
                    Console.WriteLine("Double LinkedList Empty!!!");
                }
                else
                {
                    Node temp = Head;
                    while (temp != null)
                    {
                        Console.Write(temp.Data + " ");
                        temp = temp.Next;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void PrintReverse()
        {
            try
            {
                if (Head == null)
                {
                    Console.WriteLine("Double LinkedList Empty!!!");
                }
                else
                {
                    Node temp = Head;
                    while (temp.Next != null)
                    {
                        temp = temp.Next;
                    }
                    while (temp != null)
                    {
                        Console.Write(temp.Data + " ");
                        temp = temp.Previous;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public int LinkedListLength()
        {
            return count;
        }
    }
}
