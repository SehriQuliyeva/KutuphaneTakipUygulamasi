using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;


namespace KutuphaneTakipUygulamasi
{
    public static class SqlCon
    {
        readonly static string connectionString = ("DATA SOURCE= DESKTOP-47AVJA4\\SQLEXPRESS;INITIAL CATALOG = DBKUtuphaneProject; INTEGRATED SECURITY = TRUE");
        public static SqlConnection Connect()
        {
            return new SqlConnection(connectionString);
        }
    }
}
