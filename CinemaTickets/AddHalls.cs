using System;
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
    public partial class AddHalls : Form
    {
        public AddHalls()
        {
            InitializeComponent();
        }

        private void hallsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.hallsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cinemaDataSet);

        }

        private void place_typeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.place_typeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cinemaDataSet);

        }

        private void hall_typeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.hall_typeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cinemaDataSet);

        }

        private void AddHalls_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cinemaDataSet.Place_type". При необходимости она может быть перемещена или удалена.
            this.place_typeTableAdapter.Fill(this.cinemaDataSet.Place_type);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cinemaDataSet.Halls". При необходимости она может быть перемещена или удалена.
            this.hallsTableAdapter.Fill(this.cinemaDataSet.Halls);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cinemaDataSet.Hall_type". При необходимости она может быть перемещена или удалена.
            this.hall_typeTableAdapter.Fill(this.cinemaDataSet.Hall_type);

        }
    }
}
