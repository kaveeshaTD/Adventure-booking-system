using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace adventuresport
{
    class DBconnection
    {

        string connection = @"data source =DESKTOP-CNC0FHC ;initial Catalog =adventure  ;integrated security = true";
        
        public SqlConnection Getdbconnection()
        {
            SqlConnection newconnection = new SqlConnection(connection);
            newconnection.Open();
            return newconnection;
        }
    }
}
