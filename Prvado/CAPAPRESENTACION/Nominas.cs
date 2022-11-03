using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using Prvado.CAPADATOS;
namespace Prvado.CAPAPRESENTACION
{
    public partial class Nominas : Form
    {
        public Nominas()
        {
            InitializeComponent();
        }
        ClsNominas objproducto = new ClsNominas();
        string Operacion = "Insertar";
        string idnom;
        
        private void Nominas_Load(object sender, EventArgs e)
        {
            //CARGAR LISTAS EN COMBOBOXS/ DATAGRIDVIEW
            ListarEmpleado();
       
            ListarNominas();
        }        
        private void ListarEmpleado()
        {
            ClsNominas objProd = new ClsNominas();
            CmbEmpleado.DataSource = objProd.ListarEmpleados();
            CmbEmpleado.DisplayMember = "NOMBRE";
            CmbEmpleado.ValueMember = "IDEMP";
        }
        private void ListarNominas()
        { /*IGNORAR ESTA LINEA ->*/
            VistaBaseDatos();/*<- IGNORAR ESTA LINEA*/

            ClsNominas objprod = new ClsNominas();
            dgvNominas.DataSource = objprod.ListarNominas();
        }
        private void VistaBaseDatos()
        {
            ClsNominas obj = new ClsNominas();
            dgvNominas.DataSource = obj.tablanominas();
            //DGVCategorias.DataSource = obj.ListarCategorias();
            //DGVMarcas.DataSource = obj.ListarMarcas();
        }
        private void LimpiarFormulario()
        {
            txtDpi.Clear();
            txtNombres.Clear();
            txtApellidos.Clear();
            txtCargo.Clear();
            txtSueldo.Clear();
            txtHorasextras.Clear();
            txtPreciohorasextras.Clear();
            txtPagohorasextras.Clear();
            txtBonotransporte.Clear();
            txtSeguromedico.Clear();
            txtAdelantosueldo.Clear();

            txtSueldototal.Clear();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (Operacion == "Insertar")
            {
                objproducto._IdEmpleado = Convert.ToInt32(CmbEmpleado.SelectedValue);
   
                objproducto._Dpi = txtDpi.Text;
                objproducto._Nombres = txtNombres.Text;
                objproducto._Apellidos = txtApellidos.Text;
                objproducto._Fechaingreso = dateTimePicker1.Value;
                objproducto._Direccion = txtDireccion.Text;
                objproducto._Telefono = txtTelefono.Text;
                objproducto._Cargo = txtCargo.Text;
                objproducto._Sueldo = txtSueldo.Text;
                objproducto._Horasext = Convert.ToInt32(txtHorasextras.Text);
                objproducto._Preciohorasext = Convert.ToInt32(txtPreciohorasextras.Text);
                objproducto._Pagohorasext = Convert.ToInt32(txtPagohorasextras.Text);
                objproducto._Bonotransporte = Convert.ToInt32(txtBonotransporte.Text);
                objproducto._Seguromedico = Convert.ToDouble(txtSeguromedico.Text);
                objproducto._Adelantosueldo = Convert.ToInt32(txtAdelantosueldo.Text);
                objproducto._Sueldototal = Convert.ToDouble(txtSueldototal.Text);
                objproducto._Fechanomina = dateTimePicker2.Value;
                objproducto.InsertarNominas();

                MessageBox.Show("Se inserto correctamente");
            }
            else if (Operacion == "Editar")
            {
                objproducto._IdEmpleado = Convert.ToInt32(CmbEmpleado.SelectedValue);

                objproducto._Dpi = txtDpi.Text;
                objproducto._Nombres = txtNombres.Text;
                objproducto._Apellidos = txtApellidos.Text;
                objproducto._Fechaingreso = dateTimePicker1.Value;
                objproducto._Direccion = txtDireccion.Text;
                objproducto._Telefono = txtTelefono.Text;
                objproducto._Cargo = txtCargo.Text;
                objproducto._Sueldo = txtSueldo.Text;
                objproducto._Horasext = Convert.ToInt32(txtHorasextras.Text);
                objproducto._Preciohorasext = Convert.ToInt32(txtPreciohorasextras.Text);
                objproducto._Pagohorasext = Convert.ToInt32(txtPagohorasextras.Text);
                objproducto._Bonotransporte = Convert.ToInt32(txtBonotransporte.Text);
                objproducto._Seguromedico = Convert.ToDouble(txtSeguromedico.Text);
                objproducto._Adelantosueldo = Convert.ToInt32(txtAdelantosueldo.Text);
                objproducto._Sueldototal = Convert.ToDouble(txtSueldototal.Text);
                objproducto._Fechanomina = dateTimePicker2.Value;
                objproducto._Idnom = Convert.ToInt32(idnom);
                objproducto.EditarNominas();
                Operacion = "Insertar";
                MessageBox.Show("Se edito correctamente");
            }
            ListarNominas();
            //Limpiar texboxs
            LimpiarFormulario();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvNominas.SelectedRows.Count > 0)
            {
                Operacion = "Editar";

                CmbEmpleado.Text = dgvNominas.CurrentRow.Cells["IDEMP"].Value.ToString();
                txtDpi.Text = dgvNominas.CurrentRow.Cells["DPI"].Value.ToString();
                txtNombres.Text = dgvNominas.CurrentRow.Cells["NOMBRES"].Value.ToString();  
                txtApellidos.Text = dgvNominas.CurrentRow.Cells["APELLIDOS"].Value.ToString();
                dateTimePicker1.MaxDate = DateTime.Parse(dgvNominas.CurrentRow.Cells["FECHAINGRESO"].Value.ToString());
                txtDireccion.Text = dgvNominas.CurrentRow.Cells["DIRECCION"].Value.ToString();
                txtTelefono.Text = dgvNominas.CurrentRow.Cells["TELEFONO"].Value.ToString();
                txtCargo.Text = dgvNominas.CurrentRow.Cells["CARGO"].Value.ToString();
                txtSueldo.Text = dgvNominas.CurrentRow.Cells["SUELDO"].Value.ToString();
                txtHorasextras.Text = dgvNominas.CurrentRow.Cells["HORASEXT"].Value.ToString();
                txtPreciohorasextras.Text = dgvNominas.CurrentRow.Cells["PRECIOHORASEXT"].Value.ToString();
                txtPagohorasextras.Text = dgvNominas.CurrentRow.Cells["PAGOHORASEXT"].Value.ToString();
                txtBonotransporte.Text = dgvNominas.CurrentRow.Cells["BONOTRANSPORTE"].Value.ToString();
                txtSeguromedico.Text = dgvNominas.CurrentRow.Cells["SEGUROMEDICO"].Value.ToString();
                txtAdelantosueldo.Text = dgvNominas.CurrentRow.Cells["ADELANTOSUELDO"].Value.ToString();
                txtSueldototal.Text = dgvNominas.CurrentRow.Cells["SUELDOTOTAL"].Value.ToString();
                dateTimePicker2.MaxDate = DateTime.Parse(dgvNominas.CurrentRow.Cells["FECHANOMINA"].Value.ToString());

                idnom = dgvNominas.CurrentRow.Cells["ID"].Value.ToString();
            }
            else
                MessageBox.Show("debe seleccionar una fila");
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombres.Text))
            {
                MessageBox.Show("Debe completar todos los campos!!!");
            }
            else if (string.IsNullOrEmpty(txtApellidos.Text))
            {
                MessageBox.Show("Debe completar todos los campos!!!");
            }
            else if (string.IsNullOrEmpty(txtAdelantosueldo.Text))
            {
                MessageBox.Show("Debe completar todos los campos!!!");
            }
            else if (string.IsNullOrEmpty(txtBonotransporte.Text))
            {
                MessageBox.Show("Debe completar todos los campos!!!");
            }
            else if (string.IsNullOrEmpty(txtHorasextras.Text))
            {
                MessageBox.Show("Debe completar todos los campos!!!");
            }

            else if (string.IsNullOrEmpty(txtPreciohorasextras.Text))
            {
                MessageBox.Show("Debe completar todos los campos!!!");
            }

            else if (string.IsNullOrEmpty(txtSueldo.Text))
            {
                MessageBox.Show("Debe completar todos los campos!!!");
            }
            else if (string.IsNullOrEmpty(CmbEmpleado.Text))
            {
                MessageBox.Show("Debe completar todos los campos!!!");
            }

            else {
                float totalAsignaciones, SeguroMed, TotalDesucciones, SueldoBruto, SueldoNeto;
                int HorasExt, PrecioHorasExt, PagoHorasExt, BonoTransp, AdelantoSueldo;
                HorasExt = Convert.ToInt32(txtHorasextras.Text);
                PrecioHorasExt = Convert.ToInt32(txtPreciohorasextras.Text); 
                PagoHorasExt = HorasExt * PrecioHorasExt;
                BonoTransp = Convert.ToInt32(txtBonotransporte.Text);
                totalAsignaciones = PagoHorasExt + BonoTransp;
                SueldoBruto = float.Parse(txtSueldo.Text);
                SeguroMed = SueldoBruto * 0.0591F;
                AdelantoSueldo = Convert.ToInt32(txtAdelantosueldo.Text);
                TotalDesucciones = SeguroMed - AdelantoSueldo;
                SueldoNeto = SueldoBruto + totalAsignaciones - TotalDesucciones;
                txtPagohorasextras.Text = PagoHorasExt.ToString();
                txtTotalAsignaciones.Text = totalAsignaciones.ToString();
                txtSeguromedico.Text = SeguroMed.ToString();
                txtTotalDeducciones.Text = TotalDesucciones.ToString();
                txtSueldototal.Text = SueldoNeto.ToString();
            }
        }

        private void btnbuscar1_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("Data Source=Melvin\\SQLEXPRESS;Initial Catalog=umg1;Integrated Security=True");
            SqlCommand cm = new SqlCommand("Select * From empleados where IDEMP=@Id", cn);
            cm.Parameters.AddWithValue("@Id", textBox1.Text);
            cn.Open();
            SqlDataReader reader = cm.ExecuteReader();
            if (reader.Read())
            {
               
               
                CmbEmpleado.Text = reader["IDEMP"].ToString();
                txtDpi.Text = reader["DPI"].ToString();
                txtNombres.Text = reader["NOMBRES"].ToString();
                txtApellidos.Text = reader["APELLIDOS"].ToString();
                dateTimePicker1.Text = reader["FECHAINGRESO"].ToString();
                txtDireccion.Text = reader["DIRECCION"].ToString();
                txtTelefono.Text = reader["TELEFONO"].ToString();
                txtCargo.Text = reader["CARGO"].ToString();
                txtSueldo.Text = reader["SUELDO"].ToString();
              
            }
            else
            {
                MessageBox.Show("No Existe empleado para realizar Nomina");
            }

            cn.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void btn_reporte_Click(object sender, EventArgs e)
        {
            ReporteNominas frm = new ReporteNominas();
            frm.ShowDialog();
        }
    }
    }

