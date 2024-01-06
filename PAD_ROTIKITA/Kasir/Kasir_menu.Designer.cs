namespace PAD_ROTIKITA.Kasir
{
    partial class Kasir_menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kasir_menu));
            this.btn_transaksi = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_history = new System.Windows.Forms.Button();
            this.nama = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_transaksi
            // 
            this.btn_transaksi.ImageKey = "Kasir_transaksi.png";
            this.btn_transaksi.ImageList = this.imageList1;
            this.btn_transaksi.Location = new System.Drawing.Point(203, 202);
            this.btn_transaksi.Name = "btn_transaksi";
            this.btn_transaksi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_transaksi.Size = new System.Drawing.Size(256, 256);
            this.btn_transaksi.TabIndex = 0;
            this.btn_transaksi.UseVisualStyleBackColor = true;
            this.btn_transaksi.Click += new System.EventHandler(this.btn_transaksi_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Kasir_transaksi.png");
            this.imageList1.Images.SetKeyName(1, "history.png");
            this.imageList1.Images.SetKeyName(2, "logout.png");
            // 
            // btn_history
            // 
            this.btn_history.ImageKey = "history.png";
            this.btn_history.ImageList = this.imageList1;
            this.btn_history.Location = new System.Drawing.Point(512, 202);
            this.btn_history.Name = "btn_history";
            this.btn_history.Size = new System.Drawing.Size(256, 256);
            this.btn_history.TabIndex = 1;
            this.btn_history.UseVisualStyleBackColor = true;
            this.btn_history.Click += new System.EventHandler(this.btn_history_Click);
            // 
            // nama
            // 
            this.nama.AutoSize = true;
            this.nama.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nama.Location = new System.Drawing.Point(382, 137);
            this.nama.Name = "nama";
            this.nama.Size = new System.Drawing.Size(77, 33);
            this.nama.TabIndex = 9;
            this.nama.Text = "nama";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(197, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 33);
            this.label1.TabIndex = 8;
            this.label1.Text = "Welcome, Kasir";
            // 
            // button1
            // 
            this.button1.ImageKey = "logout.png";
            this.button1.ImageList = this.imageList1;
            this.button1.Location = new System.Drawing.Point(833, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(256, 256);
            this.button1.TabIndex = 10;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Kasir_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nama);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_history);
            this.Controls.Add(this.btn_transaksi);
            this.Name = "Kasir_menu";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Kasir_menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_transaksi;
        private System.Windows.Forms.Button btn_history;
        private System.Windows.Forms.Label nama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button button1;
    }
}