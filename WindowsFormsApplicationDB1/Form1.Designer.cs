namespace WindowsFormsApplicationDB1
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.buttonCommand = new System.Windows.Forms.Button();
            this.buttonReader = new System.Windows.Forms.Button();
            this.listBoxAusgabe = new System.Windows.Forms.ListBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonNeuerDatensatz = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxBezirk = new System.Windows.Forms.TextBox();
            this.buttonNeuerBezirk = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(43, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "Connection";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 412);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(708, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // buttonCommand
            // 
            this.buttonCommand.Location = new System.Drawing.Point(43, 104);
            this.buttonCommand.Name = "buttonCommand";
            this.buttonCommand.Size = new System.Drawing.Size(107, 41);
            this.buttonCommand.TabIndex = 2;
            this.buttonCommand.Text = "Command";
            this.buttonCommand.UseVisualStyleBackColor = true;
            this.buttonCommand.Click += new System.EventHandler(this.buttonCommand_Click);
            // 
            // buttonReader
            // 
            this.buttonReader.Location = new System.Drawing.Point(43, 163);
            this.buttonReader.Name = "buttonReader";
            this.buttonReader.Size = new System.Drawing.Size(107, 43);
            this.buttonReader.TabIndex = 3;
            this.buttonReader.Text = "anzeigen";
            this.buttonReader.UseVisualStyleBackColor = true;
            this.buttonReader.Click += new System.EventHandler(this.buttonReader_Click);
            // 
            // listBoxAusgabe
            // 
            this.listBoxAusgabe.FormattingEnabled = true;
            this.listBoxAusgabe.Location = new System.Drawing.Point(47, 231);
            this.listBoxAusgabe.Name = "listBoxAusgabe";
            this.listBoxAusgabe.Size = new System.Drawing.Size(450, 160);
            this.listBoxAusgabe.TabIndex = 4;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(295, 103);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(153, 42);
            this.buttonUpdate.TabIndex = 5;
            this.buttonUpdate.Text = "ausgewählten Datensatz ändern";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonNeuerDatensatz
            // 
            this.buttonNeuerDatensatz.Location = new System.Drawing.Point(483, 105);
            this.buttonNeuerDatensatz.Name = "buttonNeuerDatensatz";
            this.buttonNeuerDatensatz.Size = new System.Drawing.Size(153, 39);
            this.buttonNeuerDatensatz.TabIndex = 6;
            this.buttonNeuerDatensatz.Text = "Neuen Datensatz anlegen";
            this.buttonNeuerDatensatz.UseVisualStyleBackColor = true;
            this.buttonNeuerDatensatz.Click += new System.EventHandler(this.buttonNeuerDatensatz_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(231, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Bezirk";
            // 
            // textBoxBezirk
            // 
            this.textBoxBezirk.Location = new System.Drawing.Point(291, 37);
            this.textBoxBezirk.Name = "textBoxBezirk";
            this.textBoxBezirk.Size = new System.Drawing.Size(135, 20);
            this.textBoxBezirk.TabIndex = 8;
            // 
            // buttonNeuerBezirk
            // 
            this.buttonNeuerBezirk.Location = new System.Drawing.Point(449, 34);
            this.buttonNeuerBezirk.Name = "buttonNeuerBezirk";
            this.buttonNeuerBezirk.Size = new System.Drawing.Size(77, 22);
            this.buttonNeuerBezirk.TabIndex = 9;
            this.buttonNeuerBezirk.Text = "Neu";
            this.buttonNeuerBezirk.UseVisualStyleBackColor = true;
            this.buttonNeuerBezirk.Click += new System.EventHandler(this.buttonNeuerBezirk_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 434);
            this.Controls.Add(this.buttonNeuerBezirk);
            this.Controls.Add(this.textBoxBezirk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonNeuerDatensatz);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.listBoxAusgabe);
            this.Controls.Add(this.buttonReader);
            this.Controls.Add(this.buttonCommand);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "OleDb - Zugriff";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button buttonCommand;
        private System.Windows.Forms.Button buttonReader;
        private System.Windows.Forms.ListBox listBoxAusgabe;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonNeuerDatensatz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxBezirk;
        private System.Windows.Forms.Button buttonNeuerBezirk;
    }
}

