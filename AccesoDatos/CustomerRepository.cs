using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class CustomerRepository
    {
        public DataTable ObtenerTodos()
        {
            DataTable datatable = new DataTable();
            String selectAll = "";
            selectAll = selectAll + "SELECT [CustomerID] " + "\n";
            selectAll = selectAll + "      ,[CompanyName] " + "\n";
            selectAll = selectAll + "      ,[ContactName] " + "\n";
            selectAll = selectAll + "      ,[ContactTitle] " + "\n";
            selectAll = selectAll + "      ,[Address] " + "\n";
            selectAll = selectAll + "      ,[City] " + "\n";
            selectAll = selectAll + "      ,[Region] " + "\n";
            selectAll = selectAll + "      ,[PostalCode] " + "\n";
            selectAll = selectAll + "      ,[Country] " + "\n";
            selectAll = selectAll + "      ,[Phone] " + "\n";
            selectAll = selectAll + "      ,[Fax] " + "\n";
            selectAll = selectAll + "  FROM [dbo].[Customers]";


            

            SqlDataAdapter adapter = new SqlDataAdapter(selectAll, DataBase.ConnectionString);
            adapter.Fill(datatable);
            return datatable;
        }


        public Customer ObtenerPorId(string Id)
        {
            
            using (var conexion = DataBase.GetSqlConnection())
            {
                var dataTable = new DataTable();
                String selectPorId = "";
                selectPorId = selectPorId + "SELECT [CustomerID] " + "\n";
                selectPorId = selectPorId + "      ,[CompanyName] " + "\n";
                selectPorId = selectPorId + "      ,[ContactName] " + "\n";
                selectPorId = selectPorId + "      ,[ContactTitle] " + "\n";
                selectPorId = selectPorId + "      ,[Address] " + "\n";
                selectPorId = selectPorId + "      ,[City] " + "\n";
                selectPorId = selectPorId + "      ,[Region] " + "\n";
                selectPorId = selectPorId + "      ,[PostalCode] " + "\n";
                selectPorId = selectPorId + "      ,[Country] " + "\n";
                selectPorId = selectPorId + "      ,[Phone] " + "\n";
                selectPorId = selectPorId + "      ,[Fax] " + "\n";
                selectPorId = selectPorId + "  FROM [dbo].[Customers] " + "\n";
                selectPorId = selectPorId + "  WHERE CustomerID = @CustomerID";
                using (SqlCommand comando = new SqlCommand(selectPorId, conexion))
                {
                    comando.Parameters.AddWithValue("@CustomerID", Id);
                    SqlDataAdapter adapter = new SqlDataAdapter(comando);
                    adapter.Fill(dataTable);
                    var cliente = ExtraerInformacionCliente(dataTable);
                    return cliente;
                }
            }
        }



        public Customer ExtraerInformacionCliente(DataTable table)
        {
            Customer customer = new Customer();
            foreach (DataRow fila in table.Rows)
            {
                customer.CustomerID = fila.Field<String>("CustomerID");
                customer.CompanyName = fila.Field<String>("CompanyName");
                customer.ContactName = fila.Field<String>("ContactName");
                customer.ContactTitle = fila.Field<String>("ContactTitle");
                customer.Address = fila.Field<String>("Address");
                customer.City = fila.Field<String>("City");
                customer.Region = fila.Field<String>("Region");
                customer.PostalCode = fila.Field<String>("PostalCode");
                customer.Country = fila.Field<String>("Country");
                customer.Phone = fila.Field<String>("Phone");
                customer.Fax = fila.Field<String>("Fax");
            }
            return customer;
        }


        public int InsertarCliente(Customer cliente)
        {
            using (var conexion = DataBase.GetSqlConnection())
            {
                string insertIntoPorId = "";
                insertIntoPorId = insertIntoPorId + "INSERT INTO [dbo].[Customers] " + "\n";
                insertIntoPorId = insertIntoPorId + "           ([CustomerID] " + "\n";
                insertIntoPorId = insertIntoPorId + "           ,[CompanyName] " + "\n";
                insertIntoPorId = insertIntoPorId + "           ,[ContactName] " + "\n";
                insertIntoPorId = insertIntoPorId + "           ,[ContactTitle] " + "\n";
                insertIntoPorId = insertIntoPorId + "           ,[Address]) " + "\n";
                insertIntoPorId = insertIntoPorId + "     VALUES " + "\n";
                insertIntoPorId = insertIntoPorId + "           (@CustomerID " + "\n";
                insertIntoPorId = insertIntoPorId + "           ,@CompanyName " + "\n";
                insertIntoPorId = insertIntoPorId + "           ,@ContactName " + "\n";
                insertIntoPorId = insertIntoPorId + "           ,@ContactTitle " + "\n";
                insertIntoPorId = insertIntoPorId + "           ,@Address)";

                conexion.Open();
                using (var commando = new SqlCommand(insertIntoPorId, conexion))
                {
                    commando.Parameters.AddWithValue("@CustomerID", cliente.CustomerID);
                    commando.Parameters.AddWithValue("@CompanyName", cliente.CompanyName);
                    commando.Parameters.AddWithValue("@ContactName", cliente.ContactName);
                    commando.Parameters.AddWithValue("@ContactTitle", cliente.ContactTitle);
                    commando.Parameters.AddWithValue("@Address", cliente.Address);
                    SqlDataAdapter adaptador = new SqlDataAdapter(commando);
                    adaptador.InsertCommand = commando;
                    return adaptador.InsertCommand.ExecuteNonQuery();
                }
            }
        }



    }
}
