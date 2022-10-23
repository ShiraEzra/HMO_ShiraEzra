using BLL;
using DAL;
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
    public partial class UserDetails : Form
    {
        public HMOEntities db { get; set; } = HMOEntities.Instance;

        public User User { get; set; }
        public Type Type { get; set; }
        public int numMonthVaccinationValidity {get; set;}
        public int DaysDurationCoronaDisease { get; set; }

        public UserDetails()
        {
            InitializeComponent();
            this.numMonthVaccinationValidity = 6;
            this.DaysDurationCoronaDisease = 7;
        }

        public UserDetails(User u, Type t):this()
        {
            this.User = u;
            this.Type = t;
            showDetails();
        }

        public UserDetails(Type t):this()
        {
            this.Type = t;
            this.User = new User();
        }

        private void showDetails()
        {
            firstName_txt.Text = this.User.FirstName_user.ToString().Trim();
            firstName_txt.Text = this.User.FirstName_user;
            lastName_txt.Text = this.User.LastName_user;
            id_txt.Text = this.User.ID_user;
            dateOfBirth_dtp.Value = this.User.DateOfBirth_user;
            city_txt.Text = this.User.City_user;
            address_txt.Text = this.User.Address_user;
            isVaccinated_cb.Checked = isVaccinatioValidity();
            isNegative_cb.Checked = isNegative();

            initVaccinationsCMB();
            initCoronaTestsCMB();
        }

        private void initCoronaTestsCMB()
        {
            var userCoronaTests = this.db.UserPerCoronaTest.Where(x => x.CodeUser_userPerCT == this.User.Code_user).ToArray();
            coronaTests_cmb.Items.AddRange(userCoronaTests);
        }

        private void initVaccinationsCMB()
        {
            var userVaccinations = this.db.UserPerVaccination.Where(x => x.CodeUser_userPerVacc == this.User.Code_user).ToArray();
            vaccinations_cmb.Items.AddRange(userVaccinations);
        }

        private bool isNegative()
        {
            var coronaTests = this.db.UserPerCoronaTest.Where(x => x.CodeUser_userPerCT == this.User.Code_user).ToList();
            UserPerCoronaTest lastCoronaTest = coronaTests.LastOrDefault();
            if (lastCoronaTest == null || lastCoronaTest.Result_userPerCT==false)
                return true;

            return lastCoronaTest.Date_userPerCT.AddDays(this.DaysDurationCoronaDisease) < DateTime.Today;
        }

        private bool isVaccinatioValidity()
        {
            var vaccinations= this.db.UserPerVaccination.Where(x => x.CodeUser_userPerVacc == this.User.Code_user).ToList();
            UserPerVaccination lastVaccination = vaccinations.LastOrDefault();
            if (lastVaccination == null)
                return false;
            return lastVaccination.Date_userPerVacc.AddMonths(this.numMonthVaccinationValidity) >= DateTime.Today;
        }

        private void menu_users_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            if (this.Type == Type.Add)
                clearControls();
            else
                showDetails();
        }

        private void clearControls()
        {
            firstName_txt.Text = "";
            firstName_txt.Text = "";
            lastName_txt.Text = "";
            id_txt.Text = "";
            dateOfBirth_dtp.Value = DateTime.Today;
            city_txt.Text = "";
            address_txt.Text = "";
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            if(save())
            {
                if (this.Type == Type.Add)
                    this.User.Add();
                else
                    this.User.Update();

                MessageBox.Show("הפעולה בוצעה בהצלחה", "אישור");
            }
        }

        private bool save()
        {
            bool ok = true;
            errorProvider1.Clear();
            try
            {
                this.User.FirstName_user = firstName_txt.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(firstName_txt, ex.Message);
                ok = false;
            }

            try
            {
                this.User.LastName_user = lastName_txt.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(lastName_txt, ex.Message);
                ok = false;
            }

            try
            {
                if(!Validateutil.LegalId(id_txt.Text))
                {
                    errorProvider1.SetError(id_txt, "ת.ז לא חוקית");
                    ok = false;
                }
                this.User.ID_user = id_txt.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(id_txt, ex.Message);
                ok = false;
            }

            try
            {
                if(dateOfBirth_dtp.Value> DateTime.Today)
                {
                    errorProvider1.SetError(dateOfBirth_dtp, "תאריך לידה לא חוקי");
                    ok = false;
                }
                this.User.DateOfBirth_user = dateOfBirth_dtp.Value;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(dateOfBirth_dtp, ex.Message);
                ok = false;
            }

            try
            {
                this.User.City_user = city_txt.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(city_lbl, ex.Message);
                ok = false;
            }

            try
            {
                this.User.Address_user = address_txt.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(address_txt, ex.Message);
                ok = false;
            }

            return ok;
        }

    }
}