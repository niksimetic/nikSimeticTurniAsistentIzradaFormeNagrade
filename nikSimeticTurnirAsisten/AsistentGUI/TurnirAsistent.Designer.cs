namespace AsistentGUI
{
    partial class TurnirAsistent
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
            this.btnUcitajTurnir = new System.Windows.Forms.Button();
            this.btnKreirajNoviTurnir = new System.Windows.Forms.Button();
            this.lblNazivTurnira = new System.Windows.Forms.Label();
            this.cmbNazivTurnira = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnUcitajTurnir
            // 
            this.btnUcitajTurnir.Location = new System.Drawing.Point(221, 156);
            this.btnUcitajTurnir.Name = "btnUcitajTurnir";
            this.btnUcitajTurnir.Size = new System.Drawing.Size(176, 45);
            this.btnUcitajTurnir.TabIndex = 0;
            this.btnUcitajTurnir.Text = "Učitaj turnir";
            this.btnUcitajTurnir.UseVisualStyleBackColor = true;
            // 
            // btnKreirajNoviTurnir
            // 
            this.btnKreirajNoviTurnir.Location = new System.Drawing.Point(221, 240);
            this.btnKreirajNoviTurnir.Name = "btnKreirajNoviTurnir";
            this.btnKreirajNoviTurnir.Size = new System.Drawing.Size(176, 48);
            this.btnKreirajNoviTurnir.TabIndex = 1;
            this.btnKreirajNoviTurnir.Text = "Kreiraj Turnir";
            this.btnKreirajNoviTurnir.UseVisualStyleBackColor = true;
            // 
            // lblNazivTurnira
            // 
            this.lblNazivTurnira.AutoSize = true;
            this.lblNazivTurnira.Location = new System.Drawing.Point(169, 84);
            this.lblNazivTurnira.Name = "lblNazivTurnira";
            this.lblNazivTurnira.Size = new System.Drawing.Size(37, 13);
            this.lblNazivTurnira.TabIndex = 2;
            this.lblNazivTurnira.Text = "Naziv:";
            // 
            // cmbNazivTurnira
            // 
            this.cmbNazivTurnira.FormattingEnabled = true;
            this.cmbNazivTurnira.Location = new System.Drawing.Point(276, 76);
            this.cmbNazivTurnira.Name = "cmbNazivTurnira";
            this.cmbNazivTurnira.Size = new System.Drawing.Size(121, 21);
            this.cmbNazivTurnira.TabIndex = 3;
            // 
            // TurnirAsistent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 407);
            this.Controls.Add(this.cmbNazivTurnira);
            this.Controls.Add(this.lblNazivTurnira);
            this.Controls.Add(this.btnKreirajNoviTurnir);
            this.Controls.Add(this.btnUcitajTurnir);
            this.Name = "TurnirAsistent";
            this.Text = "TurnirAsistent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUcitajTurnir;
        private System.Windows.Forms.Button btnKreirajNoviTurnir;
        private System.Windows.Forms.Label lblNazivTurnira;
        private System.Windows.Forms.ComboBox cmbNazivTurnira;
    }
}