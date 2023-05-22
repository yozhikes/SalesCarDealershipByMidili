using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SalesCarDealershipByMidili.Forms
{
    public partial class MainForm : Form
    {
        System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();
        string category = "";
        public MainForm(string cat)
        {
            category = cat;
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void carsBtn_Click(object sender, EventArgs e)
        {
            CarsForm carsForm = new CarsForm(category);
            carsForm.FormClosed += formClosed;
            Hide();
            carsForm.Show();
        }

        private void salesBtn_Click(object sender, EventArgs e)
        {
            SalesForm salesForm = new SalesForm(category);
            salesForm.FormClosed += formClosed;
            Hide();
            salesForm.Show();
        }

        void formClosed(object sender, FormClosedEventArgs e)
        {
            Show();
        }

        private void spravkaBtn_Click(object sender, EventArgs e)
        {
            SpravkaForm spravka = new SpravkaForm();
            spravka.FormClosed += formClosed;
            Hide();
            spravka.Show();
        }

        private void carsBtn_MouseEnter(object sender, EventArgs e)
        {
            toolTip.SetToolTip(carsBtn, "Показать таблицу\"Машины\"");
        }

        private void salesBtn_MouseEnter(object sender, EventArgs e)
        {
            toolTip.SetToolTip(salesBtn, "Показать таблицу\"Продажи\"");
        }

        private void spravkaBtn_MouseEnter(object sender, EventArgs e)
        {
            toolTip.SetToolTip(spravkaBtn, "Вызвать справку");
        }

        private void exitBtn_MouseEnter(object sender, EventArgs e)
        {
            toolTip.SetToolTip(exitBtn, "Выйти");
        }
    }
}
