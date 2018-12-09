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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelMainMenu = new System.Windows.Forms.Panel();
            this.labelTitleMainText = new System.Windows.Forms.Label();
            this.menuButtonReturnTickets = new System.Windows.Forms.Button();
            this.menuButtonAdd = new System.Windows.Forms.Button();
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
            this.titlePanelAddFilms = new MetroFramework.Controls.MetroLabel();
            this.panelAddProductionCountries = new System.Windows.Forms.Panel();
            this.titlePanelAddProductionCountries = new MetroFramework.Controls.MetroLabel();
            this.panelAddSessions = new System.Windows.Forms.Panel();
            this.titlePanelAddSessions = new MetroFramework.Controls.MetroLabel();
            this.panelAddGeners = new System.Windows.Forms.Panel();
            this.titlePanelAddGeners = new MetroFramework.Controls.MetroLabel();
            this.searchTicket = new System.Windows.Forms.Panel();
            this.panelReturnTicket = new System.Windows.Forms.Panel();
            this.buttonReturnTicketUID = new MetroFramework.Controls.MetroButton();
            this.ticketPanel = new System.Windows.Forms.Panel();
            this.ticketLength = new System.Windows.Forms.Label();
            this.ticketAgeLimit = new System.Windows.Forms.Label();
            this.ticketUID = new System.Windows.Forms.Label();
            this.ticketPrice = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ticketPlace = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ticketHall = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ticketDate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ticketImage = new System.Windows.Forms.PictureBox();
            this.ticketNameFilm = new System.Windows.Forms.Label();
            this.labelHelper = new MetroFramework.Controls.MetroLabel();
            this.buttonSearchTicketUID = new MetroFramework.Controls.MetroButton();
            this.labelHelperDescription = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.titlePanelReturnTickets = new MetroFramework.Controls.MetroLabel();
            this.textBoxUID = new System.Windows.Forms.TextBox();
            this.cinemaDataSet = new CinemaTickets.CinemaDataSet();
            this.filmsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filmsTableAdapter = new CinemaTickets.CinemaDataSetTableAdapters.FilmsTableAdapter();
            this.tableAdapterManager = new CinemaTickets.CinemaDataSetTableAdapters.TableAdapterManager();
            this.filmsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.filmsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.filmsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelMainMenu.SuspendLayout();
            this.panelFilms.SuspendLayout();
            this.panelViewListFilms.SuspendLayout();
            this.panelStatisticsAndReports.SuspendLayout();
            this.panelSearch.SuspendLayout();
            this.panelMainScreen.SuspendLayout();
            this.panelAdd.SuspendLayout();
            this.panelAddFilms.SuspendLayout();
            this.panelAddProductionCountries.SuspendLayout();
            this.panelAddSessions.SuspendLayout();
            this.panelAddGeners.SuspendLayout();
            this.searchTicket.SuspendLayout();
            this.panelReturnTicket.SuspendLayout();
            this.ticketPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ticketImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinemaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmsBindingNavigator)).BeginInit();
            this.filmsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filmsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMainMenu
            // 
            this.panelMainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.panelMainMenu.Controls.Add(this.labelTitleMainText);
            this.panelMainMenu.Controls.Add(this.menuButtonReturnTickets);
            this.panelMainMenu.Controls.Add(this.menuButtonAdd);
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
            // labelTitleMainText
            // 
            this.labelTitleMainText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
            this.labelTitleMainText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelTitleMainText.Font = new System.Drawing.Font("Righteous", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleMainText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(23)))), ((int)(((byte)(79)))));
            this.labelTitleMainText.Location = new System.Drawing.Point(0, 0);
            this.labelTitleMainText.Name = "labelTitleMainText";
            this.labelTitleMainText.Size = new System.Drawing.Size(214, 77);
            this.labelTitleMainText.TabIndex = 1;
            this.labelTitleMainText.Text = "CinemaTickets";
            this.labelTitleMainText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTitleMainText.Click += new System.EventHandler(this.labelTitleMainText_Click);
            // 
            // menuButtonReturnTickets
            // 
            this.menuButtonReturnTickets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(105)))));
            this.menuButtonReturnTickets.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuButtonReturnTickets.FlatAppearance.BorderSize = 0;
            this.menuButtonReturnTickets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuButtonReturnTickets.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuButtonReturnTickets.ForeColor = System.Drawing.Color.White;
            this.menuButtonReturnTickets.Location = new System.Drawing.Point(0, 119);
            this.menuButtonReturnTickets.Name = "menuButtonReturnTickets";
            this.menuButtonReturnTickets.Size = new System.Drawing.Size(214, 40);
            this.menuButtonReturnTickets.TabIndex = 3;
            this.menuButtonReturnTickets.Text = "Возврат билетов";
            this.menuButtonReturnTickets.UseVisualStyleBackColor = false;
            this.menuButtonReturnTickets.Click += new System.EventHandler(this.menuButtonReturnTickets_Click);
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
            // menuButtonSearch
            // 
            this.menuButtonSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(105)))));
            this.menuButtonSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuButtonSearch.FlatAppearance.BorderSize = 0;
            this.menuButtonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuButtonSearch.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuButtonSearch.ForeColor = System.Drawing.Color.White;
            this.menuButtonSearch.Location = new System.Drawing.Point(0, 160);
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
            this.menuButtonFilms.Location = new System.Drawing.Point(0, 78);
            this.menuButtonFilms.Name = "menuButtonFilms";
            this.menuButtonFilms.Size = new System.Drawing.Size(214, 40);
            this.menuButtonFilms.TabIndex = 2;
            this.menuButtonFilms.Text = "Фильмы";
            this.menuButtonFilms.UseVisualStyleBackColor = false;
            this.menuButtonFilms.Click += new System.EventHandler(this.menuButtonFilms_Click);
            // 
            // panelFilms
            // 
            this.panelFilms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
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
            this.titlePanelStatisticsAndReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.titlePanelStatisticsAndReports.Cursor = System.Windows.Forms.Cursors.Help;
            this.titlePanelStatisticsAndReports.CustomBackground = true;
            this.titlePanelStatisticsAndReports.CustomForeColor = true;
            this.titlePanelStatisticsAndReports.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.titlePanelStatisticsAndReports.ForeColor = System.Drawing.Color.White;
            this.titlePanelStatisticsAndReports.Location = new System.Drawing.Point(0, 0);
            this.titlePanelStatisticsAndReports.Name = "titlePanelStatisticsAndReports";
            this.titlePanelStatisticsAndReports.Size = new System.Drawing.Size(750, 77);
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
            this.titlePanelSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.titlePanelSearch.Cursor = System.Windows.Forms.Cursors.Help;
            this.titlePanelSearch.CustomBackground = true;
            this.titlePanelSearch.CustomForeColor = true;
            this.titlePanelSearch.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.titlePanelSearch.ForeColor = System.Drawing.Color.White;
            this.titlePanelSearch.Location = new System.Drawing.Point(0, 0);
            this.titlePanelSearch.Name = "titlePanelSearch";
            this.titlePanelSearch.Size = new System.Drawing.Size(750, 77);
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
            this.titlePanelMainScreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.titlePanelMainScreen.Cursor = System.Windows.Forms.Cursors.Help;
            this.titlePanelMainScreen.CustomBackground = true;
            this.titlePanelMainScreen.CustomForeColor = true;
            this.titlePanelMainScreen.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.titlePanelMainScreen.ForeColor = System.Drawing.Color.White;
            this.titlePanelMainScreen.Location = new System.Drawing.Point(0, 0);
            this.titlePanelMainScreen.Name = "titlePanelMainScreen";
            this.titlePanelMainScreen.Size = new System.Drawing.Size(750, 77);
            this.titlePanelMainScreen.TabIndex = 2;
            this.titlePanelMainScreen.Text = "CinemaTickets - покупай быстро и четко!";
            this.titlePanelMainScreen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelAdd
            // 
            this.panelAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
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
            this.panelAddFilms.Controls.Add(this.filmsBindingNavigator);
            this.panelAddFilms.Controls.Add(this.filmsDataGridView);
            this.panelAddFilms.Controls.Add(this.titlePanelAddFilms);
            this.panelAddFilms.Location = new System.Drawing.Point(0, 0);
            this.panelAddFilms.Name = "panelAddFilms";
            this.panelAddFilms.Size = new System.Drawing.Size(750, 528);
            this.panelAddFilms.TabIndex = 6;
            // 
            // titlePanelAddFilms
            // 
            this.titlePanelAddFilms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.titlePanelAddFilms.Cursor = System.Windows.Forms.Cursors.Help;
            this.titlePanelAddFilms.CustomBackground = true;
            this.titlePanelAddFilms.CustomForeColor = true;
            this.titlePanelAddFilms.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.titlePanelAddFilms.ForeColor = System.Drawing.Color.White;
            this.titlePanelAddFilms.Location = new System.Drawing.Point(0, 0);
            this.titlePanelAddFilms.Name = "titlePanelAddFilms";
            this.titlePanelAddFilms.Size = new System.Drawing.Size(750, 77);
            this.titlePanelAddFilms.TabIndex = 1;
            this.titlePanelAddFilms.Text = "Добавление фильмов";
            this.titlePanelAddFilms.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelAddProductionCountries
            // 
            this.panelAddProductionCountries.BackColor = System.Drawing.Color.White;
            this.panelAddProductionCountries.Controls.Add(this.titlePanelAddProductionCountries);
            this.panelAddProductionCountries.Location = new System.Drawing.Point(0, 0);
            this.panelAddProductionCountries.Name = "panelAddProductionCountries";
            this.panelAddProductionCountries.Size = new System.Drawing.Size(750, 528);
            this.panelAddProductionCountries.TabIndex = 13;
            this.panelAddProductionCountries.Visible = false;
            // 
            // titlePanelAddProductionCountries
            // 
            this.titlePanelAddProductionCountries.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.titlePanelAddProductionCountries.Cursor = System.Windows.Forms.Cursors.Help;
            this.titlePanelAddProductionCountries.CustomBackground = true;
            this.titlePanelAddProductionCountries.CustomForeColor = true;
            this.titlePanelAddProductionCountries.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.titlePanelAddProductionCountries.ForeColor = System.Drawing.Color.White;
            this.titlePanelAddProductionCountries.Location = new System.Drawing.Point(0, 0);
            this.titlePanelAddProductionCountries.Name = "titlePanelAddProductionCountries";
            this.titlePanelAddProductionCountries.Size = new System.Drawing.Size(750, 77);
            this.titlePanelAddProductionCountries.TabIndex = 1;
            this.titlePanelAddProductionCountries.Text = "Добавление стран производителей";
            this.titlePanelAddProductionCountries.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelAddSessions
            // 
            this.panelAddSessions.BackColor = System.Drawing.Color.White;
            this.panelAddSessions.Controls.Add(this.titlePanelAddSessions);
            this.panelAddSessions.Location = new System.Drawing.Point(0, 0);
            this.panelAddSessions.Name = "panelAddSessions";
            this.panelAddSessions.Size = new System.Drawing.Size(750, 528);
            this.panelAddSessions.TabIndex = 12;
            this.panelAddSessions.Visible = false;
            // 
            // titlePanelAddSessions
            // 
            this.titlePanelAddSessions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.titlePanelAddSessions.Cursor = System.Windows.Forms.Cursors.Help;
            this.titlePanelAddSessions.CustomBackground = true;
            this.titlePanelAddSessions.CustomForeColor = true;
            this.titlePanelAddSessions.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.titlePanelAddSessions.ForeColor = System.Drawing.Color.White;
            this.titlePanelAddSessions.Location = new System.Drawing.Point(0, 0);
            this.titlePanelAddSessions.Name = "titlePanelAddSessions";
            this.titlePanelAddSessions.Size = new System.Drawing.Size(750, 77);
            this.titlePanelAddSessions.TabIndex = 1;
            this.titlePanelAddSessions.Text = "Добавление сеансов";
            this.titlePanelAddSessions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelAddGeners
            // 
            this.panelAddGeners.BackColor = System.Drawing.Color.White;
            this.panelAddGeners.Controls.Add(this.titlePanelAddGeners);
            this.panelAddGeners.Location = new System.Drawing.Point(0, 0);
            this.panelAddGeners.Name = "panelAddGeners";
            this.panelAddGeners.Size = new System.Drawing.Size(750, 528);
            this.panelAddGeners.TabIndex = 11;
            this.panelAddGeners.Visible = false;
            // 
            // titlePanelAddGeners
            // 
            this.titlePanelAddGeners.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.titlePanelAddGeners.Cursor = System.Windows.Forms.Cursors.Help;
            this.titlePanelAddGeners.CustomBackground = true;
            this.titlePanelAddGeners.CustomForeColor = true;
            this.titlePanelAddGeners.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.titlePanelAddGeners.ForeColor = System.Drawing.Color.White;
            this.titlePanelAddGeners.Location = new System.Drawing.Point(0, 0);
            this.titlePanelAddGeners.Name = "titlePanelAddGeners";
            this.titlePanelAddGeners.Size = new System.Drawing.Size(750, 77);
            this.titlePanelAddGeners.TabIndex = 1;
            this.titlePanelAddGeners.Text = "Добавление жанров";
            this.titlePanelAddGeners.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // searchTicket
            // 
            this.searchTicket.Controls.Add(this.panelReturnTicket);
            this.searchTicket.Controls.Add(this.labelHelper);
            this.searchTicket.Controls.Add(this.buttonSearchTicketUID);
            this.searchTicket.Controls.Add(this.labelHelperDescription);
            this.searchTicket.Controls.Add(this.metroLabel2);
            this.searchTicket.Controls.Add(this.titlePanelReturnTickets);
            this.searchTicket.Controls.Add(this.textBoxUID);
            this.searchTicket.Location = new System.Drawing.Point(215, 0);
            this.searchTicket.Name = "searchTicket";
            this.searchTicket.Size = new System.Drawing.Size(750, 600);
            this.searchTicket.TabIndex = 6;
            // 
            // panelReturnTicket
            // 
            this.panelReturnTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.panelReturnTicket.Controls.Add(this.buttonReturnTicketUID);
            this.panelReturnTicket.Controls.Add(this.ticketPanel);
            this.panelReturnTicket.Location = new System.Drawing.Point(0, 199);
            this.panelReturnTicket.Name = "panelReturnTicket";
            this.panelReturnTicket.Size = new System.Drawing.Size(750, 402);
            this.panelReturnTicket.TabIndex = 8;
            this.panelReturnTicket.Visible = false;
            // 
            // buttonReturnTicketUID
            // 
            this.buttonReturnTicketUID.CausesValidation = false;
            this.buttonReturnTicketUID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReturnTicketUID.Location = new System.Drawing.Point(185, 314);
            this.buttonReturnTicketUID.Name = "buttonReturnTicketUID";
            this.buttonReturnTicketUID.Size = new System.Drawing.Size(385, 29);
            this.buttonReturnTicketUID.TabIndex = 8;
            this.buttonReturnTicketUID.Text = "Оформить возврат";
            this.buttonReturnTicketUID.Click += new System.EventHandler(this.buttonReturnTicketUID_Click);
            // 
            // ticketPanel
            // 
            this.ticketPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ticketPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ticketPanel.Controls.Add(this.ticketLength);
            this.ticketPanel.Controls.Add(this.ticketAgeLimit);
            this.ticketPanel.Controls.Add(this.ticketUID);
            this.ticketPanel.Controls.Add(this.ticketPrice);
            this.ticketPanel.Controls.Add(this.label9);
            this.ticketPanel.Controls.Add(this.ticketPlace);
            this.ticketPanel.Controls.Add(this.label7);
            this.ticketPanel.Controls.Add(this.ticketHall);
            this.ticketPanel.Controls.Add(this.label5);
            this.ticketPanel.Controls.Add(this.ticketDate);
            this.ticketPanel.Controls.Add(this.label2);
            this.ticketPanel.Controls.Add(this.ticketImage);
            this.ticketPanel.Controls.Add(this.ticketNameFilm);
            this.ticketPanel.Location = new System.Drawing.Point(185, 95);
            this.ticketPanel.Name = "ticketPanel";
            this.ticketPanel.Size = new System.Drawing.Size(385, 200);
            this.ticketPanel.TabIndex = 7;
            this.ticketPanel.Visible = false;
            // 
            // ticketLength
            // 
            this.ticketLength.AutoSize = true;
            this.ticketLength.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(23)))), ((int)(((byte)(79)))));
            this.ticketLength.Font = new System.Drawing.Font("Righteous", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketLength.ForeColor = System.Drawing.Color.White;
            this.ticketLength.Location = new System.Drawing.Point(317, 181);
            this.ticketLength.Name = "ticketLength";
            this.ticketLength.Size = new System.Drawing.Size(67, 17);
            this.ticketLength.TabIndex = 12;
            this.ticketLength.Text = "[Num]min.";
            // 
            // ticketAgeLimit
            // 
            this.ticketAgeLimit.AutoSize = true;
            this.ticketAgeLimit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(23)))), ((int)(((byte)(79)))));
            this.ticketAgeLimit.Font = new System.Drawing.Font("Righteous", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketAgeLimit.ForeColor = System.Drawing.Color.White;
            this.ticketAgeLimit.Location = new System.Drawing.Point(237, 2);
            this.ticketAgeLimit.Name = "ticketAgeLimit";
            this.ticketAgeLimit.Size = new System.Drawing.Size(50, 17);
            this.ticketAgeLimit.TabIndex = 11;
            this.ticketAgeLimit.Text = "[Num]+";
            // 
            // ticketUID
            // 
            this.ticketUID.AutoSize = true;
            this.ticketUID.Font = new System.Drawing.Font("Century Gothic", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ticketUID.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ticketUID.Location = new System.Drawing.Point(17, 181);
            this.ticketUID.Name = "ticketUID";
            this.ticketUID.Size = new System.Drawing.Size(161, 13);
            this.ticketUID.TabIndex = 10;
            this.ticketUID.Text = "UID: 2158.212600.982959.463.48873";
            // 
            // ticketPrice
            // 
            this.ticketPrice.AutoSize = true;
            this.ticketPrice.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ticketPrice.Location = new System.Drawing.Point(71, 137);
            this.ticketPrice.Name = "ticketPrice";
            this.ticketPrice.Size = new System.Drawing.Size(84, 16);
            this.ticketPrice.TabIndex = 9;
            this.ticketPrice.Text = "[Цена] руб.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(17, 137);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Цена:";
            // 
            // ticketPlace
            // 
            this.ticketPlace.AutoSize = true;
            this.ticketPlace.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ticketPlace.Location = new System.Drawing.Point(71, 107);
            this.ticketPlace.Name = "ticketPlace";
            this.ticketPlace.Size = new System.Drawing.Size(106, 16);
            this.ticketPlace.TabIndex = 7;
            this.ticketPlace.Text = "[Номер места]";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(17, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Место:";
            // 
            // ticketHall
            // 
            this.ticketHall.AutoSize = true;
            this.ticketHall.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ticketHall.Location = new System.Drawing.Point(71, 77);
            this.ticketHall.Name = "ticketHall";
            this.ticketHall.Size = new System.Drawing.Size(90, 16);
            this.ticketHall.TabIndex = 5;
            this.ticketHall.Text = "[Номер] зал.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(17, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Сеанс:";
            // 
            // ticketDate
            // 
            this.ticketDate.AutoSize = true;
            this.ticketDate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ticketDate.Location = new System.Drawing.Point(71, 48);
            this.ticketDate.Name = "ticketDate";
            this.ticketDate.Size = new System.Drawing.Size(51, 16);
            this.ticketDate.TabIndex = 3;
            this.ticketDate.Text = "[Дата]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(17, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Дата:";
            // 
            // ticketImage
            // 
            this.ticketImage.ImageLocation = "images/2/logo.jpg";
            this.ticketImage.Location = new System.Drawing.Point(235, 0);
            this.ticketImage.Name = "ticketImage";
            this.ticketImage.Size = new System.Drawing.Size(150, 200);
            this.ticketImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ticketImage.TabIndex = 1;
            this.ticketImage.TabStop = false;
            // 
            // ticketNameFilm
            // 
            this.ticketNameFilm.AutoSize = true;
            this.ticketNameFilm.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ticketNameFilm.Location = new System.Drawing.Point(16, 12);
            this.ticketNameFilm.Name = "ticketNameFilm";
            this.ticketNameFilm.Size = new System.Drawing.Size(98, 19);
            this.ticketNameFilm.TabIndex = 0;
            this.ticketNameFilm.Text = "[Название]";
            // 
            // labelHelper
            // 
            this.labelHelper.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelHelper.Cursor = System.Windows.Forms.Cursors.Help;
            this.labelHelper.CustomForeColor = true;
            this.labelHelper.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.labelHelper.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.labelHelper.Location = new System.Drawing.Point(623, 125);
            this.labelHelper.Name = "labelHelper";
            this.labelHelper.Size = new System.Drawing.Size(29, 29);
            this.labelHelper.TabIndex = 6;
            this.labelHelper.Text = "?";
            this.labelHelper.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelHelper.MouseLeave += new System.EventHandler(this.labelHelper_MouseLeave);
            this.labelHelper.MouseHover += new System.EventHandler(this.labelHelper_MouseHover);
            // 
            // buttonSearchTicketUID
            // 
            this.buttonSearchTicketUID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSearchTicketUID.Location = new System.Drawing.Point(470, 125);
            this.buttonSearchTicketUID.Name = "buttonSearchTicketUID";
            this.buttonSearchTicketUID.Size = new System.Drawing.Size(147, 29);
            this.buttonSearchTicketUID.TabIndex = 5;
            this.buttonSearchTicketUID.Text = "Искать";
            this.buttonSearchTicketUID.Click += new System.EventHandler(this.buttonSearchTicketUID_Click);
            // 
            // labelHelperDescription
            // 
            this.labelHelperDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.labelHelperDescription.Cursor = System.Windows.Forms.Cursors.Help;
            this.labelHelperDescription.CustomBackground = true;
            this.labelHelperDescription.CustomForeColor = true;
            this.labelHelperDescription.ForeColor = System.Drawing.Color.White;
            this.labelHelperDescription.Location = new System.Drawing.Point(0, 0);
            this.labelHelperDescription.Name = "labelHelperDescription";
            this.labelHelperDescription.Size = new System.Drawing.Size(750, 77);
            this.labelHelperDescription.TabIndex = 2;
            this.labelHelperDescription.Text = resources.GetString("labelHelperDescription.Text");
            this.labelHelperDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelHelperDescription.Visible = false;
            // 
            // metroLabel2
            // 
            this.metroLabel2.BackColor = System.Drawing.Color.White;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(112, 125);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(44, 29);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "UID:";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // titlePanelReturnTickets
            // 
            this.titlePanelReturnTickets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.titlePanelReturnTickets.Cursor = System.Windows.Forms.Cursors.Help;
            this.titlePanelReturnTickets.CustomBackground = true;
            this.titlePanelReturnTickets.CustomForeColor = true;
            this.titlePanelReturnTickets.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.titlePanelReturnTickets.ForeColor = System.Drawing.Color.White;
            this.titlePanelReturnTickets.Location = new System.Drawing.Point(0, 0);
            this.titlePanelReturnTickets.Name = "titlePanelReturnTickets";
            this.titlePanelReturnTickets.Size = new System.Drawing.Size(750, 77);
            this.titlePanelReturnTickets.TabIndex = 1;
            this.titlePanelReturnTickets.Text = "Возврат билетов";
            this.titlePanelReturnTickets.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxUID
            // 
            this.textBoxUID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxUID.Location = new System.Drawing.Point(162, 125);
            this.textBoxUID.MaxLength = 35;
            this.textBoxUID.Name = "textBoxUID";
            this.textBoxUID.Size = new System.Drawing.Size(302, 29);
            this.textBoxUID.TabIndex = 3;
            this.textBoxUID.Tag = "";
            // 
            // cinemaDataSet
            // 
            this.cinemaDataSet.DataSetName = "CinemaDataSet";
            this.cinemaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // filmsBindingSource
            // 
            this.filmsBindingSource.DataMember = "Films";
            this.filmsBindingSource.DataSource = this.cinemaDataSet;
            // 
            // filmsTableAdapter
            // 
            this.filmsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Films_generTableAdapter = null;
            this.tableAdapterManager.Films_productionTableAdapter = null;
            this.tableAdapterManager.FilmsTableAdapter = this.filmsTableAdapter;
            this.tableAdapterManager.GenerTableAdapter = null;
            this.tableAdapterManager.Hall_typeTableAdapter = null;
            this.tableAdapterManager.HallsTableAdapter = null;
            this.tableAdapterManager.NumbersTableAdapter = null;
            this.tableAdapterManager.Place_typeTableAdapter = null;
            this.tableAdapterManager.ProductionTableAdapter = null;
            this.tableAdapterManager.Sessions_listTableAdapter = null;
            this.tableAdapterManager.TicketsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CinemaTickets.CinemaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // filmsBindingNavigator
            // 
            this.filmsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.filmsBindingNavigator.BindingSource = this.filmsBindingSource;
            this.filmsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.filmsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.filmsBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.filmsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.filmsBindingNavigatorSaveItem});
            this.filmsBindingNavigator.Location = new System.Drawing.Point(0, 503);
            this.filmsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.filmsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.filmsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.filmsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.filmsBindingNavigator.Name = "filmsBindingNavigator";
            this.filmsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.filmsBindingNavigator.Size = new System.Drawing.Size(750, 25);
            this.filmsBindingNavigator.TabIndex = 7;
            this.filmsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // filmsBindingNavigatorSaveItem
            // 
            this.filmsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.filmsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("filmsBindingNavigatorSaveItem.Image")));
            this.filmsBindingNavigatorSaveItem.Name = "filmsBindingNavigatorSaveItem";
            this.filmsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.filmsBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.filmsBindingNavigatorSaveItem.Click += new System.EventHandler(this.filmsBindingNavigatorSaveItem_Click);
            // 
            // filmsDataGridView
            // 
            this.filmsDataGridView.AutoGenerateColumns = false;
            this.filmsDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.filmsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Open Sans Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.filmsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.filmsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.filmsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.filmsDataGridView.DataSource = this.filmsBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Open Sans Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.filmsDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.filmsDataGridView.Location = new System.Drawing.Point(19, 97);
            this.filmsDataGridView.MultiSelect = false;
            this.filmsDataGridView.Name = "filmsDataGridView";
            this.filmsDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.filmsDataGridView.RowHeadersVisible = false;
            this.filmsDataGridView.Size = new System.Drawing.Size(709, 376);
            this.filmsDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "№";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn1.Width = 40;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "film_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Название";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "film_year";
            this.dataGridViewTextBoxColumn3.HeaderText = "Год";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn3.Width = 35;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "film_age_limit";
            this.dataGridViewTextBoxColumn4.HeaderText = "Возрастное ограничение";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn4.Width = 80;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "film_length_min";
            this.dataGridViewTextBoxColumn5.HeaderText = "Минут";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn5.Width = 50;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "film_price_ticket";
            this.dataGridViewTextBoxColumn6.HeaderText = "Цена";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn6.Width = 45;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "film_photo";
            this.dataGridViewTextBoxColumn7.HeaderText = "Фото";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn7.Width = 90;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "film_description";
            this.dataGridViewTextBoxColumn8.HeaderText = "Описание";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "film_slogan";
            this.dataGridViewTextBoxColumn9.HeaderText = "Слоган";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn9.Width = 70;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(965, 600);
            this.ControlBox = false;
            this.Controls.Add(this.panelMainMenu);
            this.Controls.Add(this.panelAdd);
            this.Controls.Add(this.searchTicket);
            this.Controls.Add(this.panelSearch);
            this.Controls.Add(this.panelMainScreen);
            this.Controls.Add(this.panelStatisticsAndReports);
            this.Controls.Add(this.panelFilms);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.DropShadow;
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMainMenu.ResumeLayout(false);
            this.panelFilms.ResumeLayout(false);
            this.panelViewListFilms.ResumeLayout(false);
            this.panelStatisticsAndReports.ResumeLayout(false);
            this.panelSearch.ResumeLayout(false);
            this.panelMainScreen.ResumeLayout(false);
            this.panelAdd.ResumeLayout(false);
            this.panelAddFilms.ResumeLayout(false);
            this.panelAddFilms.PerformLayout();
            this.panelAddProductionCountries.ResumeLayout(false);
            this.panelAddSessions.ResumeLayout(false);
            this.panelAddGeners.ResumeLayout(false);
            this.searchTicket.ResumeLayout(false);
            this.searchTicket.PerformLayout();
            this.panelReturnTicket.ResumeLayout(false);
            this.ticketPanel.ResumeLayout(false);
            this.ticketPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ticketImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinemaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmsBindingNavigator)).EndInit();
            this.filmsBindingNavigator.ResumeLayout(false);
            this.filmsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filmsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMainMenu;
        private System.Windows.Forms.Button menuButtonSearch;
        private System.Windows.Forms.Button menuButtonExit;
        private System.Windows.Forms.Button menuButtonStatisticsAndReports;
        private System.Windows.Forms.Button menuButtonFilms;
        private System.Windows.Forms.Label labelTitleMainText;
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
        private System.Windows.Forms.Button menuButtonReturnTickets;
        private System.Windows.Forms.Panel searchTicket;
        private MetroFramework.Controls.MetroLabel titlePanelReturnTickets;
        private MetroFramework.Controls.MetroLabel labelHelperDescription;
        private System.Windows.Forms.TextBox textBoxUID;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton buttonSearchTicketUID;
        private System.Windows.Forms.Panel ticketPanel;
        private System.Windows.Forms.Label ticketNameFilm;
        private System.Windows.Forms.PictureBox ticketImage;
        private System.Windows.Forms.Label ticketPrice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label ticketPlace;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label ticketHall;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label ticketDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ticketUID;
        private System.Windows.Forms.Label ticketAgeLimit;
        private System.Windows.Forms.Label ticketLength;
        private MetroFramework.Controls.MetroLabel labelHelper;
        private System.Windows.Forms.Panel panelReturnTicket;
        private MetroFramework.Controls.MetroButton buttonReturnTicketUID;
        private CinemaDataSet cinemaDataSet;
        private System.Windows.Forms.BindingSource filmsBindingSource;
        private CinemaDataSetTableAdapters.FilmsTableAdapter filmsTableAdapter;
        private CinemaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator filmsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton filmsBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView filmsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
    }
}

