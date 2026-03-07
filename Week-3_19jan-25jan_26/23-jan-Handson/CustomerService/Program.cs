namespace CustomerService
{
    internal class Program
    {
        
            static void Main(string[] args)
            {
                // Queue for tickets (FIFO)
                Queue<string> ticketQueue = new Queue<string>();

                // Stack for actions (LIFO)
                Stack<string> actionStack = new Stack<string>();

                // Take number of tickets
                Console.Write("Enter number of tickets: ");
                int n = int.Parse(Console.ReadLine());

                // Take ticket details
                for (int i = 0; i < n; i++)
                {
                    Console.Write("Enter ticket ID: ");
                    string ticket = Console.ReadLine();
                    ticketQueue.Enqueue(ticket);
                }

                // Take number of tickets to process
                Console.Write("\nHow many tickets to process? ");
                int processCount = int.Parse(Console.ReadLine());

                for (int i = 0; i < processCount; i++)
                {
                    if (ticketQueue.Count > 0)
                    {
                        string currentTicket = ticketQueue.Dequeue();
                        Console.WriteLine("\nProcessing ticket: " + currentTicket);

                        Console.Write("Enter action performed: ");
                        string action = Console.ReadLine();
                        actionStack.Push(action + " on " + currentTicket);
                    }
                }

           
            if (actionStack.Count > 0)
            {
                Console.WriteLine("\nUndoing last action:");
                Console.WriteLine(actionStack.Pop());
            }
            else
            {
                Console.WriteLine("\nNo actions to undo.");
            }
                Console.WriteLine("\nRemaining tickets in queue:");
                if (ticketQueue.Count == 0)
                {
                    Console.WriteLine("No tickets remaining.");
                }
                else
                {
                    foreach (string t in ticketQueue)
                    {
                        Console.WriteLine(t);
                    }
                }
            }
        }
    }