using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
namespace Demo_CRUD.Controllers
{
    public class Dbclass
    {
        SqlConnection cnn;
        SqlCommand command;
        string query,Output="";
        SqlDataReader dataReader;
        string connectionString = "Data Source=DESKTOP-D84M7A1\\SQLEXPRESS;Initial Catalog=Practise;Integrated Security=True";
        public int insert(Bean obj)
        {
            connect();
            query = $"insert into demo values('{obj.Id}','{obj.Name}') ";
            SqlCommand cmd = new SqlCommand(query, cnn);
            int i=cmd.ExecuteNonQuery();
            disconnect();
            return i;
        }

        public List<Bean> selectAll()
        {
            connect();
            List<Bean> arr = new List<Bean>();
            query = "select * from demo";
            command = new SqlCommand(query, cnn);
            dataReader = command.ExecuteReader();
            Bean obj2 = new Bean();
            while(dataReader.Read())
            {
                arr.Add(new Bean(dataReader.GetValue(0).ToString().Trim(), dataReader.GetValue(1).ToString().Trim()));
            }
            disconnect();
            return arr;
        }

        public void connect()
        {
            cnn = new SqlConnection(connectionString);
            try
            {
                cnn.Open();
                Console.WriteLine("Connected");
            }
            catch(Exception e)
            {
                Console.WriteLine("Error: "+e);
            }
        }

        public void disconnect()
        {
            cnn.Close();
        }

    }
}