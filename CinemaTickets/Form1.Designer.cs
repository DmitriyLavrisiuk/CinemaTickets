﻿namespace CinemaTickets
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
            this.panelMainMenu = new System.Windows.Forms.Panel();
            this.menuButtonAdd = new System.Windows.Forms.Button();
            this.panelLabelInMainMenu = new System.Windows.Forms.Panel();
            this.labelTitleMainText = new System.Windows.Forms.Label();
            this.menuButtonSearch = new System.Windows.Forms.Button();
            this.menuButtonExit = new System.Windows.Forms.Button();
            this.menuButtonStatisticsAndReports = new System.Windows.Forms.Button();
            this.menuButtonFilms = new System.Windows.Forms.Button();
            this.panelFilms = new System.Windows.Forms.Panel();
            this.labelNumberPage = new MetroFramework.Controls.MetroLabel();
            this.buttonSearchFilmsNext = new MetroFramework.Controls.MetroButton();
            this.buttonSearchFilmsBack = new MetroFramework.Controls.MetroButton();
            this.comboBoxYear = new MetroFramework.Controls.MetroComboBox();
            this.buttonSearchFilms = new MetroFramework.Controls.MetroButton();
            this.comboBoxGener = new MetroFramework.Controls.MetroComboBox();
            this.panelViewListFilms = new System.Windows.Forms.Panel();
            this.titlePanelFilms = new MetroFramework.Controls.MetroLabel();
            this.panelStatisticsAndReports = new System.Windows.Forms.Panel();
            this.titlePanelStatisticsAndReports = new MetroFramework.Controls.MetroLabel();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.titlePanelSearch = new MetroFramework.Controls.MetroLabel();
            this.panelMainScreen = new System.Windows.Forms.Panel();
            this.titlePanelMainScreen = new MetroFramework.Controls.MetroLabel();
            this.panelAdd = new System.Windows.Forms.Panel();
            this.buttonAddProductionCountries = new MetroFramework.Controls.MetroButton();
            this.buttonAddGener = new MetroFramework.Controls.MetroButton();
            this.buttonAddSession = new MetroFramework.Controls.MetroButton();
            this.buttonAddFilm = new MetroFramework.Controls.MetroButton();
            this.panelAddFilms = new System.Windows.Forms.Panel();
            this.dataGridViewAddFilms = new System.Windows.Forms.DataGridView();
            this.titlePanelAddFilms = new MetroFramework.Controls.MetroLabel();
            this.panelAddProductionCountries = new System.Windows.Forms.Panel();
            this.titlePanelAddProductionCountries = new MetroFramework.Controls.MetroLabel();
            this.panelAddSessions = new System.Windows.Forms.Panel();
            this.titlePanelAddSessions = new MetroFramework.Controls.MetroLabel();
            this.panelAddGeners = new System.Windows.Forms.Panel();
            this.titlePanelAddGeners = new MetroFramework.Controls.MetroLabel();
            this.menuButtonReturnTickets = new System.Windows.Forms.Button();
            this.panelReturnTickets = new System.Windows.Forms.Panel();
            this.titlePanelReturnTickets = new MetroFramework.Controls.MetroLabel();
            this.panelMainMenu.SuspendLayout();
            this.panelLabelInMainMenu.SuspendLayout();
            this.panelFilms.SuspendLayout();
            this.panelViewListFilms.SuspendLayout();
            this.panelStatisticsAndReports.SuspendLayout();
            this.panelSearch.SuspendLayout();
            this.panelMainScreen.SuspendLayout();
            this.panelAdd.SuspendLayout();
            this.panelAddFilms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddFilms)).BeginInit();
            this.panelAddProductionCountries.SuspendLayout();
            this.panelAddSessions.SuspendLayout();
            this.panelAddGeners.SuspendLayout();
            this.panelReturnTickets.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMainMenu
            // 
            this.panelMainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.panelMainMenu.Controls.Add(this.menuButtonReturnTickets);
            this.panelMainMenu.Controls.Add(this.menuButtonAdd);
            this.panelMainMenu.Controls.Add(this.panelLabelInMainMenu);
            this.panelMainMenu.Controls.Add(this.menuButtonSearch);
            this.panelMainMenu.Controls.Add(this.menuButtonExit);
            this.panelMainMenu.Controls.Add(this.menuButtonStatisticsAndReports);
            this.panelMainMenu.Controls.Add(this.menuButtonFilms);
            this.panelMainMenu.ForeColor = System.Drawing.Color.Crimson;
            this.panelMainMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMainMenu.Name = "panelMainMenu";
            this.panelMainMenu.Size = new System.Drawing.Size(215, 600);
            this.panelMainMenu.TabIndex = 0;
            // 
            // menuButtonAdd
            // 
            this.menuButtonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(105)))));
            this.menuButtonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuButtonAdd.FlatAppearance.BorderSize = 0;
            this.menuButtonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuButtonAdd.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuButtonAdd.ForeColor = System.Drawing.Color.White;
            this.menuButtonAdd.Location = new System.Drawing.Point(0, 518);
            this.menuButtonAdd.Name = "menuButtonAdd";
            this.menuButtonAdd.Size = new System.Drawing.Size(214, 40);
            this.menuButtonAdd.TabIndex = 6;
            this.menuButtonAdd.Text = "Добавление данных";
            this.menuButtonAdd.UseVisualStyleBackColor = false;
            this.menuButtonAdd.Click += new System.EventHandler(this.menuButtonAdd_Click);
            // 
            // panelLabelInMainMenu
            // 
            this.panelLabelInMainMenu.BackColor = System.Drawing.Color.Gainsboro;
            this.panelLabelInMainMenu.Controls.Add(this.labelTitleMainText);
            this.panelLabelInMainMenu.Location = new System.Drawing.Point(-1, -1);
            this.panelLabelInMainMenu.Name = "panelLabelInMainMenu";
            this.panelLabelInMainMenu.Size = new System.Drawing.Size(214, 79);
            this.panelLabelInMainMenu.TabIndex = 9;
            // 
            // labelTitleMainText
            // 
            this.labelTitleMainText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
            this.labelTitleMainText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelTitleMainText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTitleMainText.Font = new System.Drawing.Font("Righteous", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleMainText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(23)))), ((int)(((byte)(79)))));
            this.labelTitleMainText.Location = new System.Drawing.Point(0, 0);
            this.labelTitleMainText.Name = "labelTitleMainText";
            this.labelTitleMainText.Size = new System.Drawing.Size(214, 79);
            this.labelTitleMainText.TabIndex = 1;
            this.labelTitleMainText.Text = "CinemaTickets";
            this.labelTitleMainText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTitleMainText.Click += new System.EventHandler(this.labelTitleMainText_Click);
            // 
            // menuButtonSearch
            // 
            this.menuButtonSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(105)))));
            this.menuButtonSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuButtonSearch.FlatAppearance.BorderSize = 0;
            this.menuButtonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuButtonSearch.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuButtonSearch.ForeColor = System.Drawing.Color.White;
            this.menuButtonSearch.Location = new System.Drawing.Point(0, 161);
            this.menuButtonSearch.Name = "menuButtonSearch";
            this.menuButtonSearch.Size = new System.Drawing.Size(214, 40);
            this.menuButtonSearch.TabIndex = 4;
            this.menuButtonSearch.Text = "Поиск";
            this.menuButtonSearch.UseVisualStyleBackColor = false;
            this.menuButtonSearch.Click += new System.EventHandler(this.menuButtonSearch_Click);
            // 
            // menuButtonExit
            // 
            this.menuButtonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(105)))));
            this.menuButtonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuButtonExit.FlatAppearance.BorderSize = 0;
            this.menuButtonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuButtonExit.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuButtonExit.ForeColor = System.Drawing.Color.White;
            this.menuButtonExit.Location = new System.Drawing.Point(0, 559);
            this.menuButtonExit.Name = "menuButtonExit";
            this.menuButtonExit.Size = new System.Drawing.Size(214, 40);
            this.menuButtonExit.TabIndex = 7;
            this.menuButtonExit.Text = "Выход";
            this.menuButtonExit.UseVisualStyleBackColor = false;
            this.menuButtonExit.Click += new System.EventHandler(this.menuButton_Exit_Click);
            // 
            // menuButtonStatisticsAndReports
            // 
            this.menuButtonStatisticsAndReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(105)))));
            this.menuButtonStatisticsAndReports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuButtonStatisticsAndReports.FlatAppearance.BorderSize = 0;
            this.menuButtonStatisticsAndReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuButtonStatisticsAndReports.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuButtonStatisticsAndReports.ForeColor = System.Drawing.Color.White;
            this.menuButtonStatisticsAndReports.Location = new System.Drawing.Point(0, 477);
            this.menuButtonStatisticsAndReports.Name = "menuButtonStatisticsAndReports";
            this.menuButtonStatisticsAndReports.Size = new System.Drawing.Size(214, 40);
            this.menuButtonStatisticsAndReports.TabIndex = 5;
            this.menuButtonStatisticsAndReports.Text = "Статистика и отчеты";
            this.menuButtonStatisticsAndReports.UseVisualStyleBackColor = false;
            this.menuButtonStatisticsAndReports.Click += new System.EventHandler(this.menuButtonStatisticsAndReport_Click);
            // 
            // menuButtonFilms
            // 
            this.menuButtonFilms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(105)))));
            this.menuButtonFilms.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuButtonFilms.FlatAppearance.BorderSize = 0;
            this.menuButtonFilms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuButtonFilms.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuButtonFilms.ForeColor = System.Drawing.Color.White;
            this.menuButtonFilms.Location = new System.Drawing.Point(0, 79);
            this.menuButtonFilms.Name = "menuButtonFilms";
            this.menuButtonFilms.Size = new System.Drawing.Size(214, 40);
            this.menuButtonFilms.TabIndex = 2;
            this.menuButtonFilms.Text = "Фильмы";
            this.menuButtonFilms.UseVisualStyleBackColor = false;
            this.menuButtonFilms.Click += new System.EventHandler(this.menuButtonFilms_Click);
            // 
            // panelFilms
            // 
            this.panelFilms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.panelFilms.Controls.Add(this.labelNumberPage);
            this.panelFilms.Controls.Add(this.buttonSearchFilmsNext);
            this.panelFilms.Controls.Add(this.buttonSearchFilmsBack);
            this.panelFilms.Controls.Add(this.comboBoxYear);
            this.panelFilms.Controls.Add(this.buttonSearchFilms);
            this.panelFilms.Controls.Add(this.comboBoxGener);
            this.panelFilms.Controls.Add(this.panelViewListFilms);
            this.panelFilms.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelFilms.Location = new System.Drawing.Point(215, 0);
            this.panelFilms.Name = "panelFilms";
            this.panelFilms.Size = new System.Drawing.Size(750, 600);
            this.panelFilms.TabIndex = 1;
            // 
            // labelNumberPage
            // 
            this.labelNumberPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelNumberPage.Cursor = System.Windows.Forms.Cursors.Help;
            this.labelNumberPage.FontSize = MetroFramework.MetroLabelSize.Small;
            this.labelNumberPage.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labelNumberPage.Location = new System.Drawing.Point(652, 550);
            this.labelNumberPage.Name = "labelNumberPage";
            this.labelNumberPage.Size = new System.Drawing.Size(82, 29);
            this.labelNumberPage.TabIndex = 10;
            this.labelNumberPage.Text = "1 из 3";
            this.labelNumberPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonSearchFilmsNext
            // 
            this.buttonSearchFilmsNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSearchFilmsNext.Location = new System.Drawing.Point(561, 550);
            this.buttonSearchFilmsNext.Name = "buttonSearchFilmsNext";
            this.buttonSearchFilmsNext.Size = new System.Drawing.Size(85, 29);
            this.buttonSearchFilmsNext.TabIndex = 5;
            this.buttonSearchFilmsNext.Text = "Вперед";
            this.buttonSearchFilmsNext.Click += new System.EventHandler(this.buttonSearchFilmsNext_Click);
            // 
            // buttonSearchFilmsBack
            // 
            this.buttonSearchFilmsBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSearchFilmsBack.Location = new System.Drawing.Point(470, 550);
            this.buttonSearchFilmsBack.Name = "buttonSearchFilmsBack";
            this.buttonSearchFilmsBack.Size = new System.Drawing.Size(85, 29);
            this.buttonSearchFilmsBack.TabIndex = 4;
            this.buttonSearchFilmsBack.Text = "Назад";
            this.buttonSearchFilmsBack.Click += new System.EventHandler(this.buttonSearchFilmsBack_Click);
            // 
            // comboBoxYear
            // 
            this.comboBoxYear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxYear.FormattingEnabled = true;
            this.comboBoxYear.ItemHeight = 23;
            this.comboBoxYear.Items.AddRange(new object[] {
            "Все года",
            "Самые новые",
            "2016 - 2018",
            "2012 - 2016",
            "2008 - 2012",
            "2006 - 2008",
            "2002 - 2006",
            "2000 - 2002",
            "1990 - 2000",
            "Более поздние"});
            this.comboBoxYear.Location = new System.Drawing.Point(163, 550);
            this.comboBoxYear.Name = "comboBoxYear";
            this.comboBoxYear.Size = new System.Drawing.Size(121, 29);
            this.comboBoxYear.TabIndex = 2;
            // 
            // buttonSearchFilms
            // 
            this.buttonSearchFilms.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSearchFilms.Location = new System.Drawing.Point(290, 550);
            this.buttonSearchFilms.Name = "buttonSearchFilms";
            this.buttonSearchFilms.Size = new System.Drawing.Size(174, 29);
            this.buttonSearchFilms.TabIndex = 3;
            this.buttonSearchFilms.Text = "Искать";
            this.buttonSearchFilms.Click += new System.EventHandler(this.buttonSearchFilms_Click);
            // 
            // comboBoxGener
            // 
            this.comboBoxGener.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxGener.FormattingEnabled = true;
            this.comboBoxGener.ItemHeight = 23;
            this.comboBoxGener.Items.AddRange(new object[] {
            "Все жанры"});
            this.comboBoxGener.Location = new System.Drawing.Point(19, 550);
            this.comboBoxGener.Name = "comboBoxGener";
            this.comboBoxGener.Size = new System.Drawing.Size(138, 29);
            this.comboBoxGener.TabIndex = 1;
            // 
            // panelViewListFilms
            // 
            this.panelViewListFilms.AutoScroll = true;
            this.panelViewListFilms.BackColor = System.Drawing.Color.White;
            this.panelViewListFilms.Controls.Add(this.titlePanelFilms);
            this.panelViewListFilms.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelViewListFilms.Location = new System.Drawing.Point(0, 0);
            this.panelViewListFilms.Name = "panelViewListFilms";
            this.panelViewListFilms.Padding = new System.Windows.Forms.Padding(0, 0, 0, 440);
            this.panelViewListFilms.Size = new System.Drawing.Size(770, 530);
            this.panelViewListFilms.TabIndex = 9;
            // 
            // titlePanelFilms
            // 
            this.titlePanelFilms.Cursor = System.Windows.Forms.Cursors.Help;
            this.titlePanelFilms.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.titlePanelFilms.Location = new System.Drawing.Point(1, 1);
            this.titlePanelFilms.Name = "titlePanelFilms";
            this.titlePanelFilms.Size = new System.Drawing.Size(768, 528);
            this.titlePanelFilms.TabIndex = 0;
            this.titlePanelFilms.Text = "Для просмотра подходящих вам результатов выберите жанр и год ниже.";
            this.titlePanelFilms.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelStatisticsAndReports
            // 
            this.panelStatisticsAndReports.Controls.Add(this.titlePanelStatisticsAndReports);
            this.panelStatisticsAndReports.Location = new System.Drawing.Point(215, 0);
            this.panelStatisticsAndReports.Name = "panelStatisticsAndReports";
            this.panelStatisticsAndReports.Size = new System.Drawing.Size(750, 600);
            this.panelStatisticsAndReports.TabIndex = 2;
            // 
            // titlePanelStatisticsAndReports
            // 
            this.titlePanelStatisticsAndReports.Cursor = System.Windows.Forms.Cursors.Help;
            this.titlePanelStatisticsAndReports.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.titlePanelStatisticsAndReports.Location = new System.Drawing.Point(0, 0);
            this.titlePanelStatisticsAndReports.Name = "titlePanelStatisticsAndReports";
            this.titlePanelStatisticsAndReports.Size = new System.Drawing.Size(750, 79);
            this.titlePanelStatisticsAndReports.TabIndex = 2;
            this.titlePanelStatisticsAndReports.Text = "Статистика и отчеты";
            this.titlePanelStatisticsAndReports.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelSearch
            // 
            this.panelSearch.Controls.Add(this.titlePanelSearch);
            this.panelSearch.Location = new System.Drawing.Point(215, 0);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(750, 600);
            this.panelSearch.TabIndex = 3;
            // 
            // titlePanelSearch
            // 
            this.titlePanelSearch.Cursor = System.Windows.Forms.Cursors.Help;
            this.titlePanelSearch.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.titlePanelSearch.Location = new System.Drawing.Point(0, 0);
            this.titlePanelSearch.Name = "titlePanelSearch";
            this.titlePanelSearch.Size = new System.Drawing.Size(750, 79);
            this.titlePanelSearch.TabIndex = 1;
            this.titlePanelSearch.Text = "Поиск";
            this.titlePanelSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelMainScreen
            // 
            this.panelMainScreen.Controls.Add(this.titlePanelMainScreen);
            this.panelMainScreen.Location = new System.Drawing.Point(215, 0);
            this.panelMainScreen.Name = "panelMainScreen";
            this.panelMainScreen.Size = new System.Drawing.Size(750, 600);
            this.panelMainScreen.TabIndex = 4;
            // 
            // titlePanelMainScreen
            // 
            this.titlePanelMainScreen.Cursor = System.Windows.Forms.Cursors.Help;
            this.titlePanelMainScreen.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.titlePanelMainScreen.Location = new System.Drawing.Point(0, 0);
            this.titlePanelMainScreen.Name = "titlePanelMainScreen";
            this.titlePanelMainScreen.Size = new System.Drawing.Size(750, 79);
            this.titlePanelMainScreen.TabIndex = 2;
            this.titlePanelMainScreen.Text = "CinemaTickets - покупай быстро и четко!";
            this.titlePanelMainScreen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelAdd
            // 
            this.panelAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.panelAdd.Controls.Add(this.buttonAddProductionCountries);
            this.panelAdd.Controls.Add(this.buttonAddGener);
            this.panelAdd.Controls.Add(this.buttonAddSession);
            this.panelAdd.Controls.Add(this.buttonAddFilm);
            this.panelAdd.Controls.Add(this.panelAddFilms);
            this.panelAdd.Controls.Add(this.panelAddProductionCountries);
            this.panelAdd.Controls.Add(this.panelAddSessions);
            this.panelAdd.Controls.Add(this.panelAddGeners);
            this.panelAdd.Location = new System.Drawing.Point(215, 0);
            this.panelAdd.Name = "panelAdd";
            this.panelAdd.Size = new System.Drawing.Size(750, 600);
            this.panelAdd.TabIndex = 5;
            // 
            // buttonAddProductionCountries
            // 
            this.buttonAddProductionCountries.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddProductionCountries.Location = new System.Drawing.Point(523, 550);
            this.buttonAddProductionCountries.Name = "buttonAddProductionCountries";
            this.buttonAddProductionCountries.Size = new System.Drawing.Size(205, 29);
            this.buttonAddProductionCountries.TabIndex = 10;
            this.buttonAddProductionCountries.Text = "Страну производителя";
            this.buttonAddProductionCountries.Click += new System.EventHandler(this.buttonAddProductionCountries_Click);
            // 
            // buttonAddGener
            // 
            this.buttonAddGener.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddGener.Location = new System.Drawing.Point(356, 550);
            this.buttonAddGener.Name = "buttonAddGener";
            this.buttonAddGener.Size = new System.Drawing.Size(161, 29);
            this.buttonAddGener.TabIndex = 9;
            this.buttonAddGener.Text = "Жанр";
            this.buttonAddGener.Click += new System.EventHandler(this.buttonAddGener_Click);
            // 
            // buttonAddSession
            // 
            this.buttonAddSession.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddSession.Location = new System.Drawing.Point(189, 550);
            this.buttonAddSession.Name = "buttonAddSession";
            this.buttonAddSession.Size = new System.Drawing.Size(161, 29);
            this.buttonAddSession.TabIndex = 8;
            this.buttonAddSession.Text = "Сеанс";
            this.buttonAddSession.Click += new System.EventHandler(this.buttonAddSession_Click);
            // 
            // buttonAddFilm
            // 
            this.buttonAddFilm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddFilm.Location = new System.Drawing.Point(22, 550);
            this.buttonAddFilm.Name = "buttonAddFilm";
            this.buttonAddFilm.Size = new System.Drawing.Size(161, 29);
            this.buttonAddFilm.TabIndex = 7;
            this.buttonAddFilm.Text = "Фильм";
            this.buttonAddFilm.Click += new System.EventHandler(this.buttonAddFilm_Click);
            // 
            // panelAddFilms
            // 
            this.panelAddFilms.BackColor = System.Drawing.Color.White;
            this.panelAddFilms.Controls.Add(this.dataGridViewAddFilms);
            this.panelAddFilms.Controls.Add(this.titlePanelAddFilms);
            this.panelAddFilms.Location = new System.Drawing.Point(1, 1);
            this.panelAddFilms.Name = "panelAddFilms";
            this.panelAddFilms.Size = new System.Drawing.Size(749, 528);
            this.panelAddFilms.TabIndex = 6;
            // 
            // dataGridViewAddFilms
            // 
            this.dataGridViewAddFilms.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.dataGridViewAddFilms.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewAddFilms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAddFilms.Location = new System.Drawing.Point(21, 78);
            this.dataGridViewAddFilms.Name = "dataGridViewAddFilms";
            this.dataGridViewAddFilms.Size = new System.Drawing.Size(712, 138);
            this.dataGridViewAddFilms.TabIndex = 2;
            // 
            // titlePanelAddFilms
            // 
            this.titlePanelAddFilms.Cursor = System.Windows.Forms.Cursors.Help;
            this.titlePanelAddFilms.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.titlePanelAddFilms.Location = new System.Drawing.Point(0, 0);
            this.titlePanelAddFilms.Name = "titlePanelAddFilms";
            this.titlePanelAddFilms.Size = new System.Drawing.Size(750, 79);
            this.titlePanelAddFilms.TabIndex = 1;
            this.titlePanelAddFilms.Text = "Добавление фильмов";
            this.titlePanelAddFilms.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelAddProductionCountries
            // 
            this.panelAddProductionCountries.BackColor = System.Drawing.Color.White;
            this.panelAddProductionCountries.Controls.Add(this.titlePanelAddProductionCountries);
            this.panelAddProductionCountries.Location = new System.Drawing.Point(1, 1);
            this.panelAddProductionCountries.Name = "panelAddProductionCountries";
            this.panelAddProductionCountries.Size = new System.Drawing.Size(749, 528);
            this.panelAddProductionCountries.TabIndex = 13;
            this.panelAddProductionCountries.Visible = false;
            // 
            // titlePanelAddProductionCountries
            // 
            this.titlePanelAddProductionCountries.Cursor = System.Windows.Forms.Cursors.Help;
            this.titlePanelAddProductionCountries.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.titlePanelAddProductionCountries.Location = new System.Drawing.Point(0, 0);
            this.titlePanelAddProductionCountries.Name = "titlePanelAddProductionCountries";
            this.titlePanelAddProductionCountries.Size = new System.Drawing.Size(750, 79);
            this.titlePanelAddProductionCountries.TabIndex = 1;
            this.titlePanelAddProductionCountries.Text = "Добавление стран производителей";
            this.titlePanelAddProductionCountries.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelAddSessions
            // 
            this.panelAddSessions.BackColor = System.Drawing.Color.White;
            this.panelAddSessions.Controls.Add(this.titlePanelAddSessions);
            this.panelAddSessions.Location = new System.Drawing.Point(1, 1);
            this.panelAddSessions.Name = "panelAddSessions";
            this.panelAddSessions.Size = new System.Drawing.Size(749, 528);
            this.panelAddSessions.TabIndex = 12;
            this.panelAddSessions.Visible = false;
            // 
            // titlePanelAddSessions
            // 
            this.titlePanelAddSessions.Cursor = System.Windows.Forms.Cursors.Help;
            this.titlePanelAddSessions.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.titlePanelAddSessions.Location = new System.Drawing.Point(0, 0);
            this.titlePanelAddSessions.Name = "titlePanelAddSessions";
            this.titlePanelAddSessions.Size = new System.Drawing.Size(750, 79);
            this.titlePanelAddSessions.TabIndex = 1;
            this.titlePanelAddSessions.Text = "Добавление сеансов";
            this.titlePanelAddSessions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelAddGeners
            // 
            this.panelAddGeners.BackColor = System.Drawing.Color.White;
            this.panelAddGeners.Controls.Add(this.titlePanelAddGeners);
            this.panelAddGeners.Location = new System.Drawing.Point(1, 1);
            this.panelAddGeners.Name = "panelAddGeners";
            this.panelAddGeners.Size = new System.Drawing.Size(749, 528);
            this.panelAddGeners.TabIndex = 11;
            this.panelAddGeners.Visible = false;
            // 
            // titlePanelAddGeners
            // 
            this.titlePanelAddGeners.Cursor = System.Windows.Forms.Cursors.Help;
            this.titlePanelAddGeners.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.titlePanelAddGeners.Location = new System.Drawing.Point(0, 0);
            this.titlePanelAddGeners.Name = "titlePanelAddGeners";
            this.titlePanelAddGeners.Size = new System.Drawing.Size(750, 79);
            this.titlePanelAddGeners.TabIndex = 1;
            this.titlePanelAddGeners.Text = "Добавление жанров";
            this.titlePanelAddGeners.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuButtonReturnTickets
            // 
            this.menuButtonReturnTickets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(105)))));
            this.menuButtonReturnTickets.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuButtonReturnTickets.FlatAppearance.BorderSize = 0;
            this.menuButtonReturnTickets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuButtonReturnTickets.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuButtonReturnTickets.ForeColor = System.Drawing.Color.White;
            this.menuButtonReturnTickets.Location = new System.Drawing.Point(0, 120);
            this.menuButtonReturnTickets.Name = "menuButtonReturnTickets";
            this.menuButtonReturnTickets.Size = new System.Drawing.Size(214, 40);
            this.menuButtonReturnTickets.TabIndex = 3;
            this.menuButtonReturnTickets.Text = "Возврат билета";
            this.menuButtonReturnTickets.UseVisualStyleBackColor = false;
            this.menuButtonReturnTickets.Click += new System.EventHandler(this.menuButtonReturnTickets_Click);
            // 
            // panelReturnTickets
            // 
            this.panelReturnTickets.Controls.Add(this.titlePanelReturnTickets);
            this.panelReturnTickets.Location = new System.Drawing.Point(215, 0);
            this.panelReturnTickets.Name = "panelReturnTickets";
            this.panelReturnTickets.Size = new System.Drawing.Size(750, 600);
            this.panelReturnTickets.TabIndex = 6;
            // 
            // titlePanelReturnTickets
            // 
            this.titlePanelReturnTickets.Cursor = System.Windows.Forms.Cursors.Help;
            this.titlePanelReturnTickets.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.titlePanelReturnTickets.Location = new System.Drawing.Point(0, 0);
            this.titlePanelReturnTickets.Name = "titlePanelReturnTickets";
            this.titlePanelReturnTickets.Size = new System.Drawing.Size(750, 79);
            this.titlePanelReturnTickets.TabIndex = 1;
            this.titlePanelReturnTickets.Text = "Возврат билетов";
            this.titlePanelReturnTickets.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 600);
            this.ControlBox = false;
            this.Controls.Add(this.panelReturnTickets);
            this.Controls.Add(this.panelMainMenu);
            this.Controls.Add(this.panelSearch);
            this.Controls.Add(this.panelMainScreen);
            this.Controls.Add(this.panelStatisticsAndReports);
            this.Controls.Add(this.panelFilms);
            this.Controls.Add(this.panelAdd);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMainMenu.ResumeLayout(false);
            this.panelLabelInMainMenu.ResumeLayout(false);
            this.panelFilms.ResumeLayout(false);
            this.panelViewListFilms.ResumeLayout(false);
            this.panelStatisticsAndReports.ResumeLayout(false);
            this.panelSearch.ResumeLayout(false);
            this.panelMainScreen.ResumeLayout(false);
            this.panelAdd.ResumeLayout(false);
            this.panelAddFilms.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddFilms)).EndInit();
            this.panelAddProductionCountries.ResumeLayout(false);
            this.panelAddSessions.ResumeLayout(false);
            this.panelAddGeners.ResumeLayout(false);
            this.panelReturnTickets.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMainMenu;
        private System.Windows.Forms.Button menuButtonSearch;
        private System.Windows.Forms.Button menuButtonExit;
        private System.Windows.Forms.Button menuButtonStatisticsAndReports;
        private System.Windows.Forms.Button menuButtonFilms;
        private System.Windows.Forms.Label labelTitleMainText;
        private System.Windows.Forms.Panel panelLabelInMainMenu;
        private System.Windows.Forms.Panel panelFilms;
        private System.Windows.Forms.Panel panelStatisticsAndReports;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.Panel panelMainScreen;
        private System.Windows.Forms.Panel panelViewListFilms;
        private MetroFramework.Controls.MetroComboBox comboBoxGener;
        private MetroFramework.Controls.MetroComboBox comboBoxYear;
        private MetroFramework.Controls.MetroButton buttonSearchFilms;
        private MetroFramework.Controls.MetroButton buttonSearchFilmsNext;
        private MetroFramework.Controls.MetroButton buttonSearchFilmsBack;
        private MetroFramework.Controls.MetroLabel titlePanelFilms;
        private MetroFramework.Controls.MetroLabel titlePanelSearch;
        private MetroFramework.Controls.MetroLabel titlePanelStatisticsAndReports;
        private MetroFramework.Controls.MetroLabel titlePanelMainScreen;
        private MetroFramework.Controls.MetroLabel labelNumberPage;
        private System.Windows.Forms.Button menuButtonAdd;
        private System.Windows.Forms.Panel panelAdd;
        private System.Windows.Forms.Panel panelAddFilms;
        private MetroFramework.Controls.MetroLabel titlePanelAddFilms;
        private MetroFramework.Controls.MetroButton buttonAddProductionCountries;
        private MetroFramework.Controls.MetroButton buttonAddGener;
        private MetroFramework.Controls.MetroButton buttonAddSession;
        private MetroFramework.Controls.MetroButton buttonAddFilm;
        private System.Windows.Forms.Panel panelAddGeners;
        private MetroFramework.Controls.MetroLabel titlePanelAddGeners;
        private System.Windows.Forms.Panel panelAddSessions;
        private MetroFramework.Controls.MetroLabel titlePanelAddSessions;
        private System.Windows.Forms.Panel panelAddProductionCountries;
        private MetroFramework.Controls.MetroLabel titlePanelAddProductionCountries;
        private System.Windows.Forms.DataGridView dataGridViewAddFilms;
        private System.Windows.Forms.Button menuButtonReturnTickets;
        private System.Windows.Forms.Panel panelReturnTickets;
        private MetroFramework.Controls.MetroLabel titlePanelReturnTickets;
    }
}

