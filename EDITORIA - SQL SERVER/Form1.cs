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
        private void btnQuery1_Click(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            try
            {
            //variables utili
                int anno= (int)nudAnno.Value;
                int pubblicazione = (int)cmbPubblicazione.SelectedValue;
            //query
                cmd = new SqlCommand();
                cmd.Connection = cn;//Connessione fatta nel foarm load
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM ARTICOLI WHERE annoPubblicazione=@anno AND codPUBBLICAZIONi=@pubblicazione";
               
                cmd.Parameters.AddWithValue("@anno", anno);
                cmd.Parameters.AddWithValue("@pubblicazione", pubblicazione);
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

                cmbPubblicazione.DataSource = null;
                cmbPubblicazione.DataSource = dt;
                cmbPubblicazione.DisplayMember = "TITOLO";
                cmbPubblicazione.ValueMember = "codPubblicazioni";    //PK per quando inseriremo il voto
                if (dt.Rows.Count == 0) MessageBox.Show("NESSUN DATO SODDISFA L'ISTRUZIONE SCRITTA");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
