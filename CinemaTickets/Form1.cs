using System;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Collections.Generic;
using dbCinemaTickets;
using LiveCharts;                   //Core of the library
using LiveCharts.Wpf;               //The WPF controls
using LiveCharts.WinForms;          //the WinForm wrappers

namespace CinemaTickets
{
    public partial class MainForm : MetroForm
    {
        private Application application;
        private Microsoft.Office.Interop.Excel.Workbook workBook;
        private Microsoft.Office.Interop.Excel.Worksheet worksheet;
        // Object for work with CinemaTickets objectDataBase
        private readonly CinemaTickets_functionality objectDataBase;
        // List panel for content 
        private List<Panel> listPanel;
        private List<Panel> listPanelDiagram;
        // List buttons in left menu
        private List<Button> listButtonInLeftMenu;
        // List settings 
        private List<short> settings;
        // List for films
        private List<PictureBox> listPictureBox;
        private List<Label> listLabelFilmName,
            listLabelAgeLimit,
            listLabelLengthFilm;
        // List for films search
        private List<PictureBox> listPictureBoxFilmsSearch;
        private List<Label>
            listLabelNameFilmSearch,
            listLabelYearFilmSearch,
            listLabelAgeLimitFilmSearch,
            listLabelLengthFilmSearch,
            listLabelPriceFilmSearch,
            listLabelDescriptionFilmSearch,
            listLabelSloganFilmSearch,
            listLabelGenersFilmSearch,
            listLabelProductionCountriesFilmSearch,
            listNumberPlaces;
        private List<List<object>>
            bufferArray,
            placesType;
        private int activeIndexFromBuffer;

        public MainForm()
        {
            InitializeComponent();
            objectDataBase = new CinemaTickets_functionality();
            listPictureBox = new List<PictureBox>();
            listLabelFilmName = new List<Label>();
            listLabelAgeLimit = new List<Label>();
            listLabelLengthFilm = new List<Label>();

            listPictureBoxFilmsSearch = new List<PictureBox>();
            listLabelNameFilmSearch = new List<Label>();
            listLabelYearFilmSearch = new List<Label>();
            listLabelAgeLimitFilmSearch = new List<Label>();
            listLabelLengthFilmSearch = new List<Label>();
            listLabelPriceFilmSearch = new List<Label>();
            listLabelDescriptionFilmSearch = new List<Label>();
            listLabelSloganFilmSearch = new List<Label>();
            listLabelGenersFilmSearch = new List<Label>();
            listLabelProductionCountriesFilmSearch = new List<Label>();
            placesType = new List<List<object>>();

            settings = new List<short>() {
            /*
             * settings[0] - Количество записей на странице "Фильмы"
             * settings[1] - Номер страницы результата запроса "Фильмы"
             * settings[2] - Количество записей на странице "Поиск"
             * settings[3] - Номер страницы результата запроса "Поиск"
             */
                8, 1, 2, 1
            };

            listPanel = new List<Panel>()
            {
                panelMainScreen,
                panelFilms,
                panelSearch,
                panelStatisticsAndReports,
                panelAdd,
                searchTicket
            };

            listButtonInLeftMenu = new List<Button>()
            {
                menuButtonFilms,
                menuButtonStatisticsAndReports,
                menuButtonSearch,
                menuButtonAdd,
                menuButtonExit,
                menuButtonReturnTickets
            };

            listPanelDiagram = new List<Panel>()
            {
                panelDiagram1,
                panelDiagram2,
                panelDiagram3,
                panelDiagram4
            };

            bufferArray = new List<List<object>>();
            placesType = new List<List<object>>();

            listNumberPlaces = new List<Label>()
            {
                place_1,
                place_2,
                place_3,
                place_4,
                place_5,
                place_6,
                place_7,
                place_8,
                place_9,
                place_10,
                place_11,
                place_12,
                place_13,
                place_14,
                place_15,
                place_16,
                place_17,
                place_18,
                place_19,
                place_20,
                place_21,
                place_22,
                place_23,
                place_24,
                place_25,
                place_26,
                place_27,
                place_28,
                place_29,
                place_30,
                place_31,
                place_32,
                place_33,
                place_34,
                place_35,
                place_36,
                place_37,
                place_38,
                place_39,
                place_40,
                place_41,
                place_42,
                place_43,
                place_44,
                place_45,
                place_46,
                place_47,
                place_48,
                place_49,
                place_50,
                place_51,
                place_52,
                place_53,
                place_54,
                place_55,
                place_56,
                place_57,
                place_58,
                place_59,
                place_60
            };

            panelSearch.Controls.Add(ticketPanel);
            panelSearch.Controls.Remove(ticketPanel);
        }
        // Callback function atfer Form load
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
                listPictureBox[i].Click += new EventHandler(listPictureBox_Click);
                listLabelFilmName.Add(new Label());
                listLabelAgeLimit.Add(new Label());
                listLabelLengthFilm.Add(new Label());
            }

