using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_Implementation
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                LinkedList linkedList = new LinkedList();
                do
                {
                    Console.WriteLine("Please Select following options");
                    Console.WriteLine("1:Insert data at head");
                    Console.WriteLine("2:Insert data at end");
                    Console.WriteLine("3:Insert data at Nth Position");
                    Console.WriteLine("4:Print Length of LinkedList");
                    Console.WriteLine("5:Delete node at Nth Position");
                    Console.WriteLine("6:Print Linkedlist data");
                    Console.WriteLine("7:Print Linkedlist data in reverse order");
                    Console.WriteLine("8:Reverse Linked List in iteratively");
                    Console.WriteLine("9:Reverse Linked List in recursively");
                    int input = int.Parse(Console.ReadLine());
                    switch (input)
                    {
                        case 1:
                            Console.WriteLine("Please Enter Linkedlist content");
                            int content1 = int.Parse(Console.ReadLine());
                            linkedList.InsertAtHead(content1);
                            break;
                        case 2:
                            Console.WriteLine("Please Enter Linkedlist content");
                            int content2 = int.Parse(Console.ReadLine());
                            linkedList.InsertAtEnd(content2);
                            break;
                        case 3:
                            Console.WriteLine("Please Enter the position and data to be inserted");
                            int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                            if (arr[0] < 1 || arr[0] > linkedList.ReturnCounter() + 1)
                            {
                                Console.WriteLine("Please Enter a proper position to insert node");
                                Console.WriteLine();
                            }
                            else
                            {
                                linkedList.InsertAtNthPosition(arr[0], arr[1]);
                            }
                            break;
                        case 4:
                            Console.WriteLine(linkedList.ReturnCounter());
                            break;
                        case 5:
                            Console.WriteLine("Please Enter the position of node to be deleted");
                            int pos = int.Parse(Console.ReadLine());
                            if (pos < 0 || pos > linkedList.ReturnCounter())
                            {
                                Console.WriteLine("Please Enter a valid position to delete");
                                Console.WriteLine();
                            }
                            else
                            {
                                linkedList.DeleteNode(pos);
                            }
                            break;
                        case 6:
                            Console.WriteLine();
                            linkedList.PrintData();
                            Console.WriteLine();
                            break;
                        case 7:
                            Console.WriteLine();
                            linkedList.PrintReverse(LinkedList.Head);
                            Console.WriteLine();
                            break;
                        case 8:
                            linkedList.ReverseIterative();
                            linkedList.PrintData();
                            break;
                        case 9:
                            Console.WriteLine();
                            linkedList.ReverseRecursive(LinkedList.Head);
                            linkedList.PrintData();
                            break;
                    }
                    // Console.WriteLine("Do you want to continue please press y and enter");
                } while (true); //while (Console.ReadLine().ToLower() == "y");

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
    }
    class LinkedList
    {
        public static Node Head;
        public static int count;

        public LinkedList()
        {
            count = 0;
        }

        public Node GetNode(int data)
        {

            Node newNode = new Node();
            newNode.Data = data;
            newNode.Next = null;
            return newNode;
        }

        public void InsertAtHead(int data)
        {
            try
            {
                if (Head == null)
                {
                    Head = GetNode(data);
                    count++;
                }
                else
                {
                    Node temp = GetNode(data);
                    temp.Next = Head;
                    Head = temp;
                    count++;
                }
                Console.WriteLine("Data inserted");
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
                if (Head == null)
                {
                    Head = GetNode(data);
                    count++;
                }
                else
                {
                    Node temp = Head;
                    while (temp.Next != null)
                    {
                        temp = temp.Next;
                    }
                    temp.Next = GetNode(data);
                    count++;
                }
                Console.WriteLine("Data inserted");
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
                    Console.WriteLine("LinkedList Empty");
                }
                else
                {
                    Node temp = Head;
                    while (temp.Next != null)
                    {
                        Console.Write(temp.Data + "-->");
                        temp = temp.Next;
                    }
                    Console.Write(temp.Data + "-->null");
                    Console.WriteLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void InsertAtNthPosition(int position, int data)
        {
            try
            {
                if (Head == null)
                {
                    if (position > 1)
                    {
                        Console.WriteLine("Head Node is null hence inserting at head node");
                        Head = GetNode(data);
                        count++;
                    }
                }
                else
                {

                    if (position == 1)
                    {
                        InsertAtHead(data);
                        count++;
                    }
                    else
                    {
                        Node newNode = GetNode(data);
                        Node temp = Head;
                        for (int i = 0; i < position - 2; i++)
                        {
                            temp = temp.Next;
                        }
                        newNode.Next = temp.Next;
                        temp.Next = newNode;
                        count++;
                    }
                }
                Console.WriteLine("Data inserted at {0}th position", position);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public int ReturnCounter()
        {
            return count;
        }

        public void DeleteNode(int position)
        {
            if (Head == null)
            {
                Console.WriteLine("Linked List Empty");
            }
            else
            {
                if (position == 1)
                {
                    Head = Head.Next;
                    count--;
                }
                else
                {
                    Node temp = Head;
                    for (int i = 0; i < position - 2; i++)
                    {
                        temp = temp.Next;
                    }
                    temp.Next = temp.Next.Next;
                    count--;
                }
                Console.WriteLine("Node deleted at {0}th position", position);
            }
        }

        public void PrintReverse(Node node)
        {
            if (Head == null)
            {
                Console.WriteLine("Linked List Empty");
            }
            else
            {
                if (node != null)
                {
                    PrintReverse(node.Next);
                    Console.Write(node.Data + "-->");
                }
            }
        }

        public void ReverseIterative()
        {
            if (Head == null)
            {
                Console.WriteLine("Linked List Empty");
            }
            else
            {
                Node current, previous=null, next=null;
                current = Head;
                while (current != null)
                {
                    next = current.Next;
                    current.Next = previous;
                    previous = current;
                    current = next;
                }
                Head = previous;
            }
        }

        public void ReverseRecursive(Node p)
        {
            if (Head == null)
            {
                Console.WriteLine("Linked List Empty");
            }
            else
            {
                if (p.Next == null)
                {
                    Head = p;
                    return;
                }
                ReverseRecursive(p.Next);
                Node q = p.Next;
                q.Next = p;
                p.Next = null;
            }
        }
    }
}
