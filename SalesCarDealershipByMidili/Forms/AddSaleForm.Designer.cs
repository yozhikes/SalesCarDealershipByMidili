namespace SalesCarDealershipByMidili.Forms
{
    partial class AddSaleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSaleForm));
            this.addBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fioTxt = new System.Windows.Forms.TextBox();
            this.phoneTxt = new System.Windows.Forms.MaskedTextBox();
            this.sumTxt = new System.Windows.Forms.TextBox();
            this.dateTxt = new System.Windows.Forms.DateTimePicker();
            this.car_modelTxt = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.car_markTxt = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.White;
            this.addBtn.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addBtn.Location = new System.Drawing.Point(199, 369);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(148, 74);
            this.addBtn.TabIndex = 6;
            this.addBtn.Text = "Добавить";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(152, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(235, 30);
            this.label9.TabIndex = 58;
            this.label9.Text = "Добавление продажи";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(19, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(237, 30);
            this.label4.TabIndex = 62;
            this.label4.Text = "Телефон покупателя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(18, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 30);
            this.label2.TabIndex = 61;
            this.label2.Text = "Фио покупателя";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(20, 302);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 30);
            this.label8.TabIndex = 64;
            this.label8.Text = "Сумма";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(19, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 30);
            this.label3.TabIndex = 63;
            this.label3.Text = "Дата";
            // 
            // fioTxt
            // 
            this.fioTxt.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fioTxt.Location = new System.Drawing.Point(267, 163);
            this.fioTxt.Name = "fioTxt";
            this.fioTxt.Size = new System.Drawing.Size(276, 34);
            this.fioTxt.TabIndex = 2;
            this.fioTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fioTxt_KeyPress);
            // 
            // phoneTxt
            // 
            this.phoneTxt.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.phoneTxt.Location = new System.Drawing.Point(267, 213);
            this.phoneTxt.Mask = "+00000000000";
            this.phoneTxt.Name = "phoneTxt";
            this.phoneTxt.Size = new System.Drawing.Size(276, 34);
            this.phoneTxt.TabIndex = 3;
            // 
            // sumTxt
            // 
            this.sumTxt.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sumTxt.Location = new System.Drawing.Point(267, 302);
            this.sumTxt.Name = "sumTxt";
            this.sumTxt.Size = new System.Drawing.Size(276, 34);
            this.sumTxt.TabIndex = 5;
            // 
            // dateTxt
            // 
            this.dateTxt.CustomFormat = "dd-MM-yyyy";
            this.dateTxt.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.dateTxt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTxt.Location = new System.Drawing.Point(267, 260);
            this.dateTxt.Name = "dateTxt";
            this.dateTxt.Size = new System.Drawing.Size(276, 34);
            this.dateTxt.TabIndex = 65;
            this.dateTxt.Value = new System.DateTime(2023, 5, 12, 0, 0, 0, 0);
            // 
            // car_modelTxt
            // 
            this.car_modelTxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.car_modelTxt.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.car_modelTxt.FormattingEnabled = true;
            this.car_modelTxt.Location = new System.Drawing.Point(267, 118);
            this.car_modelTxt.Name = "car_modelTxt";
            this.car_modelTxt.Size = new System.Drawing.Size(276, 35);
            this.car_modelTxt.TabIndex = 77;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(19, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 30);
            this.label5.TabIndex = 78;
            this.label5.Text = "Модель машины";
            // 
            // car_markTxt
            // 
            this.car_markTxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.car_markTxt.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.car_markTxt.FormattingEnabled = true;
            this.car_markTxt.Location = new System.Drawing.Point(267, 74);
            this.car_markTxt.Name = "car_markTxt";
            this.car_markTxt.Size = new System.Drawing.Size(276, 35);
            this.car_markTxt.TabIndex = 75;
            this.car_markTxt.SelectedIndexChanged += new System.EventHandler(this.car_markTxt_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(19, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 30);
            this.label6.TabIndex = 76;
            this.label6.Text = "Марка машины";
            // 
            // AddSaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SalesCarDealershipByMidili.Properties.Resources.car_dashboard_and_wheel_close_up;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(568, 467);
            this.Controls.Add(this.car_modelTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.car_markTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTxt);
            this.Controls.Add(this.sumTxt);
            this.Controls.Add(this.phoneTxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.fioTxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(584, 506);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(584, 506);
            this.Name = "AddSaleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление продажи";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fioTxt;
        private System.Windows.Forms.MaskedTextBox phoneTxt;
        private System.Windows.Forms.TextBox sumTxt;
        private System.Windows.Forms.DateTimePicker dateTxt;
        private System.Windows.Forms.ComboBox car_modelTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox car_markTxt;
        private System.Windows.Forms.Label label6;
    }
}