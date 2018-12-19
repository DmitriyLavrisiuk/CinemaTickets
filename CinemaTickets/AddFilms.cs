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
    public partial class AddFilms : Form
    {
        public AddFilms()
        {
            InitializeComponent();
        }

        private void filmsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.filmsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cinemaDataSet);

        }

        private void AddFilms_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cinemaDataSet.Films". При необходимости она может быть перемещена или удалена.
            this.filmsTableAdapter.Fill(this.cinemaDataSet.Films);

        }
    }
}
