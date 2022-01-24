namespace diploma
{
    partial class Form_book_instances_edit
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
            this.textBox_edit_isbn_issn = new System.Windows.Forms.TextBox();
            this.textBox_edit_state_instances = new System.Windows.Forms.TextBox();
            this.label_isbn_issn = new System.Windows.Forms.Label();
            this.label_state_instances = new System.Windows.Forms.Label();
            this.button_edit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _focus
            // 
            this._focus.Location = new System.Drawing.Point(141, 129);
            this._focus.Name = "_focus";
            this._focus.Size = new System.Drawing.Size(2, 2);
            this._focus.TabIndex = 23;
            this._focus.Text = "button1";
            this._focus.UseVisualStyleBackColor = true;
            // 
            // textBox_edit_isbn_issn
            // 
            this.textBox_edit_isbn_issn.Location = new System.Drawing.Point(76, 6);
            this.textBox_edit_isbn_issn.Name = "textBox_edit_isbn_issn";
            this.textBox_edit_isbn_issn.Size = new System.Drawing.Size(286, 20);
            this.textBox_edit_isbn_issn.TabIndex = 24;
            // 
            // textBox_edit_state_instances
            // 
            this.textBox_edit_state_instances.Location = new System.Drawing.Point(142, 32);
            this.textBox_edit_state_instances.Name = "textBox_edit_state_instances";
            this.textBox_edit_state_instances.Size = new System.Drawing.Size(220, 20);
            this.textBox_edit_state_instances.TabIndex = 25;
            // 
            // label_isbn_issn
            // 
            this.label_isbn_issn.AutoSize = true;
            this.label_isbn_issn.Location = new System.Drawing.Point(5, 9);
            this.label_isbn_issn.Name = "label_isbn_issn";
            this.label_isbn_issn.Size = new System.Drawing.Size(65, 13);
            this.label_isbn_issn.TabIndex = 26;
            this.label_isbn_issn.Text = "ISBN/ISSN:";
            // 
            // label_state_instances
            // 
            this.label_state_instances.AutoSize = true;
            this.label_state_instances.Location = new System.Drawing.Point(7, 35);
            this.label_state_instances.Name = "label_state_instances";
            this.label_state_instances.Size = new System.Drawing.Size(129, 13);
            this.label_state_instances.TabIndex = 27;
            this.label_state_instances.Text = "Состояние экземпляра:";
            // 
            // button_edit
            // 
            this.button_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_edit.Font = new System.Drawing.Font("Sitka Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_edit.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button_edit.Location = new System.Drawing.Point(256, 58);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(106, 31);
            this.button_edit.TabIndex = 32;
            this.button_edit.Text = "Изменить";
            this.button_edit.UseVisualStyleBackColor = true;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // Form_book_instances_edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 96);
            this.Controls.Add(this.button_edit);
            this.Controls.Add(this.label_state_instances);
            this.Controls.Add(this.label_isbn_issn);
            this.Controls.Add(this.textBox_edit_state_instances);
            this.Controls.Add(this.textBox_edit_isbn_issn);
            this.Controls.Add(this._focus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_book_instances_edit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактирование экземпляра";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _focus;
        private System.Windows.Forms.TextBox textBox_edit_isbn_issn;
        private System.Windows.Forms.TextBox textBox_edit_state_instances;
        private System.Windows.Forms.Label label_isbn_issn;
        private System.Windows.Forms.Label label_state_instances;
        private System.Windows.Forms.Button button_edit;
    }
}