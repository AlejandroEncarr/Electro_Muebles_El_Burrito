using capaDatos;
using System.Globalization; //Esto hace referencia la capa que quiero usar
                            //using + nombre del namespace

namespace capaNegocio
{
    public class Validacion
    {
        //  Instancia de la clase en la cual se encuentra la conexion 
        private conexion con = new conexion();

        public bool ValidarLogin(string Usuario, string Contrasena)
        {
            return con.Login(Usuario, Contrasena);
        }

        //A la hora de crear un Usuario valida de que no exista 
        public bool ValidarUsuario(String  Usuario)
        {
            return conexion.ValidarUsuario(Usuario);
        }

        public string InsertarUsuario(string Usuario, String Contrasena, int IdRoll)
        {
            int codigoUsuario = conexion.InsertarUsuario(Usuario, Contrasena, IdRoll);

            return "Usuario agregado con exito.";
        }
    }
}
