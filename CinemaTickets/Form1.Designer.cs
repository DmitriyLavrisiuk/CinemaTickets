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
            this.Label_PageInfo = new MetroFramework.Controls.MetroLabel();
            this.Button_SearchFilms_Next = new MetroFramework.Controls.MetroButton();
            this.Button_SearchFilms_Back = new MetroFramework.Controls.MetroButton();
            this.ComboBox_Year = new MetroFramework.Controls.MetroComboBox();
            this.Button_SearchFilms = new MetroFramework.Controls.MetroButton();
            this.ComboBox_Gener = new MetroFramework.Controls.MetroComboBox();
            this.Panel_ViewListFilms = new System.Windows.Forms.Panel();
            this.MainTitle_Panel_Films = new MetroFramework.Controls.MetroLabel();
            this.Panel_StatisticsAndReport = new System.Windows.Forms.Panel();
            this.Label_Title_Panel_StatisticsAndReport = new MetroFramework.Controls.MetroLabel();
            this.Panel_Search = new System.Windows.Forms.Panel();
            this.Label_Title_Panel_Search = new MetroFramework.Controls.MetroLabel();
            this.Panel_MainScreen = new System.Windows.Forms.Panel();
            this.Label_Title_Panel_MainScreen = new MetroFramework.Controls.MetroLabel();
            this.Panel_MainMenu.SuspendLayout();
            this.Panel_LabelInMainMenu.SuspendLayout();
            this.Panel_Films.SuspendLayout();
            this.Panel_ViewListFilms.SuspendLayout();
            this.Panel_StatisticsAndReport.SuspendLayout();
            this.Panel_Search.SuspendLayout();
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
            this.Label_TitleMainText.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.MenuButton_Search.Location = new System.Drawing.Point(0, 161);
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
            this.MenuButton_Exit.Location = new System.Drawing.Point(0, 559);
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
            this.MenuButton_StatisticsAndReport.Location = new System.Drawing.Point(0, 120);
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
            this.MenuButton_Films.Location = new System.Drawing.Point(0, 79);
            this.MenuButton_Films.Name = "MenuButton_Films";
            this.MenuButton_Films.Size = new System.Drawing.Size(214, 40);
            this.MenuButton_Films.TabIndex = 2;
            this.MenuButton_Films.Text = "Фильмы";
            this.MenuButton_Films.UseVisualStyleBackColor = false;
            this.MenuButton_Films.Click += new System.EventHandler(this.MenuButton_Films_Click);
            // 
            // Panel_Films
            // 
            this.Panel_Films.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.Panel_Films.Controls.Add(this.Label_PageInfo);
            this.Panel_Films.Controls.Add(this.Button_SearchFilms_Next);
            this.Panel_Films.Controls.Add(this.Button_SearchFilms_Back);
            this.Panel_Films.Controls.Add(this.ComboBox_Year);
            this.Panel_Films.Controls.Add(this.Button_SearchFilms);
            this.Panel_Films.Controls.Add(this.ComboBox_Gener);
            this.Panel_Films.Controls.Add(this.Panel_ViewListFilms);
            this.Panel_Films.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Panel_Films.Location = new System.Drawing.Point(215, 0);
            this.Panel_Films.Name = "Panel_Films";
            this.Panel_Films.Size = new System.Drawing.Size(750, 600);
            this.Panel_Films.TabIndex = 1;
            // 
            // Label_PageInfo
            // 
            this.Label_PageInfo.BackColor = System.Drawing.Color.Gainsboro;
            this.Label_PageInfo.CausesValidation = false;
            this.Label_PageInfo.FontSize = MetroFramework.MetroLabelSize.Small;
            this.Label_PageInfo.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.Label_PageInfo.Location = new System.Drawing.Point(648, 550);
            this.Label_PageInfo.Name = "Label_PageInfo";
            this.Label_PageInfo.Size = new System.Drawing.Size(79, 29);
            this.Label_PageInfo.TabIndex = 6;
            this.Label_PageInfo.Text = "Стр [?/?]";
            this.Label_PageInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Button_SearchFilms_Next
            // 
            this.Button_SearchFilms_Next.Location = new System.Drawing.Point(553, 550);
            this.Button_SearchFilms_Next.Name = "Button_SearchFilms_Next";
            this.Button_SearchFilms_Next.Size = new System.Drawing.Size(89, 29);
            this.Button_SearchFilms_Next.TabIndex = 5;
            this.Button_SearchFilms_Next.Text = "Вперед";
            // 
            // Button_SearchFilms_Back
            // 
            this.Button_SearchFilms_Back.Location = new System.Drawing.Point(458, 550);
            this.Button_SearchFilms_Back.Name = "Button_SearchFilms_Back";
            this.Button_SearchFilms_Back.Size = new System.Drawing.Size(89, 29);
            this.Button_SearchFilms_Back.TabIndex = 4;
            this.Button_SearchFilms_Back.Text = "Назад";
            // 
            // ComboBox_Year
            // 
            this.ComboBox_Year.FormattingEnabled = true;
            this.ComboBox_Year.ItemHeight = 23;
            this.ComboBox_Year.Items.AddRange(new object[] {
            "Все",
            "Самые новые",
            "2016 - 2018",
            "2012 - 2016",
            "2008 - 2012",
            "2006 - 2008",
            "2002 - 2006",
            "2000 - 2002",
            "1990 - 2000",
            "Более поздние"});
            this.ComboBox_Year.Location = new System.Drawing.Point(163, 550);
            this.ComboBox_Year.Name = "ComboBox_Year";
            this.ComboBox_Year.Size = new System.Drawing.Size(121, 29);
            this.ComboBox_Year.TabIndex = 2;
            // 
            // Button_SearchFilms
            // 
            this.Button_SearchFilms.Location = new System.Drawing.Point(290, 550);
            this.Button_SearchFilms.Name = "Button_SearchFilms";
            this.Button_SearchFilms.Size = new System.Drawing.Size(162, 29);
            this.Button_SearchFilms.TabIndex = 3;
            this.Button_SearchFilms.Text = "Искать";
            this.Button_SearchFilms.Click += new System.EventHandler(this.Button_SearchFilms_Click);
            // 
            // ComboBox_Gener
            // 
            this.ComboBox_Gener.FormattingEnabled = true;
            this.ComboBox_Gener.ItemHeight = 23;
            this.ComboBox_Gener.Items.AddRange(new object[] {
            "Все жанры"});
            this.ComboBox_Gener.Location = new System.Drawing.Point(19, 550);
            this.ComboBox_Gener.Name = "ComboBox_Gener";
            this.ComboBox_Gener.Size = new System.Drawing.Size(138, 29);
            this.ComboBox_Gener.TabIndex = 1;
            // 
            // Panel_ViewListFilms
            // 
            this.Panel_ViewListFilms.AutoScroll = true;
            this.Panel_ViewListFilms.BackColor = System.Drawing.Color.White;
            this.Panel_ViewListFilms.Controls.Add(this.MainTitle_Panel_Films);
            this.Panel_ViewListFilms.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Panel_ViewListFilms.Location = new System.Drawing.Point(0, 0);
            this.Panel_ViewListFilms.Name = "Panel_ViewListFilms";
            this.Panel_ViewListFilms.Padding = new System.Windows.Forms.Padding(0, 0, 0, 440);
            this.Panel_ViewListFilms.Size = new System.Drawing.Size(770, 530);
            this.Panel_ViewListFilms.TabIndex = 9;
            // 
            // MainTitle_Panel_Films
            // 
            this.MainTitle_Panel_Films.Cursor = System.Windows.Forms.Cursors.Help;
            this.MainTitle_Panel_Films.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.MainTitle_Panel_Films.Location = new System.Drawing.Point(1, 1);
            this.MainTitle_Panel_Films.Name = "MainTitle_Panel_Films";
            this.MainTitle_Panel_Films.Size = new System.Drawing.Size(768, 528);
            this.MainTitle_Panel_Films.TabIndex = 0;
            this.MainTitle_Panel_Films.Text = "Для просмотра подходящих вам результатов выберите жанр и год ниже.";
            this.MainTitle_Panel_Films.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Panel_StatisticsAndReport
            // 
            this.Panel_StatisticsAndReport.Controls.Add(this.Label_Title_Panel_StatisticsAndReport);
            this.Panel_StatisticsAndReport.Location = new System.Drawing.Point(215, 0);
            this.Panel_StatisticsAndReport.Name = "Panel_StatisticsAndReport";
            this.Panel_StatisticsAndReport.Size = new System.Drawing.Size(750, 600);
            this.Panel_StatisticsAndReport.TabIndex = 2;
            // 
            // Label_Title_Panel_StatisticsAndReport
            // 
            this.Label_Title_Panel_StatisticsAndReport.Cursor = System.Windows.Forms.Cursors.Help;
            this.Label_Title_Panel_StatisticsAndReport.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.Label_Title_Panel_StatisticsAndReport.Location = new System.Drawing.Point(0, 0);
            this.Label_Title_Panel_StatisticsAndReport.Name = "Label_Title_Panel_StatisticsAndReport";
            this.Label_Title_Panel_StatisticsAndReport.Size = new System.Drawing.Size(750, 79);
            this.Label_Title_Panel_StatisticsAndReport.TabIndex = 2;
            this.Label_Title_Panel_StatisticsAndReport.Text = "Статистика и отчеты";
            this.Label_Title_Panel_StatisticsAndReport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Panel_Search
            // 
            this.Panel_Search.Controls.Add(this.Label_Title_Panel_Search);
            this.Panel_Search.Location = new System.Drawing.Point(215, 0);
            this.Panel_Search.Name = "Panel_Search";
            this.Panel_Search.Size = new System.Drawing.Size(750, 600);
            this.Panel_Search.TabIndex = 3;
            // 
            // Label_Title_Panel_Search
            // 
            this.Label_Title_Panel_Search.Cursor = System.Windows.Forms.Cursors.Help;
            this.Label_Title_Panel_Search.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.Label_Title_Panel_Search.Location = new System.Drawing.Point(0, 0);
            this.Label_Title_Panel_Search.Name = "Label_Title_Panel_Search";
            this.Label_Title_Panel_Search.Size = new System.Drawing.Size(750, 79);
            this.Label_Title_Panel_Search.TabIndex = 1;
            this.Label_Title_Panel_Search.Text = "Поиск";
            this.Label_Title_Panel_Search.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Panel_MainScreen
            // 
            this.Panel_MainScreen.Controls.Add(this.Label_Title_Panel_MainScreen);
            this.Panel_MainScreen.Location = new System.Drawing.Point(215, 0);
            this.Panel_MainScreen.Name = "Panel_MainScreen";
            this.Panel_MainScreen.Size = new System.Drawing.Size(750, 600);
            this.Panel_MainScreen.TabIndex = 4;
            // 
            // Label_Title_Panel_MainScreen
            // 
            this.Label_Title_Panel_MainScreen.Cursor = System.Windows.Forms.Cursors.Help;
            this.Label_Title_Panel_MainScreen.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.Label_Title_Panel_MainScreen.Location = new System.Drawing.Point(0, 0);
            this.Label_Title_Panel_MainScreen.Name = "Label_Title_Panel_MainScreen";
            this.Label_Title_Panel_MainScreen.Size = new System.Drawing.Size(750, 79);
            this.Label_Title_Panel_MainScreen.TabIndex = 2;
            this.Label_Title_Panel_MainScreen.Text = "CinemaTickets - покупай быстро и четко!";
            this.Label_Title_Panel_MainScreen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.Panel_ViewListFilms.ResumeLayout(false);
            this.Panel_StatisticsAndReport.ResumeLayout(false);
            this.Panel_Search.ResumeLayout(false);
            this.Panel_MainScreen.ResumeLayout(false);
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
        private System.Windows.Forms.Panel Panel_ViewListFilms;
        private MetroFramework.Controls.MetroComboBox ComboBox_Gener;
        private MetroFramework.Controls.MetroComboBox ComboBox_Year;
        private MetroFramework.Controls.MetroButton Button_SearchFilms;
        private MetroFramework.Controls.MetroButton Button_SearchFilms_Next;
        private MetroFramework.Controls.MetroButton Button_SearchFilms_Back;
        private MetroFramework.Controls.MetroLabel Label_PageInfo;
        private MetroFramework.Controls.MetroLabel MainTitle_Panel_Films;
        private MetroFramework.Controls.MetroLabel Label_Title_Panel_Search;
        private MetroFramework.Controls.MetroLabel Label_Title_Panel_StatisticsAndReport;
        private MetroFramework.Controls.MetroLabel Label_Title_Panel_MainScreen;
    }
}

