using System;
using System.Data.SqlClient;

namespace SQLDB_Test
{
    public class SqlGateway
    {
        string[] getSqlData()
        {
            //using (SqlConnection sconn = new SqlConnection()) { }
            return new string[] { "FAILURE", "FAILURE", "FAILURE", "FAILURE", "FAILURE", "FAILURE", "FAILURE" };
        }

        bool setSqlData(string name, string absoulteid, string hash, string salt, DateTime created,
            DateTime lastlogin)
        {
            return false;
        }
    }
}