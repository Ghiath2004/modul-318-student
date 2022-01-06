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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFahrplanStartstation = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFahrplanEndstation = new System.Windows.Forms.TextBox();
            this.txtFahrplanDatum = new System.Windows.Forms.TextBox();
            this.btnFahrplanSuche = new System.Windows.Forms.Button();
            this.panelFahrplanErgebnisse = new System.Windows.Forms.FlowLayoutPanel();
            this.stationenKarten2 = new SBB_Klon.stationenKarten();
            this.panelFahrplan = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panelFahrplanErgebnisse.SuspendLayout();
            this.panelFahrplan.SuspendLayout();
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
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.panelFahrplanErgebnisse, 0, 5);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1020, 464);
            this.tableLayoutPanel2.TabIndex = 6;
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
            this.tableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 145F));
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.txtFahrplanStartstation, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.txtFahrplanEndstation, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.txtFahrplanDatum, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.btnFahrplanSuche, 2, 2);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 63);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(826, 114);
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
            // txtFahrplanStartstation
            // 
            this.txtFahrplanStartstation.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtFahrplanStartstation.Location = new System.Drawing.Point(123, 5);
            this.txtFahrplanStartstation.Name = "txtFahrplanStartstation";
            this.txtFahrplanStartstation.Size = new System.Drawing.Size(260, 27);
            this.txtFahrplanStartstation.TabIndex = 1;
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
            // txtFahrplanEndstation
            // 
            this.txtFahrplanEndstation.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtFahrplanEndstation.Location = new System.Drawing.Point(123, 43);
            this.txtFahrplanEndstation.Name = "txtFahrplanEndstation";
            this.txtFahrplanEndstation.Size = new System.Drawing.Size(260, 27);
            this.txtFahrplanEndstation.TabIndex = 11;
            // 
            // txtFahrplanDatum
            // 
            this.txtFahrplanDatum.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtFahrplanDatum.Location = new System.Drawing.Point(123, 81);
            this.txtFahrplanDatum.Name = "txtFahrplanDatum";
            this.txtFahrplanDatum.Size = new System.Drawing.Size(260, 27);
            this.txtFahrplanDatum.TabIndex = 13;
            // 
            // btnFahrplanSuche
            // 
            this.btnFahrplanSuche.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnFahrplanSuche.Location = new System.Drawing.Point(389, 79);
            this.btnFahrplanSuche.Name = "btnFahrplanSuche";
            this.btnFahrplanSuche.Size = new System.Drawing.Size(139, 32);
            this.btnFahrplanSuche.TabIndex = 15;
            this.btnFahrplanSuche.Text = "Suchen";
            this.btnFahrplanSuche.UseVisualStyleBackColor = true;
            this.btnFahrplanSuche.Click += new System.EventHandler(this.btnFahrplanSuche_Click);
            // 
            // panelFahrplanErgebnisse
            // 
            this.panelFahrplanErgebnisse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFahrplanErgebnisse.AutoScroll = true;
            this.panelFahrplanErgebnisse.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelFahrplanErgebnisse.Controls.Add(this.stationenKarten2);
            this.panelFahrplanErgebnisse.Location = new System.Drawing.Point(3, 193);
            this.panelFahrplanErgebnisse.Name = "panelFahrplanErgebnisse";
            this.panelFahrplanErgebnisse.Size = new System.Drawing.Size(1014, 271);
            this.panelFahrplanErgebnisse.TabIndex = 11;
            // 
            // stationenKarten2
            // 
            this.stationenKarten2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stationenKarten2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.stationenKarten2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.stationenKarten2.Info1 = null;
            this.stationenKarten2.Info1Bez = null;
            this.stationenKarten2.Info2 = null;
            this.stationenKarten2.Info2Bez = null;
            this.stationenKarten2.Location = new System.Drawing.Point(3, 3);
            this.stationenKarten2.Name = "stationenKarten2";
            this.stationenKarten2.Size = new System.Drawing.Size(819, 143);
            this.stationenKarten2.TabIndex = 0;
            this.stationenKarten2.Titel = null;
            this.stationenKarten2.Verspaetung = null;
            // 
            // panelFahrplan
            // 
            this.panelFahrplan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFahrplan.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelFahrplan.Controls.Add(this.tableLayoutPanel2);
            this.panelFahrplan.Location = new System.Drawing.Point(12, 98);
            this.panelFahrplan.Name = "panelFahrplan";
            this.panelFahrplan.Size = new System.Drawing.Size(1026, 470);
            this.panelFahrplan.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 580);
            this.Controls.Add(this.panelFahrplan);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(585, 560);
            this.Name = "Form1";
            this.Text = "MeinSBB App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.panelFahrplanErgebnisse.ResumeLayout(false);
            this.panelFahrplan.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnFahrplan;
        private Button btnInDerNaehe;
        private Button btnVerbindungen;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private TextBox txtFahrplanStartstation;
        private Panel panelFahrplan;
        private stationenKarten stationenKarten1;
        private TableLayoutPanel tableLayoutPanel3;
        private TextBox txtFahrplanEndstation;
        private Label label3;
        private Label label2;
        private Label label4;
        private TextBox txtFahrplanDatum;
        private Button btnFahrplanSuchen;
        private Button btnFahrplanSuche;
        private FlowLayoutPanel panelFahrplanErgebnisse;
        private stationenKarten stationenKarten2;
    }
}