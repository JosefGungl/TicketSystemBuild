using System;
using System.IO;
using System.Linq;
using NLog.Web;

namespace TicketSystemBuild
{
    class Program
    {
         private static NLog.Logger logger = NLogBuilder.ConfigureNLog(Directory.GetCurrentDirectory() + "\\nlog.config").GetCurrentClassLogger();

        static void Main(string[] args)
        {
            logger.Info("Program started");

            string ticketType = "";

            do{
                Console.WriteLine("Select Ticket type/action");
                Console.WriteLine("1) Bug/Defect");
                Console.WriteLine("2) Enhancement");
                Console.WriteLine("3) Task");
                Console.WriteLine("4) Search Tickets");
                Console.WriteLine("Enter any other key to exit.");
                ticketType = Console.ReadLine();

                string choice = "";

                if (ticketType == "1")
                {
                    string ticketFilePath = Directory.GetCurrentDirectory() + "\\Tickets.csv";
                    TicketFile ticketFile = new TicketFile(ticketFilePath);
                    do
                    {
                        // ask user a question
                        Console.WriteLine("1) Display Bug/Defect Tickets.");
                        Console.WriteLine("2) Add ticket.");
                        Console.WriteLine("Enter any other key to exit.");
                        // input response
                        choice = Console.ReadLine();

                        if (choice == "1")
                        {
                            foreach(Ticket ticket in ticketFile.Tickets){
                                Console.WriteLine(ticket.Display());
                            }
                        }
                        else if (choice == "2")
                        {
                            Ticket ticket = new Ticket();
                            int ticketID = ticketFile.Tickets.Count +1;
                            Console.WriteLine("TicketID: "+ticketID);
                            Console.Write("Enter a short Summary: ");
                            ticket.summary = Console.ReadLine();
                            Console.Write("Enter status: ");
                            ticket.status = Console.ReadLine();
                            Console.Write("Enter priority: ");
                            ticket.priority = Console.ReadLine();
                            Console.Write("Enter submitter: ");
                            ticket.submitter = Console.ReadLine();
                            Console.Write("Enter assigned person: ");
                            ticket.assigned = Console.ReadLine();
                            Console.Write("Enter the person watching: ");
                            ticket.watching = Console.ReadLine();
                            Console.Write("Enter severity: ");
                            ticket.severity = Console.ReadLine();

                            ticketFile.AddTicket(ticket);
                        }
                    } while (choice == "1" || choice == "2");
                } else if (ticketType == "2"){
                    string ticketFilePath = Directory.GetCurrentDirectory() + "\\Enhancements.csv";
                    EnhancementFile enhancementFile = new EnhancementFile(ticketFilePath);
                    do{
                        // ask user a question
                        Console.WriteLine("1) Display Enhancement Tickets.");
                        Console.WriteLine("2) Add Enhancement Ticket.");
                        Console.WriteLine("Enter any other key to exit.");
                        // input response
                        choice = Console.ReadLine();

                        if (choice == "1")
                        {
                            foreach(Enhancement enhancement in enhancementFile.Enhancements){
                                Console.WriteLine(enhancement.Display());
                            }
                        }
                        else if (choice == "2")
                        {
                            Enhancement enhancement = new Enhancement();

                            int ticketId = enhancementFile.Enhancements.Count + 1;
                            Console.WriteLine("Ticket ID: "+ticketId);
                            Console.Write("Enter a short Summary: ");
                            enhancement.summary = Console.ReadLine();
                            Console.Write("Enter status: ");
                            enhancement.status = Console.ReadLine();
                            Console.Write("Enter priority: ");
                            enhancement.priority = Console.ReadLine();
                            Console.Write("Enter submitter: ");
                            enhancement.submitter = Console.ReadLine();
                            Console.Write("Enter assigned person: ");
                            enhancement.assigned = Console.ReadLine();
                            Console.Write("Enter the person watching: ");
                            enhancement.watching = Console.ReadLine();
                            Console.Write("Enter the software: ");
                            enhancement.software = Console.ReadLine();
                            Console.Write("Enter cost: ");
                            enhancement.cost = Console.ReadLine();
                            Console.Write("Enter reason: ");
                            enhancement.reason = Console.ReadLine();
                            Console.Write("Enter estimate: ");
                            enhancement.estimate = Console.ReadLine();

                            enhancementFile.AddEnhancement(enhancement);
                        }
                    } while (choice == "1" || choice == "2");
                } else if (ticketType == "3"){
                    string ticketFilePath = Directory.GetCurrentDirectory() + "\\Task.csv";
                    TaskFile taskFile = new TaskFile(ticketFilePath);
                    do{
                        // ask user a question
                        Console.WriteLine("1) Display Task Tickets.");
                        Console.WriteLine("2) Add Task Ticket.");
                        Console.WriteLine("Enter any other key to exit.");
                        // input response
                        choice = Console.ReadLine();

                        if (choice == "1")
                        {
                            foreach(Task task in taskFile.Tasks){
                                Console.WriteLine(task.Display());
                            }
                        }
                        else if (choice == "2")
                        {
                            Task task = new Task();

                            int ticketId = taskFile.Tasks.Count + 1;
                            Console.WriteLine("Ticket ID: "+ticketId);
                            Console.Write("Enter a short Summary: ");
                            task.summary = Console.ReadLine();
                            Console.Write("Enter status: ");
                            task.status = Console.ReadLine();
                            Console.Write("Enter priority: ");
                            task.priority = Console.ReadLine();
                            Console.Write("Enter submitter: ");
                            task.submitter = Console.ReadLine();
                            Console.Write("Enter assigned person: ");
                            task.assigned = Console.ReadLine();
                            Console.Write("Enter the person watching: ");
                            task.watching = Console.ReadLine();
                            Console.Write("Enter project name: ");
                            task.projectName = Console.ReadLine();
                            Console.Write("Enter due date (M/D/Y): ");
                            task.dueDate = DateTime.Parse(Console.ReadLine());

                            taskFile.AddTask(task);
                        }
                    } while (choice == "1" || choice == "2");
                } else if (ticketType == "4"){
                    Search search = new Search();
                    do{
                        Console.WriteLine("Select what to search by");
                        Console.WriteLine("1. Status");
                        Console.WriteLine("2. Priority");
                        Console.WriteLine("3. Submitter");
                        Console.WriteLine("Enter any other key to exit.");
                        choice = Console.ReadLine();
                        if(choice == "1"){
                            Console.Write("Search Status: ");
                            var input = Console.ReadLine();
                            Console.WriteLine(search.StatusSearch(input));
                        } else if (choice == "2"){
                            Console.Write("Search Priority: ");
                            var input = Console.ReadLine();
                            Console.WriteLine(search.PrioritySearch(input));
                        }else if (choice == "3"){
                            Console.Write("Search Submitter: ");
                            var input = Console.ReadLine();
                            Console.WriteLine(search.SubmitterSearch(input));
                        }
                    }while(choice == "1" || choice == "2" || choice == "3");
                }
            } while (ticketType == "1" || ticketType == "2" || ticketType == "3" || ticketType == "4");
            logger.Info("Program ended");
        }
    }
}
