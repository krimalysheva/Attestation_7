namespace L1_Form
{
    partial class MainWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.InputCompositionsDGV = new System.Windows.Forms.DataGridView();
            this.InputCompositionsDGV_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InputCompositionsDGV_Points = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InputCompositionsDGV_Genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SortCompositionsbttn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenuFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.countSoundbttn = new System.Windows.Forms.Button();
            this.countSoundlbl = new System.Windows.Forms.Label();
            this.Searchbttn = new System.Windows.Forms.Button();
            this.Fromnum = new System.Windows.Forms.NumericUpDown();
            this.Tonum = new System.Windows.Forms.NumericUpDown();
            this.searchlbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.InputCompositionsDGV)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Fromnum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tonum)).BeginInit();
            this.SuspendLayout();
            // 
            // InputCompositionsDGV
            // 
            this.InputCompositionsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InputCompositionsDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InputCompositionsDGV_Name,
            this.InputCompositionsDGV_Points,
            this.InputCompositionsDGV_Genre});
            this.InputCompositionsDGV.Location = new System.Drawing.Point(12, 27);
            this.InputCompositionsDGV.Name = "InputCompositionsDGV";
            this.InputCompositionsDGV.Size = new System.Drawing.Size(444, 327);
            this.InputCompositionsDGV.TabIndex = 0;
            // 
            // InputCompositionsDGV_Name
            // 
            this.InputCompositionsDGV_Name.HeaderText = "Композиция";
            this.InputCompositionsDGV_Name.Name = "InputCompositionsDGV_Name";
            this.InputCompositionsDGV_Name.Width = 200;
            // 
            // InputCompositionsDGV_Points
            // 
            this.InputCompositionsDGV_Points.HeaderText = "Длительность";
            this.InputCompositionsDGV_Points.Name = "InputCompositionsDGV_Points";
            // 
            // InputCompositionsDGV_Genre
            // 
            this.InputCompositionsDGV_Genre.HeaderText = "Жанр";
            this.InputCompositionsDGV_Genre.Name = "InputCompositionsDGV_Genre";
            // 
            // SortCompositionsbttn
            // 
            this.SortCompositionsbttn.Location = new System.Drawing.Point(13, 372);
            this.SortCompositionsbttn.Name = "SortCompositionsbttn";
            this.SortCompositionsbttn.Size = new System.Drawing.Size(387, 34);
            this.SortCompositionsbttn.TabIndex = 1;
            this.SortCompositionsbttn.Text = "Сортировать";
            this.SortCompositionsbttn.UseVisualStyleBackColor = true;
            this.SortCompositionsbttn.Click += new System.EventHandler(this.SortCompositionsbttn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(606, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainMenuFileOpen,
            this.MainMenuFileSave});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // MainMenuFileOpen
            // 
            this.MainMenuFileOpen.Name = "MainMenuFileOpen";
            this.MainMenuFileOpen.Size = new System.Drawing.Size(132, 22);
            this.MainMenuFileOpen.Text = "Открыть";
            this.MainMenuFileOpen.Click += new System.EventHandler(this.MainMenuFileOpen_Click);
            // 
            // MainMenuFileSave
            // 
            this.MainMenuFileSave.Name = "MainMenuFileSave";
            this.MainMenuFileSave.Size = new System.Drawing.Size(132, 22);
            this.MainMenuFileSave.Text = "Сохранить";
            this.MainMenuFileSave.Click += new System.EventHandler(this.MainMenuFileSave_Click);
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.FileName = "openFileDialog1";
            // 
            // countSoundbttn
            // 
            this.countSoundbttn.Location = new System.Drawing.Point(462, 42);
            this.countSoundbttn.Name = "countSoundbttn";
            this.countSoundbttn.Size = new System.Drawing.Size(132, 23);
            this.countSoundbttn.TabIndex = 3;
            this.countSoundbttn.Text = "Продолжительность: \r\n";
            this.countSoundbttn.UseVisualStyleBackColor = true;
            this.countSoundbttn.Click += new System.EventHandler(this.countSoundbttn_Click);
            // 
            // countSoundlbl
            // 
            this.countSoundlbl.AutoSize = true;
            this.countSoundlbl.Location = new System.Drawing.Point(511, 68);
            this.countSoundlbl.Name = "countSoundlbl";
            this.countSoundlbl.Size = new System.Drawing.Size(26, 13);
            this.countSoundlbl.TabIndex = 4;
            this.countSoundlbl.Text = "тык";
            // 
            // Searchbttn
            // 
            this.Searchbttn.Location = new System.Drawing.Point(463, 201);
            this.Searchbttn.Name = "Searchbttn";
            this.Searchbttn.Size = new System.Drawing.Size(132, 23);
            this.Searchbttn.TabIndex = 5;
            this.Searchbttn.Text = "Найти";
            this.Searchbttn.UseVisualStyleBackColor = true;
            this.Searchbttn.Click += new System.EventHandler(this.Searchbttn_Click);
            // 
            // Fromnum
            // 
            this.Fromnum.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.Fromnum.Location = new System.Drawing.Point(462, 139);
            this.Fromnum.Name = "Fromnum";
            this.Fromnum.Size = new System.Drawing.Size(131, 20);
            this.Fromnum.TabIndex = 6;
            this.Fromnum.ThousandsSeparator = true;
            // 
            // Tonum
            // 
            this.Tonum.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.Tonum.Location = new System.Drawing.Point(463, 175);
            this.Tonum.Name = "Tonum";
            this.Tonum.Size = new System.Drawing.Size(131, 20);
            this.Tonum.TabIndex = 7;
            this.Tonum.ThousandsSeparator = true;
            // 
            // searchlbl
            // 
            this.searchlbl.AutoSize = true;
            this.searchlbl.Location = new System.Drawing.Point(513, 227);
            this.searchlbl.Name = "searchlbl";
            this.searchlbl.Size = new System.Drawing.Size(24, 13);
            this.searchlbl.TabIndex = 8;
            this.searchlbl.Text = "пук";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 411);
            this.Controls.Add(this.searchlbl);
            this.Controls.Add(this.Tonum);
            this.Controls.Add(this.Fromnum);
            this.Controls.Add(this.Searchbttn);
            this.Controls.Add(this.countSoundlbl);
            this.Controls.Add(this.countSoundbttn);
            this.Controls.Add(this.SortCompositionsbttn);
            this.Controls.Add(this.InputCompositionsDGV);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "L1";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InputCompositionsDGV)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Fromnum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tonum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView InputCompositionsDGV;
        private System.Windows.Forms.Button SortCompositionsbttn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MainMenuFileOpen;
        private System.Windows.Forms.ToolStripMenuItem MainMenuFileSave;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
        private System.Windows.Forms.Button countSoundbttn;
        private System.Windows.Forms.Label countSoundlbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn InputCompositionsDGV_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn InputCompositionsDGV_Points;
        private System.Windows.Forms.DataGridViewTextBoxColumn InputCompositionsDGV_Genre;
        private System.Windows.Forms.Button Searchbttn;
        private System.Windows.Forms.NumericUpDown Fromnum;
        private System.Windows.Forms.NumericUpDown Tonum;
        private System.Windows.Forms.Label searchlbl;
    }
}

