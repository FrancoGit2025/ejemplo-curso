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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void perfilPersonaMenu_Click(object sender, EventArgs e)
        {

            foreach (Form item in Application.OpenForms)
            {
                if (item.GetType() == typeof(Form1))
                {
                    MessageBox.Show("ya existe esta ventana bierta, termine de trabajar alli");
                    return;
                }
            }


            Form1 ventana = new Form1();
            ventana.MdiParent = this;
            //ventana.ShowDialog();
            ventana.Show();
        }

        private void toolStripButtonPerfil_Click(object sender, EventArgs e)
        {
            Form1 ventana = new Form1();
            ventana.Show();
        }
    }
}
