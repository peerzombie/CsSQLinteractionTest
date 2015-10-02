using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XMLCRYPT
{
    public partial class SettingsPrompt : Form
    {
        public SettingsPrompt()
        {
            InitializeComponent();
        }

        private void cpath_Click(object sender, EventArgs e)
        {
            if (pathinput.Text.Length > 0)
            {
                string tmp = pathinput.Text;
                if (tmp.EndsWith("/") || tmp.EndsWith("\\")) tmp = tmp.Substring(0, tmp.Length - 1);
                XMLCRYPT.Properties.Settings.Default.datapath = tmp;
            }
            else
            {
                DialogResult res = MessageBox.Show("ERROR\nPath is Empty !\n Choose default path (data/) ?", "Path Invalid !",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res.Equals(DialogResult.OK))
                {
                    XMLCRYPT.Properties.Settings.Default.datapath = "data";
                }
            }
        }
    }
}
