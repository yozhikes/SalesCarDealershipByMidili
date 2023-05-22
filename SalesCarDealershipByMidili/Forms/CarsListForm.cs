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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SalesCarDealershipByMidili.Forms
{
    public partial class CarsListForm : Form
    {
        System.Windows.Forms.ToolTip tooltip = new System.Windows.Forms.ToolTip();
        DataBase _dataBase = new DataBase();
        int id = 1;
        public CarsListForm()
        {
            InitializeComponent();
        }

        private void CarsListForm_Load(object sender, EventArgs e)
        {
            string queryString = $"SELECT * FROM cars";
            var command = new SqlCommand(queryString, _dataBase.GetConnection());
            _dataBase.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            markTxt.Text = reader[1].ToString();
            modelTxt.Text = reader[2].ToString();
            body_typeTxt.Text = reader[3].ToString();
            kpTxt.Text = reader[4].ToString();
            powerTxt.Text = reader[5].ToString();
            fuelTxt.Text = reader[6].ToString();
            yearTxt.Text = reader[7].ToString();
            qtyTxt.Text = reader[8].ToString();
            reader.Close();
        }

        private void prevBtn_Click(object sender, EventArgs e)
        {
            var queryString = $"SELECT * FROM cars WHERE car_id<{id}";
            var command = new SqlCommand(queryString, _dataBase.GetConnection());
            _dataBase.openConnection();
            var reader = command.ExecuteReader();
            if (reader.Read())
            {
                while (true)
                {
                    reader.Close();
                    id--;
                    queryString = $"SELECT * FROM cars WHERE car_id={id}";
                    command = new SqlCommand(queryString, _dataBase.GetConnection());
                    _dataBase.openConnection();
                    reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        markTxt.Text = reader[1].ToString();
                        modelTxt.Text = reader[2].ToString();
                        body_typeTxt.Text = reader[3].ToString();
                        kpTxt.Text = reader[4].ToString();
                        powerTxt.Text = reader[5].ToString();
                        fuelTxt.Text = reader[6].ToString();
                        yearTxt.Text = reader[7].ToString();
                        qtyTxt.Text = reader[8].ToString();
                        break;
                    }
                }
            }
            reader.Close();
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            var queryString = $"SELECT * FROM cars WHERE car_id>{id}";
            var command = new SqlCommand(queryString, _dataBase.GetConnection());
            _dataBase.openConnection();
            var reader = command.ExecuteReader();
            if (reader.Read())
            {
                while (true)
                {
                    reader.Close();
                    id++;
                    queryString = $"SELECT * FROM cars WHERE car_id={id}";
                    command = new SqlCommand(queryString, _dataBase.GetConnection());
                    _dataBase.openConnection();
                    reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        markTxt.Text = reader[1].ToString();
                        modelTxt.Text = reader[2].ToString();
                        body_typeTxt.Text = reader[3].ToString();
                        kpTxt.Text = reader[4].ToString();
                        powerTxt.Text = reader[5].ToString();
                        fuelTxt.Text = reader[6].ToString();
                        yearTxt.Text = reader[7].ToString();
                        qtyTxt.Text = reader[8].ToString();
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
