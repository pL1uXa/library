namespace diploma
{
    partial class Form_book_create
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
            this.panel_books_create = new System.Windows.Forms.Panel();
            this.cueTextBox_create_year_of_publ = new CueTextBox();
            this.cueTextBox_create_authors_other = new CueTextBox();
            this.cueTextBox_create_author = new CueTextBox();
            this.cueTextBox_create_title = new CueTextBox();
            this.button_books_create = new System.Windows.Forms.Button();
            this._focus = new System.Windows.Forms.Button();
            this.panel_books_create.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_books_create
            // 
            this.panel_books_create.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_books_create.Controls.Add(this.cueTextBox_create_year_of_publ);
            this.panel_books_create.Controls.Add(this.cueTextBox_create_authors_other);
            this.panel_books_create.Controls.Add(this.cueTextBox_create_author);
            this.panel_books_create.Controls.Add(this.cueTextBox_create_title);
            this.panel_books_create.Controls.Add(this.button_books_create);
            this.panel_books_create.Controls.Add(this._focus);
            this.panel_books_create.Location = new System.Drawing.Point(-1, -1);
            this.panel_books_create.Name = "panel_books_create";
            this.panel_books_create.Size = new System.Drawing.Size(319, 131);
            this.panel_books_create.TabIndex = 32;
            // 
            // cueTextBox_create_year_of_publ
            // 
            this.cueTextBox_create_year_of_publ.Cue = "Год публикации";
            this.cueTextBox_create_year_of_publ.Location = new System.Drawing.Point(208, 38);
            this.cueTextBox_create_year_of_publ.Name = "cueTextBox_create_year_of_publ";
            this.cueTextBox_create_year_of_publ.Size = new System.Drawing.Size(100, 20);
            this.cueTextBox_create_year_of_publ.TabIndex = 36;
            // 
            // cueTextBox_create_authors_other
            // 
            this.cueTextBox_create_authors_other.Cue = "Другие авторы (через запятую)";
            this.cueTextBox_create_authors_other.Location = new System.Drawing.Point(9, 64);
            this.cueTextBox_create_authors_other.Name = "cueTextBox_create_authors_other";
            this.cueTextBox_create_authors_other.Size = new System.Drawing.Size(299, 20);
            this.cueTextBox_create_authors_other.TabIndex = 35;
            // 
            // cueTextBox_create_author
            // 
            this.cueTextBox_create_author.Cue = "Автор (первый, только один)";
            this.cueTextBox_create_author.Location = new System.Drawing.Point(9, 38);
            this.cueTextBox_create_author.Name = "cueTextBox_create_author";
            this.cueTextBox_create_author.Size = new System.Drawing.Size(187, 20);
            this.cueTextBox_create_author.TabIndex = 34;
            // 
            // cueTextBox_create_title
            // 
            this.cueTextBox_create_title.Cue = "Название книги";
            this.cueTextBox_create_title.Location = new System.Drawing.Point(9, 12);
            this.cueTextBox_create_title.Name = "cueTextBox_create_title";
            this.cueTextBox_create_title.Size = new System.Drawing.Size(299, 20);
            this.cueTextBox_create_title.TabIndex = 33;
            // 
            // button_books_create
            // 
            this.button_books_create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_books_create.Font = new System.Drawing.Font("Sitka Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_books_create.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button_books_create.Location = new System.Drawing.Point(202, 90);
            this.button_books_create.Name = "button_books_create";
            this.button_books_create.Size = new System.Drawing.Size(106, 31);
            this.button_books_create.TabIndex = 24;
            this.button_books_create.Text = "Добавить";
            this.button_books_create.UseVisualStyleBackColor = true;
            this.button_books_create.Click += new System.EventHandler(this.button_books_create_Click);
            // 
            // _focus
            // 
            this._focus.Location = new System.Drawing.Point(157, 63);
            this._focus.Name = "_focus";
            this._focus.Size = new System.Drawing.Size(2, 2);
            this._focus.TabIndex = 37;
            this._focus.Text = "button1";
            this._focus.UseVisualStyleBackColor = true;
            // 
            // Form_book_create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 129);
            this.Controls.Add(this.panel_books_create);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_book_create";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление книги";
            this.panel_books_create.ResumeLayout(false);
            this.panel_books_create.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_books_create;
        private System.Windows.Forms.Button button_books_create;
        private CueTextBox cueTextBox_create_title;
        private CueTextBox cueTextBox_create_year_of_publ;
        private CueTextBox cueTextBox_create_authors_other;
        private CueTextBox cueTextBox_create_author;
        private System.Windows.Forms.Button _focus;
    }
}