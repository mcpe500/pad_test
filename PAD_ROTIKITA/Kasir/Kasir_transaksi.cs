using PAD_ROTIKITA.Contracts;
using PAD_ROTIKITA.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAD_ROTIKITA.Kasir
{
    public partial class Kasir_transaksi : Form
    {
        List<dbundle> bundles;
        public Kasir_transaksi()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void LoadListRoti()
        {
            List<RotiCartVisible> data = new List<RotiCartVisible>();

            foreach (RotiCartVisible r in RotiHandler.GetAllRotiInCart())
            {
                if (r.Name.IndexOf(textBox1.Text, StringComparison.OrdinalIgnoreCase) != -1)
                {
                    data.Add(r);
                }
            }

            listRotiGridView.DataSource = data;
            listRotiGridView.Columns["Expiration"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        }
        private void loadCart()
        {
            keranjangDataGridView.Columns["KodeRoti"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            keranjangDataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            keranjangDataGridView.Columns["Expiration"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        }
        private void reloadCart()
        {

        }

        private void Kasir_transaksi_Load(object sender, EventArgs e)
        {
            LoadListRoti();
            loadCart();
        }

        private void listRotiGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.listRotiGridView.Rows[e.RowIndex];
                string kodeRoti = row.Cells["Kode"].Value.ToString();
                string namaRoti = row.Cells["Name"].Value.ToString();
                string expired = row.Cells["Expiration"].Value.ToString();
                string stock = row.Cells["Quantity"].Value.ToString();
                string hargaRoti = row.Cells["Price"].Value.ToString();

                kodeRotiLabel.Text = kodeRoti;
                namaJenisRoti.Text = namaRoti;
                tanggalExpiredLabel.Text = Convert.ToDateTime(expired).Date.ToString();
                qtyNumericUpDown.Value = 0;
                qtyNumericUpDown.Maximum = int.Parse(stock);
                hargaLabel.Text = hargaRoti;
            }
        }
        private void addToCartButton_Click(object sender, EventArgs e)
        {
            string kode_roti = kodeRotiLabel.Text;
            string jenis_roti = namaJenisRoti.Text;
            string tanggal_expired = tanggalExpiredLabel.Text;
            int quantity_label = int.Parse(qtyNumericUpDown.Value.ToString());
            string harga_label = hargaLabel.Text;

            if (!ValidateInput(kode_roti, jenis_roti, tanggal_expired, harga_label, quantity_label))
            {
                return;
            }

            if (!UpdateCartIfItemExists(kode_roti, quantity_label))
            {
                AddNewItemToCart(kode_roti, jenis_roti, harga_label, quantity_label, tanggal_expired);
            }
            int diskonValue = RotiHandler.CekDiskon(kode_roti);
            if (diskonValue != 0)
            {
                bool exists = false;
                for (int i = 0; i < diskonDataGridView.Rows.Count; i++)
                {
                    DataGridViewRow item = diskonDataGridView.Rows[i];
                    if (item.Cells[0].Value.ToString().Equals(kode_roti))
                    {
                        diskonDataGridView.Rows[i].Cells[3].Value = int.Parse(item.Cells[3].Value.ToString()) + quantity_label;
                        diskonDataGridView.Rows[i].Cells[4].Value = diskonValue * int.Parse(diskonDataGridView.Rows[i].Cells[3].Value.ToString());
                        exists = true;
                    }
                }

                if (!exists)
                {
                    diskonDataGridView.Rows.Add(kode_roti, jenis_roti, diskonValue, quantity_label, diskonValue * quantity_label);
                }
            }
            handleCekBundles();
            UpdateCartSummary();
        }
        private void handleCekBundles()
        {
            List<string> listKodeRoti = new List<string>();
            for (int i = 0; i < keranjangDataGridView.Rows.Count; i++)
            {
                listKodeRoti.Add(keranjangDataGridView.Rows[i].Cells[1].Value.ToString());
            }
            bundles = RotiHandler.GetDbundles(listKodeRoti);

            List<string> ht_ids = new List<string>();
            List<dbundle> dbundle_on_ht_id = new List<dbundle>();
            foreach (dbundle item in bundles)
            {
                if (!ht_ids.Contains(item.kode_bundle))
                {
                    dbundle_on_ht_id.Add(item);
                }
                string kode_roti_ht = "";
                string jenis_roti_ht = "";
                string diskonValue_ht = "";
                string quantity_label_ht = "";
                string diskonValue_quantity_label = "";
            }
        }

        private bool ValidateInput(string kode_roti, string jenis_roti, string tanggal_expired, string harga_label, int quantity_label)
        {
            if (kode_roti == "" || jenis_roti == "" || tanggal_expired == "" || harga_label == "")
            {
                MessageBox.Show("Belum Memilih Roti");
                return false;
            }
            else if (quantity_label == 0)
            {
                MessageBox.Show("Quantity tidak boleh 0");
                return false;
            }
            else if (quantity_label > qtyNumericUpDown.Maximum)
            {
                MessageBox.Show("Quantity melebihi stock");
                return false;
            }
            return true;
        }

        private bool UpdateCartIfItemExists(string kode_roti, int quantity_label)
        {
            foreach (DataGridViewRow item in keranjangDataGridView.Rows)
            {
                if (item.Cells[0].Value.ToString().Equals(kode_roti))
                {
                    UpdateItemQuantityIfValid(item, kode_roti, quantity_label);
                    return true;
                }
            }
            return false;
        }

        private void UpdateItemQuantityIfValid(DataGridViewRow item, string kode_roti, int quantity_label)
        {
            string currentQty = item.Cells[3].Value.ToString();
            int currentQtyInt = int.Parse(currentQty) + quantity_label;
            if (IsQuantityValid(kode_roti, currentQtyInt))
            {
                item.Cells[3].Value = currentQtyInt;
                float harga = float.Parse(item.Cells[2].Value.ToString());
                item.Cells[5].Value = harga * currentQtyInt;
            }
            else
            {
                MessageBox.Show("Permintaan Melebihi Stok");
            }
        }

        private bool IsQuantityValid(string kode_roti, int currentQtyInt)
        {
            foreach (DataGridViewRow item in listRotiGridView.Rows)
            {
                if (item.Cells[0].Value.ToString().Equals(kode_roti))
                {
                    return int.Parse(item.Cells[3].Value.ToString()) >= currentQtyInt;
                }
            }
            return false;
        }

        private void AddNewItemToCart(string kode_roti, string jenis_roti, string harga_label, int quantity_label, string tanggal_expired)
        {
            float harga = float.Parse(harga_label);
            keranjangDataGridView.Rows.Add(kode_roti, jenis_roti, harga_label, quantity_label, tanggal_expired, quantity_label * harga);
        }

        private void UpdateCartSummary()
        {
            float totalHarga = 0;
            int jumlahItem = 0;
            foreach (DataGridViewRow item in keranjangDataGridView.Rows)
            {
                jumlahItem++;
                totalHarga += float.Parse(item.Cells[5].Value.ToString());
            }
            int totalDiskon = 0;
            foreach (DataGridViewRow item in diskonDataGridView.Rows)
            {
                //string kode = item.Cells[0].Value.ToString();
                //string namaRoti = item.Cells[1].Value.ToString();
                //int potonganPerQty = int.Parse(item.Cells[2].Value.ToString());
                //int quantity = int.Parse(item.Cells[3].Value.ToString());
                totalDiskon += int.Parse(item.Cells[4].Value.ToString());
                //diskonList.Add(new DiskonItemVo(kode, namaRoti, potonganPerQty, quantity, totalDiskon));
            }
            jumlahItemLabel.Text = jumlahItem.ToString();
            totalHargaLabel.Text = (totalHarga - totalDiskon).ToString();
        }

        private void butButton_Click(object sender, EventArgs e)
        {
            List<BuyRotiItemVo> cartList = new List<BuyRotiItemVo>();
            List<DiskonItemVo> diskonList = new List<DiskonItemVo>();
            foreach (DataGridViewRow item in keranjangDataGridView.Rows)
            {
                string kode = item.Cells[0].Value.ToString();
                string nama = item.Cells[1].Value.ToString();
                int harga = int.Parse(item.Cells[2].Value.ToString());
                int quantity = int.Parse(item.Cells[3].Value.ToString());
                int subtotal = int.Parse(item.Cells[5].Value.ToString());
                cartList.Add(new BuyRotiItemVo(kode, nama, harga, quantity, subtotal));
            }
            foreach (DataGridViewRow item in diskonDataGridView.Rows)
            {
                string kode = item.Cells[0].Value.ToString();
                string nama = item.Cells[1].Value.ToString();
                int harga = int.Parse(item.Cells[2].Value.ToString());
                int quantity = int.Parse(item.Cells[3].Value.ToString());
                int subtotal = int.Parse(item.Cells[4].Value.ToString());
                diskonList.Add(new DiskonItemVo(kode, nama, harga, quantity, subtotal));
            }
            int totalHarga = int.Parse(totalHargaLabel.Text);
            RotiHandler.BuyRoti(cartList, totalHarga, diskonList);
            keranjangDataGridView.Rows.Clear();
            diskonDataGridView.Rows.Clear();
            LoadListRoti();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (RotiHandler.HEADER_HTRANS.Length == 10)
            {
                Hide();
                FormStruk frS = new FormStruk(RotiHandler.HEADER_HTRANS);
                frS.ShowDialog();
                Show();
            }
            else
            {
                MessageBox.Show("BELUM MELAKUKAN TRANSAKSI");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void listRotiGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            LoadListRoti();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
        }
    }
}

