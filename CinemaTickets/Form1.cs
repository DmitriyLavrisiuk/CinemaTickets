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
using sqlConnection;
using System.Collections;



// setting - Set DEFAULT settings for the application
// Settings[0] - Count pictureBox in list_pictureBoxViewFilms



namespace CinemaTickets
{
    public partial class MainForm : MetroForm
    {
        // => Fields
        private readonly My_SqlConnection objConnection;    // Object for work with library Sql
        private List<Panel> list_panel;                     // List panel for content 
        private List<Button> list_buttonInLeftMenu;         // List buttons in left menu
        private List<short> settings;                       // List settings                
        private List<object>[] list_FilmsData;              // List Object Films data. Every element contain full information about film.
        private List<PictureBox> list_PictureBox;           // -
        private List<Label> list_Label;                     // -




        // => Constructor
        public MainForm()
        {
            InitializeComponent();
            objConnection = new My_SqlConnection();
            List_panel = new List<Panel>() { Panel_MainScreen, Panel_Films, Panel_Search, Panel_StatisticsAndReport };
            List_buttonInLeftMenu = new List<Button>() { MenuButton_Films, MenuButton_StatisticsAndReport, MenuButton_Search, MenuButton_Exit };
            Settings = new List<short>() {16};
            List_FilmsData = new List<object>[] {
                new List<object>(),
                new List<object>(),
                new List<object>(),
                new List<object>(),
                new List<object>(),
                new List<object>(),
                new List<object>(),
                new List<object>(),
                new List<object>()
            };
            List_PictureBox = new List<PictureBox>();
            List_Label = new List<Label>();
            Set_Settings();
        }





        // => Properties
        public My_SqlConnection                             ObjConnection => objConnection;
        public List<Panel> List_panel                       { get; set; }
        public List<Button> List_buttonInLeftMenu           { get; set; }
        public List<short> Settings                         { get; set; }
        public List<object>[] List_FilmsData                { get; set; }
        public List<PictureBox> List_PictureBox             { get; set; }
        public List<Label> List_Label                       { get; set; }





        // => Methods
        private void Set_Settings()                         // Set sttings
        {
            for (int i = 0; i <= Settings[0]; i++)
            {
                List_PictureBox.Add(new PictureBox());
                List_Label.Add(new Label());
            }
        }
        private void Set_StyleButton(List<Button> e)        // Set style for list buttons
        {
            foreach (Button element in e)
            {
                element.ForeColor = Color.FromArgb(255, 255, 255);
                element.BackColor = Color.FromArgb(57, 57, 108);
                element.Font = new Font("MS Reference Sans Serif", 8, FontStyle.Regular);
            }
        }
        private void Set_StyleButton(Button e)              // Set style for one button
        {
            e.ForeColor = Color.FromArgb(255, 255, 255);
            e.BackColor = Color.FromArgb(57, 57, 108);
            e.Font = new Font("MS Reference Sans Serif", 8, FontStyle.Regular);
        }
        private void Set_Visible(Panel e1, Button e2)       // Set visible for panel and change color active button
        {
            switch (e1.Name) {
                case "Panel_Films":
                    Set_PropertyListFilms();
                    break;
                default:
                    break;
            }

            foreach(Panel element in List_panel)
                element.Visible = (element == e1) ? true : false;

            foreach (Button element in List_buttonInLeftMenu)
            {
                 if (element == e2)
                {
                    e2.Controls.Clear();
                    e2.Controls.Add(new Label() { Width = 3, Dock = DockStyle.Right, BackColor = Color.FromArgb(255, 255, 255) });
                }
                else
                    element.Controls.Clear();
            }
        }
        private void Set_Visible(Panel e)                   // Set visible for panel
        {
            foreach (Panel element in List_panel)
                element.Visible = (element == e) ? true : false;

            foreach (Button element in List_buttonInLeftMenu)
                element.Controls.Clear();
        }
        private void Set_PropertyListFilms()                // Function Panel_Films
        {
            if (List_PictureBox[0].Height == 50)
            {
                MessageBox.Show("Уже показанно!");
                short x = 30, y = 30;
                for(short i = 0; i < Settings[0];)
                {
                    List_PictureBox[i].BackColor = Color.FromArgb(225, 225, 225);
                    List_PictureBox[i].Location = new Point(x, y);
                    List_PictureBox[i].Height = 200;
                    List_PictureBox[i].Width = 150;

                    List_Label[i].Location = new Point(x, y + 200);
                    List_Label[i].Text = "[Film name]";
                    List_Label[i].ForeColor = Color.FromArgb(0, 0, 0);
                    List_Label[i].BackColor = Color.FromArgb(0, 0, 0, 0);
                    List_Label[i].Width = 150;
                    List_Label[i].Height = 30;
                    List_Label[i].TextAlign = ContentAlignment.MiddleCenter;
                    Panel_ViewListFilms.Controls.Add(List_Label[i]);
                    Panel_ViewListFilms.Controls.Add(List_PictureBox[i]);

                    x += 180;
                    i++;
                    if (i % 4 == 0) { y += 250; x = 30; } 
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e) // Form load
        {
            // SET STYLE FOR LEFT MENU BUTTON
            Set_StyleButton(List_buttonInLeftMenu);
            // SHOW MAIN SCREEN
            Set_Visible(Panel_MainScreen);
        }
        /* Action with elements in left menu:
         * 1. Label  [CinemaTickets] -> [Panel_MainScreen]
         * 2. Button [Фильмы] -> [Panel_Films]
         * 3. Button [Статистика и отчеты] -> [Panel_StatisticsAndReport]
         * 4. Button [Поиск] -> [Panel_Search]
         * 5. Button [Выход] -> Close();
         */
        private void Label_TitleMainText_Click(object sender, EventArgs e)              => Set_Visible(Panel_MainScreen);
        private void MenuButton_Films_Click(object sender, EventArgs e)                 => Set_Visible(Panel_Films, MenuButton_Films);
        private void MenuButton_StatisticsAndReport_Click(object sender, EventArgs e)   => Set_Visible(Panel_StatisticsAndReport, MenuButton_StatisticsAndReport);
        private void MenuButton_Search_Click(object sender, EventArgs e)                => Set_Visible(Panel_Search, MenuButton_Search);
        private void MenuButton_Exit_Click(object sender, EventArgs e)                  => Close();
    }
}
