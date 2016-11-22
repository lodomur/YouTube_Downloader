using MetroFramework.Forms;
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
using VideoLibrary;

namespace YouTube_Downloader
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        // Main
        public MainForm()
        {
            InitializeComponent();   
        }

        // Click btn download
        private async void btnDownload_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog() { Description = "Select you path" } )
            {
                // Check empty ? fieldTolink
                if (fieldTolink.Text == null || fieldTolink.Text == "")
                {
                    MessageBox.Show(this, "Field 'link' not be empty", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else {
                    // Show dialog 
                    if (fbd.ShowDialog() == DialogResult.OK)
                    {
                        var youtube = YouTube.Default;
                        //Visible for label
                        statusLb.Visible = true;
                        // Change label value - Downloading
                        statusLb.Text = "Downloading";
                        var video = await youtube.GetVideoAsync(fieldTolink.Text);
                        // Path, file save
                        File.WriteAllBytes(fbd.SelectedPath + "/" + video.FullName, await video.GetBytesAsync());
                        // Change label value - Completed
                        statusLb.Text = "Completed";
                    }
                }
            }
        }
    }
}
