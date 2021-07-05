using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleServer
{
    public partial class SimpleServer : Form
    {
        string appdata = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        string save;
        string defsave = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\SimpleServer";
        List<string> servers = new List<string>();
        List<string> running = new List<string>();
        List<string> consoles = new List<string>();
        string co = "";

        public SimpleServer()
        {
            InitializeComponent();
            save = appdata + @"\SimpleServer";
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region save
            if (!File.Exists(appdata + @"\SimpleServer\save.json")) File.Create(appdata + @"\SimpleServer\save.json");
            using (StreamReader sr = new StreamReader(appdata + @"\SimpleServer\save.json"))
            {
                save = sr.ReadLine();
            }
            Directory.CreateDirectory(appdata + @"\SimpleServer");
            Directory.CreateDirectory(appdata + @"\SimpleServer\Servers");
            using (StreamWriter sw = new StreamWriter(appdata + @"\SimpleServer\save.json"))
            {
                if (save != "")
                {
                    sw.WriteLine(save);
                }
                else
                {
                    sw.WriteLine(defsave);
                    save = defsave;
                }
            }
            savet.Text = save;
            #endregion
            string[] files = Directory.GetFiles(appdata + @"\SimpleServer\Servers");
            foreach(string s in files)
            {
                FileInfo fi = new FileInfo(s);
                servers.Add(fi.Name.Split('.')[0]);
            }
            LoadServers();
        }
        Label l = new Label();
        public void LoadServers()
        {
            
            ServerList.AutoScrollPosition = new Point(0,0);
            int i = 0;
            if (servers.Count != 0)
            {
                l.Visible = false;
                foreach (string s in servers)
                {
                    using (StreamReader sr = new StreamReader(appdata + @"\SimpleServer\Servers\" + s + ".json"))
                    {
                        sr.ReadLine();
                        Panel p = new Panel();
                        p.Location = new Point(0, i * 32 + i * 2);
                        p.Size = new Size(555, 32);
                        p.BackColor = Color.FromArgb(255, 128, 128);
                        if (running.Contains(s)) p.BackColor = Color.FromArgb(192,255,192);
                        p.Name = s;

                        Label c = new Label();
                        c.Text = sr.ReadLine();
                        c.Location = new Point(145, 9);
                        p.Controls.Add(c);

                        Label m = new Label();
                        m.Text = sr.ReadLine();
                        m.Location = new Point(277, 9);
                        p.Controls.Add(m);

                        Label n = new Label();
                        n.Text = s;
                        n.Location = new Point(11, 9);

                        Button open = new Button();
                        open.Text = "O";
                        open.Name = s;
                        open.Location = new Point(p.Width - 30, 0);
                        open.Size = new Size(30, 32);
                        open.FlatStyle = FlatStyle.Flat;
                        open.BackColor = Color.FromArgb(255, 128, 0);
                        open.Click += Open_Click;
                        p.Controls.Add(open);

                        Button del = new Button();
                        del.Text = "Delete";
                        del.Name = s;
                        del.Location = new Point(p.Width - 85, 0);
                        del.Size = new Size(50, 32);
                        del.FlatStyle = FlatStyle.Flat;
                        del.BackColor = Color.FromArgb(255, 128, 0);
                        del.Click += Del_Click;
                        p.Controls.Add(del);

                        Button start = new Button();
                        start.Text = "Start";
                        start.Name = s;
                        start.Location = new Point(p.Width - 132, 0);
                        start.Size = new Size(42, 32);
                        start.FlatStyle = FlatStyle.Flat;
                        start.BackColor = Color.FromArgb(255, 128, 0);
                        start.Click += Start_Click;
                        p.Controls.Add(start);

                        Button con = new Button();
                        con.Text = "C";
                        con.Name = s;
                        con.Location = new Point(p.Width - 167, 0);
                        con.Size = new Size(30, 32);
                        con.FlatStyle = FlatStyle.Flat;
                        con.BackColor = Color.FromArgb(255, 128, 0);
                        con.Click += Con_Click;
                        p.Controls.Add(con);

                        p.Controls.Add(n);
                        ServerList.Controls.Add(p);
                    }
                    i++;
                }
            }
            else
            {
                l.Visible = true;
                l.Text = "You don't have any server.Why don't you create one?";
                l.Location = new Point(20,20);
                l.Font = new Font("Arial",8,FontStyle.Regular);
                l.Size = new Size(500, 20);
                ServerList.Controls.Add(l);
            }
            
        }

        private void Con_Click(object sender, EventArgs e)
        {
            Panel p = (Panel)(((Button)sender).Parent);
            co = p.Name;
            ServerName.Text = co;
            if (running.Contains(co))
            {
                cout.Text = consoles[running.IndexOf(co)];
                cout.SelectionStart = cout.Text.Length;
                cout.ScrollToCaret();
            }
        }
        Process p;
        private void Start_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (!running.Contains(b.Parent.Name))
            {
                running.Add(b.Parent.Name);
                consoles.Add(b.Parent.Name);
                string path = "";
                using (StreamReader sr = new StreamReader(appdata + @"\SimpleServer\Servers\" + b.Name + ".json"))
                {
                    path = sr.ReadLine();
                }
                p = new Process();
                p.StartInfo.FileName = "cmd.exe";
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.RedirectStandardError = true;
                p.StartInfo.CreateNoWindow = true;
                p.StartInfo.RedirectStandardInput = true;
                p.StartInfo.WorkingDirectory = path + "\\" + b.Name;
                p.Start();
                p.StandardInput.WriteLine("call " + path + "\\" + b.Name + "\\" + "start.bat");
                p.StandardInput.Flush();
                p.OutputDataReceived += P_OutputDataReceived;
                p.ErrorDataReceived += P_ErrorDataReceived;
                p.BeginOutputReadLine();
                p.BeginErrorReadLine();
                b.Parent.BackColor = Color.FromArgb(192, 255, 192);
                LoadServers();
                co = b.Parent.Name;
                if (running.Contains(co))
                {
                    cout.Text = consoles[running.IndexOf(co)];
                    cout.SelectionStart = cout.Text.Length;
                    cout.ScrollToCaret();
                }
            }
            else MessageBox.Show("Server already running.", "ERROR");
        }

        private void P_ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (running.Contains(co))
            {
                consoles[running.IndexOf(co)] += e.Data + "\n";
                this.Invoke(new Action(() => { 
                    cout.Text = consoles[running.IndexOf(co)];
                    cout.SelectionStart = cout.Text.Length;
                    cout.ScrollToCaret();
                }));
                
            }
        }

        private void P_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (running.Contains(co))
            {
                consoles[running.IndexOf(co)] += e.Data + "\n";
                this.Invoke(new Action(() => {
                    cout.Text = consoles[running.IndexOf(co)];
                    cout.SelectionStart = cout.Text.Length;
                    cout.ScrollToCaret();
                }));
                
            }
        }

        private void Open_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            string path = "";
            using (StreamReader sr = new StreamReader(appdata + @"\SimpleServer\Servers\" + b.Name + ".json"))
            {
                path = sr.ReadLine();
            }
            Process p = new Process();
            p.StartInfo.FileName = path + "\\" + b.Name;
            p.StartInfo.UseShellExecute = true;
            p.Start();
        }

        private void Del_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (!running.Contains(b.Parent.Name))
            {
                string path = "";
                using (StreamReader sr = new StreamReader(appdata + @"\SimpleServer\Servers\" + b.Name + ".json"))
                {
                    path = sr.ReadLine();
                }
                File.Delete(appdata + @"\SimpleServer\Servers\" + b.Name + ".json");
                Directory.Delete(path + "\\" + b.Name, true);
                servers.Remove(b.Name);
                ServerList.Controls.Remove(b.Parent);
                LoadServers();
            }
            else MessageBox.Show("Server is running.", "ERROR");
        }

        private void NewServer_Click(object sender, EventArgs e)
        {
            if (versions.Text != "" && Eulacb.Checked && Names.Text != "" && SRam.Value != 0 && MRam.Value != 0 && SMG.Text != "" && MMG.Text != "" && !Directory.Exists(save + "\\" + Names.Text))
            {
                Directory.CreateDirectory(save + "\\" + Names.Text);
                File.Copy(defsave + "\\" + versions.Text + "\\spigot.jar", save + "\\" + Names.Text + "\\spigot.jar");
                using (StreamWriter sw = new StreamWriter(save + "\\" + Names.Text + "\\start.bat"))
                {
                    sw.WriteLine("@echo off");
                    sw.WriteLine("java -Xmx" + MRam.Value + SMG.Text + " -Xms" + SRam.Value + MMG.Text + " -jar spigot.jar");
                    sw.WriteLine("pause");

                }
                using (StreamWriter sw = new StreamWriter(save + "\\" + Names.Text + "\\eula.txt"))
                {
                    sw.WriteLine("#By changing the setting below to TRUE you are indicating your agreement to our EULA ");
                    sw.WriteLine("(https://account.mojang.com/documents/minecraft_eula).");
                    sw.WriteLine("#Mon Jan 01 00:00:00 CET 2021");
                    sw.WriteLine("eula=true");
                }
                using (StreamWriter sw = new StreamWriter(appdata + @"\SimpleServer\Servers\" + Names.Text + ".json"))
                {
                    sw.WriteLine(savet.Text);
                    sw.WriteLine(DateTime.Now);
                    sw.WriteLine(DateTime.Now);
                }
                servers.Add(Names.Text);
                LoadServers();
            }
            else if (Directory.Exists(save + "\\" + Names.Text) && Names.Text != "") MessageBox.Show("Server exist with this name.", "ERROR");
            else MessageBox.Show("Empty field.", "ERROR");
        }

        private void savep_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if(fbd.ShowDialog() == DialogResult.OK)
            {
                savet.Text = fbd.SelectedPath;
                save = fbd.SelectedPath;
                using (StreamWriter sw = new StreamWriter(appdata + @"\SimpleServer\save.json"))
                {
                    sw.WriteLine(save);
                }
            }
        }

        private void versions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!Directory.Exists(defsave + "\\" + versions.Text))
            {
                NewVersion.Visible = true;
            }
            else NewVersion.Visible = false;
        }

        private void NewVersion_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory(defsave + "\\" + versions.Text);
            NewVersion.Visible = false;
            DownloadVer dv = new DownloadVer(versions.Text, this);
            this.Enabled = false;
            dv.Show();
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            LoadServers();
        }

        private void cin_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                p.StandardInput.WriteLine(cin.Text);
                if(cin.Text == "stop")
                {
                    consoles.RemoveAt(running.IndexOf(co));
                    running.Remove(co);
                    cout.Text += "\nServer stopped";
                    LoadServers();
                }
                cin.Text = "";
            }
        }
    }
}
