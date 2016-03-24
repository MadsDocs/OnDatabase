namespace Attach_Detach_DB
{
    partial class frm_Main
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
            this.grpBXInfo = new System.Windows.Forms.GroupBox();
            this.lstbx_Status = new System.Windows.Forms.ListBox();
            this.grpbox_info = new System.Windows.Forms.GroupBox();
            this.txtbx_db = new System.Windows.Forms.TextBox();
            this.lbl_db = new System.Windows.Forms.Label();
            this.txtbx_passwort = new System.Windows.Forms.TextBox();
            this.txtbx_username = new System.Windows.Forms.TextBox();
            this.lbl_passwort = new System.Windows.Forms.Label();
            this.lbl_user = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lbl_status = new System.Windows.Forms.Label();
            this.btn_kappen = new System.Windows.Forms.Button();
            this.txtbx_status = new System.Windows.Forms.TextBox();
            this.grp_DBOP = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.programmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtbx_dns = new System.Windows.Forms.TextBox();
            this.lblipdns = new System.Windows.Forms.Label();
            this.txtbx_instance = new System.Windows.Forms.TextBox();
            this.lbl_instance = new System.Windows.Forms.Label();
            this.btn_speichern = new System.Windows.Forms.Button();
            this.btn_laden = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.grpBXInfo.SuspendLayout();
            this.grpbox_info.SuspendLayout();
            this.grp_DBOP.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBXInfo
            // 
            this.grpBXInfo.Controls.Add(this.lstbx_Status);
            this.grpBXInfo.Location = new System.Drawing.Point(332, 12);
            this.grpBXInfo.Name = "grpBXInfo";
            this.grpBXInfo.Size = new System.Drawing.Size(250, 322);
            this.grpBXInfo.TabIndex = 8;
            this.grpBXInfo.TabStop = false;
            this.grpBXInfo.Text = "Datenbank Informationen";
            // 
            // lstbx_Status
            // 
            this.lstbx_Status.FormattingEnabled = true;
            this.lstbx_Status.Location = new System.Drawing.Point(6, 19);
            this.lstbx_Status.Name = "lstbx_Status";
            this.lstbx_Status.Size = new System.Drawing.Size(231, 290);
            this.lstbx_Status.TabIndex = 0;
            // 
            // grpbox_info
            // 
            this.grpbox_info.Controls.Add(this.btn_clear);
            this.grpbox_info.Controls.Add(this.txtbx_instance);
            this.grpbox_info.Controls.Add(this.btn_laden);
            this.grpbox_info.Controls.Add(this.lbl_instance);
            this.grpbox_info.Controls.Add(this.btn_speichern);
            this.grpbox_info.Controls.Add(this.txtbx_dns);
            this.grpbox_info.Controls.Add(this.lblipdns);
            this.grpbox_info.Controls.Add(this.txtbx_db);
            this.grpbox_info.Controls.Add(this.lbl_db);
            this.grpbox_info.Controls.Add(this.txtbx_passwort);
            this.grpbox_info.Controls.Add(this.txtbx_username);
            this.grpbox_info.Controls.Add(this.lbl_passwort);
            this.grpbox_info.Controls.Add(this.lbl_user);
            this.grpbox_info.Location = new System.Drawing.Point(588, 12);
            this.grpbox_info.Name = "grpbox_info";
            this.grpbox_info.Size = new System.Drawing.Size(225, 322);
            this.grpbox_info.TabIndex = 9;
            this.grpbox_info.TabStop = false;
            this.grpbox_info.Text = "User / Datenbank Info";
            // 
            // txtbx_db
            // 
            this.txtbx_db.Location = new System.Drawing.Point(26, 121);
            this.txtbx_db.Name = "txtbx_db";
            this.txtbx_db.Size = new System.Drawing.Size(172, 20);
            this.txtbx_db.TabIndex = 5;
            // 
            // lbl_db
            // 
            this.lbl_db.AutoSize = true;
            this.lbl_db.Location = new System.Drawing.Point(23, 105);
            this.lbl_db.Name = "lbl_db";
            this.lbl_db.Size = new System.Drawing.Size(63, 13);
            this.lbl_db.TabIndex = 4;
            this.lbl_db.Text = "Datenbank:";
            // 
            // txtbx_passwort
            // 
            this.txtbx_passwort.Location = new System.Drawing.Point(26, 77);
            this.txtbx_passwort.Name = "txtbx_passwort";
            this.txtbx_passwort.PasswordChar = '*';
            this.txtbx_passwort.Size = new System.Drawing.Size(172, 20);
            this.txtbx_passwort.TabIndex = 3;
            // 
            // txtbx_username
            // 
            this.txtbx_username.Location = new System.Drawing.Point(26, 35);
            this.txtbx_username.Name = "txtbx_username";
            this.txtbx_username.Size = new System.Drawing.Size(172, 20);
            this.txtbx_username.TabIndex = 2;
            // 
            // lbl_passwort
            // 
            this.lbl_passwort.AutoSize = true;
            this.lbl_passwort.Location = new System.Drawing.Point(23, 58);
            this.lbl_passwort.Name = "lbl_passwort";
            this.lbl_passwort.Size = new System.Drawing.Size(53, 13);
            this.lbl_passwort.TabIndex = 1;
            this.lbl_passwort.Text = "Passwort:";
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Location = new System.Drawing.Point(23, 19);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(58, 13);
            this.lbl_user.TabIndex = 0;
            this.lbl_user.Text = "Username:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(161, 64);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Datenbank ON";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Location = new System.Drawing.Point(21, 22);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(37, 13);
            this.lbl_status.TabIndex = 1;
            this.lbl_status.Text = "Status";
            // 
            // btn_kappen
            // 
            this.btn_kappen.Location = new System.Drawing.Point(24, 64);
            this.btn_kappen.Name = "btn_kappen";
            this.btn_kappen.Size = new System.Drawing.Size(131, 23);
            this.btn_kappen.TabIndex = 2;
            this.btn_kappen.Text = "Datenbank Off";
            this.btn_kappen.UseVisualStyleBackColor = true;
            this.btn_kappen.Click += new System.EventHandler(this.btn_kappen_Click);
            // 
            // txtbx_status
            // 
            this.txtbx_status.Enabled = false;
            this.txtbx_status.Location = new System.Drawing.Point(24, 38);
            this.txtbx_status.Name = "txtbx_status";
            this.txtbx_status.Size = new System.Drawing.Size(274, 20);
            this.txtbx_status.TabIndex = 0;
            // 
            // grp_DBOP
            // 
            this.grp_DBOP.Controls.Add(this.txtbx_status);
            this.grp_DBOP.Controls.Add(this.btn_kappen);
            this.grp_DBOP.Controls.Add(this.lbl_status);
            this.grp_DBOP.Controls.Add(this.button2);
            this.grp_DBOP.Location = new System.Drawing.Point(12, 31);
            this.grp_DBOP.Name = "grp_DBOP";
            this.grp_DBOP.Size = new System.Drawing.Size(314, 100);
            this.grp_DBOP.TabIndex = 7;
            this.grp_DBOP.TabStop = false;
            this.grp_DBOP.Text = "Datenbank Operationen";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programmToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(825, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // programmToolStripMenuItem
            // 
            this.programmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.beendenToolStripMenuItem});
            this.programmToolStripMenuItem.Name = "programmToolStripMenuItem";
            this.programmToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.programmToolStripMenuItem.Text = "Programm";
            // 
            // beendenToolStripMenuItem
            // 
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            this.beendenToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.beendenToolStripMenuItem.Text = "Beenden";
            this.beendenToolStripMenuItem.Click += new System.EventHandler(this.beendenToolStripMenuItem_Click);
            // 
            // txtbx_dns
            // 
            this.txtbx_dns.Location = new System.Drawing.Point(26, 160);
            this.txtbx_dns.Name = "txtbx_dns";
            this.txtbx_dns.Size = new System.Drawing.Size(172, 20);
            this.txtbx_dns.TabIndex = 7;
            // 
            // lblipdns
            // 
            this.lblipdns.AutoSize = true;
            this.lblipdns.Location = new System.Drawing.Point(23, 144);
            this.lblipdns.Name = "lblipdns";
            this.lblipdns.Size = new System.Drawing.Size(101, 13);
            this.lblipdns.TabIndex = 6;
            this.lblipdns.Text = "IP oder DNS Name:";
            // 
            // txtbx_instance
            // 
            this.txtbx_instance.Location = new System.Drawing.Point(26, 199);
            this.txtbx_instance.Name = "txtbx_instance";
            this.txtbx_instance.Size = new System.Drawing.Size(172, 20);
            this.txtbx_instance.TabIndex = 9;
            // 
            // lbl_instance
            // 
            this.lbl_instance.AutoSize = true;
            this.lbl_instance.Location = new System.Drawing.Point(23, 183);
            this.lbl_instance.Name = "lbl_instance";
            this.lbl_instance.Size = new System.Drawing.Size(44, 13);
            this.lbl_instance.TabIndex = 8;
            this.lbl_instance.Text = "Instanz:";
            // 
            // btn_speichern
            // 
            this.btn_speichern.Location = new System.Drawing.Point(45, 225);
            this.btn_speichern.Name = "btn_speichern";
            this.btn_speichern.Size = new System.Drawing.Size(134, 21);
            this.btn_speichern.TabIndex = 10;
            this.btn_speichern.Text = "Einstellungen speichern";
            this.btn_speichern.UseVisualStyleBackColor = true;
            this.btn_speichern.Click += new System.EventHandler(this.btn_speichern_Click);
            // 
            // btn_laden
            // 
            this.btn_laden.Location = new System.Drawing.Point(45, 252);
            this.btn_laden.Name = "btn_laden";
            this.btn_laden.Size = new System.Drawing.Size(134, 21);
            this.btn_laden.TabIndex = 11;
            this.btn_laden.Text = "Einstellungen laden";
            this.btn_laden.UseVisualStyleBackColor = true;
            this.btn_laden.Click += new System.EventHandler(this.btn_laden_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(45, 279);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(134, 23);
            this.btn_clear.TabIndex = 12;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 333);
            this.Controls.Add(this.grpbox_info);
            this.Controls.Add(this.grpBXInfo);
            this.Controls.Add(this.grp_DBOP);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_Main";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpBXInfo.ResumeLayout(false);
            this.grpbox_info.ResumeLayout(false);
            this.grpbox_info.PerformLayout();
            this.grp_DBOP.ResumeLayout(false);
            this.grp_DBOP.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grpBXInfo;
        private System.Windows.Forms.ListBox lstbx_Status;
        private System.Windows.Forms.GroupBox grpbox_info;
        private System.Windows.Forms.Label lbl_passwort;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.TextBox txtbx_username;
        private System.Windows.Forms.TextBox txtbx_passwort;
        private System.Windows.Forms.TextBox txtbx_db;
        private System.Windows.Forms.Label lbl_db;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Button btn_kappen;
        private System.Windows.Forms.TextBox txtbx_status;
        private System.Windows.Forms.GroupBox grp_DBOP;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem programmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
        private System.Windows.Forms.TextBox txtbx_dns;
        private System.Windows.Forms.Label lblipdns;
        private System.Windows.Forms.TextBox txtbx_instance;
        private System.Windows.Forms.Label lbl_instance;
        private System.Windows.Forms.Button btn_speichern;
        private System.Windows.Forms.Button btn_laden;
        private System.Windows.Forms.Button btn_clear;
    }
}

