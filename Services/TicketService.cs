using System;
using DBConnection;
using ERP_Ticket_System.Models;
using Microsoft.Data.SqlClient;

namespace ERP_Ticket_System.Services{
    public class TicketService{
        
        public void AddTicket(Ticket ticket){

            SqlConnection connection = new SqlConnection(Connection.configuration);
            
            string query = "INSERT INTO Ticket (Title, Description, Status) VALUES (@Title, @Description, @Status)";
                            
            using (SqlCommand command = new SqlCommand(query, connection)){

                command.Parameters.AddWithValue("@Title",ticket.Title);
                command.Parameters.AddWithValue("@Description",ticket.Description);
                command.Parameters.AddWithValue("@Status", ticket.Status);
                
                connection.Open();

                command.ExecuteNonQuery();
            }
            connection.Close();
        }
    }

}