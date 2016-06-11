namespace proglab1
{
    partial class AddDirectorForm
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
            this.AddButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.direc = new System.Windows.Forms.Label();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.DayTextBox = new System.Windows.Forms.TextBox();
            this.MonthTextBox = new System.Windows.Forms.TextBox();
            this.YearTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(217, 82);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 14;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Дата рождения:";
            // 
            // direc
            // 
            this.direc.AutoSize = true;
            this.direc.Location = new System.Drawing.Point(12, 13);
            this.direc.Name = "direc";
            this.direc.Size = new System.Drawing.Size(29, 13);
            this.direc.TabIndex = 12;
            this.direc.Text = "Имя";
            // 
            // NameTB
            // 
            this.NameTB.Location = new System.Drawing.Point(110, 10);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(182, 20);
            this.NameTB.TabIndex = 11;
            // 
            // DayTextBox
            // 
            this.DayTextBox.Location = new System.Drawing.Point(110, 40);
            this.DayTextBox.Name = "DayTextBox";
            this.DayTextBox.Size = new System.Drawing.Size(32, 20);
            this.DayTextBox.TabIndex = 18;
            // 
            // MonthTextBox
            // 
            this.MonthTextBox.Location = new System.Drawing.Point(148, 40);
            this.MonthTextBox.Name = "MonthTextBox";
            this.MonthTextBox.Size = new System.Drawing.Size(32, 20);
            this.MonthTextBox.TabIndex = 19;
            // 
            // YearTextBox
            // 
            this.YearTextBox.Location = new System.Drawing.Point(186, 40);
            this.YearTextBox.Name = "YearTextBox";
            this.YearTextBox.Size = new System.Drawing.Size(40, 20);
            this.YearTextBox.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(232, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "(дд.мм.гггг)";
            // 
            // AddDirectorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 117);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.YearTextBox);
            this.Controls.Add(this.MonthTextBox);
            this.Controls.Add(this.DayTextBox);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.direc);
            this.Controls.Add(this.NameTB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddDirectorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить режиссера";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label direc;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.TextBox DayTextBox;
        private System.Windows.Forms.TextBox MonthTextBox;
        private System.Windows.Forms.TextBox YearTextBox;
        private System.Windows.Forms.Label label3;
    }
}