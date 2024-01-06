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
    public partial class Kasir_menu : Form
    {
        public Kasir_menu()
        {
            InitializeComponent();
            nama.Text = UserHandler.nama;
        }

        private void btn_transaksi_Click(object sender, EventArgs e)
        {
            Hide();
            Kasir_transaksi kasir_Transaksi = new Kasir_transaksi();
            kasir_Transaksi.ShowDialog();
            Show();
        }

        private void btn_history_Click(object sender, EventArgs e)
        {
            //Hide();
            //FormHistory owner_History = new FormHistory();
            //owner_History.ShowDialog();
            //Show();
        }

        private void Kasir_menu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
