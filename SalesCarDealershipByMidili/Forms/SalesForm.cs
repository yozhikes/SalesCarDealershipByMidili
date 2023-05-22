using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Reflection;
using System.Windows.Forms;

namespace SalesCarDealershipByMidili.Forms
{
    public partial class SalesForm : Form
    {
        System.Windows.Forms.ToolTip tooltip = new System.Windows.Forms.ToolTip();
        DataBase _dataBase = new DataBase();
        decimal d;
        int n;
        string category = "";
        public SalesForm(string cat)
        {
            InitializeComponent();
            category = cat;
            if (category == "user")
            {
                Height = 483;
            }
            CultureInfo customCulture = (CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
            salesDgv.DefaultCellStyle.Font = new Font("Comic Sans MS", 12, FontStyle.Bold);
            salesDgv.ColumnHeadersDefaultCellStyle.Font = new Font("Comic Sans MS", 12, FontStyle.Bold);
            dateTxt.MaxDate = DateTime.Now;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void srchBtn_Click(object sender, EventArgs e)
        {
            var chk = false;
            if (searchTxt.Text != string.Empty)
            {
                for (int i = 0; i < salesDgv.Rows.Count; i++)
                {
                    for (int j = 0; j < salesDgv.Columns.Count; j++)
                    {
                        if (salesDgv[j, i].Value.ToString().ToLower().IndexOf(searchTxt.Text.ToLower()) != -1)
                        {
                            salesDgv[j, i].Selected = true;
                            chk = true;
                        }
                        else
                        {
                            salesDgv[j, i].Selected = false;
                        }
                    }
                }
                if (!chk)
                {
                    MessageBox.Show("Ничего не найдено!","Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            else
            {
                for (int i = 0; i < salesDgv.Rows.Count; i++)
                {
                    for (int j = 0; j < salesDgv.Columns.Count; j++)
                    {
                        salesDgv[j, i].Selected = false;
                    }
                }
                MessageBox.Show("Введите текст в поисковую строку!","Ошибка", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void salesDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRow;
            selectedRow = e.RowIndex;
            if (selectedRow >= 0)
            {
                DataGridViewRow row = salesDgv.Rows[selectedRow];
                car_markTxt.Text = row.Cells[2].Value.ToString();
                car_modelTxt.Text = row.Cells[3].Value.ToString();
                fioTxt.Text = row.Cells[4].Value.ToString();
                phoneTxt.Text = row.Cells[5].Value.ToString();
                dateTxt.Text = row.Cells[6].Value.ToString();
                sumTxt.Text = row.Cells[7].Value.ToString();
            }
        }

        private void SalesForm_Load(object sender, EventArgs e)
        {
            var queryString = $"SELECT DISTINCT car_mark FROM cars";
            var command = new SqlCommand(queryString, _dataBase.GetConnection());
            _dataBase.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            car_markTxt.Items.Clear();
            while (reader.Read())
            {
                markFiltertxt.Items.Add(reader[0].ToString());
                car_markTxt.Items.Add(reader[0].ToString());
            }
            reader.Close();
            CreateColumns();
            RefreshDgv();
            markFiltertxt.SelectedIndex = 0;
        }
        private void CreateColumns()
        {
            salesDgv.Columns.Add("sale_id", "Код продажи");
            salesDgv.Columns.Add("car_id", "Код машины");
            salesDgv.Columns[0].Visible = false;
            salesDgv.Columns[1].Visible = false;
            salesDgv.Columns.Add("car_mark","Марка машины");
            salesDgv.Columns.Add("car_model","Модель машины");
            salesDgv.Columns.Add("fio", "ФИО покупателя");
            salesDgv.Columns.Add("phone", "Телефон покупателя");
            salesDgv.Columns.Add("sale_date", "Дата");
            salesDgv.Columns.Add("price", "Сумма");
            salesDgv.Columns[0].Width = 100;
            salesDgv.Columns[2].Width = 250;
            salesDgv.Columns[3].Width = 150;
            salesDgv.Columns[4].Width = 130;
            salesDgv.Columns[5].Width = 150;
        }
        private void RefreshDgv()
        {
            salesDgv.Rows.Clear();
            string queryString = $"SELECT * FROM sales,cars WHERE cars.car_id=sales.car_id";
            var command = new SqlCommand(queryString, _dataBase.GetConnection());
            _dataBase.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                salesDgv.Rows.Add(reader.GetInt32(0), reader.GetInt32(1), reader.GetString(7),
                    reader.GetString(8), reader.GetString(2),reader.GetString(3),
                    reader.GetDateTime(4),reader.GetDecimal(5));
            }
            reader.Close();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            var id = salesDgv.Rows[salesDgv.CurrentCell.RowIndex].Cells[0].Value.ToString();
            var fio = fioTxt.Text;
            var phone = phoneTxt.Text;
            var sale_date = dateTxt.Text;
            var price = sumTxt.Text;
            int index = salesDgv.CurrentCell.RowIndex;
            var car_idOld = Convert.ToInt32(salesDgv.Rows[index].Cells[1].Value);
            var car_idNew = 0;
            var qty = 0;
            var queryString = $"SELECT car_id FROM cars WHERE car_model='{car_modelTxt.Text}'";
            var command = new SqlCommand(queryString, _dataBase.GetConnection());
            _dataBase.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                car_idNew = reader.GetInt32(0);
            }
            reader.Close();
            if (fio != string.Empty && phone != string.Empty && sale_date != string.Empty &&decimal.TryParse(price, out d)
                && sumTxt.Text.Substring(0, 1) != "-")
            {
                var changequery = $"UPDATE sales SET car_id = {car_idNew}, " +
                    $"fio = '{fio}', phone = '{phone}', sale_date = '{sale_date}'," +
                    $"price ={price} WHERE sale_id = {id}";
                command = new SqlCommand(changequery, _dataBase.GetConnection());
                command.ExecuteNonQuery();
                queryString = $"SELECT qty_of_cars FROM cars WHERE car_id='{car_idOld}'";
                command = new SqlCommand(queryString, _dataBase.GetConnection());
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    qty = reader.GetInt32(0);
                }
                reader.Close();
                var updQuery = $"UPDATE cars SET qty_of_cars={qty + 1} WHERE car_id={car_idOld}";
                command = new SqlCommand(updQuery, _dataBase.GetConnection());
                command.ExecuteNonQuery();
                queryString = $"SELECT qty_of_cars FROM cars WHERE car_id='{car_idNew}'";
                command = new SqlCommand(queryString, _dataBase.GetConnection());
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    qty = reader.GetInt32(0);
                }
                reader.Close();
                updQuery = $"UPDATE cars SET qty_of_cars={qty - 1} WHERE car_id={car_idNew}";
                command = new SqlCommand(updQuery, _dataBase.GetConnection());
                command.ExecuteNonQuery();
                _dataBase.closeConnection();
                RefreshDgv();
            }
            else
            {
                MessageBox.Show("Неверный ввод!");
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            Hide();
            AddSaleForm addSaleForm = new AddSaleForm();
            addSaleForm.FormClosed += formClosed;
            addSaleForm.Show();
        }
        void formClosed(object sender, FormClosedEventArgs e)
        {
            Show();
            RefreshDgv();
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            var qty = 0;
            DialogResult result = MessageBox.Show("Вы действительно хотите удалить запись?", "Удаление", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                int index = salesDgv.CurrentCell.RowIndex;
                if (index != -1)
                {
                    salesDgv.Rows[index].Visible = false;
                    _dataBase.openConnection();
                    var id = Convert.ToInt32(salesDgv.Rows[index].Cells[0].Value);
                    var car_id = Convert.ToInt32(salesDgv.Rows[index].Cells[1].Value);
                    var deleteQuery = $"DELETE FROM sales WHERE sale_id= {id}";
                    var command = new SqlCommand(deleteQuery, _dataBase.GetConnection());
                    command.ExecuteNonQuery();
                    var queryString = $"SELECT qty_of_cars FROM cars WHERE car_id='{car_id}'";
                    command = new SqlCommand(queryString, _dataBase.GetConnection());
                    _dataBase.openConnection();
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        qty = reader.GetInt32(0);
                    }
                    reader.Close();
                    var updQuery = $"UPDATE cars SET qty_of_cars={qty + 1} WHERE car_id={car_id}";
                    command = new SqlCommand(updQuery, _dataBase.GetConnection());
                    command.ExecuteNonQuery();
                    _dataBase.closeConnection();
                }
                RefreshDgv();
            }
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
            ExcelApp.Cells[1, 1] = "Марка машины";
            ExcelApp.Cells[1, 2] = "Модель машины";
            ExcelApp.Cells[1, 3] = "ФИО покупателя";
            ExcelApp.Cells[1, 4] = "Телефон покупателя";
            ExcelApp.Cells[1, 5] = "Дата";
            ExcelApp.Cells[1, 6] = "Сумма";
            for (int i = 0; i < salesDgv.Rows.Count; i++)
            {
                for (int j = 2; j < salesDgv.ColumnCount; j++)
                {
                    ExcelApp.Cells[i + 2, j -1] = salesDgv.Rows[i].Cells[j].Value;
                }
            }
            //Вызываем нашу созданную эксельку.
            ExcelApp.Visible = true;
            ExcelApp.UserControl = true;
        }


        private void clrFilterBtn_Click(object sender, EventArgs e)
        {
            markFiltertxt.SelectedIndex=0;
            RefreshDgv();
        }

        private void ascendingBtn_Click(object sender, EventArgs e)
        {
            if (markRb.Checked)
            {
                salesDgv.Sort(salesDgv.Columns[2], ListSortDirection.Ascending);
            }
            else if (modelRb.Checked)
            {
                salesDgv.Sort(salesDgv.Columns[3], ListSortDirection.Ascending);
            }
            else if (dateRb.Checked)
            {
                salesDgv.Sort(salesDgv.Columns[6], ListSortDirection.Ascending);
            }
            else if (sumRb.Checked)
            {
                salesDgv.Sort(salesDgv.Columns[7], ListSortDirection.Ascending);
            }
            else if (telRb.Checked)
            {
                salesDgv.Sort(salesDgv.Columns[5], ListSortDirection.Ascending);
            }
            else if (fioRb.Checked)
            {
                salesDgv.Sort(salesDgv.Columns[4], ListSortDirection.Ascending);
            }
        }

        private void descendingBtn_Click(object sender, EventArgs e)
        {
            if (markRb.Checked)
            {
                salesDgv.Sort(salesDgv.Columns[2], ListSortDirection.Descending);
            }
            else if (modelRb.Checked)
            {
                salesDgv.Sort(salesDgv.Columns[3], ListSortDirection.Descending);
            }
            else if (dateRb.Checked)
            {
                salesDgv.Sort(salesDgv.Columns[6], ListSortDirection.Descending);
            }
            else if (sumRb.Checked)
            {
                salesDgv.Sort(salesDgv.Columns[7], ListSortDirection.Descending);
            }
            else if (telRb.Checked)
            {
                salesDgv.Sort(salesDgv.Columns[5], ListSortDirection.Descending);
            }
            else if (fioRb.Checked)
            {
                salesDgv.Sort(salesDgv.Columns[4], ListSortDirection.Descending);
            }
        }

        private void clrBtn_Click(object sender, EventArgs e)
        {
            salesDgv.Sort(salesDgv.Columns[0],ListSortDirection.Ascending);
            if (markRb.Checked)
            {
                markRb.Checked= false;
            }
            else if (modelRb.Checked)
            {
                modelRb.Checked = false;
            }
            else if (dateRb.Checked)
            {
                dateRb.Checked = false;
            }
            else if (sumRb.Checked)
            {
                sumRb.Checked = false;
            }
            else if (telRb.Checked)
            {
                telRb.Checked = false;
            }
            else if (fioRb.Checked)
            {
                fioRb.Checked = false;
            }
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
                int index = salesDgv.CurrentCell.RowIndex;
                if (reader[8].ToString() != "0" || reader[2].ToString()==salesDgv[3,index].Value.ToString())
                {
                    car_modelTxt.Items.Add(reader[2].ToString());
                    car_modelTxt.SelectedIndex = 0;
                }
            }
            reader.Close();
        }

        private void clrPoiskBtn_Click(object sender, EventArgs e)
        {
            searchTxt.Text = string.Empty;
            for (int i = 0; i < salesDgv.Rows.Count; i++)
            {
                for (int j = 0; j < salesDgv.Columns.Count; j++)
                {
                    salesDgv[j, i].Selected = false;
                }
            }
        }

        private void fioTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }

        private void markFiltertxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (markFiltertxt.SelectedIndex != 0) 
            {
                for (int i = 0; i < salesDgv.Rows.Count; i++)
                {
                    if (salesDgv[2, i].Value.ToString() != markFiltertxt.Text)
                    {
                        salesDgv.Rows[i].Visible = false;
                    }
                    else
                    {
                        salesDgv.Rows[i].Visible = true;
                    }
                }
            }
        }

        private void spisokBtn_Click(object sender, EventArgs e)
        {
            Hide();
            SalesListForm salesList = new SalesListForm();
            salesList.FormClosed += formClosed;
            salesList.Show();
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
