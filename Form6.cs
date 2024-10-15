using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using SD = System.Data;
using Excel = Microsoft.Office.Interop.Excel;
using Уп;
namespace Уп
{
    public partial class Form6 : Form
    {
        int idrow = -1;
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Close();
        }

        private void buttonVivod_Click(object sender, EventArgs e)
        {
            buttonExel.Enabled = true;
            Uslug.Rows.Clear();
            OleDbConnection con = Reader.Connection;
            OleDbDataAdapter ad = new OleDbDataAdapter("Select * FROM Услуги", con);
            SD.DataSet ds = new DataSet();

            ad.Fill(ds);
            Uslug.ColumnCount = ds.Tables[0].Columns.Count;
            Uslug.RowCount = ds.Tables[0].Rows.Count;

            Uslug.Columns[0].HeaderText = "КодУслуги";
            Uslug.Columns[1].HeaderText = "НазваниеУслуги";
            Uslug.Columns[2].HeaderText = "СтоимостьУслуги";
            Uslug.Columns[3].HeaderText = "СкоростьИнтернета";
            Uslug.Columns[4].HeaderText = "ТВ";
            Uslug.Columns[5].HeaderText = "КолВоКаналов";
            Uslug.Columns[6].HeaderText = "СтоимостьПодключения";
            Uslug.Columns[7].HeaderText = "СтоимостьАрендыМаршрутизатора";
            for (int i = 0; i < Uslug.ColumnCount; i++)
            {
                for (int j = 0; j < Uslug.RowCount; j++)
                {
                    Uslug[i, j].Value = ds.Tables[0].Rows[j][i].ToString();
                }
            }
            ad.SelectCommand.CommandText = "SELECT * FROM Услуги";
            ds.Clear();
            ad.Fill(ds);
            foreach (DataRow i in ds.Tables[0].Rows)
            {
                comboBox1.Items.Add(i["КодУслуги"]);
            }
         
        }

