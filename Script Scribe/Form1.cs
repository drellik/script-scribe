using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Script_Scribe
{
    public partial class Form1 : Form
    {
        private enum Flow { plot, character, speaking};
        Flow currentFlow = Flow.plot;
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void richTextBox1_PreviewKeyDown_1(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData == Keys.Tab && currentFlow == Flow.plot)
            {
                richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
                currentFlow = Flow.character;
            }
            else if (e.KeyData == Keys.Tab && currentFlow == Flow.character)
            {
                richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
                currentFlow = Flow.plot;
            }
        }
    }
}
