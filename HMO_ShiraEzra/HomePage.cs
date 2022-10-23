using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMO_ShiraEzra
{
    public partial class HomePage : Form
    {

        public HomePage()
        {
            InitializeComponent();
        }

        private void menu_users_Click(object sender, EventArgs e)
        {
            DisplayUsers du = new DisplayUsers();
            du.Show();
            this.Hide();
        }

    }
}
