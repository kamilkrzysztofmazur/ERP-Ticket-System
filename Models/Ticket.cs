using System;


namespace ERP_Ticket_System.Models
{
    public class Ticket
    {

        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }

        public Ticket(string Title, string Description, string Status)
        {

            this.Title = Title;
            this.Description = Description;
            this.Status = Status;
        }
        public Ticket(int Id, string Title, string Description, string Status)
        {
            this.Id = Id;
            this.Title = Title;
            this.Description = Description;
            this.Status = Status;
        }
    }
}
