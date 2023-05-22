using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SalesCarDealershipByMidili.Forms
{
    public partial class CarsForm : Form
    {
        System.Windows.Forms.ToolTip tooltip =new System.Windows.Forms.ToolTip();
        DataBase _dataBase = new DataBase();
        decimal d;
        int n;
        string category = "";
        public CarsForm(string cat)
        {
            InitializeComponent();
            category = cat;
            if (category == "user")
            {
                Height = 514;
            }
            CultureInfo customCulture = (CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
            carsDgv.DefaultCellStyle.Font = new Font("Comic Sans MS", 12, FontStyle.Bold);
            carsDgv.ColumnHeadersDefaultCellStyle.Font = new Font("Comic Sans MS", 12, FontStyle.Bold);
        }

        private void carsDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRow;
            selectedRow = e.RowIndex;
            if (selectedRow >= 0)
            {
                DataGridViewRow row = carsDgv.Rows[selectedRow];
                markTxt.Text = row.Cells[1].Value.ToString();
                modelTxt.Text = row.Cells[2].Value.ToString();
                body_typeTxt.Text = row.Cells[3].Value.ToString();
                transmissionTxt.Text = row.Cells[4].Value.ToString();            
                powerTxt.Text = row.Cells[5].Value.ToString();
                fuelTxt.Text = row.Cells[6].Value.ToString();
                year_releaseTxt.Text = row.Cells[7].Value.ToString();
                qtyTxt.Text = row.Cells[8].Value.ToString();
            }
        }

        private void CarsForm_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDgv();
        }
        private void CreateColumns()
        {
            carsDgv.Columns.Add("car_id", "Код машины");
            carsDgv.Columns.Add("car_mark", "Марка");
            carsDgv.Columns.Add("car_model", "Модель");
            carsDgv.Columns.Add("body_type", "Кузов");
            carsDgv.Columns.Add("transmission", "Тип коробки передач");
            carsDgv.Columns.Add("car_power", "Мощность (л.с.)");
            carsDgv.Columns.Add("engine_type", "Тип топлива");
            carsDgv.Columns.Add("release_year", "Год выпуска");
            carsDgv.Columns.Add("qty_of_cars", "Кол-во");
            carsDgv.Columns[0].Visible = false;
            carsDgv.Columns[1].Width = 150;
            carsDgv.Columns[2].Width = 130;
            carsDgv.Columns[3].Width = 130;
            carsDgv.Columns[4].Width = 100;
            carsDgv.Columns[5].Width = 100;
            carsDgv.Columns[6].Width = 90;
            carsDgv.Columns[7].Width = 90;
            carsDgv.Columns[8].Width = 80;
        }
        private void RefreshDgv()
        {
            carsDgv.Rows.Clear();
            string queryString = $"SELECT * FROM cars";
            var command = new SqlCommand(queryString, _dataBase.GetConnection());
            _dataBase.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                carsDgv.Rows.Add(reader.GetInt32(0), reader.GetString(1), reader.GetString(2),
                    reader.GetString(3), reader.GetString(4), reader.GetDecimal(5), reader.GetString(6),
                    reader.GetInt32(7), reader.GetInt32(8));
            }
            reader.Close();
            for (int i = 0; i < carsDgv.Rows.Count; i++)
            {
                if (carsDgv[8, i].Value.ToString()=="0")
                {
                    carsDgv.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                }
                else
                {
                    carsDgv.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                }
            }
            queryString = $"SELECT DISTINCT car_mark FROM cars";
            command = new SqlCommand(queryString, _dataBase.GetConnection());
            reader = command.ExecuteReader();
            markFiltertxt.Items.Clear();
            while (reader.Read())
            {
                markFiltertxt.Items.Add(reader[0].ToString());
            }
            reader.Close();
            _dataBase.closeConnection();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            Hide();
            AddCarForm addCarForm = new AddCarForm();
            addCarForm.FormClosed+= formClosed;
            addCarForm.Show();
        }
        void formClosed(object sender, FormClosedEventArgs e)
        {
            Show();
            RefreshDgv();
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            _dataBase.openConnection();
            int index = carsDgv.CurrentCell.RowIndex;
            var queryString = $"SELECT car_id FROM sales WHERE car_id={carsDgv[0,index].Value}";
            var command = new SqlCommand(queryString, _dataBase.GetConnection());
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                reader.Close();
                MessageBox.Show("Данная машина была продана, сначала удалите продажу с ней!", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                reader.Close();
                DialogResult result = MessageBox.Show("Вы действительно хотите удалить запись?", "Удаление", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (index != -1)
                    {
                        carsDgv.Rows[index].Visible = false;
                        var deleteQuery = $"DELETE FROM cars WHERE car_id = {carsDgv[0, index].Value}";
                        command = new SqlCommand(deleteQuery, _dataBase.GetConnection());
                        command.ExecuteNonQuery();
                    }
                    RefreshDgv();
                }
            }
            _dataBase.closeConnection();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            var id = carsDgv.Rows[carsDgv.CurrentCell.RowIndex].Cells[0].Value.ToString();
            var car_modelOld = carsDgv.Rows[carsDgv.CurrentCell.RowIndex].Cells[2].Value.ToString();
            var car_mark = markTxt.Text;
            var car_modelNew = modelTxt.Text;
            var body_type = body_typeTxt.Text;
            var transmission = transmissionTxt.Text;
            var car_power = powerTxt.Text;
            var engine_type = fuelTxt.Text;
            var release_year = year_releaseTxt.Text;
            var qty_of_cars = qtyTxt.Text;
            char[] a = release_year.ToCharArray();
            _dataBase.openConnection();
            var queryString = $"SELECT * FROM cars WHERE car_model='{car_modelNew}' AND car_model!='{car_modelOld}'";
            var command = new SqlCommand(queryString, _dataBase.GetConnection());
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                MessageBox.Show("Данная модель уже существует!","Ошибка",MessageBoxButtons.OK, MessageBoxIcon.Error);
                reader.Close();
            }
            else
            {
                reader.Close();
                if (car_mark != string.Empty && ((a[0] == '1' && a[1] == '9') || (a[0] == '2' && a[1] == '0')) &&
                car_modelNew != string.Empty && body_type != string.Empty &&
                decimal.TryParse(car_power, out d) && int.TryParse(release_year, out n) && release_year.Length == 4
                && int.TryParse(qty_of_cars, out n) && powerTxt.Text.Substring(0, 1) != "-" && qtyTxt.Text.Substring(0, 1) != "-")
                {
                    var changequery = $"UPDATE cars SET car_mark = '{car_mark}', " +
                        $"car_model = '{car_modelNew}', body_type = '{body_type}', transmission = '{transmission}'," +
                        $"car_power ={car_power}, engine_type='{engine_type}', release_year={release_year}," +
                        $" qty_of_cars={qty_of_cars} WHERE car_id = {id}";
                    command = new SqlCommand(changequery, _dataBase.GetConnection());
                    command.ExecuteNonQuery();
                    RefreshDgv();
                }
                else
                {
                    MessageBox.Show("Неверный ввод!");
                }
            }
            _dataBase.closeConnection();
        }

        private void expBtn_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook ExcelWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet ExcelWorkSheet;
            //Книга.
            ExcelWorkBook = ExcelApp.Workbooks.Add(System.Reflection.Missing.Value);
            //Таблица.
            ExcelWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);
            ExcelWorkSheet.Columns.ColumnWidth = 40;
            ExcelApp.Cells[1, 1] = "Марка";
            ExcelApp.Cells[1, 2] = "Модель";
            ExcelApp.Cells[1, 3] = "Кузов";
            ExcelApp.Cells[1, 4] = "Коробка передач";
            ExcelApp.Cells[1, 5] = "Мощность(л.с.)";
            ExcelApp.Cells[1, 6] = "Тип топлива";
            ExcelApp.Cells[1, 7] = "Год выпуска";
            ExcelApp.Cells[1, 8] = "Кол-во";
            for (int i = 0; i < carsDgv.Rows.Count; i++)
            {
                for (int j = 1; j < carsDgv.ColumnCount; j++)
                {
                    ExcelApp.Cells[i + 2, j] = carsDgv.Rows[i].Cells[j].Value;
                }
            }
            //Вызываем нашу созданную эксельку.
            ExcelApp.Visible = true;
            ExcelApp.UserControl = true;
        }


        private void showTxt_Click(object sender, EventArgs e)
        {
            searchTxt.Text = string.Empty;
        }

        private void searchTxt_TextChanged(object sender, EventArgs e)
        {
            if (searchTxt.Text != string.Empty)
            {
                for (int i = 0; i < carsDgv.Rows.Count; i++)
                {
                    for (int j = 0; j < carsDgv.Columns.Count; j++)
                    {
                        if (carsDgv[j, i].Value.ToString().ToLower().IndexOf(searchTxt.Text.ToLower()) != -1)
                        {
                            carsDgv[j, i].Selected = true;
                        }
                        else
                        {
                            carsDgv[j, i].Selected = false;
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < carsDgv.Rows.Count; i++)
                {
                    for (int j = 0; j < carsDgv.Columns.Count; j++)
                    {
                        carsDgv[j, i].Selected = false;
                    }
                }
            }
        }

        private void srchBtn_Click_1(object sender, EventArgs e)
        {
            var chk = false;
            if (searchTxt.Text != string.Empty)
            {
                for (int i = 0; i < carsDgv.Rows.Count; i++)
                {
                    for (int j = 0; j < carsDgv.Columns.Count; j++)
                    {
                        if (carsDgv[j, i].Value.ToString().ToLower().IndexOf(searchTxt.Text.ToLower()) != -1)
                        {
                            carsDgv[j, i].Selected = true;
                            chk = true;
                        }
                        else
                        {
                            carsDgv[j, i].Selected = false;
                        }
                    }
                }
                if (!chk)
                {
                    MessageBox.Show("Ничего не найдено!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                for (int i = 0; i < carsDgv.Rows.Count; i++)
                {
                    for (int j = 0; j < carsDgv.Columns.Count; j++)
                    {
                        carsDgv[j, i].Selected = false;
                    }
                }
                MessageBox.Show("Введите текст в поисковую строку!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clrPoiskBtn_Click(object sender, EventArgs e)
        {
            
            searchTxt.Text = string.Empty;
            for (int i = 0; i <carsDgv.Rows.Count; i++)
            {
                for (int j = 0; j < carsDgv.Columns.Count; j++)
                {
                    carsDgv[j, i].Selected = false;
                }
            }
        }

        private void ascendingBtn_Click(object sender, EventArgs e)
        {
            if (markRb.Checked)
            {
                carsDgv.Sort(carsDgv.Columns[1], ListSortDirection.Ascending);
            }
            else if (modelRb.Checked)
            {
                carsDgv.Sort(carsDgv.Columns[2], ListSortDirection.Ascending);
            }
            else if (kuzovRb.Checked)
            {
                carsDgv.Sort(carsDgv.Columns[3], ListSortDirection.Ascending);
            }
            else if (kpRb.Checked)
            {
                carsDgv.Sort(carsDgv.Columns[4], ListSortDirection.Ascending);
            }
            else if (volRb.Checked)
            {
                carsDgv.Sort(carsDgv.Columns[5], ListSortDirection.Ascending);
            }
            else if (fuelRb.Checked)
            {
                carsDgv.Sort(carsDgv.Columns[6], ListSortDirection.Ascending);
            }
            else if (yearRb.Checked)
            {
                carsDgv.Sort(carsDgv.Columns[7], ListSortDirection.Ascending);
            }
            else if (qtyRb.Checked)
            {
                carsDgv.Sort(carsDgv.Columns[8], ListSortDirection.Ascending);
            }
        }

        private void descendingBtn_Click(object sender, EventArgs e)
        {
            if (markRb.Checked)
            {
                carsDgv.Sort(carsDgv.Columns[1], ListSortDirection.Descending);
            }
            else if (modelRb.Checked)
            {
                carsDgv.Sort(carsDgv.Columns[2], ListSortDirection.Descending);
            }
            else if (kuzovRb.Checked)
            {
                carsDgv.Sort(carsDgv.Columns[3], ListSortDirection.Descending);
            }
            else if (kpRb.Checked)
            {
                carsDgv.Sort(carsDgv.Columns[4], ListSortDirection.Descending);
            }
            else if (volRb.Checked)
            {
                carsDgv.Sort(carsDgv.Columns[5], ListSortDirection.Descending);
            }
            else if (fuelRb.Checked)
            {
                carsDgv.Sort(carsDgv.Columns[6], ListSortDirection.Descending);
            }
            else if (yearRb.Checked)
            {
                carsDgv.Sort(carsDgv.Columns[7], ListSortDirection.Descending);
            }
            else if (qtyRb.Checked)
            {
                carsDgv.Sort(carsDgv.Columns[8], ListSortDirection.Descending);
            }
        }

        private void markFiltertxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < carsDgv.Rows.Count; i++)
            {
                if (carsDgv[1, i].Value.ToString() != markFiltertxt.Text)
                {
                    carsDgv.Rows[i].Visible = false;
                }
                else
                {
                    carsDgv.Rows[i].Visible = true;
                }
            }
        }

        private void clrFilterBtn_Click(object sender, EventArgs e)
        {
            RefreshDgv();
        }

        private void clrBtn_Click(object sender, EventArgs e)
        {
            carsDgv.Sort(carsDgv.Columns[0], ListSortDirection.Ascending);
            if (markRb.Checked)
            {
                markRb.Checked = false;
            }
            else if (modelRb.Checked)
            {
                modelRb.Checked = false;
            }
            else if (kuzovRb.Checked)
            {
                kuzovRb.Checked = false;
            }
            else if (kpRb.Checked)
            {
                kpRb.Checked = false;
            }
            else if (volRb.Checked)
            {
                volRb.Checked = false;
            }
            else if (fuelRb.Checked)
            {
                fuelRb.Checked = false;
            }
            else if (yearRb.Checked)
            {
                yearRb.Checked = false;
            }
            else if (qtyRb.Checked)
            {
                qtyRb.Checked = false;
            }
        }

        private void spisokBtn_Click(object sender, EventArgs e)
        {
            Hide();
            CarsListForm carsList = new CarsListForm();
            carsList.FormClosed += formClosed;
            carsList.Show();
        }

        private void searchTxt_MouseEnter(object sender, EventArgs e)
        {
            tooltip.SetToolTip(searchTxt, "Введите текст для поиска");
        }

        private void addBtn_MouseEnter(object sender, EventArgs e)
        {
            tooltip.SetToolTip(addBtn, "Добавление записи");
        }

        private void editBtn_MouseEnter(object sender, EventArgs e)
        {
            tooltip.SetToolTip(editBtn, "Изменение записи");
        }

        private void delBtn_MouseEnter(object sender, EventArgs e)
        {
            tooltip.SetToolTip(delBtn, "Удаление записи");
        }

        private void expBtn_MouseEnter(object sender, EventArgs e)
        {
            tooltip.SetToolTip(expBtn, "Экспорт таблицы");
        }
    }
}
