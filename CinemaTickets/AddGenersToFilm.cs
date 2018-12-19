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
    public partial class AddGenersToFilm : Form
    {
        public AddGenersToFilm()
        {
            InitializeComponent();
        }

        private void films_generBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.films_generBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cinemaDataSet);

        }

        private void AddGenersToFilm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cinemaDataSet.Films_gener". При необходимости она может быть перемещена или удалена.
            this.films_generTableAdapter.Fill(this.cinemaDataSet.Films_gener);

        }
    }
}
