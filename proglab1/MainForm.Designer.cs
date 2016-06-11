namespace proglab1
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageMovies = new System.Windows.Forms.TabPage();
            this.DataGVMovie = new System.Windows.Forms.DataGridView();
            this.tabPageDirectors = new System.Windows.Forms.TabPage();
            this.DataGVDirector = new System.Windows.Forms.DataGridView();
            this.tabPageGenres = new System.Windows.Forms.TabPage();
            this.DataGVGenre = new System.Windows.Forms.DataGridView();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.AddMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DelMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nextEndButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.prevStartButton = new System.Windows.Forms.Button();
            this.prevButton = new System.Windows.Forms.Button();
            this.pageLabel = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabPageMovies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGVMovie)).BeginInit();
            this.tabPageDirectors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGVDirector)).BeginInit();
            this.tabPageGenres.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGVGenre)).BeginInit();
            this.MainMenu.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageMovies);
            this.tabControl.Controls.Add(this.tabPageDirectors);
            this.tabControl.Controls.Add(this.tabPageGenres);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(3, 3);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(578, 297);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabPageMovies
            // 
            this.tabPageMovies.Controls.Add(this.DataGVMovie);
            this.tabPageMovies.Location = new System.Drawing.Point(4, 22);
            this.tabPageMovies.Name = "tabPageMovies";
            this.tabPageMovies.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMovies.Size = new System.Drawing.Size(570, 271);
            this.tabPageMovies.TabIndex = 0;
            this.tabPageMovies.Text = "Фильмы";
            this.tabPageMovies.UseVisualStyleBackColor = true;
            // 
            // DataGVMovie
            // 
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DataGVMovie.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.DataGVMovie.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGVMovie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGVMovie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGVMovie.Location = new System.Drawing.Point(3, 3);
            this.DataGVMovie.Name = "DataGVMovie";
            this.DataGVMovie.Size = new System.Drawing.Size(564, 265);
            this.DataGVMovie.TabIndex = 0;
            // 
            // tabPageDirectors
            // 
            this.tabPageDirectors.Controls.Add(this.DataGVDirector);
            this.tabPageDirectors.Location = new System.Drawing.Point(4, 22);
            this.tabPageDirectors.Name = "tabPageDirectors";
            this.tabPageDirectors.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDirectors.Size = new System.Drawing.Size(570, 327);
            this.tabPageDirectors.TabIndex = 1;
            this.tabPageDirectors.Text = "Режиссеры";
            this.tabPageDirectors.UseVisualStyleBackColor = true;
            // 
            // DataGVDirector
            // 
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DataGVDirector.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle14;
            this.DataGVDirector.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGVDirector.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGVDirector.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGVDirector.Location = new System.Drawing.Point(3, 3);
            this.DataGVDirector.Name = "DataGVDirector";
            this.DataGVDirector.Size = new System.Drawing.Size(564, 321);
            this.DataGVDirector.TabIndex = 1;
            // 
            // tabPageGenres
            // 
            this.tabPageGenres.Controls.Add(this.DataGVGenre);
            this.tabPageGenres.Location = new System.Drawing.Point(4, 22);
            this.tabPageGenres.Name = "tabPageGenres";
            this.tabPageGenres.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGenres.Size = new System.Drawing.Size(570, 327);
            this.tabPageGenres.TabIndex = 2;
            this.tabPageGenres.Text = "Жанры";
            this.tabPageGenres.UseVisualStyleBackColor = true;
            // 
            // DataGVGenre
            // 
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DataGVGenre.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle15;
            this.DataGVGenre.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGVGenre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGVGenre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGVGenre.Location = new System.Drawing.Point(3, 3);
            this.DataGVGenre.Name = "DataGVGenre";
            this.DataGVGenre.Size = new System.Drawing.Size(564, 321);
            this.DataGVGenre.TabIndex = 2;
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddMenuItem,
            this.EditMenuItem,
            this.DelMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(584, 24);
            this.MainMenu.TabIndex = 1;
            this.MainMenu.Text = "menuStrip1";
            // 
            // AddMenuItem
            // 
            this.AddMenuItem.Name = "AddMenuItem";
            this.AddMenuItem.Size = new System.Drawing.Size(71, 20);
            this.AddMenuItem.Text = "Добавить";
            this.AddMenuItem.Click += new System.EventHandler(this.AddMenuItem_Click);
            // 
            // EditMenuItem
            // 
            this.EditMenuItem.Name = "EditMenuItem";
            this.EditMenuItem.Size = new System.Drawing.Size(99, 20);
            this.EditMenuItem.Text = "Редактировать";
            this.EditMenuItem.Click += new System.EventHandler(this.EditMenuItem_Click);
            // 
            // DelMenuItem
            // 
            this.DelMenuItem.Name = "DelMenuItem";
            this.DelMenuItem.Size = new System.Drawing.Size(63, 20);
            this.DelMenuItem.Text = "Удалить";
            this.DelMenuItem.Click += new System.EventHandler(this.DelMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tabControl, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(584, 331);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.nextEndButton);
            this.panel1.Controls.Add(this.nextButton);
            this.panel1.Controls.Add(this.prevStartButton);
            this.panel1.Controls.Add(this.prevButton);
            this.panel1.Controls.Add(this.pageLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 306);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(578, 22);
            this.panel1.TabIndex = 1;
            // 
            // nextEndButton
            // 
            this.nextEndButton.Location = new System.Drawing.Point(384, 0);
            this.nextEndButton.Margin = new System.Windows.Forms.Padding(0);
            this.nextEndButton.Name = "nextEndButton";
            this.nextEndButton.Size = new System.Drawing.Size(40, 22);
            this.nextEndButton.TabIndex = 4;
            this.nextEndButton.Text = ">>";
            this.nextEndButton.UseVisualStyleBackColor = true;
            this.nextEndButton.Click += new System.EventHandler(this.nextEndButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(354, 0);
            this.nextButton.Margin = new System.Windows.Forms.Padding(0);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(30, 22);
            this.nextButton.TabIndex = 3;
            this.nextButton.Text = ">";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // prevStartButton
            // 
            this.prevStartButton.Location = new System.Drawing.Point(162, 0);
            this.prevStartButton.Margin = new System.Windows.Forms.Padding(0);
            this.prevStartButton.Name = "prevStartButton";
            this.prevStartButton.Size = new System.Drawing.Size(40, 22);
            this.prevStartButton.TabIndex = 2;
            this.prevStartButton.Text = "<<";
            this.prevStartButton.UseVisualStyleBackColor = true;
            this.prevStartButton.Click += new System.EventHandler(this.prevStartButton_Click);
            // 
            // prevButton
            // 
            this.prevButton.Location = new System.Drawing.Point(202, 0);
            this.prevButton.Margin = new System.Windows.Forms.Padding(0);
            this.prevButton.Name = "prevButton";
            this.prevButton.Size = new System.Drawing.Size(30, 22);
            this.prevButton.TabIndex = 1;
            this.prevButton.Text = "<";
            this.prevButton.UseVisualStyleBackColor = true;
            this.prevButton.Click += new System.EventHandler(this.prevButton_Click);
            // 
            // pageLabel
            // 
            this.pageLabel.AutoSize = true;
            this.pageLabel.Location = new System.Drawing.Point(264, 3);
            this.pageLabel.Name = "pageLabel";
            this.pageLabel.Size = new System.Drawing.Size(57, 13);
            this.pageLabel.TabIndex = 0;
            this.pageLabel.Text = "1-20 / 100";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 355);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.MainMenu);
            this.MainMenuStrip = this.MainMenu;
            this.MaximumSize = new System.Drawing.Size(4096, 394);
            this.MinimumSize = new System.Drawing.Size(600, 394);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Кино";
            this.tabControl.ResumeLayout(false);
            this.tabPageMovies.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGVMovie)).EndInit();
            this.tabPageDirectors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGVDirector)).EndInit();
            this.tabPageGenres.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGVGenre)).EndInit();
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageMovies;
        private System.Windows.Forms.DataGridView DataGVMovie;
        private System.Windows.Forms.TabPage tabPageDirectors;
        private System.Windows.Forms.TabPage tabPageGenres;
        private System.Windows.Forms.DataGridView DataGVDirector;
        private System.Windows.Forms.DataGridView DataGVGenre;
        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem AddMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DelMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button prevButton;
        private System.Windows.Forms.Label pageLabel;
        private System.Windows.Forms.Button nextEndButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button prevStartButton;
    }
}

