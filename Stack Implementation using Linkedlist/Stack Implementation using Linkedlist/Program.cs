using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Implementation_using_Linkedlist
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Stack stack = new Stack();
                while (true)
                {
                    Console.WriteLine();
                    Console.WriteLine("Please Select One of the following options");
                    Console.WriteLine("1:Push Data to stack");
                    Console.WriteLine("2:Pop data from stack");
                    Console.WriteLine("3:Peak from stack");
                    Console.WriteLine("4:Print Stack contents");
                    Console.WriteLine("5:Stack Size");
                    int input = int.Parse(Console.ReadLine());
                    if (input < 0 && input > 5)
                    {
                        Console.WriteLine("Please Select proper input");
                    }
                    else
                    {
                        switch (input)
                        {
                            case 1:
                                Console.WriteLine("Please Enter Data to be inserted");
                                int content = int.Parse(Console.ReadLine());
                                stack.Push(content);
                                break;

                            case 2:
                                int pop = stack.Pop();
                                if (pop != -1)
                                {
                                    Console.WriteLine("{0} is popped out of stack", pop);
                                }
                                break;

                            case 3:
                                int peak = stack.Peak();
                                if (peak != -1)
                                {
                                    Console.WriteLine("Top of stack contains {0}", peak);
                                }
                                break;

                            case 4:
                                stack.Print();
                                break;

                            case 5:
                                int size = stack.StackSize();
                                Console.WriteLine(size);
                                break;
                        }
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
        public Node Link;
    }
    class Stack
    {
        public static Node Head;
        public static int Count;

        public Stack()
        {
            Count = 0;
        }

        public Node GetNode(int data)
        {
            Node temp = new Node();
            temp.Data = data;
            temp.Link = null;
            return temp;
        }

        public void Push(int data)
        {
            Node newNode = GetNode(data); ;
            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                newNode.Link = Head;
                Head = newNode;
            }
            Count++;
            Console.WriteLine("Data Inserted");
        }

        public int Pop()
        {
            int popData = -1;
            if (Head == null)
            {
                Console.WriteLine("Stack Empty!!!");
            }
            else
            {
                popData = Head.Data;
                Head = Head.Link;
                Count--;
            }
            return popData;
        }

        public int StackSize()
        {
            return Count;
        }

        public int Peak()
        {
            int peak = -1;
            if (Head == null)
            {
                Console.WriteLine("Stack Empty!!!");
            }
            else
            {
                peak = Head.Data; ;
            }
            return peak;
        }

        public void Print()
        {
            if (Head == null)
            {
                Console.WriteLine("Stack Empty");
            }
            else
            {
                Node temp = Head;
                while (temp != null)
                {
                    Console.Write(temp.Data + " ");
                    temp = temp.Link;
                }
                Console.WriteLine();
            }
        }
    }
}
