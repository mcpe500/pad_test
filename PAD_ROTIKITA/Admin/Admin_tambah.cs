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

namespace PAD_ROTIKITA.Admin
{
    public partial class Admin_tambah : Form
    {
        public Admin_tambah()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }


        private void loadListJenisRoti()
        {
            jenisRotiGriwView.DataSource = RotiHandler.GetAllJenisRotiActive();
        }
        private void loadListRoti()
        {
            var all = RotiHandler.GetAllRoti().ToList();
            List<RotiVisible> selected = new List<RotiVisible>();

            foreach (RotiVisible j in all)
            {
                if (j.Expiration.Date > DateTime.Now.Date && j.Quantity > 0)
                {
                    selected.Add(j);
                }
            }

            listRotiGridView.DataSource = selected;

            listRotiGridView.Columns["Expiration"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        }


        private void addRotiButton_Click(object sender, EventArgs e)
        {
            string kodeJenis = TBJenisRoti.Text;
            int quantity = 0;
            try
            {
                quantity = int.Parse(qtyNumericUpDown.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Quantity harus angka" + ex.Message);
                return;
            }
            RotiHandler.AddRoti(kodeJenis, quantity);
            clear();
            loadListRoti();
        }


        private void jenisRotiGriwView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.jenisRotiGriwView.Rows[e.RowIndex];
                string kodeJenis = row.Cells["JenisCode"].Value.ToString();
                RotiHandler.currentKodeJenisRoti = kodeJenis;
                TBJenisRoti.Text = kodeJenis;
                TBKodeRoti.Text = string.Empty;
                qtyNumericUpDown.Value = 0;
                loadListJenisRoti();
                AddMode();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RotiHandler.DeleteAllRoti();
        }

        private void listRotiGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                TBJenisRoti.Text = listRotiGridView.Rows[e.RowIndex].Cells["JenisCode"].Value.ToString();
                TBKodeRoti.Text = listRotiGridView.Rows[e.RowIndex].Cells["KodeRoti"].Value.ToString();
                qtyNumericUpDown.Value = int.Parse(listRotiGridView.Rows[e.RowIndex].Cells["Quantity"].Value.ToString());
                EditMode();
            }
        }
        private void EditMode()
        {
            addRotiButton.Enabled = false;
            editRotiButton.Enabled = true;
        }

        private void AddMode()
        {
            addRotiButton.Enabled = true;
            editRotiButton.Enabled = false;
        }
        private void clear()
        {
            TBJenisRoti.Text = "";
            TBKodeRoti.Text = "";
            qtyNumericUpDown.Value = 0;
            AddMode();
        }

        private void editRotiButton_Click(object sender, EventArgs e)
        {
            string kodeRoti = TBKodeRoti.Text;
            int quantity = 0;
            try
            {
                quantity = int.Parse(qtyNumericUpDown.Text);
            }
            catch
            {
                MessageBox.Show("Quantity harus angka");
                return;
            }
            RotiHandler.EditRoti(TBKodeRoti.Text, quantity);
            clear();
            loadListRoti();
        }

        private void Admin_tambah_Load(object sender, EventArgs e)
        {
            loadListJenisRoti();
            loadListRoti();
        }

       

        private void jenisRotiGriwView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
