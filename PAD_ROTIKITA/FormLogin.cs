using PAD_ROTIKITA.Services;
using PAD_ROTIKITA;
using PAD_ROTIKITA.Controller;
using PAD_ROTIKITA.Admin;
using PAD_ROTIKITA.Kasir;
using PAD_ROTIKITA.Owner;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAD_ROTIKITA
{
    public partial class FormLogin : Form
    {
        private db_rotiEntities db = DatabaseService.GetDbContext();
        public FormLogin()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (TBUserID.Text == "Owner" && TBPassword.Text == "Owner")
            {
                UserHandler.user_ID = "OWNER";
                UserHandler.nama = "Owner";
                UserHandler.user_ID = "OWNER00000";
                UserHandler.role = "Owner";
                Owner_menu form = new Owner_menu();
                Hide();
                form.ShowDialog();
                Show();
                resetInput();
            }
            else
            {
                if (!UserHandler.LoginHandler(TBUserID.Text, TBPassword.Text))
                {
                    MessageBox.Show("Salah Login");
                }
                else
                {
                    Hide();
                    if (UserHandler.role == "Admin")
                    {
                        Admin_menu admin_Menu = new Admin_menu();
                        admin_Menu.ShowDialog();
                        resetInput();

                    }
                    else
                    {
                        Kasir_menu kasir_Menu = new Kasir_menu();
                        kasir_Menu.ShowDialog();
                        resetInput();
                    }
                    Show();
                }
            }
        }
        private void resetInput()
        {
            TBUserID.Text = "";
            TBPassword.Text = "";
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }

}
