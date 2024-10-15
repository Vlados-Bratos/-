using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.Office.Interop.Excel;
using SD = System.Data;
using Excel = Microsoft.Office.Interop.Excel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace Уп
{
    public partial class Form3 : Form
    {
      
        int idrow = -1;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void textBoxPoisk_TextChanged(object sender, EventArgs e)
        {

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
            ad = new OleDbDataAdapter("SELECT * FROM Клиенты", connection);
            ad.Fill(ds);
            dt = ds.Tables[0];

            //dt.Rows.RemoveAt(0);  - удаление

            DataRow dr = dt.NewRow();

            dr["ФИО"] = textBoxFIO.Text;
            dr["Тел"] = textBoxTel.Text;
            dr["Адрес"] = textBoxAdres.Text;
            dr["Услуга"] = comboBox1.SelectedItem.ToString();
            dr["Паспорт"] = textBoxPass.Text;

            dt.Rows.Add(dr);    //Новая строка в таблице

            OleDbCommandBuilder builder = new OleDbCommandBuilder(ad);
            ad.Update(dt);

            connection.Close();
            new EventHandler(buttonVivod_Click).Invoke(null, null);
        }



        private void buttonVivod_Click(object sender, EventArgs e)
        {
            buttonExel.Enabled = true;
               
            Clients.Rows.Clear();

            OleDbConnection con = Reader.Connection;
            OleDbDataAdapter ad = new OleDbDataAdapter("Select * FROM Клиенты", con);
            DataSet ds = new DataSet();

            ad.Fill(ds);
            Clients.ColumnCount = ds.Tables[0].Columns.Count;
            Clients.RowCount = ds.Tables[0].Rows.Count;

            Clients.Columns[0].HeaderText = "Код_клиента";
            Clients.Columns[1].HeaderText = "ФИО";
            Clients.Columns[2].HeaderText = "Телефон";
            Clients.Columns[3].HeaderText = "Адрес";
            Clients.Columns[4].HeaderText = "Паспорт";
            Clients.Columns[5].HeaderText = "Услуга";


            for (int i = 0; i < Clients.ColumnCount; i++)
            {
                for (int j = 0; j < Clients.RowCount; j++)
                {
                    Clients[i, j].Value = ds.Tables[0].Rows[j][i].ToString();
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
        /// <summary>
        /// Данный блок завершает возвращает на прошлую страницу приложения
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Close();
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
            ad = new OleDbDataAdapter("SELECT * FROM Клиенты", connection);
            ad.Fill(ds);
            dt = ds.Tables[0];
            foreach (DataRow i in dt.Rows)
            {
                del = Clients[0, idrow].Value.ToString() == i["КодКлиента"].ToString();
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

        private void Clients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idrow = e.RowIndex;
        }

        private void GroupBoxAddNewClient_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxFIO_KeyPress(object sender, KeyPressEventArgs e)
        {
            string Symbol = e.KeyChar.ToString();

            if (!Regex.Match(Symbol, @"[а-яА-Я]|[a-zA-Z]").Success)
            {
                e.Handled = true;
            }
        }

        private void textBoxTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number))
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

        private void button6_Click(object sender, EventArgs e)
        {
            OleDbConnection connection = Reader.Connection;     //Подключние к БД
            OleDbDataAdapter ad;                                //Переводчик
            DataSet ds = new DataSet();     //БД
            SD.DataTable dt;
            connection.Open();
            ad = new OleDbDataAdapter("SELECT * FROM Клиенты", connection);
            ad.Fill(ds);
            dt = ds.Tables[0];

            Clients.Rows.Clear();

            foreach (DataRow i in dt.Rows)
            {
                if (i["ФИО"].ToString().IndexOf(textBoxPoisk.Text) == -1) continue;
                Clients.Rows.Add(i.ItemArray);
            }

            connection.Close();
        }
        /// <summary>
        /// Принимает значение метода "ExportToExcel"
        /// </summary>

        private void buttonExel_Click(object sender, EventArgs e)
        {
            ExportToExcel();
            
        }
        /// <summary>
        /// Данный метод считывает данные из Таблицы "Клиенты" и записывает их документ Exel. После чего их можно распечатать
        /// </summary>
        private void ExportToExcel()
        {

            Excel.Application exApp = new Excel.Application();
            exApp.Visible = true;
            exApp.Workbooks.Add();
            Worksheet workSheet = (Worksheet)exApp.ActiveSheet;
            workSheet.Cells[1, "A"] = "Код_клиента";
            workSheet.Cells[1, "B"] = "ФИО";
            workSheet.Cells[1, "C"] = "Телефон";
            workSheet.Cells[1, "D"] = "Адрес";
            workSheet.Cells[1, "E"] = "Паспорт";
            workSheet.Cells[1, "F"] = "Услуга";
         
            int rowExcel = 2;
            for (int i = 0; i < Clients.Rows.Count; i++)
            {
                workSheet.Cells[rowExcel, "A"] = Clients.Rows[i].Cells[0].Value;
                workSheet.Cells[rowExcel, "B"] = Clients.Rows[i].Cells[1].Value;
                workSheet.Cells[rowExcel, "C"] = Clients.Rows[i].Cells[2].Value;
                workSheet.Cells[rowExcel, "D"] = Clients.Rows[i].Cells[3].Value;
                workSheet.Cells[rowExcel, "E"] = Clients.Rows[i].Cells[4].Value;
                workSheet.Cells[rowExcel, "F"] = Clients.Rows[i].Cells[5].Value;
            
                ++rowExcel;
            }
            string pathToXmlFile;
            pathToXmlFile = Environment.CurrentDirectory + "\\" + "Клиенты.xls";
            workSheet.SaveAs(pathToXmlFile);
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
            ad = new OleDbDataAdapter("SELECT * FROM Клиенты", connection);
            ad.Fill(ds);
            dt = ds.Tables[0];

            //dt.Rows.RemoveAt(0);  - удаление

            DataRow dr = dt.Rows[idrow];

            dr["ФИО"] = textBoxFIO.Text;
            dr["Тел"] = textBoxTel.Text;
            dr["Адрес"] = textBoxAdres.Text;
            dr["Услуга"] = comboBox1.SelectedItem.ToString();
            dr["Паспорт"] = textBoxPass.Text;

            OleDbCommandBuilder builder = new OleDbCommandBuilder(ad);
            ad.Update(dt);

            connection.Close();
            buttonVivod_Click(null, null);
        }
    }
}





