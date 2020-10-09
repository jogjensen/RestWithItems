using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using ModelLib;

namespace RestItemService.DButil
{
    public class ManageItem
    {
        private const String connectionString = "Data Source=itemsdbs.database.windows.net;Initial Catalog=ItemsDB;User ID=user1;Password=********;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        private const String GET_ALL = "select * from Items";

        public IEnumerable<Item> Get()
        {
            List<Item> liste = new List<Item>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(GET_ALL, conn))
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Item item = ReadNextElement(reader);
                    liste.Add(item);
                }
                reader.Close();
            }

            return liste;
        }

        private Item ReadNextElement(SqlDataReader reader)
        {
            Item item = new Item();

            item.Id = reader.GetInt32(0);
            item.Name = reader.GetString(1);
            item.Quality = reader.GetString(2);
            item.Quantity = reader.GetInt32(3);

            return item;

        }
    }
}
