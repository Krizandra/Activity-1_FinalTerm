using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.IO;

namespace Activity_1_FinalTerm
{
    public static class Database
    {
        public static readonly String DBpath = Path.GetFullPath(
                Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\InventoryManagementSystem.accdb")
            );

        private static readonly string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + DBpath + ";Persist Security Info=False;";

        public static OleDbConnection GetConnection()
        {
            return new OleDbConnection(connectionString);
        }
    }
}
