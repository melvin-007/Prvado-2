using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Prvado.CAPADATOS
{
    class ClsEmpleados
    {

        private ConexionBD Conexion = new ConexionBD();
        private SqlCommand Comando = new SqlCommand();
        private SqlDataReader LeerFilas;
        //ATRIBUTOS

        private int idemp;
        private int idArea;
        private string dpi;
        private string nombres;
        private string apellidos;
        private DateTime fechaingreso;
        private string direccion;
        private string telefono;
        private string cargo;
        private string sueldo;

        //metodos get y set
        public int _Idemp
        {
            get { return idemp; }
            set { idemp = value; }
        }

        public int _IdArea
        {
            get { return idArea; }
            set { idArea = value; }
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

        //METODOS/FUNCIONES

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
        public void InsertarEmpleados()
        {
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "AgregarEmpleados";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@idarea", idArea);
            Comando.Parameters.AddWithValue("@dpi", dpi);
            Comando.Parameters.AddWithValue("@nombres", nombres);
            Comando.Parameters.AddWithValue("@apellidos", apellidos);
            Comando.Parameters.AddWithValue("@fechaingreso", fechaingreso);
            Comando.Parameters.AddWithValue("@direccion", direccion);
            Comando.Parameters.AddWithValue("@telefono", telefono);
            Comando.Parameters.AddWithValue("@cargo", cargo);
            Comando.Parameters.AddWithValue("@sueldo", sueldo);
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
        }
        public void EditarEmpleados()
        {
            Comando.Connection = Conexion.AbrirConexion();
            //Comando.CommandText = "update EMPLEADOS set IDAREA=" + idArea + ",DPI='" + dpi + "',NOMBRES='" + nombres + "',APELLIDOS='" + apellidos + "',FECHAINGRESO='" + fechaingreso + "',DIRECCION='" + direccion + "',TELEFONO='" + telefono + "',CARGO='" + cargo + "',SUELDO=" + sueldo + " WHERE IDEMP=" + idemp;
            Comando.CommandText = "update EMPLEADOS set IDAREA=" + idArea + ",DPI='" + dpi + "',NOMBRES='" + nombres + "',APELLIDOS='" + apellidos + "',FECHAINGRESO='" + fechaingreso.ToString("yyyy/MM/dd HH:mm:ss") + "',DIRECCION='" + direccion + "',TELEFONO='" + telefono + "',CARGO='" + cargo + "',SUELDO=" + sueldo + " WHERE IDEMP=" + idemp;
            Comando.CommandType = CommandType.Text;
            Comando.ExecuteNonQuery();
            Conexion.CerrarConexion();
        }
        public void EliminarEmpleados()
        {
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "delete EMPLEADOS where IDEMP=" + idemp;
            Comando.CommandType = CommandType.Text;
            Comando.ExecuteNonQuery();
            Conexion.CerrarConexion();
        }
        //INSERTAR DATOS
        #region regi
        public DataTable tablaempleados()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "select * from EMPLEADOS";
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
