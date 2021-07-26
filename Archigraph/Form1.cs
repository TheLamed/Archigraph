using Kvyk.Telegraph;
using Kvyk.Telegraph.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Archigraph
{
    public partial class Form1 : Form
    {
        public string ArchiveFilePath { get; set; }
        public bool IsLoading { get; set; } = false; 

        public Form1()
        {
            InitializeComponent();
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            if (IsLoading)
                return;

            using (var openFileDialog = new OpenFileDialog())
            {
                if (ArchiveFilePath != null)
                    openFileDialog.InitialDirectory = Path.GetFullPath(ArchiveFilePath);

                openFileDialog.Filter = "Files|*.zip;";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ArchiveFilePath = openFileDialog.FileName;
                    tbRoot.Text = ArchiveFilePath;
                }
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (IsLoading)
                return;

            btnCreate_Click();
        }
        private async Task btnCreate_Click()
        {
            IsLoading = true;

            try
            {
                if (string.IsNullOrEmpty(ArchiveFilePath))
                {
                    MessageBox.Show("Select archive", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrEmpty(tbTitle.Text))
                {
                    MessageBox.Show("Enter Title", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                lbInfo.Text = $"Connecting to Telegra.ph";

                var client = new TelegraphClient();
                client.AccessToken = (await client.CreateAccount("Archigraph")).AccessToken;


                using ZipArchive archive = ZipFile.OpenRead(ArchiveFilePath);
                int i = 0;
                var nodes = new List<Node>();

                foreach (ZipArchiveEntry entry in archive.Entries)
                {
                    lbInfo.Text = $"Loading: {i + 1} from {archive.Entries.Count}";

                    var mime = GetMIMETypeByName(entry.FullName);
                    if (mime != "application/octet-stream")
                    {
                        var s = entry.Open();
                        var ms = new MemoryStream();
                        await s.CopyToAsync(ms);
                        var arr = ms.ToArray();
                        s.Dispose();

                        var file = await client.UploadFile(new FileToUpload { Bytes = arr, Type = mime });
                        nodes.Add(Node.ImageFigure(file.Path));
                    }
                    i++;
                }

                lbInfo.Text = $"Creating Telegra.ph page";


                var page = await client.CreatePage(tbTitle.Text, nodes);

                tbLink.Text = page.Url;

                lbInfo.Text = $"Done!";

                var psInfo = new ProcessStartInfo
                {
                    FileName = page.Url,
                    UseShellExecute = true
                };
                Process.Start(psInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if(lbInfo.Text != "Done!")
                    lbInfo.Text = "";

                IsLoading = false;
            }
        }

        private string GetMIMETypeByName(string name)
        {
            var ext = Path.GetExtension(name);
            switch (ext)
            {
                case ".png": return "image/png";
                case ".jpeg":
                case ".jpg": return "image/jpg";
                case ".gif": return "image/gif";
                default:
                    return "application/octet-stream";
            }
        }

    }
}
