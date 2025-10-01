using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Data.SqlClient;
using System.Data;
using System.Globalization;



namespace capaDatos
{
    public class conexion
    {
        // Cadena de conexión a la base de dato
        public static string datasource = "Server=ALEJANDRO\\SQLEXPRESS;Database=ElectroMueblesElBurrito;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True";


        #region " Valida que el usuario exista "
            //Metodo para recibir el usuario y la contrasena 
            // Devuelve un valor true o false
            public bool Login(String Usuario, String Contrasena)
            {
                // Crea una conexion Sql usando la cadena 
                // using asegura que la conexión se cierre automáticamente al final

                using (SqlConnection conexion = new SqlConnection(datasource))
                {
                    String consulta = "SELECT COUNT (*) FROM Usuario WHERE Usuario = @Usuario AND Contrasena=@Contrasena";
                    SqlCommand comando = new SqlCommand(consulta, conexion);

                    //Agrega parámetros para evitar SQL Injection.
                    comando.Parameters.AddWithValue("Usuario", Usuario);
                    comando.Parameters.AddWithValue("@Contrasena", Contrasena);

                    conexion.Open();

                    int contador = (int)comando.ExecuteScalar();
                    return contador > 0;
                }
            }
        #endregion

        #region " Insertar Usuario "Validar" "

            public static bool ValidarUsuario(string Usuario)
            {
                using (SqlConnection conexion = new SqlConnection(datasource))
                {
                    String validaru = "SELECT COUNT (*) FROM Usuario WHERE Usuario=@Usuario";
                    SqlCommand cmd = new SqlCommand(validaru, conexion);

                    cmd.Parameters.AddWithValue("@Usuario", Usuario);
                    conexion.Open();

                    int contador = (int)cmd.ExecuteScalar();
                    return contador > 0;
                }
            }
        #endregion

        #region " Registrar Usuario"

        public static int InsertarUsuario(String Usuario, String Contrasena, int IdRol)
        {
            using (SqlConnection conexion = new SqlConnection(datasource))
            {
                SqlCommand cmd = new SqlCommand("Sp_InsertarUsuario", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Usuario", Usuario);
                cmd.Parameters.AddWithValue("@Contrasena", Contrasena);
                cmd.Parameters.AddWithValue("@IdRol", IdRol);
                conexion.Open();

                object result = cmd.ExecuteScalar();
                return Convert.ToInt32(result);

            }
        }

        #endregion
    }
}
