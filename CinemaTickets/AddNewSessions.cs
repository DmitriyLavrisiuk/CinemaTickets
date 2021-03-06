﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaTickets
{
    public partial class AddNewSessions : Form
    {
        public AddNewSessions()
        {
            InitializeComponent();
        }

        private void sessions_listBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sessions_listBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mainCinemaDataSet);

        }

        private void AddNewSessions_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mainCinemaDataSet.Sessions_list". При необходимости она может быть перемещена или удалена.
            this.sessions_listTableAdapter.Fill(this.mainCinemaDataSet.Sessions_list);

        }
    }
}
