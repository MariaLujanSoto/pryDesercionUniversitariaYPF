using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySotoPOO
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            ClassPersonaje objeto = new ClassPersonaje();

            objeto.Nombre = txtNombre.Text;
            objeto.Fuerza = Convert.ToInt32(txtFuerza.Text);
            objeto.Destreza = int.Parse(txtDestreza.Text);

            //.Net convert / otros int.Parse

            lblInfo.Text = objeto.Nombre + "\n"+
                objeto.Fuerza + "\n" +
                objeto.Destreza;

        }
    }
}
