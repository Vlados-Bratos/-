using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Уп
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Данный блок берет данные из БД - "таблица Авторизация", после чего их сверяет с веденными в TextBox-ы. Если они совпадают, то пропускает к Главной форме, при неправильном вводе выведется сообщение о неправильных данных
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
           
            OleDbConnection connect = Reader.Connection;
            OleDbCommand cmd = new OleDbCommand();
            OleDbDataReader RD;

            connect.Open();
            cmd.Connection = connect;
            cmd.CommandText = $"SELECT * FROM Авторизация WHERE Логин ='{textBox1.Text}' AND Пароль = '{textBox2.Text}'";
            RD = cmd.ExecuteReader();
            if (RD.Read())
            {
                MessageBox.Show("Добро пожаловать!");
                Form2 f2 = new Form2();
                f2.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Неверный логин или пароль!");

        }
        /// <summary>
        /// Данный блок завершает работу приложения
        /// </summary>
        
        private void button2_Click(object sender, EventArgs e)
        {
            
           
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    
}
