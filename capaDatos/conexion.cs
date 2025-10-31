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
        //Metodo para validar si el usuario esta disponible
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
        //metodo para insertar al usuario, llamando el metodo almacenado 
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

        #region "Agregar Producto"

        //Metodo para insetar un producto

        public static void InsertarProducto(string Nombre, string Categoria, decimal Precio, int Stock, string Caracteristicas, string Marca, string Color, string Modelo, string NumeroSerie, int GarantiaMeses)
        {

            using (SqlConnection conexion = new SqlConnection(datasource))
            {
                SqlCommand cmd = new SqlCommand("InsertarProducto", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Nombre", Nombre);
                cmd.Parameters.AddWithValue("@Categoria", Categoria);
                cmd.Parameters.AddWithValue("@Precio", Precio);
                cmd.Parameters.AddWithValue("@Stock", Stock);
                cmd.Parameters.AddWithValue("@Caracteristicas", Caracteristicas);
                cmd.Parameters.AddWithValue("@Marca", Marca);
                cmd.Parameters.AddWithValue("@Color", Color);
                cmd.Parameters.AddWithValue("@Modelo", Modelo);
                cmd.Parameters.AddWithValue("@NumeroSerie", NumeroSerie);
                cmd.Parameters.AddWithValue("@GarantiaMeses", GarantiaMeses);

                conexion.Open();
                cmd.ExecuteNonQuery();
                conexion.Close();

            }
        }

        #endregion

        #region "Buscar Producto"

        public static DataTable ObtenerProductoPorId(int productoId)
        {
            using (SqlConnection conexion = new SqlConnection(datasource))
            {
                SqlCommand comando = new SqlCommand("ObtenerProductoPorId", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@ProductoID", productoId);

                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                return tabla;
            }
        }

        #endregion

        #region "Optener vendedor"

        public static DataTable ObtenerVendedorPorId(int IdVendedor)
        {
            using (SqlConnection conexion = new SqlConnection(datasource))
            {
                SqlCommand comando = new SqlCommand("ObtenerVendedorPorId", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@IdVendedor", IdVendedor);

                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                return tabla;
            }
        }

        #endregion

        #region "Obtener Cliente"

        public static DataTable ObtenerClientePorId(int clienteId)
        {
            using (SqlConnection conexion = new SqlConnection(datasource))
            {
                SqlCommand comando = new SqlCommand("ObtenerClientePorId", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@ClienteID", clienteId);

                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                return tabla;
            }
        }



        #endregion

        #region "Agregar Cliente"

        public static void AgregarCliente(string Cedula, string Nombre, string Apellido, string Telefono, string Email, string Direccion)
        {

            using (SqlConnection conexion = new SqlConnection(datasource))
            {
                SqlCommand cmd = new SqlCommand("InsertarCliente", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Nombre", Nombre);
                cmd.Parameters.AddWithValue("@Cedula", Cedula);
                cmd.Parameters.AddWithValue("@Apellido", Apellido);
                cmd.Parameters.AddWithValue("@Telefono", Telefono);
                cmd.Parameters.AddWithValue("@Email", Email);
                cmd.Parameters.AddWithValue("@Direccion", Direccion);

                conexion.Open();
                cmd.ExecuteNonQuery();
                conexion.Close();

            }
        }

        #endregion

        #region "Agregar Contrato"

        public class Contrato
        {
            public static void AgregarContrato(
                int IdVendedor, string NombreComercial, string RNC, string DireccionVendedor, string TelefonoVendedor, string EmailVendedor,
                int ClienteId, string NombreCompleto, string DireccionCliente, string EmailCliente, string TelefonoCliente,
                string Articulo, string Marca, string Color, string Modelo, string NumeroSerie, decimal Subtotal,
                decimal MontoFinanciado, int CuotasMensuales, int PlazoMeses, decimal InteresAnual, DateTime FechaInicio, DateTime FechaVencimiento,
                decimal MontoTotal, decimal PagoInicial, string PagosPeriodicos, DateTime FechaLimitePago,
                int GarantiaMeses, int DiasCambio, string Observaciones,
                string NombreEmpresa, string FirmaEmpresa, DateTime FechaEmpresa,
                string NombreClienteFirma, string FirmaCliente, DateTime FechaCliente,
                int? TransaccionId // Nullable
            )
            {
                using (SqlConnection conexion = new SqlConnection(datasource))
                {
                    SqlCommand cmd = new SqlCommand("InsertarContrato", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Vendedor
                    cmd.Parameters.AddWithValue("@IdVendedor", IdVendedor);
                    cmd.Parameters.AddWithValue("@NombreComercial", NombreComercial);
                    cmd.Parameters.AddWithValue("@RNC", RNC);
                    cmd.Parameters.AddWithValue("@DireccionVendedor", DireccionVendedor);
                    cmd.Parameters.AddWithValue("@TelefonoVendedor", TelefonoVendedor);
                    cmd.Parameters.AddWithValue("@EmailVendedor", EmailVendedor);

                    // Cliente
                    cmd.Parameters.AddWithValue("@ClienteId", ClienteId);
                    cmd.Parameters.AddWithValue("@NombreCompleto", NombreCompleto);
                    cmd.Parameters.AddWithValue("@DireccionCliente", DireccionCliente);
                    cmd.Parameters.AddWithValue("@EmailCliente", EmailCliente);
                    cmd.Parameters.AddWithValue("@TelefonoCliente", TelefonoCliente);

                    // Artículo
                    cmd.Parameters.AddWithValue("@Articulo", Articulo);
                    cmd.Parameters.AddWithValue("@Marca", Marca);
                    cmd.Parameters.AddWithValue("@Color", Color);
                    cmd.Parameters.AddWithValue("@Modelo", Modelo);
                    cmd.Parameters.AddWithValue("@NumeroSerie", NumeroSerie);
                    cmd.Parameters.AddWithValue("@Subtotal", Subtotal);

                    // Crédito
                    cmd.Parameters.AddWithValue("@MontoFinanciado", MontoFinanciado);
                    cmd.Parameters.AddWithValue("@CuotasMensuales", CuotasMensuales);
                    cmd.Parameters.AddWithValue("@PlazoMeses", PlazoMeses);
                    cmd.Parameters.AddWithValue("@InteresAnual", InteresAnual);
                    cmd.Parameters.AddWithValue("@FechaInicio", FechaInicio);
                    cmd.Parameters.AddWithValue("@FechaVencimiento", FechaVencimiento);

                    // Layaway
                    cmd.Parameters.AddWithValue("@MontoTotal", MontoTotal);
                    cmd.Parameters.AddWithValue("@PagoInicial", PagoInicial);
                    cmd.Parameters.AddWithValue("@PagosPeriodicos", PagosPeriodicos);
                    cmd.Parameters.AddWithValue("@FechaLimitePago", FechaLimitePago);

                    // Garantía
                    cmd.Parameters.AddWithValue("@GarantiaMeses", GarantiaMeses);
                    cmd.Parameters.AddWithValue("@DiasCambio", DiasCambio);
                    cmd.Parameters.AddWithValue("@Observaciones", Observaciones);

                    // Firmas
                    cmd.Parameters.AddWithValue("@NombreEmpresa", NombreEmpresa);
                    cmd.Parameters.AddWithValue("@FirmaEmpresa", FirmaEmpresa);
                    cmd.Parameters.AddWithValue("@FechaEmpresa", FechaEmpresa);
                    cmd.Parameters.AddWithValue("@NombreCliente", NombreClienteFirma);
                    cmd.Parameters.AddWithValue("@FirmaCliente", FirmaCliente);
                    cmd.Parameters.AddWithValue("@FechaCliente", FechaCliente);

                    // Otros
                    cmd.Parameters.AddWithValue("@TransaccionId", (object)TransaccionId ?? DBNull.Value);

                    conexion.Open();
                    cmd.ExecuteNonQuery();
                    conexion.Close();
                }
            }
        }
        #endregion

        #region "Metodos de pago "
        public static void InsertarFiduciario(string nombre, string cedula, string telefono, string email, string direccion)
        {
            using (SqlConnection cn = new SqlConnection(datasource))
            {
                SqlCommand cmd = new SqlCommand("InsertarFiduciario", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Cedula", cedula);
                cmd.Parameters.AddWithValue("@Telefono", telefono);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Direccion", direccion);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }


        public static void InsertarLayaway(DateTime fechaInicio, DateTime fechaFinal, decimal montoTotal, decimal montoInicial, string estado, int clienteID, int productoID, string pagosPeriodicos)
        {
            using (SqlConnection cn = new SqlConnection(datasource))
            {
                SqlCommand cmd = new SqlCommand("InsertarLayaway", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@FechaInicio", fechaInicio);
                cmd.Parameters.AddWithValue("@FechaFinal", fechaFinal);
                cmd.Parameters.AddWithValue("@MontoTotal", montoTotal);
                cmd.Parameters.AddWithValue("@MontoInicial", montoInicial);
                cmd.Parameters.AddWithValue("@Estado", estado);
                cmd.Parameters.AddWithValue("@ClienteID", clienteID);
                cmd.Parameters.AddWithValue("@ProductoID", productoID);
                cmd.Parameters.AddWithValue("@PagosPeriodicos", pagosPeriodicos);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }
        #endregion


        #region

        public static int InsertarVenta(int clienteID, int productoID, int idVendedor, DateTime fechaVenta,
                                string metodoPago, decimal subtotal, decimal itbis, decimal total)
        {
            using (SqlConnection cn = new SqlConnection(datasource))
            {
                SqlCommand cmd = new SqlCommand("sp_InsertarVenta", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ClienteID", clienteID);
                cmd.Parameters.AddWithValue("@ProductoID", productoID);
                cmd.Parameters.AddWithValue("@IdVendedor", idVendedor);
                cmd.Parameters.AddWithValue("@FechaVenta", fechaVenta);
                cmd.Parameters.AddWithValue("@MetodoPago", metodoPago);
                cmd.Parameters.AddWithValue("@Subtotal", subtotal);
                cmd.Parameters.AddWithValue("@ITBIS", itbis);
                cmd.Parameters.AddWithValue("@Total", total);

                SqlParameter outputId = new SqlParameter("@VentaID", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(outputId);

                cn.Open();
                cmd.ExecuteNonQuery();

                return (int)outputId.Value;
            }
        }


        public static void InsertarPagoContado(int ventaID, string tipoMetodo, DateTime fechaPago, decimal montoTotal)
        {
            using (SqlConnection cn = new SqlConnection(datasource))
            {
                SqlCommand cmd = new SqlCommand("sp_InsertarPagoContado", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@VentaID", ventaID);
                cmd.Parameters.AddWithValue("@TipoMetodo", tipoMetodo);
                cmd.Parameters.AddWithValue("@FechaPago", fechaPago);
                cmd.Parameters.AddWithValue("@MontoTotal", montoTotal);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static void InsertarLayaway(int ventaID, string tipoMetodo, DateTime fechaInicio, DateTime fechaFinal,
                                   decimal montoTotal, decimal montoPagado, decimal montoPendiente,
                                   string estado, string pagosPeriodicos)
        {
            using (SqlConnection cn = new SqlConnection(datasource))
            {
                SqlCommand cmd = new SqlCommand("sp_InsertarLayaway", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@VentaID", ventaID);
                cmd.Parameters.AddWithValue("@TipoMetodo", tipoMetodo);
                cmd.Parameters.AddWithValue("@FechaInicio", fechaInicio);
                cmd.Parameters.AddWithValue("@FechaFinal", fechaFinal);
                cmd.Parameters.AddWithValue("@MontoTotal", montoTotal);
                cmd.Parameters.AddWithValue("@MontoPagado", montoPagado);
                cmd.Parameters.AddWithValue("@MontoPendiente", montoPendiente);
                cmd.Parameters.AddWithValue("@Estado", estado);
                cmd.Parameters.AddWithValue("@PagosPeriodicos", pagosPeriodicos);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        #endregion

    }
}
