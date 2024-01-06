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
    public partial class Admin_bundle_edit : Form
    {
        db_rotiEntities db = DatabaseService.GetDbContext();
        hbundle bundle;
        public Admin_bundle_edit(string id_bundle)
        {
            InitializeComponent();
            bundle = db.hbundles.Find(id_bundle);


        }

        private void Admin_bundle_edit_Load(object sender, EventArgs e)
        {
            dgv.DataSource = (from p in db.dbundles
                              join r in db.rotis on p.kode_roti equals r.kode_roti
                              join j in db.jenis_roti on r.kode_jenis equals j.kode_jenis
                              where p.kode_bundle == bundle.kode_bundle
                              select new
                              {
                                  p.kode_roti,
                                  j.nama,
                                  r.expired_at,
                                  p.harga_roti,
                                  p.qty,
                              }).ToList();
            kode_bundle.Text = bundle.kode_bundle;
            keterangan.Text = bundle.keterangan;
            total.Text = bundle.harga_before.ToString();
            harga_bundle.Maximum = bundle.harga_before.Value;
            harga_bundle.Value = (int)bundle.harga_after;

            date.Value = (DateTime)bundle.tanggal_mulai;
            potongan.Text = bundle.potongan.ToString();

            int item = 0;
            DateTime min = DateTime.Now.Date.AddMonths(1);
            DateTime max = DateTime.Now.Date.AddMonths(-1);

            foreach (DataGridViewRow row in dgv.Rows)
            {
                DateTime exp = Convert.ToDateTime(db.rotis.Find(row.Cells[0].Value.ToString()).expired_at);
                DateTime crt = Convert.ToDateTime(db.rotis.Find(row.Cells[0].Value.ToString()).created_at);
                if (exp < min)
                {
                    min = exp;
                }
                else if (crt > max){
                    max = crt;
                }
                item += (int)row.Cells[4].Value;
            }



            total_item.Text = item.ToString();
            date.MaxDate = min;
            date.MinDate = max;

        }

        private void total_item_Click(object sender, EventArgs e)
        {

        }

        private void potongan_Click(object sender, EventArgs e)
        {

        }

        private void harga_bundle_ValueChanged(object sender, EventArgs e)
        {
            potongan.Text = (bundle.harga_before - harga_bundle.Value).ToString();
        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
            if (keterangan.Text == string.Empty)
            {
                MessageBox.Show("Keterangan Tidak Boleh Kosong");
            }
            else
            {
                bundle.keterangan = keterangan.Text;
                bundle.harga_after = (int)harga_bundle.Value;
                bundle.potongan = Convert.ToInt32(potongan.Text);
                bundle.tanggal_mulai = date.Value;
                db.SaveChanges();
                bundle = null;
                Close();
            }
        }

        private void btn_hapus_Click(object sender, EventArgs e)
        {
            bundle.tanggal_selesai = DateTime.Now;
            db.SaveChanges();
            bundle = null;
            Close();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
