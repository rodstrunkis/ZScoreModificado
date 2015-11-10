using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using OxyPlot;
using OxyPlot.WindowsForms;
using OxyPlot.Axes;
using OxyPlot.Series;
using OxyPlot.Annotations;

namespace ZScoreModificado
{
    public partial class ZScoreMod : Form
    {
        CReadTXT readTXT = new CReadTXT();
        CZScoreMod zscore = new CZScoreMod();
        PlotModel myModel;
        string[] marraystring;
        List<double> mlista;
        List<DataPoint> listaOutlier;

        public ZScoreMod()
        {
            InitializeComponent();

            myModel = new PlotModel();
            cplotView.Model = myModel;
            configModel();

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            oFDPesquisar.ShowDialog();
            txtPesquisar.Text = oFDPesquisar.FileName;
            marraystring = readTXT.ArrayMedicoes(oFDPesquisar.FileName);
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {

            if (marraystring != null && txtLimiar.Text != "")
            {
                myModel.Annotations.Clear(); //Limpa os pontos no gráfico que marcam a medição como outlier
                dataGridViewOutlier.Rows.Clear(); //Limpas os dados do datagridview antes de escrever

                mlista = readTXT.ConverteArrayemLista(marraystring);
                myModel.Series.Add(AddCurva(mlista));
                myModel.InvalidatePlot(true);
                lblQntDiasValor.Visible = true;
                lblQntDiasValor.Text = Convert.ToString(mlista.Count/96);
                lblValorQntMedicoes.Visible = true;
                lblValorQntMedicoes.Text = Convert.ToString(mlista.Count);
                lblQntOutlierValor.Visible = true;
                listaOutlier = zscore.ZScoreMod(mlista, Convert.ToDouble(txtLimiar.Text));
                lblQntOutlierValor.Text = Convert.ToString(listaOutlier.Count);

                
                foreach (var item in listaOutlier)
                {
                    PointAnnotation p1 = new PointAnnotation();
                    p1.X = item.X;
                    p1.Y = item.Y;
                    p1.Fill = OxyColors.Red;
                    myModel.Annotations.Add(p1);

                    dataGridViewOutlier.Rows.Add(item.X, item.Y);
                }
            }
            else
            {
                MessageBox.Show("Arquivo vazio ou valor do limiar em branco. Selecione um arquivo válido ou verifique o valor do limiar!");
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        #region OXYPLOT


        private Series AddCurva (List<double> dados)
        {
            List<DataPoint> dadosPlot = new List<DataPoint>();
            int cont = 1;
            foreach (var item in dados)
            {
                dadosPlot.Add(new DataPoint(cont, item));
                cont++;
            }

            myModel.Series.Clear();
            LineSeries s1 = new LineSeries();
            s1.Points.AddRange(dadosPlot);
            s1.Title = "Medições";
            s1.Color = OxyColors.Black;

            return s1;
        }

        /// <summary>
        /// Configuração do modelo do Oxyplot.
        /// </summary>
        private void configModel(string titulo = "Curva Medições", string subtitulo = "ZScoreMod")
        {
            myModel.Title = titulo;
            myModel.TitleColor = OxyColors.Blue;
            myModel.Subtitle = subtitulo;
            myModel.PlotType = PlotType.XY;
            myModel.Background = OxyColor.FromRgb(255, 255, 255);
            myModel.TextColor = OxyColor.FromRgb(0, 0, 0);
            myModel.IsLegendVisible = true;
            myModel.LegendBorder = OxyColors.Black;
            myModel.LegendPlacement = LegendPlacement.Outside;
            myModel.LegendPosition = LegendPosition.BottomLeft;
            myModel.LegendOrientation = LegendOrientation.Horizontal;
            myModel.Padding = new OxyThickness(8, 8, 15, 8);

            plotEixoLinearY("MW");

        }

        /// <summary>
        /// Plota um eixo de Data e hora.
        /// </summary>
        /// <param name="titulo"> Título do eixo considerado. </param>
        private void plotEixoData(string titulo = "Data e Hora")
        {
            //Criando um eixo de Data.
            DateTimeAxis eixoData = new DateTimeAxis();
            eixoData.MajorGridlineStyle = LineStyle.Solid;
            eixoData.MinorGridlineStyle = LineStyle.Dot;
            eixoData.MinimumPadding = 0.1;
            eixoData.MaximumPadding = 0.1;
            eixoData.FirstDayOfWeek = System.DayOfWeek.Sunday;
            eixoData.Title = titulo;
            myModel.Axes.Add(eixoData);
        }

        /// <summary>
        /// Plota um eixo linear
        /// </summary>
        /// <param name="titulo"> Título do eixo considerado. </param>
        private void plotEixoLinearX(string titulo = "Medições")
        {
            LinearAxis eixoLinear = new LinearAxis();
            eixoLinear.MajorGridlineStyle = LineStyle.Solid;
            eixoLinear.MinorGridlineStyle = LineStyle.Dot;
            eixoLinear.MaximumPadding = 0.1;
            eixoLinear.MinimumPadding = 0.1;
            eixoLinear.Title = titulo;
            myModel.Axes.Add(eixoLinear);
        }

        /// <summary>
        /// Plota um eixo linear
        /// </summary>
        /// <param name="titulo"> Título do eixo considerado. </param>
        private void plotEixoLinearY(string titulo = "")
        {
            LinearAxis eixoLinear = new LinearAxis();
            eixoLinear.MajorGridlineStyle = LineStyle.Solid;
            eixoLinear.MinorGridlineStyle = LineStyle.Dot;
            eixoLinear.MaximumPadding = 0.1;
            eixoLinear.MinimumPadding = 0.1;
            eixoLinear.Title = titulo;
            myModel.Axes.Add(eixoLinear);
        }
        
        #endregion
    }
}
