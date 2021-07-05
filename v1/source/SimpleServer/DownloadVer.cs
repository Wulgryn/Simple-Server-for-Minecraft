using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleServer
{
    public partial class DownloadVer : Form
    {
        string ver;
        Form f1;
        Uri link;
        string defsave = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\SimpleServer";
        public DownloadVer(string ver,Form f)
        {
            InitializeComponent();
            this.ver = ver;
            link = new Uri("https://cdn.getbukkit.org/spigot/spigot-" + ver + ".jar");
            f1 = f;
        }

        private void DownloadVer_Load(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            client.DownloadFileAsync(link, defsave + "\\" + ver + "\\spigot.jar");
            client.DownloadProgressChanged += (o, ex) =>
            {
                progressBar1.Value = ex.ProgressPercentage;
            };
            client.DownloadFileCompleted += (o, ex) =>
            {
                f1.Enabled = true;
                this.Dispose();
            };
        }
    }
}
