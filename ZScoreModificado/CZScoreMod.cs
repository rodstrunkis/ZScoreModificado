using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OxyPlot;

namespace ZScoreModificado
{
    class CZScoreMod
    {
        public double MAD(List<double> listadePM)
        {
            List<double> listaAux = new List<double>();

            for (int i = 0; i < listadePM.Count; i++)
            {
                listaAux.Add(listadePM[i]);
            }

            listaAux.Sort();

            double tamanhodaLista = 0.0;
            double posdaMedian = 0.0;
            double median = 0.0;
            double newMedian = 0.0;

            tamanhodaLista = listaAux.Count;
            posdaMedian = (tamanhodaLista / 2);

            if (tamanhodaLista % 2 == 0)
            {
                median = (listaAux[Convert.ToInt16(posdaMedian - 1)] + listaAux[Convert.ToInt16(posdaMedian)]) / 2;

                for (int i = 0; i < listaAux.Count; i++)
                {
                    double aux = 0.0;

                    aux = Math.Abs(listaAux[i] - median);
                    listaAux[i] = aux;
                }
                listaAux.Sort();

                newMedian = (listaAux[Convert.ToInt16(posdaMedian - 1)] + listaAux[Convert.ToInt16(posdaMedian)]) / 2;
            }
            else
            {
                median = listaAux[(int)posdaMedian];

                for (int i = 0; i < listaAux.Count; i++)
                {
                    double aux = 0.0;

                    aux = Math.Abs(listaAux[i] - median);
                    listaAux[i] = aux;
                }
                listaAux.Sort();

                newMedian = (listaAux[Convert.ToInt16(posdaMedian)]);
            }

            listaAux.Clear();
            return newMedian;
        }

        public double MediaAmostral(List<double> listadeMedicoes)
        {
            double mediaAmostral = 0.0;
            double aux = 0.0;

            for (int i = 0; i < listadeMedicoes.Count; i++)
            {
                aux = aux + listadeMedicoes[i];
            }

            mediaAmostral = (aux / listadeMedicoes.Count);

            return mediaAmostral;
        }

        public List<DataPoint> ZScoreMod(List<double> lista, double limiar)
        {
            List<DataPoint> ListaOutlierComPos = new List<DataPoint>();
            int qntOutlier = 0;
            double mi = 0.0;
            double mad = MAD(lista);
            double mediaAmostral = MediaAmostral(lista);

            for (int i = 0; i < lista.Count; i++)
            {
                mi = Math.Abs((0.6745 / mad) * (lista[i] - mediaAmostral));
                if (mi > limiar)
                {
                    qntOutlier = qntOutlier + 1;
                    ListaOutlierComPos.Add(new DataPoint(i + 1, lista[i]));
                }
            }
            return (ListaOutlierComPos);
        }
    }
}
