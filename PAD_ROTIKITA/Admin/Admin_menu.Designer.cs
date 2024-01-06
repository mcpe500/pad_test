namespace PAD_ROTIKITA.Admin
{
    partial class Admin_menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_menu));
            this.btn_logout = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_buang = new System.Windows.Forms.Button();
            this.btn_history = new System.Windows.Forms.Button();
            this.btn_diskon = new System.Windows.Forms.Button();
            this.btn_tambah = new System.Windows.Forms.Button();
            this.btn_daftar = new System.Windows.Forms.Button();
            this.nama = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_logout
            // 
            this.btn_logout.ImageKey = "logout.png";
            this.btn_logout.ImageList = this.imageList1;
            this.btn_logout.Location = new System.Drawing.Point(780, 404);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(265, 265);
            this.btn_logout.TabIndex = 13;
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "admin_buang.png");
            this.imageList1.Images.SetKeyName(1, "admin_daftar.png");
            this.imageList1.Images.SetKeyName(2, "admin_diskon.png");
            this.imageList1.Images.SetKeyName(3, "admin_tambah.png");
            this.imageList1.Images.SetKeyName(4, "history.png");
            this.imageList1.Images.SetKeyName(5, "logout.png");
            // 
            // btn_buang
            // 
            this.btn_buang.ImageKey = "admin_buang.png";
            this.btn_buang.ImageList = this.imageList1;
            this.btn_buang.Location = new System.Drawing.Point(780, 117);
            this.btn_buang.Name = "btn_buang";
            this.btn_buang.Size = new System.Drawing.Size(265, 265);
            this.btn_buang.TabIndex = 12;
            this.btn_buang.UseVisualStyleBackColor = true;
            this.btn_buang.Click += new System.EventHandler(this.btn_buang_Click);
            // 
            // btn_history
            // 
            this.btn_history.ImageKey = "history.png";
            this.btn_history.ImageList = this.imageList1;
            this.btn_history.Location = new System.Drawing.Point(487, 404);
            this.btn_history.Name = "btn_history";
            this.btn_history.Size = new System.Drawing.Size(265, 265);
            this.btn_history.TabIndex = 11;
            this.btn_history.UseVisualStyleBackColor = true;
            this.btn_history.Click += new System.EventHandler(this.btn_history_Click);
            // 
            // btn_diskon
            // 
            this.btn_diskon.ImageKey = "admin_diskon.png";
            this.btn_diskon.ImageList = this.imageList1;
            this.btn_diskon.Location = new System.Drawing.Point(202, 404);
            this.btn_diskon.Name = "btn_diskon";
            this.btn_diskon.Size = new System.Drawing.Size(265, 265);
            this.btn_diskon.TabIndex = 10;
            this.btn_diskon.UseVisualStyleBackColor = true;
            this.btn_diskon.Click += new System.EventHandler(this.btn_diskon_Click);
            // 
            // btn_tambah
            // 
            this.btn_tambah.ImageKey = "admin_tambah.png";
            this.btn_tambah.ImageList = this.imageList1;
            this.btn_tambah.Location = new System.Drawing.Point(487, 117);
            this.btn_tambah.Name = "btn_tambah";
            this.btn_tambah.Size = new System.Drawing.Size(265, 265);
            this.btn_tambah.TabIndex = 9;
            this.btn_tambah.UseVisualStyleBackColor = true;
            this.btn_tambah.Click += new System.EventHandler(this.btn_tambah_Click);
            // 
            // btn_daftar
            // 
            this.btn_daftar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_daftar.ImageKey = "admin_daftar.png";
            this.btn_daftar.ImageList = this.imageList1;
            this.btn_daftar.Location = new System.Drawing.Point(202, 117);
            this.btn_daftar.Name = "btn_daftar";
            this.btn_daftar.Size = new System.Drawing.Size(265, 265);
            this.btn_daftar.TabIndex = 8;
            this.btn_daftar.UseVisualStyleBackColor = true;
            this.btn_daftar.Click += new System.EventHandler(this.btn_daftar_Click);
            // 
            // nama
            // 
            this.nama.AutoSize = true;
            this.nama.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nama.Location = new System.Drawing.Point(241, 45);
            this.nama.Name = "nama";
            this.nama.Size = new System.Drawing.Size(77, 33);
            this.nama.TabIndex = 17;
            this.nama.Text = "nama";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 33);
            this.label1.TabIndex = 16;
            this.label1.Text = "Welcome, Admin ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1250, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // Admin_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.nama);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.btn_buang);
            this.Controls.Add(this.btn_history);
            this.Controls.Add(this.btn_diskon);
            this.Controls.Add(this.btn_tambah);
            this.Controls.Add(this.btn_daftar);
            this.Name = "Admin_menu";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Admin_menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Button btn_buang;
        private System.Windows.Forms.Button btn_history;
        private System.Windows.Forms.Button btn_diskon;
        private System.Windows.Forms.Button btn_tambah;
        private System.Windows.Forms.Button btn_daftar;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label nama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}