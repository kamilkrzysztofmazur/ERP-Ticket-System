using System;
using ERP_Ticket_System.Services;
using ERP_Ticket_System.Models;

namespace AddTicketToDB{
    class Program{
        static void Main(){
            Console.WriteLine("Podaj tytuł zgłoszenia");
            string Title = Console.ReadLine();

            Console.WriteLine("Podaj treść zgłoszenia");
            string Description = Console.ReadLine();

            Console.WriteLine("Podaj status zgłoszenia ");
            string Status = Console.ReadLine();

            TicketService service = new TicketService();

            Ticket ticket = new Ticket(Title, Description, Status);

            service.AddTicket(ticket);
        }
    }
}