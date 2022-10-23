using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;

namespace HMO_ShiraEzra
{
    public enum Type: byte { Display, Update, Add};
    public partial class DisplayUsers : Form
    {
        UserRetrieval userRetrieval = new UserRetrieval();
        public DisplayUsers()
        {
            InitializeComponent();
            initDG();

        }

        private void initDG()
        {
            List<User> users_lst = userRetrieval.GetUsers();
            users_dg.DataSource = users_lst.Select(x => new
            {
                //קוד_לקוח = x.Code_user
                שם_פרטי = x.FirstName_user
                ,
                שם_משפחה = x.LastName_user
               ,
                תעודת_זהות = x.ID_user
                //  ,תאריך_לידה = x.DateOfBirth_user
                //  ,עיר_מגורים = x.City_user
                //  ,כתובת = x.Address_user
            }).ToList();
        }

        private void logo_lbl_Click(object sender, EventArgs e)
        {
            HomePage hm = new HomePage();
            hm.Show();
            this.Hide();
        }

        private void menu_users_Click(object sender, EventArgs e)
        {

        }

        private void users_dg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void display_btn_Click(object sender, EventArgs e)
        {
            User u = getSelectedUser();
            if (u == null)
                showErrorMsg();
            else
            {
                UserDetails ud = new UserDetails(u, Type.Display);
                ud.Show();
            }
        }

        private void showErrorMsg()
        {
            MessageBox.Show("עליך לבחור לקוח מסוים מהטבלה", "שים לב!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
        }

        private User getSelectedUser()
        {
            User u = null;
            if (users_dg.SelectedRows.Count > 0)
            {
                String id = users_dg.SelectedRows[0].Cells[2].Value.ToString();
                u = userRetrieval.getBuID(id);
            }
            return u;
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            User u = getSelectedUser();
            if (u == null)
                showErrorMsg();
            else
            {
                UserDetails ud = new UserDetails(u, Type.Update);
                ud.Show();
            }
        }

        private void new_btn_Click(object sender, EventArgs e)
        {
            UserDetails ud = new UserDetails(Type.Add);
            ud.Show();
        }

        private void refresh_lnklbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            initDG();
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            User u = getSelectedUser();
            if (u == null)
                showErrorMsg();
            else
            {
                DialogResult r = MessageBox.Show("האם למחוק לקוח זה?", "אישור מחיקה",MessageBoxButtons.YesNo, MessageBoxIcon.Question,MessageBoxDefaultButton.Button1);
                if (r == DialogResult.Yes)
                {
                    u.Delete();
                    MessageBox.Show("הלקוח נמחק בהצלחה", "אישור מחיקה");
                    initDG();
                }
            }
        }
    }
}
