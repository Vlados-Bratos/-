namespace Уп
{
    partial class Form7
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
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Usluga = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxKolVoSotr = new System.Windows.Forms.TextBox();
            this.Adres = new System.Windows.Forms.Label();
            this.textBoxZP = new System.Windows.Forms.TextBox();
            this.Tel = new System.Windows.Forms.Label();
            this.labelFIO = new System.Windows.Forms.Label();
            this.textBoxPoisk = new System.Windows.Forms.TextBox();
            this.Poisk = new System.Windows.Forms.Label();
            this.OkazUslug = new System.Windows.Forms.DataGridView();
            this.GroupBoxAddNewClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OkazUslug)).BeginInit();
            this.SuspendLayout();
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Azure;
            this.button6.Location = new System.Drawing.Point(815, 13);
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
            this.buttonExel.Location = new System.Drawing.Point(725, 472);
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
            this.buttonIzmen.Location = new System.Drawing.Point(13, 472);
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
            this.buttonDelete.Location = new System.Drawing.Point(260, 472);
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
            this.buttonVivod.Location = new System.Drawing.Point(495, 472);
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
            this.button1.Location = new System.Drawing.Point(1140, 467);
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
            this.GroupBoxAddNewClient.Controls.Add(this.comboBox2);
            this.GroupBoxAddNewClient.Controls.Add(this.label3);
            this.GroupBoxAddNewClient.Controls.Add(this.label2);
            this.GroupBoxAddNewClient.Controls.Add(this.comboBox1);
            this.GroupBoxAddNewClient.Controls.Add(this.checkBox2);
            this.GroupBoxAddNewClient.Controls.Add(this.ButtonAdd);
            this.GroupBoxAddNewClient.Controls.Add(this.checkBox1);
            this.GroupBoxAddNewClient.Controls.Add(this.label1);
            this.GroupBoxAddNewClient.Controls.Add(this.Usluga);
            this.GroupBoxAddNewClient.Controls.Add(this.textBoxName);
            this.GroupBoxAddNewClient.Controls.Add(this.textBoxKolVoSotr);
            this.GroupBoxAddNewClient.Controls.Add(this.Adres);
            this.GroupBoxAddNewClient.Controls.Add(this.textBoxZP);
            this.GroupBoxAddNewClient.Controls.Add(this.Tel);
            this.GroupBoxAddNewClient.Controls.Add(this.labelFIO);
            this.GroupBoxAddNewClient.Location = new System.Drawing.Point(896, 43);
            this.GroupBoxAddNewClient.Name = "GroupBoxAddNewClient";
            this.GroupBoxAddNewClient.Size = new System.Drawing.Size(419, 414);
            this.GroupBoxAddNewClient.TabIndex = 28;
            this.GroupBoxAddNewClient.TabStop = false;
            this.GroupBoxAddNewClient.Text = "Добавить новую должность";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(108, 174);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(294, 24);
            this.comboBox2.TabIndex = 24;
            this.comboBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox2_KeyPress);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(13, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Оплата Услуги\r\n";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(13, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 50);
            this.label2.TabIndex = 22;
            this.label2.Text = "Аренда Маршрутизатора";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(108, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(294, 24);
            this.comboBox1.TabIndex = 21;
            this.comboBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox1_KeyPress);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(146, 276);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(18, 17);
            this.checkBox2.TabIndex = 20;
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.BackColor = System.Drawing.Color.Azure;
            this.ButtonAdd.Location = new System.Drawing.Point(6, 316);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(160, 50);
            this.ButtonAdd.TabIndex = 0;
            this.ButtonAdd.Text = "Добавить оказанную услугу";
            this.ButtonAdd.UseVisualStyleBackColor = false;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(146, 223);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(18, 17);
            this.checkBox1.TabIndex = 19;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(16, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 34);
            this.label1.TabIndex = 16;
            this.label1.Text = "Стоимость услуги";
            // 
            // Usluga
            // 
            this.Usluga.Location = new System.Drawing.Point(16, 116);
            this.Usluga.Name = "Usluga";
            this.Usluga.Size = new System.Drawing.Size(89, 52);
            this.Usluga.TabIndex = 14;
            this.Usluga.Text = "Дата Заявки на оказание услуги\r\n";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(108, 136);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(294, 22);
            this.textBoxName.TabIndex = 4;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // textBoxKolVoSotr
            // 
            this.textBoxKolVoSotr.Location = new System.Drawing.Point(108, 91);
            this.textBoxKolVoSotr.Name = "textBoxKolVoSotr";
            this.textBoxKolVoSotr.Size = new System.Drawing.Size(294, 22);
            this.textBoxKolVoSotr.TabIndex = 8;
            this.textBoxKolVoSotr.TextChanged += new System.EventHandler(this.textBoxKolVoSotr_TextChanged);
            this.textBoxKolVoSotr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxKolVoSotr_KeyPress);
            // 
            // Adres
            // 
            this.Adres.Location = new System.Drawing.Point(13, 94);
            this.Adres.Name = "Adres";
            this.Adres.Size = new System.Drawing.Size(91, 22);
            this.Adres.TabIndex = 7;
            this.Adres.Text = "Код клиента";
            // 
            // textBoxZP
            // 
            this.textBoxZP.Location = new System.Drawing.Point(108, 63);
            this.textBoxZP.Name = "textBoxZP";
            this.textBoxZP.Size = new System.Drawing.Size(294, 22);
            this.textBoxZP.TabIndex = 6;
            this.textBoxZP.TextChanged += new System.EventHandler(this.textBoxZP_TextChanged);
            this.textBoxZP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxZP_KeyPress);
            // 
            // Tel
            // 
            this.Tel.Location = new System.Drawing.Point(13, 51);
            this.Tel.Name = "Tel";
            this.Tel.Size = new System.Drawing.Size(86, 34);
            this.Tel.TabIndex = 5;
            this.Tel.Text = "Код Сотрудника";
            // 
            // labelFIO
            // 
            this.labelFIO.Location = new System.Drawing.Point(16, 25);
            this.labelFIO.Name = "labelFIO";
            this.labelFIO.Size = new System.Drawing.Size(66, 23);
            this.labelFIO.TabIndex = 0;
            this.labelFIO.Text = "Услуга";
            // 
            // textBoxPoisk
            // 
            this.textBoxPoisk.Location = new System.Drawing.Point(141, 13);
            this.textBoxPoisk.Name = "textBoxPoisk";
            this.textBoxPoisk.Size = new System.Drawing.Size(668, 22);
            this.textBoxPoisk.TabIndex = 27;
            // 
            // Poisk
            // 
            this.Poisk.AutoSize = true;
            this.Poisk.Location = new System.Drawing.Point(12, 16);
            this.Poisk.Name = "Poisk";
            this.Poisk.Size = new System.Drawing.Size(123, 16);
            this.Poisk.TabIndex = 26;
            this.Poisk.Text = "Поиск по клиенту";
            // 
            // OkazUslug
            // 
            this.OkazUslug.BackgroundColor = System.Drawing.Color.White;
            this.OkazUslug.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.OkazUslug.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OkazUslug.Location = new System.Drawing.Point(12, 43);
            this.OkazUslug.Name = "OkazUslug";
            this.OkazUslug.RowHeadersWidth = 51;
            this.OkazUslug.RowTemplate.Height = 24;
            this.OkazUslug.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OkazUslug.Size = new System.Drawing.Size(878, 414);
            this.OkazUslug.TabIndex = 25;
            this.OkazUslug.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OkazUslug_CellClick);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1345, 541);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.buttonExel);
            this.Controls.Add(this.buttonIzmen);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonVivod);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GroupBoxAddNewClient);
            this.Controls.Add(this.textBoxPoisk);
            this.Controls.Add(this.Poisk);
            this.Controls.Add(this.OkazUslug);
            this.Name = "Form7";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Оказание услуг";
            this.Load += new System.EventHandler(this.Form7_Load);
            this.GroupBoxAddNewClient.ResumeLayout(false);
            this.GroupBoxAddNewClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OkazUslug)).EndInit();
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
        private System.Windows.Forms.DataGridView OkazUslug;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Usluga;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}