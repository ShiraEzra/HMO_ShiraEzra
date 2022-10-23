
namespace HMO_ShiraEzra
{
    partial class UserDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu_users = new System.Windows.Forms.ToolStripMenuItem();
            this.logo1_lbl = new System.Windows.Forms.Label();
            this.logo_lbl = new System.Windows.Forms.Label();
            this.details_gb = new System.Windows.Forms.GroupBox();
            this.isNegative_cb = new System.Windows.Forms.CheckBox();
            this.isVaccinated_cb = new System.Windows.Forms.CheckBox();
            this.dateOfBirth_dtp = new System.Windows.Forms.DateTimePicker();
            this.address_txt = new System.Windows.Forms.TextBox();
            this.city_txt = new System.Windows.Forms.TextBox();
            this.id_txt = new System.Windows.Forms.TextBox();
            this.lastName_txt = new System.Windows.Forms.TextBox();
            this.firstName_txt = new System.Windows.Forms.TextBox();
            this.address_lbl = new System.Windows.Forms.Label();
            this.city_lbl = new System.Windows.Forms.Label();
            this.dateOfBirth_lbl = new System.Windows.Forms.Label();
            this.id_lbl = new System.Windows.Forms.Label();
            this.lastName_lbl = new System.Windows.Forms.Label();
            this.firstName_lbl = new System.Windows.Forms.Label();
            this.MedicalInformation_gb = new System.Windows.Forms.GroupBox();
            this.addCoronaTest_btn = new System.Windows.Forms.Button();
            this.addVacc_btn = new System.Windows.Forms.Button();
            this.coronaTests_cmb = new System.Windows.Forms.ComboBox();
            this.coronaTests_lbl = new System.Windows.Forms.Label();
            this.vaccinations_cmb = new System.Windows.Forms.ComboBox();
            this.vaccinations_lbl = new System.Windows.Forms.Label();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStrip1.SuspendLayout();
            this.details_gb.SuspendLayout();
            this.MedicalInformation_gb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_users});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(1056, 47);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menu_users
            // 
            this.menu_users.Font = new System.Drawing.Font("Kristen ITC", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_users.Name = "menu_users";
            this.menu_users.Size = new System.Drawing.Size(171, 43);
            this.menu_users.Text = "חברי הקופה";
            this.menu_users.Click += new System.EventHandler(this.menu_users_Click);
            // 
            // logo1_lbl
            // 
            this.logo1_lbl.AutoSize = true;
            this.logo1_lbl.Font = new System.Drawing.Font("Freestyle Script", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logo1_lbl.Location = new System.Drawing.Point(12, 125);
            this.logo1_lbl.Name = "logo1_lbl";
            this.logo1_lbl.Size = new System.Drawing.Size(225, 28);
            this.logo1_lbl.TabIndex = 8;
            this.logo1_lbl.Text = "Health Maintenance Organization";
            // 
            // logo_lbl
            // 
            this.logo_lbl.AutoSize = true;
            this.logo_lbl.Font = new System.Drawing.Font("Segoe Print", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logo_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.logo_lbl.Location = new System.Drawing.Point(-2, 12);
            this.logo_lbl.Name = "logo_lbl";
            this.logo_lbl.Size = new System.Drawing.Size(264, 141);
            this.logo_lbl.TabIndex = 7;
            this.logo_lbl.Text = "HMO";
            // 
            // details_gb
            // 
            this.details_gb.Controls.Add(this.isNegative_cb);
            this.details_gb.Controls.Add(this.isVaccinated_cb);
            this.details_gb.Controls.Add(this.dateOfBirth_dtp);
            this.details_gb.Controls.Add(this.address_txt);
            this.details_gb.Controls.Add(this.city_txt);
            this.details_gb.Controls.Add(this.id_txt);
            this.details_gb.Controls.Add(this.lastName_txt);
            this.details_gb.Controls.Add(this.firstName_txt);
            this.details_gb.Controls.Add(this.address_lbl);
            this.details_gb.Controls.Add(this.city_lbl);
            this.details_gb.Controls.Add(this.dateOfBirth_lbl);
            this.details_gb.Controls.Add(this.id_lbl);
            this.details_gb.Controls.Add(this.lastName_lbl);
            this.details_gb.Controls.Add(this.firstName_lbl);
            this.details_gb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.details_gb.ForeColor = System.Drawing.Color.Fuchsia;
            this.details_gb.Location = new System.Drawing.Point(691, 125);
            this.details_gb.Name = "details_gb";
            this.details_gb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.details_gb.Size = new System.Drawing.Size(289, 413);
            this.details_gb.TabIndex = 10;
            this.details_gb.TabStop = false;
            this.details_gb.Text = "פרטים אישיים";
            // 
            // isNegative_cb
            // 
            this.isNegative_cb.AutoSize = true;
            this.isNegative_cb.Enabled = false;
            this.isNegative_cb.ForeColor = System.Drawing.Color.Black;
            this.isNegative_cb.Location = new System.Drawing.Point(122, 367);
            this.isNegative_cb.Name = "isNegative_cb";
            this.isNegative_cb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.isNegative_cb.Size = new System.Drawing.Size(139, 24);
            this.isNegative_cb.TabIndex = 13;
            this.isNegative_cb.TabStop = false;
            this.isNegative_cb.Text = "שלילי לקורונה?";
            this.isNegative_cb.UseVisualStyleBackColor = true;
            // 
            // isVaccinated_cb
            // 
            this.isVaccinated_cb.AutoSize = true;
            this.isVaccinated_cb.Enabled = false;
            this.isVaccinated_cb.ForeColor = System.Drawing.Color.Black;
            this.isVaccinated_cb.Location = new System.Drawing.Point(131, 333);
            this.isVaccinated_cb.Name = "isVaccinated_cb";
            this.isVaccinated_cb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.isVaccinated_cb.Size = new System.Drawing.Size(130, 24);
            this.isVaccinated_cb.TabIndex = 12;
            this.isVaccinated_cb.Text = "מחוסן בתוקף?";
            this.isVaccinated_cb.UseVisualStyleBackColor = true;
            // 
            // dateOfBirth_dtp
            // 
            this.dateOfBirth_dtp.Location = new System.Drawing.Point(26, 181);
            this.dateOfBirth_dtp.Name = "dateOfBirth_dtp";
            this.dateOfBirth_dtp.Size = new System.Drawing.Size(111, 27);
            this.dateOfBirth_dtp.TabIndex = 11;
            // 
            // address_txt
            // 
            this.address_txt.Location = new System.Drawing.Point(26, 270);
            this.address_txt.Name = "address_txt";
            this.address_txt.Size = new System.Drawing.Size(111, 27);
            this.address_txt.TabIndex = 10;
            // 
            // city_txt
            // 
            this.city_txt.Location = new System.Drawing.Point(26, 224);
            this.city_txt.Name = "city_txt";
            this.city_txt.Size = new System.Drawing.Size(111, 27);
            this.city_txt.TabIndex = 9;
            // 
            // id_txt
            // 
            this.id_txt.Location = new System.Drawing.Point(26, 135);
            this.id_txt.Name = "id_txt";
            this.id_txt.Size = new System.Drawing.Size(111, 27);
            this.id_txt.TabIndex = 8;
            // 
            // lastName_txt
            // 
            this.lastName_txt.Location = new System.Drawing.Point(26, 88);
            this.lastName_txt.Name = "lastName_txt";
            this.lastName_txt.Size = new System.Drawing.Size(111, 27);
            this.lastName_txt.TabIndex = 7;
            // 
            // firstName_txt
            // 
            this.firstName_txt.Location = new System.Drawing.Point(26, 44);
            this.firstName_txt.Name = "firstName_txt";
            this.firstName_txt.Size = new System.Drawing.Size(111, 27);
            this.firstName_txt.TabIndex = 6;
            // 
            // address_lbl
            // 
            this.address_lbl.AutoSize = true;
            this.address_lbl.ForeColor = System.Drawing.Color.Black;
            this.address_lbl.Location = new System.Drawing.Point(200, 272);
            this.address_lbl.Name = "address_lbl";
            this.address_lbl.Size = new System.Drawing.Size(58, 20);
            this.address_lbl.TabIndex = 5;
            this.address_lbl.Text = "כתובת:";
            // 
            // city_lbl
            // 
            this.city_lbl.AutoSize = true;
            this.city_lbl.ForeColor = System.Drawing.Color.Black;
            this.city_lbl.Location = new System.Drawing.Point(170, 227);
            this.city_lbl.Name = "city_lbl";
            this.city_lbl.Size = new System.Drawing.Size(90, 20);
            this.city_lbl.TabIndex = 4;
            this.city_lbl.Text = "עיר מגורים:";
            // 
            // dateOfBirth_lbl
            // 
            this.dateOfBirth_lbl.AutoSize = true;
            this.dateOfBirth_lbl.ForeColor = System.Drawing.Color.Black;
            this.dateOfBirth_lbl.Location = new System.Drawing.Point(170, 186);
            this.dateOfBirth_lbl.Name = "dateOfBirth_lbl";
            this.dateOfBirth_lbl.Size = new System.Drawing.Size(95, 20);
            this.dateOfBirth_lbl.TabIndex = 3;
            this.dateOfBirth_lbl.Text = "תאריך לידה:";
            // 
            // id_lbl
            // 
            this.id_lbl.AutoSize = true;
            this.id_lbl.ForeColor = System.Drawing.Color.Black;
            this.id_lbl.Location = new System.Drawing.Point(225, 140);
            this.id_lbl.Name = "id_lbl";
            this.id_lbl.Size = new System.Drawing.Size(39, 20);
            this.id_lbl.TabIndex = 2;
            this.id_lbl.Text = "ת.ז.:";
            // 
            // lastName_lbl
            // 
            this.lastName_lbl.AutoSize = true;
            this.lastName_lbl.ForeColor = System.Drawing.Color.Black;
            this.lastName_lbl.Location = new System.Drawing.Point(175, 95);
            this.lastName_lbl.Name = "lastName_lbl";
            this.lastName_lbl.Size = new System.Drawing.Size(90, 20);
            this.lastName_lbl.TabIndex = 1;
            this.lastName_lbl.Text = "שם משפחה:";
            // 
            // firstName_lbl
            // 
            this.firstName_lbl.AutoSize = true;
            this.firstName_lbl.ForeColor = System.Drawing.Color.Black;
            this.firstName_lbl.Location = new System.Drawing.Point(191, 47);
            this.firstName_lbl.Name = "firstName_lbl";
            this.firstName_lbl.Size = new System.Drawing.Size(74, 20);
            this.firstName_lbl.TabIndex = 0;
            this.firstName_lbl.Text = "שם פרטי:";
            // 
            // MedicalInformation_gb
            // 
            this.MedicalInformation_gb.Controls.Add(this.addCoronaTest_btn);
            this.MedicalInformation_gb.Controls.Add(this.addVacc_btn);
            this.MedicalInformation_gb.Controls.Add(this.coronaTests_cmb);
            this.MedicalInformation_gb.Controls.Add(this.coronaTests_lbl);
            this.MedicalInformation_gb.Controls.Add(this.vaccinations_cmb);
            this.MedicalInformation_gb.Controls.Add(this.vaccinations_lbl);
            this.MedicalInformation_gb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.MedicalInformation_gb.ForeColor = System.Drawing.Color.Fuchsia;
            this.MedicalInformation_gb.Location = new System.Drawing.Point(117, 265);
            this.MedicalInformation_gb.Name = "MedicalInformation_gb";
            this.MedicalInformation_gb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MedicalInformation_gb.Size = new System.Drawing.Size(466, 273);
            this.MedicalInformation_gb.TabIndex = 11;
            this.MedicalInformation_gb.TabStop = false;
            this.MedicalInformation_gb.Text = "מידע רפואי מפורט";
            // 
            // addCoronaTest_btn
            // 
            this.addCoronaTest_btn.ForeColor = System.Drawing.Color.Black;
            this.addCoronaTest_btn.Location = new System.Drawing.Point(58, 193);
            this.addCoronaTest_btn.Name = "addCoronaTest_btn";
            this.addCoronaTest_btn.Size = new System.Drawing.Size(110, 58);
            this.addCoronaTest_btn.TabIndex = 6;
            this.addCoronaTest_btn.Text = "הוספת בדיקת קורונה";
            this.addCoronaTest_btn.UseVisualStyleBackColor = true;
            // 
            // addVacc_btn
            // 
            this.addVacc_btn.ForeColor = System.Drawing.Color.Black;
            this.addVacc_btn.Location = new System.Drawing.Point(186, 193);
            this.addVacc_btn.Name = "addVacc_btn";
            this.addVacc_btn.Size = new System.Drawing.Size(110, 58);
            this.addVacc_btn.TabIndex = 5;
            this.addVacc_btn.Text = "הוספת חיסון";
            this.addVacc_btn.UseVisualStyleBackColor = true;
            // 
            // coronaTests_cmb
            // 
            this.coronaTests_cmb.FormattingEnabled = true;
            this.coronaTests_cmb.Location = new System.Drawing.Point(30, 133);
            this.coronaTests_cmb.Name = "coronaTests_cmb";
            this.coronaTests_cmb.Size = new System.Drawing.Size(267, 28);
            this.coronaTests_cmb.TabIndex = 4;
            // 
            // coronaTests_lbl
            // 
            this.coronaTests_lbl.AutoSize = true;
            this.coronaTests_lbl.ForeColor = System.Drawing.Color.Black;
            this.coronaTests_lbl.Location = new System.Drawing.Point(334, 136);
            this.coronaTests_lbl.Name = "coronaTests_lbl";
            this.coronaTests_lbl.Size = new System.Drawing.Size(113, 20);
            this.coronaTests_lbl.TabIndex = 3;
            this.coronaTests_lbl.Text = "בדיקות קורונה:";
            // 
            // vaccinations_cmb
            // 
            this.vaccinations_cmb.FormattingEnabled = true;
            this.vaccinations_cmb.Location = new System.Drawing.Point(30, 60);
            this.vaccinations_cmb.Name = "vaccinations_cmb";
            this.vaccinations_cmb.Size = new System.Drawing.Size(267, 28);
            this.vaccinations_cmb.TabIndex = 2;
            // 
            // vaccinations_lbl
            // 
            this.vaccinations_lbl.AutoSize = true;
            this.vaccinations_lbl.ForeColor = System.Drawing.Color.Black;
            this.vaccinations_lbl.Location = new System.Drawing.Point(325, 63);
            this.vaccinations_lbl.Name = "vaccinations_lbl";
            this.vaccinations_lbl.Size = new System.Drawing.Size(122, 20);
            this.vaccinations_lbl.TabIndex = 1;
            this.vaccinations_lbl.Text = "חיסונים שנלקחו:";
            // 
            // cancel_btn
            // 
            this.cancel_btn.ForeColor = System.Drawing.Color.Black;
            this.cancel_btn.Location = new System.Drawing.Point(691, 555);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(76, 37);
            this.cancel_btn.TabIndex = 13;
            this.cancel_btn.Text = "בטל";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // save_btn
            // 
            this.save_btn.ForeColor = System.Drawing.Color.Black;
            this.save_btn.Location = new System.Drawing.Point(787, 555);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(74, 37);
            this.save_btn.TabIndex = 12;
            this.save_btn.Text = "שמור";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // UserDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 668);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.MedicalInformation_gb);
            this.Controls.Add(this.details_gb);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.logo1_lbl);
            this.Controls.Add(this.logo_lbl);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "UserDetails";
            this.Text = "UserDetails";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.details_gb.ResumeLayout(false);
            this.details_gb.PerformLayout();
            this.MedicalInformation_gb.ResumeLayout(false);
            this.MedicalInformation_gb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menu_users;
        private System.Windows.Forms.Label logo1_lbl;
        private System.Windows.Forms.Label logo_lbl;
        private System.Windows.Forms.GroupBox details_gb;
        private System.Windows.Forms.Label address_lbl;
        private System.Windows.Forms.Label city_lbl;
        private System.Windows.Forms.Label dateOfBirth_lbl;
        private System.Windows.Forms.Label id_lbl;
        private System.Windows.Forms.Label lastName_lbl;
        private System.Windows.Forms.Label firstName_lbl;
        private System.Windows.Forms.DateTimePicker dateOfBirth_dtp;
        private System.Windows.Forms.TextBox address_txt;
        private System.Windows.Forms.TextBox city_txt;
        private System.Windows.Forms.TextBox id_txt;
        private System.Windows.Forms.TextBox lastName_txt;
        private System.Windows.Forms.TextBox firstName_txt;
        private System.Windows.Forms.GroupBox MedicalInformation_gb;
        private System.Windows.Forms.CheckBox isNegative_cb;
        private System.Windows.Forms.CheckBox isVaccinated_cb;
        private System.Windows.Forms.Button addCoronaTest_btn;
        private System.Windows.Forms.Button addVacc_btn;
        private System.Windows.Forms.ComboBox coronaTests_cmb;
        private System.Windows.Forms.Label coronaTests_lbl;
        private System.Windows.Forms.ComboBox vaccinations_cmb;
        private System.Windows.Forms.Label vaccinations_lbl;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}