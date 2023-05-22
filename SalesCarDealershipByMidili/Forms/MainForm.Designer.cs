namespace SalesCarDealershipByMidili.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.carsBtn = new System.Windows.Forms.Button();
            this.salesBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.spravkaBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(188, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберите действие:";
            // 
            // carsBtn
            // 
            this.carsBtn.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold);
            this.carsBtn.Location = new System.Drawing.Point(113, 75);
            this.carsBtn.Name = "carsBtn";
            this.carsBtn.Size = new System.Drawing.Size(369, 73);
            this.carsBtn.TabIndex = 1;
            this.carsBtn.Text = "Таблица \"Машины\"";
            this.carsBtn.UseVisualStyleBackColor = true;
            this.carsBtn.Click += new System.EventHandler(this.carsBtn_Click);
            this.carsBtn.MouseEnter += new System.EventHandler(this.carsBtn_MouseEnter);
            // 
            // salesBtn
            // 
            this.salesBtn.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold);
            this.salesBtn.Location = new System.Drawing.Point(113, 166);
            this.salesBtn.Name = "salesBtn";
            this.salesBtn.Size = new System.Drawing.Size(369, 73);
            this.salesBtn.TabIndex = 2;
            this.salesBtn.Text = "Таблица \"Продажи\"";
            this.salesBtn.UseVisualStyleBackColor = true;
            this.salesBtn.Click += new System.EventHandler(this.salesBtn_Click);
            this.salesBtn.MouseEnter += new System.EventHandler(this.salesBtn_MouseEnter);
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold);
            this.exitBtn.Location = new System.Drawing.Point(113, 366);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(369, 73);
            this.exitBtn.TabIndex = 4;
            this.exitBtn.Text = "Выход";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            this.exitBtn.MouseEnter += new System.EventHandler(this.exitBtn_MouseEnter);
            // 
            // spravkaBtn
            // 
            this.spravkaBtn.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold);
            this.spravkaBtn.Location = new System.Drawing.Point(113, 268);
            this.spravkaBtn.Name = "spravkaBtn";
            this.spravkaBtn.Size = new System.Drawing.Size(369, 73);
            this.spravkaBtn.TabIndex = 3;
            this.spravkaBtn.Text = "Справка";
            this.spravkaBtn.UseVisualStyleBackColor = true;
            this.spravkaBtn.Click += new System.EventHandler(this.spravkaBtn_Click);
            this.spravkaBtn.MouseEnter += new System.EventHandler(this.spravkaBtn_MouseEnter);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SalesCarDealershipByMidili.Properties.Resources.car_dashboard_and_wheel_close_up;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(578, 466);
            this.Controls.Add(this.spravkaBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.salesBtn);
            this.Controls.Add(this.carsBtn);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(594, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(594, 410);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главная";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button carsBtn;
        private System.Windows.Forms.Button salesBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button spravkaBtn;
    }
}