using PAD_ROTIKITA.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAD_ROTIKITA.Admin
{
    public partial class Admin_menu : Form
    {
        public Admin_menu()
        {
            InitializeComponent();
        }

        private void Admin_menu_Load(object sender, EventArgs e)
        {
            nama.Text = UserHandler.nama;
        }

        private void btn_daftar_Click(object sender, EventArgs e)
        {
            Hide();
            Admin_daftar admin_Daftar = new Admin_daftar();
            admin_Daftar.ShowDialog();
            Show();
        }

        private void btn_tambah_Click(object sender, EventArgs e)
        {
            Hide();
            Admin_tambah admin_Tambah = new Admin_tambah();
            admin_Tambah.ShowDialog();
            Show();
        }

        private void btn_buang_Click(object sender, EventArgs e)
        {
            Hide();
            Admin_buang admin_Buang = new Admin_buang();
            admin_Buang.ShowDialog();
            Show();
        }

        private void btn_diskon_Click(object sender, EventArgs e)
        {
            Hide();
            Admin_diskon admin_Diskon = new Admin_diskon();
            admin_Diskon.ShowDialog();
            Show();
        }

        private void btn_history_Click(object sender, EventArgs e)
        {
            //Hide();
            //FormHistory formHistory = new FormHistory();
            //formHistory.ShowDialog();
            //Show();
        }


        private void btn_logout_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
