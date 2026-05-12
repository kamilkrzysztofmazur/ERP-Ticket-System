using System;
using DBConnection;
using ERP_Ticket_System.Models;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;

namespace ERP_Ticket_System.Services
{
    public class TicketService
    {

        public void AddTicket(Ticket ticket)
        {

            using (SqlConnection connection = new SqlConnection(Connection.configuration))
                {
                string query = "INSERT INTO Ticket (Title, Description, Status) VALUES (@Title, @Description, @Status)";

                using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@Title", ticket.Title);
                        command.Parameters.AddWithValue("@Description", ticket.Description);
                        command.Parameters.AddWithValue("@Status", ticket.Status);

                        connection.Open();

                        command.ExecuteNonQuery();
                    
                        connection.Close();
                    }
                }
        }
        public List<Ticket> GetAllTickets()
            {
            List<Ticket> tickets = new List<Ticket>();

            string query = "SELECT id, Title, Description, Status FROM Ticket";
            
            using (SqlConnection connection = new SqlConnection(Connection.configuration))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                        {
                        using(SqlDataReader reader = command.ExecuteReader())
                            {
                            while (reader.Read())
                                {
                                int id = reader.GetInt32(0);
                                string title = reader.GetString(1);
                                string description = reader.GetString(2);
                                string status = reader.GetString(3);

                                Ticket ticket = new Ticket(id, title,description, status);
                                
                                tickets.Add(ticket);

                                }
                            }
                        }
                }
            return tickets;
            }
    }

}