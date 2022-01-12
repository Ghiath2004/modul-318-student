using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SBB_Klon
{
    public partial class stationKarte : UserControl
    {
#pragma warning disable CS8618 // Ein Non-Nullable-Feld muss beim Beenden des Konstruktors einen Wert ungleich NULL enthalten. Erwägen Sie die Deklaration als Nullable.
        public stationKarte()
        {
            InitializeComponent();
        }

        #region karte
        private string _titel;
        private string _info1Bez;
        private string _info2Bez;
        private string _info3Bez;
        private string _info1;
        private string _info2;
        private string _info3;
        private string _verspaetung;
        private string _allDetails;
        private string _id;

        [Category("Custom Props")]
        public string Titel
        {
            get { return _titel; }
            set { _titel = value; lblKarteTitel.Text = value; }
        }

        [Category("Custom Props")]
        public string Info1Bez
        {
            get { return _info1Bez; }
            set { _info1Bez = value; lblKarteInf1Bez.Text = value; }
        }

        [Category("Custom Props")]
        public string Info2Bez
        {
            get { return _info2Bez; }
            set { _info2Bez = value; lblKarteInf2Bez.Text = value; }
        }

        [Category("Custom Props")]
        public string Info3Bez
        {
            get { return _info3Bez; }
            set { _info3Bez = value; lblKarteInf3Bez.Text = value; }
        }

        [Category("Custom Props")]
        public string Info1
        {
            get { return _info1; }
            set { _info1 = value; lblKarteInf1Con.Text = value; }
        }

        [Category("Custom Props")]
        public string Info2
        {
            get { return _info2; }
            set { _info2 = value; lblKarteInf2Con.Text = value; }
        }

        [Category("Custom Props")]
        public string Info3
        {
            get { return _info3; }
            set { _info3 = value; lblKarteInf3Con.Text = value; }
        }

        [Category("Custom Props")]
        public string Verspaetung
        {
            get { return _verspaetung; }
            set { _verspaetung = value; lblKarteVerspaetung.Text = value; }
        }

        [Category("Custom Props")]
        public string AllDetails
        {
            get { return _allDetails; }
            set { _allDetails = value; }
        }

        [Category("Custom Props")]
        public string Id
        {
            get { return _id; }
            set { _id = value; btnKarteTeilen.Click += new EventHandler(btnTeilen_Click); btnKarteTeilen.Name = value; this.Name = "item" + value; }
        }
        #endregion

        private void btnTeilen_Click(object sender, EventArgs e)
        {
            string details = this.AllDetails.ToString();
            var emailForm = new emailSenden(details);
            emailForm.Show();
        }

        private void stationenKarten_Load(object sender, EventArgs e)
        {

        }
    }
}
