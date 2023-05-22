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
    public partial class AddCarForm : Form
    {
        DataBase _dataBase = new DataBase();
        decimal d;
        int i;
        public AddCarForm()
        {
            InitializeComponent();
            CultureInfo customCulture = (CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            _dataBase.openConnection();
            var car_mark = markTxt.Text;
            var car_model = modelTxt.Text;
            var body_type = body_typeTxt.Text;
            var transmission = transmissionTxt.Text;
            var car_power = powerTxt.Text;
            var engine_type = fuelTxt.Text;
            var release_year = year_releaseTxt.Text;
            var qty_of_cars = qtyTxt.Text;
            char[] a = release_year.ToCharArray();
            if (car_mark != string.Empty && ((a[0] == '1' && a[1]=='9')||(a[0] == '2' && a[1] == '0')) &&
                car_model != string.Empty && body_type != string.Empty &&
                decimal.TryParse(car_power, out d) && int.TryParse(release_year, out i) && release_year.Length == 4
                && int.TryParse(qty_of_cars, out i)&& transmission!= string.Empty&& engine_type != string.Empty
                &&powerTxt.Text.Substring(0,1)!="-"&&qtyTxt.Text.Substring(0,1)!="-")
            {
                var addQuery = $"INSERT INTO cars(car_mark,car_model,body_type,transmission,car_power," +
                    $"engine_type,release_year,qty_of_cars) VALUES ('{car_mark}','{car_model}'," +
                    $"'{body_type}','{transmission}',{decimal.Parse(car_power)},'{engine_type}'," +
                    $"{int.Parse(release_year)},{int.Parse(qty_of_cars)})";
                var command = new SqlCommand(addQuery, _dataBase.GetConnection());
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
    }
}
