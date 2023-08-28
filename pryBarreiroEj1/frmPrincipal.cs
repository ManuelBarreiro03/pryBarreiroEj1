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


namespace pryBarreiroEj1
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void cmdCrearCarpeta_Click(object sender, EventArgs e)
        {

            try
            {
                StreamWriter swCrearArchivo = new StreamWriter("miArchivito", false);
                MessageBox.Show("archivo creado");
            }
            catch (Exception)
            {
                MessageBox.Show("archico ya creado");
            }

        }

        private void cmdGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter swManejoArchivo = new StreamWriter("miArchivito", true);
                swManejoArchivo.WriteLine(txtDatos.Text);
                swManejoArchivo.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("fatal error" + ex.Message);
            }
        }

        private void cmdLeerArchico_Click(object sender, EventArgs e)
        {
            StreamReader srManejoArchivo = new StreamReader("miArchivito");

            while (srManejoArchivo.EndOfStream==false)
            {
                txtDatos.Text += srManejoArchivo.ReadLine() + Environment.NewLine;
            }
            srManejoArchivo.Close();
        }
    }
}
