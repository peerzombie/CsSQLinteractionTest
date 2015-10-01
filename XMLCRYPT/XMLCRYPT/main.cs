using System;
using System.IO;
using System.Windows.Forms;
using cryptography;

namespace XMLCRYPT
{
    public partial class main : Form
    {
        private int r = 0;
        private string gateKey = "../../data/data.xml";
        private string gatePath = "../../data";
        public main()
        {
            InitializeComponent();
        }

        private void main_Load(object sender, EventArgs e)
        {
            XmlGateway xgate = new XmlGateway(gateKey);
            if (!Directory.Exists(gatePath))
            {
                Directory.CreateDirectory(gatePath);
                xgate.CreateRoot();
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (textbox_username.Text.Length > 0 && textbox_password.Text.Length > 7)
            {

            }
            else
            {
                string[] msg = new[]
                {
                    "ERROR: FAILED TO SAVE\nThe Followíng errors occured while saving:\n\n",
                    "",
                    "",
                    "\n\nPlease correct all Errors and try Again !"
                };
                if (textbox_username.Text.Length <= 0)
                    msg[1] = "The username is invalid\n It has to be at least 1 character long !\n\n";
                if (textbox_password.Text.Length <= 7)
                    msg[2] = "The password is invalid\n It has to be at least 8 characters long !";
                MessageBox.Show(msg[0] + msg[1] + msg[2] + msg[3], "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button_refreshlist_Click(object sender, EventArgs e)
        {
            refreshList();
        }

        private void refreshList()
        {
            XmlGateway gate = new XmlGateway(gateKey);
            string[] names = gate.getUserList();
            listBox1.Items.AddRange(names);
        }

        private void button_loaduser_Click(object sender, EventArgs e)
        {

        }
    }
}
