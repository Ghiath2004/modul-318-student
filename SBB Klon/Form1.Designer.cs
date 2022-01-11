namespace SBB_Klon
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnFahrplan = new System.Windows.Forms.Button();
            this.btnInDerNaehe = new System.Windows.Forms.Button();
            this.btnVerbindungen = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableFahrplan = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnFahrplanSuche = new System.Windows.Forms.Button();
            this.btnFahrplanEndstationMeinStandort = new System.Windows.Forms.Button();
            this.btnFahrplanStartstationMeinStandort = new System.Windows.Forms.Button();
            this.txtFahrplanStartstation = new System.Windows.Forms.ComboBox();
            this.txtFahrplanEndstation = new System.Windows.Forms.ComboBox();
            this.txtFahrplanDatum = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioFahrplanAnDatum = new System.Windows.Forms.RadioButton();
            this.radioFahrplanAbDatum = new System.Windows.Forms.RadioButton();
            this.panelFahrplanErgebnisse = new System.Windows.Forms.FlowLayoutPanel();
            this.panelFahrplan = new System.Windows.Forms.Panel();
            this.panelVerbindungen = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtVerbindungenStation = new System.Windows.Forms.ComboBox();
            this.txtVerbindungenDatum = new System.Windows.Forms.DateTimePicker();
            this.btnVerbindungenSuchen = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioVerbindungenAnDatum = new System.Windows.Forms.RadioButton();
            this.radioVerbindungenAbDatum = new System.Windows.Forms.RadioButton();
            this.panelVerbindungenErgebnisse = new System.Windows.Forms.Panel();
            this.tableAppOptions = new System.Windows.Forms.TableLayoutPanel();
            this.panelInDerNaehe = new System.Windows.Forms.Panel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableFahrplan.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelFahrplan.SuspendLayout();
            this.panelVerbindungen.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableAppOptions.SuspendLayout();
            this.panelInDerNaehe.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFahrplan
            // 
            this.btnFahrplan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFahrplan.Enabled = false;
            this.btnFahrplan.Location = new System.Drawing.Point(41, 5);
            this.btnFahrplan.Name = "btnFahrplan";
            this.btnFahrplan.Size = new System.Drawing.Size(260, 70);
            this.btnFahrplan.TabIndex = 0;
            this.btnFahrplan.Text = "Fahrplan";
            this.btnFahrplan.UseVisualStyleBackColor = true;
            this.btnFahrplan.Click += new System.EventHandler(this.btnFahrplan_Click);
            // 
            // btnInDerNaehe
            // 
            this.btnInDerNaehe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnInDerNaehe.Location = new System.Drawing.Point(725, 5);
            this.btnInDerNaehe.Name = "btnInDerNaehe";
            this.btnInDerNaehe.Size = new System.Drawing.Size(260, 70);
            this.btnInDerNaehe.TabIndex = 3;
            this.btnInDerNaehe.Text = "Stationen in der Nähe";
            this.btnInDerNaehe.UseVisualStyleBackColor = true;
            this.btnInDerNaehe.Click += new System.EventHandler(this.btnInDerNaehe_Click);
            // 
            // btnVerbindungen
            // 
            this.btnVerbindungen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVerbindungen.Location = new System.Drawing.Point(383, 5);
            this.btnVerbindungen.Name = "btnVerbindungen";
            this.btnVerbindungen.Size = new System.Drawing.Size(260, 70);
            this.btnVerbindungen.TabIndex = 4;
            this.btnVerbindungen.Text = "Mögliche Verbindungen";
            this.btnVerbindungen.UseVisualStyleBackColor = true;
            this.btnVerbindungen.Click += new System.EventHandler(this.btnVerbindungen_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.btnFahrplan, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnInDerNaehe, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnVerbindungen, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1026, 80);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // tableFahrplan
            // 
            this.tableFahrplan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableFahrplan.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableFahrplan.ColumnCount = 1;
            this.tableFahrplan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableFahrplan.Controls.Add(this.label1, 0, 1);
            this.tableFahrplan.Controls.Add(this.tableLayoutPanel3, 0, 3);
            this.tableFahrplan.Controls.Add(this.panelFahrplanErgebnisse, 0, 5);
            this.tableFahrplan.Location = new System.Drawing.Point(3, 3);
            this.tableFahrplan.Name = "tableFahrplan";
            this.tableFahrplan.RowCount = 6;
            this.tableFahrplan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableFahrplan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableFahrplan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableFahrplan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableFahrplan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableFahrplan.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableFahrplan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableFahrplan.Size = new System.Drawing.Size(1014, 431);
            this.tableFahrplan.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fahrplan";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 145F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 145F));
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnFahrplanSuche, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.btnFahrplanEndstationMeinStandort, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnFahrplanStartstationMeinStandort, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtFahrplanStartstation, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtFahrplanEndstation, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.txtFahrplanDatum, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.panel1, 3, 2);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 63);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1008, 114);
            this.tableLayoutPanel3.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Datum:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Startstation:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Endstation:";
            // 
            // btnFahrplanSuche
            // 
            this.btnFahrplanSuche.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnFahrplanSuche.Enabled = false;
            this.btnFahrplanSuche.Location = new System.Drawing.Point(389, 79);
            this.btnFahrplanSuche.Name = "btnFahrplanSuche";
            this.btnFahrplanSuche.Size = new System.Drawing.Size(139, 32);
            this.btnFahrplanSuche.TabIndex = 15;
            this.btnFahrplanSuche.Text = "Suchen";
            this.btnFahrplanSuche.UseVisualStyleBackColor = true;
            this.btnFahrplanSuche.Click += new System.EventHandler(this.btnFahrplanSuche_Click);
            // 
            // btnFahrplanEndstationMeinStandort
            // 
            this.btnFahrplanEndstationMeinStandort.Location = new System.Drawing.Point(389, 41);
            this.btnFahrplanEndstationMeinStandort.Name = "btnFahrplanEndstationMeinStandort";
            this.btnFahrplanEndstationMeinStandort.Size = new System.Drawing.Size(139, 31);
            this.btnFahrplanEndstationMeinStandort.TabIndex = 16;
            this.btnFahrplanEndstationMeinStandort.Text = "Mein Standort";
            this.btnFahrplanEndstationMeinStandort.UseVisualStyleBackColor = true;
            // 
            // btnFahrplanStartstationMeinStandort
            // 
            this.btnFahrplanStartstationMeinStandort.Location = new System.Drawing.Point(389, 3);
            this.btnFahrplanStartstationMeinStandort.Name = "btnFahrplanStartstationMeinStandort";
            this.btnFahrplanStartstationMeinStandort.Size = new System.Drawing.Size(139, 31);
            this.btnFahrplanStartstationMeinStandort.TabIndex = 17;
            this.btnFahrplanStartstationMeinStandort.Text = "Mein Standort";
            this.btnFahrplanStartstationMeinStandort.UseVisualStyleBackColor = true;
            // 
            // txtFahrplanStartstation
            // 
            this.txtFahrplanStartstation.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFahrplanStartstation.FormattingEnabled = true;
            this.txtFahrplanStartstation.Location = new System.Drawing.Point(123, 3);
            this.txtFahrplanStartstation.Name = "txtFahrplanStartstation";
            this.txtFahrplanStartstation.Size = new System.Drawing.Size(260, 31);
            this.txtFahrplanStartstation.TabIndex = 19;
            this.txtFahrplanStartstation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSartstation_KeyDown);
            // 
            // txtFahrplanEndstation
            // 
            this.txtFahrplanEndstation.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFahrplanEndstation.FormattingEnabled = true;
            this.txtFahrplanEndstation.Location = new System.Drawing.Point(123, 41);
            this.txtFahrplanEndstation.Name = "txtFahrplanEndstation";
            this.txtFahrplanEndstation.Size = new System.Drawing.Size(260, 31);
            this.txtFahrplanEndstation.TabIndex = 20;
            this.txtFahrplanEndstation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEndstation_KeyDown);
            // 
            // txtFahrplanDatum
            // 
            this.txtFahrplanDatum.CalendarFont = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFahrplanDatum.CustomFormat = "dd.MM.yyyy HH:mm";
            this.txtFahrplanDatum.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFahrplanDatum.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtFahrplanDatum.Location = new System.Drawing.Point(123, 79);
            this.txtFahrplanDatum.Name = "txtFahrplanDatum";
            this.txtFahrplanDatum.Size = new System.Drawing.Size(260, 30);
            this.txtFahrplanDatum.TabIndex = 21;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.radioFahrplanAnDatum);
            this.panel1.Controls.Add(this.radioFahrplanAbDatum);
            this.panel1.Location = new System.Drawing.Point(534, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(471, 32);
            this.panel1.TabIndex = 22;
            // 
            // radioFahrplanAnDatum
            // 
            this.radioFahrplanAnDatum.AutoSize = true;
            this.radioFahrplanAnDatum.Location = new System.Drawing.Point(120, 6);
            this.radioFahrplanAnDatum.Name = "radioFahrplanAnDatum";
            this.radioFahrplanAnDatum.Size = new System.Drawing.Size(111, 24);
            this.radioFahrplanAnDatum.TabIndex = 1;
            this.radioFahrplanAnDatum.TabStop = true;
            this.radioFahrplanAnDatum.Text = "Ankunftszeit";
            this.radioFahrplanAnDatum.UseVisualStyleBackColor = true;
            // 
            // radioFahrplanAbDatum
            // 
            this.radioFahrplanAbDatum.AutoSize = true;
            this.radioFahrplanAbDatum.Location = new System.Drawing.Point(3, 6);
            this.radioFahrplanAbDatum.Name = "radioFahrplanAbDatum";
            this.radioFahrplanAbDatum.Size = new System.Drawing.Size(110, 24);
            this.radioFahrplanAbDatum.TabIndex = 0;
            this.radioFahrplanAbDatum.TabStop = true;
            this.radioFahrplanAbDatum.Text = "Abfahrtszeit";
            this.radioFahrplanAbDatum.UseVisualStyleBackColor = true;
            // 
            // panelFahrplanErgebnisse
            // 
            this.panelFahrplanErgebnisse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFahrplanErgebnisse.AutoScroll = true;
            this.panelFahrplanErgebnisse.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelFahrplanErgebnisse.Location = new System.Drawing.Point(3, 193);
            this.panelFahrplanErgebnisse.Name = "panelFahrplanErgebnisse";
            this.panelFahrplanErgebnisse.Size = new System.Drawing.Size(1008, 235);
            this.panelFahrplanErgebnisse.TabIndex = 11;
            // 
            // panelFahrplan
            // 
            this.panelFahrplan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFahrplan.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelFahrplan.Controls.Add(this.tableFahrplan);
            this.panelFahrplan.Location = new System.Drawing.Point(3, 3);
            this.panelFahrplan.Name = "panelFahrplan";
            this.panelFahrplan.Size = new System.Drawing.Size(1020, 437);
            this.panelFahrplan.TabIndex = 7;
            // 
            // panelVerbindungen
            // 
            this.panelVerbindungen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelVerbindungen.Controls.Add(this.tableLayoutPanel2);
            this.panelVerbindungen.Location = new System.Drawing.Point(3, 446);
            this.panelVerbindungen.Name = "panelVerbindungen";
            this.panelVerbindungen.Size = new System.Drawing.Size(1020, 437);
            this.panelVerbindungen.TabIndex = 8;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.panelVerbindungenErgebnisse, 0, 5);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1014, 431);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(3, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(314, 38);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mögliche Verbindungen";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 145F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 145F));
            this.tableLayoutPanel4.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label7, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.txtVerbindungenStation, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.txtVerbindungenDatum, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.btnVerbindungenSuchen, 2, 1);
            this.tableLayoutPanel4.Controls.Add(this.panel2, 3, 1);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 63);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1008, 74);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Station:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Datum:";
            // 
            // txtVerbindungenStation
            // 
            this.txtVerbindungenStation.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtVerbindungenStation.FormattingEnabled = true;
            this.txtVerbindungenStation.Location = new System.Drawing.Point(123, 3);
            this.txtVerbindungenStation.Name = "txtVerbindungenStation";
            this.txtVerbindungenStation.Size = new System.Drawing.Size(260, 31);
            this.txtVerbindungenStation.TabIndex = 4;
            // 
            // txtVerbindungenDatum
            // 
            this.txtVerbindungenDatum.CustomFormat = "dd.MM.yyyy HH:mm";
            this.txtVerbindungenDatum.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtVerbindungenDatum.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtVerbindungenDatum.Location = new System.Drawing.Point(123, 40);
            this.txtVerbindungenDatum.Name = "txtVerbindungenDatum";
            this.txtVerbindungenDatum.Size = new System.Drawing.Size(260, 30);
            this.txtVerbindungenDatum.TabIndex = 3;
            // 
            // btnVerbindungenSuchen
            // 
            this.btnVerbindungenSuchen.Location = new System.Drawing.Point(389, 40);
            this.btnVerbindungenSuchen.Name = "btnVerbindungenSuchen";
            this.btnVerbindungenSuchen.Size = new System.Drawing.Size(139, 31);
            this.btnVerbindungenSuchen.TabIndex = 5;
            this.btnVerbindungenSuchen.Text = "Suchen";
            this.btnVerbindungenSuchen.UseVisualStyleBackColor = true;
            this.btnVerbindungenSuchen.Click += new System.EventHandler(this.btnVerbindungenSuchen_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.radioVerbindungenAnDatum);
            this.panel2.Controls.Add(this.radioVerbindungenAbDatum);
            this.panel2.Location = new System.Drawing.Point(534, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(471, 31);
            this.panel2.TabIndex = 6;
            // 
            // radioVerbindungenAnDatum
            // 
            this.radioVerbindungenAnDatum.AutoSize = true;
            this.radioVerbindungenAnDatum.Location = new System.Drawing.Point(119, 3);
            this.radioVerbindungenAnDatum.Name = "radioVerbindungenAnDatum";
            this.radioVerbindungenAnDatum.Size = new System.Drawing.Size(111, 24);
            this.radioVerbindungenAnDatum.TabIndex = 1;
            this.radioVerbindungenAnDatum.TabStop = true;
            this.radioVerbindungenAnDatum.Text = "Ankunftszeit";
            this.radioVerbindungenAnDatum.UseVisualStyleBackColor = true;
            // 
            // radioVerbindungenAbDatum
            // 
            this.radioVerbindungenAbDatum.AutoSize = true;
            this.radioVerbindungenAbDatum.Location = new System.Drawing.Point(3, 3);
            this.radioVerbindungenAbDatum.Name = "radioVerbindungenAbDatum";
            this.radioVerbindungenAbDatum.Size = new System.Drawing.Size(110, 24);
            this.radioVerbindungenAbDatum.TabIndex = 0;
            this.radioVerbindungenAbDatum.TabStop = true;
            this.radioVerbindungenAbDatum.Text = "Abfahrtszeit";
            this.radioVerbindungenAbDatum.UseVisualStyleBackColor = true;
            // 
            // panelVerbindungenErgebnisse
            // 
            this.panelVerbindungenErgebnisse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelVerbindungenErgebnisse.AutoScroll = true;
            this.panelVerbindungenErgebnisse.Location = new System.Drawing.Point(3, 153);
            this.panelVerbindungenErgebnisse.Name = "panelVerbindungenErgebnisse";
            this.panelVerbindungenErgebnisse.Size = new System.Drawing.Size(1008, 391);
            this.panelVerbindungenErgebnisse.TabIndex = 2;
            // 
            // tableAppOptions
            // 
            this.tableAppOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableAppOptions.ColumnCount = 1;
            this.tableAppOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableAppOptions.Controls.Add(this.panelVerbindungen, 0, 1);
            this.tableAppOptions.Controls.Add(this.panelFahrplan, 0, 0);
            this.tableAppOptions.Controls.Add(this.panelInDerNaehe, 0, 2);
            this.tableAppOptions.Location = new System.Drawing.Point(12, 98);
            this.tableAppOptions.Name = "tableAppOptions";
            this.tableAppOptions.RowCount = 3;
            this.tableAppOptions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableAppOptions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableAppOptions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableAppOptions.Size = new System.Drawing.Size(1026, 945);
            this.tableAppOptions.TabIndex = 9;
            // 
            // panelInDerNaehe
            // 
            this.panelInDerNaehe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelInDerNaehe.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelInDerNaehe.Controls.Add(this.tableLayoutPanel6);
            this.panelInDerNaehe.Location = new System.Drawing.Point(3, 889);
            this.panelInDerNaehe.Name = "panelInDerNaehe";
            this.panelInDerNaehe.Size = new System.Drawing.Size(1020, 53);
            this.panelInDerNaehe.TabIndex = 9;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.Controls.Add(this.label8, 0, 1);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(1014, 1);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(3, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(287, 38);
            this.label8.TabIndex = 0;
            this.label8.Text = "Stationen in der Nähe";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 1055);
            this.Controls.Add(this.tableAppOptions);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(585, 560);
            this.Name = "Form1";
            this.Text = "MeinSBB App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableFahrplan.ResumeLayout(false);
            this.tableFahrplan.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelFahrplan.ResumeLayout(false);
            this.panelVerbindungen.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableAppOptions.ResumeLayout(false);
            this.panelInDerNaehe.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnFahrplan;
        private Button btnInDerNaehe;
        private Button btnVerbindungen;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableFahrplan;
        private Label label1;
        private Panel panelFahrplan;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label3;
        private Label label2;
        private Label label4;
        private Button btnFahrplanSuche;
        private FlowLayoutPanel panelFahrplanErgebnisse;
        private Button btnFahrplanEndstationMeinStandort;
        private Button btnFahrplanStartstationMeinStandort;
        private ComboBox txtFahrplanStartstation;
        private ComboBox txtFahrplanEndstation;
        private DateTimePicker txtFahrplanDatum;
        private Panel panel1;
        private RadioButton radioFahrplanAnDatum;
        private RadioButton radioFahrplanAbDatum;
        private Panel panelVerbindungen;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label5;
        private TableLayoutPanel tableLayoutPanel4;
        private Panel panelVerbindungenErgebnisse;
        private Label label6;
        private Label label7;
        private DateTimePicker txtVerbindungenDatum;
        private ComboBox txtVerbindungenStation;
        private Button btnVerbindungenSuchen;
        private Panel panel2;
        private RadioButton radioVerbindungenAnDatum;
        private RadioButton radioVerbindungenAbDatum;
        private TableLayoutPanel tableAppOptions;
        private Panel panelInDerNaehe;
        private TableLayoutPanel tableLayoutPanel6;
        private Label label8;
    }
}