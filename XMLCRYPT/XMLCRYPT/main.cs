using System;
using System.IO;
using System.Windows.Forms;
using cryptography;

namespace XMLCRYPT
{
    public partial class Main : Form
    {
        private int _r = 0;
        private string _gateKey = "../../data/data.xml";
        private string _gatePath = "../../data";
        public Main()
        {
            InitializeComponent();
        }

        private void main_Load(object sender, EventArgs e)
        {
            SettingsPrompt d = new SettingsPrompt();
            d.ShowDialog();
            XmlGateway xgate = new XmlGateway(_gateKey);
            if (!Directory.Exists(_gatePath))
            {
                Directory.CreateDirectory(_gatePath);
                xgate.CreateRoot();
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (textbox_username.Text.Length > 0 && textbox_password.Text.Length > 7)
            {
                Random subrandom = new Random();
                int time = subrandom.Next();
                Random r = new Random(time);
                int random = r.Next(1000, 500000);
                Crypt a = new Crypt(500000);
                string hash = a.GetPwhash(textbox_password.Text);
                XmlGateway gate = new XmlGateway(_gateKey);
                gate.AddUsr(textbox_username.Text, hash, random, DateTime.Now);
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
            RefreshList();
        }

        private void RefreshList()
        {
            XmlGateway gate = new XmlGateway(_gateKey);
            object[] names = gate.GetUserList();
            if (names != null) listBox1.Items.AddRange(items: names);
        }

        private void button_loaduser_Click(object sender, EventArgs e)
        {

        }
    }
}
