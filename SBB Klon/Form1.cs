using SwissTransport.Core;
using SwissTransport.Models;
using System.Windows;


namespace SBB_Klon
{
    public partial class Form1 : Form
    {
        ITransport transport = new Transport();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panelFahrplan.Width = 1026;
            panelVerbindungen.Width = 1026;
            panelInDerNaehe.Width = 1026;

            panelVerbindungen.Hide();
            panelInDerNaehe.Hide();
        }

        private void btnFahrplanSuche_Click(object sender, EventArgs e)
        {
            var vonStation = txtFahrplanStartstation.Text;
            var nachStation = txtFahrplanEndstation.Text;
            DateTime datum = txtFahrplanDatum.Value;
            DateTime zeit = Convert.ToDateTime(datum.ToString("HH:mm"));
            int istAnkunftszeit = 0;
            if (radioFahrplanAnDatum.Checked) { istAnkunftszeit = 1; }
            var fahrmoeglichkeiten = transport.GetConnections(vonStation, nachStation, istAnkunftszeit, datum, zeit, 8).ConnectionList;

            panelFahrplanErgebnisse.Controls.Clear();

            if (fahrmoeglichkeiten.Count > 0)
            {
                foreach (var fahrmoeglichkeit in fahrmoeglichkeiten)
                {
                    TimeSpan? Fahrdauer;
                    var stationenKarten = new stationenKarten();
                    panelFahrplanErgebnisse.Controls.Add(stationenKarten);
                    stationenKarten.Width = 823;
                    stationenKarten.Height = 140;
                    stationenKarten.Titel = Convert.ToString(fahrmoeglichkeit.From.Station.Name) + " --> " + Convert.ToString(fahrmoeglichkeit.To.Station.Name);
                    stationenKarten.Info1Bez = "Abfahrtzeit: ";
                    stationenKarten.Info1 = fahrmoeglichkeit.From.Departure.Value.ToString("dd.MM.yyyy HH:mm");
                    stationenKarten.Info2Bez = "Ankunftzeit: ";
                    stationenKarten.Info2 = fahrmoeglichkeit.To.Arrival.Value.ToString("dd.MM.yyyy HH:mm");
                    stationenKarten.Info3Bez = "Fahrtdauer: ";
                    Fahrdauer = fahrmoeglichkeit.To.Arrival - fahrmoeglichkeit.From.Departure;
                    stationenKarten.Info3 = Fahrdauer.Value.ToString(@"hh\:mm");
                    if (fahrmoeglichkeit.From.Delay > 0)
                    {
                        stationenKarten.Verspaetung = "+ " + fahrmoeglichkeit.From.Delay + "min";
                    }
                    else
                    {
                        stationenKarten.Verspaetung = "";
                    }
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Keine Ergebnisse gefunden.");
            }
        }

        private void btnVerbindungenSuchen_Click(object sender, EventArgs e)
        {
            var station = txtVerbindungenStation.Text;
            DateTime datum = txtVerbindungenDatum.Value;
            DateTime zeit = Convert.ToDateTime(datum.ToString("HH:mm"));
            int istAnkunftszeit = 0;
            if (radioFahrplanAnDatum.Checked) { istAnkunftszeit = 1; }
            var fahrmoeglichkeiten = transport.GetStationBoard(station, "8503059", 8).Entries;

            panelVerbindungenErgebnisse.Controls.Clear();
            if (fahrmoeglichkeiten.Count > 0)
            {
                foreach (var fahrmoeglichkeit in fahrmoeglichkeiten)
                {
                    var stationFahrmoeglichkeiten = transport.GetConnections(station, fahrmoeglichkeit.To, istAnkunftszeit, datum, zeit, 1).ConnectionList;
                    TimeSpan? Fahrdauer;
                    var stationenKarten = new stationenKarten();

                    panelVerbindungenErgebnisse.Controls.Add(stationenKarten);
                    stationenKarten.Width = 823;
                    stationenKarten.Height = 140;
                    stationenKarten.Titel = Convert.ToString(stationFahrmoeglichkeiten[0].From.Station.Name) + " --> " + Convert.ToString(stationFahrmoeglichkeiten[0].To.Station.Name);
                    stationenKarten.Info1Bez = "Abfahrtzeit: ";
                    stationenKarten.Info1 = stationFahrmoeglichkeiten[0].From.Departure.Value.ToString("dd.MM.yyyy HH:mm");
                    stationenKarten.Info2Bez = "Ankunftzeit: ";
                    stationenKarten.Info2 = stationFahrmoeglichkeiten[0].To.Arrival.Value.ToString("dd.MM.yyyy HH:mm");
                    stationenKarten.Info3Bez = "Fahrtdauer: ";
                    Fahrdauer = stationFahrmoeglichkeiten[0].To.Arrival - stationFahrmoeglichkeiten[0].From.Departure;
                    stationenKarten.Info3 = Fahrdauer.Value.ToString(@"hh\:mm");
                    if (stationFahrmoeglichkeiten[0].From.Delay > 0)
                    {
                        stationenKarten.Verspaetung = "+ " + stationFahrmoeglichkeiten[0].From.Delay + "min";
                    }
                    else
                    {
                        stationenKarten.Verspaetung = "";
                    }
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Keine Ergebnisse gefunden.");
            }
        }

        private void txtSartstation_KeyDown(object sender, KeyEventArgs e)
        {
            var vonStation = txtFahrplanStartstation.Text;
            var nachStation = txtFahrplanEndstation.Text;

            if (vonStation != "")
            {
                var stationen = transport.GetStations(vonStation).StationList;

                if(stationen.Count > 0)
                {
                    txtFahrplanStartstation.Items.Clear();
                    foreach (Station station in stationen)
                    {
                        if (!string.IsNullOrEmpty(station.Name))
                        {
                            txtFahrplanStartstation.Items.Add(station.Name);
                            txtFahrplanStartstation.SelectionStart = vonStation.Length;
                        }
                    }
                }
            }
            
            if (vonStation != "" && nachStation != "")
            {
                btnFahrplanSuche.Enabled = true;
            }
            else
            {
                btnFahrplanSuche.Enabled = false;
            }
        }

        private void txtEndstation_KeyDown(object sender, KeyEventArgs e)
        {

            var vonStation = txtFahrplanStartstation.Text;
            var nachStation = txtFahrplanEndstation.Text;

            if (nachStation != "")
            {
                var stationen = transport.GetStations(nachStation).StationList;

                if (stationen.Count > 0)
                {
                    txtFahrplanEndstation.Items.Clear();
                    foreach (Station station in stationen)
                    {
                        if (!string.IsNullOrEmpty(station.Name))
                        {
                            txtFahrplanEndstation.Items.Add(station.Name);
                            txtFahrplanEndstation.SelectionStart = nachStation.Length;
                        }
                    }
                }
            }

            if (vonStation != "" && nachStation != "")
            {
                btnFahrplanSuche.Enabled = true;
            }
            else
            {
                btnFahrplanSuche.Enabled = false;
            }
        }

        private void btnFahrplan_Click(object sender, EventArgs e)
        {
            btnFahrplan.Enabled = false;
            btnVerbindungen.Enabled = true;
            btnInDerNaehe.Enabled = true;
            panelFahrplan.Show();
            panelVerbindungen.Hide();
            panelInDerNaehe.Hide();
        }

        private void btnVerbindungen_Click(object sender, EventArgs e)
        {
            btnFahrplan.Enabled = true;
            btnVerbindungen.Enabled = false;
            btnInDerNaehe.Enabled = true;
            panelFahrplan.Hide();
            panelVerbindungen.Show();
            panelInDerNaehe.Hide();
        }

        private void btnInDerNaehe_Click(object sender, EventArgs e)
        {
            btnFahrplan.Enabled = true;
            btnVerbindungen.Enabled = true;
            btnInDerNaehe.Enabled = false;
            panelFahrplan.Hide();
            panelVerbindungen.Hide();
            panelInDerNaehe.Show();
        }

        /* private void btnFahrplanStartstationMeinStandort_Click(object sender, EventArgs e)
        {
            double? stationXCor = transport.GetStationBoard("Menznau", "").Station.Coordinate.XCoordinate;
            double? stationYCor = transport.GetStationBoard("Menznau", "").Station.Coordinate.YCoordinate;
            double? dis = transport.GetStationBoard("Menznau", "").Station.Distance;
            double myXCor = 47;
            double myYCor = 8;
        } */
    }
}