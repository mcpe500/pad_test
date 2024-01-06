using PAD_ROTIKITA.Services;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PAD_ROTIKITA.Admin
{
    public partial class Admin_diskon_dialog : Form
    {
        List<string> selected;
        db_rotiEntities db = DatabaseService.GetDbContext();
        public Admin_diskon_dialog(List<string> selected)
        {
            InitializeComponent();
            this.selected = selected;
            comboBox.SelectedIndex = 0;
        }

        private void DialogDiskon_Load(object sender, EventArgs e)
        {
            dgv.DataSource = (from p in db.rotis
                              join j in db.jenis_roti on p.kode_jenis equals j.kode_jenis
                              where selected.Contains(p.kode_roti)
                              select new
                              {
                                  Kode = p.kode_roti,
                                  Nama = j.nama,
                                  Exp = p.expired_at,
                                  Harga = j.harga
                              }
                              ).ToList();
            dgv.Columns.Add(new DataGridViewTextBoxColumn());
            dgv.Columns.Add(new DataGridViewTextBoxColumn());

            dgv.Columns[4].Name = "Potongan";
            dgv.Columns[5].Name = "Harga Diskon";
            updateDGV();

        }

        private void cekMin()
        {
            int min = 999999999;
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if ((int)row.Cells[3].Value < min)
                {
                    min = (int)row.Cells[3].Value;
                }
            }
            num.Maximum = min;
        }

        public void updateDGV()
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (comboBox.Text == "%")
                {
                    row.Cells[4].Value = (int)row.Cells[3].Value * (int)num.Value / 100;

                }
                else
                {
                    row.Cells[4].Value = (int)num.Value;
                }

                row.Cells[5].Value = (int)row.Cells[3].Value - (int)row.Cells[4].Value;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox.SelectedIndex == 0) num.Maximum = 100;
            else cekMin();
            updateDGV();
        }

        private void num_ValueChanged(object sender, EventArgs e)
        {
            updateDGV();
        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
            if (keterangan.Text == string.Empty)
            {
                MessageBox.Show("Keterangan Tidak Boleh Kosong");
            }
            else if (num.Value == 0)
            {
                MessageBox.Show("Anda belum memasukkan diskon");
            }
            else
            {
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    diskon d = new diskon();
                    d.kode_roti = row.Cells[0].Value.ToString();
                    d.tanggal_selesai = Convert.ToDateTime(row.Cells[2].Value);
                    d.harga_before = (int)row.Cells[3].Value;
                    d.potongan = (int)row.Cells[4].Value;
                    d.harga_after = (int)row.Cells[5].Value;

                    d.kode_diskon = "D" + (db.diskons.ToList().Count + 1).ToString().PadLeft(9, '0');
                    d.tanggal_mulai = dateTimePicker1.Value;
                    d.nama = num.Value + " " + comboBox.Text;
                    d.keterangan = keterangan.Text;

                    db.diskons.Add(d);
                    db.SaveChanges();
                }

                MessageBox.Show("Berhasil menambahkan diskon");
                Close();
            }


        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value < DateTime.Now.Date)
            {
                MessageBox.Show("Tanggal harus sama atau lebih besar dari sekarang");
                dateTimePicker1.Value = DateTime.Now;
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
