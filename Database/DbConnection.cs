using Microsoft.Extensions.Configuration;
using System.IO;

namespace DBConnection {
    public class Connection {
        public static string configuration {
            get {
                var config = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json")
                    .Build();
                
                return config.GetConnectionString("DefaultConnection");
            }
        }
    }
}