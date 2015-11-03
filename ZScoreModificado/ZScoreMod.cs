using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZScoreModificado
{
    public partial class ZScoreMod : Form
    {
        CReadTXT readTXT = new CReadTXT();
        CZScoreMod zscore = new CZScoreMod();
        string[] marraystring;
        double[] marraydouble;
        List<double> mlista;

        public ZScoreMod()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            oFDPesquisar.ShowDialog();
            txtPesquisar.Text = oFDPesquisar.FileName;
            marraystring = readTXT.ArrayMedicoes(oFDPesquisar.FileName);
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            mlista = readTXT.ConverteArrayemLista(marraystring);
            lblMADValor.Visible = true;
            lblMADValor.Text = Convert.ToString(zscore.MAD(mlista));
            lblMediaAmostralValor.Visible = true;
            lblMediaAmostralValor.Text = Convert.ToString(zscore.MediaAmostral(mlista));
            lblQntOutlierValor.Visible = true;
            lblQntOutlierValor.Text = Convert.ToString(zscore.ZScoreMod(mlista));
        }
    }
}
