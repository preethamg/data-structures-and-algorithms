using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Implementation_of_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Queue Size");
            int size = Convert.ToInt32(Console.ReadLine());
            Queue queue = new Queue(size);
            while (true)
            {
                Console.WriteLine("Please Select one of the following options");
                Console.WriteLine("1:Enque Data to queue");
                Console.WriteLine("2:Deque Data from queue");
                Console.WriteLine("3:Peak Data from queue");
                Console.WriteLine("4:Print Data from queue");
                Console.WriteLine("5:Print queue length");
                int input = Convert.ToInt32(Console.ReadLine());
                if (input < 0 || input > 5)
                {
                    Console.WriteLine("Please Select Proper Input");
                }
                else
                {
                    switch (input)
                    {
                        case 1:
                            Console.WriteLine("Please Enter the data to Enque");
                            int data = Convert.ToInt32(Console.ReadLine());
                            queue.Enque(data);
                            break;

                        case 2:
                            int deque = queue.Deque();
                            if (deque != -1)
                            {
                                Console.WriteLine("{0} is dequed from Client", deque);
                                Console.WriteLine();
                            }
                            break;

                        case 3:
                            int peak = queue.Peek();
                            if (peak != -1)
                            {
                                Console.WriteLine("{0} is the next value to deque", peak);
                                Console.WriteLine();
                            }
                            break;

                        case 4:
                            queue.Print();
                            break;

                        case 5:
                            int count = queue.QueueCount();
                            Console.WriteLine(count);
                            Console.WriteLine();
                            break;
                    }
                }
            }
        }
    }
    class Queue
    {
        static int Queue_Size;
        static int[] queue;
        int front = -1; int rear = -1;
        static int count;

        public Queue(int size)
        {
            Queue_Size = size;
            queue = new int[Queue_Size];
            count = 0;
        }

        public void Enque(int data)
        {
            try
            {
                if (isFull())
                {
                    Console.WriteLine("Queue Overflow!!!");
                    return;
                }
                else if (isEmpty())
                {
                    front = 0; rear = 0;
                }
                else
                {
                    rear++;
                }
                queue[rear] = data;
                count++;
                Console.WriteLine("Data Enqued");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public int Deque()
        {
            int dequeval = -1;
            try
            {
                if (isEmpty())
                {
                    Console.WriteLine("Queue Empty!!!");
                    return dequeval;
                }
                if (front == rear)
                {
                    front = rear = -1;
                    count = 0;
                    Console.WriteLine("Queue Empty");
                    return dequeval;
                }
                else
                {
                    dequeval = queue[front];
                    front++;
                    count--;
                    return dequeval;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return dequeval;
            }
        }

        public int Peek()
        {
            int peek = -1;
            try
            {
                if (!isEmpty())
                {
                    peek = queue[front];
                }
                else
                {
                    Console.WriteLine("Queue Empty");
                }
                return peek;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return peek;
            }
        }

        public int QueueCount()
        {
            return count;
        }

        public void Print()
        {
            try
            {
                if (isEmpty())
                {
                    Console.WriteLine("Queue Empty!!!!");
                }
                else
                {
                    if (front < rear)
                    {
                        for (int i = front; i <= rear; i++)
                        {
                            Console.Write(queue[i] + " ");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Queue Empty!!!");
                    }
                    Console.WriteLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public bool isEmpty()
        {
            if (front == -1 && rear == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool isFull()
        {
            if (rear == Queue_Size - 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
