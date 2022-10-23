
namespace HMO_ShiraEzra
{
    partial class DisplayUsers
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
            this.logo1_lbl = new System.Windows.Forms.Label();
            this.logo_lbl = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu_users = new System.Windows.Forms.ToolStripMenuItem();
            this.users_dg = new System.Windows.Forms.DataGridView();
            this.display_btn = new System.Windows.Forms.Button();
            this.update_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.new_btn = new System.Windows.Forms.Button();
            this.refresh_lnklbl = new System.Windows.Forms.LinkLabel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.users_dg)).BeginInit();
            this.SuspendLayout();
            // 
            // logo1_lbl
            // 
            this.logo1_lbl.AutoSize = true;
            this.logo1_lbl.Font = new System.Drawing.Font("Freestyle Script", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logo1_lbl.Location = new System.Drawing.Point(10, 130);
            this.logo1_lbl.Name = "logo1_lbl";
            this.logo1_lbl.Size = new System.Drawing.Size(225, 28);
            this.logo1_lbl.TabIndex = 4;
            this.logo1_lbl.Text = "Health Maintenance Organization";
            // 
            // logo_lbl
            // 
            this.logo_lbl.AutoSize = true;
            this.logo_lbl.Font = new System.Drawing.Font("Segoe Print", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logo_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.logo_lbl.Location = new System.Drawing.Point(-4, 17);
            this.logo_lbl.Name = "logo_lbl";
            this.logo_lbl.Size = new System.Drawing.Size(264, 141);
            this.logo_lbl.TabIndex = 3;
            this.logo_lbl.Text = "HMO";
            this.logo_lbl.Click += new System.EventHandler(this.logo_lbl_Click);
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
            this.menuStrip1.Size = new System.Drawing.Size(1111, 47);
            this.menuStrip1.TabIndex = 5;
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
            // users_dg
            // 
            this.users_dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.users_dg.Location = new System.Drawing.Point(597, 163);
            this.users_dg.Name = "users_dg";
            this.users_dg.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.users_dg.RowHeadersWidth = 51;
            this.users_dg.RowTemplate.Height = 24;
            this.users_dg.Size = new System.Drawing.Size(453, 381);
            this.users_dg.TabIndex = 6;
            this.users_dg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.users_dg_CellContentClick);
            // 
            // display_btn
            // 
            this.display_btn.Location = new System.Drawing.Point(370, 260);
            this.display_btn.Name = "display_btn";
            this.display_btn.Size = new System.Drawing.Size(111, 46);
            this.display_btn.TabIndex = 7;
            this.display_btn.Text = "הצגת פרטים מלאים";
            this.display_btn.UseVisualStyleBackColor = true;
            this.display_btn.Click += new System.EventHandler(this.display_btn_Click);
            // 
            // update_btn
            // 
            this.update_btn.Location = new System.Drawing.Point(223, 260);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(111, 46);
            this.update_btn.TabIndex = 8;
            this.update_btn.Text = "עדכון";
            this.update_btn.UseVisualStyleBackColor = true;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(146, 343);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(111, 46);
            this.delete_btn.TabIndex = 9;
            this.delete_btn.Text = "מחיקה";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // new_btn
            // 
            this.new_btn.Location = new System.Drawing.Point(293, 343);
            this.new_btn.Name = "new_btn";
            this.new_btn.Size = new System.Drawing.Size(111, 46);
            this.new_btn.TabIndex = 10;
            this.new_btn.Text = "הוספת חדש";
            this.new_btn.UseVisualStyleBackColor = true;
            this.new_btn.Click += new System.EventHandler(this.new_btn_Click);
            // 
            // refresh_lnklbl
            // 
            this.refresh_lnklbl.AutoSize = true;
            this.refresh_lnklbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.refresh_lnklbl.Location = new System.Drawing.Point(1004, 561);
            this.refresh_lnklbl.Name = "refresh_lnklbl";
            this.refresh_lnklbl.Size = new System.Drawing.Size(46, 25);
            this.refresh_lnklbl.TabIndex = 11;
            this.refresh_lnklbl.TabStop = true;
            this.refresh_lnklbl.Text = "רענן";
            this.refresh_lnklbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.refresh_lnklbl_LinkClicked);
            // 
            // DisplayUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 645);
            this.Controls.Add(this.refresh_lnklbl);
            this.Controls.Add(this.new_btn);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.display_btn);
            this.Controls.Add(this.users_dg);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.logo1_lbl);
            this.Controls.Add(this.logo_lbl);
            this.Name = "DisplayUsers";
            this.Text = "DisplayUsers";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.users_dg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label logo1_lbl;
        private System.Windows.Forms.Label logo_lbl;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menu_users;
        private System.Windows.Forms.DataGridView users_dg;
        private System.Windows.Forms.Button display_btn;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button new_btn;
        private System.Windows.Forms.LinkLabel refresh_lnklbl;
    }
}