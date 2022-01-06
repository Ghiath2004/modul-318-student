using SwissTransport.Core;

namespace SBB_Klon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var transport = new Transport();
            var stationen = transport.GetStations;
            // var station = transport.GetConnections("Luzern", "Menznau");
        }

        private void btnFahrplanSuche_Click(object sender, EventArgs e)
        {
            var stationenKarten = new stationenKarten();
            stationenKarten.Visible = true;
            stationenKarten.Show();
            stationenKarten.AutoSize = true;
            stationenKarten.Titel = "hallo";
            panelFahrplan.Container.Add(stationenKarten);
        }
    }
}