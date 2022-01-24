namespace diploma
{
    partial class Form_book_edit
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
            this.panel_books_main = new System.Windows.Forms.Panel();
            this.button_instances_view = new System.Windows.Forms.Button();
            this.button_books_delete = new System.Windows.Forms.Button();
            this.button_books_edit_view = new System.Windows.Forms.Button();
            this._focus = new System.Windows.Forms.Button();
            this.panel_books_instances = new System.Windows.Forms.Panel();
            this.label_info = new System.Windows.Forms.Label();
            this.button_instances_view_user = new System.Windows.Forms.Button();
            this.dgv_books_instances = new System.Windows.Forms.DataGridView();
            this.button_instances_delete = new System.Windows.Forms.Button();
            this.button_instances_add = new System.Windows.Forms.Button();
            this.panel_books_edit = new System.Windows.Forms.Panel();
            this.textBox_edit_authors_other = new System.Windows.Forms.TextBox();
            this.label_edit_authors_other = new System.Windows.Forms.Label();
            this.textBox_edit_author = new System.Windows.Forms.TextBox();
            this.label_edit_year_of_publ = new System.Windows.Forms.Label();
            this.label_edit_author = new System.Windows.Forms.Label();
            this.label_edit_title = new System.Windows.Forms.Label();
            this.textBox_edit_year_of_publ = new System.Windows.Forms.TextBox();
            this.textBox_edit_title = new System.Windows.Forms.TextBox();
            this.button_books_edit = new System.Windows.Forms.Button();
            this.panel_books_main.SuspendLayout();
            this.panel_books_instances.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_books_instances)).BeginInit();
            this.panel_books_edit.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_books_main
            // 
            this.panel_books_main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_books_main.Controls.Add(this.button_instances_view);
            this.panel_books_main.Controls.Add(this.button_books_delete);
            this.panel_books_main.Controls.Add(this.button_books_edit_view);
            this.panel_books_main.Controls.Add(this._focus);
            this.panel_books_main.Controls.Add(this.panel_books_instances);
            this.panel_books_main.Controls.Add(this.panel_books_edit);
            this.panel_books_main.Location = new System.Drawing.Point(-1, -1);
            this.panel_books_main.Name = "panel_books_main";
            this.panel_books_main.Size = new System.Drawing.Size(609, 229);
            this.panel_books_main.TabIndex = 26;
            // 
            // button_instances_view
            // 
            this.button_instances_view.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button_instances_view.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.button_instances_view.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_instances_view.Location = new System.Drawing.Point(-1, 38);
            this.button_instances_view.Name = "button_instances_view";
            this.button_instances_view.Size = new System.Drawing.Size(156, 40);
            this.button_instances_view.TabIndex = 29;
            this.button_instances_view.TabStop = false;
            this.button_instances_view.Text = "Посмотреть экземпляры";
            this.button_instances_view.UseVisualStyleBackColor = false;
            this.button_instances_view.Click += new System.EventHandler(this.button_instances_view_Click);
            // 
            // button_books_delete
            // 
            this.button_books_delete.BackColor = System.Drawing.Color.RosyBrown;
            this.button_books_delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.button_books_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_books_delete.Location = new System.Drawing.Point(-1, 188);
            this.button_books_delete.Name = "button_books_delete";
            this.button_books_delete.Size = new System.Drawing.Size(156, 40);
            this.button_books_delete.TabIndex = 28;
            this.button_books_delete.TabStop = false;
            this.button_books_delete.Text = "Удалить книгу";
            this.button_books_delete.UseVisualStyleBackColor = false;
            this.button_books_delete.Click += new System.EventHandler(this.button_books_delete_Click);
            // 
            // button_books_edit_view
            // 
            this.button_books_edit_view.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button_books_edit_view.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.button_books_edit_view.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_books_edit_view.Location = new System.Drawing.Point(-1, -1);
            this.button_books_edit_view.Name = "button_books_edit_view";
            this.button_books_edit_view.Size = new System.Drawing.Size(156, 40);
            this.button_books_edit_view.TabIndex = 27;
            this.button_books_edit_view.TabStop = false;
            this.button_books_edit_view.Text = "Редактировать";
            this.button_books_edit_view.UseVisualStyleBackColor = false;
            this.button_books_edit_view.Click += new System.EventHandler(this.button_books_edit_view_Click);
            // 
            // _focus
            // 
            this._focus.Location = new System.Drawing.Point(302, 112);
            this._focus.Name = "_focus";
            this._focus.Size = new System.Drawing.Size(2, 2);
            this._focus.TabIndex = 33;
            this._focus.Text = "button1";
            this._focus.UseVisualStyleBackColor = true;
            // 
            // panel_books_instances
            // 
            this.panel_books_instances.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_books_instances.Controls.Add(this.label_info);
            this.panel_books_instances.Controls.Add(this.button_instances_view_user);
            this.panel_books_instances.Controls.Add(this.dgv_books_instances);
            this.panel_books_instances.Controls.Add(this.button_instances_delete);
            this.panel_books_instances.Controls.Add(this.button_instances_add);
            this.panel_books_instances.Location = new System.Drawing.Point(154, -1);
            this.panel_books_instances.Name = "panel_books_instances";
            this.panel_books_instances.Size = new System.Drawing.Size(454, 229);
            this.panel_books_instances.TabIndex = 32;
            // 
            // label_info
            // 
            this.label_info.AutoSize = true;
            this.label_info.Location = new System.Drawing.Point(108, 175);
            this.label_info.Name = "label_info";
            this.label_info.Size = new System.Drawing.Size(240, 13);
            this.label_info.TabIndex = 35;
            this.label_info.Text = "Двойной клик по записи для редактирования";
            this.label_info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_instances_view_user
            // 
            this.button_instances_view_user.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_instances_view_user.Font = new System.Drawing.Font("Sitka Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_instances_view_user.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button_instances_view_user.Location = new System.Drawing.Point(133, 193);
            this.button_instances_view_user.Name = "button_instances_view_user";
            this.button_instances_view_user.Size = new System.Drawing.Size(186, 31);
            this.button_instances_view_user.TabIndex = 34;
            this.button_instances_view_user.Text = "Посмотреть кем взята";
            this.button_instances_view_user.UseVisualStyleBackColor = true;
            this.button_instances_view_user.Click += new System.EventHandler(this.button_instances_view_user_Click);
            // 
            // dgv_books_instances
            // 
            this.dgv_books_instances.AllowUserToAddRows = false;
            this.dgv_books_instances.AllowUserToDeleteRows = false;
            this.dgv_books_instances.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Sitka Text", 8.25F);
            this.dgv_books_instances.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_books_instances.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_books_instances.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_books_instances.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_books_instances.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_books_instances.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_books_instances.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_books_instances.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgv_books_instances.Location = new System.Drawing.Point(0, 0);
            this.dgv_books_instances.MultiSelect = false;
            this.dgv_books_instances.Name = "dgv_books_instances";
            this.dgv_books_instances.ReadOnly = true;
            this.dgv_books_instances.RowHeadersVisible = false;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Sitka Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dgv_books_instances.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_books_instances.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_books_instances.ShowCellErrors = false;
            this.dgv_books_instances.ShowEditingIcon = false;
            this.dgv_books_instances.ShowRowErrors = false;
            this.dgv_books_instances.Size = new System.Drawing.Size(452, 171);
            this.dgv_books_instances.TabIndex = 33;
            this.dgv_books_instances.DoubleClick += new System.EventHandler(this.dgv_books_instances_DoubleClick);
            // 
            // button_instances_delete
            // 
            this.button_instances_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_instances_delete.Font = new System.Drawing.Font("Sitka Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_instances_delete.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button_instances_delete.Location = new System.Drawing.Point(3, 193);
            this.button_instances_delete.Name = "button_instances_delete";
            this.button_instances_delete.Size = new System.Drawing.Size(106, 31);
            this.button_instances_delete.TabIndex = 32;
            this.button_instances_delete.Text = "Удалить";
            this.button_instances_delete.UseVisualStyleBackColor = true;
            this.button_instances_delete.Click += new System.EventHandler(this.button_instances_delete_Click);
            // 
            // button_instances_add
            // 
            this.button_instances_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_instances_add.Font = new System.Drawing.Font("Sitka Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_instances_add.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button_instances_add.Location = new System.Drawing.Point(343, 193);
            this.button_instances_add.Name = "button_instances_add";
            this.button_instances_add.Size = new System.Drawing.Size(106, 31);
            this.button_instances_add.TabIndex = 31;
            this.button_instances_add.Text = "Добавить";
            this.button_instances_add.UseVisualStyleBackColor = true;
            this.button_instances_add.Click += new System.EventHandler(this.button_instances_add_Click);
            // 
            // panel_books_edit
            // 
            this.panel_books_edit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_books_edit.Controls.Add(this.textBox_edit_authors_other);
            this.panel_books_edit.Controls.Add(this.label_edit_authors_other);
            this.panel_books_edit.Controls.Add(this.textBox_edit_author);
            this.panel_books_edit.Controls.Add(this.label_edit_year_of_publ);
            this.panel_books_edit.Controls.Add(this.label_edit_author);
            this.panel_books_edit.Controls.Add(this.label_edit_title);
            this.panel_books_edit.Controls.Add(this.textBox_edit_year_of_publ);
            this.panel_books_edit.Controls.Add(this.textBox_edit_title);
            this.panel_books_edit.Controls.Add(this.button_books_edit);
            this.panel_books_edit.Location = new System.Drawing.Point(154, -1);
            this.panel_books_edit.Name = "panel_books_edit";
            this.panel_books_edit.Size = new System.Drawing.Size(454, 229);
            this.panel_books_edit.TabIndex = 31;
            // 
            // textBox_edit_authors_other
            // 
            this.textBox_edit_authors_other.Location = new System.Drawing.Point(9, 129);
            this.textBox_edit_authors_other.Name = "textBox_edit_authors_other";
            this.textBox_edit_authors_other.Size = new System.Drawing.Size(440, 20);
            this.textBox_edit_authors_other.TabIndex = 32;
            // 
            // label_edit_authors_other
            // 
            this.label_edit_authors_other.AutoSize = true;
            this.label_edit_authors_other.Location = new System.Drawing.Point(6, 113);
            this.label_edit_authors_other.Name = "label_edit_authors_other";
            this.label_edit_authors_other.Size = new System.Drawing.Size(170, 13);
            this.label_edit_authors_other.TabIndex = 31;
            this.label_edit_authors_other.Text = "Другие авторы (через запятую):";
            // 
            // textBox_edit_author
            // 
            this.textBox_edit_author.Location = new System.Drawing.Point(9, 81);
            this.textBox_edit_author.Name = "textBox_edit_author";
            this.textBox_edit_author.Size = new System.Drawing.Size(204, 20);
            this.textBox_edit_author.TabIndex = 30;
            // 
            // label_edit_year_of_publ
            // 
            this.label_edit_year_of_publ.AutoSize = true;
            this.label_edit_year_of_publ.Location = new System.Drawing.Point(242, 65);
            this.label_edit_year_of_publ.Name = "label_edit_year_of_publ";
            this.label_edit_year_of_publ.Size = new System.Drawing.Size(90, 13);
            this.label_edit_year_of_publ.TabIndex = 29;
            this.label_edit_year_of_publ.Text = "Год публикации:";
            // 
            // label_edit_author
            // 
            this.label_edit_author.AutoSize = true;
            this.label_edit_author.Location = new System.Drawing.Point(6, 65);
            this.label_edit_author.Name = "label_edit_author";
            this.label_edit_author.Size = new System.Drawing.Size(155, 13);
            this.label_edit_author.TabIndex = 28;
            this.label_edit_author.Text = "Автор (первый, только один):";
            // 
            // label_edit_title
            // 
            this.label_edit_title.AutoSize = true;
            this.label_edit_title.Location = new System.Drawing.Point(6, 13);
            this.label_edit_title.Name = "label_edit_title";
            this.label_edit_title.Size = new System.Drawing.Size(92, 13);
            this.label_edit_title.TabIndex = 27;
            this.label_edit_title.Text = "Название книги:";
            // 
            // textBox_edit_year_of_publ
            // 
            this.textBox_edit_year_of_publ.Location = new System.Drawing.Point(245, 81);
            this.textBox_edit_year_of_publ.Name = "textBox_edit_year_of_publ";
            this.textBox_edit_year_of_publ.Size = new System.Drawing.Size(204, 20);
            this.textBox_edit_year_of_publ.TabIndex = 26;
            // 
            // textBox_edit_title
            // 
            this.textBox_edit_title.Location = new System.Drawing.Point(9, 29);
            this.textBox_edit_title.Name = "textBox_edit_title";
            this.textBox_edit_title.Size = new System.Drawing.Size(440, 20);
            this.textBox_edit_title.TabIndex = 25;
            // 
            // button_books_edit
            // 
            this.button_books_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_books_edit.Font = new System.Drawing.Font("Sitka Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_books_edit.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button_books_edit.Location = new System.Drawing.Point(343, 193);
            this.button_books_edit.Name = "button_books_edit";
            this.button_books_edit.Size = new System.Drawing.Size(106, 31);
            this.button_books_edit.TabIndex = 24;
            this.button_books_edit.Text = "Изменить";
            this.button_books_edit.UseVisualStyleBackColor = true;
            this.button_books_edit.Click += new System.EventHandler(this.button_books_edit_Click);
            // 
            // Form_book_edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 227);
            this.Controls.Add(this.panel_books_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_book_edit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактирование книги";
            this.Load += new System.EventHandler(this.Form_book_edit_Load);
            this.panel_books_main.ResumeLayout(false);
            this.panel_books_instances.ResumeLayout(false);
            this.panel_books_instances.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_books_instances)).EndInit();
            this.panel_books_edit.ResumeLayout(false);
            this.panel_books_edit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_books_main;
        private System.Windows.Forms.Button button_instances_view;
        private System.Windows.Forms.Button button_books_delete;
        private System.Windows.Forms.Button button_books_edit_view;
        private System.Windows.Forms.Panel panel_books_instances;
        private System.Windows.Forms.DataGridView dgv_books_instances;
        private System.Windows.Forms.Button button_instances_delete;
        private System.Windows.Forms.Button button_instances_add;
        private System.Windows.Forms.Panel panel_books_edit;
        private System.Windows.Forms.TextBox textBox_edit_authors_other;
        private System.Windows.Forms.Label label_edit_authors_other;
        private System.Windows.Forms.TextBox textBox_edit_author;
        private System.Windows.Forms.Label label_edit_year_of_publ;
        private System.Windows.Forms.Label label_edit_author;
        private System.Windows.Forms.Label label_edit_title;
        private System.Windows.Forms.TextBox textBox_edit_year_of_publ;
        private System.Windows.Forms.TextBox textBox_edit_title;
        private System.Windows.Forms.Button button_books_edit;
        private System.Windows.Forms.Button _focus;
        private System.Windows.Forms.Button button_instances_view_user;
        private System.Windows.Forms.Label label_info;
    }
}