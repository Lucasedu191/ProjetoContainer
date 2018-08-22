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
    public partial class frmSplitcontainer : Form
    {
        public frmSplitcontainer()
        {
            InitializeComponent();
        }

        private void frmSplitcontainer_Load(object sender, EventArgs e)
        {
            lsbImagens.Items.Add("lobo1");
            lsbImagens.Items.Add("lobo2");
            lsbImagens.Items.Add("lobo3");
            lsbImagens.Items.Add("lobo4");
        }

        private void lsbImagens_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsbImagens.SelectedIndices.Count < 1) return;
            if (lsbImagens.SelectedIndex == 0)
            {
                lblInformacao.Text = "Informação relacionada ao primeiro lobo";
                pnlImagem.BackgroundImage = Properties.Resources.lobo1;
            }
            else if (lsbImagens.SelectedIndex == 1)
            {
                lblInformacao.Text = "Informação relacionada ao segundo lobo";
                pnlImagem.BackgroundImage = Properties.Resources.lobo2;
            }
            else if (lsbImagens.SelectedIndex == 2)
            {
                lblInformacao.Text = "Informação relacionada ao terceiro lobo";
                pnlImagem.BackgroundImage = Properties.Resources.lobo3;
            }
            else if (lsbImagens.SelectedIndex == 3)
            {
                lblInformacao.Text = "Informação relacionada ao quarto lobo";
                pnlImagem.BackgroundImage = Properties.Resources.lobo4;
            }
        }
    }
}
