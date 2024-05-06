namespace G8_Quartett
{
    partial class Window
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstKarten = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblKarte = new System.Windows.Forms.Label();
            this.btnBenutzeWert = new System.Windows.Forms.Button();
            this.btnBenutzeFarbe = new System.Windows.Forms.Button();
            this.lstSpielerGespielt = new System.Windows.Forms.ListBox();
            this.lstComputerGespielt = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnNameEingeben = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstKarten
            // 
            this.lstKarten.FormattingEnabled = true;
            this.lstKarten.ItemHeight = 16;
            this.lstKarten.Location = new System.Drawing.Point(287, 12);
            this.lstKarten.Name = "lstKarten";
            this.lstKarten.Size = new System.Drawing.Size(120, 420);
            this.lstKarten.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Aktuelle Karte:";
            // 
            // lblKarte
            // 
            this.lblKarte.AutoSize = true;
            this.lblKarte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblKarte.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKarte.Location = new System.Drawing.Point(80, 44);
            this.lblKarte.Name = "lblKarte";
            this.lblKarte.Size = new System.Drawing.Size(66, 34);
            this.lblKarte.TabIndex = 3;
            this.lblKarte.Text = "text";
            this.lblKarte.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBenutzeWert
            // 
            this.btnBenutzeWert.Location = new System.Drawing.Point(18, 150);
            this.btnBenutzeWert.Name = "btnBenutzeWert";
            this.btnBenutzeWert.Size = new System.Drawing.Size(209, 56);
            this.btnBenutzeWert.TabIndex = 4;
            this.btnBenutzeWert.Text = "Wert";
            this.btnBenutzeWert.UseVisualStyleBackColor = true;
            this.btnBenutzeWert.Click += new System.EventHandler(this.btnBenutzeWert_Click);
            // 
            // btnBenutzeFarbe
            // 
            this.btnBenutzeFarbe.Location = new System.Drawing.Point(18, 229);
            this.btnBenutzeFarbe.Name = "btnBenutzeFarbe";
            this.btnBenutzeFarbe.Size = new System.Drawing.Size(209, 56);
            this.btnBenutzeFarbe.TabIndex = 5;
            this.btnBenutzeFarbe.Text = "Farbe";
            this.btnBenutzeFarbe.UseVisualStyleBackColor = true;
            this.btnBenutzeFarbe.Click += new System.EventHandler(this.btnBenutzeFarbe_Click);
            // 
            // lstSpielerGespielt
            // 
            this.lstSpielerGespielt.FormattingEnabled = true;
            this.lstSpielerGespielt.ItemHeight = 16;
            this.lstSpielerGespielt.Location = new System.Drawing.Point(476, 150);
            this.lstSpielerGespielt.Name = "lstSpielerGespielt";
            this.lstSpielerGespielt.Size = new System.Drawing.Size(120, 164);
            this.lstSpielerGespielt.TabIndex = 6;
            // 
            // lstComputerGespielt
            // 
            this.lstComputerGespielt.FormattingEnabled = true;
            this.lstComputerGespielt.ItemHeight = 16;
            this.lstComputerGespielt.Location = new System.Drawing.Point(631, 150);
            this.lstComputerGespielt.Name = "lstComputerGespielt";
            this.lstComputerGespielt.Size = new System.Drawing.Size(120, 164);
            this.lstComputerGespielt.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(473, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Deine Karten:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(628, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Comuter Karten:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 416);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Dein Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(99, 416);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 11;
            // 
            // btnNameEingeben
            // 
            this.btnNameEingeben.Location = new System.Drawing.Point(205, 416);
            this.btnNameEingeben.Name = "btnNameEingeben";
            this.btnNameEingeben.Size = new System.Drawing.Size(66, 30);
            this.btnNameEingeben.TabIndex = 12;
            this.btnNameEingeben.Text = "OK";
            this.btnNameEingeben.UseVisualStyleBackColor = true;
            this.btnNameEingeben.Click += new System.EventHandler(this.btnNameEingeben_Click);
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNameEingeben);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstComputerGespielt);
            this.Controls.Add(this.lstSpielerGespielt);
            this.Controls.Add(this.btnBenutzeFarbe);
            this.Controls.Add(this.btnBenutzeWert);
            this.Controls.Add(this.lblKarte);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstKarten);
            this.Name = "Window";
            this.Text = "Quartett";
            this.Load += new System.EventHandler(this.Window_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstKarten;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblKarte;
        private System.Windows.Forms.Button btnBenutzeWert;
        private System.Windows.Forms.Button btnBenutzeFarbe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstSpielerGespielt;
        private System.Windows.Forms.ListBox lstComputerGespielt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnNameEingeben;
    }
}

