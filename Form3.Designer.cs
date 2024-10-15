namespace Уп
{
    partial class Form3
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
            this.Clients = new System.Windows.Forms.DataGridView();
            this.Poisk = new System.Windows.Forms.Label();
            this.textBoxPoisk = new System.Windows.Forms.TextBox();
            this.GroupBoxAddNewClient = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.Usluga = new System.Windows.Forms.Label();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.Pasport = new System.Windows.Forms.Label();
            this.textBoxAdres = new System.Windows.Forms.TextBox();
            this.Adres = new System.Windows.Forms.Label();
            this.textBoxTel = new System.Windows.Forms.TextBox();
            this.Tel = new System.Windows.Forms.Label();
            this.textBoxFIO = new System.Windows.Forms.TextBox();
            this.labelFIO = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonVivod = new System.Windows.Forms.Button();
            this.buttonExel = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonIzmen = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Clients)).BeginInit();
            this.GroupBoxAddNewClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // Clients
            // 
            this.Clients.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Clients.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.Clients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Clients.Location = new System.Drawing.Point(12, 41);
            this.Clients.Name = "Clients";
            this.Clients.RowHeadersWidth = 51;
            this.Clients.RowTemplate.Height = 24;
            this.Clients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Clients.Size = new System.Drawing.Size(878, 414);
            this.Clients.TabIndex = 0;
            this.Clients.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Clients_CellClick);
            // 
            // Poisk
            // 
            this.Poisk.AutoSize = true;
            this.Poisk.Location = new System.Drawing.Point(12, 16);
            this.Poisk.Name = "Poisk";
            this.Poisk.Size = new System.Drawing.Size(100, 16);
            this.Poisk.TabIndex = 2;
            this.Poisk.Text = "Поиск по ФИО";
            // 
            // textBoxPoisk
            // 
            this.textBoxPoisk.Location = new System.Drawing.Point(130, 13);
            this.textBoxPoisk.Name = "textBoxPoisk";
            this.textBoxPoisk.Size = new System.Drawing.Size(679, 22);
            this.textBoxPoisk.TabIndex = 3;
            this.textBoxPoisk.TextChanged += new System.EventHandler(this.textBoxPoisk_TextChanged);
            // 
            // GroupBoxAddNewClient
            // 
            this.GroupBoxAddNewClient.Controls.Add(this.comboBox1);
            this.GroupBoxAddNewClient.Controls.Add(this.ButtonAdd);
            this.GroupBoxAddNewClient.Controls.Add(this.Usluga);
            this.GroupBoxAddNewClient.Controls.Add(this.textBoxPass);
            this.GroupBoxAddNewClient.Controls.Add(this.Pasport);
            this.GroupBoxAddNewClient.Controls.Add(this.textBoxAdres);
            this.GroupBoxAddNewClient.Controls.Add(this.Adres);
            this.GroupBoxAddNewClient.Controls.Add(this.textBoxTel);
            this.GroupBoxAddNewClient.Controls.Add(this.Tel);
            this.GroupBoxAddNewClient.Controls.Add(this.textBoxFIO);
            this.GroupBoxAddNewClient.Controls.Add(this.labelFIO);
            this.GroupBoxAddNewClient.Location = new System.Drawing.Point(896, 41);
            this.GroupBoxAddNewClient.Name = "GroupBoxAddNewClient";
            this.GroupBoxAddNewClient.Size = new System.Drawing.Size(419, 414);
            this.GroupBoxAddNewClient.TabIndex = 4;
            this.GroupBoxAddNewClient.TabStop = false;
            this.GroupBoxAddNewClient.Text = "Добавить нового клиента";
            this.GroupBoxAddNewClient.Enter += new System.EventHandler(this.GroupBoxAddNewClient_Enter);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(108, 160);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(294, 24);
            this.comboBox1.TabIndex = 13;
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.BackColor = System.Drawing.Color.Azure;
            this.ButtonAdd.Location = new System.Drawing.Point(19, 267);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(160, 50);
            this.ButtonAdd.TabIndex = 0;
            this.ButtonAdd.Text = "Добавить клиента";
            this.ButtonAdd.UseVisualStyleBackColor = false;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // Usluga
            // 
            this.Usluga.Location = new System.Drawing.Point(16, 150);
            this.Usluga.Name = "Usluga";
            this.Usluga.Size = new System.Drawing.Size(100, 34);
            this.Usluga.TabIndex = 11;
            this.Usluga.Text = "Заказанная услуга";
            // 
            // textBoxPass
            // 
            this.textBoxPass.Location = new System.Drawing.Point(108, 204);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(100, 22);
            this.textBoxPass.TabIndex = 10;
            this.textBoxPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPass_KeyPress);
            // 
            // Pasport
            // 
            this.Pasport.Location = new System.Drawing.Point(16, 213);
            this.Pasport.Name = "Pasport";
            this.Pasport.Size = new System.Drawing.Size(65, 13);
            this.Pasport.TabIndex = 9;
            this.Pasport.Text = "Паспорт";
            // 
            // textBoxAdres
            // 
            this.textBoxAdres.Location = new System.Drawing.Point(108, 100);
            this.textBoxAdres.Name = "textBoxAdres";
            this.textBoxAdres.Size = new System.Drawing.Size(294, 22);
            this.textBoxAdres.TabIndex = 8;
            // 
            // Adres
            // 
            this.Adres.Location = new System.Drawing.Point(16, 100);
            this.Adres.Name = "Adres";
            this.Adres.Size = new System.Drawing.Size(91, 41);
            this.Adres.TabIndex = 7;
            this.Adres.Text = "Адрес проживания";
            // 
            // textBoxTel
            // 
            this.textBoxTel.Location = new System.Drawing.Point(108, 63);
            this.textBoxTel.Name = "textBoxTel";
            this.textBoxTel.Size = new System.Drawing.Size(294, 22);
            this.textBoxTel.TabIndex = 6;
            this.textBoxTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTel_KeyPress);
            // 
            // Tel
            // 
            this.Tel.Location = new System.Drawing.Point(16, 65);
            this.Tel.Name = "Tel";
            this.Tel.Size = new System.Drawing.Size(70, 20);
            this.Tel.TabIndex = 5;
            this.Tel.Text = "Телефон";
            // 
            // textBoxFIO
            // 
            this.textBoxFIO.Location = new System.Drawing.Point(108, 26);
            this.textBoxFIO.Name = "textBoxFIO";
            this.textBoxFIO.Size = new System.Drawing.Size(294, 22);
            this.textBoxFIO.TabIndex = 4;
            this.textBoxFIO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFIO_KeyPress);
            // 
            // labelFIO
            // 
            this.labelFIO.Location = new System.Drawing.Point(16, 25);
            this.labelFIO.Name = "labelFIO";
            this.labelFIO.Size = new System.Drawing.Size(60, 13);
            this.labelFIO.TabIndex = 0;
            this.labelFIO.Text = "ФИО";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Coral;
            this.button1.Location = new System.Drawing.Point(1140, 465);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 55);
            this.button1.TabIndex = 9;
            this.button1.Text = "Вернуться обратно";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonVivod
            // 
            this.buttonVivod.BackColor = System.Drawing.Color.Azure;
            this.buttonVivod.Location = new System.Drawing.Point(495, 470);
            this.buttonVivod.Margin = new System.Windows.Forms.Padding(4);
            this.buttonVivod.Name = "buttonVivod";
            this.buttonVivod.Size = new System.Drawing.Size(165, 45);
            this.buttonVivod.TabIndex = 10;
            this.buttonVivod.Text = "Вывод таблицы";
            this.buttonVivod.UseVisualStyleBackColor = false;
            this.buttonVivod.Click += new System.EventHandler(this.buttonVivod_Click);
            // 
            // buttonExel
            // 
            this.buttonExel.BackColor = System.Drawing.Color.Azure;
            this.buttonExel.Enabled = false;
            this.buttonExel.Location = new System.Drawing.Point(725, 470);
            this.buttonExel.Name = "buttonExel";
            this.buttonExel.Size = new System.Drawing.Size(165, 45);
            this.buttonExel.TabIndex = 13;
            this.buttonExel.Text = "Вывод на печать";
            this.buttonExel.UseVisualStyleBackColor = false;
            this.buttonExel.Click += new System.EventHandler(this.buttonExel_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Azure;
            this.buttonDelete.Location = new System.Drawing.Point(260, 470);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(165, 45);
            this.buttonDelete.TabIndex = 11;
            this.buttonDelete.Text = "Удалить запись";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonIzmen
            // 
            this.buttonIzmen.BackColor = System.Drawing.Color.Azure;
            this.buttonIzmen.Location = new System.Drawing.Point(13, 470);
            this.buttonIzmen.Margin = new System.Windows.Forms.Padding(4);
            this.buttonIzmen.Name = "buttonIzmen";
            this.buttonIzmen.Size = new System.Drawing.Size(165, 45);
            this.buttonIzmen.TabIndex = 12;
            this.buttonIzmen.Text = "Изменить запись";
            this.buttonIzmen.UseVisualStyleBackColor = false;
            this.buttonIzmen.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Azure;
            this.button6.Location = new System.Drawing.Point(815, 12);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 14;
            this.button6.Text = "Поиск";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1327, 538);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.buttonExel);
            this.Controls.Add(this.buttonIzmen);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonVivod);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GroupBoxAddNewClient);
            this.Controls.Add(this.textBoxPoisk);
            this.Controls.Add(this.Poisk);
            this.Controls.Add(this.Clients);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Клиенты";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Clients)).EndInit();
            this.GroupBoxAddNewClient.ResumeLayout(false);
            this.GroupBoxAddNewClient.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Clients;
        private System.Windows.Forms.Label Poisk;
        private System.Windows.Forms.TextBox textBoxPoisk;
        private System.Windows.Forms.GroupBox GroupBoxAddNewClient;
        private System.Windows.Forms.Label labelFIO;
        private System.Windows.Forms.TextBox textBoxFIO;
        private System.Windows.Forms.Label Tel;
        private System.Windows.Forms.TextBox textBoxTel;
        private System.Windows.Forms.TextBox textBoxAdres;
        private System.Windows.Forms.Label Adres;
        private System.Windows.Forms.Label Usluga;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.Label Pasport;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonVivod;
        private System.Windows.Forms.Button buttonExel;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonIzmen;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button6;
    }
}