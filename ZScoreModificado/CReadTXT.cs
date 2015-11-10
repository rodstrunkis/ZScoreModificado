using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ZScoreModificado
{
    public class CReadTXT
    {
        public string[] ArrayMedicoes(string path)
        {
                StreamReader sr = new StreamReader(path);
                string[] mArray = sr.ReadToEnd().Split('\r');
                return mArray; 
        }

        public List<double> ConverteArrayemLista(string[] m)
        {
            List<double> listademedicoes = new List<double>();
            foreach (var item in m)
            {
                listademedicoes.Add(Double.Parse(item));
            }
		 
            return listademedicoes;
        }
    }
}
