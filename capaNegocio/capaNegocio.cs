using capaDatos;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Globalization; //Esto hace referencia la capa que quiero usar
                            //using + nombre del namespace

namespace capaNegocio
{
    #region "Agregar Usuario"
    public class Validacion
    {
        //  Instancia de la clase en la cual se encuentra la conexion 
        private conexion con = new conexion();

        public bool ValidarLogin(string Usuario, string Contrasena)
        {
            return con.Login(Usuario, Contrasena);
        }

        //A la hora de crear un Usuario valida de que no exista 
        public bool ValidarUsuario(String Usuario)
        {
            return conexion.ValidarUsuario(Usuario);
        }

        public string InsertarUsuario(string Usuario, String Contrasena, int IdRoll)
        {
            int codigoUsuario = conexion.InsertarUsuario(Usuario, Contrasena, IdRoll);

            return "Usuario agregado con exito.";
        }
    }
    #endregion

    #region "Producto"

    public class Productos
    {
        //  Instancia de la clase en la cual se encuentra la conexion 
        private conexion con = new conexion();

        public string InsertarProducto(string Nombre, string Categoria, decimal Precio,
                                string Caracteristicas, string Marca, string Color,
                                string Modelo, string NumeroSerie, int GarantiaMeses, bool Estado)
        {
            try
            {
                conexion.InsertarProducto(Nombre, Categoria, Precio, Caracteristicas, Marca, Color, Modelo, NumeroSerie, GarantiaMeses, Estado);
                return "Producto agregado con éxito.";
            }
            catch (Exception ex)
            {
                return $"Error al agregar el producto: {ex.Message}";
            }
        }

    }

    #endregion

    #region "Agregar Cliente"

    public class Cliente
    {
        //  Instancia de la clase en la cual se encuentra la conexion 
        private conexion con = new conexion();

        public string InsertarCliente(string Cedula, string Nombre, string Apellido, string Telefono, string Email, string Direccion)
        {
            try
            {
                conexion.AgregarCliente(Nombre, Cedula, Apellido, Telefono, Email, Direccion);
                return "Cliente agregado con exito.";
            }
            catch (Exception ex)
            {
                return $"Error al agregar al Cliente: {ex.Message}";
            }


        }
    }
    #endregion

    #region "Agregar Contrato"

    public class Contrato
    {
        // Instancia de la clase en la cual se encuentra la conexión
        private conexion con = new conexion();

        public string InsertarContrato(
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
            try
            {
                conexion.Contrato.AgregarContrato(
                    IdVendedor, NombreComercial, RNC, DireccionVendedor, TelefonoVendedor, EmailVendedor,
                    ClienteId, NombreCompleto, DireccionCliente, EmailCliente, TelefonoCliente,
                    Articulo, Marca, Color, Modelo, NumeroSerie, Subtotal,
                    MontoFinanciado, CuotasMensuales, PlazoMeses, InteresAnual, FechaInicio, FechaVencimiento,
                    MontoTotal, PagoInicial, PagosPeriodicos, FechaLimitePago,
                    GarantiaMeses, DiasCambio, Observaciones,
                    NombreEmpresa, FirmaEmpresa, FechaEmpresa,
                    NombreClienteFirma, FirmaCliente, FechaCliente,
                    TransaccionId
                );

                return "Contrato registrado con éxito.";
            }
            catch (Exception ex)
            {
                return $"Error al registrar el contrato: {ex.Message}";
            }
        }
    }



    #endregion

    public class Producto
    {
        public DataTable ObtenerProductoPorId(int productoId)
        {
            try
            {
                return conexion.ObtenerProductoPorId(productoId);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener datos del producto: " + ex.Message);
            }
        }
    }


    public class Vendedor
    {
        public DataTable ObtenerVendedorPorId(int IdVendedor)
        {
            try
            {
                return conexion.ObtenerVendedorPorId(IdVendedor);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener datos del producto: " + ex.Message);
            }
        }
    }


