using MemoriasDinamicas.BE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoriasDinamicas.FE
{
    public partial class MemoriaDinamicaForm : Form
    {
        public MemoriaDinamicaForm()
        {
            InitializeComponent();
            IngresarIndice.Hide();
        }

        Queue<string> ColaStrings = new Queue<string>();
        Stack<string> PilaStrings = new Stack<string>();
        List<string> ListaStrings = new List<string>();
        private void btIngresarEnCola_Click(object sender, EventArgs e)
        {

            if (tbxInput1.Text == "")
            {
                ColaMetodos.MostrarDatosEnCola(ColaStrings, ListaInputsCola);
            }
            else
            {
                ColaMetodos.Encolar(tbxInput1.Text, ColaStrings);
                tbxInput1.Clear();
                tbxInput1.Focus();

            }
        }

        private void btIngresarEnPila_Click(object sender, EventArgs e)
        {
            if (tbxInput2.Text == "")
            {
                PilaMetodos.MostrarDatosEnPila(PilaStrings, ListaInputsPila);
            }
            else
            {
                PilaMetodos.Apilar(tbxInput2.Text, PilaStrings);
                tbxInput2.Clear();
                tbxInput2.Focus();
            }
        }

        private void btIngresarEnArrayList_Click(object sender, EventArgs e)
        {
            if (tbxInput3.Text == "")
            {
                IngresarIndice.Show();
            }
            else
            {
                ArrayListMetodos.Agregar(tbxInput3.Text, ListaStrings);
                IngresarIndice.Hide();
                tbxInput3.Clear();
                tbxInput3.Focus();
            }
        }

        private void btIngresarIndice_Click(object sender, EventArgs e)
        {
            int num = int.Parse(tbxIndice.Text);
            if(num < 0 || num > ListaStrings.Count)
            {
                tbxIndice.Clear();
                MessageBox.Show("No hay elementos en esa posición");
            }
            else
            {
                tbxResultado.Text = ArrayListMetodos.MostrarDatoSolicitado(tbxIndice.Text, ListaStrings);
                
            }
        }
            
        private void tbxIndice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten números.");
            }
        }
    }
}
