namespace SalesCarDealershipByMidili.Forms
{
    partial class SalesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesForm));
            this.salesDgv = new System.Windows.Forms.DataGridView();
            this.backBtn = new System.Windows.Forms.Button();
            this.searchTxt = new System.Windows.Forms.TextBox();
            this.srchBtn = new System.Windows.Forms.Button();
            this.expBtn = new System.Windows.Forms.Button();
            this.delBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.sumTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.phoneTxt = new System.Windows.Forms.MaskedTextBox();
            this.fioTxt = new System.Windows.Forms.TextBox();
            this.car_markTxt = new System.Windows.Forms.ComboBox();
            this.dateTxt = new System.Windows.Forms.DateTimePicker();
            this.markRb = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.telRb = new System.Windows.Forms.RadioButton();
            this.fioRb = new System.Windows.Forms.RadioButton();
            this.clrBtn = new System.Windows.Forms.Button();
            this.ascendingBtn = new System.Windows.Forms.Button();
            this.descendingBtn = new System.Windows.Forms.Button();
            this.sumRb = new System.Windows.Forms.RadioButton();
            this.dateRb = new System.Windows.Forms.RadioButton();
            this.modelRb = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.markFiltertxt = new System.Windows.Forms.ComboBox();
            this.clrFilterBtn = new System.Windows.Forms.Button();
            this.car_modelTxt = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.clrPoiskBtn = new System.Windows.Forms.Button();
            this.spisokBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.salesDgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // salesDgv
            // 
            this.salesDgv.AllowUserToAddRows = false;
            this.salesDgv.AllowUserToDeleteRows = false;
            this.salesDgv.BackgroundColor = System.Drawing.Color.White;
            this.salesDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salesDgv.Location = new System.Drawing.Point(12, 88);
            this.salesDgv.Name = "salesDgv";
            this.salesDgv.ReadOnly = true;
            this.salesDgv.Size = new System.Drawing.Size(974, 340);
            this.salesDgv.TabIndex = 1;
            this.salesDgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.salesDgv_CellClick);
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.Transparent;
            this.backBtn.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backBtn.Location = new System.Drawing.Point(12, 37);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(90, 34);
            this.backBtn.TabIndex = 11;
            this.backBtn.Text = "Назад";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // searchTxt
            // 
            this.searchTxt.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchTxt.Location = new System.Drawing.Point(157, 37);
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.Size = new System.Drawing.Size(247, 34);
            this.searchTxt.TabIndex = 12;
            this.searchTxt.MouseEnter += new System.EventHandler(this.searchTxt_MouseEnter);
            // 
            // srchBtn
            // 
            this.srchBtn.BackColor = System.Drawing.Color.Transparent;
            this.srchBtn.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.srchBtn.Location = new System.Drawing.Point(423, 37);
            this.srchBtn.Name = "srchBtn";
            this.srchBtn.Size = new System.Drawing.Size(208, 34);
            this.srchBtn.TabIndex = 13;
            this.srchBtn.Text = "Поиск";
            this.srchBtn.UseVisualStyleBackColor = false;
            this.srchBtn.Click += new System.EventHandler(this.srchBtn_Click);
            // 
            // expBtn
            // 
            this.expBtn.BackColor = System.Drawing.Color.Transparent;
            this.expBtn.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.expBtn.Location = new System.Drawing.Point(853, 641);
            this.expBtn.Name = "expBtn";
            this.expBtn.Size = new System.Drawing.Size(130, 56);
            this.expBtn.TabIndex = 10;
            this.expBtn.Text = "Экспорт";
            this.expBtn.UseVisualStyleBackColor = false;
            this.expBtn.Click += new System.EventHandler(this.expBtn_Click);
            this.expBtn.MouseEnter += new System.EventHandler(this.expBtn_MouseEnter);
            // 
            // delBtn
            // 
            this.delBtn.BackColor = System.Drawing.Color.Transparent;
            this.delBtn.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delBtn.Location = new System.Drawing.Point(613, 641);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(130, 56);
            this.delBtn.TabIndex = 9;
            this.delBtn.Text = "Удалить";
            this.delBtn.UseVisualStyleBackColor = false;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            this.delBtn.MouseEnter += new System.EventHandler(this.delBtn_MouseEnter);
            // 
            // editBtn
            // 
            this.editBtn.BackColor = System.Drawing.Color.Transparent;
            this.editBtn.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editBtn.Location = new System.Drawing.Point(325, 641);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(130, 56);
            this.editBtn.TabIndex = 8;
            this.editBtn.Text = "Изменить";
            this.editBtn.UseVisualStyleBackColor = false;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            this.editBtn.MouseEnter += new System.EventHandler(this.editBtn_MouseEnter);
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.Transparent;
            this.addBtn.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addBtn.Location = new System.Drawing.Point(17, 641);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(130, 56);
            this.addBtn.TabIndex = 7;
            this.addBtn.Text = "Добавить";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            this.addBtn.MouseEnter += new System.EventHandler(this.addBtn_MouseEnter);
            // 
            // sumTxt
            // 
            this.sumTxt.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sumTxt.Location = new System.Drawing.Point(794, 548);
            this.sumTxt.Name = "sumTxt";
            this.sumTxt.Size = new System.Drawing.Size(189, 34);
            this.sumTxt.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(548, 548);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 30);
            this.label8.TabIndex = 36;
            this.label8.Text = "Сумма";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(547, 505);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 30);
            this.label3.TabIndex = 35;
            this.label3.Text = "Дата";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(551, 456);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(237, 30);
            this.label4.TabIndex = 34;
            this.label4.Text = "Телефон покупателя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 544);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 30);
            this.label2.TabIndex = 33;
            this.label2.Text = "Фио покупателя";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 456);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 30);
            this.label1.TabIndex = 32;
            this.label1.Text = "Марка машины";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(152, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 27);
            this.label9.TabIndex = 52;
            this.label9.Text = "Поиск:";
            // 
            // phoneTxt
            // 
            this.phoneTxt.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.phoneTxt.Location = new System.Drawing.Point(794, 456);
            this.phoneTxt.Mask = "+00000000000";
            this.phoneTxt.Name = "phoneTxt";
            this.phoneTxt.Size = new System.Drawing.Size(189, 34);
            this.phoneTxt.TabIndex = 4;
            // 
            // fioTxt
            // 
            this.fioTxt.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fioTxt.Location = new System.Drawing.Point(209, 544);
            this.fioTxt.Name = "fioTxt";
            this.fioTxt.Size = new System.Drawing.Size(276, 34);
            this.fioTxt.TabIndex = 3;
            this.fioTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fioTxt_KeyPress);
            // 
            // car_markTxt
            // 
            this.car_markTxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.car_markTxt.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.car_markTxt.FormattingEnabled = true;
            this.car_markTxt.Location = new System.Drawing.Point(209, 456);
            this.car_markTxt.Name = "car_markTxt";
            this.car_markTxt.Size = new System.Drawing.Size(276, 35);
            this.car_markTxt.TabIndex = 2;
            this.car_markTxt.SelectedIndexChanged += new System.EventHandler(this.car_markTxt_SelectedIndexChanged);
            // 
            // dateTxt
            // 
            this.dateTxt.CustomFormat = "dd-MM-yyyy";
            this.dateTxt.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.dateTxt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTxt.Location = new System.Drawing.Point(794, 505);
            this.dateTxt.Name = "dateTxt";
            this.dateTxt.Size = new System.Drawing.Size(189, 34);
            this.dateTxt.TabIndex = 66;
            // 
            // markRb
            // 
            this.markRb.AutoSize = true;
            this.markRb.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.markRb.Location = new System.Drawing.Point(20, 33);
            this.markRb.Name = "markRb";
            this.markRb.Size = new System.Drawing.Size(174, 31);
            this.markRb.TabIndex = 67;
            this.markRb.TabStop = true;
            this.markRb.Text = "Марка машины";
            this.markRb.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.telRb);
            this.groupBox1.Controls.Add(this.fioRb);
            this.groupBox1.Controls.Add(this.clrBtn);
            this.groupBox1.Controls.Add(this.ascendingBtn);
            this.groupBox1.Controls.Add(this.descendingBtn);
            this.groupBox1.Controls.Add(this.sumRb);
            this.groupBox1.Controls.Add(this.dateRb);
            this.groupBox1.Controls.Add(this.modelRb);
            this.groupBox1.Controls.Add(this.markRb);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(1006, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 406);
            this.groupBox1.TabIndex = 68;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сортировка";
            // 
            // telRb
            // 
            this.telRb.AutoSize = true;
            this.telRb.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.telRb.Location = new System.Drawing.Point(20, 144);
            this.telRb.Name = "telRb";
            this.telRb.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.telRb.Size = new System.Drawing.Size(114, 31);
            this.telRb.TabIndex = 77;
            this.telRb.TabStop = true;
            this.telRb.Text = "Телефон";
            this.telRb.UseVisualStyleBackColor = true;
            // 
            // fioRb
            // 
            this.fioRb.AutoSize = true;
            this.fioRb.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.fioRb.Location = new System.Drawing.Point(20, 107);
            this.fioRb.Name = "fioRb";
            this.fioRb.Size = new System.Drawing.Size(71, 31);
            this.fioRb.TabIndex = 76;
            this.fioRb.TabStop = true;
            this.fioRb.Text = "ФИО";
            this.fioRb.UseVisualStyleBackColor = true;
            // 
            // clrBtn
            // 
            this.clrBtn.BackColor = System.Drawing.Color.White;
            this.clrBtn.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clrBtn.ForeColor = System.Drawing.Color.Black;
            this.clrBtn.Location = new System.Drawing.Point(20, 333);
            this.clrBtn.Name = "clrBtn";
            this.clrBtn.Size = new System.Drawing.Size(196, 34);
            this.clrBtn.TabIndex = 75;
            this.clrBtn.Text = "Очистить";
            this.clrBtn.UseVisualStyleBackColor = false;
            this.clrBtn.Click += new System.EventHandler(this.clrBtn_Click);
            // 
            // ascendingBtn
            // 
            this.ascendingBtn.BackColor = System.Drawing.Color.White;
            this.ascendingBtn.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ascendingBtn.ForeColor = System.Drawing.Color.Black;
            this.ascendingBtn.Location = new System.Drawing.Point(20, 252);
            this.ascendingBtn.Name = "ascendingBtn";
            this.ascendingBtn.Size = new System.Drawing.Size(196, 34);
            this.ascendingBtn.TabIndex = 73;
            this.ascendingBtn.Text = "По возрастанию";
            this.ascendingBtn.UseVisualStyleBackColor = false;
            this.ascendingBtn.Click += new System.EventHandler(this.ascendingBtn_Click);
            // 
            // descendingBtn
            // 
            this.descendingBtn.BackColor = System.Drawing.Color.White;
            this.descendingBtn.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descendingBtn.ForeColor = System.Drawing.Color.Black;
            this.descendingBtn.Location = new System.Drawing.Point(20, 292);
            this.descendingBtn.Name = "descendingBtn";
            this.descendingBtn.Size = new System.Drawing.Size(196, 34);
            this.descendingBtn.TabIndex = 74;
            this.descendingBtn.Text = "По убыванию";
            this.descendingBtn.UseVisualStyleBackColor = false;
            this.descendingBtn.Click += new System.EventHandler(this.descendingBtn_Click);
            // 
            // sumRb
            // 
            this.sumRb.AutoSize = true;
            this.sumRb.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.sumRb.Location = new System.Drawing.Point(20, 215);
            this.sumRb.Name = "sumRb";
            this.sumRb.Size = new System.Drawing.Size(92, 31);
            this.sumRb.TabIndex = 71;
            this.sumRb.TabStop = true;
            this.sumRb.Text = "Сумма";
            this.sumRb.UseVisualStyleBackColor = true;
            // 
            // dateRb
            // 
            this.dateRb.AutoSize = true;
            this.dateRb.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.dateRb.Location = new System.Drawing.Point(20, 178);
            this.dateRb.Name = "dateRb";
            this.dateRb.Size = new System.Drawing.Size(76, 31);
            this.dateRb.TabIndex = 70;
            this.dateRb.TabStop = true;
            this.dateRb.Text = "Дата";
            this.dateRb.UseVisualStyleBackColor = true;
            // 
            // modelRb
            // 
            this.modelRb.AutoSize = true;
            this.modelRb.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.modelRb.Location = new System.Drawing.Point(20, 70);
            this.modelRb.Name = "modelRb";
            this.modelRb.Size = new System.Drawing.Size(187, 31);
            this.modelRb.TabIndex = 68;
            this.modelRb.TabStop = true;
            this.modelRb.Text = "Модель машины";
            this.modelRb.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.markFiltertxt);
            this.groupBox2.Controls.Add(this.clrFilterBtn);
            this.groupBox2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(1255, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(251, 175);
            this.groupBox2.TabIndex = 72;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Фильтр по марке машины";
            // 
            // markFiltertxt
            // 
            this.markFiltertxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.markFiltertxt.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.markFiltertxt.FormattingEnabled = true;
            this.markFiltertxt.Items.AddRange(new object[] {
            "<Выберите>"});
            this.markFiltertxt.Location = new System.Drawing.Point(17, 69);
            this.markFiltertxt.Name = "markFiltertxt";
            this.markFiltertxt.Size = new System.Drawing.Size(208, 35);
            this.markFiltertxt.TabIndex = 76;
            this.markFiltertxt.SelectedIndexChanged += new System.EventHandler(this.markFiltertxt_SelectedIndexChanged);
            // 
            // clrFilterBtn
            // 
            this.clrFilterBtn.BackColor = System.Drawing.Color.White;
            this.clrFilterBtn.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clrFilterBtn.ForeColor = System.Drawing.Color.Black;
            this.clrFilterBtn.Location = new System.Drawing.Point(17, 110);
            this.clrFilterBtn.Name = "clrFilterBtn";
            this.clrFilterBtn.Size = new System.Drawing.Size(208, 45);
            this.clrFilterBtn.TabIndex = 75;
            this.clrFilterBtn.Text = "Очистить";
            this.clrFilterBtn.UseVisualStyleBackColor = false;
            this.clrFilterBtn.Click += new System.EventHandler(this.clrFilterBtn_Click);
            // 
            // car_modelTxt
            // 
            this.car_modelTxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.car_modelTxt.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.car_modelTxt.FormattingEnabled = true;
            this.car_modelTxt.Location = new System.Drawing.Point(209, 500);
            this.car_modelTxt.Name = "car_modelTxt";
            this.car_modelTxt.Size = new System.Drawing.Size(276, 35);
            this.car_modelTxt.TabIndex = 73;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 497);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 30);
            this.label5.TabIndex = 74;
            this.label5.Text = "Модель машины";
            // 
            // clrPoiskBtn
            // 
            this.clrPoiskBtn.BackColor = System.Drawing.Color.Transparent;
            this.clrPoiskBtn.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clrPoiskBtn.Location = new System.Drawing.Point(652, 36);
            this.clrPoiskBtn.Name = "clrPoiskBtn";
            this.clrPoiskBtn.Size = new System.Drawing.Size(196, 34);
            this.clrPoiskBtn.TabIndex = 76;
            this.clrPoiskBtn.Text = "Очистить";
            this.clrPoiskBtn.UseVisualStyleBackColor = false;
            this.clrPoiskBtn.Click += new System.EventHandler(this.clrPoiskBtn_Click);
            // 
            // spisokBtn
            // 
            this.spisokBtn.BackColor = System.Drawing.Color.White;
            this.spisokBtn.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spisokBtn.Location = new System.Drawing.Point(1272, 293);
            this.spisokBtn.Name = "spisokBtn";
            this.spisokBtn.Size = new System.Drawing.Size(208, 125);
            this.spisokBtn.TabIndex = 82;
            this.spisokBtn.Text = "Вывод данных в виде списка";
            this.spisokBtn.UseVisualStyleBackColor = false;
            this.spisokBtn.Click += new System.EventHandler(this.spisokBtn_Click);
            // 
            // SalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SalesCarDealershipByMidili.Properties.Resources.car_dashboard_and_wheel_close_up;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1518, 719);
            this.Controls.Add(this.spisokBtn);
            this.Controls.Add(this.clrPoiskBtn);
            this.Controls.Add(this.car_modelTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dateTxt);
            this.Controls.Add(this.phoneTxt);
            this.Controls.Add(this.car_markTxt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.expBtn);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.sumTxt);
            this.Controls.Add(this.fioTxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchTxt);
            this.Controls.Add(this.srchBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.salesDgv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1019, 385);
            this.Name = "SalesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Продажи";
            this.Load += new System.EventHandler(this.SalesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.salesDgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView salesDgv;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.TextBox searchTxt;
        private System.Windows.Forms.Button srchBtn;
        private System.Windows.Forms.Button expBtn;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.TextBox sumTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox phoneTxt;
        private System.Windows.Forms.TextBox fioTxt;
        private System.Windows.Forms.ComboBox car_markTxt;
        private System.Windows.Forms.DateTimePicker dateTxt;
        private System.Windows.Forms.RadioButton markRb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton sumRb;
        private System.Windows.Forms.RadioButton dateRb;
        private System.Windows.Forms.RadioButton modelRb;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button clrFilterBtn;
        private System.Windows.Forms.Button ascendingBtn;
        private System.Windows.Forms.Button descendingBtn;
        private System.Windows.Forms.Button clrBtn;
        private System.Windows.Forms.ComboBox car_modelTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button clrPoiskBtn;
        private System.Windows.Forms.RadioButton telRb;
        private System.Windows.Forms.RadioButton fioRb;
        private System.Windows.Forms.ComboBox markFiltertxt;
        private System.Windows.Forms.Button spisokBtn;
    }
}