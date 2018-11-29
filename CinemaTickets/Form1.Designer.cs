namespace CinemaTickets
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
            this.Panel_MainMenu = new System.Windows.Forms.Panel();
            this.Panel_LabelInMainMenu = new System.Windows.Forms.Panel();
            this.Label_TitleMainText = new System.Windows.Forms.Label();
            this.MenuButton_Search = new System.Windows.Forms.Button();
            this.MenuButton_Exit = new System.Windows.Forms.Button();
            this.MenuButton_StatisticsAndReport = new System.Windows.Forms.Button();
            this.MenuButton_Films = new System.Windows.Forms.Button();
            this.Panel_Films = new System.Windows.Forms.Panel();
            this.Panel_ViewListFilms = new System.Windows.Forms.Panel();
            this.pictureBox_1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Panel_StatisticsAndReport = new System.Windows.Forms.Panel();
            this.Panel_Search = new System.Windows.Forms.Panel();
            this.Panel_MainScreen = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Panel_MainMenu.SuspendLayout();
            this.Panel_LabelInMainMenu.SuspendLayout();
            this.Panel_Films.SuspendLayout();
            this.Panel_ViewListFilms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_1)).BeginInit();
            this.Panel_MainScreen.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_MainMenu
            // 
            this.Panel_MainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.Panel_MainMenu.Controls.Add(this.Panel_LabelInMainMenu);
            this.Panel_MainMenu.Controls.Add(this.MenuButton_Search);
            this.Panel_MainMenu.Controls.Add(this.MenuButton_Exit);
            this.Panel_MainMenu.Controls.Add(this.MenuButton_StatisticsAndReport);
            this.Panel_MainMenu.Controls.Add(this.MenuButton_Films);
            this.Panel_MainMenu.ForeColor = System.Drawing.Color.Crimson;
            this.Panel_MainMenu.Location = new System.Drawing.Point(0, 0);
            this.Panel_MainMenu.Name = "Panel_MainMenu";
            this.Panel_MainMenu.Size = new System.Drawing.Size(215, 600);
            this.Panel_MainMenu.TabIndex = 0;
            // 
            // Panel_LabelInMainMenu
            // 
            this.Panel_LabelInMainMenu.BackColor = System.Drawing.Color.Gainsboro;
            this.Panel_LabelInMainMenu.Controls.Add(this.Label_TitleMainText);
            this.Panel_LabelInMainMenu.Location = new System.Drawing.Point(-1, -1);
            this.Panel_LabelInMainMenu.Name = "Panel_LabelInMainMenu";
            this.Panel_LabelInMainMenu.Size = new System.Drawing.Size(214, 79);
            this.Panel_LabelInMainMenu.TabIndex = 9;
            // 
            // Label_TitleMainText
            // 
            this.Label_TitleMainText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
            this.Label_TitleMainText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label_TitleMainText.Font = new System.Drawing.Font("Righteous", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_TitleMainText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(23)))), ((int)(((byte)(79)))));
            this.Label_TitleMainText.Location = new System.Drawing.Point(0, 0);
            this.Label_TitleMainText.Name = "Label_TitleMainText";
            this.Label_TitleMainText.Size = new System.Drawing.Size(214, 79);
            this.Label_TitleMainText.TabIndex = 1;
            this.Label_TitleMainText.Text = "CinemaTickets";
            this.Label_TitleMainText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label_TitleMainText.Click += new System.EventHandler(this.Label_TitleMainText_Click);
            // 
            // MenuButton_Search
            // 
            this.MenuButton_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(105)))));
            this.MenuButton_Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MenuButton_Search.FlatAppearance.BorderSize = 0;
            this.MenuButton_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuButton_Search.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MenuButton_Search.ForeColor = System.Drawing.Color.White;
            this.MenuButton_Search.Location = new System.Drawing.Point(0, 164);
            this.MenuButton_Search.Name = "MenuButton_Search";
            this.MenuButton_Search.Size = new System.Drawing.Size(214, 40);
            this.MenuButton_Search.TabIndex = 4;
            this.MenuButton_Search.Text = "Поиск";
            this.MenuButton_Search.UseVisualStyleBackColor = false;
            this.MenuButton_Search.Click += new System.EventHandler(this.MenuButton_Search_Click);
            // 
            // MenuButton_Exit
            // 
            this.MenuButton_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(105)))));
            this.MenuButton_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MenuButton_Exit.FlatAppearance.BorderSize = 0;
            this.MenuButton_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuButton_Exit.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MenuButton_Exit.ForeColor = System.Drawing.Color.White;
            this.MenuButton_Exit.Location = new System.Drawing.Point(0, 560);
            this.MenuButton_Exit.Name = "MenuButton_Exit";
            this.MenuButton_Exit.Size = new System.Drawing.Size(214, 40);
            this.MenuButton_Exit.TabIndex = 5;
            this.MenuButton_Exit.Text = "Выход";
            this.MenuButton_Exit.UseVisualStyleBackColor = false;
            this.MenuButton_Exit.Click += new System.EventHandler(this.MenuButton_Exit_Click);
            // 
            // MenuButton_StatisticsAndReport
            // 
            this.MenuButton_StatisticsAndReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(105)))));
            this.MenuButton_StatisticsAndReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MenuButton_StatisticsAndReport.FlatAppearance.BorderSize = 0;
            this.MenuButton_StatisticsAndReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuButton_StatisticsAndReport.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MenuButton_StatisticsAndReport.ForeColor = System.Drawing.Color.White;
            this.MenuButton_StatisticsAndReport.Location = new System.Drawing.Point(0, 122);
            this.MenuButton_StatisticsAndReport.Name = "MenuButton_StatisticsAndReport";
            this.MenuButton_StatisticsAndReport.Size = new System.Drawing.Size(214, 40);
            this.MenuButton_StatisticsAndReport.TabIndex = 3;
            this.MenuButton_StatisticsAndReport.Text = "Статистика и отчеты";
            this.MenuButton_StatisticsAndReport.UseVisualStyleBackColor = false;
            this.MenuButton_StatisticsAndReport.Click += new System.EventHandler(this.MenuButton_StatisticsAndReport_Click);
            // 
            // MenuButton_Films
            // 
            this.MenuButton_Films.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(105)))));
            this.MenuButton_Films.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MenuButton_Films.FlatAppearance.BorderSize = 0;
            this.MenuButton_Films.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuButton_Films.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MenuButton_Films.ForeColor = System.Drawing.Color.White;
            this.MenuButton_Films.Location = new System.Drawing.Point(0, 80);
            this.MenuButton_Films.Name = "MenuButton_Films";
            this.MenuButton_Films.Size = new System.Drawing.Size(214, 40);
            this.MenuButton_Films.TabIndex = 2;
            this.MenuButton_Films.Text = "Фильмы";
            this.MenuButton_Films.UseVisualStyleBackColor = false;
            this.MenuButton_Films.Click += new System.EventHandler(this.MenuButton_Films_Click);
            // 
            // Panel_Films
            // 
            this.Panel_Films.Controls.Add(this.Panel_ViewListFilms);
            this.Panel_Films.Controls.Add(this.label2);
            this.Panel_Films.Location = new System.Drawing.Point(215, 0);
            this.Panel_Films.Name = "Panel_Films";
            this.Panel_Films.Size = new System.Drawing.Size(750, 600);
            this.Panel_Films.TabIndex = 1;
            // 
            // Panel_ViewListFilms
            // 
            this.Panel_ViewListFilms.AutoScroll = true;
            this.Panel_ViewListFilms.Controls.Add(this.pictureBox_1);
            this.Panel_ViewListFilms.Location = new System.Drawing.Point(3, 3);
            this.Panel_ViewListFilms.Name = "Panel_ViewListFilms";
            this.Panel_ViewListFilms.Size = new System.Drawing.Size(761, 497);
            this.Panel_ViewListFilms.TabIndex = 9;
            // 
            // pictureBox_1
            // 
            this.pictureBox_1.Location = new System.Drawing.Point(30, 30);
            this.pictureBox_1.Name = "pictureBox_1";
            this.pictureBox_1.Size = new System.Drawing.Size(150, 200);
            this.pictureBox_1.TabIndex = 0;
            this.pictureBox_1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 520);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "label2";
            // 
            // Panel_StatisticsAndReport
            // 
            this.Panel_StatisticsAndReport.Location = new System.Drawing.Point(215, 0);
            this.Panel_StatisticsAndReport.Name = "Panel_StatisticsAndReport";
            this.Panel_StatisticsAndReport.Size = new System.Drawing.Size(750, 600);
            this.Panel_StatisticsAndReport.TabIndex = 2;
            // 
            // Panel_Search
            // 
            this.Panel_Search.Location = new System.Drawing.Point(215, 0);
            this.Panel_Search.Name = "Panel_Search";
            this.Panel_Search.Size = new System.Drawing.Size(750, 600);
            this.Panel_Search.TabIndex = 3;
            // 
            // Panel_MainScreen
            // 
            this.Panel_MainScreen.Controls.Add(this.label1);
            this.Panel_MainScreen.Location = new System.Drawing.Point(215, 0);
            this.Panel_MainScreen.Name = "Panel_MainScreen";
            this.Panel_MainScreen.Size = new System.Drawing.Size(750, 600);
            this.Panel_MainScreen.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(335, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 600);
            this.ControlBox = false;
            this.Controls.Add(this.Panel_MainMenu);
            this.Controls.Add(this.Panel_Films);
            this.Controls.Add(this.Panel_Search);
            this.Controls.Add(this.Panel_MainScreen);
            this.Controls.Add(this.Panel_StatisticsAndReport);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Panel_MainMenu.ResumeLayout(false);
            this.Panel_LabelInMainMenu.ResumeLayout(false);
            this.Panel_Films.ResumeLayout(false);
            this.Panel_Films.PerformLayout();
            this.Panel_ViewListFilms.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_1)).EndInit();
            this.Panel_MainScreen.ResumeLayout(false);
            this.Panel_MainScreen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_MainMenu;
        private System.Windows.Forms.Button MenuButton_Search;
        private System.Windows.Forms.Button MenuButton_Exit;
        private System.Windows.Forms.Button MenuButton_StatisticsAndReport;
        private System.Windows.Forms.Button MenuButton_Films;
        private System.Windows.Forms.Label Label_TitleMainText;
        private System.Windows.Forms.Panel Panel_LabelInMainMenu;
        private System.Windows.Forms.Panel Panel_Films;
        private System.Windows.Forms.Panel Panel_StatisticsAndReport;
        private System.Windows.Forms.Panel Panel_Search;
        private System.Windows.Forms.Panel Panel_MainScreen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel Panel_ViewListFilms;
        private System.Windows.Forms.PictureBox pictureBox_1;
    }
}

