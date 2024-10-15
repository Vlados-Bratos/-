namespace Уп
{
    partial class Form6
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button6 = new System.Windows.Forms.Button();
            this.buttonExel = new System.Windows.Forms.Button();
            this.buttonIzmen = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonVivod = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.GroupBoxAddNewClient = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBoxKolVoSotr = new System.Windows.Forms.TextBox();
            this.Adres = new System.Windows.Forms.Label();
            this.textBoxZP = new System.Windows.Forms.TextBox();
            this.Tel = new System.Windows.Forms.Label();
            this.labelFIO = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxPoisk = new System.Windows.Forms.TextBox();
            this.Poisk = new System.Windows.Forms.Label();
            this.Uslug = new System.Windows.Forms.DataGridView();
            this.GroupBoxAddNewClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Uslug)).BeginInit();
            this.SuspendLayout();
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Azure;
            this.button6.Location = new System.Drawing.Point(815, 8);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 34;
            this.button6.Text = "Поиск";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // buttonExel
            // 
            this.buttonExel.BackColor = System.Drawing.Color.Azure;
            this.buttonExel.Enabled = false;
            this.buttonExel.Location = new System.Drawing.Point(725, 467);
            this.buttonExel.Name = "buttonExel";
            this.buttonExel.Size = new System.Drawing.Size(165, 45);
            this.buttonExel.TabIndex = 33;
            this.buttonExel.Text = "Вывод на печать";
            this.buttonExel.UseVisualStyleBackColor = false;
            this.buttonExel.Click += new System.EventHandler(this.buttonExel_Click);
            // 
            // buttonIzmen
            // 
            this.buttonIzmen.BackColor = System.Drawing.Color.Azure;
            this.buttonIzmen.Location = new System.Drawing.Point(13, 467);
            this.buttonIzmen.Margin = new System.Windows.Forms.Padding(4);
            this.buttonIzmen.Name = "buttonIzmen";
            this.buttonIzmen.Size = new System.Drawing.Size(165, 45);
            this.buttonIzmen.TabIndex = 32;
            this.buttonIzmen.Text = "Изменить запись";
            this.buttonIzmen.UseVisualStyleBackColor = false;
            this.buttonIzmen.Click += new System.EventHandler(this.buttonIzmen_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Azure;
            this.buttonDelete.Location = new System.Drawing.Point(260, 467);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(165, 45);
            this.buttonDelete.TabIndex = 31;
            this.buttonDelete.Text = "Удалить запись";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonVivod
            // 
            this.buttonVivod.BackColor = System.Drawing.Color.Azure;
            this.buttonVivod.Location = new System.Drawing.Point(495, 467);
            this.buttonVivod.Margin = new System.Windows.Forms.Padding(4);
            this.buttonVivod.Name = "buttonVivod";
            this.buttonVivod.Size = new System.Drawing.Size(165, 45);
            this.buttonVivod.TabIndex = 30;
            this.buttonVivod.Text = "Вывод таблицы";
            this.buttonVivod.UseVisualStyleBackColor = false;
            this.buttonVivod.Click += new System.EventHandler(this.buttonVivod_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Coral;
            this.button1.Location = new System.Drawing.Point(1140, 462);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 55);
            this.button1.TabIndex = 29;
            this.button1.Text = "Вернуться обратно";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GroupBoxAddNewClient
            // 
            this.GroupBoxAddNewClient.Controls.Add(this.checkBox1);
            this.GroupBoxAddNewClient.Controls.Add(this.label4);
            this.GroupBoxAddNewClient.Controls.Add(this.ButtonAdd);
            this.GroupBoxAddNewClient.Controls.Add(this.textBox2);
            this.GroupBoxAddNewClient.Controls.Add(this.label3);
            this.GroupBoxAddNewClient.Controls.Add(this.textBox1);
            this.GroupBoxAddNewClient.Controls.Add(this.label2);
            this.GroupBoxAddNewClient.Controls.Add(this.label1);
            this.GroupBoxAddNewClient.Controls.Add(this.comboBox1);
            this.GroupBoxAddNewClient.Controls.Add(this.textBoxKolVoSotr);
            this.GroupBoxAddNewClient.Controls.Add(this.Adres);
            this.GroupBoxAddNewClient.Controls.Add(this.textBoxZP);
            this.GroupBoxAddNewClient.Controls.Add(this.Tel);
            this.GroupBoxAddNewClient.Controls.Add(this.labelFIO);
            this.GroupBoxAddNewClient.Controls.Add(this.textBoxName);
            this.GroupBoxAddNewClient.Location = new System.Drawing.Point(896, 38);
            this.GroupBoxAddNewClient.Name = "GroupBoxAddNewClient";
            this.GroupBoxAddNewClient.Size = new System.Drawing.Size(419, 414);
            this.GroupBoxAddNewClient.TabIndex = 28;
            this.GroupBoxAddNewClient.TabStop = false;
            this.GroupBoxAddNewClient.Text = "Добавить новую должность";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(108, 325);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(18, 17);
            this.checkBox1.TabIndex = 16;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(7, 325);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 36);
            this.label4.TabIndex = 15;
            this.label4.Text = "ТВ\r\n\r\n";
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.BackColor = System.Drawing.Color.Azure;
            this.ButtonAdd.Location = new System.Drawing.Point(6, 364);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(160, 50);
            this.ButtonAdd.TabIndex = 0;
            this.ButtonAdd.Text = "Добавить Услугу\r\n";
            this.ButtonAdd.UseVisualStyleBackColor = false;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(108, 267);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(294, 22);
            this.textBox2.TabIndex = 14;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(7, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 58);
            this.label3.TabIndex = 13;
            this.label3.Text = "Стоимость Аренды Маршрутизатора\r\n";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(108, 216);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(294, 22);
            this.textBox1.TabIndex = 12;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(7, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 32);
            this.label2.TabIndex = 11;
            this.label2.Text = "Стоимость Подключения";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 32);
            this.label1.TabIndex = 10;
            this.label1.Text = "Кол-во \r\nКаналов";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(108, 22);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(294, 24);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox1_KeyPress);
            // 
            // textBoxKolVoSotr
            // 
            this.textBoxKolVoSotr.Location = new System.Drawing.Point(108, 110);
            this.textBoxKolVoSotr.Name = "textBoxKolVoSotr";
            this.textBoxKolVoSotr.Size = new System.Drawing.Size(294, 22);
            this.textBoxKolVoSotr.TabIndex = 8;
            // 
            // Adres
            // 
            this.Adres.Location = new System.Drawing.Point(7, 100);
            this.Adres.Name = "Adres";
            this.Adres.Size = new System.Drawing.Size(91, 41);
            this.Adres.TabIndex = 7;
            this.Adres.Text = "Скорость Интернета";
            // 
            // textBoxZP
            // 
            this.textBoxZP.Location = new System.Drawing.Point(108, 62);
            this.textBoxZP.Name = "textBoxZP";
            this.textBoxZP.Size = new System.Drawing.Size(294, 22);
            this.textBoxZP.TabIndex = 6;
            this.textBoxZP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxZP_KeyPress);
            // 
            // Tel
            // 
            this.Tel.Location = new System.Drawing.Point(7, 65);
            this.Tel.Name = "Tel";
            this.Tel.Size = new System.Drawing.Size(86, 35);
            this.Tel.TabIndex = 5;
            this.Tel.Text = "Стоимость услуги";
            // 
            // labelFIO
            // 
            this.labelFIO.Location = new System.Drawing.Point(7, 22);
            this.labelFIO.Name = "labelFIO";
            this.labelFIO.Size = new System.Drawing.Size(86, 40);
            this.labelFIO.TabIndex = 0;
            this.labelFIO.Text = "Название Услуги\r\n";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(108, 151);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(3, 10, 15, 15);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(294, 22);
            this.textBoxName.TabIndex = 4;
            this.textBoxName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxName_KeyPress);
            // 
            // textBoxPoisk
            // 
            this.textBoxPoisk.Location = new System.Drawing.Point(151, 9);
            this.textBoxPoisk.Name = "textBoxPoisk";
            this.textBoxPoisk.Size = new System.Drawing.Size(658, 22);
            this.textBoxPoisk.TabIndex = 27;
            // 
            // Poisk
            // 
            this.Poisk.AutoSize = true;
            this.Poisk.Location = new System.Drawing.Point(10, 12);
            this.Poisk.Name = "Poisk";
            this.Poisk.Size = new System.Drawing.Size(135, 16);
            this.Poisk.TabIndex = 26;
            this.Poisk.Text = "Поиск по названию";
            // 
            // Uslug
            // 
            this.Uslug.BackgroundColor = System.Drawing.Color.White;
            this.Uslug.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.Uslug.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Uslug.GridColor = System.Drawing.Color.White;
            this.Uslug.Location = new System.Drawing.Point(12, 38);
            this.Uslug.Name = "Uslug";
            this.Uslug.RowHeadersWidth = 51;
            this.Uslug.RowTemplate.Height = 24;
            this.Uslug.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Uslug.Size = new System.Drawing.Size(878, 414);
            this.Uslug.TabIndex = 25;
            this.Uslug.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Uslug_CellClick);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1336, 539);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.buttonExel);
            this.Controls.Add(this.buttonIzmen);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonVivod);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GroupBoxAddNewClient);
            this.Controls.Add(this.textBoxPoisk);
            this.Controls.Add(this.Poisk);
            this.Controls.Add(this.Uslug);
            this.Name = "Form6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Услуги";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.GroupBoxAddNewClient.ResumeLayout(false);
            this.GroupBoxAddNewClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Uslug)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button buttonExel;
        private System.Windows.Forms.Button buttonIzmen;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonVivod;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox GroupBoxAddNewClient;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.TextBox textBoxKolVoSotr;
        private System.Windows.Forms.Label Adres;
        private System.Windows.Forms.TextBox textBoxZP;
        private System.Windows.Forms.Label Tel;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelFIO;
        private System.Windows.Forms.TextBox textBoxPoisk;
        private System.Windows.Forms.Label Poisk;
        private System.Windows.Forms.DataGridView Uslug;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}