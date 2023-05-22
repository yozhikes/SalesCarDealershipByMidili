namespace SalesCarDealershipByMidili.Forms
{
    partial class SalesListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesListForm));
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTxt = new System.Windows.Forms.DateTimePicker();
            this.sumTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.fioTxt = new System.Windows.Forms.TextBox();
            this.nextBtn = new System.Windows.Forms.Button();
            this.prevBtn = new System.Windows.Forms.Button();
            this.telTxt = new System.Windows.Forms.TextBox();
            this.modelTxt = new System.Windows.Forms.TextBox();
            this.markTxt = new System.Windows.Forms.TextBox();
            this.backBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(14, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 30);
            this.label5.TabIndex = 92;
            this.label5.Text = "Модель машины";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(14, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 30);
            this.label6.TabIndex = 90;
            this.label6.Text = "Марка машины";
            // 
            // dateTxt
            // 
            this.dateTxt.CustomFormat = "dd-MM-yyyy";
            this.dateTxt.Enabled = false;
            this.dateTxt.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.dateTxt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTxt.Location = new System.Drawing.Point(262, 247);
            this.dateTxt.Name = "dateTxt";
            this.dateTxt.Size = new System.Drawing.Size(276, 34);
            this.dateTxt.TabIndex = 88;
            this.dateTxt.Value = new System.DateTime(2023, 5, 12, 0, 0, 0, 0);
            // 
            // sumTxt
            // 
            this.sumTxt.BackColor = System.Drawing.Color.White;
            this.sumTxt.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sumTxt.Location = new System.Drawing.Point(262, 289);
            this.sumTxt.Name = "sumTxt";
            this.sumTxt.ReadOnly = true;
            this.sumTxt.Size = new System.Drawing.Size(276, 34);
            this.sumTxt.TabIndex = 81;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(15, 289);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 30);
            this.label8.TabIndex = 87;
            this.label8.Text = "Сумма";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(14, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 30);
            this.label3.TabIndex = 86;
            this.label3.Text = "Дата";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(14, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(237, 30);
            this.label4.TabIndex = 85;
            this.label4.Text = "Телефон покупателя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 30);
            this.label2.TabIndex = 84;
            this.label2.Text = "Фио покупателя";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(213, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 30);
            this.label9.TabIndex = 83;
            this.label9.Text = "Продажи";
            // 
            // fioTxt
            // 
            this.fioTxt.BackColor = System.Drawing.Color.White;
            this.fioTxt.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fioTxt.Location = new System.Drawing.Point(262, 153);
            this.fioTxt.Name = "fioTxt";
            this.fioTxt.ReadOnly = true;
            this.fioTxt.Size = new System.Drawing.Size(276, 34);
            this.fioTxt.TabIndex = 79;
            // 
            // nextBtn
            // 
            this.nextBtn.BackColor = System.Drawing.Color.White;
            this.nextBtn.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nextBtn.Location = new System.Drawing.Point(387, 353);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(130, 56);
            this.nextBtn.TabIndex = 94;
            this.nextBtn.Text = ">";
            this.nextBtn.UseVisualStyleBackColor = false;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            this.nextBtn.MouseEnter += new System.EventHandler(this.nextBtn_MouseEnter);
            // 
            // prevBtn
            // 
            this.prevBtn.BackColor = System.Drawing.Color.White;
            this.prevBtn.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prevBtn.Location = new System.Drawing.Point(38, 353);
            this.prevBtn.Name = "prevBtn";
            this.prevBtn.Size = new System.Drawing.Size(130, 56);
            this.prevBtn.TabIndex = 93;
            this.prevBtn.Text = "<";
            this.prevBtn.UseVisualStyleBackColor = false;
            this.prevBtn.Click += new System.EventHandler(this.prevBtn_Click);
            this.prevBtn.MouseEnter += new System.EventHandler(this.prevBtn_MouseEnter);
            // 
            // telTxt
            // 
            this.telTxt.BackColor = System.Drawing.Color.White;
            this.telTxt.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.telTxt.Location = new System.Drawing.Point(262, 200);
            this.telTxt.Name = "telTxt";
            this.telTxt.ReadOnly = true;
            this.telTxt.Size = new System.Drawing.Size(276, 34);
            this.telTxt.TabIndex = 95;
            // 
            // modelTxt
            // 
            this.modelTxt.BackColor = System.Drawing.Color.White;
            this.modelTxt.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.modelTxt.Location = new System.Drawing.Point(262, 110);
            this.modelTxt.Name = "modelTxt";
            this.modelTxt.ReadOnly = true;
            this.modelTxt.Size = new System.Drawing.Size(276, 34);
            this.modelTxt.TabIndex = 96;
            // 
            // markTxt
            // 
            this.markTxt.BackColor = System.Drawing.Color.White;
            this.markTxt.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.markTxt.Location = new System.Drawing.Point(262, 65);
            this.markTxt.Name = "markTxt";
            this.markTxt.ReadOnly = true;
            this.markTxt.Size = new System.Drawing.Size(276, 34);
            this.markTxt.TabIndex = 97;
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.White;
            this.backBtn.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backBtn.Location = new System.Drawing.Point(5, 7);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(90, 34);
            this.backBtn.TabIndex = 98;
            this.backBtn.Text = "Назад";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // SalesListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SalesCarDealershipByMidili.Properties.Resources.car_dashboard_and_wheel_close_up;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(554, 437);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.markTxt);
            this.Controls.Add(this.modelTxt);
            this.Controls.Add(this.telTxt);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.prevBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTxt);
            this.Controls.Add(this.sumTxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.fioTxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(570, 476);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(570, 476);
            this.Name = "SalesListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Продажи";
            this.Load += new System.EventHandler(this.SalesListForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTxt;
        private System.Windows.Forms.TextBox sumTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox fioTxt;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Button prevBtn;
        private System.Windows.Forms.TextBox telTxt;
        private System.Windows.Forms.TextBox modelTxt;
        private System.Windows.Forms.TextBox markTxt;
        private System.Windows.Forms.Button backBtn;
    }
}