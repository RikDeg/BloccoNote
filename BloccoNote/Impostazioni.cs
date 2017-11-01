using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloccoNote
{
    public partial class Impostazioni : Form
    {
        public Impostazioni()
        {
            InitializeComponent();
        }

        //Metodo che apre il dialogbox per la scelta di cartella e imposta il valore.
        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                //MessageBox.Show(fbd.SelectedPath.ToString());
                Properties.Settings.Default.PercorsoNote = fbd.SelectedPath.ToString();
                txtPercorso.Text = fbd.SelectedPath.ToString();
            }
        }
    }
}
