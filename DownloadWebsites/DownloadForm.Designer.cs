namespace DownloadWebsites
{
    partial class DownloadForm
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
            this.SyncDownloadButton = new System.Windows.Forms.Button();
            this.AsyncDownloadButton = new System.Windows.Forms.Button();
            this.ShowResultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SyncDownloadButton
            // 
            this.SyncDownloadButton.Location = new System.Drawing.Point(54, 69);
            this.SyncDownloadButton.Name = "SyncDownloadButton";
            this.SyncDownloadButton.Size = new System.Drawing.Size(566, 23);
            this.SyncDownloadButton.TabIndex = 0;
            this.SyncDownloadButton.Text = "SyncDownload";
            this.SyncDownloadButton.UseVisualStyleBackColor = true;
            this.SyncDownloadButton.Click += new System.EventHandler(this.SyncDownloadButton_Click);
            // 
            // AsyncDownloadButton
            // 
            this.AsyncDownloadButton.Location = new System.Drawing.Point(54, 123);
            this.AsyncDownloadButton.Name = "AsyncDownloadButton";
            this.AsyncDownloadButton.Size = new System.Drawing.Size(566, 23);
            this.AsyncDownloadButton.TabIndex = 1;
            this.AsyncDownloadButton.Text = "AsyncDownload";
            this.AsyncDownloadButton.UseVisualStyleBackColor = true;
            this.AsyncDownloadButton.Click += new System.EventHandler(this.AsyncDownloadButton_Click);
            // 
            // ShowResultLabel
            // 
            this.ShowResultLabel.Location = new System.Drawing.Point(54, 200);
            this.ShowResultLabel.Name = "ShowResultLabel";
            this.ShowResultLabel.Size = new System.Drawing.Size(566, 367);
            this.ShowResultLabel.TabIndex = 2;
            this.ShowResultLabel.Text = "显示数据";
            // 
            // DownloadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 761);
            this.Controls.Add(this.ShowResultLabel);
            this.Controls.Add(this.AsyncDownloadButton);
            this.Controls.Add(this.SyncDownloadButton);
            this.Name = "DownloadForm";
            this.Text = "AsyncAwait";
            this.ResumeLayout(false);

        }

        #endregion

        private Button SyncDownloadButton;
        private Button AsyncDownloadButton;
        private Label ShowResultLabel;
    }
}