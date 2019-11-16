using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanliBanHang.DAO
{
    public class DataProvider
    {
        private string connectionSTR = @"Data Source=LAPTOP-7RRV7AH5;Initial Catalog=PhanMemQuanLyBanHangSBTC;Integrated Security=True";

        public static object Instance { get; internal set; }

        public DataTable ExcuteQuery(string query)
        {
            DataTable data = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionSTR))

            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(data);
            
                connection.Close();
                }

            return data;
        }


    }
}
