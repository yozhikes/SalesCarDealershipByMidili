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

namespace SalesCarDealershipByMidili.Forms
{
    public partial class SalesListForm : Form
    {
        System.Windows.Forms.ToolTip tooltip = new System.Windows.Forms.ToolTip();
        DataBase _dataBase = new DataBase();
        int id = 1;
        public SalesListForm()
        {
            InitializeComponent();
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            var queryString = $"SELECT * FROM sales WHERE sale_id>{id}";
            var command = new SqlCommand(queryString, _dataBase.GetConnection());
            _dataBase.openConnection();
            var reader = command.ExecuteReader();
            if (reader.Read())
            {
                while (true)
                {
                    reader.Close();
                    id++;
                    queryString = $"SELECT * FROM sales,cars WHERE cars.car_id=sales.car_id AND sale_id={id}";
                    command = new SqlCommand(queryString, _dataBase.GetConnection());
                    _dataBase.openConnection();
                    reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        markTxt.Text = reader[7].ToString();
                        modelTxt.Text = reader[8].ToString();
                        fioTxt.Text = reader[2].ToString();
                        telTxt.Text = reader[3].ToString();
                        dateTxt.Text = reader[4].ToString();
                        sumTxt.Text = reader[5].ToString();
                        break;
                    }
                }
            }
            reader.Close();
        }

        private void prevBtn_Click(object sender, EventArgs e)
        {
            var queryString = $"SELECT * FROM sales WHERE sale_id<{id}";
            var command = new SqlCommand(queryString, _dataBase.GetConnection());
            _dataBase.openConnection();
            var reader = command.ExecuteReader();
            if (reader.Read())
            {
                while (true)
                {
                    reader.Close();
                    id--;
                    queryString = $"SELECT * FROM sales,cars WHERE cars.car_id=sales.car_id AND sale_id={id}";
                    command = new SqlCommand(queryString, _dataBase.GetConnection());
                    _dataBase.openConnection();
                    reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        markTxt.Text = reader[7].ToString();
                        modelTxt.Text = reader[8].ToString();
                        fioTxt.Text = reader[2].ToString();
                        telTxt.Text = reader[3].ToString();
                        dateTxt.Text = reader[4].ToString();
                        sumTxt.Text = reader[5].ToString();
                        break;
                    }
                }
            }
            reader.Close();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SalesListForm_Load(object sender, EventArgs e)
        {
            string queryString = $"SELECT * FROM sales,cars WHERE cars.car_id=sales.car_id";
            var command = new SqlCommand(queryString, _dataBase.GetConnection());
            _dataBase.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            markTxt.Text = reader[7].ToString();
            modelTxt.Text = reader[8].ToString();
            fioTxt.Text = reader[2].ToString();
            telTxt.Text = reader[3].ToString();
            dateTxt.Text = reader[4].ToString();
            sumTxt.Text = reader[5].ToString();
            reader.Close();
        }

        private void prevBtn_MouseEnter(object sender, EventArgs e)
        {
            tooltip.SetToolTip(prevBtn, "Назад");
        }

        private void nextBtn_MouseEnter(object sender, EventArgs e)
        {
            tooltip.SetToolTip(nextBtn, "Вперед");
        }
    }
}
