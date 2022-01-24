namespace diploma
{
    partial class Form_registration
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
            this.label_logo_registration = new System.Windows.Forms.Label();
            this.groupBox_usr_date_of_birth = new System.Windows.Forms.GroupBox();
            this.button_usr_registration = new System.Windows.Forms.Button();
            this.pictureBox_capcha = new System.Windows.Forms.PictureBox();
            this.textBox_capcha = new System.Windows.Forms.TextBox();
            this.button_capcha_update = new System.Windows.Forms.Button();
            this._focus = new System.Windows.Forms.Button();
            this.cueTextBoxpBox_usr_date_of_birth_yyyy = new CueTextBox();
            this.cueTextBoxpBox_usr_date_of_birth_mm = new CueTextBox();
            this.cueTextBoxpBox_usr_date_of_birth_dd = new CueTextBox();
            this.cueTextBox_usr_middle_name = new CueTextBox();
            this.cueTextBox_usr_password_again = new CueTextBox();
            this.cueTextBox_usr_phone = new CueTextBox();
            this.cueTextBox_usr_surname = new CueTextBox();
            this.cueTextBox_usr_password = new CueTextBox();
            this.cueTextBox_usr_email = new CueTextBox();
            this.cueTextBox_usr_login = new CueTextBox();
            this.cueTextBox_usr_name = new CueTextBox();
            this.groupBox_usr_date_of_birth.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_capcha)).BeginInit();
            this.SuspendLayout();
            // 
            // label_logo_registration
            // 
            this.label_logo_registration.AutoSize = true;
            this.label_logo_registration.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_logo_registration.Location = new System.Drawing.Point(97, 20);
            this.label_logo_registration.Name = "label_logo_registration";
            this.label_logo_registration.Size = new System.Drawing.Size(138, 25);
            this.label_logo_registration.TabIndex = 7;
            this.label_logo_registration.Text = "Регистрация";
            // 
            // groupBox_usr_date_of_birth
            // 
            this.groupBox_usr_date_of_birth.Controls.Add(this.cueTextBoxpBox_usr_date_of_birth_yyyy);
            this.groupBox_usr_date_of_birth.Controls.Add(this.cueTextBoxpBox_usr_date_of_birth_mm);
            this.groupBox_usr_date_of_birth.Controls.Add(this.cueTextBoxpBox_usr_date_of_birth_dd);
            this.groupBox_usr_date_of_birth.Enabled = false;
            this.groupBox_usr_date_of_birth.Location = new System.Drawing.Point(177, 86);
            this.groupBox_usr_date_of_birth.Name = "groupBox_usr_date_of_birth";
            this.groupBox_usr_date_of_birth.Size = new System.Drawing.Size(147, 46);
            this.groupBox_usr_date_of_birth.TabIndex = 24;
            this.groupBox_usr_date_of_birth.TabStop = false;
            this.groupBox_usr_date_of_birth.Text = "Дата рождения";
            // 
            // button_usr_registration
            // 
            this.button_usr_registration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_usr_registration.Font = new System.Drawing.Font("Sitka Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_usr_registration.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button_usr_registration.Location = new System.Drawing.Point(79, 257);
            this.button_usr_registration.Name = "button_usr_registration";
            this.button_usr_registration.Size = new System.Drawing.Size(181, 31);
            this.button_usr_registration.TabIndex = 25;
            this.button_usr_registration.Text = "Зарегистрироваться";
            this.button_usr_registration.UseVisualStyleBackColor = true;
            this.button_usr_registration.Click += new System.EventHandler(this.button_usr_registration_Click);
            // 
            // pictureBox_capcha
            // 
            this.pictureBox_capcha.Location = new System.Drawing.Point(12, 190);
            this.pictureBox_capcha.Name = "pictureBox_capcha";
            this.pictureBox_capcha.Size = new System.Drawing.Size(169, 63);
            this.pictureBox_capcha.TabIndex = 26;
            this.pictureBox_capcha.TabStop = false;
            // 
            // textBox_capcha
            // 
            this.textBox_capcha.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_capcha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_capcha.Font = new System.Drawing.Font("Sitka Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_capcha.Location = new System.Drawing.Point(187, 190);
            this.textBox_capcha.MaxLength = 5;
            this.textBox_capcha.Name = "textBox_capcha";
            this.textBox_capcha.ShortcutsEnabled = false;
            this.textBox_capcha.Size = new System.Drawing.Size(138, 34);
            this.textBox_capcha.TabIndex = 27;
            this.textBox_capcha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_capcha.WordWrap = false;
            // 
            // button_capcha_update
            // 
            this.button_capcha_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_capcha_update.Font = new System.Drawing.Font("Sitka Text", 8F);
            this.button_capcha_update.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button_capcha_update.Location = new System.Drawing.Point(187, 228);
            this.button_capcha_update.Name = "button_capcha_update";
            this.button_capcha_update.Size = new System.Drawing.Size(138, 25);
            this.button_capcha_update.TabIndex = 28;
            this.button_capcha_update.Text = "Не вижу";
            this.button_capcha_update.UseVisualStyleBackColor = true;
            this.button_capcha_update.Click += new System.EventHandler(this.button_capcha_update_Click);
            // 
            // _focus
            // 
            this._focus.Location = new System.Drawing.Point(222, 146);
            this._focus.Name = "_focus";
            this._focus.Size = new System.Drawing.Size(2, 2);
            this._focus.TabIndex = 34;
            this._focus.Text = "button1";
            this._focus.UseVisualStyleBackColor = true;
            // 
            // cueTextBoxpBox_usr_date_of_birth_yyyy
            // 
            this.cueTextBoxpBox_usr_date_of_birth_yyyy.Cue = "YYYY";
            this.cueTextBoxpBox_usr_date_of_birth_yyyy.Location = new System.Drawing.Point(85, 19);
            this.cueTextBoxpBox_usr_date_of_birth_yyyy.Name = "cueTextBoxpBox_usr_date_of_birth_yyyy";
            this.cueTextBoxpBox_usr_date_of_birth_yyyy.Size = new System.Drawing.Size(57, 20);
            this.cueTextBoxpBox_usr_date_of_birth_yyyy.TabIndex = 2;
            // 
            // cueTextBoxpBox_usr_date_of_birth_mm
            // 
            this.cueTextBoxpBox_usr_date_of_birth_mm.Cue = "MM";
            this.cueTextBoxpBox_usr_date_of_birth_mm.Location = new System.Drawing.Point(45, 19);
            this.cueTextBoxpBox_usr_date_of_birth_mm.Name = "cueTextBoxpBox_usr_date_of_birth_mm";
            this.cueTextBoxpBox_usr_date_of_birth_mm.Size = new System.Drawing.Size(34, 20);
            this.cueTextBoxpBox_usr_date_of_birth_mm.TabIndex = 1;
            // 
            // cueTextBoxpBox_usr_date_of_birth_dd
            // 
            this.cueTextBoxpBox_usr_date_of_birth_dd.Cue = "DD";
            this.cueTextBoxpBox_usr_date_of_birth_dd.Location = new System.Drawing.Point(5, 19);
            this.cueTextBoxpBox_usr_date_of_birth_dd.Name = "cueTextBoxpBox_usr_date_of_birth_dd";
            this.cueTextBoxpBox_usr_date_of_birth_dd.Size = new System.Drawing.Size(34, 20);
            this.cueTextBoxpBox_usr_date_of_birth_dd.TabIndex = 0;
            // 
            // cueTextBox_usr_middle_name
            // 
            this.cueTextBox_usr_middle_name.Cue = "Отчество";
            this.cueTextBox_usr_middle_name.Location = new System.Drawing.Point(12, 86);
            this.cueTextBox_usr_middle_name.Name = "cueTextBox_usr_middle_name";
            this.cueTextBox_usr_middle_name.Size = new System.Drawing.Size(148, 20);
            this.cueTextBox_usr_middle_name.TabIndex = 23;
            // 
            // cueTextBox_usr_password_again
            // 
            this.cueTextBox_usr_password_again.Cue = "Пароль (еще раз)";
            this.cueTextBox_usr_password_again.Location = new System.Drawing.Point(177, 164);
            this.cueTextBox_usr_password_again.Name = "cueTextBox_usr_password_again";
            this.cueTextBox_usr_password_again.Size = new System.Drawing.Size(148, 20);
            this.cueTextBox_usr_password_again.TabIndex = 22;
            // 
            // cueTextBox_usr_phone
            // 
            this.cueTextBox_usr_phone.Cue = "Телефон";
            this.cueTextBox_usr_phone.Location = new System.Drawing.Point(177, 138);
            this.cueTextBox_usr_phone.Name = "cueTextBox_usr_phone";
            this.cueTextBox_usr_phone.Size = new System.Drawing.Size(148, 20);
            this.cueTextBox_usr_phone.TabIndex = 21;
            // 
            // cueTextBox_usr_surname
            // 
            this.cueTextBox_usr_surname.Cue = "Фамилия";
            this.cueTextBox_usr_surname.Location = new System.Drawing.Point(177, 60);
            this.cueTextBox_usr_surname.Name = "cueTextBox_usr_surname";
            this.cueTextBox_usr_surname.Size = new System.Drawing.Size(148, 20);
            this.cueTextBox_usr_surname.TabIndex = 20;
            // 
            // cueTextBox_usr_password
            // 
            this.cueTextBox_usr_password.Cue = "Пароль";
            this.cueTextBox_usr_password.Location = new System.Drawing.Point(12, 164);
            this.cueTextBox_usr_password.Name = "cueTextBox_usr_password";
            this.cueTextBox_usr_password.Size = new System.Drawing.Size(148, 20);
            this.cueTextBox_usr_password.TabIndex = 19;
            // 
            // cueTextBox_usr_email
            // 
            this.cueTextBox_usr_email.Cue = "E-Mail";
            this.cueTextBox_usr_email.Location = new System.Drawing.Point(12, 138);
            this.cueTextBox_usr_email.Name = "cueTextBox_usr_email";
            this.cueTextBox_usr_email.Size = new System.Drawing.Size(148, 20);
            this.cueTextBox_usr_email.TabIndex = 18;
            // 
            // cueTextBox_usr_login
            // 
            this.cueTextBox_usr_login.Cue = "Логин";
            this.cueTextBox_usr_login.Location = new System.Drawing.Point(12, 112);
            this.cueTextBox_usr_login.Name = "cueTextBox_usr_login";
            this.cueTextBox_usr_login.Size = new System.Drawing.Size(148, 20);
            this.cueTextBox_usr_login.TabIndex = 17;
            // 
            // cueTextBox_usr_name
            // 
            this.cueTextBox_usr_name.Cue = "Имя";
            this.cueTextBox_usr_name.Location = new System.Drawing.Point(12, 60);
            this.cueTextBox_usr_name.Name = "cueTextBox_usr_name";
            this.cueTextBox_usr_name.Size = new System.Drawing.Size(148, 20);
            this.cueTextBox_usr_name.TabIndex = 16;
            // 
            // Form_registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 294);
            this.Controls.Add(this.button_capcha_update);
            this.Controls.Add(this.textBox_capcha);
            this.Controls.Add(this.pictureBox_capcha);
            this.Controls.Add(this.button_usr_registration);
            this.Controls.Add(this.groupBox_usr_date_of_birth);
            this.Controls.Add(this.cueTextBox_usr_middle_name);
            this.Controls.Add(this.cueTextBox_usr_password_again);
            this.Controls.Add(this.cueTextBox_usr_phone);
            this.Controls.Add(this.cueTextBox_usr_surname);
            this.Controls.Add(this.cueTextBox_usr_password);
            this.Controls.Add(this.cueTextBox_usr_email);
            this.Controls.Add(this.cueTextBox_usr_login);
            this.Controls.Add(this.cueTextBox_usr_name);
            this.Controls.Add(this.label_logo_registration);
            this.Controls.Add(this._focus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_registration";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация";
            this.Load += new System.EventHandler(this.Form_registration_Load);
            this.groupBox_usr_date_of_birth.ResumeLayout(false);
            this.groupBox_usr_date_of_birth.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_capcha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_logo_registration;
        private CueTextBox cueTextBox_usr_name;
        private CueTextBox cueTextBox_usr_login;
        private CueTextBox cueTextBox_usr_email;
        private CueTextBox cueTextBox_usr_password;
        private CueTextBox cueTextBox_usr_surname;
        private CueTextBox cueTextBox_usr_phone;
        private CueTextBox cueTextBox_usr_password_again;
        private CueTextBox cueTextBox_usr_middle_name;
        private System.Windows.Forms.GroupBox groupBox_usr_date_of_birth;
        private CueTextBox cueTextBoxpBox_usr_date_of_birth_yyyy;
        private CueTextBox cueTextBoxpBox_usr_date_of_birth_mm;
        private CueTextBox cueTextBoxpBox_usr_date_of_birth_dd;
        private System.Windows.Forms.Button button_usr_registration;
        private System.Windows.Forms.PictureBox pictureBox_capcha;
        private System.Windows.Forms.TextBox textBox_capcha;
        private System.Windows.Forms.Button button_capcha_update;
        private System.Windows.Forms.Button _focus;
    }
}