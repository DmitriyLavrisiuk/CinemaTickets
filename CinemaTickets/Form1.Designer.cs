namespace CinemaTickets
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuButton_Search = new System.Windows.Forms.Button();
            this.menuButton_Exit = new System.Windows.Forms.Button();
            this.menuButton_Statistic = new System.Windows.Forms.Button();
            this.menuButton_Films = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.menuButton_Search);
            this.panel1.Controls.Add(this.menuButton_Exit);
            this.panel1.Controls.Add(this.menuButton_Statistic);
            this.panel1.Controls.Add(this.menuButton_Films);
            this.panel1.ForeColor = System.Drawing.Color.Crimson;
            this.panel1.Location = new System.Drawing.Point(-1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(214, 501);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(-1, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(214, 79);
            this.panel2.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Righteous", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(23)))), ((int)(((byte)(79)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 79);
            this.label1.TabIndex = 8;
            this.label1.Text = "CinemaTickets";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.menuButton_Search.Size = new System.Drawing.Size(214, 40);
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
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 498);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button menuButton_Search;
        private System.Windows.Forms.Button menuButton_Exit;
        private System.Windows.Forms.Button menuButton_Statistic;
        private System.Windows.Forms.Button menuButton_Films;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
    }
}

