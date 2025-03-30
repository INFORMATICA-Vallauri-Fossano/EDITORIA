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
            this.cmbPubblicazione = new System.Windows.Forms.ComboBox();
            this.lblPubblicazioni = new System.Windows.Forms.Label();
            this.nudAnno = new System.Windows.Forms.NumericUpDown();
            this.lblAnno = new System.Windows.Forms.Label();
            this.btnQuery1 = new System.Windows.Forms.Button();
            this.dgvArticoliAnno = new System.Windows.Forms.DataGridView();
            this.lblArticoliAnno = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticoliAnno)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbPubblicazione
            // 
            this.cmbPubblicazione.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPubblicazione.FormattingEnabled = true;
            this.cmbPubblicazione.Location = new System.Drawing.Point(20, 31);
            this.cmbPubblicazione.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbPubblicazione.Name = "cmbPubblicazione";
            this.cmbPubblicazione.Size = new System.Drawing.Size(287, 24);
            this.cmbPubblicazione.TabIndex = 1;
            // 
            // lblPubblicazioni
            // 
            this.lblPubblicazioni.AutoSize = true;
            this.lblPubblicazioni.Location = new System.Drawing.Point(16, 11);
            this.lblPubblicazioni.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPubblicazioni.Name = "lblPubblicazioni";
            this.lblPubblicazioni.Size = new System.Drawing.Size(106, 16);
            this.lblPubblicazioni.TabIndex = 3;
            this.lblPubblicazioni.Text = "PUBBLICAZIONI";
            // 
            // nudAnno
            // 
            this.nudAnno.Location = new System.Drawing.Point(20, 80);
            this.nudAnno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudAnno.Maximum = new decimal(new int[] {
            2025,
            0,
            0,
            0});
            this.nudAnno.Name = "nudAnno";
            this.nudAnno.Size = new System.Drawing.Size(160, 22);
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
            this.lblAnno.Location = new System.Drawing.Point(16, 60);
            this.lblAnno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAnno.Name = "lblAnno";
            this.lblAnno.Size = new System.Drawing.Size(46, 16);
            this.lblAnno.TabIndex = 6;
            this.lblAnno.Text = "ANNO";
            // 
            // btnQuery1
            // 
            this.btnQuery1.Location = new System.Drawing.Point(208, 76);
            this.btnQuery1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnQuery1.Name = "btnQuery1";
            this.btnQuery1.Size = new System.Drawing.Size(100, 28);
            this.btnQuery1.TabIndex = 3;
            this.btnQuery1.Text = "CERCA";
            this.btnQuery1.UseVisualStyleBackColor = true;
            this.btnQuery1.Click += new System.EventHandler(this.btnQuery1_Click);
            // 
            // dgvArticoliAnno
            // 
            this.dgvArticoliAnno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticoliAnno.Location = new System.Drawing.Point(20, 186);
            this.dgvArticoliAnno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvArticoliAnno.Name = "dgvArticoliAnno";
            this.dgvArticoliAnno.Size = new System.Drawing.Size(288, 353);
            this.dgvArticoliAnno.TabIndex = 8;
            // 
            // lblArticoliAnno
            // 
            this.lblArticoliAnno.AutoSize = true;
            this.lblArticoliAnno.Location = new System.Drawing.Point(20, 162);
            this.lblArticoliAnno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArticoliAnno.Name = "lblArticoliAnno";
            this.lblArticoliAnno.Size = new System.Drawing.Size(162, 16);
            this.lblArticoliAnno.TabIndex = 9;
            this.lblArticoliAnno.Text = "ARTICOLI DELL\'ANNO ??";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.lblArticoliAnno);
            this.Controls.Add(this.dgvArticoliAnno);
            this.Controls.Add(this.btnQuery1);
            this.Controls.Add(this.lblAnno);
            this.Controls.Add(this.nudAnno);
            this.Controls.Add(this.lblPubblicazioni);
            this.Controls.Add(this.cmbPubblicazione);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMenu";
            this.Text = "data";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudAnno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticoliAnno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbPubblicazione;
        private System.Windows.Forms.Label lblPubblicazioni;
        private System.Windows.Forms.NumericUpDown nudAnno;
        private System.Windows.Forms.Label lblAnno;
        private System.Windows.Forms.Button btnQuery1;
        private System.Windows.Forms.DataGridView dgvArticoliAnno;
        private System.Windows.Forms.Label lblArticoliAnno;
    }
}

