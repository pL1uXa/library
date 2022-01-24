namespace diploma
{
    partial class Form_user_create
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
            this.panel_users_create = new System.Windows.Forms.Panel();
            this.cueTextBox_create_phone = new CueTextBox();
            this.cueTextBox_create_new_pass_2 = new CueTextBox();
            this.cueTextBox_create_email = new CueTextBox();
            this.cueTextBox_create_new_pass = new CueTextBox();
            this.cueTextBox_create_fio = new CueTextBox();
            this.cueTextBox_create_login = new CueTextBox();
            this.cueTextBox_create_library_card = new CueTextBox();
            this.button_users_create = new System.Windows.Forms.Button();
            this._focus = new System.Windows.Forms.Button();
            this.panel_users_create.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_users_create
            // 
            this.panel_users_create.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_users_create.Controls.Add(this.cueTextBox_create_phone);
            this.panel_users_create.Controls.Add(this.cueTextBox_create_new_pass_2);
            this.panel_users_create.Controls.Add(this.cueTextBox_create_email);
            this.panel_users_create.Controls.Add(this.cueTextBox_create_new_pass);
            this.panel_users_create.Controls.Add(this.cueTextBox_create_fio);
            this.panel_users_create.Controls.Add(this.cueTextBox_create_login);
            this.panel_users_create.Controls.Add(this.cueTextBox_create_library_card);
            this.panel_users_create.Controls.Add(this.button_users_create);
            this.panel_users_create.Controls.Add(this._focus);
            this.panel_users_create.Location = new System.Drawing.Point(-1, -1);
            this.panel_users_create.Name = "panel_users_create";
            this.panel_users_create.Size = new System.Drawing.Size(263, 212);
            this.panel_users_create.TabIndex = 33;
            // 
            // cueTextBox_create_phone
            // 
            this.cueTextBox_create_phone.Cue = "Телефон";
            this.cueTextBox_create_phone.Location = new System.Drawing.Point(6, 84);
            this.cueTextBox_create_phone.Name = "cueTextBox_create_phone";
            this.cueTextBox_create_phone.Size = new System.Drawing.Size(248, 20);
            this.cueTextBox_create_phone.TabIndex = 40;
            // 
            // cueTextBox_create_new_pass_2
            // 
            this.cueTextBox_create_new_pass_2.Cue = "Введите пароль (еще раз)";
            this.cueTextBox_create_new_pass_2.Location = new System.Drawing.Point(6, 146);
            this.cueTextBox_create_new_pass_2.Name = "cueTextBox_create_new_pass_2";
            this.cueTextBox_create_new_pass_2.Size = new System.Drawing.Size(248, 20);
            this.cueTextBox_create_new_pass_2.TabIndex = 1;
            this.cueTextBox_create_new_pass_2.UseSystemPasswordChar = true;
            // 
            // cueTextBox_create_email
            // 
            this.cueTextBox_create_email.Cue = "E-Mail";
            this.cueTextBox_create_email.Location = new System.Drawing.Point(6, 58);
            this.cueTextBox_create_email.Name = "cueTextBox_create_email";
            this.cueTextBox_create_email.Size = new System.Drawing.Size(248, 20);
            this.cueTextBox_create_email.TabIndex = 39;
            // 
            // cueTextBox_create_new_pass
            // 
            this.cueTextBox_create_new_pass.Cue = "Введите пароль";
            this.cueTextBox_create_new_pass.Location = new System.Drawing.Point(6, 120);
            this.cueTextBox_create_new_pass.Name = "cueTextBox_create_new_pass";
            this.cueTextBox_create_new_pass.Size = new System.Drawing.Size(248, 20);
            this.cueTextBox_create_new_pass.TabIndex = 0;
            this.cueTextBox_create_new_pass.UseSystemPasswordChar = true;
            // 
            // cueTextBox_create_fio
            // 
            this.cueTextBox_create_fio.Cue = "ФИО";
            this.cueTextBox_create_fio.Location = new System.Drawing.Point(6, 32);
            this.cueTextBox_create_fio.Name = "cueTextBox_create_fio";
            this.cueTextBox_create_fio.Size = new System.Drawing.Size(248, 20);
            this.cueTextBox_create_fio.TabIndex = 38;
            // 
            // cueTextBox_create_login
            // 
            this.cueTextBox_create_login.Cue = "Логин";
            this.cueTextBox_create_login.Location = new System.Drawing.Point(133, 6);
            this.cueTextBox_create_login.Name = "cueTextBox_create_login";
            this.cueTextBox_create_login.Size = new System.Drawing.Size(121, 20);
            this.cueTextBox_create_login.TabIndex = 37;
            // 
            // cueTextBox_create_library_card
            // 
            this.cueTextBox_create_library_card.Cue = "Номер билета";
            this.cueTextBox_create_library_card.Location = new System.Drawing.Point(6, 6);
            this.cueTextBox_create_library_card.Name = "cueTextBox_create_library_card";
            this.cueTextBox_create_library_card.Size = new System.Drawing.Size(121, 20);
            this.cueTextBox_create_library_card.TabIndex = 36;
            // 
            // button_users_create
            // 
            this.button_users_create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_users_create.Font = new System.Drawing.Font("Sitka Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_users_create.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button_users_create.Location = new System.Drawing.Point(148, 172);
            this.button_users_create.Name = "button_users_create";
            this.button_users_create.Size = new System.Drawing.Size(106, 31);
            this.button_users_create.TabIndex = 24;
            this.button_users_create.Text = "Создать";
            this.button_users_create.UseVisualStyleBackColor = true;
            this.button_users_create.Click += new System.EventHandler(this.button_users_create_Click);
            // 
            // _focus
            // 
            this._focus.Location = new System.Drawing.Point(129, 104);
            this._focus.Name = "_focus";
            this._focus.Size = new System.Drawing.Size(2, 2);
            this._focus.TabIndex = 41;
            this._focus.Text = "button1";
            this._focus.UseVisualStyleBackColor = true;
            // 
            // Form_user_create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 210);
            this.Controls.Add(this.panel_users_create);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_user_create";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Создание пользователя";
            this.panel_users_create.ResumeLayout(false);
            this.panel_users_create.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_users_create;
        private CueTextBox cueTextBox_create_phone;
        private CueTextBox cueTextBox_create_new_pass_2;
        private CueTextBox cueTextBox_create_email;
        private CueTextBox cueTextBox_create_new_pass;
        private CueTextBox cueTextBox_create_fio;
        private CueTextBox cueTextBox_create_login;
        private CueTextBox cueTextBox_create_library_card;
        private System.Windows.Forms.Button button_users_create;
        private System.Windows.Forms.Button _focus;
    }
}