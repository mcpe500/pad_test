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

namespace PAD_ROTIKITA.Admin

{
    public partial class Admin_bundle : Form
    {
        List<string> selected;
        db_rotiEntities db = DatabaseService.GetDbContext();
        int totalint;
        public Admin_bundle(List<string> selected)
        {
            InitializeComponent();
            this.selected = selected;
            dgv.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;
            date.MinDate = DateTime.Now;
        }

        private DateTime expMin()
        {
            DateTime min = DateTime.Now.Date.AddMonths(1);
            foreach (string oke in selected)
            {
                DateTime exp = Convert.ToDateTime(db.rotis.Find(oke).expired_at);
                if (exp < min)
                {
                    min = exp;
                }
            }
            return min;
        }

        private void Admin_bundle_Load(object sender, EventArgs e)
        {
            dgv.DataSource = (from p in db.rotis
                              join j in db.jenis_roti on p.kode_jenis equals j.kode_jenis
                              where selected.Contains(p.kode_roti)
                              select new
                              {
                                  Kode = p.kode_roti,
                                  Nama = j.nama,
                                  Exp = p.expired_at,
                                  Harga = j.harga,
                              }
                              ).ToList();
            kode_bundle.Text = "Bundle" + (db.hbundles.ToList().Count + 1).ToString().PadLeft(4, '0');

            dgv.Columns.Add(new DataGridViewTextBoxColumn());
            dgv.Columns[dgv.ColumnCount - 1].Name = "Jumlah Item";
            foreach (DataGridViewRow row in dgv.Rows) row.Cells[4].Value = 1;
            setTotal();
            date.MaxDate = expMin();
            harga_bundle.Value = Convert.ToInt16(total.Text);
        }

        private void dgv_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                if (!int.TryParse(e.FormattedValue.ToString(), out _))
                {
                    e.Cancel = true;
                    MessageBox.Show("Please enter a valid number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    setTotal();
                }
            }
        }
        public void setTotal()
        {
            totalint = 0;
            int item = 0;
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                totalint += Convert.ToInt16(dgv.Rows[i].Cells[3].Value) * Convert.ToInt16(dgv.Rows[i].Cells[4].Value);
                item += Convert.ToInt16(dgv.Rows[i].Cells[4].Value);
            }
            total.Text = totalint.ToString();
            potongan.Text = (totalint - harga_bundle.Value).ToString();
            total_item.Text = item.ToString();
            harga_bundle.Maximum = totalint;
        }

        private void kode_bundle_Click(object sender, EventArgs e)
        {

        }

        private void total_Click(object sender, EventArgs e)
        {

        }

        private void date_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dgv_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            setTotal();
        }

        private void total_TextChanged(object sender, EventArgs e)
        {
            //potongan.Text = (Convert.ToInt32(total.Text) - harga_bundle.Value).ToString();
        }

        private void harga_bundle_ValueChanged(object sender, EventArgs e)
        {
            setTotal();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
            if (keterangan.Text == string.Empty)
            {
                MessageBox.Show("Keterangan tidak boleh kosong");
            }
            else
            {
                hbundle h = new hbundle();
                h.kode_bundle = kode_bundle.Text;
                h.harga_before = Convert.ToInt16(total.Text);
                h.harga_after = Convert.ToInt16(harga_bundle.Value);
                h.potongan = Convert.ToInt16(potongan.Text);
                h.tanggal_mulai = date.Value;
                h.tanggal_selesai = expMin();
                h.keterangan = keterangan.Text;
                db.hbundles.Add(h);
                db.SaveChanges();

                foreach (DataGridViewRow row in dgv.Rows)
                {
                    dbundle d = new dbundle();
                    d.kode_dbundle = "DB" + (db.dbundles.ToList().Count + 1).ToString().PadLeft(8, '0');
                    d.kode_bundle = h.kode_bundle;
                    d.kode_roti = row.Cells[0].Value.ToString();
                    d.qty = Convert.ToInt16(row.Cells[4].Value);
                    d.harga_roti = (int)row.Cells[3].Value;
                    db.dbundles.Add(d);
                    db.SaveChanges();
                }
                MessageBox.Show("Berhasil Menambahkan Bunddle");
                Close();
            }
        }

        private void total_item_Click(object sender, EventArgs e)
        {

        }

        private void dgv_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void keterangan_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
