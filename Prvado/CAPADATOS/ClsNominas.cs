using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Prvado.CAPADATOS
{
    class ClsNominas
    {
        private ConexionBD Conexion = new ConexionBD();
        private SqlCommand Comando = new SqlCommand();
        private SqlDataReader LeerFilas;

        private int idnom;
        private int idEmpleado;
        private string dpi;
        private string nombres;
        private string apellidos;
        private DateTime fechaingreso;
        private string direccion;
        private string telefono;
        private string cargo;
        private string sueldo;
        private int horasext;
        private int preciohorasext;
        private int pagohorasext;
        private int bonotransporte;
        private double seguromedico;
        private int adelantosueldo;
        private double sueldototal;
        private DateTime fechanomina;
        //metodos get y set
        public int _Idnom
        {
            get { return idnom; }
            set { idnom = value; }
        }
        public int _IdEmpleado
        {
            get { return idEmpleado; }
            set { idEmpleado = value; }
        }
        public string _Dpi
        {
            get { return dpi; }
            set { dpi = value; }
        }     
        public string _Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }
        public string _Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }
        public DateTime _Fechaingreso
        {
            get { return fechaingreso; }
            set { fechaingreso = value; }
        }
        public string _Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        public string _Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        public string _Cargo
        {
            get { return cargo; }
            set { cargo = value; }
        }
        public string _Sueldo
        {
            get { return sueldo; }
            set { sueldo = value; }
        }
        public int _Horasext
        {
            get { return horasext; }
            set { horasext = value; }
        }
        public int _Preciohorasext
        {
            get { return preciohorasext; }
            set { preciohorasext = value; }
        }
        public int _Pagohorasext
        {
            get { return pagohorasext; }
            set { pagohorasext = value; }
        }

        public int _Bonotransporte
        {
            get { return bonotransporte; }
            set { bonotransporte = value; }
        }
        public double _Seguromedico
        {
            get { return seguromedico; }
            set { seguromedico = value; }
        }
        public int _Adelantosueldo
        {
            get { return adelantosueldo; }
            set { adelantosueldo = value; }
        }
        public double _Sueldototal
        {
            get { return sueldototal; }
            set { sueldototal = value; }
        }
        public DateTime _Fechanomina
        {
            get { return fechanomina; }
            set { fechanomina = value; }
        }
        //METODOS/FUNCIONES
        public DataTable ListarEmpleados()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "ListarEmpleados";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            Conexion.CerrarConexion();
            return Tabla;
        }
        public DataTable ListarAreas()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "ListarAreas";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            Conexion.CerrarConexion();
            return Tabla;
        }
        public DataTable ListarNominas()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "ListarNominas";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            Conexion.CerrarConexion();
            return Tabla;
        }
        public void InsertarNominas()
        {
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "AgregarNominas";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@idempleado", idEmpleado);
            Comando.Parameters.AddWithValue("@dpi", dpi);       
            Comando.Parameters.AddWithValue("@nombres", nombres);
            Comando.Parameters.AddWithValue("@apellidos", apellidos);
            Comando.Parameters.AddWithValue("@fechaingreso", fechaingreso);
            Comando.Parameters.AddWithValue("@direccion", direccion);
            Comando.Parameters.AddWithValue("@telefono", telefono);
            Comando.Parameters.AddWithValue("@cargo", cargo);
            Comando.Parameters.AddWithValue("@sueldo", sueldo);
            Comando.Parameters.AddWithValue("@horasextras", horasext);
            Comando.Parameters.AddWithValue("@preciohorasextras", preciohorasext);
            Comando.Parameters.AddWithValue("@pagohorasextras", pagohorasext);
            Comando.Parameters.AddWithValue("@bonotransporte", bonotransporte);
            Comando.Parameters.AddWithValue("@seguromedico", seguromedico);
            Comando.Parameters.AddWithValue("@adelantosueldo", adelantosueldo);
            Comando.Parameters.AddWithValue("@sueldototal", sueldototal);
            Comando.Parameters.AddWithValue("@fechanomina", fechanomina);
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
        }
        public void EditarNominas()
        {
            Comando.Connection = Conexion.AbrirConexion();
          //  Comando.CommandText = "update EMPLEADOS set IDAREA=" + idArea + ",DPI='" + dpi + "',NOMBRES='" + nombres + "',APELLIDOS='" + apellidos + "',FECHAINGRESO='" + fechaingreso.ToString("yyyy/MM/dd HH:mm:ss") + "',DIRECCION='" + direccion + "',TELEFONO='" + telefono + "',CARGO='" + cargo + "',SUELDO=" + sueldo + " WHERE IDEMP=" + idemp;

            Comando.CommandText = "update NOMINAS set IDEMPLEADO=" + idEmpleado + ",DPI='" + dpi + "',NOMBRES='" + nombres + "',APELLIDOS='" + apellidos + "',FECHAINGRESO='" + fechaingreso.ToString("yyyy/MM/dd HH:mm:ss") + "',DIRECCION='" + direccion + "',TELEFONO='" + telefono + "',CARGO='" + cargo + "',SUELDO='" + sueldo + "',HORASEXT='" + horasext + "',PRECIOHORASEXT='" + preciohorasext + "',PAGOHORASEXT='" + pagohorasext + "',BONOTRANSPORTE='" + bonotransporte + "',SEGUROMEDICO='" + seguromedico + "',ADELANTOSUELDO='" + adelantosueldo + "', SUELDOTOTAL=" + sueldototal + ", FECHANOMINA='" + fechanomina.ToString("yyyy/MM/dd HH:mm:ss") + "' WHERE IDNOM=" + idnom;
            Comando.CommandType = CommandType.Text;
            Comando.ExecuteNonQuery();
            Conexion.CerrarConexion();
        }
        public void EliminarNominas()  
        {
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "delete NOMINAS where IDNOM=" + idnom;
            Comando.CommandType = CommandType.Text;
            Comando.ExecuteNonQuery();
            Conexion.CerrarConexion();
        }
        //INSERTAR DATOS
        #region regi
        public DataTable tablanominas()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "select *from NOMINAS";
            Comando.CommandType = CommandType.Text;
            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            Conexion.CerrarConexion();
            return Tabla;
        }
        #endregion
    }
}
