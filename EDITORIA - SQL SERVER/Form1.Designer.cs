namespace EDITORIA___SQL_SERVER
{
    partial class frmMenu
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
            this.cmbPubblicazioni = new System.Windows.Forms.ComboBox();
            this.lblPubblicazioni = new System.Windows.Forms.Label();
            this.nudAnno = new System.Windows.Forms.NumericUpDown();
            this.lblAnno = new System.Windows.Forms.Label();
            this.btnQuery1 = new System.Windows.Forms.Button();
            this.dgvArticoliAnno = new System.Windows.Forms.DataGridView();
            this.lblArticoliAnno = new System.Windows.Forms.Label();
            this.btnAbbonamentiAnnuali = new System.Windows.Forms.Button();
            this.dgvAbbonamentiAnnuali = new System.Windows.Forms.DataGridView();
            this.btnNumeroPubblicazioni = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbAbbonati = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticoliAnno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbbonamentiAnnuali)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbPubblicazioni
            // 
            this.cmbPubblicazioni.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPubblicazioni.FormattingEnabled = true;
            this.cmbPubblicazioni.Location = new System.Drawing.Point(15, 25);
            this.cmbPubblicazioni.Name = "cmbPubblicazioni";
            this.cmbPubblicazioni.Size = new System.Drawing.Size(216, 21);
            this.cmbPubblicazioni.TabIndex = 1;
            // 
            // lblPubblicazioni
            // 
            this.lblPubblicazioni.AutoSize = true;
            this.lblPubblicazioni.Location = new System.Drawing.Point(12, 9);
            this.lblPubblicazioni.Name = "lblPubblicazioni";
            this.lblPubblicazioni.Size = new System.Drawing.Size(88, 13);
            this.lblPubblicazioni.TabIndex = 3;
            this.lblPubblicazioni.Text = "PUBBLICAZIONI";
            // 
            // nudAnno
            // 
            this.nudAnno.Location = new System.Drawing.Point(15, 65);
            this.nudAnno.Maximum = new decimal(new int[] {
            2025,
            0,
            0,
            0});
            this.nudAnno.Name = "nudAnno";
            this.nudAnno.Size = new System.Drawing.Size(120, 20);
            this.nudAnno.TabIndex = 2;
            this.nudAnno.Value = new decimal(new int[] {
            2024,
            0,
            0,
            0});
            // 
            // lblAnno
            // 
            this.lblAnno.AutoSize = true;
            this.lblAnno.Location = new System.Drawing.Point(12, 49);
            this.lblAnno.Name = "lblAnno";
            this.lblAnno.Size = new System.Drawing.Size(38, 13);
            this.lblAnno.TabIndex = 6;
            this.lblAnno.Text = "ANNO";
            // 
            // btnQuery1
            // 
            this.btnQuery1.Location = new System.Drawing.Point(156, 62);
            this.btnQuery1.Name = "btnQuery1";
            this.btnQuery1.Size = new System.Drawing.Size(75, 23);
            this.btnQuery1.TabIndex = 3;
            this.btnQuery1.Text = "CERCA";
            this.btnQuery1.UseVisualStyleBackColor = true;
            this.btnQuery1.Click += new System.EventHandler(this.btnQuery1_Click);
            // 
            // dgvArticoliAnno
            // 
            this.dgvArticoliAnno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticoliAnno.Location = new System.Drawing.Point(15, 151);
            this.dgvArticoliAnno.Name = "dgvArticoliAnno";
            this.dgvArticoliAnno.Size = new System.Drawing.Size(216, 287);
            this.dgvArticoliAnno.TabIndex = 8;
            // 
            // lblArticoliAnno
            // 
            this.lblArticoliAnno.AutoSize = true;
            this.lblArticoliAnno.Location = new System.Drawing.Point(15, 132);
            this.lblArticoliAnno.Name = "lblArticoliAnno";
            this.lblArticoliAnno.Size = new System.Drawing.Size(134, 13);
            this.lblArticoliAnno.TabIndex = 9;
            this.lblArticoliAnno.Text = "ARTICOLI DELL\'ANNO ??";
            // 
            // btnAbbonamentiAnnuali
            // 
            this.btnAbbonamentiAnnuali.Location = new System.Drawing.Point(273, 111);
            this.btnAbbonamentiAnnuali.Name = "btnAbbonamentiAnnuali";
            this.btnAbbonamentiAnnuali.Size = new System.Drawing.Size(216, 34);
            this.btnAbbonamentiAnnuali.TabIndex = 10;
            this.btnAbbonamentiAnnuali.Text = "ABBONAMENTI ANNUALI";
            this.btnAbbonamentiAnnuali.UseVisualStyleBackColor = true;
            this.btnAbbonamentiAnnuali.Click += new System.EventHandler(this.btnAbbonamentiAnnuali_Click);
            // 
            // dgvAbbonamentiAnnuali
            // 
            this.dgvAbbonamentiAnnuali.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAbbonamentiAnnuali.Location = new System.Drawing.Point(273, 151);
            this.dgvAbbonamentiAnnuali.Name = "dgvAbbonamentiAnnuali";
            this.dgvAbbonamentiAnnuali.Size = new System.Drawing.Size(216, 287);
            this.dgvAbbonamentiAnnuali.TabIndex = 11;
            // 
            // btnNumeroPubblicazioni
            // 
            this.btnNumeroPubblicazioni.Location = new System.Drawing.Point(528, 111);
            this.btnNumeroPubblicazioni.Name = "btnNumeroPubblicazioni";
            this.btnNumeroPubblicazioni.Size = new System.Drawing.Size(216, 34);
            this.btnNumeroPubblicazioni.TabIndex = 12;
            this.btnNumeroPubblicazioni.Text = "NUMERO PUBBLICAZIONI";
            this.btnNumeroPubblicazioni.UseVisualStyleBackColor = true;
            this.btnNumeroPubblicazioni.Click += new System.EventHandler(this.btnNumeroPubblicazioni_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(525, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "ABBONATI";
            // 
            // cmbAbbonati
            // 
            this.cmbAbbonati.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAbbonati.FormattingEnabled = true;
            this.cmbAbbonati.Location = new System.Drawing.Point(528, 84);
            this.cmbAbbonati.Name = "cmbAbbonati";
            this.cmbAbbonati.Size = new System.Drawing.Size(216, 21);
            this.cmbAbbonati.TabIndex = 13;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbAbbonati);
            this.Controls.Add(this.btnNumeroPubblicazioni);
            this.Controls.Add(this.dgvAbbonamentiAnnuali);
            this.Controls.Add(this.btnAbbonamentiAnnuali);
            this.Controls.Add(this.lblArticoliAnno);
            this.Controls.Add(this.dgvArticoliAnno);
            this.Controls.Add(this.btnQuery1);
            this.Controls.Add(this.lblAnno);
            this.Controls.Add(this.nudAnno);
            this.Controls.Add(this.lblPubblicazioni);
            this.Controls.Add(this.cmbPubblicazioni);
            this.Name = "frmMenu";
            this.Text = "data";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudAnno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticoliAnno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbbonamentiAnnuali)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbPubblicazioni;
        private System.Windows.Forms.Label lblPubblicazioni;
        private System.Windows.Forms.NumericUpDown nudAnno;
        private System.Windows.Forms.Label lblAnno;
        private System.Windows.Forms.Button btnQuery1;
        private System.Windows.Forms.DataGridView dgvArticoliAnno;
        private System.Windows.Forms.Label lblArticoliAnno;
        private System.Windows.Forms.Button btnAbbonamentiAnnuali;
        private System.Windows.Forms.DataGridView dgvAbbonamentiAnnuali;
        private System.Windows.Forms.Button btnNumeroPubblicazioni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbAbbonati;
    }
}

