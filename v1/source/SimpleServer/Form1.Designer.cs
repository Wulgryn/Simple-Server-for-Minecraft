
namespace SimpleServer
{
    partial class SimpleServer
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ServerList = new System.Windows.Forms.Panel();
            this.SRam = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ServerName = new System.Windows.Forms.Label();
            this.Names = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MRam = new System.Windows.Forms.NumericUpDown();
            this.NewVersion = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Port = new System.Windows.Forms.TextBox();
            this.Eulacb = new System.Windows.Forms.CheckBox();
            this.MMG = new System.Windows.Forms.ComboBox();
            this.SMG = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.versions = new System.Windows.Forms.ComboBox();
            this.savep = new System.Windows.Forms.Button();
            this.savet = new System.Windows.Forms.TextBox();
            this.NewServer = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cout = new System.Windows.Forms.RichTextBox();
            this.cin = new System.Windows.Forms.TextBox();
            this.Refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SRam)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MRam)).BeginInit();
            this.SuspendLayout();
            // 
            // ServerList
            // 
            this.ServerList.AutoScroll = true;
            this.ServerList.BackColor = System.Drawing.SystemColors.Control;
            this.ServerList.Location = new System.Drawing.Point(226, 30);
            this.ServerList.Name = "ServerList";
            this.ServerList.Size = new System.Drawing.Size(574, 420);
            this.ServerList.TabIndex = 0;
            // 
            // SRam
            // 
            this.SRam.Location = new System.Drawing.Point(11, 194);
            this.SRam.Maximum = new decimal(new int[] {
            32768,
            0,
            0,
            0});
            this.SRam.Name = "SRam";
            this.SRam.Size = new System.Drawing.Size(92, 23);
            this.SRam.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.Names);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.MRam);
            this.panel2.Controls.Add(this.SRam);
            this.panel2.Controls.Add(this.NewVersion);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.Port);
            this.panel2.Controls.Add(this.Eulacb);
            this.panel2.Controls.Add(this.MMG);
            this.panel2.Controls.Add(this.SMG);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.versions);
            this.panel2.Controls.Add(this.savep);
            this.panel2.Controls.Add(this.savet);
            this.panel2.Controls.Add(this.NewServer);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 450);
            this.panel2.TabIndex = 1;
            // 
            // ServerName
            // 
            this.ServerName.AutoSize = true;
            this.ServerName.Location = new System.Drawing.Point(806, 12);
            this.ServerName.Name = "ServerName";
            this.ServerName.Size = new System.Drawing.Size(40, 15);
            this.ServerName.TabIndex = 18;
            this.ServerName.Text = "NONE";
            // 
            // Names
            // 
            this.Names.Location = new System.Drawing.Point(11, 130);
            this.Names.Name = "Names";
            this.Names.Size = new System.Drawing.Size(197, 23);
            this.Names.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Name:";
            // 
            // MRam
            // 
            this.MRam.Location = new System.Drawing.Point(11, 222);
            this.MRam.Maximum = new decimal(new int[] {
            32768,
            0,
            0,
            0});
            this.MRam.Name = "MRam";
            this.MRam.Size = new System.Drawing.Size(92, 23);
            this.MRam.TabIndex = 15;
            // 
            // NewVersion
            // 
            this.NewVersion.BackColor = System.Drawing.Color.OrangeRed;
            this.NewVersion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NewVersion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewVersion.Location = new System.Drawing.Point(13, 53);
            this.NewVersion.Name = "NewVersion";
            this.NewVersion.Size = new System.Drawing.Size(75, 23);
            this.NewVersion.TabIndex = 14;
            this.NewVersion.Text = "Download";
            this.NewVersion.UseVisualStyleBackColor = false;
            this.NewVersion.Visible = false;
            this.NewVersion.Click += new System.EventHandler(this.NewVersion_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "PORT:";
            // 
            // Port
            // 
            this.Port.Location = new System.Drawing.Point(13, 275);
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(38, 23);
            this.Port.TabIndex = 12;
            this.Port.Text = "25565";
            // 
            // Eulacb
            // 
            this.Eulacb.AutoSize = true;
            this.Eulacb.Location = new System.Drawing.Point(11, 315);
            this.Eulacb.Name = "Eulacb";
            this.Eulacb.Size = new System.Drawing.Size(102, 19);
            this.Eulacb.TabIndex = 11;
            this.Eulacb.Text = "Agree to EULA";
            this.Eulacb.UseVisualStyleBackColor = true;
            // 
            // MMG
            // 
            this.MMG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MMG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MMG.FormattingEnabled = true;
            this.MMG.Items.AddRange(new object[] {
            "M",
            "G"});
            this.MMG.Location = new System.Drawing.Point(118, 222);
            this.MMG.Name = "MMG";
            this.MMG.Size = new System.Drawing.Size(44, 23);
            this.MMG.TabIndex = 10;
            // 
            // SMG
            // 
            this.SMG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SMG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SMG.FormattingEnabled = true;
            this.SMG.Items.AddRange(new object[] {
            "M",
            "G"});
            this.SMG.Location = new System.Drawing.Point(118, 193);
            this.SMG.Name = "SMG";
            this.SMG.Size = new System.Drawing.Size(44, 23);
            this.SMG.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Start/Max RAM:";
            // 
            // versions
            // 
            this.versions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.versions.FormattingEnabled = true;
            this.versions.Items.AddRange(new object[] {
            "1.16.5",
            "1.16.4",
            "1.16.3",
            "1.16.2",
            "1.16.1",
            "1.15.2",
            "1.15.2",
            "1.15.1",
            "1.15",
            "1.14.4",
            "1.14.3",
            "1.14.2",
            "1.14",
            "1.13.2",
            "1.13",
            "1.12.2",
            "1.12",
            "1.11.2",
            "1.11.1",
            "1.11"});
            this.versions.Location = new System.Drawing.Point(13, 82);
            this.versions.Name = "versions";
            this.versions.Size = new System.Drawing.Size(196, 23);
            this.versions.TabIndex = 5;
            this.versions.SelectedIndexChanged += new System.EventHandler(this.versions_SelectedIndexChanged);
            // 
            // savep
            // 
            this.savep.Location = new System.Drawing.Point(195, 415);
            this.savep.Name = "savep";
            this.savep.Size = new System.Drawing.Size(25, 23);
            this.savep.TabIndex = 3;
            this.savep.Text = "O";
            this.savep.UseVisualStyleBackColor = true;
            this.savep.Click += new System.EventHandler(this.savep_Click);
            // 
            // savet
            // 
            this.savet.Location = new System.Drawing.Point(12, 415);
            this.savet.Name = "savet";
            this.savet.ReadOnly = true;
            this.savet.Size = new System.Drawing.Size(177, 23);
            this.savet.TabIndex = 2;
            // 
            // NewServer
            // 
            this.NewServer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NewServer.Location = new System.Drawing.Point(13, 12);
            this.NewServer.Name = "NewServer";
            this.NewServer.Size = new System.Drawing.Size(196, 35);
            this.NewServer.TabIndex = 0;
            this.NewServer.Text = "New";
            this.NewServer.UseVisualStyleBackColor = true;
            this.NewServer.Click += new System.EventHandler(this.NewServer_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(235, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(371, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "Created";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(503, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 15);
            this.label9.TabIndex = 4;
            this.label9.Text = "Modified";
            // 
            // cout
            // 
            this.cout.Location = new System.Drawing.Point(806, 30);
            this.cout.Name = "cout";
            this.cout.ReadOnly = true;
            this.cout.Size = new System.Drawing.Size(612, 391);
            this.cout.TabIndex = 5;
            this.cout.Text = "";
            // 
            // cin
            // 
            this.cin.Location = new System.Drawing.Point(806, 427);
            this.cin.Name = "cin";
            this.cin.Size = new System.Drawing.Size(610, 23);
            this.cin.TabIndex = 6;
            this.cin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cin_KeyDown);
            // 
            // Refresh
            // 
            this.Refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Refresh.Location = new System.Drawing.Point(706, 5);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(94, 23);
            this.Refresh.TabIndex = 7;
            this.Refresh.Text = "Refresh";
            this.Refresh.UseVisualStyleBackColor = false;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // SimpleServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1416, 450);
            this.Controls.Add(this.ServerName);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.cin);
            this.Controls.Add(this.cout);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ServerList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "SimpleServer";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SimpleServer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SRam)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MRam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel ServerList;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button NewServer;
        private System.Windows.Forms.Button savep;
        private System.Windows.Forms.TextBox savet;
        private System.Windows.Forms.ComboBox SMG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox versions;
        private System.Windows.Forms.ComboBox MMG;
        private System.Windows.Forms.CheckBox Eulacb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Port;
        private System.Windows.Forms.Button NewVersion;
        private System.Windows.Forms.NumericUpDown SRam;
        private System.Windows.Forms.NumericUpDown MRam;
        private System.Windows.Forms.TextBox Names;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox cout;
        private System.Windows.Forms.TextBox cin;
        private System.Windows.Forms.Label ServerName;
        private System.Windows.Forms.Button Refresh;
    }
}

