namespace diploma
{
    partial class Form_group_3
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_main = new System.Windows.Forms.Panel();
            this.button_news = new System.Windows.Forms.Button();
            this.button_users = new System.Windows.Forms.Button();
            this.panel_news = new System.Windows.Forms.Panel();
            this.button_news_save = new System.Windows.Forms.Button();
            this.richTextBox_news = new System.Windows.Forms.RichTextBox();
            this.panel_users = new System.Windows.Forms.Panel();
            this._focus = new System.Windows.Forms.Button();
            this.dgv_users_search = new System.Windows.Forms.DataGridView();
            this.button_raise_to = new System.Windows.Forms.Button();
            this.cueTextBox_users = new CueTextBox();
            this.label_user_info = new System.Windows.Forms.Label();
            this.panel_main.SuspendLayout();
            this.panel_news.SuspendLayout();
            this.panel_users.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_users_search)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel_main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_main.Controls.Add(this.button_news);
            this.panel_main.Controls.Add(this.button_users);
            this.panel_main.Controls.Add(this.panel_users);
            this.panel_main.Controls.Add(this.panel_news);
            this.panel_main.Location = new System.Drawing.Point(-1, -1);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(684, 271);
            this.panel_main.TabIndex = 20;
            // 
            // button_news
            // 
            this.button_news.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button_news.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.button_news.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_news.Location = new System.Drawing.Point(-1, -1);
            this.button_news.Name = "button_news";
            this.button_news.Size = new System.Drawing.Size(156, 40);
            this.button_news.TabIndex = 24;
            this.button_news.TabStop = false;
            this.button_news.Text = "Новости";
            this.button_news.UseVisualStyleBackColor = false;
            this.button_news.Click += new System.EventHandler(this.button_news_Click);
            // 
            // button_users
            // 
            this.button_users.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button_users.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.button_users.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_users.Location = new System.Drawing.Point(-1, 38);
            this.button_users.Name = "button_users";
            this.button_users.Size = new System.Drawing.Size(156, 40);
            this.button_users.TabIndex = 23;
            this.button_users.TabStop = false;
            this.button_users.Text = "Сотрудники";
            this.button_users.UseVisualStyleBackColor = false;
            this.button_users.Click += new System.EventHandler(this.button_users_Click);
            // 
            // panel_news
            // 
            this.panel_news.BackColor = System.Drawing.SystemColors.Control;
            this.panel_news.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_news.Controls.Add(this.button_news_save);
            this.panel_news.Controls.Add(this.richTextBox_news);
            this.panel_news.Location = new System.Drawing.Point(154, -1);
            this.panel_news.Name = "panel_news";
            this.panel_news.Size = new System.Drawing.Size(529, 271);
            this.panel_news.TabIndex = 17;
            // 
            // button_news_save
            // 
            this.button_news_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_news_save.Font = new System.Drawing.Font("Sitka Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_news_save.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button_news_save.Location = new System.Drawing.Point(415, 233);
            this.button_news_save.Name = "button_news_save";
            this.button_news_save.Size = new System.Drawing.Size(106, 31);
            this.button_news_save.TabIndex = 23;
            this.button_news_save.Text = "Сохранить";
            this.button_news_save.UseVisualStyleBackColor = true;
            this.button_news_save.Click += new System.EventHandler(this.button_news_save_Click);
            // 
            // richTextBox_news
            // 
            this.richTextBox_news.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_news.Location = new System.Drawing.Point(6, 12);
            this.richTextBox_news.Name = "richTextBox_news";
            this.richTextBox_news.Size = new System.Drawing.Size(515, 215);
            this.richTextBox_news.TabIndex = 0;
            this.richTextBox_news.Text = "";
            // 
            // panel_users
            // 
            this.panel_users.BackColor = System.Drawing.SystemColors.Control;
            this.panel_users.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_users.Controls.Add(this.label_user_info);
            this.panel_users.Controls.Add(this.button_raise_to);
            this.panel_users.Controls.Add(this.cueTextBox_users);
            this.panel_users.Controls.Add(this.dgv_users_search);
            this.panel_users.Location = new System.Drawing.Point(154, -1);
            this.panel_users.Name = "panel_users";
            this.panel_users.Size = new System.Drawing.Size(529, 271);
            this.panel_users.TabIndex = 25;
            // 
            // _focus
            // 
            this._focus.Location = new System.Drawing.Point(340, 133);
            this._focus.Name = "_focus";
            this._focus.Size = new System.Drawing.Size(2, 2);
            this._focus.TabIndex = 23;
            this._focus.Text = "button1";
            this._focus.UseVisualStyleBackColor = true;
            // 
            // dgv_users_search
            // 
            this.dgv_users_search.AllowUserToAddRows = false;
            this.dgv_users_search.AllowUserToDeleteRows = false;
            this.dgv_users_search.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Sitka Text", 8.25F);
            this.dgv_users_search.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_users_search.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_users_search.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_users_search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_users_search.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_users_search.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_users_search.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_users_search.Location = new System.Drawing.Point(6, 3);
            this.dgv_users_search.MultiSelect = false;
            this.dgv_users_search.Name = "dgv_users_search";
            this.dgv_users_search.ReadOnly = true;
            this.dgv_users_search.RowHeadersVisible = false;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Sitka Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dgv_users_search.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_users_search.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_users_search.ShowCellErrors = false;
            this.dgv_users_search.ShowEditingIcon = false;
            this.dgv_users_search.ShowRowErrors = false;
            this.dgv_users_search.Size = new System.Drawing.Size(515, 199);
            this.dgv_users_search.TabIndex = 22;
            this.dgv_users_search.DoubleClick += new System.EventHandler(this.dgv_users_search_DoubleClick);
            // 
            // button_raise_to
            // 
            this.button_raise_to.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_raise_to.Font = new System.Drawing.Font("Sitka Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_raise_to.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button_raise_to.Location = new System.Drawing.Point(294, 233);
            this.button_raise_to.Name = "button_raise_to";
            this.button_raise_to.Size = new System.Drawing.Size(227, 31);
            this.button_raise_to.TabIndex = 25;
            this.button_raise_to.Text = "Повысить до библиотекаря";
            this.button_raise_to.UseVisualStyleBackColor = true;
            this.button_raise_to.Click += new System.EventHandler(this.button_raise_to_Click);
            // 
            // cueTextBox_users
            // 
            this.cueTextBox_users.Cue = "Введите логин";
            this.cueTextBox_users.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cueTextBox_users.Location = new System.Drawing.Point(6, 233);
            this.cueTextBox_users.Name = "cueTextBox_users";
            this.cueTextBox_users.Size = new System.Drawing.Size(291, 31);
            this.cueTextBox_users.TabIndex = 26;
            // 
            // label_user_info
            // 
            this.label_user_info.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_user_info.Location = new System.Drawing.Point(6, 207);
            this.label_user_info.Name = "label_user_info";
            this.label_user_info.Size = new System.Drawing.Size(515, 23);
            this.label_user_info.TabIndex = 27;
            this.label_user_info.Text = "Двойной клик по пользователю заберет его права";
            this.label_user_info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form_group_3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 269);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this._focus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_group_3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Панель управления [Директор]";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_group_3_FormClosed);
            this.Load += new System.EventHandler(this.Form_group_3_Load);
            this.panel_main.ResumeLayout(false);
            this.panel_news.ResumeLayout(false);
            this.panel_users.ResumeLayout(false);
            this.panel_users.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_users_search)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Button button_news;
        private System.Windows.Forms.Button button_users;
        private System.Windows.Forms.Panel panel_news;
        private System.Windows.Forms.RichTextBox richTextBox_news;
        private System.Windows.Forms.Button button_news_save;
        private System.Windows.Forms.Button _focus;
        private System.Windows.Forms.Panel panel_users;
        private System.Windows.Forms.DataGridView dgv_users_search;
        private System.Windows.Forms.Button button_raise_to;
        private System.Windows.Forms.Label label_user_info;
        private CueTextBox cueTextBox_users;
    }
}