using System;
using System.Windows.Forms;
using cryptography;
using SQLDB_Test.dbDataSetTableAdapters;

namespace SQLDB_Test
{
    public class SqlGateway
    {
        crypt c = new crypt(1);

        public string[] getSqlData()
        {
            //using (SqlConnection sconn = new SqlConnection()) { }
            mtblTableAdapter tableAdapter = new mtblTableAdapter();
            dbDataSet.mtblDataTable table = new dbDataSet.mtblDataTable();
            tableAdapter.Fill(table);
            //MessageBox.Show(DateTime.Now + "\n" + DateTime.Now + 10, "TDATA");
            return new[] {"FAILURE", "FAILURE", "FAILURE", "FAILURE", "FAILURE", "FAILURE", "FAILURE"};
        }

        private bool setSqlData(string name, string absoulteid, string hash, string salt, DateTime created,
            DateTime lastlogin)
        {
            return false;
        }
    }
}