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
    public partial class Kasir_history : Form
    {
        public Kasir_history()
        {
            InitializeComponent();
            dari.MaxDate = DateTime.Now.Date;
            sampai.MaxDate = DateTime.Now.Date;
            dari.Value = DateTime.Now.Date;
            sampai.Value = DateTime.Now.Date;
        }

        private void Kasir_history_Load(object sender, EventArgs e)
        {
            
        }

        private void dari_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
