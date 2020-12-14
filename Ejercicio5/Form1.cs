using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            lblTamanho.Text = "Tamaño de la lista 1 : " + listBox1.Items.Count;
            lblIndices.Text = "";
        }

        private void btnAnhadir_Click(object sender, EventArgs e)
        {
            if (txtAnhadir.Text == "")
            {
                MessageBox.Show("Debes escribir algo para añadir!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                listBox1.Items.Add(txtAnhadir.Text);
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            ListBox.SelectedObjectCollection seleccionados;

            if (listBox1.SelectedItems.Count == 0)
            {
                if (listBox2.SelectedItems.Count == 0)
                {
                    MessageBox.Show("No hay ningún elemento seleccionado!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    seleccionados = listBox2.SelectedItems;

                    for (int i = 0; i < seleccionados.Count; i++)
                    {
                        listBox2.Items.Remove(seleccionados[i]);
                    }
                }
            }
            else
            {
                seleccionados = listBox1.SelectedItems;

                for (int i = 0; i < seleccionados.Count; i++)
                {
                    listBox1.Items.Remove(seleccionados[i]);
                }
            }
        }
    }
}
