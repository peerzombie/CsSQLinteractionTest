namespace XMLCRYPT
{
    partial class main
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.submitButton = new System.Windows.Forms.Button();
            this.desc1 = new System.Windows.Forms.Label();
            this.textbox_username = new System.Windows.Forms.TextBox();
            this.mbox = new System.Windows.Forms.GroupBox();
            this.desc2 = new System.Windows.Forms.Label();
            this.textbox_password = new System.Windows.Forms.TextBox();
            this.box_loadUser = new System.Windows.Forms.GroupBox();
            this.button_loaduser = new System.Windows.Forms.Button();
            this.button_refreshlist = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.mbox.SuspendLayout();
            this.box_loadUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(9, 71);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(245, 23);
            this.submitButton.TabIndex = 0;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // desc1
            // 
            this.desc1.AutoSize = true;
            this.desc1.Location = new System.Drawing.Point(6, 22);
            this.desc1.Name = "desc1";
            this.desc1.Size = new System.Drawing.Size(55, 13);
            this.desc1.TabIndex = 1;
            this.desc1.Text = "Username";
            // 
            // textbox_username
            // 
            this.textbox_username.Location = new System.Drawing.Point(67, 19);
            this.textbox_username.Name = "textbox_username";
            this.textbox_username.Size = new System.Drawing.Size(187, 20);
            this.textbox_username.TabIndex = 2;
            // 
            // mbox
            // 
            this.mbox.Controls.Add(this.desc2);
            this.mbox.Controls.Add(this.submitButton);
            this.mbox.Controls.Add(this.textbox_password);
            this.mbox.Controls.Add(this.desc1);
            this.mbox.Controls.Add(this.textbox_username);
            this.mbox.Location = new System.Drawing.Point(12, 12);
            this.mbox.Name = "mbox";
            this.mbox.Size = new System.Drawing.Size(260, 103);
            this.mbox.TabIndex = 3;
            this.mbox.TabStop = false;
            this.mbox.Text = "Add User";
            // 
            // desc2
            // 
            this.desc2.AutoSize = true;
            this.desc2.Location = new System.Drawing.Point(6, 48);
            this.desc2.Name = "desc2";
            this.desc2.Size = new System.Drawing.Size(53, 13);
            this.desc2.TabIndex = 3;
            this.desc2.Text = "Password";
            // 
            // textbox_password
            // 
            this.textbox_password.Location = new System.Drawing.Point(67, 45);
            this.textbox_password.Name = "textbox_password";
            this.textbox_password.PasswordChar = '*';
            this.textbox_password.Size = new System.Drawing.Size(187, 20);
            this.textbox_password.TabIndex = 4;
            // 
            // box_loadUser
            // 
            this.box_loadUser.Controls.Add(this.button_loaduser);
            this.box_loadUser.Controls.Add(this.button_refreshlist);
            this.box_loadUser.Controls.Add(this.listBox1);
            this.box_loadUser.Location = new System.Drawing.Point(12, 122);
            this.box_loadUser.Name = "box_loadUser";
            this.box_loadUser.Size = new System.Drawing.Size(260, 127);
            this.box_loadUser.TabIndex = 4;
            this.box_loadUser.TabStop = false;
            this.box_loadUser.Text = "Load User";
            // 
            // button_loaduser
            // 
            this.button_loaduser.Location = new System.Drawing.Point(136, 98);
            this.button_loaduser.Name = "button_loaduser";
            this.button_loaduser.Size = new System.Drawing.Size(118, 23);
            this.button_loaduser.TabIndex = 2;
            this.button_loaduser.Text = "Load User";
            this.button_loaduser.UseVisualStyleBackColor = true;
            this.button_loaduser.Click += new System.EventHandler(this.button_loaduser_Click);
            // 
            // button_refreshlist
            // 
            this.button_refreshlist.Location = new System.Drawing.Point(9, 98);
            this.button_refreshlist.Name = "button_refreshlist";
            this.button_refreshlist.Size = new System.Drawing.Size(121, 23);
            this.button_refreshlist.TabIndex = 1;
            this.button_refreshlist.Text = "Refresh List";
            this.button_refreshlist.UseVisualStyleBackColor = true;
            this.button_refreshlist.Click += new System.EventHandler(this.button_refreshlist_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(9, 20);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(245, 69);
            this.listBox1.TabIndex = 0;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.box_loadUser);
            this.Controls.Add(this.mbox);
            this.Name = "main";
            this.Text = "Add User";
            this.Load += new System.EventHandler(this.main_Load);
            this.mbox.ResumeLayout(false);
            this.mbox.PerformLayout();
            this.box_loadUser.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label desc1;
        private System.Windows.Forms.TextBox textbox_username;
        private System.Windows.Forms.GroupBox mbox;
        private System.Windows.Forms.Label desc2;
        private System.Windows.Forms.TextBox textbox_password;
        private System.Windows.Forms.GroupBox box_loadUser;
        private System.Windows.Forms.Button button_loaduser;
        private System.Windows.Forms.Button button_refreshlist;
        private System.Windows.Forms.ListBox listBox1;
    }
}

