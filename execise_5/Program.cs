using System;

namespace CircularQueues_CSharp
{
    class Queues
    {
        int Hilmy, Naufal, max = 5;
        int[] queue_array = new int[5];
        public Queues()
        {
            Hilmy = -1;
            Naufal = -1;
        }
        public void insert(int element)
        {
            if ((Hilmy == 0 && Naufal == max - 1) || (Hilmy == Naufal + 1))
            {
                Console.WriteLine("\nQueue overflow\n");
                return;
            }
            if (Hilmy == -1)
            {
                Hilmy = 0;
                Naufal = 0;
            }
            else
            {
                if (Naufal == max - 1)
                    Naufal = 0;
                else
                    Naufal = Naufal + 1;
            }
            queue_array[Naufal] = element;
        }
        public void remove()
        {
            if (Hilmy == -1)
            {
                Console.WriteLine("Queue underflow\n");
                return;
            }
            Console.WriteLine("\nThe element deleted from the queue is: " + queue_array[Hilmy] + "\n");
            if (Hilmy == Naufal)
            {
                Hilmy = -1;
                Naufal = -1;
            }
            else
            {
                if (Hilmy == max - 1)
                    Hilmy = 0;
                else
                    Hilmy = Hilmy + 1;
            }
        }
        public void display()
        {
            int FRONT_positition = Hilmy;
            int REAR_positition = Naufal;

            if (Hilmy == -1)
            {
                Console.WriteLine("Queue is empty\n");
                return;
            }
            Console.WriteLine("\nElements in the queue are........\n");
            if (FRONT_positition <= REAR_positition)
            {
                while (FRONT_positition <= REAR_positition)
                {
                    Console.WriteLine(queue_array[FRONT_positition] + "   ");
                    FRONT_positition++;
                }
                Console.WriteLine();
            }
            else
            {
                while (FRONT_positition <= max - 1)
                {
                    Console.WriteLine(queue_array[FRONT_positition] + "   ");
                    FRONT_positition++;
                }
                FRONT_positition = 0;
                while (FRONT_positition <= REAR_positition)
                {
                    Console.Write(queue_array[FRONT_positition] + "   ");
                    FRONT_positition++;
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Queues q = new Queues();
            char ch;
            while (true)
            {
                try
                {
                    Console.WriteLine("Menu ");
                    Console.WriteLine("1. Implement insert operation");
                    Console.WriteLine("1. Implement delete operation");
                    Console.WriteLine("3. Display values ");
                    Console.WriteLine("4. Exit");
                    Console.WriteLine("\n Enter your choice (1-4): ");
                    ch = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine();
                    switch (ch)
                    {
                        case '1':
                            {
                                Console.WriteLine("\nMasukkan Huruf : ");
                                int num = Convert.ToInt32(Console.ReadLine());
                                string num_str = num.ToString();
                                Console.WriteLine();
                                q.insert(num);
                            }
                            break;
                        case '2':
                            {
                                q.remove();
                            }
                            break;
                        case '3':
                            {
                                q.display();
                            }
                            break;
                        case '4':
                            return;
                        default:
                            {
                                Console.WriteLine("Invalid option!!");
                            }
                            break;
                    }
                }
                catch (Exception )
                {
                    Console.WriteLine("Check for the values entered.");
                }
            }
        }
    }
}