﻿using BalticMarinasBuySellWS.Utilities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

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
                MySqlCommand cmd = new MySqlCommand(Queries.GetAllSoldItems, conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new SoldItem()
                        {
                            SoldItemId = Convert.ToInt32(reader["SoldItemId"]),
                            Title = reader["Title"].ToString(),
                            Category = reader["Category"].ToString(),
                            Price = Convert.ToDecimal(reader["Price"]),
                            MadeYear = reader["MadeYear"].ToString(),
                            Description = reader["Description"].ToString(),
                            UserId = Convert.ToInt32(reader["UserId"])
                        });
                    }
                }
            }
            return list;
        }

        public SoldItem GetSoldItemById(int id)
        {
            var soldItemById = new SoldItem();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(Queries.GetSoldItemById, conn);
                cmd.Parameters.Add("@id", MySqlDbType.Int16).Value = id;

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        soldItemById.SoldItemId = Convert.ToInt32(reader["SoldItemId"]);
                        soldItemById.Title = reader["Title"].ToString();
                        soldItemById.Category = reader["Category"].ToString();
                        soldItemById.Price = Convert.ToDecimal(reader["Price"]);
                        soldItemById.MadeYear = reader["MadeYear"].ToString();
                        soldItemById.Description = reader["Description"].ToString();
                        soldItemById.UserId = Convert.ToInt32(reader["UserId"]);
                    }
                }
            }
            return soldItemById;
        }
    }
}
