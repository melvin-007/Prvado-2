using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Prvado.CAPADATOS
{
    class ClsAreas
    {
        private ConexionBD Conexion = new ConexionBD();
        private SqlCommand Comando = new SqlCommand();
        private SqlDataReader LeerFilas;
        //ATRIBUTOS

       // private int idemp;
        private int idar;
        private string area;
        private string descripcion;
        // private int idEmpleado;
        

        //metodos get y set
        public int _Idar
        {
            get { return idar; }
            set { idar = value; }
        }

        public string _Area
        {
            get { return area; }
            set { area = value; }
        }
        public string _Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        //METODOS/FUNCIONES

        public DataTable ListarAreas()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "ListarArea";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            Conexion.CerrarConexion();
            return Tabla;
        }
      
        public void InsertarAreas()
        {
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "AgregarAreas";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@area", area);
            Comando.Parameters.AddWithValue("@descripcion", descripcion);
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
        }
        public void EditarAreas()
        {
            Comando.Connection = Conexion.AbrirConexion();
            //Comando.CommandText = "update EMPLEADOS set IDAREA=" + idArea + ",DPI='" + dpi + "',NOMBRES='" + nombres + "',APELLIDOS='" + apellidos + "',FECHAINGRESO='" + fechaingreso + "',DIRECCION='" + direccion + "',TELEFONO='" + telefono + "',CARGO='" + cargo + "',SUELDO=" + sueldo + " WHERE IDEMP=" + idemp;
            //      Comando.CommandText = "update PRODUCTOS set IDCATEGORIA="+idCategoria+",IDMARCA="+idMarca+",DESCRIPCION='"+descripcion+"',PRECIO="+precio+" WHERE IDPROD="+idprod;
            Comando.CommandText = "update AREAS set AREA='" + area + "',DESCRIPCION='" + descripcion + "' WHERE IDAR=" + idar;
            Comando.CommandType = CommandType.Text;
            Comando.ExecuteNonQuery();
            Conexion.CerrarConexion();
        }
        public void EliminarAreas()
        {
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "delete AREAS where IDAR=" + idar;
            Comando.CommandType = CommandType.Text;
            Comando.ExecuteNonQuery();
            Conexion.CerrarConexion();
        }
        //INSERTAR DATOS
        #region regi
        public DataTable tablaareas()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "select * from AREAS";
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
