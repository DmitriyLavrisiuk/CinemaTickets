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
        private readonly My_SqlConnection objConnection;    // Object for work with library Sql
        private List<Panel> list_panel;                     // List panel for content 
        private List<Button> list_buttonInLeftMenu;         // List buttons in left menu





        // => Constructor
        public MainForm()
        {
            InitializeComponent();
            objConnection = new My_SqlConnection();
            List_panel = new List<Panel>() { Panel_MainScreen, Panel_Films, Panel_Search, Panel_StatisticsAndReport };
            List_buttonInLeftMenu = new List<Button>() { MenuButton_Films, MenuButton_StatisticsAndReport, MenuButton_Search, MenuButton_Exit };
        }
    




        // => Properties
        public My_SqlConnection ObjConnection => objConnection;
        public List<Panel> List_panel { get => list_panel; set => list_panel = value; }
        public List<Button> List_buttonInLeftMenu { get => list_buttonInLeftMenu; set => list_buttonInLeftMenu = value; }





        // => Methods
        /* Set style for list buttons */
        public void Set_StyleButton(List<Button> e)
        {
            foreach (Button element in e)
            {
                element.ForeColor = Color.FromArgb(255, 255, 255);
                element.BackColor = Color.FromArgb(57, 57, 108);
                element.Font = new Font("MS Reference Sans Serif", 8, FontStyle.Regular);
            }
        }

        /* Set style for one button */
        public void Set_StyleButton(Button e)
        {
            e.ForeColor = Color.FromArgb(255, 255, 255);
            e.BackColor = Color.FromArgb(57, 57, 108);
            e.Font = new Font("MS Reference Sans Serif", 8, FontStyle.Regular);
        }

        /* Set visible for panel and change color active button */
        public void Set_visible(Panel e1, Button e2)
        {
            foreach(Panel element in List_panel)
                element.Visible = (element == e1) ? true : false;

            foreach (Button element in List_buttonInLeftMenu)
                element.BackColor = (element == e2) ? Color.FromArgb(49, 49, 93) : Color.FromArgb(57, 57, 108);
        }

        /* Set visible for panel*/
        public void Set_visible(Panel e)
        {
            foreach (Panel element in List_panel)
                element.Visible = (element == e) ? true : false;
        }

        /* Form load */
        private void Form1_Load(object sender, EventArgs e)
        {
            // SET STYLE FOR LEFT MENU BUTTON
            Set_StyleButton(List_buttonInLeftMenu);
        }

        // Action with elements in left menu:
        // 1. Label  [CinemaTickets] -> [Panel_MainScreen]
        // 2. Button [Фильмы] -> [Panel_Films]
        // 3. Button [Статистика и отчеты] -> [Panel_StatisticsAndReport]
        // 4. Button [Поиск] -> [Panel_Search]
        // 5. Button [Выход] -> Close();
        private void Label_TitleMainText_Click(object sender, EventArgs e)              => Set_visible(Panel_MainScreen);
        private void MenuButton_Films_Click(object sender, EventArgs e)                 => Set_visible(Panel_Films, MenuButton_Films);
        private void MenuButton_StatisticsAndReport_Click(object sender, EventArgs e)   => Set_visible(Panel_StatisticsAndReport, MenuButton_StatisticsAndReport);
        private void MenuButton_Search_Click(object sender, EventArgs e)                => Set_visible(Panel_Search, MenuButton_Search);
        private void MenuButton_Exit_Click(object sender, EventArgs e)                  => Close();
    }
}
