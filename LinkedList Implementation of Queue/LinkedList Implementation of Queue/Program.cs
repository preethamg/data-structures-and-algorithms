using System;

namespace LinkedList_Implementation_of_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Queue queue = new Queue();
                while (true)
                {
                    Console.WriteLine("Please Select one of the options");
                    Console.WriteLine("1: Enque Data");
                    Console.WriteLine("2: Deque Data");
                    Console.WriteLine("3: Peek Data");
                    Console.WriteLine("4: Print Data in Queue");
                    int input = Convert.ToInt32(Console.ReadLine());
                    if (input < 0 || input > 4)
                    {
                        Console.WriteLine("Please Choose Proper Input");
                    }
                    else
                    {
                        switch (input)
                        {
                            case 1:
                                Console.WriteLine("Please Enter Data to be enqued");
                                int data = Convert.ToInt32(Console.ReadLine());
                                queue.Enque(data);
                                break;

                            case 2:
                                int deque = queue.Deque();
                                if (deque != -1)
                                {
                                    Console.WriteLine("{0} is dequed from queue",deque);
                                    Console.WriteLine();
                                }
                                break;

                            case 3:
                                int peak = queue.Peek();
                                if (peak != -1)
                                {
                                    Console.WriteLine(peak);
                                    Console.WriteLine();
                                }
                                break;

                            case 4:
                                queue.Print();
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

    public class Node
    {
        public int Data;
        public Node Link;
    }

    public class Queue
    {
        public static Node Front;
        public static Node Rear;

        public Node GetNode(int data)
        {
            Node temp = new Node();
            temp.Data = data;
            temp.Link = null;
            return temp;
        }

        public void Enque(int data)
        {
            try
            {
                Node temp = GetNode(data);
                if (Front == null && Rear == null)
                {
                    Front = Rear = temp;
                }
                else
                {
                    Rear.Link = temp;
                    Rear = temp;
                    Console.WriteLine("Data Enqued");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public int Deque()
        {
            int data = -1;
            try
            {
                if (Front == null && Rear == null)
                {
                    Console.WriteLine("Queue Empty !!!");
                }
                else if (Front == Rear)
                {
                    data = Front.Data;
                    Front = Rear = null;
                }
                else
                {
                    data = Front.Data;
                    Front = Front.Link;
                }
                return data;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return data;
            }
        }

        public int Peek()
        {
            int data = -1;
            try
            {
                if (Front == null && Rear == null)
                {
                    Console.WriteLine("Queue Empty !!!");
                }
                else
                {
                    data = Front.Data;
                }
                return data;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return data;
            }
        }

        public void Print()
        {
            try
            {
                if (Front == null && Rear == null)
                {
                    Console.WriteLine("Queue Empty !!!");
                }
                else
                {
                    Node temp = Front;
                    while (temp != null)
                    {
                        Console.Write(temp.Data + " ");
                        temp = temp.Link;
                    }
                    Console.WriteLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
