using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BalticMarinasBuySellWS.Models
{
    public class SoldItemContext
    {
        public string ConnectionString { get; set; }

        public SoldItemContext(string connectionString)
        {
            this.ConnectionString = connectionString;
        }

        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }

        public List<SoldItem> GetAllSoldItems()
        {
            List<SoldItem> list = new List<SoldItem>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("select * from sold_items", conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new SoldItem()
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Name = reader["name"].ToString(),
                            Type = reader["type"].ToString(),
                            Price = Convert.ToInt32(reader["price"]),
                            Year = reader["year"].ToString(),
                            Description = reader["description"].ToString(),
                            Sold = Convert.ToInt32(reader["sold"])
                        });
                    }
                }
            }
            return list;
        }
    }
}
