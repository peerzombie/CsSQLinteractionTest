using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cryptography;

namespace XMLCRYPT
{
    public partial class main : Form
    {
        private crypt c = new crypt(1);
        public main()
        {
            InitializeComponent();
        }

        private void main_Load(object sender, EventArgs e)
        {
            XmlGateway xgate = new XmlGateway("data/data.xml");
            if (!Directory.Exists("data"))
            {
                Directory.CreateDirectory("data");
                xgate.CreateRoot();
            }
        }
    }
}
