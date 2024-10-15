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
    public partial class Form4 : Form
    {
        int idrow = -1;
        public Form4()
        {
            InitializeComponent();
        }
        private void Form4_Load(object sender, EventArgs e)
        {
        }
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text.Length == 0 ||
             textBoxZP.Text.Length == 0 ||
             textBoxKolVoSotr.Text.Length == 0)
            {
                MessageBox.Show("Введите значение в поле !");
                return;
            }
            OleDbConnection connection = Reader.Connection;     //Подключние к БД
            OleDbDataAdapter ad;                                //Переводчик
            DataSet ds = new DataSet();     //БД
            SD.DataTable dt;               //Таблица БД

            connection.Open();
            ad = new OleDbDataAdapter("SELECT * FROM Должности", connection);
            ad.Fill(ds);
            dt = ds.Tables[0];

            //dt.Rows.RemoveAt(0);  - удаление

            DataRow dr = dt.NewRow();

            dr["Наименование"] = textBoxName.Text;
            dr["Зарплата"] = textBoxZP.Text;
            dr["КолВоСотрудников"] = textBoxKolVoSotr.Text;
           

            dt.Rows.Add(dr);    //Новая строка в таблице

            OleDbCommandBuilder builder = new OleDbCommandBuilder(ad);
            ad.Update(dt);

            connection.Close();
            new EventHandler(buttonVivod_Click).Invoke(null, null);
        }

        private void buttonVivod_Click(object sender, EventArgs e)
        {
            buttonExel.Enabled = true;
            Dolg.Rows.Clear();
            OleDbConnection con = Reader.Connection;
           OleDbDataAdapter ad = new OleDbDataAdapter("Select * FROM Должности", con);
            SD.DataSet ds = new DataSet();

            ad.Fill(ds);
            Dolg.ColumnCount = ds.Tables[0].Columns.Count;
            Dolg.RowCount = ds.Tables[0].Rows.Count;

            Dolg.Columns[0].HeaderText = "КодДолжности"; 
            Dolg.Columns[1].HeaderText = "Наименование";
            Dolg.Columns[2].HeaderText = "Зарплата";
            Dolg.Columns[3].HeaderText = "КолВоСотрудников";
            for (int i = 0; i < Dolg.ColumnCount; i++)
            {
                for (int j = 0; j < Dolg.RowCount; j++)
                {
                    Dolg[i, j].Value = ds.Tables[0].Rows[j][i].ToString();
                }
            }
            ds.Clear();
           ad.Fill(ds);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Close();
        }

        private void buttonDelete_Click(object sender, EventArgs e)    //Должности
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
            ad = new OleDbDataAdapter("SELECT * FROM Должности", connection);
            ad.Fill(ds);
            dt = ds.Tables[0];
            foreach (DataRow i in dt.Rows)
            {
                del = Dolg[0, idrow].Value.ToString() == i["КодДолжности"].ToString();
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

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void textBoxZP_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBoxKolVoSotr_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void textBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            string Symbol = e.KeyChar.ToString();

            if (!Regex.Match(Symbol, @"[а-яА-Я]|[a-zA-Z]").Success)
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

        private void button6_Click(object sender, EventArgs e)
        {
            OleDbConnection connection = Reader.Connection;     //Подключние к БД
            OleDbDataAdapter ad;                                //Переводчик
            DataSet ds = new DataSet();     //БД
            SD.DataTable dt;
            connection.Open();
            ad = new OleDbDataAdapter("SELECT * FROM Должности", connection);
            ad.Fill(ds);
            dt = ds.Tables[0];

            Dolg.Rows.Clear();

            foreach (DataRow i in dt.Rows)
            {
                if (i["Наименование"].ToString().IndexOf(textBoxPoisk.Text) == -1) continue;
                Dolg.Rows.Add(i.ItemArray);
            }

            connection.Close();
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
            workSheet.Cells[1, "A"] = "КодДолжности";
            workSheet.Cells[1, "B"] = "Наименование";
            workSheet.Cells[1, "C"] = "Зарплата";
            workSheet.Cells[1, "D"] = "КолВоСотрудников";
           

            int rowExcel = 2;
            for (int i = 0; i < Dolg.Rows.Count; i++)
            {
                workSheet.Cells[rowExcel, "A"] = Dolg.Rows[i].Cells[0].Value;
                workSheet.Cells[rowExcel, "B"] = Dolg.Rows[i].Cells[1].Value;
                workSheet.Cells[rowExcel, "C"] = Dolg.Rows[i].Cells[2].Value;
                workSheet.Cells[rowExcel, "D"] = Dolg.Rows[i].Cells[3].Value;
                ++rowExcel;
            }
            string pathToXmlFile;
            pathToXmlFile = Environment.CurrentDirectory + "\\" + "Должности.xls";
            workSheet.SaveAs(pathToXmlFile);
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = new Bitmap(Dolg.Size.Width + 10, Dolg.Size.Height + 10);
            Dolg.DrawToBitmap(bmp, Dolg.Bounds);
            e.Graphics.DrawImage(bmp, 0, 0);
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
            ad = new OleDbDataAdapter("SELECT * FROM Должности", connection);
            ad.Fill(ds);
            dt = ds.Tables[0];

            //dt.Rows.RemoveAt(0);  - удаление

            DataRow dr = dt.Rows[idrow];

            dr["Наименование"] = textBoxName.Text;
            dr["Зарплата"] = textBoxZP.Text;
            dr["КолВоСотрудников"] = textBoxKolVoSotr.Text;

            OleDbCommandBuilder builder = new OleDbCommandBuilder(ad);
            ad.Update(dt);

            connection.Close();
            buttonVivod_Click(null, null);
        }

        private void GroupBoxAddNewClient_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxPoisk_TextChanged(object sender, EventArgs e)
        {

        }

        private void Poisk_Click(object sender, EventArgs e)
        {

        }

        private void Doljnosti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Dolg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idrow = e.RowIndex;
        }
    }
}
