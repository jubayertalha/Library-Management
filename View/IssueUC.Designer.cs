
namespace Library_Management.View
{
    partial class IssueUC
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
            this.cb_status_issue = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_book_id_issue = new System.Windows.Forms.TextBox();
            this.lbl_issue_date_issue = new System.Windows.Forms.Label();
            this.lbl_status_issue = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtp_return_date_issue = new System.Windows.Forms.DateTimePicker();
            this.lbl_return_date_issue = new System.Windows.Forms.Label();
            this.dtp_tobe_return_issue = new System.Windows.Forms.DateTimePicker();
            this.lbl_tobe_return_issue = new System.Windows.Forms.Label();
            this.dtp_issue_date_issue = new System.Windows.Forms.DateTimePicker();
            this.lbl_user_info_issue = new System.Windows.Forms.Label();
            this.btn_user_name_enter_issue = new System.Windows.Forms.Button();
            this.tb_user_name_issue = new System.Windows.Forms.TextBox();
            this.lbl_user_name_issue = new System.Windows.Forms.Label();
            this.lbl_book_info_issue = new System.Windows.Forms.Label();
            this.btn_book_enter_issue = new System.Windows.Forms.Button();
            this.lbl_book_id_issue = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_issue_id_issue = new System.Windows.Forms.TextBox();
            this.gv_info_issue = new System.Windows.Forms.DataGridView();
            this.gb_info_issue = new System.Windows.Forms.GroupBox();
            this.cb_search_issue = new System.Windows.Forms.ComboBox();
            this.btn_edit_issue = new System.Windows.Forms.Button();
            this.btn_add_issue = new System.Windows.Forms.Button();
            this.btn_search_issue = new System.Windows.Forms.Button();
            this.tb_search_issue = new System.Windows.Forms.TextBox();
            this.btn_delete_issue = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_clear_issue = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_info_issue)).BeginInit();
            this.gb_info_issue.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_status_issue
            // 
            this.cb_status_issue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_status_issue.FormattingEnabled = true;
            this.cb_status_issue.Items.AddRange(new object[] {
            "Issued",
            "Returned",
            "Expired"});
            this.cb_status_issue.Location = new System.Drawing.Point(115, 211);
            this.cb_status_issue.Name = "cb_status_issue";
            this.cb_status_issue.Size = new System.Drawing.Size(224, 28);
            this.cb_status_issue.TabIndex = 13;
            this.cb_status_issue.SelectedIndexChanged += new System.EventHandler(this.cb_status_issue_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(480, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Type: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(468, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Issue";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1022, 70);
            this.panel1.TabIndex = 18;
            // 
            // tb_book_id_issue
            // 
            this.tb_book_id_issue.Location = new System.Drawing.Point(115, 139);
            this.tb_book_id_issue.Name = "tb_book_id_issue";
            this.tb_book_id_issue.Size = new System.Drawing.Size(224, 26);
            this.tb_book_id_issue.TabIndex = 9;
            this.tb_book_id_issue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_book_id_issue_KeyPress);
            // 
            // lbl_issue_date_issue
            // 
            this.lbl_issue_date_issue.AutoSize = true;
            this.lbl_issue_date_issue.Location = new System.Drawing.Point(6, 247);
            this.lbl_issue_date_issue.Name = "lbl_issue_date_issue";
            this.lbl_issue_date_issue.Size = new System.Drawing.Size(91, 20);
            this.lbl_issue_date_issue.TabIndex = 8;
            this.lbl_issue_date_issue.Text = "Issue Date:";
            // 
            // lbl_status_issue
            // 
            this.lbl_status_issue.AutoSize = true;
            this.lbl_status_issue.Location = new System.Drawing.Point(6, 217);
            this.lbl_status_issue.Name = "lbl_status_issue";
            this.lbl_status_issue.Size = new System.Drawing.Size(60, 20);
            this.lbl_status_issue.TabIndex = 7;
            this.lbl_status_issue.Text = "Status:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtp_return_date_issue);
            this.groupBox2.Controls.Add(this.lbl_return_date_issue);
            this.groupBox2.Controls.Add(this.dtp_tobe_return_issue);
            this.groupBox2.Controls.Add(this.lbl_tobe_return_issue);
            this.groupBox2.Controls.Add(this.dtp_issue_date_issue);
            this.groupBox2.Controls.Add(this.lbl_user_info_issue);
            this.groupBox2.Controls.Add(this.btn_user_name_enter_issue);
            this.groupBox2.Controls.Add(this.tb_user_name_issue);
            this.groupBox2.Controls.Add(this.lbl_user_name_issue);
            this.groupBox2.Controls.Add(this.lbl_book_info_issue);
            this.groupBox2.Controls.Add(this.btn_book_enter_issue);
            this.groupBox2.Controls.Add(this.cb_status_issue);
            this.groupBox2.Controls.Add(this.tb_book_id_issue);
            this.groupBox2.Controls.Add(this.lbl_issue_date_issue);
            this.groupBox2.Controls.Add(this.lbl_status_issue);
            this.groupBox2.Controls.Add(this.lbl_book_id_issue);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tb_issue_id_issue);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(19, 161);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(433, 354);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Panel";
            // 
            // dtp_return_date_issue
            // 
            this.dtp_return_date_issue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_return_date_issue.Location = new System.Drawing.Point(115, 306);
            this.dtp_return_date_issue.Name = "dtp_return_date_issue";
            this.dtp_return_date_issue.Size = new System.Drawing.Size(224, 23);
            this.dtp_return_date_issue.TabIndex = 45;
            // 
            // lbl_return_date_issue
            // 
            this.lbl_return_date_issue.AutoSize = true;
            this.lbl_return_date_issue.Location = new System.Drawing.Point(6, 307);
            this.lbl_return_date_issue.Name = "lbl_return_date_issue";
            this.lbl_return_date_issue.Size = new System.Drawing.Size(101, 20);
            this.lbl_return_date_issue.TabIndex = 44;
            this.lbl_return_date_issue.Text = "Return Date:";
            // 
            // dtp_tobe_return_issue
            // 
            this.dtp_tobe_return_issue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_tobe_return_issue.Location = new System.Drawing.Point(115, 277);
            this.dtp_tobe_return_issue.Name = "dtp_tobe_return_issue";
            this.dtp_tobe_return_issue.Size = new System.Drawing.Size(224, 23);
            this.dtp_tobe_return_issue.TabIndex = 43;
            // 
            // lbl_tobe_return_issue
            // 
            this.lbl_tobe_return_issue.AutoSize = true;
            this.lbl_tobe_return_issue.Location = new System.Drawing.Point(6, 278);
            this.lbl_tobe_return_issue.Name = "lbl_tobe_return_issue";
            this.lbl_tobe_return_issue.Size = new System.Drawing.Size(102, 20);
            this.lbl_tobe_return_issue.TabIndex = 42;
            this.lbl_tobe_return_issue.Text = "Tobe Return:";
            // 
            // dtp_issue_date_issue
            // 
            this.dtp_issue_date_issue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_issue_date_issue.Location = new System.Drawing.Point(115, 246);
            this.dtp_issue_date_issue.Name = "dtp_issue_date_issue";
            this.dtp_issue_date_issue.Size = new System.Drawing.Size(224, 23);
            this.dtp_issue_date_issue.TabIndex = 41;
            this.dtp_issue_date_issue.ValueChanged += new System.EventHandler(this.dtp_issue_date_issue_ValueChanged);
            // 
            // lbl_user_info_issue
            // 
            this.lbl_user_info_issue.AutoSize = true;
            this.lbl_user_info_issue.Location = new System.Drawing.Point(111, 106);
            this.lbl_user_info_issue.Name = "lbl_user_info_issue";
            this.lbl_user_info_issue.Size = new System.Drawing.Size(287, 20);
            this.lbl_user_info_issue.TabIndex = 40;
            this.lbl_user_info_issue.Text = "Returned: 45    Issued: 12    Expired: 10";
            // 
            // btn_user_name_enter_issue
            // 
            this.btn_user_name_enter_issue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_user_name_enter_issue.Location = new System.Drawing.Point(345, 66);
            this.btn_user_name_enter_issue.Name = "btn_user_name_enter_issue";
            this.btn_user_name_enter_issue.Size = new System.Drawing.Size(81, 28);
            this.btn_user_name_enter_issue.TabIndex = 39;
            this.btn_user_name_enter_issue.Text = "Enter";
            this.btn_user_name_enter_issue.UseVisualStyleBackColor = true;
            this.btn_user_name_enter_issue.Click += new System.EventHandler(this.btn_user_name_enter_issue_Click);
            // 
            // tb_user_name_issue
            // 
            this.tb_user_name_issue.Location = new System.Drawing.Point(115, 66);
            this.tb_user_name_issue.Name = "tb_user_name_issue";
            this.tb_user_name_issue.Size = new System.Drawing.Size(224, 26);
            this.tb_user_name_issue.TabIndex = 38;
            // 
            // lbl_user_name_issue
            // 
            this.lbl_user_name_issue.AutoSize = true;
            this.lbl_user_name_issue.Location = new System.Drawing.Point(6, 69);
            this.lbl_user_name_issue.Name = "lbl_user_name_issue";
            this.lbl_user_name_issue.Size = new System.Drawing.Size(93, 20);
            this.lbl_user_name_issue.TabIndex = 37;
            this.lbl_user_name_issue.Text = "User Name:";
            // 
            // lbl_book_info_issue
            // 
            this.lbl_book_info_issue.AutoSize = true;
            this.lbl_book_info_issue.Location = new System.Drawing.Point(111, 179);
            this.lbl_book_info_issue.Name = "lbl_book_info_issue";
            this.lbl_book_info_issue.Size = new System.Drawing.Size(148, 20);
            this.lbl_book_info_issue.TabIndex = 36;
            this.lbl_book_info_issue.Text = "Book Available: 123";
            // 
            // btn_book_enter_issue
            // 
            this.btn_book_enter_issue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_book_enter_issue.Location = new System.Drawing.Point(345, 139);
            this.btn_book_enter_issue.Name = "btn_book_enter_issue";
            this.btn_book_enter_issue.Size = new System.Drawing.Size(81, 28);
            this.btn_book_enter_issue.TabIndex = 32;
            this.btn_book_enter_issue.Text = "Enter";
            this.btn_book_enter_issue.UseVisualStyleBackColor = true;
            this.btn_book_enter_issue.Click += new System.EventHandler(this.btn_book_enter_issue_Click);
            // 
            // lbl_book_id_issue
            // 
            this.lbl_book_id_issue.AutoSize = true;
            this.lbl_book_id_issue.Location = new System.Drawing.Point(6, 142);
            this.lbl_book_id_issue.Name = "lbl_book_id_issue";
            this.lbl_book_id_issue.Size = new System.Drawing.Size(68, 20);
            this.lbl_book_id_issue.TabIndex = 4;
            this.lbl_book_id_issue.Text = "Book Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Issue Id:";
            // 
            // tb_issue_id_issue
            // 
            this.tb_issue_id_issue.Enabled = false;
            this.tb_issue_id_issue.Location = new System.Drawing.Point(115, 34);
            this.tb_issue_id_issue.Name = "tb_issue_id_issue";
            this.tb_issue_id_issue.Size = new System.Drawing.Size(224, 26);
            this.tb_issue_id_issue.TabIndex = 2;
            // 
            // gv_info_issue
            // 
            this.gv_info_issue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gv_info_issue.BackgroundColor = System.Drawing.Color.SeaShell;
            this.gv_info_issue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_info_issue.Location = new System.Drawing.Point(23, 31);
            this.gv_info_issue.Name = "gv_info_issue";
            this.gv_info_issue.Size = new System.Drawing.Size(490, 422);
            this.gv_info_issue.TabIndex = 1;
            // 
            // gb_info_issue
            // 
            this.gb_info_issue.Controls.Add(this.gv_info_issue);
            this.gb_info_issue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_info_issue.Location = new System.Drawing.Point(473, 161);
            this.gb_info_issue.Name = "gb_info_issue";
            this.gb_info_issue.Size = new System.Drawing.Size(533, 474);
            this.gb_info_issue.TabIndex = 20;
            this.gb_info_issue.TabStop = false;
            this.gb_info_issue.Text = "Info";
            // 
            // cb_search_issue
            // 
            this.cb_search_issue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_search_issue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_search_issue.FormattingEnabled = true;
            this.cb_search_issue.Items.AddRange(new object[] {
            "Issued",
            "Returned",
            "Expired",
            "User"});
            this.cb_search_issue.Location = new System.Drawing.Point(532, 121);
            this.cb_search_issue.Name = "cb_search_issue";
            this.cb_search_issue.Size = new System.Drawing.Size(224, 28);
            this.cb_search_issue.TabIndex = 24;
            this.cb_search_issue.SelectedIndexChanged += new System.EventHandler(this.cb_search_issue_SelectedIndexChanged);
            // 
            // btn_edit_issue
            // 
            this.btn_edit_issue.Location = new System.Drawing.Point(104, 521);
            this.btn_edit_issue.Name = "btn_edit_issue";
            this.btn_edit_issue.Size = new System.Drawing.Size(81, 28);
            this.btn_edit_issue.TabIndex = 25;
            this.btn_edit_issue.Text = "Edit";
            this.btn_edit_issue.UseVisualStyleBackColor = true;
            this.btn_edit_issue.Click += new System.EventHandler(this.btn_edit_issue_Click);
            // 
            // btn_add_issue
            // 
            this.btn_add_issue.Location = new System.Drawing.Point(18, 521);
            this.btn_add_issue.Name = "btn_add_issue";
            this.btn_add_issue.Size = new System.Drawing.Size(81, 28);
            this.btn_add_issue.TabIndex = 23;
            this.btn_add_issue.Text = "Add";
            this.btn_add_issue.UseVisualStyleBackColor = true;
            this.btn_add_issue.Click += new System.EventHandler(this.btn_add_issue_Click);
            // 
            // btn_search_issue
            // 
            this.btn_search_issue.Location = new System.Drawing.Point(355, 125);
            this.btn_search_issue.Name = "btn_search_issue";
            this.btn_search_issue.Size = new System.Drawing.Size(81, 28);
            this.btn_search_issue.TabIndex = 19;
            this.btn_search_issue.Text = "Search";
            this.btn_search_issue.UseVisualStyleBackColor = true;
            this.btn_search_issue.Click += new System.EventHandler(this.btn_search_issue_Click);
            // 
            // tb_search_issue
            // 
            this.tb_search_issue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_search_issue.Location = new System.Drawing.Point(91, 125);
            this.tb_search_issue.Name = "tb_search_issue";
            this.tb_search_issue.Size = new System.Drawing.Size(258, 26);
            this.tb_search_issue.TabIndex = 17;
            this.tb_search_issue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_search_issue_KeyPress);
            // 
            // btn_delete_issue
            // 
            this.btn_delete_issue.Location = new System.Drawing.Point(191, 521);
            this.btn_delete_issue.Name = "btn_delete_issue";
            this.btn_delete_issue.Size = new System.Drawing.Size(81, 28);
            this.btn_delete_issue.TabIndex = 26;
            this.btn_delete_issue.Text = "Delete";
            this.btn_delete_issue.UseVisualStyleBackColor = true;
            this.btn_delete_issue.Click += new System.EventHandler(this.btn_delete_issue_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 20);
            this.label8.TabIndex = 29;
            this.label8.Text = "Issue Id:";
            // 
            // btn_clear_issue
            // 
            this.btn_clear_issue.Location = new System.Drawing.Point(278, 521);
            this.btn_clear_issue.Name = "btn_clear_issue";
            this.btn_clear_issue.Size = new System.Drawing.Size(81, 28);
            this.btn_clear_issue.TabIndex = 30;
            this.btn_clear_issue.Text = "Clear";
            this.btn_clear_issue.UseVisualStyleBackColor = true;
            this.btn_clear_issue.Click += new System.EventHandler(this.btn_clear_issue_Click);
            // 
            // IssueUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.Controls.Add(this.btn_clear_issue);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gb_info_issue);
            this.Controls.Add(this.cb_search_issue);
            this.Controls.Add(this.btn_edit_issue);
            this.Controls.Add(this.btn_add_issue);
            this.Controls.Add(this.btn_search_issue);
            this.Controls.Add(this.tb_search_issue);
            this.Controls.Add(this.btn_delete_issue);
            this.Name = "IssueUC";
            this.Size = new System.Drawing.Size(1022, 659);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_info_issue)).EndInit();
            this.gb_info_issue.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cb_status_issue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tb_book_id_issue;
        private System.Windows.Forms.Label lbl_issue_date_issue;
        private System.Windows.Forms.Label lbl_status_issue;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_book_id_issue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_issue_id_issue;
        private System.Windows.Forms.DataGridView gv_info_issue;
        private System.Windows.Forms.GroupBox gb_info_issue;
        private System.Windows.Forms.ComboBox cb_search_issue;
        private System.Windows.Forms.Button btn_edit_issue;
        private System.Windows.Forms.Button btn_add_issue;
        private System.Windows.Forms.Button btn_search_issue;
        private System.Windows.Forms.TextBox tb_search_issue;
        private System.Windows.Forms.Button btn_delete_issue;
        private System.Windows.Forms.Label lbl_user_info_issue;
        private System.Windows.Forms.Button btn_user_name_enter_issue;
        private System.Windows.Forms.TextBox tb_user_name_issue;
        private System.Windows.Forms.Label lbl_user_name_issue;
        private System.Windows.Forms.Label lbl_book_info_issue;
        private System.Windows.Forms.Button btn_book_enter_issue;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtp_return_date_issue;
        private System.Windows.Forms.Label lbl_return_date_issue;
        private System.Windows.Forms.DateTimePicker dtp_tobe_return_issue;
        private System.Windows.Forms.Label lbl_tobe_return_issue;
        private System.Windows.Forms.DateTimePicker dtp_issue_date_issue;
        private System.Windows.Forms.Button btn_clear_issue;
    }
}
