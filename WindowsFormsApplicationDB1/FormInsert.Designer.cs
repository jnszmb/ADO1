namespace WindowsFormsApplicationDB1
{
    partial class FormInsert
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.textBoxVkPreis = new System.Windows.Forms.TextBox();
            this.textBoxMeldebestand = new System.Windows.Forms.TextBox();
            this.textBoxBestand = new System.Windows.Forms.TextBox();
            this.textBoxBezeichnung = new System.Windows.Forms.TextBox();
            this.textBoxArtikelNr = new System.Windows.Forms.TextBox();
            this.textBoxArtikelOid = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxArtikelGruppe = new System.Windows.Forms.ComboBox();
            this.comboBoxVerpackung = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(456, 351);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(89, 52);
            this.buttonCancel.TabIndex = 40;
            this.buttonCancel.Text = "Abbruch";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(361, 351);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(89, 52);
            this.buttonOk.TabIndex = 39;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            // 
            // textBoxVkPreis
            // 
            this.textBoxVkPreis.Location = new System.Drawing.Point(136, 341);
            this.textBoxVkPreis.Name = "textBoxVkPreis";
            this.textBoxVkPreis.Size = new System.Drawing.Size(180, 20);
            this.textBoxVkPreis.TabIndex = 37;
            // 
            // textBoxMeldebestand
            // 
            this.textBoxMeldebestand.Location = new System.Drawing.Point(136, 260);
            this.textBoxMeldebestand.Name = "textBoxMeldebestand";
            this.textBoxMeldebestand.Size = new System.Drawing.Size(180, 20);
            this.textBoxMeldebestand.TabIndex = 35;
            // 
            // textBoxBestand
            // 
            this.textBoxBestand.Location = new System.Drawing.Point(136, 219);
            this.textBoxBestand.Name = "textBoxBestand";
            this.textBoxBestand.Size = new System.Drawing.Size(180, 20);
            this.textBoxBestand.TabIndex = 34;
            // 
            // textBoxBezeichnung
            // 
            this.textBoxBezeichnung.Location = new System.Drawing.Point(136, 177);
            this.textBoxBezeichnung.Name = "textBoxBezeichnung";
            this.textBoxBezeichnung.Size = new System.Drawing.Size(180, 20);
            this.textBoxBezeichnung.TabIndex = 33;
            // 
            // textBoxArtikelNr
            // 
            this.textBoxArtikelNr.Location = new System.Drawing.Point(136, 93);
            this.textBoxArtikelNr.Name = "textBoxArtikelNr";
            this.textBoxArtikelNr.Size = new System.Drawing.Size(180, 20);
            this.textBoxArtikelNr.TabIndex = 31;
            // 
            // textBoxArtikelOid
            // 
            this.textBoxArtikelOid.Location = new System.Drawing.Point(136, 51);
            this.textBoxArtikelOid.Name = "textBoxArtikelOid";
            this.textBoxArtikelOid.ReadOnly = true;
            this.textBoxArtikelOid.Size = new System.Drawing.Size(180, 20);
            this.textBoxArtikelOid.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 389);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "letzteEntnahme";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 348);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "VkPreis";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 309);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Verpackung";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Meldebestand";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Bestand";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Bezeichnung";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "ArtikelGruppe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "ArtikelNr";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "ArtikelOid";
            // 
            // comboBoxArtikelGruppe
            // 
            this.comboBoxArtikelGruppe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxArtikelGruppe.FormattingEnabled = true;
            this.comboBoxArtikelGruppe.Location = new System.Drawing.Point(136, 132);
            this.comboBoxArtikelGruppe.Name = "comboBoxArtikelGruppe";
            this.comboBoxArtikelGruppe.Size = new System.Drawing.Size(180, 21);
            this.comboBoxArtikelGruppe.TabIndex = 42;
            // 
            // comboBoxVerpackung
            // 
            this.comboBoxVerpackung.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVerpackung.FormattingEnabled = true;
            this.comboBoxVerpackung.Location = new System.Drawing.Point(136, 301);
            this.comboBoxVerpackung.Name = "comboBoxVerpackung";
            this.comboBoxVerpackung.Size = new System.Drawing.Size(180, 21);
            this.comboBoxVerpackung.TabIndex = 43;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(136, 383);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(180, 20);
            this.dateTimePicker1.TabIndex = 44;
            // 
            // FormInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 572);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBoxVerpackung);
            this.Controls.Add(this.comboBoxArtikelGruppe);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.textBoxVkPreis);
            this.Controls.Add(this.textBoxMeldebestand);
            this.Controls.Add(this.textBoxBestand);
            this.Controls.Add(this.textBoxBezeichnung);
            this.Controls.Add(this.textBoxArtikelNr);
            this.Controls.Add(this.textBoxArtikelOid);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormInsert";
            this.Text = "Neuer Datensatz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.TextBox textBoxVkPreis;
        private System.Windows.Forms.TextBox textBoxMeldebestand;
        private System.Windows.Forms.TextBox textBoxBestand;
        private System.Windows.Forms.TextBox textBoxBezeichnung;
        private System.Windows.Forms.TextBox textBoxArtikelNr;
        private System.Windows.Forms.TextBox textBoxArtikelOid;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxArtikelGruppe;
        private System.Windows.Forms.ComboBox comboBoxVerpackung;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}