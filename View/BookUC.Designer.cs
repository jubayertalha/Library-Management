
namespace Library_Management.View
{
    partial class BookUC
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
            this.btn_delete_book = new System.Windows.Forms.Button();
            this.btn_edit_book = new System.Windows.Forms.Button();
            this.btn_add_book = new System.Windows.Forms.Button();
            this.btn_search_book = new System.Windows.Forms.Button();
            this.tb_search_book = new System.Windows.Forms.TextBox();
            this.tb_stock_book = new System.Windows.Forms.TextBox();
            this.tb_author_book = new System.Windows.Forms.TextBox();
            this.tb_name_book = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_id_book = new System.Windows.Forms.TextBox();
            this.gb_info_book = new System.Windows.Forms.GroupBox();
            this.gv_info_book = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_category_book = new System.Windows.Forms.ComboBox();
            this.cb_search_book = new System.Windows.Forms.ComboBox();
            this.btn_clear_book = new System.Windows.Forms.Button();
            this.gb_info_book.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_info_book)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_delete_book
            // 
            this.btn_delete_book.Location = new System.Drawing.Point(193, 378);
            this.btn_delete_book.Name = "btn_delete_book";
            this.btn_delete_book.Size = new System.Drawing.Size(81, 28);
            this.btn_delete_book.TabIndex = 15;
            this.btn_delete_book.Text = "Delete";
            this.btn_delete_book.UseVisualStyleBackColor = true;
            this.btn_delete_book.Click += new System.EventHandler(this.btn_delete_book_Click);
            // 
            // btn_edit_book
            // 
            this.btn_edit_book.Location = new System.Drawing.Point(106, 378);
            this.btn_edit_book.Name = "btn_edit_book";
            this.btn_edit_book.Size = new System.Drawing.Size(81, 28);
            this.btn_edit_book.TabIndex = 14;
            this.btn_edit_book.Text = "Edit";
            this.btn_edit_book.UseVisualStyleBackColor = true;
            this.btn_edit_book.Click += new System.EventHandler(this.btn_edit_book_Click);
            // 
            // btn_add_book
            // 
            this.btn_add_book.Location = new System.Drawing.Point(19, 378);
            this.btn_add_book.Name = "btn_add_book";
            this.btn_add_book.Size = new System.Drawing.Size(81, 28);
            this.btn_add_book.TabIndex = 13;
            this.btn_add_book.Text = "Add";
            this.btn_add_book.UseVisualStyleBackColor = true;
            this.btn_add_book.Click += new System.EventHandler(this.btn_add_book_Click);
            // 
            // btn_search_book
            // 
            this.btn_search_book.Location = new System.Drawing.Point(283, 125);
            this.btn_search_book.Name = "btn_search_book";
            this.btn_search_book.Size = new System.Drawing.Size(81, 28);
            this.btn_search_book.TabIndex = 10;
            this.btn_search_book.Text = "Search";
            this.btn_search_book.UseVisualStyleBackColor = true;
            this.btn_search_book.Click += new System.EventHandler(this.btn_search_book_Click);
            // 
            // tb_search_book
            // 
            this.tb_search_book.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_search_book.Location = new System.Drawing.Point(19, 127);
            this.tb_search_book.Name = "tb_search_book";
            this.tb_search_book.Size = new System.Drawing.Size(258, 26);
            this.tb_search_book.TabIndex = 8;
            this.tb_search_book.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_search_book_KeyPress);
            // 
            // tb_stock_book
            // 
            this.tb_stock_book.Location = new System.Drawing.Point(115, 164);
            this.tb_stock_book.MaxLength = 5;
            this.tb_stock_book.Name = "tb_stock_book";
            this.tb_stock_book.Size = new System.Drawing.Size(224, 26);
            this.tb_stock_book.TabIndex = 12;
            this.tb_stock_book.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_stock_book_KeyPress);
            // 
            // tb_author_book
            // 
            this.tb_author_book.Location = new System.Drawing.Point(115, 98);
            this.tb_author_book.Name = "tb_author_book";
            this.tb_author_book.Size = new System.Drawing.Size(224, 26);
            this.tb_author_book.TabIndex = 10;
            // 
            // tb_name_book
            // 
            this.tb_name_book.Location = new System.Drawing.Point(115, 66);
            this.tb_name_book.Name = "tb_name_book";
            this.tb_name_book.Size = new System.Drawing.Size(224, 26);
            this.tb_name_book.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Stock:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Category:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Author Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Book Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Book Id:";
            // 
            // tb_id_book
            // 
            this.tb_id_book.Enabled = false;
            this.tb_id_book.Location = new System.Drawing.Point(115, 34);
            this.tb_id_book.Name = "tb_id_book";
            this.tb_id_book.Size = new System.Drawing.Size(224, 26);
            this.tb_id_book.TabIndex = 2;
            // 
            // gb_info_book
            // 
            this.gb_info_book.Controls.Add(this.gv_info_book);
            this.gb_info_book.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_info_book.Location = new System.Drawing.Point(370, 161);
            this.gb_info_book.Name = "gb_info_book";
            this.gb_info_book.Size = new System.Drawing.Size(636, 474);
            this.gb_info_book.TabIndex = 11;
            this.gb_info_book.TabStop = false;
            this.gb_info_book.Text = "All Book Info";
            // 
            // gv_info_book
            // 
            this.gv_info_book.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gv_info_book.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.gv_info_book.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_info_book.Location = new System.Drawing.Point(23, 31);
            this.gv_info_book.Name = "gv_info_book";
            this.gv_info_book.Size = new System.Drawing.Size(592, 422);
            this.gv_info_book.TabIndex = 1;
            this.gv_info_book.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_info_book_CellDoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cb_category_book);
            this.groupBox2.Controls.Add(this.tb_stock_book);
            this.groupBox2.Controls.Add(this.tb_author_book);
            this.groupBox2.Controls.Add(this.tb_name_book);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tb_id_book);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(19, 161);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(345, 206);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(468, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Book";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(389, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Category:";
            // 
            // cb_category_book
            // 
            this.cb_category_book.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_category_book.FormattingEnabled = true;
            this.cb_category_book.Items.AddRange(new object[] {
            "Select",
            "Finction",
            "Non Fiction",
            "Children"});
            this.cb_category_book.Location = new System.Drawing.Point(115, 130);
            this.cb_category_book.Name = "cb_category_book";
            this.cb_category_book.Size = new System.Drawing.Size(224, 28);
            this.cb_category_book.TabIndex = 13;
            // 
            // cb_search_book
            // 
            this.cb_search_book.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_search_book.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_search_book.FormattingEnabled = true;
            this.cb_search_book.Items.AddRange(new object[] {
            "All",
            "Finction",
            "Non Fiction",
            "Children"});
            this.cb_search_book.Location = new System.Drawing.Point(472, 127);
            this.cb_search_book.Name = "cb_search_book";
            this.cb_search_book.Size = new System.Drawing.Size(224, 28);
            this.cb_search_book.TabIndex = 14;
            this.cb_search_book.SelectedIndexChanged += new System.EventHandler(this.cb_search_book_SelectedIndexChanged);
            // 
            // btn_clear_book
            // 
            this.btn_clear_book.Location = new System.Drawing.Point(280, 378);
            this.btn_clear_book.Name = "btn_clear_book";
            this.btn_clear_book.Size = new System.Drawing.Size(81, 28);
            this.btn_clear_book.TabIndex = 16;
            this.btn_clear_book.Text = "Clear";
            this.btn_clear_book.UseVisualStyleBackColor = true;
            this.btn_clear_book.Click += new System.EventHandler(this.btn_clear_book_Click);
            // 
            // BookUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.Controls.Add(this.btn_clear_book);
            this.Controls.Add(this.cb_search_book);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_delete_book);
            this.Controls.Add(this.btn_edit_book);
            this.Controls.Add(this.btn_add_book);
            this.Controls.Add(this.btn_search_book);
            this.Controls.Add(this.tb_search_book);
            this.Controls.Add(this.gb_info_book);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Name = "BookUC";
            this.Size = new System.Drawing.Size(1022, 659);
            this.gb_info_book.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_info_book)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_delete_book;
        private System.Windows.Forms.Button btn_edit_book;
        private System.Windows.Forms.Button btn_add_book;
        private System.Windows.Forms.Button btn_search_book;
        private System.Windows.Forms.TextBox tb_search_book;
        private System.Windows.Forms.TextBox tb_stock_book;
        private System.Windows.Forms.TextBox tb_author_book;
        private System.Windows.Forms.TextBox tb_name_book;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_id_book;
        private System.Windows.Forms.GroupBox gb_info_book;
        private System.Windows.Forms.DataGridView gv_info_book;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_category_book;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_search_book;
        private System.Windows.Forms.Button btn_clear_book;
    }
}
