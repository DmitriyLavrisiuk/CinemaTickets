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
        // List for film 
        private List<PictureBox> listPictureBox; 
        private List<Label> listLabelFilmName; 
        private List<Label> listLabelAgeLimit; 
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
                10, 1
            };
            listPanel = new List<Panel>()
            {
                panelMainScreen, panelFilms, panelSearch,
                panelStatisticsAndReports, panelAdd, searchTicket
            };
            listButtonInLeftMenu = new List<Button>()
            {
                menuButtonFilms, menuButtonStatisticsAndReports,
                menuButtonSearch, menuButtonAdd, menuButtonExit,
                menuButtonReturnTickets
            };
            panelSearch.Controls.Add(ticketPanel);
            panelSearch.Controls.Remove(ticketPanel);

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
            // Set style for elements
            setStyleForElements();
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
        private void setStyleForElements()
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
                listLabelLengthFilm[i].Location = new Point(x +
                listPictureBox[i].Width - listLabelLengthFilm[i].Width + 2, y +
                listPictureBox[i].Height - listLabelLengthFilm[i].Height + 2);

                listLabelAgeLimit[i].Visible = listLabelLengthFilm[i].Visible =
                listLabelFilmName[i].Visible = listPictureBox[i].Visible = false;

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
            foreach (object e in objectDataBase.getFullListOfGener()) {
                comboBoxGener.Items.Add(e);
            }
            comboBoxGener.SelectedIndex = comboBoxYear.SelectedIndex = 0;
            buttonSearchFilmsBack.Visible = buttonSearchFilmsNext.Visible =
                labelNumberPage.Visible = false;
            buttonSearchFilms.Width = 437;
            
        }
        private void toggleHelper(bool state)
        {
            labelHelperDescription.Visible = (state) ? true : false;
        }
        private void drawTicket(object name, object date, object hall, object numbePlace, object price, object uid, object ageLimit, object length, object image, Panel namePanel, short x, short y)
        {
            ticketNameFilm.Text = name.ToString();
            ticketDate.Text = date.ToString();
            ticketHall.Text = hall.ToString() + " зал.";
            ticketPlace.Text = numbePlace.ToString();
            ticketPrice.Text = price.ToString() + " руб.";
            ticketUID.Text = "UID: " + uid.ToString();
            ticketAgeLimit.Text = ageLimit.ToString() + "+";
            ticketLength.Text = length.ToString() + "min.";
            ticketLength.Location = new Point(ticketPanel.Width - ticketLength.Width - 1, ticketPanel.Height - ticketLength.Height - 1);
            ticketImage.ImageLocation = image.ToString();
            ticketPanel.Location = new Point(x, y);
            namePanel.Controls.Add(ticketPanel);
            ticketPanel.Visible = true;
        }
        private void searchTicketUID()
        {
            List<object> result = objectDataBase.getAllInformationAboutTicketByUID(textBoxUID.Text);
            if (result.Count != 0)
            {
                drawTicket(result[0], result[1], result[2], result[3], result[4], result[5], result[6], result[7], result[8], panelReturnTicket, 185, 95);
                panelReturnTicket.Visible = true;
            }
            else
            {
                panelReturnTicket.Visible = false;
                MessageBox.Show("Билет с таким UID не найден.");
            }
        }
        private void returnTicketUID()
        {
            List<object> result = objectDataBase.returnTicket(textBoxUID.Text);
            MessageBox.Show(result[0].ToString());

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

            List<List<object>> queryRes = objectDataBase.findFilmsByFilters_3(settings[0], settings[1], comboBoxGener.SelectedItem.ToString(), comboBoxYear.SelectedItem.ToString());
            
            for (short i = 0; i < settings[0]; i++)
            {
                if (i < queryRes.Count - 1)
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

            if (Convert.ToInt32(queryRes[queryRes.Count - 1][0]) / settings[0] <= 1)
            {
                buttonSearchFilmsNext.Enabled = false;
                buttonSearchFilmsBack.Enabled = false;
            }
            else if (settings[1] >= Convert.ToInt32(queryRes[queryRes.Count - 1][0]) / settings[0])
            {
                buttonSearchFilmsNext.Enabled = false;
                buttonSearchFilmsBack.Enabled = true;
            }
            else
            {
                buttonSearchFilmsNext.Enabled = true;
                buttonSearchFilmsBack.Enabled = false;
            }
            
            if (queryRes.Count-1 != 0)
            {
                buttonSearchFilmsBack.Visible = buttonSearchFilmsNext.Visible = labelNumberPage.Visible = true;
                buttonSearchFilms.Width = 174;
                titlePanelFilms.Visible = false;
                int buf = (Convert.ToInt32(queryRes[queryRes.Count - 1][0]) / settings[0] == 0) ? 1 : Convert.ToInt32(queryRes[queryRes.Count - 1][0]) / settings[0];
                labelNumberPage.Text = settings[1] + " из " + buf.ToString();
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
        
        // Panel return ticket
        private void menuButtonReturnTickets_Click(object sender, EventArgs e) => setVisible(searchTicket, menuButtonReturnTickets);
        private void buttonSearchTicketUID_Click(object sender, EventArgs e) => searchTicketUID();
        private void buttonReturnTicketUID_Click(object sender, EventArgs e) => returnTicketUID();
        private void labelHelper_MouseHover(object sender, EventArgs e) => toggleHelper(true);
        private void labelHelper_MouseLeave(object sender, EventArgs e) => toggleHelper(false);
        
        // Panel Add new data
        private void menuButtonAdd_Click(object sender, EventArgs e) => setVisible(panelAdd, menuButtonAdd);
        private void buttonAddFilm_Click(object sender, EventArgs e) {
            AddFilms newForm = new AddFilms();
            newForm.Show();
        }
        private void buttonAddSession_Click(object sender, EventArgs e) {
            AddSessions newForm = new AddSessions();
            newForm.Show();
        }
        private void buttonAddGener_Click(object sender, EventArgs e) {
            AddGeners newForm = new AddGeners();
            newForm.Show();
        }
        private void buttonAddProductionCountries_Click(object sender, EventArgs e) {
            AddProductionCountries newForm = new AddProductionCountries();
            newForm.Show();
        }
        private void buttonAddHalls_Click(object sender, EventArgs e) {
            AddHalls newForm = new AddHalls();
            newForm.Show();
        }
        private void buttonAddGenerToFilm_Click(object sender, EventArgs e)
        {
            AddGenersToFilm newForm = new AddGenersToFilm();
            newForm.Show();
        }
        private void buttonAddProductionCountriesToFilm_Click(object sender, EventArgs e)
        {
            AddProductionCountriesToFilm newForm = new AddProductionCountriesToFilm();
            newForm.Show();
        }

        // Button Exit
        private void menuButton_Exit_Click(object sender, EventArgs e) => Close();
    }

}
