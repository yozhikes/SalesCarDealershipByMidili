using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesCarDealershipByMidili.Forms
{
    public partial class SpravkaForm : Form
    {
        public SpravkaForm()
        {
            InitializeComponent();
        }

        private void SpravkaForm_Load(object sender, EventArgs e)
        {
            txt.Text = "В программе доступен просмотр в табличном виде\nи в виде списка двух таблиц:" +
                "\"Машины\" и \"Продажи\",\nесли вы являетесь администратором, то вы\nимеете доступ " +
                "к функциям добавления, изменения \nи удаления записей в таблицах.\nДля удобства добавление" +
                " записей реализовано\nв отдельном окне.";
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
