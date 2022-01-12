namespace SBB_Klon
{
    partial class emailSenden
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSendEmail = new System.Windows.Forms.Button();
            this.txtEmailTo = new System.Windows.Forms.TextBox();
            this.txtEmailSubject = new System.Windows.Forms.TextBox();
            this.txtEmailBody = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSendEmail
            // 
            this.btnSendEmail.Enabled = false;
            this.btnSendEmail.Location = new System.Drawing.Point(579, 390);
            this.btnSendEmail.Name = "btnSendEmail";
            this.btnSendEmail.Size = new System.Drawing.Size(209, 48);
            this.btnSendEmail.TabIndex = 0;
            this.btnSendEmail.Text = "Senden";
            this.btnSendEmail.UseVisualStyleBackColor = true;
            this.btnSendEmail.Click += new System.EventHandler(this.btnSendEmail_Click);
            // 
            // txtEmailTo
            // 
            this.txtEmailTo.Location = new System.Drawing.Point(113, 11);
            this.txtEmailTo.Name = "txtEmailTo";
            this.txtEmailTo.Size = new System.Drawing.Size(675, 27);
            this.txtEmailTo.TabIndex = 1;
            this.txtEmailTo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVerbindungenStation_KeyDown);
            // 
            // txtEmailSubject
            // 
            this.txtEmailSubject.Location = new System.Drawing.Point(113, 44);
            this.txtEmailSubject.Name = "txtEmailSubject";
            this.txtEmailSubject.Size = new System.Drawing.Size(675, 27);
            this.txtEmailSubject.TabIndex = 2;
            this.txtEmailSubject.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVerbindungenStation_KeyDown);
            // 
            // txtEmailBody
            // 
            this.txtEmailBody.Location = new System.Drawing.Point(113, 77);
            this.txtEmailBody.Name = "txtEmailBody";
            this.txtEmailBody.Size = new System.Drawing.Size(675, 307);
            this.txtEmailBody.TabIndex = 3;
            this.txtEmailBody.Text = "";
            this.txtEmailBody.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVerbindungenStation_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Empfänger:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Betreff:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nachricht:";
            // 
            // emailSenden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEmailBody);
            this.Controls.Add(this.txtEmailSubject);
            this.Controls.Add(this.txtEmailTo);
            this.Controls.Add(this.btnSendEmail);
            this.Name = "emailSenden";
            this.Text = "emailSenden";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnSendEmail;
        private TextBox txtEmailTo;
        private TextBox txtEmailSubject;
        private RichTextBox txtEmailBody;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}