namespace YouTube_Downloader
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnDownload = new MetroFramework.Controls.MetroTile();
            this.fieldTolink = new System.Windows.Forms.TextBox();
            this.statusLb = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(391, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(86, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Link to video:";
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(25, 113);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(361, 43);
            this.btnDownload.Style = MetroFramework.MetroColorStyle.Red;
            this.btnDownload.TabIndex = 2;
            this.btnDownload.Text = "DOWNLAD VIDEO";
            this.btnDownload.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDownload.TileImage = ((System.Drawing.Image)(resources.GetObject("btnDownload.TileImage")));
            this.btnDownload.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDownload.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnDownload.UseTileImage = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // fieldTolink
            // 
            this.fieldTolink.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fieldTolink.Location = new System.Drawing.Point(25, 82);
            this.fieldTolink.Name = "fieldTolink";
            this.fieldTolink.Size = new System.Drawing.Size(360, 25);
            this.fieldTolink.TabIndex = 4;
            // 
            // statusLb
            // 
            this.statusLb.AutoSize = true;
            this.statusLb.Enabled = false;
            this.statusLb.FontSize = MetroFramework.MetroLabelSize.Small;
            this.statusLb.Location = new System.Drawing.Point(303, 64);
            this.statusLb.Name = "statusLb";
            this.statusLb.Size = new System.Drawing.Size(82, 15);
            this.statusLb.TabIndex = 5;
            this.statusLb.Text = "Downloading...";
            this.statusLb.Visible = false;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel2.Location = new System.Drawing.Point(391, 30);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(111, 15);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "Created by Lodomur";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 173);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.statusLb);
            this.Controls.Add(this.fieldTolink);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.DropShadow;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "YouTube downloader";
            this.Theme = MetroFramework.MetroThemeStyle.Light;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTile btnDownload;
        private System.Windows.Forms.TextBox fieldTolink;
        private MetroFramework.Controls.MetroLabel statusLb;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}

