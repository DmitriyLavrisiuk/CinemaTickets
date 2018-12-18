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
    public partial class AddProductionCountriesToFilm : Form
    {
        public AddProductionCountriesToFilm()
        {
            InitializeComponent();
        }

        private void films_productionBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.films_productionBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cinemaDataSet);

        }

        private void AddProductionCountriesToFilm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cinemaDataSet.Films_production". При необходимости она может быть перемещена или удалена.
            this.films_productionTableAdapter.Fill(this.cinemaDataSet.Films_production);

        }
    }
}
