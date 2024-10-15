using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Уп
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Данный блок завершает работу приложения
        /// </summary>
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
       
        /// <summary>
        /// Данный блок перенаправляет на другую форму - "Клиенты"
        /// </summary>
        private void button4_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Close();
        }
        /// <summary>
        /// Данный блок перенаправляет на другую форму - "Должности"
        /// </summary>
        private void button2_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
            this.Close();
        }
        /// <summary>
        /// Данный блок перенаправляет на другую форму - "Сотрудники"
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
            this.Close();
        }
        /// <summary>
        /// Данный блок перенаправляет на другую форму - "Услуги"
        /// </summary>
        private void button6_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.Show();
            this.Close();
        }
        /// <summary>
        /// Данный блок перенаправляет на другую форму - "Оказание услуг"
        /// </summary>
        private void button5_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            f7.Show();
            this.Close();
        }
    }
}
