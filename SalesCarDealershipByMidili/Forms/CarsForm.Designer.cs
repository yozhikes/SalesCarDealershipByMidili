namespace SalesCarDealershipByMidili.Forms
{
    partial class CarsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarsForm));
            this.carsDgv = new System.Windows.Forms.DataGridView();
            this.backBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.markTxt = new System.Windows.Forms.TextBox();
            this.modelTxt = new System.Windows.Forms.TextBox();
            this.transmissionTxt = new System.Windows.Forms.ComboBox();
            this.fuelTxt = new System.Windows.Forms.ComboBox();
            this.qtyTxt = new System.Windows.Forms.TextBox();
            this.powerTxt = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.delBtn = new System.Windows.Forms.Button();
            this.expBtn = new System.Windows.Forms.Button();
            this.year_releaseTxt = new System.Windows.Forms.MaskedTextBox();
            this.body_typeTxt = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.markFiltertxt = new System.Windows.Forms.ComboBox();
            this.clrFilterBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.qtyRb = new System.Windows.Forms.RadioButton();
            this.yearRb = new System.Windows.Forms.RadioButton();
            this.kpRb = new System.Windows.Forms.RadioButton();
            this.kuzovRb = new System.Windows.Forms.RadioButton();
            this.clrBtn = new System.Windows.Forms.Button();
            this.ascendingBtn = new System.Windows.Forms.Button();
            this.descendingBtn = new System.Windows.Forms.Button();
            this.fuelRb = new System.Windows.Forms.RadioButton();
            this.volRb = new System.Windows.Forms.RadioButton();
            this.modelRb = new System.Windows.Forms.RadioButton();
            this.markRb = new System.Windows.Forms.RadioButton();
            this.clrPoiskBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.searchTxt = new System.Windows.Forms.TextBox();
            this.srchBtn = new System.Windows.Forms.Button();
            this.spisokBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.carsDgv)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // carsDgv
            // 
            this.carsDgv.AllowUserToAddRows = false;
            this.carsDgv.AllowUserToDeleteRows = false;
            this.carsDgv.BackgroundColor = System.Drawing.Color.White;
            this.carsDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carsDgv.Location = new System.Drawing.Point(12, 91);
            this.carsDgv.Name = "carsDgv";
            this.carsDgv.ReadOnly = true;
            this.carsDgv.Size = new System.Drawing.Size(961, 371);
            this.carsDgv.TabIndex = 0;
            this.carsDgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.carsDgv_CellClick);
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.White;
            this.backBtn.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backBtn.Location = new System.Drawing.Point(12, 35);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(90, 34);
            this.backBtn.TabIndex = 13;
            this.backBtn.Text = "Назад";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 487);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 30);
            this.label1.TabIndex = 7;
            this.label1.Text = "Марка";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(17, 530);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 30);
            this.label2.TabIndex = 8;
            this.label2.Text = "Модель";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(17, 613);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 30);
            this.label3.TabIndex = 10;
            this.label3.Text = "Коробка передач";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(17, 570);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 30);
            this.label4.TabIndex = 9;
            this.label4.Text = "Кузов";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(514, 618);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 30);
            this.label5.TabIndex = 14;
            this.label5.Text = "Количество";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(514, 571);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 30);
            this.label6.TabIndex = 13;
            this.label6.Text = "Год выпуска";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(514, 531);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 30);
            this.label7.TabIndex = 12;
            this.label7.Text = "Тип топлива";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(514, 488);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(175, 30);
            this.label8.TabIndex = 11;
            this.label8.Text = "Мощность(л.с.)";
            // 
            // markTxt
            // 
            this.markTxt.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.markTxt.Location = new System.Drawing.Point(129, 484);
            this.markTxt.Name = "markTxt";
            this.markTxt.Size = new System.Drawing.Size(352, 34);
            this.markTxt.TabIndex = 1;
            // 
            // modelTxt
            // 
            this.modelTxt.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.modelTxt.Location = new System.Drawing.Point(129, 530);
            this.modelTxt.Name = "modelTxt";
            this.modelTxt.Size = new System.Drawing.Size(352, 34);
            this.modelTxt.TabIndex = 2;
            // 
            // transmissionTxt
            // 
            this.transmissionTxt.BackColor = System.Drawing.Color.White;
            this.transmissionTxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.transmissionTxt.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.transmissionTxt.FormattingEnabled = true;
            this.transmissionTxt.Items.AddRange(new object[] {
            "Механика",
            "Автомат",
            "Робот",
            "Вариатор"});
            this.transmissionTxt.Location = new System.Drawing.Point(210, 613);
            this.transmissionTxt.Name = "transmissionTxt";
            this.transmissionTxt.Size = new System.Drawing.Size(271, 35);
            this.transmissionTxt.TabIndex = 4;
            // 
            // fuelTxt
            // 
            this.fuelTxt.BackColor = System.Drawing.Color.White;
            this.fuelTxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fuelTxt.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fuelTxt.FormattingEnabled = true;
            this.fuelTxt.Items.AddRange(new object[] {
            "Бензин",
            "Дизель",
            "Газ",
            "Водород"});
            this.fuelTxt.Location = new System.Drawing.Point(685, 530);
            this.fuelTxt.Name = "fuelTxt";
            this.fuelTxt.Size = new System.Drawing.Size(288, 35);
            this.fuelTxt.TabIndex = 6;
            // 
            // qtyTxt
            // 
            this.qtyTxt.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.qtyTxt.Location = new System.Drawing.Point(685, 617);
            this.qtyTxt.Name = "qtyTxt";
            this.qtyTxt.Size = new System.Drawing.Size(288, 34);
            this.qtyTxt.TabIndex = 8;
            // 
            // powerTxt
            // 
            this.powerTxt.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.powerTxt.Location = new System.Drawing.Point(710, 487);
            this.powerTxt.Name = "powerTxt";
            this.powerTxt.Size = new System.Drawing.Size(263, 34);
            this.powerTxt.TabIndex = 5;
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.White;
            this.addBtn.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addBtn.Location = new System.Drawing.Point(22, 675);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(130, 56);
            this.addBtn.TabIndex = 9;
            this.addBtn.Text = "Добавить";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            this.addBtn.MouseEnter += new System.EventHandler(this.addBtn_MouseEnter);
            // 
            // editBtn
            // 
            this.editBtn.BackColor = System.Drawing.Color.White;
            this.editBtn.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editBtn.Location = new System.Drawing.Point(314, 675);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(130, 56);
            this.editBtn.TabIndex = 10;
            this.editBtn.Text = "Изменить";
            this.editBtn.UseVisualStyleBackColor = false;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            this.editBtn.MouseEnter += new System.EventHandler(this.editBtn_MouseEnter);
            // 
            // delBtn
            // 
            this.delBtn.BackColor = System.Drawing.Color.White;
            this.delBtn.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delBtn.Location = new System.Drawing.Point(583, 675);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(130, 56);
            this.delBtn.TabIndex = 11;
            this.delBtn.Text = "Удалить";
            this.delBtn.UseVisualStyleBackColor = false;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            this.delBtn.MouseEnter += new System.EventHandler(this.delBtn_MouseEnter);
            // 
            // expBtn
            // 
            this.expBtn.BackColor = System.Drawing.Color.White;
            this.expBtn.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.expBtn.Location = new System.Drawing.Point(843, 675);
            this.expBtn.Name = "expBtn";
            this.expBtn.Size = new System.Drawing.Size(130, 56);
            this.expBtn.TabIndex = 12;
            this.expBtn.Text = "Экспорт";
            this.expBtn.UseVisualStyleBackColor = false;
            this.expBtn.Click += new System.EventHandler(this.expBtn_Click);
            this.expBtn.MouseEnter += new System.EventHandler(this.expBtn_MouseEnter);
            // 
            // year_releaseTxt
            // 
            this.year_releaseTxt.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.year_releaseTxt.Location = new System.Drawing.Point(685, 571);
            this.year_releaseTxt.Mask = "0000";
            this.year_releaseTxt.Name = "year_releaseTxt";
            this.year_releaseTxt.Size = new System.Drawing.Size(288, 34);
            this.year_releaseTxt.TabIndex = 56;
            // 
            // body_typeTxt
            // 
            this.body_typeTxt.BackColor = System.Drawing.Color.White;
            this.body_typeTxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.body_typeTxt.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.body_typeTxt.FormattingEnabled = true;
            this.body_typeTxt.Items.AddRange(new object[] {
            "Седан",
            "Универсал",
            "Хэтчбек",
            "Лифтбек",
            "Купе",
            "Лимузин",
            "Кабриолет",
            "Внедорожник"});
            this.body_typeTxt.Location = new System.Drawing.Point(129, 571);
            this.body_typeTxt.Name = "body_typeTxt";
            this.body_typeTxt.Size = new System.Drawing.Size(352, 35);
            this.body_typeTxt.TabIndex = 57;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.markFiltertxt);
            this.groupBox2.Controls.Add(this.clrFilterBtn);
            this.groupBox2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(1262, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(251, 175);
            this.groupBox2.TabIndex = 74;
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
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.qtyRb);
            this.groupBox1.Controls.Add(this.yearRb);
            this.groupBox1.Controls.Add(this.kpRb);
            this.groupBox1.Controls.Add(this.kuzovRb);
            this.groupBox1.Controls.Add(this.clrBtn);
            this.groupBox1.Controls.Add(this.ascendingBtn);
            this.groupBox1.Controls.Add(this.descendingBtn);
            this.groupBox1.Controls.Add(this.fuelRb);
            this.groupBox1.Controls.Add(this.volRb);
            this.groupBox1.Controls.Add(this.modelRb);
            this.groupBox1.Controls.Add(this.markRb);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(993, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 450);
            this.groupBox1.TabIndex = 73;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сортировка";
            // 
            // qtyRb
            // 
            this.qtyRb.AutoSize = true;
            this.qtyRb.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.qtyRb.Location = new System.Drawing.Point(20, 288);
            this.qtyRb.Name = "qtyRb";
            this.qtyRb.Size = new System.Drawing.Size(138, 31);
            this.qtyRb.TabIndex = 79;
            this.qtyRb.TabStop = true;
            this.qtyRb.Text = "Количество";
            this.qtyRb.UseVisualStyleBackColor = true;
            // 
            // yearRb
            // 
            this.yearRb.AutoSize = true;
            this.yearRb.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.yearRb.Location = new System.Drawing.Point(20, 252);
            this.yearRb.Name = "yearRb";
            this.yearRb.Size = new System.Drawing.Size(148, 31);
            this.yearRb.TabIndex = 78;
            this.yearRb.TabStop = true;
            this.yearRb.Text = "Год выпуска";
            this.yearRb.UseVisualStyleBackColor = true;
            // 
            // kpRb
            // 
            this.kpRb.AutoSize = true;
            this.kpRb.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.kpRb.Location = new System.Drawing.Point(20, 144);
            this.kpRb.Name = "kpRb";
            this.kpRb.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.kpRb.Size = new System.Drawing.Size(104, 31);
            this.kpRb.TabIndex = 77;
            this.kpRb.TabStop = true;
            this.kpRb.Text = "Тип КП";
            this.kpRb.UseVisualStyleBackColor = true;
            // 
            // kuzovRb
            // 
            this.kuzovRb.AutoSize = true;
            this.kuzovRb.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.kuzovRb.Location = new System.Drawing.Point(20, 107);
            this.kuzovRb.Name = "kuzovRb";
            this.kuzovRb.Size = new System.Drawing.Size(82, 31);
            this.kuzovRb.TabIndex = 76;
            this.kuzovRb.TabStop = true;
            this.kuzovRb.Text = "Кузов";
            this.kuzovRb.UseVisualStyleBackColor = true;
            // 
            // clrBtn
            // 
            this.clrBtn.BackColor = System.Drawing.Color.White;
            this.clrBtn.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clrBtn.ForeColor = System.Drawing.Color.Black;
            this.clrBtn.Location = new System.Drawing.Point(20, 406);
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
            this.ascendingBtn.Location = new System.Drawing.Point(20, 325);
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
            this.descendingBtn.Location = new System.Drawing.Point(20, 365);
            this.descendingBtn.Name = "descendingBtn";
            this.descendingBtn.Size = new System.Drawing.Size(196, 34);
            this.descendingBtn.TabIndex = 74;
            this.descendingBtn.Text = "По убыванию";
            this.descendingBtn.UseVisualStyleBackColor = false;
            this.descendingBtn.Click += new System.EventHandler(this.descendingBtn_Click);
            // 
            // fuelRb
            // 
            this.fuelRb.AutoSize = true;
            this.fuelRb.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.fuelRb.Location = new System.Drawing.Point(20, 215);
            this.fuelRb.Name = "fuelRb";
            this.fuelRb.Size = new System.Drawing.Size(152, 31);
            this.fuelRb.TabIndex = 71;
            this.fuelRb.TabStop = true;
            this.fuelRb.Text = "Тип топлива";
            this.fuelRb.UseVisualStyleBackColor = true;
            // 
            // volRb
            // 
            this.volRb.AutoSize = true;
            this.volRb.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.volRb.Location = new System.Drawing.Point(20, 178);
            this.volRb.Name = "volRb";
            this.volRb.Size = new System.Drawing.Size(123, 31);
            this.volRb.TabIndex = 70;
            this.volRb.TabStop = true;
            this.volRb.Text = "Мощность";
            this.volRb.UseVisualStyleBackColor = true;
            // 
            // modelRb
            // 
            this.modelRb.AutoSize = true;
            this.modelRb.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.modelRb.Location = new System.Drawing.Point(20, 70);
            this.modelRb.Name = "modelRb";
            this.modelRb.Size = new System.Drawing.Size(101, 31);
            this.modelRb.TabIndex = 68;
            this.modelRb.TabStop = true;
            this.modelRb.Text = "Модель";
            this.modelRb.UseVisualStyleBackColor = true;
            // 
            // markRb
            // 
            this.markRb.AutoSize = true;
            this.markRb.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.markRb.Location = new System.Drawing.Point(20, 33);
            this.markRb.Name = "markRb";
            this.markRb.Size = new System.Drawing.Size(88, 31);
            this.markRb.TabIndex = 67;
            this.markRb.TabStop = true;
            this.markRb.Text = "Марка";
            this.markRb.UseVisualStyleBackColor = true;
            // 
            // clrPoiskBtn
            // 
            this.clrPoiskBtn.BackColor = System.Drawing.Color.Transparent;
            this.clrPoiskBtn.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clrPoiskBtn.Location = new System.Drawing.Point(692, 34);
            this.clrPoiskBtn.Name = "clrPoiskBtn";
            this.clrPoiskBtn.Size = new System.Drawing.Size(196, 34);
            this.clrPoiskBtn.TabIndex = 80;
            this.clrPoiskBtn.Text = "Очистить";
            this.clrPoiskBtn.UseVisualStyleBackColor = false;
            this.clrPoiskBtn.Click += new System.EventHandler(this.clrPoiskBtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(192, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 27);
            this.label9.TabIndex = 79;
            this.label9.Text = "Поиск:";
            // 
            // searchTxt
            // 
            this.searchTxt.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchTxt.Location = new System.Drawing.Point(197, 35);
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.Size = new System.Drawing.Size(247, 34);
            this.searchTxt.TabIndex = 77;
            this.searchTxt.MouseEnter += new System.EventHandler(this.searchTxt_MouseEnter);
            // 
            // srchBtn
            // 
            this.srchBtn.BackColor = System.Drawing.Color.Transparent;
            this.srchBtn.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.srchBtn.Location = new System.Drawing.Point(463, 35);
            this.srchBtn.Name = "srchBtn";
            this.srchBtn.Size = new System.Drawing.Size(208, 34);
            this.srchBtn.TabIndex = 78;
            this.srchBtn.Text = "Поиск";
            this.srchBtn.UseVisualStyleBackColor = false;
            this.srchBtn.Click += new System.EventHandler(this.srchBtn_Click_1);
            // 
            // spisokBtn
            // 
            this.spisokBtn.BackColor = System.Drawing.Color.White;
            this.spisokBtn.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spisokBtn.Location = new System.Drawing.Point(1279, 327);
            this.spisokBtn.Name = "spisokBtn";
            this.spisokBtn.Size = new System.Drawing.Size(208, 125);
            this.spisokBtn.TabIndex = 81;
            this.spisokBtn.Text = "Вывод данных в виде списка";
            this.spisokBtn.UseVisualStyleBackColor = false;
            this.spisokBtn.Click += new System.EventHandler(this.spisokBtn_Click);
            // 
            // CarsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SalesCarDealershipByMidili.Properties.Resources.car_dashboard_and_wheel_close_up;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1525, 763);
            this.Controls.Add(this.spisokBtn);
            this.Controls.Add(this.clrPoiskBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.searchTxt);
            this.Controls.Add(this.body_typeTxt);
            this.Controls.Add(this.srchBtn);
            this.Controls.Add(this.year_releaseTxt);
            this.Controls.Add(this.expBtn);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.powerTxt);
            this.Controls.Add(this.qtyTxt);
            this.Controls.Add(this.fuelTxt);
            this.Controls.Add(this.transmissionTxt);
            this.Controls.Add(this.modelTxt);
            this.Controls.Add(this.markTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.carsDgv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1541, 802);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1500, 514);
            this.Name = "CarsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Машины";
            this.Load += new System.EventHandler(this.CarsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carsDgv)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView carsDgv;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox markTxt;
        private System.Windows.Forms.TextBox modelTxt;
        private System.Windows.Forms.ComboBox transmissionTxt;
        private System.Windows.Forms.ComboBox fuelTxt;
        private System.Windows.Forms.TextBox qtyTxt;
        private System.Windows.Forms.TextBox powerTxt;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Button expBtn;
        private System.Windows.Forms.MaskedTextBox year_releaseTxt;
        private System.Windows.Forms.ComboBox body_typeTxt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox markFiltertxt;
        private System.Windows.Forms.Button clrFilterBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton kpRb;
        private System.Windows.Forms.RadioButton kuzovRb;
        private System.Windows.Forms.Button clrBtn;
        private System.Windows.Forms.Button ascendingBtn;
        private System.Windows.Forms.Button descendingBtn;
        private System.Windows.Forms.RadioButton fuelRb;
        private System.Windows.Forms.RadioButton volRb;
        private System.Windows.Forms.RadioButton modelRb;
        private System.Windows.Forms.RadioButton markRb;
        private System.Windows.Forms.Button clrPoiskBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox searchTxt;
        private System.Windows.Forms.Button srchBtn;
        private System.Windows.Forms.RadioButton qtyRb;
        private System.Windows.Forms.RadioButton yearRb;
        private System.Windows.Forms.Button spisokBtn;
    }
}