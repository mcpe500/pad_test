namespace PAD_ROTIKITA.Owner
{
    partial class Owner_register
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.TBNamaPegawai = new System.Windows.Forms.TextBox();
            this.TBPassPegawai = new System.Windows.Forms.TextBox();
            this.kasirRadioButton = new System.Windows.Forms.RadioButton();
            this.adminRadioButton = new System.Windows.Forms.RadioButton();
            this.listPegawaiView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.listPegawaiView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Register Pegawai";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(109, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(109, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password : ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(114, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(385, 57);
            this.button1.TabIndex = 3;
            this.button1.Text = "Register";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.menuDaftarRotiButton_Click);
            // 
            // TBNamaPegawai
            // 
            this.TBNamaPegawai.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBNamaPegawai.Location = new System.Drawing.Point(254, 199);
            this.TBNamaPegawai.Name = "TBNamaPegawai";
            this.TBNamaPegawai.Size = new System.Drawing.Size(245, 37);
            this.TBNamaPegawai.TabIndex = 4;
            // 
            // TBPassPegawai
            // 
            this.TBPassPegawai.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBPassPegawai.Location = new System.Drawing.Point(254, 254);
            this.TBPassPegawai.Name = "TBPassPegawai";
            this.TBPassPegawai.Size = new System.Drawing.Size(245, 37);
            this.TBPassPegawai.TabIndex = 5;
            // 
            // kasirRadioButton
            // 
            this.kasirRadioButton.AutoSize = true;
            this.kasirRadioButton.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kasirRadioButton.Location = new System.Drawing.Point(254, 307);
            this.kasirRadioButton.Name = "kasirRadioButton";
            this.kasirRadioButton.Size = new System.Drawing.Size(78, 33);
            this.kasirRadioButton.TabIndex = 6;
            this.kasirRadioButton.TabStop = true;
            this.kasirRadioButton.Text = "Kasir";
            this.kasirRadioButton.UseVisualStyleBackColor = true;
            // 
            // adminRadioButton
            // 
            this.adminRadioButton.AutoSize = true;
            this.adminRadioButton.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminRadioButton.Location = new System.Drawing.Point(403, 307);
            this.adminRadioButton.Name = "adminRadioButton";
            this.adminRadioButton.Size = new System.Drawing.Size(96, 33);
            this.adminRadioButton.TabIndex = 7;
            this.adminRadioButton.TabStop = true;
            this.adminRadioButton.Text = "Admin";
            this.adminRadioButton.UseVisualStyleBackColor = true;
            // 
            // listPegawaiView
            // 
            this.listPegawaiView.AllowUserToAddRows = false;
            this.listPegawaiView.AllowUserToDeleteRows = false;
            this.listPegawaiView.AllowUserToResizeColumns = false;
            this.listPegawaiView.AllowUserToResizeRows = false;
            this.listPegawaiView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listPegawaiView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listPegawaiView.GridColor = System.Drawing.Color.Black;
            this.listPegawaiView.Location = new System.Drawing.Point(559, 133);
            this.listPegawaiView.Name = "listPegawaiView";
            this.listPegawaiView.ReadOnly = true;
            this.listPegawaiView.RowHeadersVisible = false;
            this.listPegawaiView.RowHeadersWidth = 62;
            this.listPegawaiView.RowTemplate.Height = 28;
            this.listPegawaiView.Size = new System.Drawing.Size(688, 523);
            this.listPegawaiView.TabIndex = 8;
            // 
            // Owner_register
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.listPegawaiView);
            this.Controls.Add(this.adminRadioButton);
            this.Controls.Add(this.kasirRadioButton);
            this.Controls.Add(this.TBPassPegawai);
            this.Controls.Add(this.TBNamaPegawai);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Owner_register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRegister";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Owner_register_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listPegawaiView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBNamaPegawai;
        private System.Windows.Forms.TextBox TBPassPegawai;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton kasirRadioButton;
        private System.Windows.Forms.RadioButton adminRadioButton;
        private System.Windows.Forms.DataGridView listPegawaiView;
    }
}