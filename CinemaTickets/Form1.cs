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

namespace CinemaTickets
{
    public partial class MainForm : MetroForm
    {
        // Object for work with CinemaTickets objectDataBase
        private readonly CinemaTickets_functionality objectDataBase; 
        // List panel for content 
        private List<Panel> listPanel; 
        // List buttons in panelAdd
        private List<Panel> listPanelAddData; 
        // List buttons in left menu
        private List<Button> listButtonInLeftMenu; 
        // List settings 
        private List<short> settings;                
        // List pictureBox for film 
        private List<PictureBox> listPictureBox; 
        // List label for film name
        private List<Label> listLabelFilmName; 
        // List label for film age limit
        private List<Label> listLabelAgeLimit; 
        // List label for length film
        private List<Label> listLabelLengthFilm; 

        public MainForm()
        {
            InitializeComponent();
            objectDataBase = new CinemaTickets_functionality();
            listPictureBox = new List<PictureBox>();
            listLabelFilmName = new List<Label>();
            listLabelAgeLimit = new List<Label>();
            listLabelLengthFilm = new List<Label>();
            settings = new List<short>() {
                20, 1
            };
            listPanel = new List<Panel>() {
                panelMainScreen, panelFilms, panelSearch,
                panelStatisticsAndReports, panelAdd, panelReturnTickets
            };
            listPanelAddData = new List<Panel>() {
                panelAddFilms, panelAddSessions, panelAddGeners,
                panelAddProductionCountries
            };
            listButtonInLeftMenu = new List<Button>() {
                menuButtonFilms, menuButtonStatisticsAndReports,
                menuButtonSearch, menuButtonAdd, menuButtonExit,
                menuButtonReturnTickets
            };

        }
        // CallBakc function atfer Form load
        private void Form1_Load(object sender, EventArgs e)
        {
            // Set settings
            setSettings();
        }
        // Set settings
        private void setSettings()
        {
            for (int i = 0; i <= settings[0]; i++)
            {
                listPictureBox.Add(new PictureBox());
                listLabelFilmName.Add(new Label());
                listLabelAgeLimit.Add(new Label());
                listLabelLengthFilm.Add(new Label());
            }
            // SET STYLE FOR LEFT MENU BUTTON
            setStyleButton(listButtonInLeftMenu);
            // SHOW MAIN SCREEN
            setVisible(panelMainScreen);
            // SET Style Films List
            setStyleFilmsList();
        }
        // Set style for list buttons
        private void setStyleButton(List<Button> e)
        {
            foreach (Button element in e)
            {
                element.ForeColor = Color.FromArgb(255, 255, 255);
                element.BackColor = Color.FromArgb(57, 57, 108);
                element.Font = new Font("Open sans", 9, FontStyle.Regular);
            }

        }
        // Set visible for panel
        private void setVisible(Panel e1, Button e2)
        {
            foreach (Panel element in listPanel) {
                element.Visible = (element == e1) ? true : false;
            }

            foreach (Button element in listButtonInLeftMenu)
            {
                if (element == e2)
                {
                    e2.Controls.Clear();
                    e2.Controls.Add(new Label() { Width = 3, Dock = DockStyle.Right, BackColor = Color.FromArgb(255, 255, 255) });
                } else {
                    element.Controls.Clear();
                }
            }

        }
        // Set visible for panel
        private void setVisible(Panel e)
        {
            foreach (Panel element in listPanel) {
                element.Visible = (element == e) ? true : false;
            }

            foreach (Button element in listButtonInLeftMenu) {
                element.Controls.Clear();
            }

        }
        // Set visible for panels in Panel_Add
        private void setVisiblePanelAdd(Panel e1)
        {
            foreach (Panel element in listPanelAddData) {
                element.Visible = (element == e1) ? true : false;
            }

        }
        // Set location and style for elements Films
        private void setStyleFilmsList()
        {
            short x = 30, y = 30;
            for (short i = 0; i < settings[0];)
            {
                listPictureBox[i].BackColor = Color.FromArgb(225, 225, 225);
                listPictureBox[i].Height = 200;
                listPictureBox[i].Width = 150;
                listPictureBox[i].Location = new Point(x, y);
                listPictureBox[i].SizeMode = PictureBoxSizeMode.StretchImage;

                listLabelFilmName[i].Text = "[Film name]";
                listLabelFilmName[i].ForeColor = Color.FromArgb(0, 0, 0);
                listLabelFilmName[i].BackColor = Color.FromArgb(1, 0, 0, 0);
                listLabelFilmName[i].Width = 150;
                listLabelFilmName[i].Height = 30;
                listLabelFilmName[i].Font = new Font("Roboto", 9, FontStyle.Regular);
                listLabelFilmName[i].TextAlign = ContentAlignment.MiddleCenter;
                listLabelFilmName[i].Location = new Point(x, y + 200);

                listLabelAgeLimit[i].Text = "18+";
                listLabelAgeLimit[i].ForeColor = Color.FromArgb(255, 255, 255);
                listLabelAgeLimit[i].BackColor = Color.FromArgb(236, 23, 79);
                listLabelAgeLimit[i].Width = 35;
                listLabelAgeLimit[i].Height = 20;
                listLabelAgeLimit[i].Font = new Font("Righteous", 8);
                listLabelAgeLimit[i].TextAlign = ContentAlignment.MiddleCenter;
                listLabelAgeLimit[i].Location = new Point(x - 2, y - 2);

                listLabelLengthFilm[i].Text = "124 min.";
                listLabelLengthFilm[i].ForeColor = Color.FromArgb(255, 255, 255);
                listLabelLengthFilm[i].BackColor = Color.FromArgb(236, 23, 79);
                listLabelLengthFilm[i].Width = 50;
                listLabelLengthFilm[i].Height = 20;
                listLabelLengthFilm[i].Font = new Font("Righteous", 8);
                listLabelLengthFilm[i].TextAlign = ContentAlignment.MiddleCenter;
                listLabelLengthFilm[i].Location = new Point(x + listPictureBox[i].Width - listLabelLengthFilm[i].Width + 2, y + listPictureBox[i].Height - listLabelLengthFilm[i].Height + 2);

                listLabelAgeLimit[i].Visible = listLabelLengthFilm[i].Visible = listLabelFilmName[i].Visible = listPictureBox[i].Visible = false;

                panelViewListFilms.Controls.Add(listLabelLengthFilm[i]);
                panelViewListFilms.Controls.Add(listLabelAgeLimit[i]);
                panelViewListFilms.Controls.Add(listPictureBox[i]);
                panelViewListFilms.Controls.Add(listLabelFilmName[i]);

                x += 180;
                i++;
                if (i % 4 == 0) {
                    y += 250;
                    x = 30;
                }
            }

            foreach (object e in objectDataBase.GetFullListOfGener()) {
                comboBoxGener.Items.Add(e);
            }
            comboBoxGener.SelectedIndex = 0;
            comboBoxYear.SelectedIndex = 0;
            buttonSearchFilmsBack.Visible = buttonSearchFilmsNext.Visible = labelNumberPage.Visible = false;
            buttonSearchFilms.Width = 437;

        }
        // Function Panel_Films
        private void loadFilmsToPanelFilms(short pageAct)
        {
            switch (pageAct)
            {
                case 0: settings[1] = 1; break;
                case 1: settings[1] += 1; break;
                case -1: settings[1] -= 1; break;
            }

            List<List<object>> queryRes = objectDataBase.FindFilmsByFilters_3(settings[0], settings[1], comboBoxGener.SelectedItem.ToString(), comboBoxYear.SelectedItem.ToString());

            for (short i = 0; i < settings[0]; i++)
            {
                if (i < queryRes.Count-1)
                {
                    listLabelFilmName[i].Text = queryRes[i][1].ToString();
                    listLabelAgeLimit[i].Text = queryRes[i][2].ToString() + "+";
                    listLabelLengthFilm[i].Text = queryRes[i][3].ToString() + " min.";
                    listPictureBox[i].ImageLocation = queryRes[i][4].ToString();
                    listLabelAgeLimit[i].Visible = listLabelLengthFilm[i].Visible = listLabelFilmName[i].Visible = listPictureBox[i].Visible = true;
                } else {
                    listLabelAgeLimit[i].Visible = listLabelLengthFilm[i].Visible = listLabelFilmName[i].Visible = listPictureBox[i].Visible = false;
                }
            }

            if (Convert.ToInt32(queryRes[queryRes.Count - 1][0]) <= settings[0] * settings[1])
            {
                buttonSearchFilmsNext.Enabled = false;
                buttonSearchFilmsBack.Enabled = true;
            } else if (Convert.ToInt32(queryRes[queryRes.Count - 1][0]) >= settings[0] * settings[1] && settings[1] == 1) {
                buttonSearchFilmsNext.Enabled = true;
                buttonSearchFilmsBack.Enabled = false;
            } else {
                buttonSearchFilmsNext.Enabled = true;
                buttonSearchFilmsBack.Enabled = true;
            }


            if (queryRes.Count-1 != 0)
            {
                buttonSearchFilmsBack.Visible = buttonSearchFilmsNext.Visible = labelNumberPage.Visible = true;
                buttonSearchFilms.Width = 174;
                titlePanelFilms.Visible = false;
                labelNumberPage.Text = settings[1] + " из " + Convert.ToInt32(queryRes[queryRes.Count - 1][0]) / settings[0];
            } else {
                buttonSearchFilmsBack.Visible = buttonSearchFilmsNext.Visible = labelNumberPage.Visible = false;
                buttonSearchFilms.Width = 437;
                titlePanelFilms.Text = "По вашему запросу ничего не найдено :(";
                titlePanelFilms.Visible = true;
            }

        }
        // Panel TitleMainText
        private void labelTitleMainText_Click(object sender, EventArgs e) => setVisible(panelMainScreen);
        // Panel Films
        private void menuButtonFilms_Click(object sender, EventArgs e) => setVisible(panelFilms, menuButtonFilms);
        private void buttonSearchFilms_Click(object sender, EventArgs e) => loadFilmsToPanelFilms(0);
        private void buttonSearchFilmsBack_Click(object sender, EventArgs e) => loadFilmsToPanelFilms(-1);
        private void buttonSearchFilmsNext_Click(object sender, EventArgs e) => loadFilmsToPanelFilms(1);
        // Panel StatisticsAndReport
        private void menuButtonStatisticsAndReport_Click(object sender, EventArgs e) => setVisible(panelStatisticsAndReports, menuButtonStatisticsAndReports);
        // Panel Search
        private void menuButtonSearch_Click(object sender, EventArgs e) => setVisible(panelSearch, menuButtonSearch);
        // Panel Add new data
        private void menuButtonAdd_Click(object sender, EventArgs e) => setVisible(panelAdd, menuButtonAdd);
        private void menuButtonReturnTickets_Click(object sender, EventArgs e) => setVisible(panelReturnTickets, menuButtonReturnTickets);
        private void buttonAddFilm_Click(object sender, EventArgs e) => setVisiblePanelAdd(panelAddFilms);
        private void buttonAddSession_Click(object sender, EventArgs e) => setVisiblePanelAdd(panelAddSessions);
        private void buttonAddGener_Click(object sender, EventArgs e) => setVisiblePanelAdd(panelAddGeners);
        private void buttonAddProductionCountries_Click(object sender, EventArgs e) => setVisiblePanelAdd(panelAddProductionCountries);
        // Button Exit
        private void menuButton_Exit_Click(object sender, EventArgs e) => Close();

    }

}
