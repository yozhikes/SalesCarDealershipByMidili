namespace SalesCarDealershipByMidili.Forms
{
    partial class AddCarForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCarForm));
            this.powerTxt = new System.Windows.Forms.TextBox();
            this.qtyTxt = new System.Windows.Forms.TextBox();
            this.fuelTxt = new System.Windows.Forms.ComboBox();
            this.transmissionTxt = new System.Windows.Forms.ComboBox();
            this.modelTxt = new System.Windows.Forms.TextBox();
            this.markTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.year_releaseTxt = new System.Windows.Forms.MaskedTextBox();
            this.body_typeTxt = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // powerTxt
            // 
            this.powerTxt.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.powerTxt.Location = new System.Drawing.Point(251, 258);
            this.powerTxt.Name = "powerTxt";
            this.powerTxt.Size = new System.Drawing.Size(283, 34);
            this.powerTxt.TabIndex = 5;
            // 
            // qtyTxt
            // 
            this.qtyTxt.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.qtyTxt.Location = new System.Drawing.Point(251, 383);
            this.qtyTxt.Name = "qtyTxt";
            this.qtyTxt.Size = new System.Drawing.Size(283, 34);
            this.qtyTxt.TabIndex = 8;
            // 
            // fuelTxt
            // 
            this.fuelTxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fuelTxt.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.fuelTxt.FormattingEnabled = true;
            this.fuelTxt.Items.AddRange(new object[] {
            "Бензин",
            "Дизель",
            "Газ",
            "Водород"});
            this.fuelTxt.Location = new System.Drawing.Point(251, 299);
            this.fuelTxt.Name = "fuelTxt";
            this.fuelTxt.Size = new System.Drawing.Size(283, 35);
            this.fuelTxt.TabIndex = 6;
            // 
            // transmissionTxt
            // 
            this.transmissionTxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.transmissionTxt.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.transmissionTxt.FormattingEnabled = true;
            this.transmissionTxt.Items.AddRange(new object[] {
            "Механика",
            "Автомат",
            "Робот",
            "Вариатор"});
            this.transmissionTxt.Location = new System.Drawing.Point(251, 209);
            this.transmissionTxt.Name = "transmissionTxt";
            this.transmissionTxt.Size = new System.Drawing.Size(283, 35);
            this.transmissionTxt.TabIndex = 4;
            // 
            // modelTxt
            // 
            this.modelTxt.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.modelTxt.Location = new System.Drawing.Point(251, 126);
            this.modelTxt.Name = "modelTxt";
            this.modelTxt.Size = new System.Drawing.Size(283, 34);
            this.modelTxt.TabIndex = 2;
            // 
            // markTxt
            // 
            this.markTxt.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.markTxt.Location = new System.Drawing.Point(251, 83);
            this.markTxt.Name = "markTxt";
            this.markTxt.Size = new System.Drawing.Size(283, 34);
            this.markTxt.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(51, 383);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 30);
            this.label5.TabIndex = 31;
            this.label5.Text = "Количество";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(51, 340);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 30);
            this.label6.TabIndex = 30;
            this.label6.Text = "Год выпуска";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(51, 300);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 30);
            this.label7.TabIndex = 29;
            this.label7.Text = "Тип топлива";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(51, 257);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(175, 30);
            this.label8.TabIndex = 28;
            this.label8.Text = "Мощность(л.с.)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(50, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 30);
            this.label3.TabIndex = 27;
            this.label3.Text = "Коробка передач";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(50, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 30);
            this.label4.TabIndex = 26;
            this.label4.Text = "Кузов";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(50, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 30);
            this.label2.TabIndex = 25;
            this.label2.Text = "Модель";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(50, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 30);
            this.label1.TabIndex = 24;
            this.label1.Text = "Марка";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(176, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(232, 30);
            this.label9.TabIndex = 40;
            this.label9.Text = "Добавление машины";
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.White;
            this.addBtn.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addBtn.Location = new System.Drawing.Point(225, 443);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(148, 74);
            this.addBtn.TabIndex = 9;
            this.addBtn.Text = "Добавить";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // year_releaseTxt
            // 
            this.year_releaseTxt.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.year_releaseTxt.Location = new System.Drawing.Point(251, 343);
            this.year_releaseTxt.Mask = "0000";
            this.year_releaseTxt.Name = "year_releaseTxt";
            this.year_releaseTxt.Size = new System.Drawing.Size(283, 34);
            this.year_releaseTxt.TabIndex = 7;
            // 
            // body_typeTxt
            // 
            this.body_typeTxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.body_typeTxt.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
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
            this.body_typeTxt.Location = new System.Drawing.Point(251, 168);
            this.body_typeTxt.Name = "body_typeTxt";
            this.body_typeTxt.Size = new System.Drawing.Size(283, 35);
            this.body_typeTxt.TabIndex = 41;
            // 
            // AddCarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SalesCarDealershipByMidili.Properties.Resources.car_dashboard_and_wheel_close_up;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(562, 549);
            this.Controls.Add(this.body_typeTxt);
            this.Controls.Add(this.year_releaseTxt);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.label9);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(578, 588);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(578, 588);
            this.Name = "AddCarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление машины";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox powerTxt;
        private System.Windows.Forms.TextBox qtyTxt;
        private System.Windows.Forms.ComboBox fuelTxt;
        private System.Windows.Forms.ComboBox transmissionTxt;
        private System.Windows.Forms.TextBox modelTxt;
        private System.Windows.Forms.TextBox markTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.MaskedTextBox year_releaseTxt;
        private System.Windows.Forms.ComboBox body_typeTxt;
    }
}