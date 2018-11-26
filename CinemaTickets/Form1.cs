using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace CinemaTickets
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

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
    }
}
