using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesCarDealershipByMidili.Forms
{
    public partial class AddSaleForm : Form
    {
        DataBase _dataBase = new DataBase();
        decimal d;
        public AddSaleForm()
        {
            InitializeComponent();
            CultureInfo customCulture = (CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
            var queryString = $"SELECT DISTINCT car_mark FROM cars";
            var command = new SqlCommand(queryString, _dataBase.GetConnection());
            _dataBase.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            car_markTxt.Items.Clear();
            while (reader.Read())
            {
                car_markTxt.Items.Add(reader[0].ToString());
            }
            reader.Close();
            dateTxt.MaxDate= DateTime.Now;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            _dataBase.openConnection();
            var car_id = 0;
            var qty = 0;
            var fio = fioTxt.Text;
            var phone = phoneTxt.Text;
            var sale_date = dateTxt.Text;
            var price = sumTxt.Text;
            var queryString = $"SELECT car_id FROM cars WHERE car_model='{car_modelTxt.Text}'";
            var command = new SqlCommand(queryString, _dataBase.GetConnection());
            _dataBase.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                car_id = reader.GetInt32(0);
            }
            reader.Close();
            if (fio != string.Empty && phone != string.Empty && sale_date != string.Empty && decimal.TryParse(price, out d)
                && sumTxt.Text.Substring(0, 1) != "-")
            {
                var addQuery = $"INSERT INTO sales(car_id,fio,phone,sale_date,price) VALUES " +
                    $"('{car_id}','{fio}'," +
                    $"'{phone}','{sale_date}',{decimal.Parse(price)})";
                command = new SqlCommand(addQuery, _dataBase.GetConnection());
                command.ExecuteNonQuery();

                queryString = $"SELECT qty_of_cars FROM cars WHERE car_id='{car_id}'";
                command = new SqlCommand(queryString, _dataBase.GetConnection());
                _dataBase.openConnection();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    qty = reader.GetInt32(0);
                }
                reader.Close();
                addQuery = $"UPDATE cars SET qty_of_cars={qty-1} WHERE car_id={car_id}";
                command = new SqlCommand(addQuery, _dataBase.GetConnection());
                command.ExecuteNonQuery();
                Close();
                MessageBox.Show("Новая запись успешно создана!");
            }
            else
            {
                MessageBox.Show("Неверный ввод!");
            }
            _dataBase.closeConnection();
        }

        private void car_markTxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            var queryString = $"SELECT * FROM cars WHERE car_mark='{car_markTxt.Text}'";
            var command = new SqlCommand(queryString, _dataBase.GetConnection());
            _dataBase.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            car_modelTxt.Items.Clear();
            while (reader.Read())
            {
                if (reader[8].ToString() != "0")
                {
                    car_modelTxt.Items.Add(reader[2].ToString());
                    car_modelTxt.SelectedIndex = 0;
                }
            }
            reader.Close();
        }

        private void fioTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }
    }
}
