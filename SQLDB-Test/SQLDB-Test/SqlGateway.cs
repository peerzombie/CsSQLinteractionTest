using System;

namespace SQLDB_Test
{
    public class SqlGateway
    {
        private string absoluteId = "48E80342-946C-4A68-8D5D-16E2BE324D38";

        private DateTime created = DateTime.Now;

        private string hash =
            "df924e16f327b7b00f723766663e830e455d1c64fac9a8203cad340c7093172c937128b21dcf3adac1d6be5ffbd765d7d1474b4a7f1c88216fe716b1a9567c4b";

        private DateTime lastLogin = DateTime.Now;
        private string name = null;

        private string salt =
            "fd346b760a1eb0da524dfdb6dc9cfbc59031cb7f741836e1b8a8c9a66438ac8c394ec9af7a09c8b96bc4d5ef60f513545f8ddddcdb2b49622b425f635baa84cb";

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