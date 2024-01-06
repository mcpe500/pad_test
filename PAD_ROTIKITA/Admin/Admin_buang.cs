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
    public partial class Admin_buang : Form
    {
        db_rotiEntities db = DatabaseService.GetDbContext();
        public Admin_buang()
        {
            InitializeComponent();
        }

        private void Admin_buang_Load(object sender, EventArgs e)
        {
            load_dgv_roti();
            load_dgv_buang();
        }

        private void load_dgv_roti()
        {
            dgv_roti.Columns.Clear();
            dgv_roti.Columns.Add(new DataGridViewCheckBoxColumn());
            dgv_roti.DataSource = (from p in db.rotis
                                   join j in db.jenis_roti on p.kode_jenis equals j.kode_jenis
                                   where p.qty > 0 && p.expired_at < DateTime.Now
                                   select new
                                   {
                                       Kode_Produksi = p.kode_roti,
                                       Kode_Roti = p.kode_jenis,
                                       Nama_Roti = j.nama,
                                       QTY = p.qty,
                                       Harga = j.harga,
                                       Tanggal_Produksi = p.created_at,
                                       Tanggal_Expired = p.expired_at
                                   }).ToList();


            dgv_roti.AutoResizeColumn(0, DataGridViewAutoSizeColumnMode.AllCells);
            dgv_roti.AutoResizeColumn(4, DataGridViewAutoSizeColumnMode.AllCells);

            dgv_roti.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv_roti.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv_roti.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void load_dgv_buang()
        {
            dgv_buang.DataSource = (from p in db.buangs
                                    join j in db.jenis_roti on p.kode_jenis equals j.kode_jenis
                                    select new
                                    {
                                        Kode_Pembuangan = p.kode_buang,
                                        Kode_Roti = p.kode_jenis,
                                        Nama_Roti = j.nama,
                                        QTY = p.qty,
                                        Harga = p.harga,
                                        Tanggal_Dibuang = p.dibuang_at
                                    }).ToList();
        }

        private void dgv_roti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_hapus_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgv_roti.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value))
                {
                    roti r = db.rotis.Find(row.Cells[1].Value.ToString());
                    r.qty = 0;
                    db.SaveChanges();

                    buang b = new buang();
                    b.kode_buang = "Buang" + (db.buangs.ToList().Count + 1).ToString().PadLeft(5, '0');
                    b.kode_roti = row.Cells[1].Value.ToString();
                    b.kode_jenis = row.Cells[2].Value.ToString();
                    b.nama_roti = row.Cells[3].Value.ToString();
                    b.harga = (int)row.Cells[5].Value;
                    b.qty = (int)row.Cells[4].Value;
                    b.subtotal = b.harga * b.qty;
                    b.created_at = (DateTime)row.Cells[6].Value;
                    b.expired_at = (DateTime)row.Cells[7].Value;
                    b.dibuang_at = DateTime.Now;

                    db.buangs.Add(b);
                    db.SaveChanges();
                }
            }
            load_dgv_roti();
            load_dgv_buang();
        }

        private void btn_hapus_Click_1(object sender, EventArgs e)
        {

        }
    }
}
