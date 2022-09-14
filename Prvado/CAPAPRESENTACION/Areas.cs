using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using Prvado.CAPADATOS;
namespace Prvado.CAPAPRESENTACION
{
    public partial class Areas : Form
    {
        public Areas()
        {
            InitializeComponent();
        }
        ClsAreas objproducto = new ClsAreas();
        string Operacion = "Insertar";
        string idar;

        private void Areas_Load(object sender, EventArgs e)
        {
            ListarGridAreas();
        }
        private void ListarGridAreas()
        { /*IGNORAR ESTA LINEA ->*/
            VistaBaseDatos();/*<- IGNORAR ESTA LINEA*/

            ClsAreas objprod = new ClsAreas();
            dgvAreas.DataSource = objprod.ListarAreas();
        }
        private void VistaBaseDatos()
        {

            ClsAreas obj = new ClsAreas();
            dgvAreas.DataSource = obj.tablaareas();
            //DGVCategorias.DataSource = obj.ListarCategorias();
            //DGVMarcas.DataSource = obj.ListarMarcas();
        }

        private void LimpiarFormulario()
        {
            txtArea.Clear();
            txtDescripcion.Clear();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (Operacion == "Insertar")
            {

                objproducto._Area = txtArea.Text;
                objproducto._Descripcion = txtDescripcion.Text;

                objproducto.InsertarAreas();

                MessageBox.Show("Se inserto correctamente");
            }
            else if (Operacion == "Editar")
            {
                objproducto._Area = txtArea.Text;
                objproducto._Descripcion = txtDescripcion.Text;
         
                objproducto._Idar = Convert.ToInt32(idar);
                objproducto.EditarAreas();
                Operacion = "Insertar";
                MessageBox.Show("Se edito correctamente");
            }
            ListarGridAreas();
            //Limpiar texboxs
            LimpiarFormulario();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvAreas.SelectedRows.Count > 0)
            {
                Operacion = "Editar";
                txtArea.Text = dgvAreas.CurrentRow.Cells["AREA"].Value.ToString();
                txtDescripcion.Text = dgvAreas.CurrentRow.Cells["DESCRIPCION"].Value.ToString();
          
                idar = dgvAreas.CurrentRow.Cells["IDAR"].Value.ToString();
            }
            else
                MessageBox.Show("debe seleccionar una fila");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }
    }
}
