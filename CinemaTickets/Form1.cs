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
        private List<Panel> list_panel;



        // => Constructor
        public MainForm()
        {
            InitializeComponent();
            objConnection = new My_SqlConnection();
            List_panel = new List<Panel>() { Panel_MainScreen, Panel_Films, Panel_Search, Panel_StatisticsAndReport };
        }




        // => Properties
        public My_SqlConnection _objConnection => objConnection;
        public List<Panel> List_panel { get => list_panel; set => list_panel = value; }




        // => Methods
        /* Set style for button */
        public void Set_StyleButton(Button menuButton)
        {
            menuButton.ForeColor = Color.FromArgb(255, 255, 255);
            menuButton.BackColor = Color.FromArgb(57, 57, 108);
            menuButton.Font = new Font("MS Reference Sans Serif", 8, FontStyle.Regular);
        }

        /* Set visible for panel */
        public void Set_visible(Panel e)
        {
            foreach(Panel element in List_panel)
                element.Visible = (element == e) ? true : false;
        }

        /* Form load */
        private void Form1_Load(object sender, EventArgs e)
        {
            // SET STYLE FOR LEFT MENU BUTTON
            Set_StyleButton(menuButton_Films);
            Set_StyleButton(MenuButton_StatisticsAndReport);
            Set_StyleButton(menuButton_Exit);
            Set_StyleButton(MenuButton_Search);
        }

        // Action with elements in left menu:
        // 1. Label  [CinemaTickets] -> [Panel_MainScreen]
        // 2. Button [Фильмы] -> [Panel_Films]
        // 3. Button [Статистика и отчеты] -> [Panel_StatisticsAndReport]
        // 4. Button [Поиск] -> [Panel_Search]
        // 5. Button [Выход] -> Close();
        private void Label_TitleMainText_Click(object sender, EventArgs e) => Set_visible(Panel_MainScreen);
        private void MenuButton_Films_Click(object sender, EventArgs e) => Set_visible(Panel_Films);
        private void MenuButton_StatisticsAndReport_Click(object sender, EventArgs e) => Set_visible(Panel_StatisticsAndReport);
        private void MenuButton_Search_Click(object sender, EventArgs e) => Set_visible(Panel_Search);
        private void MenuButton_Exit_Click(object sender, EventArgs e) => Close();
    }
}
