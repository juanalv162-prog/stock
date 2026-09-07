using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace stock_bebidas
{
    public partial class Form1 : Form
    {
        // Lista para guardar las bebidas
        List<string> bebidas = new List<string>();

        public Form1()
        {
            InitializeComponent();

            // Conectar el botón AGREGAR con el código
            btnAgregar.Click += btnAgregar_Click;
        }

        // BOTÓN AGREGAR BEBIDAS
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtbebidas.Text;
            int cantidad = (int)numericUpDown1.Value;

            // Comprobar que se haya escrito el nombre
            if (nombre == "")
            {
                MessageBox.Show("Ingrese el nombre de la bebida.");
                return;
            }

            // Comprobar el stock
            if (cantidad < 3)
            {
                bebidas.Add(nombre + " - " + cantidad +
                    " unidades - STOCK BAJO");
            }
            else
            {
                bebidas.Add(nombre + " - " + cantidad +
                    " unidades - STOCK SUFICIENTE");
            }

            MessageBox.Show("Bebida agregada correctamente.");

            // Limpiar los campos
            txtbebidas.Clear();
            numericUpDown1.Value = 0;
        }

        // BOTÓN MOSTRAR STOCK
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            IstStock.Items.Clear();

            // Recorrer todas las bebidas
            for (int i = 0; i < bebidas.Count; i++)
            {
                IstStock.Items.Add(bebidas[i]);
            }
        }

        // CARGA DEL FORMULARIO
        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}