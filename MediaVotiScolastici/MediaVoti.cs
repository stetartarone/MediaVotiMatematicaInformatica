using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MediaVotiScolastici
{
    public partial class MediaVoti : Form
    {
        public MediaVoti()
        {
            InitializeComponent();
        }
        // Variabile globale per la classe
        public string classe = "La magnifica classe del Mateucci Centrale";

        // Metodo per calcolare la media dei voti
        private void btnMediaInformatica_Click(object sender, EventArgs e)
        {
            if (txtNomeCognomeAlunni.Text == "")
            {
                MessageBox.Show("Inserire nome e cognome dell'alunno o alunna", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           
            // Conversione dei voti da stringa a double
            double votoScritto = Convert.ToDouble(txtScInfo.Text);
            double votoOrale = Convert.ToDouble(txtOraleInfo.Text);
            double votoPratica = Convert.ToDouble(txtLabInfo.Text);
            double mediaVotiInformatica = (votoScritto + votoOrale + votoPratica) / 3;
            txtMediaInfo.Text = Convert.ToString(Math.Round(mediaVotiInformatica, 2));
            txtMediaInfo.Text = mediaVotiInformatica.ToString();
        }
        //Scegli la classe che fa parte l'allunno

        //Reset valori delle textbox
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtNomeCognomeAlunni.Clear();
            txtScInfo.Clear();
            txtScrittoMate.Clear();
            txtOraleInfo.Clear();
            txtOraleMate.Clear();
            txtLabInfo.Clear();
            txtMediaInfo.Text = "";
            txtMediaMatematica.Text = "";
            txtNomeCognomeAlunni.Focus();
            gboxClasse.Enabled = true;
        }
        //Salva i dati in un file di testo
        private void btnSalva_Click(object sender, EventArgs e)
        {
            if (txtMediaInfo.Text == "" && txtMediaMatematica.Text == "")
            {
                string message = "Inserisci i voti di entrambe le materie prima di salvare i dati.";
                MessageBox.Show(message, "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            StreamWriter sw = new StreamWriter("C:\\Users\\steta\\source\\repos\\MediaVotiScolastici\\MediaVotiScolastici\\MediaVoti.txt", true);
            string rigaInformatica = cboxInformatica.SelectedItem.ToString() + ";" + txtNomeCognomeAlunni.Text + ";" + txtScInfo.Text + ";" + txtOraleInfo.Text + ";" + txtLabInfo.Text + ";" + txtMediaInfo.Text;
            sw.WriteLine(rigaInformatica);
            string rigaMatematica = cboxMatematica.SelectedItem.ToString() + ";" + txtNomeCognomeAlunni.Text + ";" + txtScrittoMate.Text + ";" + txtOraleMate.Text + ";" + txtlabMate.Text + ";" + txtMediaMatematica.Text;
            sw.WriteLine(rigaMatematica);
            sw.Close();
            MessageBox.Show("Dati salvati correttamente in MediaVoti.txt", "Salvataggio completato", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        // Legge i dati dal file di testo
        private void btnLeggi_Click(object sender, EventArgs e)
        {
            LetturaFile lettura = new LetturaFile();
            lettura.Show();
        }
        // Chiude l'applicazione
        private void btnEsci_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // Metodo per gestire il cambiamento della classe selezionata
        private void rdbIC_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radio = (RadioButton)sender;
            classe = radio.Text;
        }
        // Metodo per gestire il cambiamento della classe selezionata
        private void rdbIIC_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radio = (RadioButton)sender;
            classe = radio.Text;
        }
        // Metodo per gestire il cambiamento della classe selezionata
        private void rdbIIIC_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radio = (RadioButton)sender;
            classe = radio.Text;
        }
        // Metodo per gestire il cambiamento della classe selezionata
        private void rdbIVC_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radio = (RadioButton)sender;
            classe = radio.Text;
        }
        // Metodo per gestire il cambiamento della classe selezionata
        private void rdbVC_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radio = (RadioButton)sender;
            classe = radio.Text;
        }
        // Disabilita il gruppo di radio button per la selezione della classe
        private void txtScInfo_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (e.KeyChar == 8)
            {
                return; // Permette il backspace
            }
            if(char.IsDigit(e.KeyChar))
            {
                string temp = textBox.Text + e.KeyChar.ToString();
                if(Convert.ToInt16(temp) > 10)
                {
                    MessageBox.Show("Il voto massimo è 10", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.KeyChar = (char)0; // Impedisce l'inserimento del carattere
                }
            }
            e.KeyChar = (char)0; // Impedisce l'inserimento del carattere
        }

        // Metodo per calcolare la media dei voti di matematica
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNomeCognomeAlunni.Text == "")
            {
                MessageBox.Show("Inserire tutti i voti", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Conversione dei voti da stringa a double
            double votoScrittoMate = Convert.ToDouble(txtScrittoMate.Text);
            double votoOraleMate = Convert.ToDouble(txtOraleMate.Text);
            double votoLabMate = Convert.ToDouble(txtlabMate.Text);
            double mediaVotiMatematica = (votoScrittoMate + votoOraleMate + votoLabMate) / 3;
            txtMediaMatematica.Text = mediaVotiMatematica.ToString();
        }
    }
}
