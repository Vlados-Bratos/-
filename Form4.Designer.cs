namespace Уп
{
    partial class Form4
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
            this.button2 = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonVivod = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.GroupBoxAddNewClient = new System.Windows.Forms.GroupBox();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.textBoxKolVoSotr = new System.Windows.Forms.TextBox();
            this.Adres = new System.Windows.Forms.Label();
            this.textBoxZP = new System.Windows.Forms.TextBox();
            this.Tel = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelFIO = new System.Windows.Forms.Label();
            this.textBoxPoisk = new System.Windows.Forms.TextBox();
            this.Poisk = new System.Windows.Forms.Label();
            this.Dolg = new System.Windows.Forms.DataGridView();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.GroupBoxAddNewClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dolg)).BeginInit();
            this.SuspendLayout();
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Azure;
            this.button6.Location = new System.Drawing.Point(551, 15);
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
            this.buttonExel.Location = new System.Drawing.Point(632, 311);
            this.buttonExel.Name = "buttonExel";
            this.buttonExel.Size = new System.Drawing.Size(165, 45);
            this.buttonExel.TabIndex = 23;
            this.buttonExel.Text = "Вывод на печать";
            this.buttonExel.UseVisualStyleBackColor = false;
            this.buttonExel.Click += new System.EventHandler(this.buttonExel_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Azure;
            this.button2.Location = new System.Drawing.Point(13, 311);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 45);
            this.button2.TabIndex = 22;
            this.button2.Text = "Изменить запись";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.buttonIzmen_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Azure;
            this.buttonDelete.Location = new System.Drawing.Point(216, 311);
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
            this.buttonVivod.Location = new System.Drawing.Point(415, 311);
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
            this.button1.Location = new System.Drawing.Point(859, 311);
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
            this.GroupBoxAddNewClient.Controls.Add(this.ButtonAdd);
            this.GroupBoxAddNewClient.Controls.Add(this.textBoxKolVoSotr);
            this.GroupBoxAddNewClient.Controls.Add(this.Adres);
            this.GroupBoxAddNewClient.Controls.Add(this.textBoxZP);
            this.GroupBoxAddNewClient.Controls.Add(this.Tel);
            this.GroupBoxAddNewClient.Controls.Add(this.textBoxName);
            this.GroupBoxAddNewClient.Controls.Add(this.labelFIO);
            this.GroupBoxAddNewClient.Location = new System.Drawing.Point(632, 43);
            this.GroupBoxAddNewClient.Name = "GroupBoxAddNewClient";
            this.GroupBoxAddNewClient.Size = new System.Drawing.Size(406, 249);
            this.GroupBoxAddNewClient.TabIndex = 18;
            this.GroupBoxAddNewClient.TabStop = false;
            this.GroupBoxAddNewClient.Text = "Добавить новую должность";
            this.GroupBoxAddNewClient.Enter += new System.EventHandler(this.GroupBoxAddNewClient_Enter);
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.BackColor = System.Drawing.Color.Azure;
            this.ButtonAdd.Location = new System.Drawing.Point(6, 168);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(160, 50);
            this.ButtonAdd.TabIndex = 0;
            this.ButtonAdd.Text = "Добавить должность";
            this.ButtonAdd.UseVisualStyleBackColor = false;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // textBoxKolVoSotr
            // 
            this.textBoxKolVoSotr.Location = new System.Drawing.Point(108, 110);
            this.textBoxKolVoSotr.Name = "textBoxKolVoSotr";
            this.textBoxKolVoSotr.Size = new System.Drawing.Size(294, 22);
            this.textBoxKolVoSotr.TabIndex = 8;
            this.textBoxKolVoSotr.TextChanged += new System.EventHandler(this.textBoxKolVoSotr_TextChanged);
            this.textBoxKolVoSotr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxKolVoSotr_KeyPress);
            // 
            // Adres
            // 
            this.Adres.Location = new System.Drawing.Point(16, 100);
            this.Adres.Name = "Adres";
            this.Adres.Size = new System.Drawing.Size(91, 41);
            this.Adres.TabIndex = 7;
            this.Adres.Text = "Кол-во сотрудников";
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
            this.Tel.Location = new System.Drawing.Point(16, 66);
            this.Tel.Name = "Tel";
            this.Tel.Size = new System.Drawing.Size(86, 20);
            this.Tel.TabIndex = 5;
            this.Tel.Text = "Зарплата";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(108, 26);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(294, 22);
            this.textBoxName.TabIndex = 4;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            this.textBoxName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxName_KeyPress);
            // 
            // labelFIO
            // 
            this.labelFIO.Location = new System.Drawing.Point(16, 25);
            this.labelFIO.Name = "labelFIO";
            this.labelFIO.Size = new System.Drawing.Size(86, 40);
            this.labelFIO.TabIndex = 0;
            this.labelFIO.Text = "Наименование должности";
            // 
            // textBoxPoisk
            // 
            this.textBoxPoisk.Location = new System.Drawing.Point(155, 15);
            this.textBoxPoisk.Name = "textBoxPoisk";
            this.textBoxPoisk.Size = new System.Drawing.Size(385, 22);
            this.textBoxPoisk.TabIndex = 17;
            this.textBoxPoisk.TextChanged += new System.EventHandler(this.textBoxPoisk_TextChanged);
            // 
            // Poisk
            // 
            this.Poisk.AutoSize = true;
            this.Poisk.Location = new System.Drawing.Point(12, 18);
            this.Poisk.Name = "Poisk";
            this.Poisk.Size = new System.Drawing.Size(137, 16);
            this.Poisk.TabIndex = 16;
            this.Poisk.Text = "Поиск по Названию";
            this.Poisk.Click += new System.EventHandler(this.Poisk_Click);
            // 
            // Dolg
            // 
            this.Dolg.BackgroundColor = System.Drawing.Color.White;
            this.Dolg.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.Dolg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dolg.Location = new System.Drawing.Point(12, 44);
            this.Dolg.Name = "Dolg";
            this.Dolg.RowHeadersWidth = 51;
            this.Dolg.RowTemplate.Height = 24;
            this.Dolg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dolg.Size = new System.Drawing.Size(614, 248);
            this.Dolg.TabIndex = 15;
            this.Dolg.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dolg_CellClick);
            this.Dolg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Doljnosti_CellContentClick);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1059, 394);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.buttonExel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonVivod);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GroupBoxAddNewClient);
            this.Controls.Add(this.textBoxPoisk);
            this.Controls.Add(this.Poisk);
            this.Controls.Add(this.Dolg);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Должности";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.GroupBoxAddNewClient.ResumeLayout(false);
            this.GroupBoxAddNewClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dolg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button buttonExel;
        private System.Windows.Forms.Button button2;
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
        private System.Windows.Forms.DataGridView Dolg;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}