    public class Clienteid
    {
        public DataTable ObtenerClientePorId(int clienteId)
        {
            try
            {
                return conexion.ObtenerClientePorId(clienteId);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener datos del cliente: " + ex.Message);
            }
        }
    }

    #region "Pagos"
    public class Venta
    {
        public static int InsertarVenta(int clienteID, int productoID, int idVendedor, DateTime fechaVenta,
                                       string metodoPago, decimal subtotal, decimal itbis, decimal total)
        {
            return conexion.InsertarVenta(clienteID, productoID, idVendedor, fechaVenta, metodoPago, subtotal, itbis, total);
        }

        public static void InsertarMetodoPagoContado(int ventaID, string tipoMetodo, DateTime fechaPago, decimal montoTotal)
        {
            conexion.InsertarPagoContado(ventaID, tipoMetodo, fechaPago, montoTotal);
        }

        public static void InsertarMetodoPagoLayaway(int ventaID, string tipoMetodo, DateTime fechaInicio, DateTime fechaFinal,
                                                    decimal montoTotal, decimal montoInicial, decimal montoPagado,
                                                    string estado, string pagosPeriodicos)
        {
            conexion.InsertarLayaway(ventaID, tipoMetodo, fechaInicio, fechaFinal, montoTotal, montoInicial, montoPagado, estado, pagosPeriodicos);
        }

        /*  public static void InsertarMetodoFiduciario(int ventaID,
                 decimal montoTotal,
                 decimal montoPagado,
                 string estado,
                 decimal montoFinanciado,
                 decimal cuotasMensuales,
                 int plazo,
                 decimal interesAnual,
                 DateTime fechaInicio,
                 DateTime fechaVencimiento)
          {
              conexion.InsertarFiduciario(ventaID, montoTotal, montoPagado, estado, montoFinanciado, cuotasMensuales, plazo, interesAnual, fechaInicio, fechaVencimiento);
          }*/




        public static void InsertarVenta()
        {
            throw new NotImplementedException();
        }
    }

    #endregion

    public class VentaNegocio
    {
        public int RegistrarVenta(int clienteID, int productoID, int idVendedor, DateTime fechaVenta,
                                  string metodoPago, decimal subtotal, decimal itbis, decimal total)
        {
            return conexion.InsertarVenta(clienteID, productoID, idVendedor, fechaVenta, metodoPago, subtotal, itbis, total);
        }

        public void RegistrarPagoContado(int ventaID, string tipoMetodo, DateTime fechaPago, decimal montoTotal)
        {
            conexion.InsertarPagoContado(ventaID, tipoMetodo, fechaPago, montoTotal);
        }

        public static void InsertarMetodoPagoLayaway(int ventaID, string tipoMetodo, DateTime fechaInicio, DateTime fechaFinal,
            decimal montoTotal, decimal montoInicial, decimal montoPagado, string estado, string pagosPeriodicos)
        {
            conexion.InsertarLayaway(ventaID, tipoMetodo, fechaInicio, fechaFinal,
                                     montoTotal, montoInicial, montoPagado,
                                     estado, pagosPeriodicos);
        }

        public static void InsertarMetodoPagoFiduciario(int ventaID,decimal montoTotal, decimal montoPagado, string estado, decimal montoFinanciado,
            decimal cuotasMensuales, int plazo, decimal interesAnual, DateTime fechaInicio, DateTime fechaVencimiento)
        {
            conexion.InsertarFiduciario(ventaID, montoTotal, montoPagado, estado,
                                        montoFinanciado, cuotasMensuales, plazo,
                                        interesAnual, fechaInicio, fechaVencimiento);
        }


    }
    public class Pagos
    {
        public  DataTable ObtenerVenta(int ventaID)
        {
            return conexion.ObtenerVentaPorID(ventaID);
        }


        public static void InsertarPago(int ventaID, decimal montoPagado, decimal mora,
                               decimal montoPendiente, string fechaPago, string metodoPago)
        {
            conexion.InsertarPago(ventaID, montoPagado, mora, montoPendiente, fechaPago, metodoPago);
        }


    }   

}

