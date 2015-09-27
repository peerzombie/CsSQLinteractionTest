using System;
using System.Windows.Forms;

namespace SQLDB_Test
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void main_Load(object sender, EventArgs e)
        {
            SqlGateway sqlGateway = new SqlGateway();
            sqlGateway.getSqlData();
        }
    }
}