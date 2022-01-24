namespace diploma
{
    partial class Form_user_debts_add
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
            this.cueTextBox_code_instance = new CueTextBox();
            this.dateTP_issue_up_to = new System.Windows.Forms.DateTimePicker();
            this.label_issue_before = new System.Windows.Forms.Label();
            this.button_debts_add = new System.Windows.Forms.Button();
            this._focus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cueTextBox_code_instance
            // 
            this.cueTextBox_code_instance.Cue = "Введите код экземпляра";
            this.cueTextBox_code_instance.Location = new System.Drawing.Point(12, 12);
            this.cueTextBox_code_instance.Name = "cueTextBox_code_instance";
            this.cueTextBox_code_instance.Size = new System.Drawing.Size(172, 20);
            this.cueTextBox_code_instance.TabIndex = 0;
            // 
            // dateTP_issue_up_to
            // 
            this.dateTP_issue_up_to.Checked = false;
            this.dateTP_issue_up_to.CustomFormat = "yyyy-MM-dd";
            this.dateTP_issue_up_to.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTP_issue_up_to.Location = new System.Drawing.Point(85, 38);
            this.dateTP_issue_up_to.Name = "dateTP_issue_up_to";
            this.dateTP_issue_up_to.Size = new System.Drawing.Size(99, 20);
            this.dateTP_issue_up_to.TabIndex = 1;
            // 
            // label_issue_before
            // 
            this.label_issue_before.AutoSize = true;
            this.label_issue_before.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_issue_before.Location = new System.Drawing.Point(12, 44);
            this.label_issue_before.Name = "label_issue_before";
            this.label_issue_before.Size = new System.Drawing.Size(63, 13);
            this.label_issue_before.TabIndex = 4;
            this.label_issue_before.Text = "Выдать до:";
            // 
            // button_debts_add
            // 
            this.button_debts_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_debts_add.Font = new System.Drawing.Font("Sitka Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_debts_add.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button_debts_add.Location = new System.Drawing.Point(78, 64);
            this.button_debts_add.Name = "button_debts_add";
            this.button_debts_add.Size = new System.Drawing.Size(106, 31);
            this.button_debts_add.TabIndex = 32;
            this.button_debts_add.Text = "Добавить";
            this.button_debts_add.UseVisualStyleBackColor = true;
            this.button_debts_add.Click += new System.EventHandler(this.button_debts_add_Click);
            // 
            // _focus
            // 
            this._focus.Location = new System.Drawing.Point(180, 66);
            this._focus.Name = "_focus";
            this._focus.Size = new System.Drawing.Size(2, 2);
            this._focus.TabIndex = 33;
            this._focus.Text = "button1";
            this._focus.UseVisualStyleBackColor = true;
            // 
            // Form_user_debts_add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(195, 101);
            this.Controls.Add(this._focus);
            this.Controls.Add(this.button_debts_add);
            this.Controls.Add(this.label_issue_before);
            this.Controls.Add(this.dateTP_issue_up_to);
            this.Controls.Add(this.cueTextBox_code_instance);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_user_debts_add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить книгу";
            this.Load += new System.EventHandler(this.Form_user_debts_add_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CueTextBox cueTextBox_code_instance;
        private System.Windows.Forms.DateTimePicker dateTP_issue_up_to;
        private System.Windows.Forms.Label label_issue_before;
        private System.Windows.Forms.Button button_debts_add;
        private System.Windows.Forms.Button _focus;
    }
}