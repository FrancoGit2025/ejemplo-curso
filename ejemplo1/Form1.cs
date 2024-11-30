using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemplo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string elemento = txtNombre.Text;
            listViewElementos.Items.Add(elemento);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboColorFavorito.Items.Add("rojo");
            cboColorFavorito.Items.Add("verde");
            cboColorFavorito.Items.Add("negro");
        }

        private void btnVerPerfil_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            DateTime fecha = dtpFechaNacimiento.Value;
            string chocolate = ckbChocolate.Checked ? "le gusta el chocolate" : "odia el chocolate";
            string tipo;
            if (rdbWizard.Checked)
                tipo = "wizard";
            else if (rdbMuggle.Checked)
                tipo = "muggle";
            else
                tipo = "skibs";

            string colorFav = cboColorFavorito.SelectedItem.ToString();
            string numFav = numFavorito.Value.ToString();

            MessageBox.Show("nombre: " + nombre + ", fecha: " + fecha + ", " + chocolate + ", tipo: " + tipo + ", color fav: " + colorFav + ", numero favorito: " + numFav);


        }
    }
}
