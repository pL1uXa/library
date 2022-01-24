namespace diploma
{
    partial class Form_user_profile_edit
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_users_main = new System.Windows.Forms.Panel();
            this.button_debts_view = new System.Windows.Forms.Button();
            this.button_users_delete = new System.Windows.Forms.Button();
            this.button_users_edit_view = new System.Windows.Forms.Button();
            this.panel_users_debts = new System.Windows.Forms.Panel();
            this.label_error_library_card = new System.Windows.Forms.Label();
            this.dgv_users_debts = new System.Windows.Forms.DataGridView();
            this.button_debts_delete = new System.Windows.Forms.Button();
            this.button_debts_add = new System.Windows.Forms.Button();
            this.panel_users_edit = new System.Windows.Forms.Panel();
            this.groupBox_edit_new_pass = new System.Windows.Forms.GroupBox();
            this.button_edit_new_pass = new System.Windows.Forms.Button();
            this.cueTextBox_edit_new_pass_2 = new CueTextBox();
            this.cueTextBox_edit_new_pass = new CueTextBox();
            this.textBox_edit_email = new System.Windows.Forms.TextBox();
            this.label_info_email = new System.Windows.Forms.Label();
            this.textBox_edit_phone = new System.Windows.Forms.TextBox();
            this.label_info_phone = new System.Windows.Forms.Label();
            this.textBox_edit_fio = new System.Windows.Forms.TextBox();
            this.label_info_fio = new System.Windows.Forms.Label();
            this.label_info_login = new System.Windows.Forms.Label();
            this.label_info_library_card = new System.Windows.Forms.Label();
            this.textBox_edit_login = new System.Windows.Forms.TextBox();
            this.textBox_edit_library_card = new System.Windows.Forms.TextBox();
            this.button_users_edit = new System.Windows.Forms.Button();
            this._focus = new System.Windows.Forms.Button();
            this.panel_users_main.SuspendLayout();
            this.panel_users_debts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_users_debts)).BeginInit();
            this.panel_users_edit.SuspendLayout();
            this.groupBox_edit_new_pass.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_users_main
            // 
            this.panel_users_main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_users_main.Controls.Add(this.button_debts_view);
            this.panel_users_main.Controls.Add(this.button_users_delete);
            this.panel_users_main.Controls.Add(this.button_users_edit_view);
            this.panel_users_main.Controls.Add(this.panel_users_debts);
            this.panel_users_main.Controls.Add(this.panel_users_edit);
            this.panel_users_main.Location = new System.Drawing.Point(-1, -1);
            this.panel_users_main.Name = "panel_users_main";
            this.panel_users_main.Size = new System.Drawing.Size(609, 229);
            this.panel_users_main.TabIndex = 25;
            // 
            // button_debts_view
            // 
            this.button_debts_view.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button_debts_view.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.button_debts_view.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_debts_view.Location = new System.Drawing.Point(-1, 38);
            this.button_debts_view.Name = "button_debts_view";
            this.button_debts_view.Size = new System.Drawing.Size(156, 40);
            this.button_debts_view.TabIndex = 29;
            this.button_debts_view.TabStop = false;
            this.button_debts_view.Text = "Посмотреть книги";
            this.button_debts_view.UseVisualStyleBackColor = false;
            this.button_debts_view.Click += new System.EventHandler(this.button_debts_view_Click);
            // 
            // button_users_delete
            // 
            this.button_users_delete.BackColor = System.Drawing.Color.RosyBrown;
            this.button_users_delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.button_users_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_users_delete.Location = new System.Drawing.Point(-1, 188);
            this.button_users_delete.Name = "button_users_delete";
            this.button_users_delete.Size = new System.Drawing.Size(156, 40);
            this.button_users_delete.TabIndex = 28;
            this.button_users_delete.TabStop = false;
            this.button_users_delete.Text = "Удалить пользователя";
            this.button_users_delete.UseVisualStyleBackColor = false;
            this.button_users_delete.Click += new System.EventHandler(this.button_users_delete_Click);
            // 
            // button_users_edit_view
            // 
            this.button_users_edit_view.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button_users_edit_view.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.button_users_edit_view.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_users_edit_view.Location = new System.Drawing.Point(-1, -1);
            this.button_users_edit_view.Name = "button_users_edit_view";
            this.button_users_edit_view.Size = new System.Drawing.Size(156, 40);
            this.button_users_edit_view.TabIndex = 27;
            this.button_users_edit_view.TabStop = false;
            this.button_users_edit_view.Text = "Редактировать";
            this.button_users_edit_view.UseVisualStyleBackColor = false;
            this.button_users_edit_view.Click += new System.EventHandler(this.button_users_edit_view_Click);
            // 
            // panel_users_debts
            // 
            this.panel_users_debts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_users_debts.Controls.Add(this.label_error_library_card);
            this.panel_users_debts.Controls.Add(this.dgv_users_debts);
            this.panel_users_debts.Controls.Add(this.button_debts_delete);
            this.panel_users_debts.Controls.Add(this.button_debts_add);
            this.panel_users_debts.Location = new System.Drawing.Point(154, -1);
            this.panel_users_debts.Name = "panel_users_debts";
            this.panel_users_debts.Size = new System.Drawing.Size(454, 229);
            this.panel_users_debts.TabIndex = 32;
            // 
            // label_error_library_card
            // 
            this.label_error_library_card.AutoSize = true;
            this.label_error_library_card.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_error_library_card.Location = new System.Drawing.Point(110, 87);
            this.label_error_library_card.Name = "label_error_library_card";
            this.label_error_library_card.Size = new System.Drawing.Size(227, 13);
            this.label_error_library_card.TabIndex = 34;
            this.label_error_library_card.Text = "У пользователя нет читательского билета!";
            this.label_error_library_card.Visible = false;
            // 
            // dgv_users_debts
            // 
            this.dgv_users_debts.AllowUserToAddRows = false;
            this.dgv_users_debts.AllowUserToDeleteRows = false;
            this.dgv_users_debts.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Sitka Text", 8.25F);
            this.dgv_users_debts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_users_debts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_users_debts.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_users_debts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_users_debts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_users_debts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_users_debts.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_users_debts.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgv_users_debts.Location = new System.Drawing.Point(0, 0);
            this.dgv_users_debts.MultiSelect = false;
            this.dgv_users_debts.Name = "dgv_users_debts";
            this.dgv_users_debts.ReadOnly = true;
            this.dgv_users_debts.RowHeadersVisible = false;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Sitka Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dgv_users_debts.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_users_debts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_users_debts.ShowCellErrors = false;
            this.dgv_users_debts.ShowEditingIcon = false;
            this.dgv_users_debts.ShowRowErrors = false;
            this.dgv_users_debts.Size = new System.Drawing.Size(452, 187);
            this.dgv_users_debts.TabIndex = 33;
            // 
            // button_debts_delete
            // 
            this.button_debts_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_debts_delete.Font = new System.Drawing.Font("Sitka Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_debts_delete.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button_debts_delete.Location = new System.Drawing.Point(3, 193);
            this.button_debts_delete.Name = "button_debts_delete";
            this.button_debts_delete.Size = new System.Drawing.Size(106, 31);
            this.button_debts_delete.TabIndex = 32;
            this.button_debts_delete.Text = "Удалить";
            this.button_debts_delete.UseVisualStyleBackColor = true;
            this.button_debts_delete.Click += new System.EventHandler(this.button_debts_delete_Click);
            // 
            // button_debts_add
            // 
            this.button_debts_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_debts_add.Font = new System.Drawing.Font("Sitka Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_debts_add.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button_debts_add.Location = new System.Drawing.Point(343, 193);
            this.button_debts_add.Name = "button_debts_add";
            this.button_debts_add.Size = new System.Drawing.Size(106, 31);
            this.button_debts_add.TabIndex = 31;
            this.button_debts_add.Text = "Добавить";
            this.button_debts_add.UseVisualStyleBackColor = true;
            this.button_debts_add.Click += new System.EventHandler(this.button_debts_add_Click);
            // 
            // panel_users_edit
            // 
            this.panel_users_edit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_users_edit.Controls.Add(this.groupBox_edit_new_pass);
            this.panel_users_edit.Controls.Add(this.textBox_edit_email);
            this.panel_users_edit.Controls.Add(this.label_info_email);
            this.panel_users_edit.Controls.Add(this.textBox_edit_phone);
            this.panel_users_edit.Controls.Add(this.label_info_phone);
            this.panel_users_edit.Controls.Add(this.textBox_edit_fio);
            this.panel_users_edit.Controls.Add(this.label_info_fio);
            this.panel_users_edit.Controls.Add(this.label_info_login);
            this.panel_users_edit.Controls.Add(this.label_info_library_card);
            this.panel_users_edit.Controls.Add(this.textBox_edit_login);
            this.panel_users_edit.Controls.Add(this.textBox_edit_library_card);
            this.panel_users_edit.Controls.Add(this.button_users_edit);
            this.panel_users_edit.Location = new System.Drawing.Point(154, -1);
            this.panel_users_edit.Name = "panel_users_edit";
            this.panel_users_edit.Size = new System.Drawing.Size(454, 229);
            this.panel_users_edit.TabIndex = 31;
            // 
            // groupBox_edit_new_pass
            // 
            this.groupBox_edit_new_pass.Controls.Add(this.button_edit_new_pass);
            this.groupBox_edit_new_pass.Controls.Add(this.cueTextBox_edit_new_pass_2);
            this.groupBox_edit_new_pass.Controls.Add(this.cueTextBox_edit_new_pass);
            this.groupBox_edit_new_pass.Location = new System.Drawing.Point(3, 137);
            this.groupBox_edit_new_pass.Name = "groupBox_edit_new_pass";
            this.groupBox_edit_new_pass.Size = new System.Drawing.Size(446, 87);
            this.groupBox_edit_new_pass.TabIndex = 35;
            this.groupBox_edit_new_pass.TabStop = false;
            this.groupBox_edit_new_pass.Text = "Новый пароль";
            // 
            // button_edit_new_pass
            // 
            this.button_edit_new_pass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_edit_new_pass.Font = new System.Drawing.Font("Sitka Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_edit_new_pass.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button_edit_new_pass.Location = new System.Drawing.Point(8, 51);
            this.button_edit_new_pass.Name = "button_edit_new_pass";
            this.button_edit_new_pass.Size = new System.Drawing.Size(160, 31);
            this.button_edit_new_pass.TabIndex = 25;
            this.button_edit_new_pass.Text = "Сменить пароль";
            this.button_edit_new_pass.UseVisualStyleBackColor = true;
            this.button_edit_new_pass.Click += new System.EventHandler(this.button_edit_new_pass_Click);
            // 
            // cueTextBox_edit_new_pass_2
            // 
            this.cueTextBox_edit_new_pass_2.Cue = "Введите пароль (еще раз)";
            this.cueTextBox_edit_new_pass_2.Location = new System.Drawing.Point(230, 23);
            this.cueTextBox_edit_new_pass_2.Name = "cueTextBox_edit_new_pass_2";
            this.cueTextBox_edit_new_pass_2.Size = new System.Drawing.Size(210, 20);
            this.cueTextBox_edit_new_pass_2.TabIndex = 1;
            this.cueTextBox_edit_new_pass_2.UseSystemPasswordChar = true;
            // 
            // cueTextBox_edit_new_pass
            // 
            this.cueTextBox_edit_new_pass.Cue = "Введите пароль";
            this.cueTextBox_edit_new_pass.Location = new System.Drawing.Point(8, 23);
            this.cueTextBox_edit_new_pass.Name = "cueTextBox_edit_new_pass";
            this.cueTextBox_edit_new_pass.Size = new System.Drawing.Size(210, 20);
            this.cueTextBox_edit_new_pass.TabIndex = 0;
            this.cueTextBox_edit_new_pass.UseSystemPasswordChar = true;
            // 
            // textBox_edit_email
            // 
            this.textBox_edit_email.Location = new System.Drawing.Point(316, 10);
            this.textBox_edit_email.Name = "textBox_edit_email";
            this.textBox_edit_email.Size = new System.Drawing.Size(133, 20);
            this.textBox_edit_email.TabIndex = 34;
            // 
            // label_info_email
            // 
            this.label_info_email.AutoSize = true;
            this.label_info_email.Location = new System.Drawing.Point(271, 13);
            this.label_info_email.Name = "label_info_email";
            this.label_info_email.Size = new System.Drawing.Size(39, 13);
            this.label_info_email.TabIndex = 33;
            this.label_info_email.Text = "E-Mail:";
            // 
            // textBox_edit_phone
            // 
            this.textBox_edit_phone.Location = new System.Drawing.Point(316, 35);
            this.textBox_edit_phone.Name = "textBox_edit_phone";
            this.textBox_edit_phone.Size = new System.Drawing.Size(133, 20);
            this.textBox_edit_phone.TabIndex = 32;
            // 
            // label_info_phone
            // 
            this.label_info_phone.AutoSize = true;
            this.label_info_phone.Location = new System.Drawing.Point(255, 38);
            this.label_info_phone.Name = "label_info_phone";
            this.label_info_phone.Size = new System.Drawing.Size(55, 13);
            this.label_info_phone.TabIndex = 31;
            this.label_info_phone.Text = "Телефон:";
            // 
            // textBox_edit_fio
            // 
            this.textBox_edit_fio.Location = new System.Drawing.Point(94, 61);
            this.textBox_edit_fio.Name = "textBox_edit_fio";
            this.textBox_edit_fio.Size = new System.Drawing.Size(355, 20);
            this.textBox_edit_fio.TabIndex = 30;
            // 
            // label_info_fio
            // 
            this.label_info_fio.AutoSize = true;
            this.label_info_fio.Location = new System.Drawing.Point(51, 64);
            this.label_info_fio.Name = "label_info_fio";
            this.label_info_fio.Size = new System.Drawing.Size(37, 13);
            this.label_info_fio.TabIndex = 29;
            this.label_info_fio.Text = "ФИО:";
            // 
            // label_info_login
            // 
            this.label_info_login.AutoSize = true;
            this.label_info_login.Location = new System.Drawing.Point(47, 38);
            this.label_info_login.Name = "label_info_login";
            this.label_info_login.Size = new System.Drawing.Size(41, 13);
            this.label_info_login.TabIndex = 28;
            this.label_info_login.Text = "Логин:";
            // 
            // label_info_library_card
            // 
            this.label_info_library_card.AutoSize = true;
            this.label_info_library_card.Location = new System.Drawing.Point(6, 13);
            this.label_info_library_card.Name = "label_info_library_card";
            this.label_info_library_card.Size = new System.Drawing.Size(82, 13);
            this.label_info_library_card.TabIndex = 27;
            this.label_info_library_card.Text = "Номер билета:";
            // 
            // textBox_edit_login
            // 
            this.textBox_edit_login.Location = new System.Drawing.Point(94, 35);
            this.textBox_edit_login.Name = "textBox_edit_login";
            this.textBox_edit_login.Size = new System.Drawing.Size(133, 20);
            this.textBox_edit_login.TabIndex = 26;
            // 
            // textBox_edit_library_card
            // 
            this.textBox_edit_library_card.Location = new System.Drawing.Point(94, 10);
            this.textBox_edit_library_card.Name = "textBox_edit_library_card";
            this.textBox_edit_library_card.Size = new System.Drawing.Size(133, 20);
            this.textBox_edit_library_card.TabIndex = 25;
            // 
            // button_users_edit
            // 
            this.button_users_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_users_edit.Font = new System.Drawing.Font("Sitka Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_users_edit.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button_users_edit.Location = new System.Drawing.Point(343, 87);
            this.button_users_edit.Name = "button_users_edit";
            this.button_users_edit.Size = new System.Drawing.Size(106, 31);
            this.button_users_edit.TabIndex = 24;
            this.button_users_edit.Text = "Изменить";
            this.button_users_edit.UseVisualStyleBackColor = true;
            this.button_users_edit.Click += new System.EventHandler(this.button_users_edit_Click);
            // 
            // _focus
            // 
            this._focus.Location = new System.Drawing.Point(302, 113);
            this._focus.Name = "_focus";
            this._focus.Size = new System.Drawing.Size(2, 2);
            this._focus.TabIndex = 26;
            this._focus.Text = "button1";
            this._focus.UseVisualStyleBackColor = true;
            // 
            // Form_user_profile_edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 227);
            this.Controls.Add(this.panel_users_main);
            this.Controls.Add(this._focus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_user_profile_edit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактирование пользователя";
            this.Load += new System.EventHandler(this.Form_use_profile_edit_Load);
            this.panel_users_main.ResumeLayout(false);
            this.panel_users_debts.ResumeLayout(false);
            this.panel_users_debts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_users_debts)).EndInit();
            this.panel_users_edit.ResumeLayout(false);
            this.panel_users_edit.PerformLayout();
            this.groupBox_edit_new_pass.ResumeLayout(false);
            this.groupBox_edit_new_pass.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_users_main;
        private System.Windows.Forms.Button button_debts_view;
        private System.Windows.Forms.Button button_users_delete;
        private System.Windows.Forms.Button button_users_edit_view;
        private System.Windows.Forms.Panel panel_users_edit;
        private System.Windows.Forms.GroupBox groupBox_edit_new_pass;
        private System.Windows.Forms.Button button_edit_new_pass;
        private CueTextBox cueTextBox_edit_new_pass_2;
        private CueTextBox cueTextBox_edit_new_pass;
        private System.Windows.Forms.TextBox textBox_edit_email;
        private System.Windows.Forms.Label label_info_email;
        private System.Windows.Forms.TextBox textBox_edit_phone;
        private System.Windows.Forms.Label label_info_phone;
        private System.Windows.Forms.TextBox textBox_edit_fio;
        private System.Windows.Forms.Label label_info_fio;
        private System.Windows.Forms.Label label_info_login;
        private System.Windows.Forms.Label label_info_library_card;
        private System.Windows.Forms.TextBox textBox_edit_login;
        private System.Windows.Forms.TextBox textBox_edit_library_card;
        private System.Windows.Forms.Button button_users_edit;
        private System.Windows.Forms.Button _focus;
        private System.Windows.Forms.Panel panel_users_debts;
        private System.Windows.Forms.Button button_debts_delete;
        private System.Windows.Forms.Button button_debts_add;
        private System.Windows.Forms.DataGridView dgv_users_debts;
        private System.Windows.Forms.Label label_error_library_card;
    }
}