namespace XMLCRYPT
{
    partial class SettingsPrompt
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pathinput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cpath = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pathinput
            // 
            this.pathinput.Location = new System.Drawing.Point(160, 6);
            this.pathinput.Name = "pathinput";
            this.pathinput.Size = new System.Drawing.Size(219, 20);
            this.pathinput.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Where to store the Settings: ";
            // 
            // cpath
            // 
            this.cpath.Location = new System.Drawing.Point(15, 36);
            this.cpath.Name = "cpath";
            this.cpath.Size = new System.Drawing.Size(364, 23);
            this.cpath.TabIndex = 2;
            this.cpath.Text = "Choose Path";
            this.cpath.UseVisualStyleBackColor = true;
            this.cpath.Click += new System.EventHandler(this.cpath_Click);
            // 
            // SettingsPrompt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 71);
            this.Controls.Add(this.cpath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pathinput);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsPrompt";
            this.Text = "SettingsPrompt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pathinput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cpath;
    }
}