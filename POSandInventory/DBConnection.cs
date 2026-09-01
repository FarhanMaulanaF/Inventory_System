using System;
using System.Collections.Generic;
using System.Text;

namespace POSandInventory
{
    internal class DBConnection
    {
        public string MyConnection()
        {
            string con = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=POS_DEMO_DB;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
            return con;
        }
    }
}
