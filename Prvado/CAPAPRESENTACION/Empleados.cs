using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Prvado.CAPADATOS;
namespace Prvado.CAPAPRESENTACION
{
    public partial class Empleados : Form
    {
        public Empleados()
        {
            InitializeComponent();
        }
        ClsEmpleados objproducto = new ClsEmpleados();
        string Operacion = "Insertar";
        string idemp;
        private void Empleados_Load(object sender, EventArgs e)
        {
            ListarComboArea();
            ListarGridAreas();
        }
        private void ListarComboArea()
        {
            ClsEmpleados objProd = new ClsEmpleados();
            cbArea.DataSource = objProd.ListarAreas();
            cbArea.DisplayMember = "AREA";
            cbArea.ValueMember = "IDAR";
        }
        private void ListarGridAreas()
        { /*IGNORAR ESTA LINEA ->*/
            VistaBaseDatos();/*<- IGNORAR ESTA LINEA*/
            ClsEmpleados objprod = new ClsEmpleados();
            dgvEmpleados.DataSource = objprod.ListarEmpleados();
        }
        private void VistaBaseDatos()
        {
            ClsEmpleados obj = new ClsEmpleados();
            dgvEmpleados.DataSource = obj.tablaempleados();
            //DGVCategorias.DataSource = obj.ListarCategorias();
            //DGVMarcas.DataSource = obj.ListarMarcas();
        }
        private void LimpiarFormulario()
        {
            txtAreas.Clear();
            txtDpi.Clear();
            txtNombres.Clear();
            txtApellidos.Clear();
            //dateTimePicker1.clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtCargo.Clear();
            txtSueldo.Clear();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (Operacion == "Insertar")
            {
                objproducto._IdArea = Convert.ToInt32(cbArea.SelectedValue);
                objproducto._Dpi = txtDpi.Text;
                objproducto._Nombres = txtNombres.Text;
                objproducto._Apellidos = txtApellidos.Text;
                objproducto._Fechaingreso = dateTimePicker1.Value;
                objproducto._Direccion = txtDireccion.Text;
                objproducto._Telefono = txtTelefono.Text;
                objproducto._Cargo = txtCargo.Text;
                objproducto._Sueldo = txtSueldo.Text;

                objproducto.InsertarEmpleados();

                MessageBox.Show("Se inserto correctamente");
            }
            else if (Operacion == "Editar")
            {
                objproducto._IdArea = Convert.ToInt32(cbArea.SelectedValue);
                objproducto._Dpi = txtDpi.Text;
                objproducto._Nombres = txtNombres.Text;
                objproducto._Apellidos = txtApellidos.Text;
                objproducto._Fechaingreso = dateTimePicker1.Value;
                objproducto._Direccion = txtDireccion.Text;
                objproducto._Telefono = txtTelefono.Text;
                objproducto._Cargo = txtCargo.Text;
                objproducto._Sueldo = txtSueldo.Text;

                objproducto._Idemp = Convert.ToInt32(idemp);
                objproducto.EditarEmpleados();
                Operacion = "Insertar";
                MessageBox.Show("Se edito correctamente");
            }
            ListarGridAreas();
            //Limpiar texboxs
            LimpiarFormulario();
        }
        private void btnbuscar2_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("Data Source=Melvin\\SQLEXPRESS;Initial Catalog=umg1;Integrated Security=True");
            SqlCommand cm = new SqlCommand("Select * From areas where IDAR=@Id", cn);
            cm.Parameters.AddWithValue("@Id", txtBuscar.Text);
            cn.Open();
            SqlDataReader reader = cm.ExecuteReader();
            if (reader.Read())
            {
                txtAreas.Text = reader["IDAR"].ToString();
                label23.Text = reader["AREA"].ToString();
            }
            else
            {
                MessageBox.Show("No Existe empleado para realizar Nomina");
            }

            cn.Close();
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvEmpleados.SelectedRows.Count > 0)
            {
                Operacion = "Editar";

                cbArea.Text = dgvEmpleados.CurrentRow.Cells["IDAREA"].Value.ToString();
                txtDpi.Text = dgvEmpleados.CurrentRow.Cells["DPI"].Value.ToString();
                txtNombres.Text = dgvEmpleados.CurrentRow.Cells["NOMBRES"].Value.ToString();
                txtApellidos.Text = dgvEmpleados.CurrentRow.Cells["APELLIDOS"].Value.ToString();
                dateTimePicker1.MaxDate = DateTime.Parse(dgvEmpleados.CurrentRow.Cells["FECHAINGRESO"].Value.ToString());
                txtDireccion.Text = dgvEmpleados.CurrentRow.Cells["DIRECCION"].Value.ToString();
                txtTelefono.Text = dgvEmpleados.CurrentRow.Cells["TELEFONO"].Value.ToString();
                txtCargo.Text = dgvEmpleados.CurrentRow.Cells["CARGO"].Value.ToString();
                txtSueldo.Text = dgvEmpleados.CurrentRow.Cells["SUELDO"].Value.ToString();

                idemp = dgvEmpleados.CurrentRow.Cells["IDEMP"].Value.ToString();
            }
            else
                MessageBox.Show("debe seleccionar una fila");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvEmpleados.SelectedRows.Count > 0)
            {
                objproducto._Idemp = Convert.ToInt32(dgvEmpleados.CurrentRow.Cells[0].Value);
                objproducto.EliminarEmpleados();
                MessageBox.Show("Se elimino satisfactoriamente");
                ListarGridAreas();
            }
            else
                MessageBox.Show("Seleccione una fila");
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }
    }
}
