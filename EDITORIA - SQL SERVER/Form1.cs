using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDITORIA___SQL_SERVER
{
    public partial class frmMenu: Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }
        public string AnnoArticoli
        {
            set {
                lblArticoliAnno.Text = lblArticoliAnno.Text.Replace("??", value);
            }
        }
        public int Pubblicazione { get => (int)cmbPubblicazioni.SelectedValue; }
        private void btnQuery1_Click(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            try
            {
            //variables utili
                int anno= (int)nudAnno.Value;
            //query
                cmd = new SqlCommand();
                cmd.Connection = cn;//Connessione fatta nel foarm load
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM ARTICOLI WHERE annoPubblicazione=@anno AND codPUBBLICAZIONi=@pubblicazione";
               
                cmd.Parameters.AddWithValue("@anno", anno);
                cmd.Parameters.AddWithValue("@pubblicazione", Pubblicazione);
                //cmd.ExecuteNonQuery();

                adp = new SqlDataAdapter(cmd);
                adp.Fill(dt);

                dgvArticoliAnno.DataSource = null;
                dgvArticoliAnno.DataSource = dt;
                if (dt.Rows.Count == 0) MessageBox.Show("NESSUN DATO SODDISFA L'ISTRUZIONE SCRITTA");
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
        }

        SqlConnection cn;   //gestisce la comunicazione fisica con il db
        SqlCommand cmd;     //per impostare il comando (istruzione sql)
        SqlDataAdapter adp;     //per raccogliere i dati. Restituisce una tabella Virtuale

        private void frmMenu_Load(object sender, EventArgs e)
        {
            //COLLEGAMENTO DATABASE
            string dbName = "EDITORIA.MDF";
            string cnString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" +
                                Application.StartupPath + "\\" + dbName +
                                ";Integrated Security=True;Connect Timeout=30";
            try
            {
                //cn = new SqlConnection();
                //cn.ConnectionString=cnString;
                //OPPURE
                cn = new SqlConnection(cnString);
                cn.Open();
                MessageBox.Show("Connessione con il database " + dbName + " è riuscita");
                //carica i CONTROLLI
                popolaCmbPubblicazioni();
                popolaCmbAbbonati();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void popolaCmbAbbonati()
        {
            DataTable dt = new DataTable();
            try
            {
                cmd = new SqlCommand();
                cmd.Connection = cn;//Connessione fatta nel foarm loaf
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "SELECT cognome,nome,cognome+' '+nome as 'nominativo',codAbbonato FROM ABBONATI ORDER BY COGNOME,NOME";
                adp = new SqlDataAdapter(cmd);
                adp.Fill(dt);

                cmbAbbonati.DataSource = null;
                cmbAbbonati.DataSource = dt;
                cmbAbbonati.DisplayMember = "nominativo";
                cmbAbbonati.ValueMember = "codAbbonato";    //PK per quando inseriremo il voto
                if (dt.Rows.Count == 0) MessageBox.Show("NESSUN DATO SODDISFA L'ISTRUZIONE SCRITTA");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void popolaCmbPubblicazioni()
        {
            DataTable dt = new DataTable();
            try
            {
                cmd = new SqlCommand();
                cmd.Connection = cn;//Connessione fatta nel foarm loaf
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "SELECT * FROM PUBBLICAZIONI ORDER BY TITOLO";
                adp = new SqlDataAdapter(cmd);
                adp.Fill(dt);

                cmbPubblicazioni.DataSource = null;
                cmbPubblicazioni.DataSource = dt;
                cmbPubblicazioni.DisplayMember = "TITOLO";
                cmbPubblicazioni.ValueMember = "codPubblicazioni";    //PK per quando inseriremo il voto
                if (dt.Rows.Count == 0) MessageBox.Show("NESSUN DATO SODDISFA L'ISTRUZIONE SCRITTA");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAbbonamentiAnnuali_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dataTable = new DataTable();

                cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType= CommandType.Text;

                cmd.CommandText = "SELECT * FROM ABBONAMENTI WHERE TIPOABBONAMENTO='ANNUALE'";
                adp = new SqlDataAdapter(cmd);
                adp.Fill(dataTable);
                dgvAbbonamentiAnnuali.DataSource = dataTable;
                if (dataTable.Rows.Count == 0) MessageBox.Show("NESSUN DATO SODDISFA L'ISTRUZIONE SCRITTA");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public int Abbonato { get => (int)cmbAbbonati.SelectedValue; }
        private void btnNumeroPubblicazioni_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType=CommandType.Text;
                cmd.CommandText = "SELECT COUNT(*) FROM ABBONAMENTI WHERE CODABBONATO=@abbonato";
                cmd.Parameters.AddWithValue("@abbonato", Abbonato);

                MessageBox.Show($"L'abbonato [{cmbAbbonati.Text}] segue [{cmd.ExecuteScalar()}] riviste");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRimanentiQuery_Click(object sender, EventArgs e)
        {
            try
            {

                MessageBox.Show($"L'abbonato [{cmbAbbonati.Text}] segue [{cmd.ExecuteScalar()}] riviste");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
