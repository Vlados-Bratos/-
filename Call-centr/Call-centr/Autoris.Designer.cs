namespace Call_centr
{
    partial class Authoriz
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authoriz));
            this.Login = new System.Windows.Forms.Label();
            this.Passwrd = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Password_Texbox = new System.Windows.Forms.TextBox();
            this.Vhod_button = new System.Windows.Forms.Button();
            this.Close_button = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.Location = new System.Drawing.Point(101, 50);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(54, 21);
            this.Login.TabIndex = 1;
            this.Login.Text = "Логин";
            // 
            // Passwrd
            // 
            this.Passwrd.AutoSize = true;
            this.Passwrd.Location = new System.Drawing.Point(101, 165);
            this.Passwrd.Name = "Passwrd";
            this.Passwrd.Size = new System.Drawing.Size(63, 21);
            this.Passwrd.TabIndex = 2;
            this.Passwrd.Text = "Пароль";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(105, 81);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 29);
            this.textBox1.TabIndex = 3;
            // 
            // Password_Texbox
            // 
            this.Password_Texbox.Location = new System.Drawing.Point(105, 196);
            this.Password_Texbox.Name = "Password_Texbox";
            this.Password_Texbox.Size = new System.Drawing.Size(150, 29);
            this.Password_Texbox.TabIndex = 4;
            // 
            // Vhod_button
            // 
            this.Vhod_button.BackColor = System.Drawing.Color.LightCyan;
            this.Vhod_button.Location = new System.Drawing.Point(25, 280);
            this.Vhod_button.Name = "Vhod_button";
            this.Vhod_button.Size = new System.Drawing.Size(125, 50);
            this.Vhod_button.TabIndex = 5;
            this.Vhod_button.Text = "Вход";
            this.Vhod_button.UseVisualStyleBackColor = false;
            // 
            // Close_button
            // 
            this.Close_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.Close_button.Location = new System.Drawing.Point(180, 280);
            this.Close_button.Name = "Close_button";
            this.Close_button.Size = new System.Drawing.Size(125, 50);
            this.Close_button.TabIndex = 6;
            this.Close_button.Text = "Выход";
            this.Close_button.UseVisualStyleBackColor = false;
            this.Close_button.Click += new System.EventHandler(this.Close_button_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(35, 165);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 60);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Call_centr.Properties.Resources.Login;
            this.pictureBox1.Location = new System.Drawing.Point(35, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Authoriz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(334, 361);
            this.ControlBox = false;
            this.Controls.Add(this.Close_button);
            this.Controls.Add(this.Vhod_button);
            this.Controls.Add(this.Password_Texbox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Passwrd);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(350, 400);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(350, 400);
            this.Name = "Authoriz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label Login;
        private System.Windows.Forms.Label Passwrd;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox Password_Texbox;
        private System.Windows.Forms.Button Vhod_button;
        private System.Windows.Forms.Button Close_button;
    }
}

