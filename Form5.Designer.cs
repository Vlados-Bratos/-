namespace Уп
{
    partial class Form5
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.Pasport = new System.Windows.Forms.Label();
            this.textBoxAdres = new System.Windows.Forms.TextBox();
            this.Adres = new System.Windows.Forms.Label();
            this.textBoxTel = new System.Windows.Forms.TextBox();
            this.Tel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.Usluga = new System.Windows.Forms.Label();
            this.textBoxFIO = new System.Windows.Forms.TextBox();
            this.labelFIO = new System.Windows.Forms.Label();
            this.textBoxPoisk = new System.Windows.Forms.TextBox();
            this.Poisk = new System.Windows.Forms.Label();
            this.Sotrudniki = new System.Windows.Forms.DataGridView();
            this.GroupBoxAddNewClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Sotrudniki)).BeginInit();
            this.SuspendLayout();
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Azure;
            this.button6.Location = new System.Drawing.Point(815, 7);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 24;
            this.button6.Text = "Поиск";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // buttonExel
            // 
            this.buttonExel.BackColor = System.Drawing.Color.Azure;
            this.buttonExel.Enabled = false;
            this.buttonExel.Location = new System.Drawing.Point(725, 465);
            this.buttonExel.Name = "buttonExel";
            this.buttonExel.Size = new System.Drawing.Size(165, 45);
            this.buttonExel.TabIndex = 23;
            this.buttonExel.Text = "Вывод на печать";
            this.buttonExel.UseVisualStyleBackColor = false;
            this.buttonExel.Click += new System.EventHandler(this.buttonExel_Click);
            // 
            // buttonIzmen
            // 
            this.buttonIzmen.BackColor = System.Drawing.Color.Azure;
            this.buttonIzmen.Location = new System.Drawing.Point(13, 465);
            this.buttonIzmen.Margin = new System.Windows.Forms.Padding(4);
            this.buttonIzmen.Name = "buttonIzmen";
            this.buttonIzmen.Size = new System.Drawing.Size(165, 45);
            this.buttonIzmen.TabIndex = 22;
            this.buttonIzmen.Text = "Изменить запись";
            this.buttonIzmen.UseVisualStyleBackColor = false;
            this.buttonIzmen.Click += new System.EventHandler(this.buttonIzmen_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Azure;
            this.buttonDelete.Location = new System.Drawing.Point(260, 465);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(165, 45);
            this.buttonDelete.TabIndex = 21;
            this.buttonDelete.Text = "Удалить запись";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonVivod
            // 
            this.buttonVivod.BackColor = System.Drawing.Color.Azure;
            this.buttonVivod.Location = new System.Drawing.Point(495, 465);
            this.buttonVivod.Margin = new System.Windows.Forms.Padding(4);
            this.buttonVivod.Name = "buttonVivod";
            this.buttonVivod.Size = new System.Drawing.Size(165, 45);
            this.buttonVivod.TabIndex = 20;
            this.buttonVivod.Text = "Вывод таблицы";
            this.buttonVivod.UseVisualStyleBackColor = false;
            this.buttonVivod.Click += new System.EventHandler(this.buttonVivod_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Coral;
            this.button1.Location = new System.Drawing.Point(1140, 460);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 55);
            this.button1.TabIndex = 19;
            this.button1.Text = "Вернуться обратно";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GroupBoxAddNewClient
            // 
            this.GroupBoxAddNewClient.Controls.Add(this.label2);
            this.GroupBoxAddNewClient.Controls.Add(this.label1);
            this.GroupBoxAddNewClient.Controls.Add(this.textBoxPass);
            this.GroupBoxAddNewClient.Controls.Add(this.Pasport);
            this.GroupBoxAddNewClient.Controls.Add(this.textBoxAdres);
            this.GroupBoxAddNewClient.Controls.Add(this.Adres);
            this.GroupBoxAddNewClient.Controls.Add(this.textBoxTel);
            this.GroupBoxAddNewClient.Controls.Add(this.Tel);
            this.GroupBoxAddNewClient.Controls.Add(this.comboBox1);
            this.GroupBoxAddNewClient.Controls.Add(this.ButtonAdd);
            this.GroupBoxAddNewClient.Controls.Add(this.Usluga);
            this.GroupBoxAddNewClient.Controls.Add(this.textBoxFIO);
            this.GroupBoxAddNewClient.Controls.Add(this.labelFIO);
            this.GroupBoxAddNewClient.Location = new System.Drawing.Point(896, 36);
            this.GroupBoxAddNewClient.Name = "GroupBoxAddNewClient";
            this.GroupBoxAddNewClient.Size = new System.Drawing.Size(419, 414);
            this.GroupBoxAddNewClient.TabIndex = 18;
            this.GroupBoxAddNewClient.TabStop = false;
            this.GroupBoxAddNewClient.Text = "Добавить нового клиента";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(11, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 50);
            this.label1.TabIndex = 20;
            this.label1.Text = "Паспорт";
            // 
            // textBoxPass
            // 
            this.textBoxPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPass.Location = new System.Drawing.Point(117, 194);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(100, 24);
            this.textBoxPass.TabIndex = 19;
            this.textBoxPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPass_KeyPress);
            // 
            // Pasport
            // 
            this.Pasport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Pasport.Location = new System.Drawing.Point(16, 221);
            this.Pasport.Name = "Pasport";
            this.Pasport.Size = new System.Drawing.Size(75, 23);
            this.Pasport.TabIndex = 18;
            this.Pasport.Text = "Паспорт";
            // 
            // textBoxAdres
            // 
            this.textBoxAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAdres.Location = new System.Drawing.Point(117, 98);
            this.textBoxAdres.Name = "textBoxAdres";
            this.textBoxAdres.Size = new System.Drawing.Size(294, 24);
            this.textBoxAdres.TabIndex = 17;
            this.textBoxAdres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAdres_KeyPress);
            // 
            // Adres
            // 
            this.Adres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Adres.Location = new System.Drawing.Point(7, 134);
            this.Adres.Name = "Adres";
            this.Adres.Size = new System.Drawing.Size(100, 41);
            this.Adres.TabIndex = 16;
            this.Adres.Text = "Адрес проживания";
            // 
            // textBoxTel
            // 
            this.textBoxTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTel.Location = new System.Drawing.Point(117, 151);
            this.textBoxTel.Name = "textBoxTel";
            this.textBoxTel.Size = new System.Drawing.Size(294, 24);
            this.textBoxTel.TabIndex = 15;
            // 
            // Tel
            // 
            this.Tel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Tel.Location = new System.Drawing.Point(7, 102);
            this.Tel.Name = "Tel";
            this.Tel.Size = new System.Drawing.Size(75, 20);
            this.Tel.TabIndex = 14;
            this.Tel.Text = "Телефон";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(117, 60);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(294, 24);
            this.comboBox1.TabIndex = 13;
            this.comboBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox1_KeyPress);
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.BackColor = System.Drawing.Color.Azure;
            this.ButtonAdd.Location = new System.Drawing.Point(6, 358);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(160, 50);
            this.ButtonAdd.TabIndex = 0;
            this.ButtonAdd.Text = "Добавить Сотрудника";
            this.ButtonAdd.UseVisualStyleBackColor = false;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // Usluga
            // 
            this.Usluga.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Usluga.Location = new System.Drawing.Point(6, 65);
            this.Usluga.Name = "Usluga";
            this.Usluga.Size = new System.Drawing.Size(105, 24);
            this.Usluga.TabIndex = 11;
            this.Usluga.Text = "Должность";
            // 
            // textBoxFIO
            // 
            this.textBoxFIO.Location = new System.Drawing.Point(117, 25);
            this.textBoxFIO.Name = "textBoxFIO";
            this.textBoxFIO.Size = new System.Drawing.Size(294, 22);
            this.textBoxFIO.TabIndex = 4;
            this.textBoxFIO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFIO_KeyPress);
            // 
            // labelFIO
            // 
            this.labelFIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFIO.Location = new System.Drawing.Point(6, 25);
            this.labelFIO.Name = "labelFIO";
            this.labelFIO.Size = new System.Drawing.Size(60, 22);
            this.labelFIO.TabIndex = 0;
            this.labelFIO.Text = "ФИО";
            // 
            // textBoxPoisk
            // 
            this.textBoxPoisk.Location = new System.Drawing.Point(117, 7);
            this.textBoxPoisk.Name = "textBoxPoisk";
            this.textBoxPoisk.Size = new System.Drawing.Size(692, 22);
            this.textBoxPoisk.TabIndex = 17;
            // 
            // Poisk
            // 
            this.Poisk.AutoSize = true;
            this.Poisk.Location = new System.Drawing.Point(12, 10);
            this.Poisk.Name = "Poisk";
            this.Poisk.Size = new System.Drawing.Size(100, 16);
            this.Poisk.TabIndex = 16;
            this.Poisk.Text = "Поиск по ФИО";
            // 
            // Sotrudniki
            // 
            this.Sotrudniki.BackgroundColor = System.Drawing.Color.White;
            this.Sotrudniki.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.Sotrudniki.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Sotrudniki.Location = new System.Drawing.Point(12, 36);
            this.Sotrudniki.Name = "Sotrudniki";
            this.Sotrudniki.RowHeadersWidth = 51;
            this.Sotrudniki.RowTemplate.Height = 24;
            this.Sotrudniki.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Sotrudniki.Size = new System.Drawing.Size(878, 414);
            this.Sotrudniki.TabIndex = 15;
            this.Sotrudniki.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Sotrudniki_CellClick);
            // 
            // Form5
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
            this.Controls.Add(this.Sotrudniki);
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Данные сотрудников";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.GroupBoxAddNewClient.ResumeLayout(false);
            this.GroupBoxAddNewClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Sotrudniki)).EndInit();
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Label Usluga;
        private System.Windows.Forms.TextBox textBoxFIO;
        private System.Windows.Forms.Label labelFIO;
        private System.Windows.Forms.TextBox textBoxPoisk;
        private System.Windows.Forms.Label Poisk;
        private System.Windows.Forms.DataGridView Sotrudniki;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.Label Pasport;
        private System.Windows.Forms.TextBox textBoxAdres;
        private System.Windows.Forms.Label Adres;
        private System.Windows.Forms.TextBox textBoxTel;
        private System.Windows.Forms.Label Tel;
        private System.Windows.Forms.Label label2;
    }
}