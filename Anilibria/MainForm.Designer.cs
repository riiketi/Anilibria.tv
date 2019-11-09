namespace Anilibria
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.InputURL_tb = new System.Windows.Forms.TextBox();
            this.Start_btn = new System.Windows.Forms.Button();
            this.Output_dataGridView = new System.Windows.Forms.DataGridView();
            this.Title_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.URL_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Search_btn = new System.Windows.Forms.Button();
            this.SearchInput_tb = new System.Windows.Forms.TextBox();
            this.Prev_btn = new System.Windows.Forms.Button();
            this.Next_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.GetList_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Download_btn = new System.Windows.Forms.Button();
            this.Play_btn = new System.Windows.Forms.Button();
            this.webBrowser2 = new System.Windows.Forms.WebBrowser();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.process1 = new System.Diagnostics.Process();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.Output_dataGridView)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // InputURL_tb
            // 
            this.InputURL_tb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputURL_tb.Location = new System.Drawing.Point(6, 6);
            this.InputURL_tb.Name = "InputURL_tb";
            this.InputURL_tb.Size = new System.Drawing.Size(499, 20);
            this.InputURL_tb.TabIndex = 0;
            this.InputURL_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputURL_tb_KeyDown);
            // 
            // Start_btn
            // 
            this.Start_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Start_btn.Location = new System.Drawing.Point(511, 6);
            this.Start_btn.Name = "Start_btn";
            this.Start_btn.Size = new System.Drawing.Size(75, 20);
            this.Start_btn.TabIndex = 1;
            this.Start_btn.Text = "Start";
            this.Start_btn.UseVisualStyleBackColor = true;
            this.Start_btn.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Output_dataGridView
            // 
            this.Output_dataGridView.AllowUserToAddRows = false;
            this.Output_dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Output_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Output_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Title_Column,
            this.URL_Column});
            this.Output_dataGridView.Location = new System.Drawing.Point(6, 32);
            this.Output_dataGridView.MultiSelect = false;
            this.Output_dataGridView.Name = "Output_dataGridView";
            this.Output_dataGridView.RowHeadersVisible = false;
            this.Output_dataGridView.Size = new System.Drawing.Size(742, 308);
            this.Output_dataGridView.TabIndex = 2;
            this.Output_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Output_dataGridView_CellContentClick);
            this.Output_dataGridView.CellStateChanged += new System.Windows.Forms.DataGridViewCellStateChangedEventHandler(this.Output_dataGridView_CellStateChanged);
            // 
            // Title_Column
            // 
            this.Title_Column.HeaderText = "Title";
            this.Title_Column.Name = "Title_Column";
            this.Title_Column.ReadOnly = true;
            this.Title_Column.Width = 200;
            // 
            // URL_Column
            // 
            this.URL_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.URL_Column.HeaderText = "URL";
            this.URL_Column.Name = "URL_Column";
            this.URL_Column.ReadOnly = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControl1.Location = new System.Drawing.Point(2, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(762, 402);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Search_btn);
            this.tabPage2.Controls.Add(this.SearchInput_tb);
            this.tabPage2.Controls.Add(this.Prev_btn);
            this.tabPage2.Controls.Add(this.Next_btn);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.GetList_btn);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.webBrowser1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(754, 376);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Список тайтлов";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Search_btn
            // 
            this.Search_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Search_btn.Location = new System.Drawing.Point(625, 4);
            this.Search_btn.Name = "Search_btn";
            this.Search_btn.Size = new System.Drawing.Size(123, 20);
            this.Search_btn.TabIndex = 14;
            this.Search_btn.Text = "Поиск";
            this.Search_btn.UseVisualStyleBackColor = true;
            this.Search_btn.Click += new System.EventHandler(this.Search_btn_Click);
            // 
            // SearchInput_tb
            // 
            this.SearchInput_tb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchInput_tb.Location = new System.Drawing.Point(7, 4);
            this.SearchInput_tb.Name = "SearchInput_tb";
            this.SearchInput_tb.Size = new System.Drawing.Size(612, 20);
            this.SearchInput_tb.TabIndex = 13;
            this.SearchInput_tb.TextChanged += new System.EventHandler(this.SearchInput_tb_TextChanged);
            this.SearchInput_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchInput_tb_KeyDown);
            // 
            // Prev_btn
            // 
            this.Prev_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Prev_btn.Location = new System.Drawing.Point(6, 348);
            this.Prev_btn.Name = "Prev_btn";
            this.Prev_btn.Size = new System.Drawing.Size(75, 22);
            this.Prev_btn.TabIndex = 12;
            this.Prev_btn.Text = "Назад";
            this.Prev_btn.UseVisualStyleBackColor = true;
            this.Prev_btn.Click += new System.EventHandler(this.Prev_btn_Click_1);
            // 
            // Next_btn
            // 
            this.Next_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Next_btn.Location = new System.Drawing.Point(87, 348);
            this.Next_btn.Name = "Next_btn";
            this.Next_btn.Size = new System.Drawing.Size(75, 22);
            this.Next_btn.TabIndex = 11;
            this.Next_btn.Text = "Вперёд";
            this.Next_btn.UseVisualStyleBackColor = true;
            this.Next_btn.Click += new System.EventHandler(this.Next_btn_Click_1);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(168, 348);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 22);
            this.button1.TabIndex = 10;
            this.button1.Text = "Обновить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // GetList_btn
            // 
            this.GetList_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.GetList_btn.Location = new System.Drawing.Point(589, 347);
            this.GetList_btn.Name = "GetList_btn";
            this.GetList_btn.Size = new System.Drawing.Size(159, 22);
            this.GetList_btn.TabIndex = 7;
            this.GetList_btn.Text = "Get List";
            this.GetList_btn.UseVisualStyleBackColor = true;
            this.GetList_btn.Click += new System.EventHandler(this.GetList_btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dataGridView1.Location = new System.Drawing.Point(6, 31);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(742, 311);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Title";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "URL";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(597, 182);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(20, 20);
            this.webBrowser1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Download_btn);
            this.tabPage1.Controls.Add(this.Play_btn);
            this.tabPage1.Controls.Add(this.Start_btn);
            this.tabPage1.Controls.Add(this.InputURL_tb);
            this.tabPage1.Controls.Add(this.Output_dataGridView);
            this.tabPage1.Controls.Add(this.webBrowser2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(754, 376);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Список серий";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Download_btn
            // 
            this.Download_btn.Enabled = false;
            this.Download_btn.Location = new System.Drawing.Point(673, 6);
            this.Download_btn.Name = "Download_btn";
            this.Download_btn.Size = new System.Drawing.Size(75, 20);
            this.Download_btn.TabIndex = 5;
            this.Download_btn.Text = "Download";
            this.Download_btn.UseVisualStyleBackColor = true;
            this.Download_btn.Click += new System.EventHandler(this.Download_btn_Click);
            // 
            // Play_btn
            // 
            this.Play_btn.Enabled = false;
            this.Play_btn.Location = new System.Drawing.Point(592, 6);
            this.Play_btn.Name = "Play_btn";
            this.Play_btn.Size = new System.Drawing.Size(75, 20);
            this.Play_btn.TabIndex = 4;
            this.Play_btn.Text = "Play";
            this.Play_btn.UseVisualStyleBackColor = true;
            this.Play_btn.Click += new System.EventHandler(this.Play_btn_Click);
            // 
            // webBrowser2
            // 
            this.webBrowser2.Location = new System.Drawing.Point(6, 227);
            this.webBrowser2.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser2.Name = "webBrowser2";
            this.webBrowser2.ScriptErrorsSuppressed = true;
            this.webBrowser2.Size = new System.Drawing.Size(20, 20);
            this.webBrowser2.TabIndex = 3;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.axWindowsMediaPlayer1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(754, 376);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Плеер";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(6, 6);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(742, 364);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(766, 407);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Anilibria.TV";
            ((System.ComponentModel.ISupportInitialize)(this.Output_dataGridView)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox InputURL_tb;
        private System.Windows.Forms.Button Start_btn;
        private System.Windows.Forms.DataGridView Output_dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn URL_Column;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Diagnostics.Process process1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button GetList_btn;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.WebBrowser webBrowser2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Prev_btn;
        private System.Windows.Forms.Button Next_btn;
        private System.Windows.Forms.Button Search_btn;
        private System.Windows.Forms.TextBox SearchInput_tb;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button Download_btn;
        private System.Windows.Forms.Button Play_btn;
        public AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}

