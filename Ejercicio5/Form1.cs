using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Ejercicio5
{
    public partial class Form1 : Form
    {
        String titulo = "Ejercicio 5";
        int contadorTitulo, contadorTimer = 0;
        Icon icono1, icono2;

        public Form1()
        {
            InitializeComponent();

            Text = "";

            lblTamanho.Text = "Tamaño de la lista 1 : " + listBox1.Items.Count;
            lblIndices.Text = "";

            Directory.SetCurrentDirectory(Directory.GetCurrentDirectory() + "..\\..\\..\\Properties");
            contadorTitulo = titulo.Length - 1;

            icono1 = new Icon(Directory.GetCurrentDirectory() + "\\Listas.ico");
            icono2 = new Icon(Directory.GetCurrentDirectory() + "\\Listas2.ico");

            Icon = icono1;

            toolTip1.SetToolTip(txtAnhadir, "Caja de texto donde se escribe lo que se quiere añadir a la lista 1");
            toolTip1.SetToolTip(btnAnhadir, "Añade a la lista 1 lo que hay en la caja de texto");
            toolTip1.SetToolTip(btnQuitar, "Quita el/los elemento/s seleccionado/s de la lista correspondiente");
            toolTip1.SetToolTip(listBox1, "Lista donde se añaden los elementos escritos en la caja de texto");
            toolTip1.SetToolTip(listBox2, "Tamaño : " + listBox2.Items.Count);
            toolTip1.SetToolTip(btnTraspasarIzq, "Traspasa los elementos seleccionados de la lista 1 a la lista 2");
            toolTip1.SetToolTip(btnTraspasarDer, "Traspasa los elementos seleccionados de la lista 2 a la lista 1");
        }


        // Función que contiene las acciones a realizar cuando se pulsa el botón añadir
        private void btnAnhadir_Click(object sender, EventArgs e)
        {
            if (txtAnhadir.Text == "") // Indico el error si no se ha escrito nada en la caja de texto
            {
                MessageBox.Show("Debes escribir algo para añadir!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Si está bien, añado lo escrito a la ListBox y actualizo la etiqueta que muestra el tamaño de la ListBox1
                listBox1.Items.Add(txtAnhadir.Text);
                lblTamanho.Text = "Tamaño de la lista 1 : " + listBox1.Items.Count;
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
                else // Si hay seleccionado en la ListBox2...
                {
                    listBox2.Items.Remove(listBox2.SelectedItem); // Elimino el elemento seleccionado de la ListBox 2
                    toolTip1.SetToolTip(listBox2, "Tamaño : " + listBox2.Items.Count); // Actualizo el tooltip de la ListBox2
                }
            }
            else // Si la ListBox1 tiene elementos seleccionados...
            {
                seleccionados = listBox1.SelectedItems; // Establezco la variable seleccionados y la igualo a la colección de items seleccionados 

                for (int i = seleccionados.Count - 1; i >= 0; i--) // Recorro los items seleccionados
                {
                    listBox1.Items.Remove(seleccionados[i]); // Y los elimino de la ListBox correspondiente
                }

                lblTamanho.Text = "Tamaño de la lista 1 : " + listBox1.Items.Count; // Actualizo la etiqueta que muestra el tamaño de la ListBox1
            }
        }


        // Función que indica las acciones a realizar cuando se selecciona un elemento de un ListBox
        private void seleccionDeElementos(object sender, EventArgs e)
        {
            ListBox lista = (ListBox)sender; // Guardo en una variable el ListBox en el que se estén seleccionando los índices

            lblIndices.Text = "Índices seleccionados : ";

            for (int i = 0; i < lista.SelectedIndices.Count; i++)
            {
                if (i == lista.SelectedIndices.Count-1)
                {
                    lblIndices.Text += lista.SelectedIndices[i];
                }
                else
                {
                    lblIndices.Text += lista.SelectedIndices[i] + ", ";
                }
            }
        }


        // Función que gestiona el traspaso de elementos de una lista a otra
        private void traspasar(object sender, EventArgs e)
        {
            ListBox.SelectedObjectCollection seleccionados; // Creo una variable que recoge los items seleccionados de la listbox

            // Compruebo qué botón de los dos de traspasar ha sido pulsado
            if (sender == btnTraspasarIzq)
            {
                if (listBox1.SelectedItems.Count != 0) // Si hay algún elemento seleccionado en la ListBox1...
                {
                    seleccionados = listBox1.SelectedItems; // Guardo los elementos seleccionados de la lista en la variable

                    for (int i = seleccionados.Count - 1; i >= 0; i--) // Inserto los elementos seleccionados en la otra lista
                    {
                        listBox2.Items.Insert(0, seleccionados[i]);
                    }
                }
            }
            else
            {
                if (listBox2.SelectedItems.Count != 0) // Si hay algún elemento seleccionado en la ListBox2...
                {
                    listBox1.Items.Insert(0, listBox2.SelectedItem); // Inserto el elemento seleccionado de la lista 2 en la lista 1
                }
            }

            btnQuitar_Click(sender, e); // Llamo a la función de quitar los elementos seleccionados para ahorrarme código
            lblTamanho.Text = "Tamaño de la lista 1 : " + listBox1.Items.Count; // Actualizo la etiqueta que muestra el tamaño de la ListBox1
            toolTip1.SetToolTip(listBox2, "Tamaño : " + listBox2.Items.Count); // Actualizo el tooltip de la ListBox2
        }


        // Función que gestiona el tick del timer1
        private void timer1_Tick(object sender, EventArgs e)
        {
            contadorTimer++;

            if (contadorTitulo != -1)
            {
                Text = titulo[contadorTitulo] + Text;

                contadorTitulo --;
            }
            else // Cuando ya se ha mostrado todo el título, vuelve a mostrarse otra vez con scroll
            {
                Text = "";
                contadorTitulo = titulo.Length - 1;
            }


            if (contadorTimer % 2 == 0)
            {
                if (Icon == icono1)
                {
                    Icon = icono2;
                }
                else
                {
                    Icon = icono1;
                }
            }
        }
    }
}
