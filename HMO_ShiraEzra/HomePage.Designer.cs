
namespace HMO_ShiraEzra
{
    partial class HomePage
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.logo_lbl = new System.Windows.Forms.Label();
            this.logo1_lbl = new System.Windows.Forms.Label();
            this.menu_users = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // logo_lbl
            // 
            this.logo_lbl.AutoSize = true;
            this.logo_lbl.Font = new System.Drawing.Font("Segoe Print", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logo_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.logo_lbl.Location = new System.Drawing.Point(0, 8);
            this.logo_lbl.Name = "logo_lbl";
            this.logo_lbl.Size = new System.Drawing.Size(395, 213);
            this.logo_lbl.TabIndex = 1;
            this.logo_lbl.Text = "HMO";
            // 
            // logo1_lbl
            // 
            this.logo1_lbl.AutoSize = true;
            this.logo1_lbl.Font = new System.Drawing.Font("Freestyle Script", 19.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logo1_lbl.Location = new System.Drawing.Point(29, 173);
            this.logo1_lbl.Name = "logo1_lbl";
            this.logo1_lbl.Size = new System.Drawing.Size(329, 40);
            this.logo1_lbl.TabIndex = 2;
            this.logo1_lbl.Text = "Health Maintenance Organization";
            // 
            // menu_users
            // 
            this.menu_users.Font = new System.Drawing.Font("Kristen ITC", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_users.Name = "menu_users";
            this.menu_users.Size = new System.Drawing.Size(171, 43);
            this.menu_users.Text = "חברי הקופה";
            this.menu_users.Click += new System.EventHandler(this.menu_users_Click);
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
            this.menuStrip1.Size = new System.Drawing.Size(1048, 47);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(-3, -7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(449, 54);
            this.label1.TabIndex = 4;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1048, 650);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logo1_lbl);
            this.Controls.Add(this.logo_lbl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HomePage";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label logo_lbl;
        private System.Windows.Forms.Label logo1_lbl;
        private System.Windows.Forms.ToolStripMenuItem menu_users;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label1;
    }
}