            for (int i = 0; i <= settings[2]; i++)
            {
                listPictureBoxFilmsSearch.Add(new PictureBox());
                listLabelNameFilmSearch.Add(new Label());
                listLabelYearFilmSearch.Add(new Label());
                listLabelAgeLimitFilmSearch.Add(new Label());
                listLabelLengthFilmSearch.Add(new Label());
                listLabelPriceFilmSearch.Add(new Label());
                listLabelDescriptionFilmSearch.Add(new Label());
                listLabelSloganFilmSearch.Add(new Label());
                listLabelGenersFilmSearch.Add(new Label());
                listLabelProductionCountriesFilmSearch.Add(new Label());
            }

            foreach (Label element in listNumberPlaces)
            {
                element.Click += new EventHandler(listNumberPlaces_Click);
            }

            // SET STYLE FOR LEFT MENU BUTTON
            setStyleButton(listButtonInLeftMenu);
            // SHOW MAIN SCREEN
            setVisible(panelMainScreen);
            // Set style for elements
            setStyleForElements();

            loadFilmsToPanelFilms(0);
            loadFilmsToPanelSearchFilms(0);
        }
        // Set style for list buttons
        private void setStyleButton(List<Button> e)
        {
            foreach (Button element in e)
            {
                element.ForeColor = Color.FromArgb(255, 255, 255);
                element.BackColor = Color.FromArgb(57, 57, 108);
                element.Font = new Font("Arial", 9, FontStyle.Regular);
            }

        }
        // Set visible for panel 1
        private void setVisible(Panel e1, Button e2)
        {
            foreach (Panel element in listPanel)
            {
                element.Visible = (element == e1) ? true : false;
            }

            foreach (Button element in listButtonInLeftMenu)
            {
                if (element == e2)
                {
                    e2.Controls.Clear();
                    e2.Controls.Add(new Label()
                    {
                        Width = 3,
                        Dock = DockStyle.Right,
                        BackColor = Color.FromArgb(255, 255, 255)
                    });
                }
                else
                {
                    element.Controls.Clear();
                }
            }
        }
        // Set visible for panel 2
        private void setVisible(Panel e)
        {
            foreach (Panel element in listPanel)
            {
                element.Visible = (element == e) ? true : false;
            }

            foreach (Button element in listButtonInLeftMenu)
            {
                element.Controls.Clear();
            }

        }
        // Set visible for panel 3
        private void setVisible(Panel e, List<Panel> listPanelToHide)
        {
            labelTitlePanelStatisticsAndReports.Visible = false;
            foreach (Panel element in listPanelToHide)
            {
                element.Visible = (element == e) ? true : false;
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
                listPictureBox[i].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                listPictureBox[i].Cursor = System.Windows.Forms.Cursors.Hand;

                listLabelFilmName[i].Text = "[Film name]";
                listLabelFilmName[i].ForeColor = Color.FromArgb(0, 0, 0);
                listLabelFilmName[i].BackColor = Color.FromArgb(1, 0, 0, 0);
                listLabelFilmName[i].Width = 150;
                listLabelFilmName[i].Height = 30;
                listLabelFilmName[i].Font = new Font("Arial", 9, FontStyle.Regular);
                listLabelFilmName[i].TextAlign = ContentAlignment.MiddleCenter;
                listLabelFilmName[i].Location = new Point(x, y + 200);

                listLabelAgeLimit[i].Text = "18+";
                listLabelAgeLimit[i].ForeColor = Color.FromArgb(255, 255, 255);
                listLabelAgeLimit[i].BackColor = Color.FromArgb(236, 23, 79);
                listLabelAgeLimit[i].Width = 35;
                listLabelAgeLimit[i].Height = 20;
                listLabelAgeLimit[i].Font = new Font("Arial", 8);
                listLabelAgeLimit[i].TextAlign = ContentAlignment.MiddleCenter;
                listLabelAgeLimit[i].Location = new Point(x - 2, y - 2);

                listLabelLengthFilm[i].Text = "124 min.";
                listLabelLengthFilm[i].ForeColor = Color.FromArgb(255, 255, 255);
                listLabelLengthFilm[i].BackColor = Color.FromArgb(236, 23, 79);
                listLabelLengthFilm[i].Width = 50;
                listLabelLengthFilm[i].Height = 20;
                listLabelLengthFilm[i].Font = new Font("Arial", 8);
                listLabelLengthFilm[i].TextAlign = ContentAlignment.MiddleCenter;
                listLabelLengthFilm[i].Location = new Point(x +
                listPictureBox[i].Width - listLabelLengthFilm[i].Width + 2, y +
                listPictureBox[i].Height - listLabelLengthFilm[i].Height + 2);

                listLabelAgeLimit[i].Visible =
                listLabelLengthFilm[i].Visible =
                listLabelFilmName[i].Visible =
                listPictureBox[i].Visible = false;

                panelViewListFilms.Controls.Add(listLabelLengthFilm[i]);
                panelViewListFilms.Controls.Add(listLabelAgeLimit[i]);
                panelViewListFilms.Controls.Add(listPictureBox[i]);
                panelViewListFilms.Controls.Add(listLabelFilmName[i]);

                x += 180;
                i++;

                if (i % 4 == 0)
                {
                    y += 250;
                    x = 30;
                }
            }

            x = y = 30;
            for (short i = 0; i < settings[2];)
            {
                listLabelSloganFilmSearch[i].Font =
                listLabelPriceFilmSearch[i].Font =
                listLabelYearFilmSearch[i].Font =
                listLabelGenersFilmSearch[i].Font =
                listLabelProductionCountriesFilmSearch[i].Font = new Font("Arial", 8, FontStyle.Regular);

                listLabelNameFilmSearch[i].TextAlign =
                listLabelSloganFilmSearch[i].TextAlign =
                listLabelPriceFilmSearch[i].TextAlign =
                listLabelDescriptionFilmSearch[i].TextAlign =
                listLabelYearFilmSearch[i].TextAlign =
                listLabelGenersFilmSearch[i].TextAlign =
                listLabelProductionCountriesFilmSearch[i].TextAlign = ContentAlignment.MiddleLeft;

                listPictureBoxFilmsSearch[i].BackColor = Color.FromArgb(225, 225, 225);
                listPictureBoxFilmsSearch[i].Height = 200;
                listPictureBoxFilmsSearch[i].Width = 150;
                listPictureBoxFilmsSearch[i].Location = new Point(x, y);
                listPictureBoxFilmsSearch[i].SizeMode = PictureBoxSizeMode.StretchImage;
                listPictureBoxFilmsSearch[i].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

                listLabelAgeLimitFilmSearch[i].Text = "18+";
                listLabelAgeLimitFilmSearch[i].ForeColor = Color.FromArgb(255, 255, 255);
                listLabelAgeLimitFilmSearch[i].BackColor = Color.FromArgb(236, 23, 79);
                listLabelAgeLimitFilmSearch[i].Width = 35;
                listLabelAgeLimitFilmSearch[i].Height = 20;
                listLabelAgeLimitFilmSearch[i].Font = new Font("Arial", 8);
                listLabelAgeLimitFilmSearch[i].TextAlign = ContentAlignment.MiddleCenter;
                listLabelAgeLimitFilmSearch[i].Location = new Point(x - 2, y +
                listPictureBoxFilmsSearch[i].Height - listLabelAgeLimitFilmSearch[i].Height + 2);

                listLabelLengthFilmSearch[i].Text = "124 min.";
                listLabelLengthFilmSearch[i].ForeColor = Color.FromArgb(255, 255, 255);
                listLabelLengthFilmSearch[i].BackColor = Color.FromArgb(236, 23, 79);
                listLabelLengthFilmSearch[i].Width = 50;
                listLabelLengthFilmSearch[i].Height = 20;
                listLabelLengthFilmSearch[i].Font = new Font("Arial", 8);
                listLabelLengthFilmSearch[i].TextAlign = ContentAlignment.MiddleCenter;
                listLabelLengthFilmSearch[i].Location = new Point(x +
                listPictureBoxFilmsSearch[i].Width - listLabelLengthFilmSearch[i].Width + 2, y +
                listPictureBoxFilmsSearch[i].Height - listLabelLengthFilmSearch[i].Height + 2);

                listLabelNameFilmSearch[i].Text = "[Film name]";
                listLabelNameFilmSearch[i].ForeColor = Color.FromArgb(0, 0, 0);
                listLabelNameFilmSearch[i].BackColor = Color.FromArgb(1, 0, 0, 0);
                listLabelNameFilmSearch[i].Size = new Size(400, 15);
                listLabelNameFilmSearch[i].Font = new Font("Arial", 10, FontStyle.Bold);
                listLabelNameFilmSearch[i].Location = new Point(x +
                listPictureBoxFilmsSearch[i].Width + 15, y);

                listLabelSloganFilmSearch[i].Size = new Size(400, 13);
                listLabelSloganFilmSearch[i].Location = new Point(x +
                listPictureBoxFilmsSearch[i].Width + 15, y + listLabelLengthFilmSearch[i].Height + 8);

                listLabelYearFilmSearch[i].Size = new Size(400, 13);
                listLabelYearFilmSearch[i].Location = new Point(x +
                listPictureBoxFilmsSearch[i].Width + 15, y + listLabelSloganFilmSearch[i].Height + 30);

                listLabelProductionCountriesFilmSearch[i].Size = new Size(400, 13);
                listLabelProductionCountriesFilmSearch[i].TextAlign = ContentAlignment.MiddleLeft;
                listLabelProductionCountriesFilmSearch[i].Location = new Point(x +
                listPictureBoxFilmsSearch[i].Width + 15, y + listLabelYearFilmSearch[i].Height + 45);

                listLabelGenersFilmSearch[i].Size = new Size(400, 13);
                listLabelGenersFilmSearch[i].Location = new Point(x +
                listPictureBoxFilmsSearch[i].Width + 15, y + listLabelProductionCountriesFilmSearch[i].Height + 60);

                listLabelPriceFilmSearch[i].ForeColor = Color.FromArgb(0, 0, 0);
                listLabelPriceFilmSearch[i].BackColor = Color.FromArgb(245, 245, 245);
                listLabelPriceFilmSearch[i].Size = new Size(listPictureBoxFilmsSearch[i].Width, 30);
                listLabelPriceFilmSearch[i].Location = new Point(x, y + listPictureBoxFilmsSearch[i].Height);
                listLabelPriceFilmSearch[i].Font = new Font("Arial", 8, FontStyle.Underline);
                listLabelPriceFilmSearch[i].TextAlign = ContentAlignment.MiddleCenter;

                listLabelDescriptionFilmSearch[i].Size = new Size(500, 150);
                listLabelDescriptionFilmSearch[i].TextAlign = ContentAlignment.TopLeft;
                listLabelDescriptionFilmSearch[i].Location = new Point(x +
                listPictureBoxFilmsSearch[i].Width + 15, y + listLabelGenersFilmSearch[i].Height + 75);

                listPictureBoxFilmsSearch[i].Visible =
                listLabelNameFilmSearch[i].Visible =
                listLabelSloganFilmSearch[i].Visible =
                listLabelAgeLimitFilmSearch[i].Visible =
                listLabelPriceFilmSearch[i].Visible =
                listLabelDescriptionFilmSearch[i].Visible =
                listLabelYearFilmSearch[i].Visible =
                listLabelLengthFilmSearch[i].Visible =
                listLabelGenersFilmSearch[i].Visible =
                listLabelProductionCountriesFilmSearch[i].Visible = false;

                panelViewSearch.Controls.Add(listLabelAgeLimitFilmSearch[i]);
                panelViewSearch.Controls.Add(listLabelLengthFilmSearch[i]);
                panelViewSearch.Controls.Add(listPictureBoxFilmsSearch[i]);
                panelViewSearch.Controls.Add(listLabelNameFilmSearch[i]);
                panelViewSearch.Controls.Add(listLabelYearFilmSearch[i]);
                panelViewSearch.Controls.Add(listLabelSloganFilmSearch[i]);
                panelViewSearch.Controls.Add(listLabelProductionCountriesFilmSearch[i]);
                panelViewSearch.Controls.Add(listLabelGenersFilmSearch[i]);
                panelViewSearch.Controls.Add(listLabelPriceFilmSearch[i]);
                panelViewSearch.Controls.Add(listLabelDescriptionFilmSearch[i]);

                i++;
                y += 250;
            }

            foreach (object e in objectDataBase.GetFullListOfGeners())
            {
                filter_comboBoxGener.Items.Add(e);
            }

            foreach (object e in objectDataBase.GetFullListOfProductionCountries())
            {
                filter_comboBoxCountry.Items.Add(e);
            }

            filter_comboBoxCountry.SelectedIndex =
            filter_comboBoxYear.SelectedIndex =
            filter_comboBoxAgeLimite.SelectedIndex =
            filter_comboBoxLength.SelectedIndex =
            filter_comboBoxPrice.SelectedIndex =
            filter_comboBoxGener.SelectedIndex = 0;

            buttonSearchFilmsBack.Visible =
            buttonSearchFilmsNext.Visible =
            labelNumberPage.Visible = false;

            buttonShowFilters.Width =
            buttonSearchFilms.Width = 715;
        }
        private void toggleHelper(bool state)
        {
            labelHelperDescription.Visible = (state) ? true : false;
        }
        private void drawTicket(
            object name,
            object date,
            object hall,
            object numbePlace,
            object price,
            object uid,
            object ageLimit,
            object length,
            object image,
            Panel namePanel,
            short x,
            short y)
        {
            ticketNameFilm.Text = name.ToString();
            ticketDate.Text = date.ToString();
            ticketHall.Text = hall.ToString();
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
            List<object> result = objectDataBase.GetAllInformationAboutTicketByUID(textBoxUID.Text);
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
            List<object> result = objectDataBase.ReturnTicket(textBoxUID.Text);
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

            List<List<object>> queryRes = objectDataBase.FindAllFilms(settings[0], settings[1]);

            for (short i = 0; i < settings[0]; i++)
            {
                if (i < queryRes.Count - 1)
                {
                    listLabelFilmName[i].Text = queryRes[i][1].ToString();
                    listLabelAgeLimit[i].Text = queryRes[i][2].ToString() + "+";
                    listLabelLengthFilm[i].Text = queryRes[i][3].ToString() + " min.";
                    listPictureBox[i].ImageLocation = queryRes[i][4].ToString();

                    listLabelAgeLimit[i].Visible =
                    listLabelLengthFilm[i].Visible =
                    listLabelFilmName[i].Visible =
                    listPictureBox[i].Visible = true;
                }
                else
                {
                    listLabelAgeLimit[i].Visible =
                    listLabelLengthFilm[i].Visible =
                    listLabelFilmName[i].Visible =
                    listPictureBox[i].Visible = false;
                }
            }

            if (queryRes.Count - 1 != 0)
            {
                buttonSearchFilmsBack.Visible = buttonSearchFilmsNext.Visible = labelNumberPage.Visible = true;
                buttonSearchFilms.Width = 445;
                titlePanelFilms.Visible = false;

                int buf = (Convert.ToInt32(queryRes[queryRes.Count - 1][0]) / settings[0] == 0)
                    ? 1
                    : Convert.ToInt32(Math.Ceiling(Convert.ToDouble(queryRes[queryRes.Count - 1][0]) / settings[0]));

                labelNumberPage.Text = settings[1] + " из " + buf.ToString();
                if (buf == 1)
                {
                    buttonSearchFilmsNext.Enabled =
                    buttonSearchFilmsBack.Enabled = false;
                }
                else if (settings[1] == 1)
                {
                    buttonSearchFilmsNext.Enabled = true;
                    buttonSearchFilmsBack.Enabled = false;
                }
                else if (settings[1] == buf)
                {
                    buttonSearchFilmsNext.Enabled = false;
                    buttonSearchFilmsBack.Enabled = true;
                }
                else if (settings[1] > 1)
                {
                    buttonSearchFilmsNext.Enabled = true;
                    buttonSearchFilmsBack.Enabled = true;
                }
            }
            else
            {
                buttonSearchFilmsBack.Visible = buttonSearchFilmsNext.Visible = labelNumberPage.Visible = false;
                buttonSearchFilms.Width = 715;
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
        private void drawReserveTicket(
            object name,
            object date,
            object hall,
            object numbePlace,
            object price,
            object ageLimit,
            object length,
            object image,
            Panel namePanel,
            short x,
            short y)
        {
            reserveTicketNameFilm.Text = name.ToString();
            reserveTicketDate.Text = date.ToString();
            reserveTicketHall.Text = hall.ToString();
            reserveTicketPlace.Text = numbePlace.ToString();
            reserveTicketPrice.Text = price.ToString() + " руб.";
            reserveTicketAgeLimit.Text = ageLimit.ToString() + "+";
            reserveTicketLength.Text = length.ToString() + "min.";
            reserveTicketLength.Location = new Point(reserveTicketPanel.Width - reserveTicketLength.Width - 1, reserveTicketPanel.Height - reserveTicketLength.Height - 1);
            reserveTicketImage.ImageLocation = image.ToString();
            reserveTicketPanel.Location = new Point(x, y);
            namePanel.Controls.Add(reserveTicketPanel);
            reserveTicketPanel.Visible = true;
        }
        private void listPictureBox_Click(object sender, EventArgs e)
        {
            string id = (sender as PictureBox).ImageLocation.Replace("images/","");
            id = id.Replace("/logo.jpg", "");

            List<object> result = objectDataBase.FindSessionsFromFilmById(Convert.ToInt32(id));
            bufferArray.Clear();
            if (result.Count > 0)
            {
                panelBuyTicket.Visible = true;
                bufferArray.Clear();
                comboBoxSessionList.Items.Clear();
                foreach (List<object> element in result)
                {
                    comboBoxSessionList.Items.Add("Зал " + element[0].ToString() + "   |   " + element[1].ToString());
                    bufferArray.Add(new List<object>() { element[0], element[1], element[2] });
                }
                comboBoxSessionList.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("Сеансов на данный фильм нет!");
            }
        }
        private void comboBoxSessionList_SelectedIndexChanged(object sender, EventArgs e)
        {
            activeIndexFromBuffer = (sender as ComboBox).SelectedIndex;
            placesType.Clear();
            reserveTicketPanel.Visible =
            buttonBuyTicket.Visible = false;
            placesType = objectDataBase.GetAllTypesPlacesInHall(
                Convert.ToInt32(bufferArray[activeIndexFromBuffer][0])
            );

            List<object> tickets = objectDataBase.GetAllTicketFromSessionById(
                Convert.ToInt32(bufferArray[activeIndexFromBuffer][2])
            );

            foreach (Label element in listNumberPlaces)
            {
                element.ForeColor = Color.FromArgb(255, 255, 255);
                element.Enabled = true;
                element.Cursor = Cursors.Hand;

                int buf = Convert.ToInt32(element.Text);

                if (buf >= Convert.ToInt32(placesType[0][2]) &&
                    buf <= Convert.ToInt32(placesType[0][3]))
                {
                    element.BackColor = Color.FromArgb(153, 153, 153);
                    metroToolTip1.SetToolTip(element, placesType[0][0].ToString());
                }
                else if (buf >= Convert.ToInt32(placesType[1][2]) &&
                    buf <= Convert.ToInt32(placesType[1][3]))
                {
                    element.BackColor = Color.FromArgb(142, 69, 173);
                    metroToolTip1.SetToolTip(element, placesType[1][0].ToString());
                }
                else
                {
                    element.BackColor = Color.FromArgb(231, 69, 50);
                    metroToolTip1.SetToolTip(element, placesType[2][0].ToString());
                }

                foreach (object element2 in tickets)
                {
                    if (Convert.ToInt32(element2) == buf)
                    {
                        element.Enabled = false;
                        element.Cursor = Cursors.No;
                        metroToolTip1.SetToolTip(element, "Билет на данное место выкуплен!");
                    }
                }
            }
            panelWrapperListPlaces.Visible = true;
        }
        private void listNumberPlaces_Click(object sender, EventArgs e)
        {
            if ((sender as Label).Enabled)
            {
                List<List<object>> result = objectDataBase.GenerateTicket(
                    Convert.ToInt32(bufferArray[activeIndexFromBuffer][2]),
                    Convert.ToInt32((sender as Label).Text)
                );

                drawReserveTicket(result[0][0], result[0][1],
                    result[0][2], (sender as Label).Text,
                    result[0][3], result[0][5],
                    result[0][4], result[0][6],
                    panelBuyTicket, 181, 320
                );

                buttonBuyTicket.Visible = true;
            }
        }
        private void buttonClosePanelBuyTicket_Click(object sender, EventArgs e)
        {
            panelBuyTicket.Visible =
            reserveTicketPanel.Visible =
            buttonBuyTicket.Visible = false;
        }
        private void buttonBuyTicket_Click(object sender, EventArgs e)
        {
            objectDataBase.BuyTicket(
                Convert.ToInt32(reserveTicketHall.Text),
                reserveTicketDate.Text,
                Convert.ToInt32(reserveTicketPlace.Text)
            );

            MessageBox.Show("Билет приобретен!");
            panelBuyTicket.Visible =
            reserveTicketPanel.Visible =
            buttonBuyTicket.Visible = false;
        }

        // Panel StatisticsAndReport
        private void menuButtonStatisticsAndReport_Click(object sender, EventArgs e) => setVisible(panelStatisticsAndReports, menuButtonStatisticsAndReports);

        // Panel Search
        private void menuButtonSearch_Click(object sender, EventArgs e) => setVisible(panelSearch, menuButtonSearch);
        private void buttonShowFilters_Click(object sender, EventArgs e) => PanelSearchFilters.Visible = true;
        private void filter_labelClose_Click(object sender, EventArgs e) => PanelSearchFilters.Visible = false;
        private void loadFilmsToPanelSearchFilms(short pageAct)
        {
            switch (pageAct)
            {
                case 0:
                    settings[3] = 1;
                    PanelSearchFilters.Visible = !checkBoxAutoHide.Checked;
                    break;
                case 1: settings[3] += 1; break;
                case -1: settings[3] -= 1; break;
            }

            List<List<object>> queryRes = objectDataBase.FindFilmsByAllFilters(
                settings[2],
                settings[3],
                filter_comboBoxYear.SelectedItem.ToString(),
                filter_comboBoxAgeLimite.SelectedItem.ToString(),
                filter_comboBoxLength.SelectedItem.ToString(),
                filter_comboBoxPrice.SelectedItem.ToString(),
                filter_textBoxDescription.Text,
                filter_textBoxSlogan.Text,
                filter_comboBoxGener.SelectedItem.ToString(),
                filter_comboBoxCountry.SelectedItem.ToString());

            for (short i = 0; i < settings[2]; i++)
            {
                if (i < queryRes.Count - 1)
                {
                    listLabelNameFilmSearch[i].Text = queryRes[i][1].ToString();
                    listLabelAgeLimitFilmSearch[i].Text = queryRes[i][3].ToString() + "+";
                    listLabelLengthFilmSearch[i].Text = queryRes[i][4].ToString() + " min.";
                    listPictureBoxFilmsSearch[i].ImageLocation = queryRes[i][6].ToString();
                    listLabelYearFilmSearch[i].Text = "Год: " + queryRes[i][2].ToString();
                    listLabelPriceFilmSearch[i].Text = "Цена: от " + queryRes[i][5].ToString() + " рублей.";
                    listLabelSloganFilmSearch[i].Text = "Слоган: " + queryRes[i][8].ToString();
                    listLabelDescriptionFilmSearch[i].Text = "Описание: " + queryRes[i][7].ToString();
                    listLabelProductionCountriesFilmSearch[i].Text = "Производство: " + queryRes[i][9].ToString();
                    listLabelGenersFilmSearch[i].Text = "Жанр: " + queryRes[i][10].ToString();

                    listPictureBoxFilmsSearch[i].Visible =
                    listLabelNameFilmSearch[i].Visible =
                    listLabelYearFilmSearch[i].Visible =
                    listLabelAgeLimitFilmSearch[i].Visible =
                    listLabelPriceFilmSearch[i].Visible =
                    listLabelDescriptionFilmSearch[i].Visible =
                    listLabelSloganFilmSearch[i].Visible =
                    listLabelLengthFilmSearch[i].Visible =
                    listLabelGenersFilmSearch[i].Visible =
                    listLabelProductionCountriesFilmSearch[i].Visible = true;
                }
                else
                {
                    listPictureBoxFilmsSearch[i].Visible =
                    listLabelNameFilmSearch[i].Visible =
                    listLabelYearFilmSearch[i].Visible =
                    listLabelAgeLimitFilmSearch[i].Visible =
                    listLabelPriceFilmSearch[i].Visible =
                    listLabelDescriptionFilmSearch[i].Visible =
                    listLabelSloganFilmSearch[i].Visible =
                    listLabelLengthFilmSearch[i].Visible =
                    listLabelGenersFilmSearch[i].Visible =
                    listLabelProductionCountriesFilmSearch[i].Visible = false;
                }
            }

            if (queryRes.Count - 1 != 0)
            {
                buttonBackPage.Visible =
                buttonNextPage.Visible =
                labelPageNumber.Visible =
                labelCountResults.Visible = true;
                buttonShowFilters.Width = 85;
                titlePanelSearch.Visible = false;

                int buf = (Convert.ToInt32(queryRes[queryRes.Count - 1][0]) / settings[2] == 0)
                    ? 1
                    : Convert.ToInt32(Math.Ceiling(Convert.ToDouble(queryRes[queryRes.Count - 1][0]) / settings[2]));

                buttonSearchByAllFilters.Width = 493;
                labelCountResults.Text = "Фильмов найденно: " + queryRes[queryRes.Count - 1][0];
                labelPageNumber.Text = settings[3] + " из " + buf.ToString();

                if (buf == 1)
                {
                    buttonNextPage.Enabled =
                    buttonBackPage.Enabled = false;
                }
                else if (settings[3] == 1)
                {
                    buttonNextPage.Enabled = true;
                    buttonBackPage.Enabled = false;
                }
                else if (settings[3] == buf)
                {
                    buttonNextPage.Enabled = false;
                    buttonBackPage.Enabled = true;
                }
                else if (settings[3] > 1)
                {
                    buttonNextPage.Enabled = true;
                    buttonBackPage.Enabled = true;
                }
            }
            else
            {
                buttonBackPage.Visible =
                buttonNextPage.Visible =
                labelPageNumber.Visible =
                labelCountResults.Visible = false;
                buttonShowFilters.Width = 715;
                titlePanelSearch.Text = "По вашему запросу ничего не найдено :(";
                buttonSearchByAllFilters.Width = 659;
                titlePanelSearch.Visible = true;
            }

        }
        private void buttonSearchByAllFilters_Click(object sender, EventArgs e) => loadFilmsToPanelSearchFilms(0);
        private void buttonBackPage_Click(object sender, EventArgs e) => loadFilmsToPanelSearchFilms(-1);
        private void buttonNextPage_Click(object sender, EventArgs e) => loadFilmsToPanelSearchFilms(1);

        // Panel return ticket
        private void menuButtonReturnTickets_Click(object sender, EventArgs e) => setVisible(searchTicket, menuButtonReturnTickets);
        private void buttonSearchTicketUID_Click(object sender, EventArgs e) => searchTicketUID();
        private void buttonReturnTicketUID_Click(object sender, EventArgs e) => returnTicketUID();
        private void labelHelper_MouseHover(object sender, EventArgs e) => toggleHelper(true);
        private void labelHelper_MouseLeave(object sender, EventArgs e) => toggleHelper(false);

        // Panel Add new data
        private void menuButtonAdd_Click(object sender, EventArgs e) => setVisible(panelAdd, menuButtonAdd);

        private void buttonExportExcel_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddFilm_Click(object sender, EventArgs e)
        {
            AddFilms newForm = new AddFilms();
            newForm.Show();
        }
        private void buttonAddSession_Click(object sender, EventArgs e)
        {
            AddSessions newForm = new AddSessions();
            newForm.Show();
        }
        private void buttonAddGener_Click(object sender, EventArgs e)
        {
            AddGeners newForm = new AddGeners();
            newForm.Show();
        }
        private void buttonAddProductionCountries_Click(object sender, EventArgs e)
        {
            AddProductionCountries newForm = new AddProductionCountries();
            newForm.Show();
        }
        private void buttonAddHalls_Click(object sender, EventArgs e)
        {
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

        // Panel statistic and reports
        private void buttonDiagram1_Click(object sender, EventArgs e)
        {
            setVisible(panelDiagram1, listPanelDiagram);

            List<List<object>> result =  objectDataBase.DiagramFilmYear();

            pieChart1.Series = new SeriesCollection();

            pieChart1.LegendLocation = LegendLocation.Top;

            Func<ChartPoint, string> labelPoint = chartPoint =>
                string.Format("{0} film(s)", chartPoint.Y, chartPoint.Participation);

            foreach (List<object> element in result)
            {
                pieChart1.Series.Add(
                    new PieSeries
                    {
                        Title = element[0].ToString() + " год",
                        Values = new ChartValues<int> { Convert.ToInt32(element[1]) },
                        DataLabels = true,
                        LabelPoint = labelPoint
                    }
                );
            }
        }
        private void buttonDiagram2_Click(object sender, EventArgs e)
        {
            setVisible(panelDiagram2, listPanelDiagram);
            List<List<object>> result =  objectDataBase.DiagramFilmGener();
            
            foreach (List<object> element in result)
            {

            }

            int a = Convert.ToInt32(result[0][0]);

            ChartValues<int> aaa = new ChartValues<int>() { a };

            cartesianDiagram2.Series = new SeriesCollection() {
                new StackedColumnSeries
                {
                    Values = aaa,
                    StackMode = StackMode.Values,
                    DataLabels = true
                }
            };

            cartesianDiagram2.AxisX.Add(
                new Axis
                {
                    Title = "Browser",
                    Labels = new[] { "Chrome", "Mozilla", "Opera", "IE" },
                    Separator = DefaultAxes.CleanSeparator
                }
            );

            cartesianDiagram2.AxisY.Add(
                new Axis
                {
                    Title = "Количество фильмов",
                    LabelFormatter = value => value.ToString()
                }
            );
        }

        private void buttonDiagram3_Click(object sender, EventArgs e) => setVisible(panelDiagram3, listPanelDiagram);
        private void buttonDiagram4_Click(object sender, EventArgs e)
        {
            setVisible(panelDiagram4, listPanelDiagram);

            List<List<object>> result =  objectDataBase.DiagramAgeLimit();

            pieChart4.Series = new SeriesCollection();

            pieChart4.LegendLocation = LegendLocation.Top;

            Func<ChartPoint, string> labelPoint = chartPoint =>
                string.Format("{0} film(s)", chartPoint.Y, chartPoint.Participation);

            foreach (List<object> element in result)
            {
                pieChart4.Series.Add(
                    new PieSeries
                    {
                        Title = element[0].ToString() + "+",
                        Values = new ChartValues<int> { Convert.ToInt32(element[1]) },
                        DataLabels = true,
                        LabelPoint = labelPoint
                    }
                );
            }
        }

        // Button Exit
        private void menuButton_Exit_Click(object sender, EventArgs e) => Close();

    }

}
