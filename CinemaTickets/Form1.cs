using System;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Collections.Generic;
using dbCinemaTickets;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Collections;
using System.Data.SqlClient;



// setting - Set DEFAULT settings for the application
// Settings[0] - Count pictureBox in list_pictureBoxViewFilms
// Доделать пагинацию и сделать переключение по страницам, а так же проявлять длительность фильма по наведению на PictureBox



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
            settings = new List<short>() { 2, 1 };
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
                element.Font = new Font("Open sans", 9, FontStyle.Regular);
            }
        }
        private void Set_Visible(Panel e1, Button e2)       // Set visible for panel 
        {
            foreach (Panel element in list_panel)
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
                list_PictureBox[i].SizeMode = PictureBoxSizeMode.StretchImage;

                list_Label_FilmName[i].Text = "[Film name]";
                list_Label_FilmName[i].ForeColor = Color.FromArgb(0, 0, 0);
                list_Label_FilmName[i].BackColor = Color.FromArgb(1, 0, 0, 0);
                list_Label_FilmName[i].Width = 150;
                list_Label_FilmName[i].Height = 30;
                list_Label_FilmName[i].Font = new Font("Roboto", 9, FontStyle.Regular);
                list_Label_FilmName[i].TextAlign = ContentAlignment.MiddleCenter;
                list_Label_FilmName[i].Location = new Point(x, y + 200);

                list_Label_AgeLimit[i].Text = "18+";
                list_Label_AgeLimit[i].ForeColor = Color.FromArgb(255, 255, 255);
                list_Label_AgeLimit[i].BackColor = Color.FromArgb(236, 23, 79);
                list_Label_AgeLimit[i].Width = 35;
                list_Label_AgeLimit[i].Height = 20;
                list_Label_AgeLimit[i].Font = new Font("Righteous", 8);
                list_Label_AgeLimit[i].TextAlign = ContentAlignment.MiddleCenter;
                list_Label_AgeLimit[i].Location = new Point(x - 2, y - 2);

                list_Label_LengthFilm[i].Text = "124 min.";
                list_Label_LengthFilm[i].ForeColor = Color.FromArgb(255, 255, 255);
                list_Label_LengthFilm[i].BackColor = Color.FromArgb(236, 23, 79);
                list_Label_LengthFilm[i].Width = 50;
                list_Label_LengthFilm[i].Height = 20;
                list_Label_LengthFilm[i].Font = new Font("Righteous", 8);
                list_Label_LengthFilm[i].TextAlign = ContentAlignment.MiddleCenter;
                list_Label_LengthFilm[i].Location = new Point(x + list_PictureBox[i].Width - list_Label_LengthFilm[i].Width + 2, y + list_PictureBox[i].Height - list_Label_LengthFilm[i].Height + 2);

                list_Label_AgeLimit[i].Visible = list_Label_LengthFilm[i].Visible = list_Label_FilmName[i].Visible = list_PictureBox[i].Visible = false;

                Panel_ViewListFilms.Controls.Add(list_Label_LengthFilm[i]);
                Panel_ViewListFilms.Controls.Add(list_Label_AgeLimit[i]);
                Panel_ViewListFilms.Controls.Add(list_PictureBox[i]);
                Panel_ViewListFilms.Controls.Add(list_Label_FilmName[i]);

                x += 180;
                i++;
                if (i % 4 == 0) { y += 250; x = 30; }
            }

            foreach (object e in db.GetFullListOfGener())
                ComboBox_Gener.Items.Add(e);
            ComboBox_Gener.SelectedIndex = 0;
            ComboBox_Year.SelectedIndex = 0;
            Button_SearchFilms_Back.Visible = Button_SearchFilms_Next.Visible = Label_NumberPage.Visible = false;
            Button_SearchFilms.Width = 437;
        }
        private void LoadFilmsTo_Panel_Films(short pageAct) // Function Panel_Films 
        {
            switch (pageAct)
            {
                case 0: settings[1] = 1; break;
                case 1: settings[1] += 1; break;
                case -1: settings[1] -= 1; break;
            }

            List<List<object>> queryRes = db.FindFilmsByFilters_3(settings[0], settings[1], ComboBox_Gener.SelectedItem.ToString(), ComboBox_Year.SelectedItem.ToString());

            for (short i = 0; i < settings[0]; i++)
            {
                if (i < queryRes.Count-1)
                {
                    list_Label_FilmName[i].Text = queryRes[i][1].ToString();
                    list_Label_AgeLimit[i].Text = queryRes[i][2].ToString() + "+";
                    list_Label_LengthFilm[i].Text = queryRes[i][3].ToString() + " min.";
                    list_PictureBox[i].ImageLocation = queryRes[i][4].ToString();
                    list_Label_AgeLimit[i].Visible = list_Label_LengthFilm[i].Visible = list_Label_FilmName[i].Visible = list_PictureBox[i].Visible = true;
                }
                else
                {
                    list_Label_AgeLimit[i].Visible = list_Label_LengthFilm[i].Visible = list_Label_FilmName[i].Visible = list_PictureBox[i].Visible = false;
                }
            }

            if (Convert.ToInt32(queryRes[queryRes.Count - 1][0]) <= settings[0] * settings[1])
            {
                Button_SearchFilms_Next.Enabled = false;
                Button_SearchFilms_Back.Enabled = true;
            }
            else if (Convert.ToInt32(queryRes[queryRes.Count - 1][0]) >= settings[0] * settings[1] && settings[1] == 1)
            {
                Button_SearchFilms_Next.Enabled = true;
                Button_SearchFilms_Back.Enabled = false;
            }
            else
            {
                Button_SearchFilms_Next.Enabled = true;
                Button_SearchFilms_Back.Enabled = true;
            }


            if (queryRes.Count-1 != 0)
            {
                Button_SearchFilms_Back.Visible = Button_SearchFilms_Next.Visible = Label_NumberPage.Visible = true;
                Button_SearchFilms.Width = 174;
                MainTitle_Panel_Films.Visible = false;
                Label_NumberPage.Text = settings[1] + " из " + Convert.ToInt32(queryRes[queryRes.Count - 1][0]) / settings[0];
            }
            else
            {
                Button_SearchFilms_Back.Visible = Button_SearchFilms_Next.Visible = Label_NumberPage.Visible = false;
                Button_SearchFilms.Width = 437;
                MainTitle_Panel_Films.Text = "По вашему запросу ничего не найдено :(";
                MainTitle_Panel_Films.Visible = true;
            }
        }

        // Panel TitleMainText
        private void Label_TitleMainText_Click(object sender, EventArgs e) => Set_Visible(Panel_MainScreen);

        // Panel Films
        private void MenuButton_Films_Click(object sender, EventArgs e) => Set_Visible(Panel_Films, MenuButton_Films);
        private void Button_SearchFilms_Click(object sender, EventArgs e) => LoadFilmsTo_Panel_Films(0);
        private void Button_SearchFilms_Back_Click(object sender, EventArgs e) => LoadFilmsTo_Panel_Films(-1);
        private void Button_SearchFilms_Next_Click(object sender, EventArgs e) => LoadFilmsTo_Panel_Films(1);

        // Panel StatisticsAndReport
        private void MenuButton_StatisticsAndReport_Click(object sender, EventArgs e) => Set_Visible(Panel_StatisticsAndReport, MenuButton_StatisticsAndReport);

        // Panel Search
        private void MenuButton_Search_Click(object sender, EventArgs e) => Set_Visible(Panel_Search, MenuButton_Search);

        // Button Exit
        private void MenuButton_Exit_Click(object sender, EventArgs e) => Close();
    }
}
