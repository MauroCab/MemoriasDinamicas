using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoriasDinamicas.BE
{
     public class ColaMetodos
    {
        public static void Encolar(string input, Queue<string> cola)
        {
            cola.Enqueue(input);
        }

        public static void MostrarDatosEnCola(Queue<string> cola, ListView lista)
        {
            while (cola.Count > 0)
            {
                lista.Items.Add(cola.Dequeue());
            }
        }
    }
}
