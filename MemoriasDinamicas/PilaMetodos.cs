using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoriasDinamicas
{
    public class PilaMetodos
    {
        public static void Apilar(string input, Stack<string> pila)
        {
            pila.Push(input);
        }

        public static void MostrarDatosEnPila(Stack<string> pila, ListView lista)
        {
            Stack<string> StackInverso = new Stack<string>();

            while (pila.Count > 0)
            {
                StackInverso.Push(pila.Pop());
            }

            while (StackInverso.Count > 0)
            {
                lista.Items.Add(StackInverso.Pop());
            }

        }
    }
}
