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
    
    public partial class Form7 : Form
    {
        int idrow = -1;
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Close();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxZP_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxKolVoSotr_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text.Length == 0 ||
            textBoxZP.Text.Length == 0 ||
            textBoxKolVoSotr.Text.Length == 0 ||
            comboBox1.Text.Length == 0 )
            {
                MessageBox.Show("Введите значение в поле !");
                return;
            }
            OleDbConnection connection = Reader.Connection;     //Подключние к БД
            OleDbDataAdapter ad;                                //Переводчик
            DataSet ds = new DataSet();     //БД
            SD.DataTable dt;               //Таблица БД

            connection.Open();
            ad = new OleDbDataAdapter("SELECT * FROM ОказаниеУслуги", connection);
            ad.Fill(ds);
            dt = ds.Tables[0];

            //dt.Rows.RemoveAt(0);  - удаление

            DataRow dr = dt.NewRow();


            dr["Услуга"] = comboBox1.SelectedItem.ToString();
            dr["КодСотрудника"] = textBoxZP.Text;
            dr["КодКлиента"] = textBoxKolVoSotr.Text; 
            dr["ДатаЗаявкиНаОказаниеУслуги"] = textBoxName.Text;
            dr["АрендаМаршрутизатора"] = checkBox1.Checked;
            dr["СтоимостьУслуги"] = comboBox1.SelectedItem.ToString();
            dr["Оплата"] = checkBox2.Checked;
            


            dt.Rows.Add(dr);    //Новая строка в таблице

            OleDbCommandBuilder builder = new OleDbCommandBuilder(ad);
            ad.Update(dt);

            connection.Close();
            buttonVivod_Click(null, null);
        }

        private void buttonVivod_Click(object sender, EventArgs e)
        {
            buttonExel.Enabled = true;
            OkazUslug.Rows.Clear();
            OleDbConnection con = Reader.Connection;
            OleDbDataAdapter ad = new OleDbDataAdapter("Select * FROM ОказаниеУслуги", con);
            SD.DataSet ds = new DataSet();

            ad.Fill(ds);
            OkazUslug.ColumnCount = ds.Tables[0].Columns.Count;
            OkazUslug.RowCount = ds.Tables[0].Rows.Count;

            OkazUslug.Columns[0].HeaderText = "Услуга";
            OkazUslug.Columns[1].HeaderText = "КодСотрудника";
            OkazUslug.Columns[2].HeaderText = "КодКлиента";
            OkazUslug.Columns[3].HeaderText = "ДатаЗаявкиНаОказаниеУслуги";
            OkazUslug.Columns[4].HeaderText = "АрендаМаршрутизатора";
            OkazUslug.Columns[5].HeaderText = "СтоимостьУслуги";
            OkazUslug.Columns[6].HeaderText = "Оплата";
            for (int i = 0; i < OkazUslug.ColumnCount; i++)
            {
                for (int j = 0; j < OkazUslug.RowCount; j++)
                {
                    OkazUslug[i, j].Value = ds.Tables[0].Rows[j][i].ToString();
                }
            }
            ad.SelectCommand.CommandText = "SELECT * FROM Услуги";
            ds.Clear();
            ad.Fill(ds);
            foreach (DataRow i in ds.Tables[0].Rows)
            {
                comboBox1.Items.Add(i["КодУслуги"]);
            }
            foreach (DataRow i in ds.Tables[0].Rows)
            {
                comboBox2.Items.Add(i["СтоимостьУслуги"]);
            }
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
            ad = new OleDbDataAdapter("SELECT * FROM ОказаниеУслуги", connection);
            ad.Fill(ds);
            dt = ds.Tables[0];
            foreach (DataRow i in dt.Rows)
            {
              del = OkazUslug[0, idrow].Value.ToString() == i["Услуга"].ToString();
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
            buttonVivod_Click(null, null);
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
       
            workSheet.Cells[1, "A"] = "Услуга";
            workSheet.Cells[1, "B"] = "КодСотрудника";
            workSheet.Cells[1, "C"] = "КодКлиента";
            workSheet.Cells[1, "D"] = "ДатаЗаявкиНаОказаниеУслуги";
            workSheet.Cells[1, "E"] = "АрендаМаршрутизатора";
            workSheet.Cells[1, "F"] = "СтоимостьУслуги";
            workSheet.Cells[1, "G"] = "Оплата";
            int rowExcel = 2;
            for (int i = 0; i < OkazUslug.Rows.Count; i++)
            {
                workSheet.Cells[rowExcel, "A"] = OkazUslug.Rows[i].Cells[0].Value;
                workSheet.Cells[rowExcel, "B"] = OkazUslug.Rows[i].Cells[1].Value;
                workSheet.Cells[rowExcel, "C"] = OkazUslug.Rows[i].Cells[2].Value;
                workSheet.Cells[rowExcel, "D"] = OkazUslug.Rows[i].Cells[3].Value;
                workSheet.Cells[rowExcel, "E"] = OkazUslug.Rows[i].Cells[4].Value;
                workSheet.Cells[rowExcel, "F"] = OkazUslug.Rows[i].Cells[5].Value;
                workSheet.Cells[rowExcel, "G"] = OkazUslug.Rows[i].Cells[6].Value;
                ++rowExcel;
            }
            string pathToXmlFile;
            pathToXmlFile = Environment.CurrentDirectory + "\\" + "ОказаниеУслуги.xls";
            workSheet.SaveAs(pathToXmlFile);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OleDbConnection connection = Reader.Connection;     //Подключние к БД
            OleDbDataAdapter ad;                                //Переводчик
            DataSet ds = new DataSet();     //БД
            SD.DataTable dt;
            connection.Open();
            ad = new OleDbDataAdapter("SELECT * FROM ОказаниеУслуги", connection);
            ad.Fill(ds);
            dt = ds.Tables[0];

            OkazUslug.Rows.Clear();

            foreach (DataRow i in dt.Rows)
            {
                if (i["КодКлиента"].ToString().IndexOf(textBoxPoisk.Text) == -1) continue;
                OkazUslug.Rows.Add(i.ItemArray);
            }

            connection.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void OkazUslug_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idrow = e.RowIndex;
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

        private void textBoxKolVoSotr_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void comboBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void buttonIzmen_Click(object sender, EventArgs e)
        {
            if(idrow == -1)
            {
                MessageBox.Show("Не выбрана строка", "Система", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            OleDbConnection connection = Reader.Connection;     //Подключние к БД
            OleDbDataAdapter ad;                                //Переводчик
            DataSet ds = new DataSet();     //БД
            SD.DataTable dt;               //Таблица БД

            connection.Open();
            ad = new OleDbDataAdapter("SELECT * FROM ОказаниеУслуги", connection);
            ad.Fill(ds);
            dt = ds.Tables[0];

            //dt.Rows.RemoveAt(0);  - удаление

            DataRow dr = dt.Rows[idrow];


            dr["Услуга"] = comboBox1.SelectedItem.ToString();
            dr["КодСотрудника"] = textBoxZP.Text;
            dr["КодКлиента"] = textBoxKolVoSotr.Text;
            dr["ДатаЗаявкиНаОказаниеУслуги"] = textBoxName.Text;
            dr["АрендаМаршрутизатора"] = checkBox1.Checked;
            dr["СтоимостьУслуги"] = comboBox1.SelectedItem.ToString();
            dr["Оплата"] = checkBox2.Checked;

            OleDbCommandBuilder builder = new OleDbCommandBuilder(ad);
            ad.Update(dt);

            connection.Close();
            buttonVivod_Click(null, null);
        }
    }
}
