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
            this.menuButton_Search = new System.Windows.Forms.Button();
            this.menuButton_Exit = new System.Windows.Forms.Button();
            this.menuButton_Statistic = new System.Windows.Forms.Button();
            this.menuButton_Films = new System.Windows.Forms.Button();
            this.Panel_Cinema = new System.Windows.Forms.Panel();
            this.Panel_MainMenu.SuspendLayout();
            this.Panel_LabelInMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_MainMenu
            // 
            this.Panel_MainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.Panel_MainMenu.Controls.Add(this.Panel_LabelInMainMenu);
            this.Panel_MainMenu.Controls.Add(this.menuButton_Search);
            this.Panel_MainMenu.Controls.Add(this.menuButton_Exit);
            this.Panel_MainMenu.Controls.Add(this.menuButton_Statistic);
            this.Panel_MainMenu.Controls.Add(this.menuButton_Films);
            this.Panel_MainMenu.ForeColor = System.Drawing.Color.Crimson;
            this.Panel_MainMenu.Location = new System.Drawing.Point(-1, -2);
            this.Panel_MainMenu.Name = "Panel_MainMenu";
            this.Panel_MainMenu.Size = new System.Drawing.Size(214, 501);
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
            this.Label_TitleMainText.TabIndex = 8;
            this.Label_TitleMainText.Text = "CinemaTickets";
            this.Label_TitleMainText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuButton_Search
            // 
            this.menuButton_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(105)))));
            this.menuButton_Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuButton_Search.FlatAppearance.BorderSize = 0;
            this.menuButton_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuButton_Search.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuButton_Search.ForeColor = System.Drawing.Color.White;
            this.menuButton_Search.Location = new System.Drawing.Point(0, 164);
            this.menuButton_Search.Name = "menuButton_Search";
            this.menuButton_Search.Size = new System.Drawing.Size(215, 40);
            this.menuButton_Search.TabIndex = 7;
            this.menuButton_Search.Text = "Поиск";
            this.menuButton_Search.UseVisualStyleBackColor = false;
            // 
            // menuButton_Exit
            // 
            this.menuButton_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(105)))));
            this.menuButton_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuButton_Exit.FlatAppearance.BorderSize = 0;
            this.menuButton_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuButton_Exit.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuButton_Exit.ForeColor = System.Drawing.Color.White;
            this.menuButton_Exit.Location = new System.Drawing.Point(0, 461);
            this.menuButton_Exit.Name = "menuButton_Exit";
            this.menuButton_Exit.Size = new System.Drawing.Size(214, 40);
            this.menuButton_Exit.TabIndex = 6;
            this.menuButton_Exit.Text = "Выход";
            this.menuButton_Exit.UseVisualStyleBackColor = false;
            // 
            // menuButton_Statistic
            // 
            this.menuButton_Statistic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(105)))));
            this.menuButton_Statistic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuButton_Statistic.FlatAppearance.BorderSize = 0;
            this.menuButton_Statistic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuButton_Statistic.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuButton_Statistic.ForeColor = System.Drawing.Color.White;
            this.menuButton_Statistic.Location = new System.Drawing.Point(0, 122);
            this.menuButton_Statistic.Name = "menuButton_Statistic";
            this.menuButton_Statistic.Size = new System.Drawing.Size(214, 40);
            this.menuButton_Statistic.TabIndex = 5;
            this.menuButton_Statistic.Text = "Статистика и отчеты";
            this.menuButton_Statistic.UseVisualStyleBackColor = false;
            // 
            // menuButton_Films
            // 
            this.menuButton_Films.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(105)))));
            this.menuButton_Films.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuButton_Films.FlatAppearance.BorderSize = 0;
            this.menuButton_Films.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuButton_Films.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuButton_Films.ForeColor = System.Drawing.Color.White;
            this.menuButton_Films.Location = new System.Drawing.Point(0, 80);
            this.menuButton_Films.Name = "menuButton_Films";
            this.menuButton_Films.Size = new System.Drawing.Size(214, 40);
            this.menuButton_Films.TabIndex = 4;
            this.menuButton_Films.Text = "Фильмы";
            this.menuButton_Films.UseVisualStyleBackColor = false;
            this.menuButton_Films.Click += new System.EventHandler(this.menuButton_Films_Click);
            // 
            // Panel_Cinema
            // 
            this.Panel_Cinema.Location = new System.Drawing.Point(212, 0);
            this.Panel_Cinema.Name = "Panel_Cinema";
            this.Panel_Cinema.Size = new System.Drawing.Size(707, 498);
            this.Panel_Cinema.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 498);
            this.Controls.Add(this.Panel_Cinema);
            this.Controls.Add(this.Panel_MainMenu);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Panel_MainMenu.ResumeLayout(false);
            this.Panel_LabelInMainMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_MainMenu;
        private System.Windows.Forms.Button menuButton_Search;
        private System.Windows.Forms.Button menuButton_Exit;
        private System.Windows.Forms.Button menuButton_Statistic;
        private System.Windows.Forms.Button menuButton_Films;
        private System.Windows.Forms.Label Label_TitleMainText;
        private System.Windows.Forms.Panel Panel_LabelInMainMenu;
        private System.Windows.Forms.Panel Panel_Cinema;
    }
}

