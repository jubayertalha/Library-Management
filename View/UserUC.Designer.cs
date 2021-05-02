
namespace Library_Management.View
{
    partial class UserUC
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
            this.btn_delete_user = new System.Windows.Forms.Button();
            this.btn_edit_user = new System.Windows.Forms.Button();
            this.btn_add_user = new System.Windows.Forms.Button();
            this.btn_search_user = new System.Windows.Forms.Button();
            this.tb_search_user = new System.Windows.Forms.TextBox();
            this.dtp_dob_user = new System.Windows.Forms.DateTimePicker();
            this.tb_pass_user = new System.Windows.Forms.TextBox();
            this.tb_location_user = new System.Windows.Forms.TextBox();
            this.tb_phone_user = new System.Windows.Forms.TextBox();
            this.tb_name_user = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_userName_user = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gv_info_user = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_info_user)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_delete_user
            // 
            this.btn_delete_user.Location = new System.Drawing.Point(193, 396);
            this.btn_delete_user.Name = "btn_delete_user";
            this.btn_delete_user.Size = new System.Drawing.Size(81, 28);
            this.btn_delete_user.TabIndex = 15;
            this.btn_delete_user.Text = "Delete";
            this.btn_delete_user.UseVisualStyleBackColor = true;
            this.btn_delete_user.Click += new System.EventHandler(this.btn_delete_user_Click);
            // 
            // btn_edit_user
            // 
            this.btn_edit_user.Location = new System.Drawing.Point(106, 396);
            this.btn_edit_user.Name = "btn_edit_user";
            this.btn_edit_user.Size = new System.Drawing.Size(81, 28);
            this.btn_edit_user.TabIndex = 14;
            this.btn_edit_user.Text = "Edit";
            this.btn_edit_user.UseVisualStyleBackColor = true;
            this.btn_edit_user.Click += new System.EventHandler(this.btn_edit_user_Click);
            // 
            // btn_add_user
            // 
            this.btn_add_user.Location = new System.Drawing.Point(19, 396);
            this.btn_add_user.Name = "btn_add_user";
            this.btn_add_user.Size = new System.Drawing.Size(81, 28);
            this.btn_add_user.TabIndex = 13;
            this.btn_add_user.Text = "Add";
            this.btn_add_user.UseVisualStyleBackColor = true;
            this.btn_add_user.Click += new System.EventHandler(this.btn_add_user_Click);
            // 
            // btn_search_user
            // 
            this.btn_search_user.Location = new System.Drawing.Point(283, 125);
            this.btn_search_user.Name = "btn_search_user";
            this.btn_search_user.Size = new System.Drawing.Size(81, 28);
            this.btn_search_user.TabIndex = 10;
            this.btn_search_user.Text = "Search";
            this.btn_search_user.UseVisualStyleBackColor = true;
            this.btn_search_user.Click += new System.EventHandler(this.btn_search_user_Click);
            // 
            // tb_search_user
            // 
            this.tb_search_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_search_user.Location = new System.Drawing.Point(19, 127);
            this.tb_search_user.Name = "tb_search_user";
            this.tb_search_user.Size = new System.Drawing.Size(258, 26);
            this.tb_search_user.TabIndex = 8;
            // 
            // dtp_dob_user
            // 
            this.dtp_dob_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_dob_user.Location = new System.Drawing.Point(115, 162);
            this.dtp_dob_user.Name = "dtp_dob_user";
            this.dtp_dob_user.Size = new System.Drawing.Size(224, 23);
            this.dtp_dob_user.TabIndex = 13;
            // 
            // tb_pass_user
            // 
            this.tb_pass_user.Location = new System.Drawing.Point(115, 191);
            this.tb_pass_user.Name = "tb_pass_user";
            this.tb_pass_user.Size = new System.Drawing.Size(224, 26);
            this.tb_pass_user.TabIndex = 12;
            this.tb_pass_user.UseSystemPasswordChar = true;
            // 
            // tb_location_user
            // 
            this.tb_location_user.Location = new System.Drawing.Point(115, 130);
            this.tb_location_user.Name = "tb_location_user";
            this.tb_location_user.Size = new System.Drawing.Size(224, 26);
            this.tb_location_user.TabIndex = 11;
            // 
            // tb_phone_user
            // 
            this.tb_phone_user.Location = new System.Drawing.Point(115, 98);
            this.tb_phone_user.MaxLength = 10;
            this.tb_phone_user.Name = "tb_phone_user";
            this.tb_phone_user.Size = new System.Drawing.Size(224, 26);
            this.tb_phone_user.TabIndex = 10;
            this.tb_phone_user.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_phone_user_KeyPress);
            // 
            // tb_name_user
            // 
            this.tb_name_user.Location = new System.Drawing.Point(115, 66);
            this.tb_name_user.Name = "tb_name_user";
            this.tb_name_user.Size = new System.Drawing.Size(224, 26);
            this.tb_name_user.TabIndex = 9;
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
            // tb_userName_user
            // 
            this.tb_userName_user.Location = new System.Drawing.Point(115, 34);
            this.tb_userName_user.Name = "tb_userName_user";
            this.tb_userName_user.Size = new System.Drawing.Size(224, 26);
            this.tb_userName_user.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gv_info_user);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(370, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(636, 539);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "All Users Info";
            // 
            // gv_info_user
            // 
            this.gv_info_user.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_info_user.Location = new System.Drawing.Point(23, 31);
            this.gv_info_user.Name = "gv_info_user";
            this.gv_info_user.Size = new System.Drawing.Size(592, 485);
            this.gv_info_user.TabIndex = 1;
            this.gv_info_user.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_info_user_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(468, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Users";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtp_dob_user);
            this.groupBox2.Controls.Add(this.tb_pass_user);
            this.groupBox2.Controls.Add(this.tb_location_user);
            this.groupBox2.Controls.Add(this.tb_phone_user);
            this.groupBox2.Controls.Add(this.tb_name_user);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tb_userName_user);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(19, 161);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(345, 229);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Panel";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1022, 70);
            this.panel1.TabIndex = 9;
            // 
            // UserUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.Controls.Add(this.btn_delete_user);
            this.Controls.Add(this.btn_edit_user);
            this.Controls.Add(this.btn_add_user);
            this.Controls.Add(this.btn_search_user);
            this.Controls.Add(this.tb_search_user);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Name = "UserUC";
            this.Size = new System.Drawing.Size(1022, 659);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_info_user)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_delete_user;
        private System.Windows.Forms.Button btn_edit_user;
        private System.Windows.Forms.Button btn_add_user;
        private System.Windows.Forms.Button btn_search_user;
        private System.Windows.Forms.TextBox tb_search_user;
        private System.Windows.Forms.DateTimePicker dtp_dob_user;
        private System.Windows.Forms.TextBox tb_pass_user;
        private System.Windows.Forms.TextBox tb_location_user;
        private System.Windows.Forms.TextBox tb_phone_user;
        private System.Windows.Forms.TextBox tb_name_user;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_userName_user;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView gv_info_user;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
    }
}
