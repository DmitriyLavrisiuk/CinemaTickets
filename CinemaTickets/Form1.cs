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
using dbCinemaTickets;
using System.Collections;
using System.Data.SqlClient;



// setting - Set DEFAULT settings for the application
// Settings[0] - Count pictureBox in list_pictureBoxViewFilms



namespace CinemaTickets
{
    public partial class MainForm : MetroForm
    {
        // => Fields
        private readonly CinemaTickets_functionality db;    // Object for work with CinemaTickets db
        private List<Panel> list_panel;                     // List panel for content 
        private List<Button> list_buttonInLeftMenu;         // List buttons in left menu
        private List<short> settings;                       // List settings                
        private List<PictureBox> list_PictureBox;           // -
        private List<Label> list_Label_FilmName;            // -
        private List<Label> list_Label_AgeLimit;            // -
        private List<Label> list_Label_LengthFilm;          // -




        // => Constructor
        public MainForm()
        {
            InitializeComponent();
            db = new CinemaTickets_functionality();
            list_panel = new List<Panel>() { Panel_MainScreen, Panel_Films, Panel_Search, Panel_StatisticsAndReport };
            list_buttonInLeftMenu = new List<Button>() { MenuButton_Films, MenuButton_StatisticsAndReport, MenuButton_Search, MenuButton_Exit };
            settings = new List<short>() {20};
            list_PictureBox = new List<PictureBox>();
            list_Label_FilmName = new List<Label>();
            list_Label_AgeLimit = new List<Label>();
            list_Label_LengthFilm = new List<Label>();
        }





        // => Methods
        private void Form1_Load(object sender, EventArgs e) // Form load 
        {
            // SET SETTINGS
            Set_Settings();
        }
        private void Set_Settings()                         // Set sttings 
        {
            for (int i = 0; i <= settings[0]; i++)
            {
                list_PictureBox.Add(new PictureBox());
                list_Label_FilmName.Add(new Label());
                list_Label_AgeLimit.Add(new Label());
                list_Label_LengthFilm.Add(new Label());
            }

            // SET STYLE FOR LEFT MENU BUTTON
            Set_StyleButton(list_buttonInLeftMenu);
            // SHOW MAIN SCREEN
            Set_Visible(Panel_MainScreen);
            // SET Style Films List
            Set_StyleFilmsList();
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
        private void Set_Visible(Panel e1, Button e2)       // Set visible for panel 
        {
            foreach(Panel element in list_panel)
                element.Visible = (element == e1) ? true : false;

            foreach (Button element in list_buttonInLeftMenu)
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
            foreach (Panel element in list_panel)
                element.Visible = (element == e) ? true : false;

            foreach (Button element in list_buttonInLeftMenu)
                element.Controls.Clear();
        }
        private void Set_StyleFilmsList()                   // Set location and style for elements Films 
        {
            short x = 30, y = 30;
            for (short i = 0; i < settings[0];)
            {
                list_PictureBox[i].BackColor = Color.FromArgb(225, 225, 225);
                list_PictureBox[i].Height = 200;
                list_PictureBox[i].Width = 150;
                list_PictureBox[i].Location = new Point(x, y);

                list_Label_FilmName[i].Text = "[Film name]";
                list_Label_FilmName[i].ForeColor = Color.FromArgb(0, 0, 0);
                list_Label_FilmName[i].BackColor = Color.FromArgb(5, 0, 0, 0);
                list_Label_FilmName[i].Width = 150;
                list_Label_FilmName[i].Height = 30;
                list_Label_FilmName[i].TextAlign = ContentAlignment.MiddleCenter;
                list_Label_FilmName[i].Location = new Point(x, y + 200);

                list_Label_AgeLimit[i].Text = "18+";
                list_Label_AgeLimit[i].ForeColor = Color.FromArgb(0, 0, 0);
                list_Label_AgeLimit[i].BackColor = Color.FromArgb(40, 0, 0, 0);
                list_Label_AgeLimit[i].Width = 35;
                list_Label_AgeLimit[i].Height = 20;
                list_Label_AgeLimit[i].TextAlign = ContentAlignment.MiddleCenter;
                list_Label_AgeLimit[i].Location = new Point(x, y);

                list_Label_LengthFilm[i].Text = "124 min.";
                list_Label_LengthFilm[i].ForeColor = Color.FromArgb(0, 0, 0);
                list_Label_LengthFilm[i].BackColor = Color.FromArgb(40, 0, 0, 0);
                list_Label_LengthFilm[i].Width = 50;
                list_Label_LengthFilm[i].Height = 20;
                list_Label_LengthFilm[i].TextAlign = ContentAlignment.MiddleCenter;
                list_Label_LengthFilm[i].Location = new Point(x + list_Label_FilmName[i].Width - list_Label_LengthFilm[i].Width, y);
                
                x += 180;
                i++;
                if (i % 4 == 0) { y += 250; x = 30; }
            }
            
            foreach (object e in db.GetFullListOfGener())
                ComboBox_Gener.Items.Add(e);
            ComboBox_Gener.SelectedIndex = 0;
            ComboBox_Year.SelectedIndex = 0;
            Button_SearchFilms_Back.Visible = Button_SearchFilms_Next.Visible = Label_PageInfo.Visible = false;
            Button_SearchFilms.Width = 437;
        }
        private void LoadFilmsTo_Panel_Films()              // Function Panel_Films 
        {
            MessageBox.Show("Успешно"); // - DEGUB HELP (REMOVE THIS LINE)
             
            List<List<object>> queryRes = db.FindFilmsByTwoFilters();

            for (short i = 0; i < settings[0];)
            {
                Panel_ViewListFilms.Controls.Add(list_Label_AgeLimit[i]);
                Panel_ViewListFilms.Controls.Add(list_Label_LengthFilm[i]);
                Panel_ViewListFilms.Controls.Add(list_Label_FilmName[i]);
                Panel_ViewListFilms.Controls.Add(list_PictureBox[i]);
                i++;
            }

                MessageBox.Show(queryRes[0][1].ToString());
            Button_SearchFilms_Back.Visible = Button_SearchFilms_Next.Visible = Label_PageInfo.Visible = true;
            Button_SearchFilms.Width = 162;
            MainTitle_Panel_Films.Visible = false;
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
        private void Button_SearchFilms_Click(object sender, EventArgs e)               => LoadFilmsTo_Panel_Films();
        private void MenuButton_StatisticsAndReport_Click(object sender, EventArgs e)   => Set_Visible(Panel_StatisticsAndReport, MenuButton_StatisticsAndReport);
        private void MenuButton_Search_Click(object sender, EventArgs e)                => Set_Visible(Panel_Search, MenuButton_Search);
        private void MenuButton_Exit_Click(object sender, EventArgs e)                  => Close();

    }
}
