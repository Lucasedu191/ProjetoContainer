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
    public partial class frmPrincipal2 : Form
    {
        public frmPrincipal2()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void flowLayoutPanelToolStripMenuItem_Click(object sender, EventArgs e)
        {
             
        }

        private void groupBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGroupBox form = new FrmGroupBox();
            form.MdiParent = this;
            form.StartPosition = FormStartPosition.Manual;
            form.Location = new Point(0, 0);
            form.Show();
        }

        private void panelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPanel form = new FrmPanel();
            form.MdiParent = this;
            form.StartPosition = FormStartPosition.Manual;
            form.Location = new Point(0, 0);
            form.Show();

        }

        private void splitContainerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSplitcontainer form = new frmSplitcontainer();
            form.MdiParent = this;
            form.StartPosition = FormStartPosition.Manual;
            form.Location = new Point(0, 0);
            form.Show();
        }

        private void tabControlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTabControl form = new frmTabControl();
            form.MdiParent = this;
            form.StartPosition = FormStartPosition.Manual;
            form.Location = new Point(0, 0);
            form.Show();

        }

        private void tableLayoutControlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTableLayoutPanel form = new frmTableLayoutPanel();
            form.MdiParent = this;
            form.StartPosition = FormStartPosition.Manual;
            form.Location = new Point(0, 0);
            form.Show();
        }
        //criando um metodo para chamar o form quando for clicado no menu strip
        private void AbrirFormulario(Form form)
        {
            form.MdiParent = this;
            form.StartPosition = FormStartPosition.Manual;
            form.Location = new Point(0, 0);
            form.Show(); 
        }
    }
}
