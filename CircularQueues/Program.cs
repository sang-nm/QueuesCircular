using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularQueues
{
    class Queues
    {
        public static int Max = 5;
        public int[] arr = new int[Max];
        public int Front, Rear;
        public Queues()
        {
            Front = Rear = -1;
        }

        public void insert(int item)
        {
            if ((Front == 0 && Rear == Max - 1) || (Front == Rear + 1))
            {
                Console.WriteLine("Full slot");
                return;
            }
            if (Front == -1)
            {
                Front = 0;
                Rear = 0;
            }
            else
            {
                if (Rear == Max - 1)
                {
                    Rear = 0;
                }
                else
                {
                    Rear = Rear + 1;
                }
            }
            arr[Rear] = item;
            Console.Clear();
        }

        public void delete()
        {
            if (Front == -1)
            {
                Console.WriteLine("Empty slot");
                return;
            }
            Console.WriteLine("\n The element deleted from the queue is: " + arr[Front] + "\n");
            if (Front == Rear) 
            {
                Front = -1;
                Rear = -1;
            }
            else
            {
                if (Front == Max - 1)
                {
                    Front = 0;
                }
                else
                {
                    Front = Front + 1;
                }
            }
        }

        public void display()
        {
            int Front_pos = Front;
            int Rear_pos = Rear;
            if (Front == -1)
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            Console.WriteLine("\n Elements in the queue are:\n");
            if (Front_pos <= Rear_pos) 
            {
                while (Front_pos <= Rear_pos)
                {
                    Console.WriteLine(arr[Front_pos] + " ");
                    Front_pos++;
                }
                Console.WriteLine();
            }
            else
            {
                while (Front_pos <= Max - 1)
                {
                    Console.WriteLine(arr[Front_pos] + " ");
                    Front_pos++;
                }
                Front_pos = 0;
                while (Front_pos <= Rear)
                {
                    Console.WriteLine(arr[Front_pos] + " ");
                    Front_pos++;
                }
                Console.WriteLine();
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Queues Q = new Queues();
            while (true)
            {
                try
                {
                    Console.WriteLine("Menu");
                    Console.WriteLine("1. Implement insert operation");
                    Console.WriteLine("2. Implement delete operation");
                    Console.WriteLine("3. Display values");
                    Console.WriteLine("4. Exit");
                    Console.WriteLine("\n Enter your choice (1-4): ");
                    int ch = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    switch (ch)
                    {
                        case 1:
                            {
                                Console.WriteLine("Enter a number:");
                                int num = Convert.ToInt32(Console.ReadLine());
                                Q.insert(num);
                            }
                            break;
                        case 2:
                            {
                                Q.delete();
                            }
                            break;
                        case 3:
                            {
                                Q.display();
                            }
                            break;
                        case 4:
                            return;
                        default:
                            {
                                Console.WriteLine("Invalid option!!");
                            }
                            break;
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Check for the values entered.");
                }
                Console.WriteLine();
            }
        }
    }
}
