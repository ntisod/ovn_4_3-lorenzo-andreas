namespace Övning_4._3
{
    partial class FrmKontakt
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
            this.btnÖppna = new System.Windows.Forms.Button();
            this.lblFörnmn = new System.Windows.Forms.Label();
            this.tbxTelefonnummer = new System.Windows.Forms.TextBox();
            this.lblTelefonnr = new System.Windows.Forms.Label();
            this.tbxEpost = new System.Windows.Forms.TextBox();
            this.lblEpost = new System.Windows.Forms.Label();
            this.tbxEfternamn = new System.Windows.Forms.TextBox();
            this.lblEfternamn = new System.Windows.Forms.Label();
            this.btnSparaSom = new System.Windows.Forms.Button();
            this.dlgSparaFil = new System.Windows.Forms.SaveFileDialog();
            this.tbxFörnamn = new System.Windows.Forms.TextBox();
            this.dlgÖppnaFil = new System.Windows.Forms.OpenFileDialog();
            this.lbxKontakter = new System.Windows.Forms.ListBox();
            this.btnLäggtill = new System.Windows.Forms.Button();
            this.btnTabort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnÖppna
            // 
            this.btnÖppna.Location = new System.Drawing.Point(225, 319);
            this.btnÖppna.Name = "btnÖppna";
            this.btnÖppna.Size = new System.Drawing.Size(127, 39);
            this.btnÖppna.TabIndex = 0;
            this.btnÖppna.Text = "Öppna";
            this.btnÖppna.UseVisualStyleBackColor = true;
            this.btnÖppna.Click += new System.EventHandler(this.btnÖppna_Click);
            // 
            // lblFörnmn
            // 
            this.lblFörnmn.AutoSize = true;
            this.lblFörnmn.Location = new System.Drawing.Point(34, 78);
            this.lblFörnmn.Name = "lblFörnmn";
            this.lblFörnmn.Size = new System.Drawing.Size(73, 20);
            this.lblFörnmn.TabIndex = 1;
            this.lblFörnmn.Text = "Förnamn";
            // 
            // tbxTelefonnummer
            // 
            this.tbxTelefonnummer.Location = new System.Drawing.Point(160, 218);
            this.tbxTelefonnummer.Name = "tbxTelefonnummer";
            this.tbxTelefonnummer.Size = new System.Drawing.Size(192, 26);
            this.tbxTelefonnummer.TabIndex = 4;
            // 
            // lblTelefonnr
            // 
            this.lblTelefonnr.AutoSize = true;
            this.lblTelefonnr.Location = new System.Drawing.Point(34, 224);
            this.lblTelefonnr.Name = "lblTelefonnr";
            this.lblTelefonnr.Size = new System.Drawing.Size(120, 20);
            this.lblTelefonnr.TabIndex = 3;
            this.lblTelefonnr.Text = "Telefonnummer";
            // 
            // tbxEpost
            // 
            this.tbxEpost.Location = new System.Drawing.Point(160, 166);
            this.tbxEpost.Name = "tbxEpost";
            this.tbxEpost.Size = new System.Drawing.Size(192, 26);
            this.tbxEpost.TabIndex = 6;
            // 
            // lblEpost
            // 
            this.lblEpost.AutoSize = true;
            this.lblEpost.Location = new System.Drawing.Point(34, 172);
            this.lblEpost.Name = "lblEpost";
            this.lblEpost.Size = new System.Drawing.Size(51, 20);
            this.lblEpost.TabIndex = 5;
            this.lblEpost.Text = "Epost";
            // 
            // tbxEfternamn
            // 
            this.tbxEfternamn.Location = new System.Drawing.Point(160, 123);
            this.tbxEfternamn.Name = "tbxEfternamn";
            this.tbxEfternamn.Size = new System.Drawing.Size(192, 26);
            this.tbxEfternamn.TabIndex = 8;
            // 
            // lblEfternamn
            // 
            this.lblEfternamn.AutoSize = true;
            this.lblEfternamn.Location = new System.Drawing.Point(34, 123);
            this.lblEfternamn.Name = "lblEfternamn";
            this.lblEfternamn.Size = new System.Drawing.Size(84, 20);
            this.lblEfternamn.TabIndex = 7;
            this.lblEfternamn.Text = "Efternamn";
            // 
            // btnSparaSom
            // 
            this.btnSparaSom.Location = new System.Drawing.Point(27, 319);
            this.btnSparaSom.Name = "btnSparaSom";
            this.btnSparaSom.Size = new System.Drawing.Size(127, 39);
            this.btnSparaSom.TabIndex = 9;
            this.btnSparaSom.Text = "Spara som...";
            this.btnSparaSom.UseVisualStyleBackColor = true;
            this.btnSparaSom.Click += new System.EventHandler(this.btnSparaSom_Click);
            // 
            // tbxFörnamn
            // 
            this.tbxFörnamn.Location = new System.Drawing.Point(160, 78);
            this.tbxFörnamn.Name = "tbxFörnamn";
            this.tbxFörnamn.Size = new System.Drawing.Size(192, 26);
            this.tbxFörnamn.TabIndex = 10;
            // 
            // lbxKontakter
            // 
            this.lbxKontakter.FormattingEnabled = true;
            this.lbxKontakter.ItemHeight = 20;
            this.lbxKontakter.Location = new System.Drawing.Point(420, 78);
            this.lbxKontakter.Name = "lbxKontakter";
            this.lbxKontakter.Size = new System.Drawing.Size(300, 164);
            this.lbxKontakter.TabIndex = 11;
            this.lbxKontakter.SelectedIndexChanged += new System.EventHandler(this.lbxKontakter_SelectedIndexChanged);
            // 
            // btnLäggtill
            // 
            this.btnLäggtill.Location = new System.Drawing.Point(420, 319);
            this.btnLäggtill.Name = "btnLäggtill";
            this.btnLäggtill.Size = new System.Drawing.Size(127, 39);
            this.btnLäggtill.TabIndex = 12;
            this.btnLäggtill.Text = "Lägg till";
            this.btnLäggtill.UseVisualStyleBackColor = true;
            this.btnLäggtill.Click += new System.EventHandler(this.btnLäggtill_Click);
            // 
            // btnTabort
            // 
            this.btnTabort.Location = new System.Drawing.Point(593, 319);
            this.btnTabort.Name = "btnTabort";
            this.btnTabort.Size = new System.Drawing.Size(127, 39);
            this.btnTabort.TabIndex = 13;
            this.btnTabort.Text = "Ta bort";
            this.btnTabort.UseVisualStyleBackColor = true;
            this.btnTabort.Click += new System.EventHandler(this.btnTabort_Click);
            // 
            // FrmKontakt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTabort);
            this.Controls.Add(this.btnLäggtill);
            this.Controls.Add(this.lbxKontakter);
            this.Controls.Add(this.tbxFörnamn);
            this.Controls.Add(this.btnSparaSom);
            this.Controls.Add(this.tbxEfternamn);
            this.Controls.Add(this.lblEfternamn);
            this.Controls.Add(this.tbxEpost);
            this.Controls.Add(this.lblEpost);
            this.Controls.Add(this.tbxTelefonnummer);
            this.Controls.Add(this.lblTelefonnr);
            this.Controls.Add(this.lblFörnmn);
            this.Controls.Add(this.btnÖppna);
            this.Name = "FrmKontakt";
            this.Text = "En Kontakt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnÖppna;
        private System.Windows.Forms.Label lblFörnmn;
        private System.Windows.Forms.TextBox tbxTelefonnummer;
        private System.Windows.Forms.Label lblTelefonnr;
        private System.Windows.Forms.TextBox tbxEpost;
        private System.Windows.Forms.Label lblEpost;
        private System.Windows.Forms.TextBox tbxEfternamn;
        private System.Windows.Forms.Label lblEfternamn;
        private System.Windows.Forms.Button btnSparaSom;
        private System.Windows.Forms.SaveFileDialog dlgSparaFil;
        private System.Windows.Forms.TextBox tbxFörnamn;
        private System.Windows.Forms.OpenFileDialog dlgÖppnaFil;
        private System.Windows.Forms.ListBox lbxKontakter;
        private System.Windows.Forms.Button btnLäggtill;
        private System.Windows.Forms.Button btnTabort;
    }
}

