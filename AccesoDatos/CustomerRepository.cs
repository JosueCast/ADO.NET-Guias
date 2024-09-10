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


    }
}
