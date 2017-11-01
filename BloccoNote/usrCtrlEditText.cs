using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloccoNote
{
    public partial class usrCtrlEditText : UserControl
    {
        internal EventHandler ButtonClick;

        public usrCtrlEditText()
        {
            InitializeComponent();
        }

        public usrCtrlEditText(String path)
        {
            InitializeComponent();
            richTextBox1.LoadFile(path);
        }

        public void salva(String nome)
        {
            richTextBox1.SaveFile(Properties.Settings.Default.PercorsoNote + "\\" + nome + ".rtf");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
