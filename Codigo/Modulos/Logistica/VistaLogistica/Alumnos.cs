using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VistaLogistica
{
    public partial class Alumnos : Form
    {

        Menu mn = new Menu();
        string table = "tbl_alumnos";
        public Alumnos()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void navegador1_Load(object sender, EventArgs e)
        {
            NavegadorVista.Navegador.idApp = "6002";
            TextBox[] Grupotextbox = { txtBuscar, txtLinea, textBox1, txtact};
            TextBox[] Idtextbox = { txtBuscar, txtLinea, textBox1, txtact};
            navegador1.textbox = Grupotextbox;
            navegador1.tabla = dtgLinea;
            navegador1.textboxi = Idtextbox;
            navegador1.actual = this;
            navegador1.cargar(dtgLinea, Grupotextbox, "prototipoef0901192375");
        }
    }
}
