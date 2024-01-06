using PAD_ROTIKITA.Contracts;
using PAD_ROTIKITA.Controller;
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

namespace PAD_ROTIKITA.Owner
{
    public partial class Owner_register : Form
    {
        public Owner_register()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            loadListUser();
        }

        private db_rotiEntities db = DatabaseService.GetDbContext();


        private void loadListUser()
        {
            listPegawaiView.DataSource = UserHandler.GetAllUsersVisible();
        }
        public void clearInput()
        {
            TBNamaPegawai.Text = "";
            TBPassPegawai.Text = "";
            kasirRadioButton.Checked = false;
            adminRadioButton.Checked = false;
        }
        private void menuDaftarRotiButton_Click(object sender, EventArgs e)
        {
            string namaPegawai = TBNamaPegawai.Text;
            string password = TBPassPegawai.Text;
            string role = "";
            if (kasirRadioButton.Checked)
            {
                role = UserRole.KASIR;
            }
            else if (adminRadioButton.Checked)
            {
                role = UserRole.ADMIN;
            }
            UserHandler.AddUser(namaPegawai, password, role);
            loadListUser();
            clearInput();
        }

        private void Owner_register_Load(object sender, EventArgs e)
        {

        }
    }
}
