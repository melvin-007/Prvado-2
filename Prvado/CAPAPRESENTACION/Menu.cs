using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prvado.CAPAPRESENTACION
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
       //SqlConnection con = new SqlConnection("Data Source=DESKTOP-DEIS0VR\\SQLEXPRESS;Initial Catalog=Nomina;Integrated Security=True");

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void crearEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Empleados empleados = new Empleados();
            empleados.Show();
        }

        private void crearNominaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Nominas nominas = new Nominas();
            nominas.Show();
        }

        private void mantenimientoDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
       
        }

        private void mantenimientoDeAresasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Areas areas = new Areas();
            areas.Show();
        }

        private void nominasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ConsultarNominas nomina = new ConsultarNominas();
            nomina.Show();
        }

        private void empleadosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ConsultarEmpleados empleados = new ConsultarEmpleados();
            empleados.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ConsultarAreas areas = new ConsultarAreas();
            areas.Show();
        }
    }
}
