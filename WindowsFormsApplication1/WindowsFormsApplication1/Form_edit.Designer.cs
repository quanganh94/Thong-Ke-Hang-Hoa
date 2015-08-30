namespace WindowsFormsApplication1
{
    partial class Form_edit
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cb_number = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_date = new System.Windows.Forms.ComboBox();
            this.cb_month = new System.Windows.Forms.ComboBox();
            this.cb_year = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dg_list = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phieuthanhtoanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataDataSet = new WindowsFormsApplication1.DataDataSet();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dg_edited = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.new_inventor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.done = new System.Windows.Forms.PictureBox();
            this.loading = new System.Windows.Forms.PictureBox();
            this.mathang = new System.Windows.Forms.Label();
            this.gia = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tonkho = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.phieuthanhtoanTableAdapter = new WindowsFormsApplication1.DataDataSetTableAdapters.phieuthanhtoanTableAdapter();
            this.thucDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.thucDonTableAdapter = new WindowsFormsApplication1.DataDataSetTableAdapters.ThucDonTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication1.DataDataSetTableAdapters.TableAdapterManager();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuthanhtoanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_edited)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.done)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thucDonBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Năm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tháng:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.cb_number);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cb_date);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cb_month);
            this.groupBox1.Controls.Add(this.cb_year);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 220);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 43);
            this.button1.TabIndex = 8;
            this.button1.Text = "Lưu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cb_number
            // 
            this.cb_number.FormattingEnabled = true;
            this.cb_number.Location = new System.Drawing.Point(81, 125);
            this.cb_number.Name = "cb_number";
            this.cb_number.Size = new System.Drawing.Size(97, 21);
            this.cb_number.TabIndex = 7;
            this.cb_number.SelectedIndexChanged += new System.EventHandler(this.cb_number_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Số Phiếu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ngày:";
            // 
            // cb_date
            // 
            this.cb_date.FormattingEnabled = true;
            this.cb_date.Location = new System.Drawing.Point(81, 92);
            this.cb_date.Name = "cb_date";
            this.cb_date.Size = new System.Drawing.Size(97, 21);
            this.cb_date.TabIndex = 2;
            this.cb_date.SelectedIndexChanged += new System.EventHandler(this.cb_date_SelectedIndexChanged);
            // 
            // cb_month
            // 
            this.cb_month.FormattingEnabled = true;
            this.cb_month.Location = new System.Drawing.Point(81, 60);
            this.cb_month.Name = "cb_month";
            this.cb_month.Size = new System.Drawing.Size(97, 21);
            this.cb_month.TabIndex = 1;
            this.cb_month.SelectedIndexChanged += new System.EventHandler(this.cb_month_SelectedIndexChanged);
            // 
            // cb_year
            // 
            this.cb_year.FormattingEnabled = true;
            this.cb_year.Location = new System.Drawing.Point(81, 27);
            this.cb_year.Name = "cb_year";
            this.cb_year.Size = new System.Drawing.Size(97, 21);
            this.cb_year.TabIndex = 0;
            this.cb_year.SelectedIndexChanged += new System.EventHandler(this.cb_year_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dg_list);
            this.groupBox2.Location = new System.Drawing.Point(225, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(445, 206);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Phiếu Thanh Toán";
            // 
            // dg_list
            // 
            this.dg_list.AutoGenerateColumns = false;
            this.dg_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_list.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.quantity});
            this.dg_list.DataSource = this.phieuthanhtoanBindingSource;
            this.dg_list.Location = new System.Drawing.Point(7, 19);
            this.dg_list.Name = "dg_list";
            this.dg_list.Size = new System.Drawing.Size(432, 195);
            this.dg_list.TabIndex = 0;
            this.dg_list.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_list_CellContentClick);
            this.dg_list.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_list_CellEndEdit);
            this.dg_list.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dg_list_CellValidating);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // quantity
            // 
            this.quantity.DataPropertyName = "quantity";
            this.quantity.HeaderText = "quantity";
            this.quantity.Name = "quantity";
            // 
            // phieuthanhtoanBindingSource
            // 
            this.phieuthanhtoanBindingSource.DataMember = "phieuthanhtoan";
            this.phieuthanhtoanBindingSource.DataSource = this.dataDataSet;
            // 
            // dataDataSet
            // 
            this.dataDataSet.DataSetName = "DataDataSet";
            this.dataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dg_edited);
            this.groupBox3.Location = new System.Drawing.Point(13, 240);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(829, 173);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Đã sửa";
            // 
            // dg_edited
            // 
            this.dg_edited.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_edited.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.price,
            this.inventor,
            this.new_inventor});
            this.dg_edited.Location = new System.Drawing.Point(7, 20);
            this.dg_edited.Name = "dg_edited";
            this.dg_edited.Size = new System.Drawing.Size(816, 147);
            this.dg_edited.TabIndex = 0;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.HeaderText = "Tên mặt hàng";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // price
            // 
            this.price.HeaderText = "Giá";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Width = 150;
            // 
            // inventor
            // 
            this.inventor.HeaderText = "Tồn Kho ban đầu";
            this.inventor.Name = "inventor";
            this.inventor.ReadOnly = true;
            this.inventor.Width = 150;
            // 
            // new_inventor
            // 
            this.new_inventor.HeaderText = "Tồn kho sau khi sửa ";
            this.new_inventor.Name = "new_inventor";
            this.new_inventor.Width = 150;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.done);
            this.groupBox4.Controls.Add(this.loading);
            this.groupBox4.Controls.Add(this.mathang);
            this.groupBox4.Controls.Add(this.gia);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.tonkho);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(676, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(166, 220);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông Tin";
            // 
            // done
            // 
            this.done.Image = global::WindowsFormsApplication1.Properties.Resources.done;
            this.done.Location = new System.Drawing.Point(53, 161);
            this.done.Name = "done";
            this.done.Size = new System.Drawing.Size(50, 50);
            this.done.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.done.TabIndex = 6;
            this.done.TabStop = false;
            this.done.Visible = false;
            // 
            // loading
            // 
            this.loading.Image = global::WindowsFormsApplication1.Properties.Resources.ajax_loader__2_;
            this.loading.Location = new System.Drawing.Point(66, 171);
            this.loading.Name = "loading";
            this.loading.Size = new System.Drawing.Size(32, 32);
            this.loading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.loading.TabIndex = 5;
            this.loading.TabStop = false;
            this.loading.Visible = false;
            // 
            // mathang
            // 
            this.mathang.AutoSize = true;
            this.mathang.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mathang.Location = new System.Drawing.Point(6, 46);
            this.mathang.Name = "mathang";
            this.mathang.Size = new System.Drawing.Size(0, 13);
            this.mathang.TabIndex = 4;
            // 
            // gia
            // 
            this.gia.AutoSize = true;
            this.gia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gia.Location = new System.Drawing.Point(63, 129);
            this.gia.Name = "gia";
            this.gia.Size = new System.Drawing.Size(0, 18);
            this.gia.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Giá:";
            // 
            // tonkho
            // 
            this.tonkho.AutoSize = true;
            this.tonkho.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tonkho.Location = new System.Drawing.Point(63, 86);
            this.tonkho.Name = "tonkho";
            this.tonkho.Size = new System.Drawing.Size(0, 18);
            this.tonkho.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tồn Kho:";
            // 
            // phieuthanhtoanTableAdapter
            // 
            this.phieuthanhtoanTableAdapter.ClearBeforeFill = true;
            // 
            // thucDonBindingSource
            // 
            this.thucDonBindingSource.DataMember = "ThucDon";
            this.thucDonBindingSource.DataSource = this.dataDataSet;
            // 
            // thucDonTableAdapter
            // 
            this.thucDonTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.KHTableAdapter = null;
            this.tableAdapterManager.phieuthanhtoanTableAdapter = this.phieuthanhtoanTableAdapter;
            this.tableAdapterManager.ThucDonTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication1.DataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.UpdateInsertDelete;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(569, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Hiện tất cả";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form_edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 421);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_edit";
            this.Text = "Form_edit";
            this.Load += new System.EventHandler(this.Form_edit_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuthanhtoanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_edited)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.done)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thucDonBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cb_number;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private DataDataSet dataDataSet;
        private DataDataSetTableAdapters.phieuthanhtoanTableAdapter phieuthanhtoanTableAdapter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dg_list;
        private System.Windows.Forms.BindingSource thucDonBindingSource;
        private DataDataSetTableAdapters.ThucDonTableAdapter thucDonTableAdapter;
        private System.Windows.Forms.ComboBox cb_date;
        private System.Windows.Forms.ComboBox cb_month;
        private System.Windows.Forms.ComboBox cb_year;
        private System.Windows.Forms.Button button1;

        private DataDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dg_edited;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn inventor;
        private System.Windows.Forms.DataGridViewTextBoxColumn new_inventor;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label gia;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label tonkho;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label mathang;
        private System.Windows.Forms.PictureBox done;
        private System.Windows.Forms.PictureBox loading;
        private System.Windows.Forms.BindingSource phieuthanhtoanBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.Button button2;
    }
}