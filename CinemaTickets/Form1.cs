using System;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

// My library
using sqlConnection;

namespace CinemaTickets
{
    public partial class MainForm : MetroForm
    {
        // => Fields
        private readonly My_SqlConnection objConnection;

        // => Constructor
        public MainForm()
        {
            InitializeComponent();
            objConnection = new My_SqlConnection();
        }

        // => Properties
        public My_SqlConnection _objConnection => objConnection;

        // => Methods
        /* Set style for button */
        public void Set_StyleButton(Button menuButton)
        {
            menuButton.ForeColor = Color.FromArgb(255, 255, 255);
            menuButton.BackColor = Color.FromArgb(57, 57, 108);
            menuButton.Font = new Font("MS Reference Sans Serif", 8, FontStyle.Regular);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // SET STYLE FOR LEFT MENU BUTTON
            Set_StyleButton(menuButton_Films);
            Set_StyleButton(menuButton_Statistic);
            Set_StyleButton(menuButton_Exit);
            Set_StyleButton(menuButton_Search);
        }

        private void menuButton_Films_Click(object sender, EventArgs e)
        {

        }
    }
}
