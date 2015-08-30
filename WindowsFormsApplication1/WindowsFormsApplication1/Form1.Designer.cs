namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.date = new System.Windows.Forms.ComboBox();
            this.month = new System.Windows.Forms.ComboBox();
            this.year = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.number = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbx_name = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dg_data = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thucDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataDataSet = new WindowsFormsApplication1.DataDataSet();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.KH = new System.Windows.Forms.ComboBox();
            this.kHBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.kHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.soluong = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.lb_sum = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.Button();
            this.dataDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kHTableAdapter1 = new WindowsFormsApplication1.DataDataSetTableAdapters.KHTableAdapter();
            this.thucDonTableAdapter = new WindowsFormsApplication1.DataDataSetTableAdapters.ThucDonTableAdapter();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_thanhtien = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.loading = new System.Windows.Forms.PictureBox();
            this.done = new System.Windows.Forms.PictureBox();
            this.unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_list = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.hd_num = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.hd_year = new System.Windows.Forms.ComboBox();
            this.hd_month = new System.Windows.Forms.ComboBox();
            this.hd_date = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dg_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thucDonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soluong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.done)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_list)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Khách hàng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 1;
            this.label2.Tag = "c";
            this.label2.Text = "Ngày Thu:";
            // 
            // date
            // 
            this.date.FormattingEnabled = true;
            this.date.Location = new System.Drawing.Point(152, 52);
            this.date.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(60, 28);
            this.date.TabIndex = 3;
            // 
            // month
            // 
            this.month.FormattingEnabled = true;
            this.month.Location = new System.Drawing.Point(222, 52);
            this.month.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.month.Name = "month";
            this.month.Size = new System.Drawing.Size(78, 28);
            this.month.TabIndex = 4;
            // 
            // year
            // 
            this.year.FormattingEnabled = true;
            this.year.Location = new System.Drawing.Point(312, 51);
            this.year.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(124, 28);
            this.year.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(156, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ngày";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(230, 22);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tháng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(346, 20);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Năm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(498, 22);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Số Phiếu";
            // 
            // number
            // 
            this.number.Location = new System.Drawing.Point(464, 52);
            this.number.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(148, 26);
            this.number.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 238);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Tên Hàng:";
            // 
            // tbx_name
            // 
            this.tbx_name.Location = new System.Drawing.Point(150, 238);
            this.tbx_name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbx_name.Name = "tbx_name";
            this.tbx_name.Size = new System.Drawing.Size(148, 26);
            this.tbx_name.TabIndex = 13;
            this.tbx_name.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.tbx_name.DoubleClick += new System.EventHandler(this.tbx_name_DoubleClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(47, 274);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Số Lượng:";
            // 
            // dg_data
            // 
            this.dg_data.AllowUserToAddRows = false;
            this.dg_data.AllowUserToDeleteRows = false;
            this.dg_data.AutoGenerateColumns = false;
            this.dg_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.unitDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.inventor});
            this.dg_data.DataSource = this.thucDonBindingSource;
            this.dg_data.Location = new System.Drawing.Point(18, 330);
            this.dg_data.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dg_data.Name = "dg_data";
            this.dg_data.ReadOnly = true;
            this.dg_data.Size = new System.Drawing.Size(610, 453);
            this.dg_data.TabIndex = 17;
            this.dg_data.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Tên mặt hàng";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // unitDataGridViewTextBoxColumn
            // 
            this.unitDataGridViewTextBoxColumn.DataPropertyName = "unit";
            this.unitDataGridViewTextBoxColumn.HeaderText = "Đơn vị";
            this.unitDataGridViewTextBoxColumn.Name = "unitDataGridViewTextBoxColumn";
            this.unitDataGridViewTextBoxColumn.ReadOnly = true;
            this.unitDataGridViewTextBoxColumn.Width = 80;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Giá";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // inventor
            // 
            this.inventor.DataPropertyName = "inventor";
            this.inventor.HeaderText = "Tồn kho";
            this.inventor.Name = "inventor";
            this.inventor.ReadOnly = true;
            this.inventor.Width = 50;
            // 
            // thucDonBindingSource
            // 
            this.thucDonBindingSource.DataMember = "ThucDon";
            this.thucDonBindingSource.DataSource = this.dataDataSet;
            this.thucDonBindingSource.CurrentChanged += new System.EventHandler(this.thucDonBindingSource_CurrentChanged);
            // 
            // dataDataSet
            // 
            this.dataDataSet.DataSetName = "DataDataSet";
            this.dataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(18, 12);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 31);
            this.button2.TabIndex = 18;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1104, 792);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(224, 55);
            this.button3.TabIndex = 19;
            this.button3.Text = "Lưu Phiếu";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // KH
            // 
            this.KH.DataSource = this.kHBindingSource1;
            this.KH.DisplayMember = "name";
            this.KH.FormattingEnabled = true;
            this.KH.Location = new System.Drawing.Point(152, 95);
            this.KH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.KH.Name = "KH";
            this.KH.Size = new System.Drawing.Size(478, 28);
            this.KH.TabIndex = 20;
            this.KH.ValueMember = "name";
            this.KH.DoubleClick += new System.EventHandler(this.KH_DoubleClick);
            this.KH.SelectedIndexChanged += new System.EventHandler(this.KH_SelectedIndexChanged);
            // 
            // kHBindingSource1
            // 
            this.kHBindingSource1.DataMember = "KH";
            this.kHBindingSource1.DataSource = this.dataDataSet;
            // 
            // soluong
            // 
            this.soluong.Location = new System.Drawing.Point(150, 268);
            this.soluong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.soluong.Name = "soluong";
            this.soluong.Size = new System.Drawing.Size(62, 26);
            this.soluong.TabIndex = 21;
            this.soluong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.soluong.ValueChanged += new System.EventHandler(this.soluong_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(496, 803);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 30);
            this.label9.TabIndex = 22;
            this.label9.Text = "Tổng Tiền: ";
            // 
            // lb_sum
            // 
            this.lb_sum.AutoSize = true;
            this.lb_sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sum.ForeColor = System.Drawing.Color.DarkRed;
            this.lb_sum.Location = new System.Drawing.Point(633, 792);
            this.lb_sum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_sum.Name = "lb_sum";
            this.lb_sum.Size = new System.Drawing.Size(0, 46);
            this.lb_sum.TabIndex = 23;
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(39, 803);
            this.btn_update.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(174, 57);
            this.btn_update.TabIndex = 24;
            this.btn_update.Text = "Cập nhật giá";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // dataDataSetBindingSource
            // 
            this.dataDataSetBindingSource.DataSource = this.dataDataSet;
            this.dataDataSetBindingSource.Position = 0;
            // 
            // kHTableAdapter1
            // 
            this.kHTableAdapter1.ClearBeforeFill = true;
            // 
            // thucDonTableAdapter
            // 
            this.thucDonTableAdapter.ClearBeforeFill = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(496, 901);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(142, 29);
            this.label10.TabIndex = 25;
            this.label10.Text = "Thành Tiền:";
            // 
            // lbl_thanhtien
            // 
            this.lbl_thanhtien.AutoSize = true;
            this.lbl_thanhtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_thanhtien.ForeColor = System.Drawing.Color.Navy;
            this.lbl_thanhtien.Location = new System.Drawing.Point(662, 898);
            this.lbl_thanhtien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_thanhtien.Name = "lbl_thanhtien";
            this.lbl_thanhtien.Size = new System.Drawing.Size(0, 30);
            this.lbl_thanhtien.TabIndex = 26;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(39, 887);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 57);
            this.button1.TabIndex = 27;
            this.button1.Text = "Sửa phiếu cũ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // loading
            // 
            this.loading.Image = global::WindowsFormsApplication1.Properties.Resources.ajax_loader__2_;
            this.loading.Location = new System.Drawing.Point(1194, 883);
            this.loading.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.loading.Name = "loading";
            this.loading.Size = new System.Drawing.Size(32, 32);
            this.loading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.loading.TabIndex = 28;
            this.loading.TabStop = false;
            this.loading.Visible = false;
            // 
            // done
            // 
            this.done.Image = global::WindowsFormsApplication1.Properties.Resources.done;
            this.done.Location = new System.Drawing.Point(1180, 867);
            this.done.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.done.Name = "done";
            this.done.Size = new System.Drawing.Size(50, 50);
            this.done.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.done.TabIndex = 29;
            this.done.TabStop = false;
            this.done.Visible = false;
            // 
            // unit
            // 
            this.unit.HeaderText = "Đơn vị";
            this.unit.Name = "unit";
            this.unit.Width = 70;
            // 
            // count
            // 
            this.count.HeaderText = "Số lượng";
            this.count.Name = "count";
            this.count.Width = 40;
            // 
            // price
            // 
            this.price.HeaderText = "Giá";
            this.price.Name = "price";
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.HeaderText = "Tên mặt hàng";
            this.name.Name = "name";
            // 
            // dg_list
            // 
            this.dg_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_list.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.price,
            this.count,
            this.unit});
            this.dg_list.Location = new System.Drawing.Point(642, 22);
            this.dg_list.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dg_list.Name = "dg_list";
            this.dg_list.Size = new System.Drawing.Size(686, 760);
            this.dg_list.TabIndex = 11;
            this.dg_list.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dg_list.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dg_list.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dg_list.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.Delete_Item);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 144);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(163, 20);
            this.label11.TabIndex = 30;
            this.label11.Text = "Đính kèm hóa đơn số:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(78, 205);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 20);
            this.label12.TabIndex = 31;
            this.label12.Text = "Ngày:";
            // 
            // hd_num
            // 
            this.hd_num.Location = new System.Drawing.Point(184, 141);
            this.hd_num.Name = "hd_num";
            this.hd_num.Size = new System.Drawing.Size(269, 26);
            this.hd_num.TabIndex = 32;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(346, 173);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 20);
            this.label13.TabIndex = 36;
            this.label13.Text = "Năm";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(230, 175);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 20);
            this.label14.TabIndex = 35;
            this.label14.Text = "Tháng";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(156, 175);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(45, 20);
            this.label15.TabIndex = 34;
            this.label15.Text = "Ngày";
            // 
            // hd_year
            // 
            this.hd_year.FormattingEnabled = true;
            this.hd_year.Location = new System.Drawing.Point(310, 201);
            this.hd_year.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.hd_year.Name = "hd_year";
            this.hd_year.Size = new System.Drawing.Size(124, 28);
            this.hd_year.TabIndex = 41;
            // 
            // hd_month
            // 
            this.hd_month.FormattingEnabled = true;
            this.hd_month.Location = new System.Drawing.Point(220, 202);
            this.hd_month.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.hd_month.Name = "hd_month";
            this.hd_month.Size = new System.Drawing.Size(78, 28);
            this.hd_month.TabIndex = 40;
            // 
            // hd_date
            // 
            this.hd_date.FormattingEnabled = true;
            this.hd_date.Location = new System.Drawing.Point(150, 202);
            this.hd_date.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.hd_date.Name = "hd_date";
            this.hd_date.Size = new System.Drawing.Size(60, 28);
            this.hd_date.TabIndex = 39;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(994, 973);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(164, 39);
            this.button4.TabIndex = 42;
            this.button4.Text = "Xem bản in";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1164, 973);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(164, 39);
            this.button5.TabIndex = 43;
            this.button5.Text = "In Phiếu";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(822, 981);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(148, 24);
            this.checkBox1.TabIndex = 44;
            this.checkBox1.Text = "Tự in sau khi lưu";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 1053);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.hd_year);
            this.Controls.Add(this.hd_month);
            this.Controls.Add(this.hd_date);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.hd_num);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.done);
            this.Controls.Add(this.loading);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_thanhtien);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.lb_sum);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.soluong);
            this.Controls.Add(this.KH);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dg_data);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbx_name);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dg_list);
            this.Controls.Add(this.number);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.year);
            this.Controls.Add(this.month);
            this.Controls.Add(this.date);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Phiếu Thanh Toán";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.Form1_Closing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thucDonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soluong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.done)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_list)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox date;
        private System.Windows.Forms.ComboBox month;
        private System.Windows.Forms.ComboBox year;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox number;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbx_name;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dg_data;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox KH;
        private System.Windows.Forms.BindingSource kHBindingSource;
        private System.Windows.Forms.NumericUpDown soluong;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lb_sum;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.BindingSource dataDataSetBindingSource;
        private DataDataSet dataDataSet;
        private System.Windows.Forms.BindingSource kHBindingSource1;
        private DataDataSetTableAdapters.KHTableAdapter kHTableAdapter1;
        private System.Windows.Forms.BindingSource thucDonBindingSource;
        private DataDataSetTableAdapters.ThucDonTableAdapter thucDonTableAdapter;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl_thanhtien;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox loading;
        private System.Windows.Forms.PictureBox done;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn count;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridView dg_list;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inventor;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox hd_num;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox hd_year;
        private System.Windows.Forms.ComboBox hd_month;
        private System.Windows.Forms.ComboBox hd_date;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

