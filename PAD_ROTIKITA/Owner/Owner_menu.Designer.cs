namespace PAD_ROTIKITA.Owner
{
    partial class Owner_menu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Owner_menu));
            this.btn_pegawai = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_report = new System.Windows.Forms.Button();
            this.btn_history = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_logout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_pegawai
            // 
            this.btn_pegawai.ImageKey = "owner_pegawai.png";
            this.btn_pegawai.ImageList = this.imageList1;
            this.btn_pegawai.Location = new System.Drawing.Point(320, 107);
            this.btn_pegawai.Name = "btn_pegawai";
            this.btn_pegawai.Size = new System.Drawing.Size(256, 256);
            this.btn_pegawai.TabIndex = 0;
            this.btn_pegawai.UseVisualStyleBackColor = true;
            this.btn_pegawai.Click += new System.EventHandler(this.btn_pegawai_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "logout.png");
            this.imageList1.Images.SetKeyName(1, "owner_pegawai.png");
            this.imageList1.Images.SetKeyName(2, "owner_report.png");
            this.imageList1.Images.SetKeyName(3, "history.png");
            // 
            // btn_report
            // 
            this.btn_report.ImageKey = "owner_report.png";
            this.btn_report.ImageList = this.imageList1;
            this.btn_report.Location = new System.Drawing.Point(591, 107);
            this.btn_report.Name = "btn_report";
            this.btn_report.Size = new System.Drawing.Size(256, 256);
            this.btn_report.TabIndex = 1;
            this.btn_report.UseVisualStyleBackColor = true;
            this.btn_report.Click += new System.EventHandler(this.btn_report_Click);
            // 
            // btn_history
            // 
            this.btn_history.ImageKey = "history.png";
            this.btn_history.ImageList = this.imageList1;
            this.btn_history.Location = new System.Drawing.Point(320, 382);
            this.btn_history.Name = "btn_history";
            this.btn_history.Size = new System.Drawing.Size(256, 256);
            this.btn_history.TabIndex = 2;
            this.btn_history.UseVisualStyleBackColor = true;
            this.btn_history.Click += new System.EventHandler(this.btn_history_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(316, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 33);
            this.label1.TabIndex = 9;
            this.label1.Text = "Welcome, Owner";
            // 
            // btn_logout
            // 
            this.btn_logout.ImageKey = "logout.png";
            this.btn_logout.ImageList = this.imageList1;
            this.btn_logout.Location = new System.Drawing.Point(591, 382);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(256, 256);
            this.btn_logout.TabIndex = 10;
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // Owner_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_history);
            this.Controls.Add(this.btn_report);
            this.Controls.Add(this.btn_pegawai);
            this.Name = "Owner_menu";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_pegawai;
        private System.Windows.Forms.Button btn_report;
        private System.Windows.Forms.Button btn_history;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btn_logout;
    }
}