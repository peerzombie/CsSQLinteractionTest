using System;
using cryptography;
namespace SQLDB_Test
{
    public class SqlGateway
    {
        crypt c = new crypt(1);

        private string[] getSqlData()
        {
            //using (SqlConnection sconn = new SqlConnection()) { }
            
            return new[] {"FAILURE", "FAILURE", "FAILURE", "FAILURE", "FAILURE", "FAILURE", "FAILURE"};
        }

        private bool setSqlData(string name, string absoulteid, string hash, string salt, DateTime created,
            DateTime lastlogin)
        {
            return false;
        }
    }
}