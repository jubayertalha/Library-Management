
namespace Library_Management.View
{
    partial class AdminUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.gv_info_admin = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtp_dob_admin = new System.Windows.Forms.DateTimePicker();
            this.tb_pass_admin = new System.Windows.Forms.TextBox();
            this.tb_location_admin = new System.Windows.Forms.TextBox();
            this.tb_phone_admin = new System.Windows.Forms.TextBox();
            this.tb_name_admin = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_userName_admin = new System.Windows.Forms.TextBox();
            this.tb_search_admin = new System.Windows.Forms.TextBox();
            this.btn_search_admin = new System.Windows.Forms.Button();
            this.btn_add_admin = new System.Windows.Forms.Button();
            this.btn_edit_admin = new System.Windows.Forms.Button();
            this.btn_delete_admin = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_info_admin)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1022, 70);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(468, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Admin";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gv_info_admin
            // 
            this.gv_info_admin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gv_info_admin.BackgroundColor = System.Drawing.Color.Ivory;
            this.gv_info_admin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_info_admin.Location = new System.Drawing.Point(23, 31);
            this.gv_info_admin.Name = "gv_info_admin";
            this.gv_info_admin.Size = new System.Drawing.Size(592, 485);
            this.gv_info_admin.TabIndex = 1;
            this.gv_info_admin.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_info_admin_CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gv_info_admin);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(370, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(636, 539);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "All Admin Info";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtp_dob_admin);
            this.groupBox2.Controls.Add(this.tb_pass_admin);
            this.groupBox2.Controls.Add(this.tb_location_admin);
            this.groupBox2.Controls.Add(this.tb_phone_admin);
            this.groupBox2.Controls.Add(this.tb_name_admin);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tb_userName_admin);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(19, 161);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(345, 229);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Panel";
            // 
            // dtp_dob_admin
            // 
            this.dtp_dob_admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_dob_admin.Location = new System.Drawing.Point(115, 162);
            this.dtp_dob_admin.Name = "dtp_dob_admin";
            this.dtp_dob_admin.Size = new System.Drawing.Size(224, 23);
            this.dtp_dob_admin.TabIndex = 13;
            // 
            // tb_pass_admin
            // 
            this.tb_pass_admin.Location = new System.Drawing.Point(115, 191);
            this.tb_pass_admin.Name = "tb_pass_admin";
            this.tb_pass_admin.Size = new System.Drawing.Size(224, 26);
            this.tb_pass_admin.TabIndex = 12;
            this.tb_pass_admin.UseSystemPasswordChar = true;
            // 
            // tb_location_admin
            // 
            this.tb_location_admin.Location = new System.Drawing.Point(115, 130);
            this.tb_location_admin.Name = "tb_location_admin";
            this.tb_location_admin.Size = new System.Drawing.Size(224, 26);
            this.tb_location_admin.TabIndex = 11;
            // 
            // tb_phone_admin
            // 
            this.tb_phone_admin.Location = new System.Drawing.Point(115, 98);
            this.tb_phone_admin.MaxLength = 10;
            this.tb_phone_admin.Name = "tb_phone_admin";
            this.tb_phone_admin.Size = new System.Drawing.Size(224, 26);
            this.tb_phone_admin.TabIndex = 10;
            this.tb_phone_admin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_phone_admin_KeyPress);
            // 
            // tb_name_admin
            // 
            this.tb_name_admin.Location = new System.Drawing.Point(115, 66);
            this.tb_name_admin.Name = "tb_name_admin";
            this.tb_name_admin.Size = new System.Drawing.Size(224, 26);
            this.tb_name_admin.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Date Of Birth:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Location: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Password: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Phone: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Full Name: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "User Name: ";
            // 
            // tb_userName_admin
            // 
            this.tb_userName_admin.Location = new System.Drawing.Point(115, 34);
            this.tb_userName_admin.Name = "tb_userName_admin";
            this.tb_userName_admin.Size = new System.Drawing.Size(224, 26);
            this.tb_userName_admin.TabIndex = 2;
            // 
            // tb_search_admin
            // 
            this.tb_search_admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_search_admin.Location = new System.Drawing.Point(19, 127);
            this.tb_search_admin.Name = "tb_search_admin";
            this.tb_search_admin.Size = new System.Drawing.Size(258, 26);
            this.tb_search_admin.TabIndex = 0;
            // 
            // btn_search_admin
            // 
            this.btn_search_admin.Location = new System.Drawing.Point(283, 125);
            this.btn_search_admin.Name = "btn_search_admin";
            this.btn_search_admin.Size = new System.Drawing.Size(81, 28);
            this.btn_search_admin.TabIndex = 1;
            this.btn_search_admin.Text = "Search";
            this.btn_search_admin.UseVisualStyleBackColor = true;
            this.btn_search_admin.Click += new System.EventHandler(this.btn_search_admin_Click);
            // 
            // btn_add_admin
            // 
            this.btn_add_admin.Location = new System.Drawing.Point(19, 396);
            this.btn_add_admin.Name = "btn_add_admin";
            this.btn_add_admin.Size = new System.Drawing.Size(81, 28);
            this.btn_add_admin.TabIndex = 5;
            this.btn_add_admin.Text = "Add";
            this.btn_add_admin.UseVisualStyleBackColor = true;
            this.btn_add_admin.Click += new System.EventHandler(this.btn_add_admin_Click);
            // 
            // btn_edit_admin
            // 
            this.btn_edit_admin.Location = new System.Drawing.Point(106, 396);
            this.btn_edit_admin.Name = "btn_edit_admin";
            this.btn_edit_admin.Size = new System.Drawing.Size(81, 28);
            this.btn_edit_admin.TabIndex = 6;
            this.btn_edit_admin.Text = "Edit";
            this.btn_edit_admin.UseVisualStyleBackColor = true;
            this.btn_edit_admin.Click += new System.EventHandler(this.btn_edit_admin_Click);
            // 
            // btn_delete_admin
            // 
            this.btn_delete_admin.Location = new System.Drawing.Point(193, 396);
            this.btn_delete_admin.Name = "btn_delete_admin";
            this.btn_delete_admin.Size = new System.Drawing.Size(81, 28);
            this.btn_delete_admin.TabIndex = 7;
            this.btn_delete_admin.Text = "Delete";
            this.btn_delete_admin.UseVisualStyleBackColor = true;
            this.btn_delete_admin.Click += new System.EventHandler(this.btn_delete_admin_Click);
            // 
            // AdminUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.Controls.Add(this.btn_delete_admin);
            this.Controls.Add(this.btn_edit_admin);
            this.Controls.Add(this.btn_add_admin);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_search_admin);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tb_search_admin);
            this.Controls.Add(this.panel1);
            this.Name = "AdminUC";
            this.Size = new System.Drawing.Size(1022, 659);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_info_admin)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gv_info_admin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tb_name_admin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_userName_admin;
        private System.Windows.Forms.TextBox tb_search_admin;
        private System.Windows.Forms.Button btn_search_admin;
        private System.Windows.Forms.Button btn_add_admin;
        private System.Windows.Forms.DateTimePicker dtp_dob_admin;
        private System.Windows.Forms.TextBox tb_pass_admin;
        private System.Windows.Forms.TextBox tb_location_admin;
        private System.Windows.Forms.TextBox tb_phone_admin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_edit_admin;
        private System.Windows.Forms.Button btn_delete_admin;
    }
}
