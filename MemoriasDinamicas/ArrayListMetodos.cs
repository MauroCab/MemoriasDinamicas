using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoriasDinamicas
{
    public class ArrayListMetodos
    {
        public static void Agregar(string input, List<string> listaArray)
        {
            listaArray.Add(input);
        }

        public static string MostrarDatoSolicitado(string index, List<string> listaArray)
        {
            int i = int.Parse(index);
            return listaArray[i];
        }
    }
}