        private void buttonExel_Click(object sender, EventArgs e)
        {
            ExportToExcel();
        }
        private void ExportToExcel()
        {
            Excel.Application exApp = new Excel.Application();
            exApp.Visible = true;
            exApp.Workbooks.Add();
            Worksheet workSheet = (Worksheet)exApp.ActiveSheet;
            workSheet.Cells[1, "A"] = "КодУслуги";
            workSheet.Cells[1, "B"] = "НазваниеУслуги";
            workSheet.Cells[1, "C"] = "СтоимостьУслуги";
            workSheet.Cells[1, "D"] = "СкоростьИнтернета";
            workSheet.Cells[1, "E"] = "ТВ";
            workSheet.Cells[1, "G"] = "КолВоКаналов";
            workSheet.Cells[1, "F"] = "СтоимостьПодключения";
            workSheet.Cells[1, "H"] = "СтоимостьАрендыМаршрутизатора";
            int rowExcel = 2;
            for (int i = 0; i < Uslug.Rows.Count; i++)
            {
                workSheet.Cells[rowExcel, "A"] = Uslug.Rows[i].Cells[0].Value;
                workSheet.Cells[rowExcel, "B"] = Uslug.Rows[i].Cells[1].Value;
                workSheet.Cells[rowExcel, "C"] = Uslug.Rows[i].Cells[2].Value;
                workSheet.Cells[rowExcel, "D"] = Uslug.Rows[i].Cells[3].Value;
                workSheet.Cells[rowExcel, "E"] = Uslug.Rows[i].Cells[4].Value;
                workSheet.Cells[rowExcel, "F"] = Uslug.Rows[i].Cells[5].Value;
                workSheet.Cells[rowExcel, "G"] = Uslug.Rows[i].Cells[6].Value;
                workSheet.Cells[rowExcel, "H"] = Uslug.Rows[i].Cells[7].Value;
              
                ++rowExcel;
            }
            string pathToXmlFile;
            pathToXmlFile = Environment.CurrentDirectory + "\\" + "Услуги.xls";
            workSheet.SaveAs(pathToXmlFile);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (idrow == -1)
            {
                MessageBox.Show("Не выбрана строка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            OleDbConnection connection = Reader.Connection;     //Подключние к БД
            OleDbDataAdapter ad;                                //Переводчик
            DataSet ds = new DataSet();     //БД
            SD.DataTable dt;               //Таблица БД
            bool del = false;
            connection.Open();
            ad = new OleDbDataAdapter("SELECT * FROM Услуги", connection);
            ad.Fill(ds);
            dt = ds.Tables[0];
            foreach (DataRow i in dt.Rows)
            {
                del = Uslug[0, idrow].Value.ToString() == i["КодУслуги"].ToString();
                if (del)
                {
                    i.Delete();
                    break;
                }
            }
            OleDbCommandBuilder builder = new OleDbCommandBuilder(ad);
            ad.Update(dt);
            connection.Close();
            if (!del) return;
            new EventHandler(buttonVivod_Click).Invoke(null, null);
        }

        private void Uslug_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idrow = e.RowIndex;
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxZP.Text.Length == 0 ||
            textBoxKolVoSotr.Text.Length == 0 ||
            textBoxName.Text.Length == 0 ||
            comboBox1.Text.Length == 0 ||
            textBox1.Text.Length == 0 ||
            textBox2.Text.Length == 0)
            {
                MessageBox.Show("Введите значение в поле !");
                return;
            }
            OleDbConnection connection = Reader.Connection;     //Подключние к БД
            OleDbDataAdapter ad;                                //Переводчик
            DataSet ds = new DataSet();     //БД
            SD.DataTable dt;               //Таблица БД

            connection.Open();
            ad = new OleDbDataAdapter("SELECT * FROM Услуги", connection);
            ad.Fill(ds);
            dt = ds.Tables[0];

            //dt.Rows.RemoveAt(0);  - удаление

            DataRow dr = dt.NewRow();
            dr["НазваниеУслуги"] = comboBox1.SelectedItem.ToString();
            dr["СтоимостьУслуги"] = textBoxZP.Text;
            dr["СкоростьИнтернета"] = textBoxKolVoSotr.Text;
            dr["КолВоКаналов"] = textBoxName.Text;
            dr["ТВ"] = checkBox1.Checked;
            dr["СтоимостьПодключения"] = textBox1.Text;
            dr["СтоимостьАрендыМаршрутизатора"] = textBox2.Text;

            dt.Rows.Add(dr);    //Новая строка в таблице

            OleDbCommandBuilder builder = new OleDbCommandBuilder(ad);
            ad.Update(dt);

            connection.Close();
            new EventHandler(buttonVivod_Click).Invoke(null, null);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OleDbConnection connection = Reader.Connection;     //Подключние к БД
            OleDbDataAdapter ad;                                //Переводчик
            DataSet ds = new DataSet();     //БД
            SD.DataTable dt;
            connection.Open();
            ad = new OleDbDataAdapter("SELECT * FROM Услуги", connection);
            ad.Fill(ds);
            dt = ds.Tables[0];

            Uslug.Rows.Clear();

            foreach (DataRow i in dt.Rows)
            {
                if (i["НазваниеУслуги"].ToString().IndexOf(textBoxPoisk.Text) == -1) continue;
                Uslug.Rows.Add(i.ItemArray);
            }

            connection.Close();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void textBoxZP_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void textBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void buttonIzmen_Click(object sender, EventArgs e)
        {
            if (idrow == -1)
            {
                MessageBox.Show("Не выбрана строка", "Система", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            OleDbConnection connection = Reader.Connection;     //Подключние к БД
            OleDbDataAdapter ad;                                //Переводчик
            DataSet ds = new DataSet();     //БД
            SD.DataTable dt;               //Таблица БД

            connection.Open();
            ad = new OleDbDataAdapter("SELECT * FROM Услуги", connection);
            ad.Fill(ds);
            dt = ds.Tables[0];

            //dt.Rows.RemoveAt(0);  - удаление

            DataRow dr = dt.Rows[idrow];

            dr["НазваниеУслуги"] = comboBox1.SelectedItem.ToString();
            dr["СтоимостьУслуги"] = textBoxZP.Text;
            dr["СкоростьИнтернета"] = textBoxKolVoSotr.Text;
            dr["КолВоКаналов"] = textBoxName.Text;
            dr["ТВ"] = checkBox1.Checked;
            dr["СтоимостьПодключения"] = textBox1.Text;
            dr["СтоимостьАрендыМаршрутизатора"] = textBox2.Text;

            OleDbCommandBuilder builder = new OleDbCommandBuilder(ad);
            ad.Update(dt);

            connection.Close();
            buttonVivod_Click(null, null);
        }
    }
}



