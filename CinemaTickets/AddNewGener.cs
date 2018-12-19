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
    public partial class AddNewGener : Form
    {
        public AddNewGener()
        {
            InitializeComponent();
        }

        private void generBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.generBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mainCinemaDataSet);

        }

        private void AddNewGener_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mainCinemaDataSet.Gener". При необходимости она может быть перемещена или удалена.
            this.generTableAdapter.Fill(this.mainCinemaDataSet.Gener);

        }
    }
}
