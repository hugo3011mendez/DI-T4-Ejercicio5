﻿using System;
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


        // Función que contiene las acciones a realizar cuando se pulsa el botón añadir
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


        // Función que contiene las acciones a realizar cuando se pulsa el botón quitar
        private void btnQuitar_Click(object sender, EventArgs e)
        {
            ListBox.SelectedObjectCollection seleccionados; // Creo una variable que recoge los items seleccionados de la listbox

            if (listBox1.SelectedItems.Count == 0) // Si la ListBox1 no tiene seleccionados...
            {
                if (listBox2.SelectedItems.Count == 0) // Si no hay seleccionados en ninguna ListBox...
                {
                    MessageBox.Show("No hay ningún elemento seleccionado!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); // Muestro mensaje de error
                }
                else // Si hay seleccionados en la ListBox2...
                {
                    seleccionados = listBox2.SelectedItems; // Establezco la variable seleccionados y la igualo a la colección de items seleccionados

                    for (int i = 0; i < seleccionados.Count; i++) // Recorro los items seleccionados
                    {
                        listBox2.Items.Remove(seleccionados[i]); // Y los elimino de la ListBox correspondiente
                    }
                }
            }
            else // Si la ListBox1 tiene elementos seleccionados...
            {
                seleccionados = listBox1.SelectedItems; // Establezco la variable seleccionados y la igualo a la colección de items seleccionados 

                for (int i = 0; i < seleccionados.Count; i++) // Recorro los items seleccionados
                {
                    listBox1.Items.Remove(seleccionados[i]); // Y los elimino de la ListBox correspondiente
                }
            }
        }
    }
}
