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
  
    public partial class Form5 : Form
    {
        int idrow = -1;
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

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
            Sotrudniki.Rows.Clear();

            OleDbConnection con = Reader.Connection;
            OleDbDataAdapter ad = new OleDbDataAdapter("Select * FROM ДанныеСотрудников", con);
            DataSet ds = new DataSet();

            ad.Fill(ds);
            Sotrudniki.ColumnCount = ds.Tables[0].Columns.Count;
            Sotrudniki.RowCount = ds.Tables[0].Rows.Count;

            Sotrudniki.Columns[0].HeaderText = "КодСотрудника";
            Sotrudniki.Columns[1].HeaderText = "ФИО";
            Sotrudniki.Columns[2].HeaderText = "Должность";
            Sotrudniki.Columns[3].HeaderText = "Тел";
            Sotrudniki.Columns[4].HeaderText = "АдресПроживания";
            Sotrudniki.Columns[5].HeaderText = "Паспорт";


            for (int i = 0; i < Sotrudniki.ColumnCount; i++)
            {
                for (int j = 0; j < Sotrudniki.RowCount; j++)
                {
                    Sotrudniki[i, j].Value = ds.Tables[0].Rows[j][i].ToString();
                }
            }


            ad.SelectCommand.CommandText = "SELECT * FROM Должности";
            ds.Clear();
            ad.Fill(ds);

            foreach (DataRow i in ds.Tables[0].Rows)
            {
                comboBox1.Items.Add(i["КодДолжности"]);
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
            ad = new OleDbDataAdapter("SELECT * FROM ДанныеСотрудников", connection);
            ad.Fill(ds);
            dt = ds.Tables[0];
            foreach (DataRow i in dt.Rows)
            {
                del = Sotrudniki[0, idrow].Value.ToString() == i["КодСотрудника"].ToString();
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

        private void Sotrudniki_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idrow = e.RowIndex;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OleDbConnection connection = Reader.Connection;     //Подключние к БД
            OleDbDataAdapter ad;                                //Переводчик
            DataSet ds = new DataSet();     //БД
            SD.DataTable dt;
            connection.Open();
            ad = new OleDbDataAdapter("SELECT * FROM ДанныеСотрудников", connection);
            ad.Fill(ds);
            dt = ds.Tables[0];

            Sotrudniki.Rows.Clear();

            foreach (DataRow i in dt.Rows)
            {
                if (i["ФИО"].ToString().IndexOf(textBoxPoisk.Text) == -1) continue;
                Sotrudniki.Rows.Add(i.ItemArray);
            }

            connection.Close();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxFIO.Text.Length == 0 ||
           textBoxTel.Text.Length == 0 ||
           textBoxAdres.Text.Length == 0 ||
           comboBox1.Text.Length == 0 ||
           textBoxPass.Text.Length == 0)
            {
                MessageBox.Show("Введите значение в поле !");
                return;
            }
            OleDbConnection connection = Reader.Connection;     //Подключние к БД
            OleDbDataAdapter ad;                                //Переводчик
            DataSet ds = new DataSet();     //БД
            SD.DataTable dt;               //Таблица БД

            connection.Open();
            ad = new OleDbDataAdapter("SELECT * FROM ДанныеСотрудников", connection);
            ad.Fill(ds);
            dt = ds.Tables[0];

            //dt.Rows.RemoveAt(0);  - удаление

            DataRow dr = dt.NewRow();

       

            dr["ФИО"] = textBoxFIO.Text;
            dr["Должность"] = comboBox1.SelectedItem.ToString();
            dr["Тел"] = textBoxTel.Text;
            dr["АдресПроживания"] = textBoxAdres.Text;
            dr["Паспорт"] = textBoxPass.Text;

            dt.Rows.Add(dr);    //Новая строка в таблице

            OleDbCommandBuilder builder = new OleDbCommandBuilder(ad);
            ad.Update(dt);

            connection.Close();
            new EventHandler(buttonVivod_Click).Invoke(null, null);
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
            workSheet.Cells[1, "A"] = "КодСотрудника";
            workSheet.Cells[1, "B"] = "ФИО";
            workSheet.Cells[1, "C"] = "Должность";
            workSheet.Cells[1, "D"] = "Тел";
            workSheet.Cells[1, "E"] = "АдресПроживания";
            workSheet.Cells[1, "F"] = "Паспорт";
            int rowExcel = 2;
            for (int i = 0; i < Sotrudniki.Rows.Count; i++)
            {
                workSheet.Cells[rowExcel, "A"] = Sotrudniki.Rows[i].Cells[0].Value;
                workSheet.Cells[rowExcel, "B"] = Sotrudniki.Rows[i].Cells[1].Value;
                workSheet.Cells[rowExcel, "C"] = Sotrudniki.Rows[i].Cells[2].Value;
                workSheet.Cells[rowExcel, "D"] = Sotrudniki.Rows[i].Cells[3].Value;
                workSheet.Cells[rowExcel, "E"] = Sotrudniki.Rows[i].Cells[4].Value;
                workSheet.Cells[rowExcel, "F"] = Sotrudniki.Rows[i].Cells[5].Value;
               
                ++rowExcel;
            }
            string pathToXmlFile;
            pathToXmlFile = Environment.CurrentDirectory + "\\" + "ДанныеСотрудников.xls";
            workSheet.SaveAs(pathToXmlFile);
        }

        private void textBoxFIO_KeyPress(object sender, KeyPressEventArgs e)
        {

            string Symbol = e.KeyChar.ToString();

            if (!Regex.Match(Symbol, @"[а-яА-Я]|[a-zA-Z]").Success)
            {
                e.Handled = true;
            }
        }

        private void textBoxPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void textBoxAdres_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
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
            ad = new OleDbDataAdapter("SELECT * FROM ДанныеСотрудников", connection);
            ad.Fill(ds);
            dt = ds.Tables[0];

            //dt.Rows.RemoveAt(0);  - удаление

            DataRow dr = dt.Rows[idrow];


            dr["ФИО"] = textBoxFIO.Text;
            dr["Должность"] = comboBox1.SelectedItem.ToString();
            dr["Тел"] = textBoxTel.Text;
            dr["АдресПроживания"] = textBoxAdres.Text;
            dr["Паспорт"] = textBoxPass.Text;

            OleDbCommandBuilder builder = new OleDbCommandBuilder(ad);
            ad.Update(dt);

            connection.Close();
            buttonVivod_Click(null, null);
        }

    }
}
