using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaVotiScolastici
{
    public partial class LetturaFile : Form
    {
        public LetturaFile()
        {
            InitializeComponent();
        }

        private void LetturaFile_Load(object sender, EventArgs e)
        {
            if (File.Exists("C:\\Users\\steta\\source\\repos\\MediaVotiScolastici\\MediaVotiScolastici\\MediaVoti.txt"))
            {
                // Creazione di un DataGridView per visualizzare i dati del file
                DataGridView dataGrid = new DataGridView();
                dataGrid.Size = new Size(800, 400);
                dataGrid.Location = new Point(10, 10);
                dataGrid.RowHeadersVisible = false;
                dataGrid.SelectionMode = 0 ;
                dataGrid.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
                dataGrid.DefaultCellStyle.SelectionForeColor = Color.Black;
                dataGrid.ColumnCount = 6 ;
                dataGrid.Columns[0].Name = "Materia";
                dataGrid.Columns[0].Width = 100;
                dataGrid.Columns[1].Name = "Nome e Cognome Alunno";
                dataGrid.Columns[1].Width = 150;
                dataGrid.Columns[2].Name = "Voto Scritto";
                dataGrid.Columns[2].Width = 100;
                dataGrid.Columns[3].Name = "Voto Orale";
                dataGrid.Columns[3].Width = 100;
                dataGrid.Columns[4].Name = "Voto Pratica";
                dataGrid.Columns[4].Width = 100;
                dataGrid.Columns[5].Name = "Media Voti";
                dataGrid.Columns[5].Width = 150;
                dataGrid.Visible = true;
                this.Controls.Add(dataGrid);
                // Lettura del file "voti.txt" e popolamento del DataGridView
                StreamReader lettura = new StreamReader("C:\\Users\\steta\\source\\repos\\MediaVotiScolastici\\MediaVotiScolastici\\MediaVoti.txt");
                string linea;
                int i = 0;
                // Ciclo per leggere ogni riga del file e aggiungerla al DataGridView
                while ((linea = lettura.ReadLine()) != null)
                {
                    i++;
                    string[] campi = linea.Split(';');
                    dataGrid.Rows.Add(campi);
                }
                lettura.Close();
            }
            else
            {
                MessageBox.Show("Non sono stati inseriti nessun voto, quindi non è possibile visualizzare i dati", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
        }
    }
}
