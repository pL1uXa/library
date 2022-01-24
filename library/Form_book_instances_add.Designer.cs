namespace diploma
{
    partial class Form_book_instances_add
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
            this._focus = new System.Windows.Forms.Button();
            this.button_instances_add = new System.Windows.Forms.Button();
            this.cueTextBox_state_instances = new CueTextBox();
            this.cueTextBox_isbn_issn = new CueTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _focus
            // 
            this._focus.Location = new System.Drawing.Point(262, 106);
            this._focus.Name = "_focus";
            this._focus.Size = new System.Drawing.Size(2, 2);
            this._focus.TabIndex = 38;
            this._focus.Text = "button1";
            this._focus.UseVisualStyleBackColor = true;
            // 
            // button_instances_add
            // 
            this.button_instances_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_instances_add.Font = new System.Drawing.Font("Sitka Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_instances_add.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button_instances_add.Location = new System.Drawing.Point(160, 64);
            this.button_instances_add.Name = "button_instances_add";
            this.button_instances_add.Size = new System.Drawing.Size(106, 31);
            this.button_instances_add.TabIndex = 37;
            this.button_instances_add.Text = "Добавить";
            this.button_instances_add.UseVisualStyleBackColor = true;
            this.button_instances_add.Click += new System.EventHandler(this.button_instances_add_Click);
            // 
            // cueTextBox_state_instances
            // 
            this.cueTextBox_state_instances.Cue = "Введите состояние экземпляра";
            this.cueTextBox_state_instances.Location = new System.Drawing.Point(12, 12);
            this.cueTextBox_state_instances.Name = "cueTextBox_state_instances";
            this.cueTextBox_state_instances.Size = new System.Drawing.Size(254, 20);
            this.cueTextBox_state_instances.TabIndex = 34;
            // 
            // cueTextBox_isbn_issn
            // 
            this.cueTextBox_isbn_issn.Cue = "ISBN/ISSN";
            this.cueTextBox_isbn_issn.Location = new System.Drawing.Point(12, 38);
            this.cueTextBox_isbn_issn.Name = "cueTextBox_isbn_issn";
            this.cueTextBox_isbn_issn.Size = new System.Drawing.Size(254, 20);
            this.cueTextBox_isbn_issn.TabIndex = 39;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(137, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(2, 2);
            this.button1.TabIndex = 40;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form_book_instances_add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 101);
            this.Controls.Add(this.cueTextBox_isbn_issn);
            this.Controls.Add(this._focus);
            this.Controls.Add(this.button_instances_add);
            this.Controls.Add(this.cueTextBox_state_instances);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_book_instances_add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление экземпляра книги";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _focus;
        private System.Windows.Forms.Button button_instances_add;
        private CueTextBox cueTextBox_state_instances;
        private CueTextBox cueTextBox_isbn_issn;
        private System.Windows.Forms.Button button1;
    }
}