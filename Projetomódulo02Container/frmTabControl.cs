using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projetomódulo02Container
{
    public partial class frmTabControl : Form
    {
        public frmTabControl()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                tabControl1.Controls.Add(tabPageTeste3);
            }
            else
            {
                tabControl1.Controls.Remove(tabPageTeste3);
            }
        }

        private void frmTabControl_Load(object sender, EventArgs e)
        {
            tabControl1.Controls.Remove(tabPageTeste3);
        }
    }
}
