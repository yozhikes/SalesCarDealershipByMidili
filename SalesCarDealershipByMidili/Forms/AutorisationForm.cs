using SalesCarDealershipByMidili.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesCarDealershipByMidili
{
    public partial class AutorisationForm : Form
    {
        DataBase _dataBase = new DataBase();
        ToolTip toolTip=new ToolTip();
        public AutorisationForm()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            _dataBase.openConnection();
            string queryString = $"SELECT * FROM users WHERE usr_name='{loginTxt.Text}' AND pass='{passTxt.Text}'";
            var command = new SqlCommand(queryString, _dataBase.GetConnection());
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                Hide();
                MessageBox.Show("Авторизация прошла успешно!");
                MainForm mainForm = new MainForm(reader[3].ToString());
                mainForm.Show();                
            }
            else
            {
                MessageBox.Show("Введён неверный логин/пароль!");
            }
            _dataBase.closeConnection();
        }

        private void loginTxt_MouseEnter(object sender, EventArgs e)
        {
            toolTip.SetToolTip(loginTxt, "Логин");
        }

        private void passTxt_MouseEnter(object sender, EventArgs e)
        {
            toolTip.SetToolTip(passTxt, "Пароль");
        }

        private void loginBtn_MouseEnter(object sender, EventArgs e)
        {
            toolTip.SetToolTip(loginBtn, "Вход");
        }
    }
}
