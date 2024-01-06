using PAD_ROTIKITA.Controller;
using PAD_ROTIKITA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAD_ROTIKITA.Admin
{
    public partial class Admin_daftar : Form
    {
        private Panel fixedPanel;
        private List<RoundedPanel> rotiList;
        public Admin_daftar()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            InitializeFixedPanel();
            rotiList = new List<RoundedPanel>();
        }

        private void InitializeFixedPanel()
        {
            fixedPanel = new Panel
            {
                Size = new System.Drawing.Size(200, 50),
                BackColor = System.Drawing.Color.Cornsilk,
                Location = new System.Drawing.Point(10, 10), 
            };

            Controls.Add(fixedPanel);

            // Subscribe to the form's Scroll event
            this.Scroll += FormDaftarRoti_Scroll;
        }


        public void jenisRotiPanel_Click(object sender, EventArgs e)
        {
            Panel current = (Panel)sender;

            // Define variables to store label texts
            string labelKodeText = "";
            string labelKode = "";
            string labelNameText = "";
            string labelNama = "";
            string labelExpiredText = "";
            string labelExpired = "";
            string labelHargaText = "";
            string labelHarga = "";

            foreach (var item in current.Controls)
            {
                if (((Label)item).Name.Contains("labelKodeText" + current.TabIndex))
                {
                    labelKodeText = ((Label)item).Text;
                }
                else if (((Label)item).Name.Contains("labelKode" + current.TabIndex))
                {
                    labelKode = ((Label)item).Text;
                }
                else if (((Label)item).Name.Contains("labelNameText" + current.TabIndex))
                {
                    labelNameText = ((Label)item).Text;
                }
                else if (((Label)item).Name.Contains("labelNama" + current.TabIndex))
                {
                    labelNama = ((Label)item).Text;
                }
                else if (((Label)item).Name.Contains("labelExpiredText" + current.TabIndex))
                {
                    labelExpiredText = ((Label)item).Text;
                }
                else if (((Label)item).Name.Contains("labelExpired" + current.TabIndex))
                {
                    labelExpired = ((Label)item).Text;
                }
                else if (((Label)item).Name.Contains("labelHargaText" + current.TabIndex))
                {
                    labelHargaText = ((Label)item).Text;
                }
                else if (((Label)item).Name.Contains("labelHarga" + current.TabIndex))
                {
                    labelHarga = ((Label)item).Text;
                }
            }

            namaTextBox.Text = labelNama;
            expiredTextBox.Text = RotiHandler.ReformatExpired(labelExpired);
            hargaTextBox.Text = RotiHandler.ReformatHarga(labelHarga).ToString();
            RotiHandler.currentKodeJenisRoti = labelKode;
            editMode();
        }

        private void editMode()
        {
            SetButtonState(false, true, true, true);
        }
        private void insertMode()
        {
            SetButtonState(true, false, false, true);
        }
        private void clearListRoti()
        {
            List<RoundedPanel> panelsToRemove = new List<RoundedPanel>();

            foreach (Control control in this.Controls)
            {
                if (control is RoundedPanel)
                {
                    RoundedPanel panel = (RoundedPanel)control;
                    if (panel.BackColor == Color.Red || panel.BackColor == Color.Aqua)
                    {
                        panelsToRemove.Add(panel);
                    }
                }
            }

            foreach (RoundedPanel panel in panelsToRemove)
            {
                this.Controls.Remove(panel);
                rotiList.Remove(panel);
                panel.Dispose(); // Dispose of the panel if needed
            }
        }


        private void loadJenisRoti()
        {
            clearListRoti();
            List<jenis_roti> jenisRoti = RotiHandler.GetAllJenisRoti();
            int positionX = 0;
            int positionY = -1;
            int startX = 320;
            int startY = 8;
            for (int i = 0; i < jenisRoti.Count; i++)
            {
                // Update positionX based on the loop index
                positionX = i % 4;

                // Update positionY if positionX is even
                if (positionX % 4 == 0)
                {
                    positionY += 1;
                }

                // Create a panel
                RoundedPanel panel = new RoundedPanel();
                if (jenisRoti[i].status == 0)
                {
                    panel.BackColor = Color.Red;
                }
                else if (jenisRoti[i].status == 1)
                {
                    panel.BackColor = Color.Silver;
                }
                panel.Location = new Point(startX + (positionX * 216), startY + (positionY * 158));
                panel.Size = new Size(200, 150);
                panel.TabIndex = i; 
                panel.Click += new System.EventHandler(this.jenisRotiPanel_Click);
                panel.BorderStyle = BorderStyle.FixedSingle;
                this.Controls.Add(panel);

                // Create labels inside the panel
                Label labelKodeText = new Label();
                labelKodeText.Location = new System.Drawing.Point(10, 8);
                labelKodeText.Name = "labelKodeText" + i; 
                labelKodeText.Size = new System.Drawing.Size(59, 20);
                labelKodeText.TabIndex = i * 6; 
                labelKodeText.Text = "Kode";
                labelKodeText.Font = new System.Drawing.Font("Calibri", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                panel.Controls.Add(labelKodeText); 

                Label r1 = new Label();
                r1.Location = new System.Drawing.Point(75, 8);
                r1.Text = ":";
                r1.Size = new System.Drawing.Size(15, 20);
                r1.Font = new System.Drawing.Font("Calibri", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                panel.Controls.Add(r1);

                Label labelKode = new Label();
                labelKode.Location = new System.Drawing.Point(90, 8);
                labelKode.Name = "labelKode" + i; 
                labelKode.Size = new System.Drawing.Size(100, 20);
                labelKode.Font = new System.Drawing.Font("Calibri", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                labelKode.TabIndex = i * 6 + 1;

                //labelNama.Text = "Roti " + (i + 1); // Updated label text
                labelKode.Text = jenisRoti[i].kode_jenis;

                panel.Controls.Add(labelKode); 


                // Create labels inside the panel
                Label labelNameText = new Label();
                labelNameText.Location = new System.Drawing.Point(10, 40);
                labelNameText.Name = "labelNameText" + i;
                labelNameText.Size = new System.Drawing.Size(59, 20);
                labelNameText.TabIndex = i * 6;
                labelNameText.Text = "Nama";
                labelNameText.Font = new System.Drawing.Font("Calibri", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                panel.Controls.Add(labelNameText);

                Label r2 = new Label();
                r2.Location = new System.Drawing.Point(75, 40);
                r2.Text = ":";
                r2.Size = new System.Drawing.Size(15, 20);
                r2.Font = new System.Drawing.Font("Calibri", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                panel.Controls.Add(r2);

                Label labelNama = new Label();
                labelNama.Location = new System.Drawing.Point(90, 40);
                labelNama.Name = "labelNama" + i;
                labelNama.Size = new System.Drawing.Size(100, 20);
                labelNama.Font = new System.Drawing.Font("Calibri", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                labelNama.TabIndex = i * 6 + 1; 

                //labelNama.Text = "Roti " + (i + 1); // Updated label text
                labelNama.Text = jenisRoti[i].nama;

                panel.Controls.Add(labelNama); 

                Label labelExpiredText = new Label();
                labelExpiredText.Location = new System.Drawing.Point(10, 77);
                labelExpiredText.Name = "labelExpiredText" + i; 
                labelExpiredText.Size = new System.Drawing.Size(70, 20);
                labelExpiredText.TabIndex = i * 6 + 2; // Adjusted TabIndex
                labelExpiredText.Text = "Expired";
                labelExpiredText.Font = new System.Drawing.Font("Calibri", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                panel.Controls.Add(labelExpiredText); // Add the label to the panel

                Label r3 = new Label();
                r3.Location = new System.Drawing.Point(75, 77);
                r3.Text = ":";
                r3.Size = new System.Drawing.Size(15, 20);
                r3.Font = new System.Drawing.Font("Calibri", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                panel.Controls.Add(r3);

                Label labelExpired = new Label();
                labelExpired.Location = new System.Drawing.Point(90, 77);
                labelExpired.Name = "labelExpired" + i; // Unique name for each label
                labelExpired.Size = new System.Drawing.Size(54, 20);
                labelExpired.TabIndex = i * 6 + 3; // Adjusted TabIndex

                //labelExpired.Text = "00000";
                labelExpired.Text = jenisRoti[i].exp.ToString() + " " + RotiHandler.EXPIRED_SUFFIX;
                labelExpired.Font = new System.Drawing.Font("Calibri", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                panel.Controls.Add(labelExpired); // Add the label to the panel

                Label labelHargaText = new Label();
                labelHargaText.Location = new System.Drawing.Point(10, 118);
                labelHargaText.Name = "labelHargaText" + i; // Unique name for each label
                labelHargaText.Size = new System.Drawing.Size(55, 20);
                labelHargaText.TabIndex = i * 6 + 4; // Adjusted TabIndex
                labelHargaText.Text = "Harga";
                labelHargaText.Font = new System.Drawing.Font("Calibri", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                panel.Controls.Add(labelHargaText); // Add the label to the panel

                Label r4 = new Label();
                r4.Location = new System.Drawing.Point(75, 118);
                r4.Text = ": Rp";
                r4.Size = new System.Drawing.Size(40, 20);
                r4.Font = new System.Drawing.Font("Calibri", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                panel.Controls.Add(r4);

                Label labelHarga = new Label();
                labelHarga.Location = new System.Drawing.Point(110, 118);
                labelHarga.Name = "labelHarga" + i; // Unique name for each label
                labelHarga.Size = new System.Drawing.Size(60, 20);
                labelHarga.TabIndex = i * 6 + 5; // Adjusted TabIndex

                int harga = int.Parse(jenisRoti[i].harga.ToString());
                labelHarga.Text = RotiHandler.FormatHarga(harga);
                labelHarga.Font = new System.Drawing.Font("Calibri", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                panel.Controls.Add(labelHarga); // Add the label to the panel
            }
        }

        private void FormDaftarRoti_Load(object sender, EventArgs e)
        {
            loadJenisRoti();
            insertMode();
        }

        private void UpdateFixedPosition()
        {
            int fixedX = 12;
            int fixedY = 42;

            Point adjustedPoint = PointToClient(new Point(fixedX, fixedY));
            addNamaLabel.Location = new Point(adjustedPoint.X, adjustedPoint.Y);
        }


        private void FormDaftarRoti_Scroll(object sender, ScrollEventArgs e)
        {
            fixedPanel.Location = new System.Drawing.Point(10 + HorizontalScroll.Value, 10 + VerticalScroll.Value);
        }

        private void addPanel_Click(object sender, EventArgs e)
        {
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            clearState();
        }
        private void clearState()
        {
            insertMode();
            namaTextBox.Text = "";
            expiredTextBox.Text = "";
            hargaTextBox.Text = "";
            RotiHandler.ResetState();
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            if (namaTextBox.Text == "" || expiredTextBox.Text == "" || hargaTextBox.Text == "")
            {
                MessageBox.Show("Isi semua field");
                return;
            }
            if(int.TryParse(expiredTextBox.Text,out _) && int.TryParse(hargaTextBox.Text,out _)) { 
                RotiHandler.AddJenisRoti(namaTextBox.Text, int.Parse(hargaTextBox.Text), int.Parse(expiredTextBox.Text));
                MessageBox.Show("Berhasil menambahkan roti");
                clearState();
                loadJenisRoti();
            } else
            {
                MessageBox.Show("Format Invalid");
            }
            
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (namaTextBox.Text == "" || expiredTextBox.Text == "" || hargaTextBox.Text == "")
            {
                MessageBox.Show("Isi semua field");
                return;
            }
            if (!IsReadyToUpdate())
            {
                MessageBox.Show("Tidak siap untuk di update");
                return;
            }
            MessageBox.Show("Berhasil update roti");
            RotiHandler.UpdateJenisRoti(namaTextBox.Text, int.Parse(hargaTextBox.Text), int.Parse(expiredTextBox.Text));
            clearState();

            loadJenisRoti();
        }
        private bool IsReadyToUpdate()
        {
            if (RotiHandler.currentKodeJenisRoti == "")
            {
                return false;
            }
            jenis_roti jenisRoti = RotiHandler.GetCurrentJenisRoti();
            if (jenisRoti == null)
            {
                return false;
            }
            if (!int.TryParse(expiredTextBox.Text, out _) || !int.TryParse(hargaTextBox.Text,out _))
            {
                return false;
            }
            if (jenisRoti.status == 0 || (jenisRoti.nama == namaTextBox.Text && jenisRoti.exp == int.Parse(expiredTextBox.Text) && jenisRoti.harga == int.Parse(hargaTextBox.Text)))
            {
                return false;
            }

            return true;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (namaTextBox.Text == "" || expiredTextBox.Text == "" || hargaTextBox.Text == "")
            {
                MessageBox.Show("Isi semua field");
                return;
            }
            RotiHandler.DeleteJenisRoti();
            clearState();
            loadJenisRoti();
        }

        private void SetButtonState(bool insert, bool update, bool delete, bool clear)
        {
            insertButton.Enabled = insert;
            updateButton.Enabled = update;
            deleteButton.Enabled = delete;
            clearButton.Enabled = clear;
        }

    }

}
