using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cl.Ing.Pensiones.Beneficios.Bel
{
    public class CargaInformacionCoreTraspasoPrimaUno
    {
        #region Miembros

        private string personaID = string.Empty;
        private string apellidoPaterno = string.Empty;
        private string apellidoMaterno = string.Empty;
        private string nombres = string.Empty;
        private string tipoComposicionPrimaria = string.Empty;
        private string tipoModalidad = string.Empty;
        private string tipoTramitePension = string.Empty;
        private string tipoSeleccion = string.Empty;
        private int codigoCiaSeguros;
        private string fechaContabilizacion = string.Empty;
        private int valorMLsaldo;
        private string tipoFondo = string.Empty;
        private string fechaDisponibilidad = string.Empty;
        private string procesoID = string.Empty;
        private string tipoTramite = string.Empty;
        private string tipoModalidadDos = string.Empty;
        private string tipoViaPago = string.Empty;
        private string institucionFinancieraID = string.Empty;
        private string receptorPagoID = string.Empty;
        private int codigoInstitucionFinancieraDeposito;
        private string tipoCuentaDeposito = string.Empty;
        private string numeroCuentaDeposito = string.Empty;
        private int codigoAgenciaPagoRegimen;
        private string descripcion = string.Empty;
        private string direccion = string.Empty;
        private int codigoComuna;
        private string descripcionComuna = string.Empty;
        private int regionID;
        private string descripcionRegion = string.Empty;
        private string ciudad = string.Empty;
        private int clienteID;
        private int numeroTramite;
        private string nombreReceptor = string.Empty;              
        private string producto = string.Empty;
        private string categoria = string.Empty;
        private string numeroTipoProducto = string.Empty;
        private double valorUFrequeridoBono;
        private double valorUFmontoTraspasoPrima;
       

        #endregion

        #region Propiedades públicas

        /// <summary>
        /// Obtiene o asigna el id de la persona
        /// </summary>
        public string PersonaID
        {
            set { personaID = value; }
            get { return personaID; }
        }

        /// <summary>
        /// Obtiene o asigna el apellido paterno
        /// </summary>
        public string ApellidoPaterno
        {
            set { apellidoPaterno = value; }
            get { return apellidoPaterno; }
        }

        /// <summary>
        /// Obtiene o asigna el apellido materno
        /// </summary>
        public string ApellidoMaterno
        {
            set { apellidoMaterno = value; }
            get { return apellidoMaterno; }
        }

        /// <summary>
        /// Obtiene o asigna los nombres
        /// </summary>
        public string Nombres
        {
            set { nombres = value; }
            get { return nombres; }
        }

        /// <summary>
        /// Obtiene o asigna el tipo de composición primaria
        /// </summary>
        public string TipoComposicionPrimaria
        {
            set { tipoComposicionPrimaria = value; }
            get { return tipoComposicionPrimaria; }
        }

        /// <summary>
        /// Obtiene o asigna el tipo de modalidad
        /// </summary>
        public string TipoModalidad
        {
            set { tipoModalidad = value; }
            get { return tipoModalidad; }
        }

        /// <summary>
        /// Obtiene o asigna el tipo de tramite pension
        /// </summary>
        public string TipoTramitePension
        {
            set { tipoTramitePension = value; }
            get { return tipoTramitePension; }
        }

        /// <summary>
        /// Obtiene o asigna el tipo de seleccion
        /// </summary>
        public string TipoSeleccion
        {
            set { tipoSeleccion = value; }
            get { return tipoSeleccion; }
        }

        /// <summary>
        /// Obtiene o asigna el codigo de compañia de seguros
        /// </summary>
        public int CodigoCiaSeguros
        {
            set { codigoCiaSeguros = value; }
            get { return codigoCiaSeguros; }
        }

        /// <summary>
        /// Obtiene o asigna la fecha de contabilizacion
        /// </summary>
        public string FechaContabilizacion
        {
            set { fechaContabilizacion = value; }
            get { return fechaContabilizacion; }
        }

        /// <summary>
        /// Obtiene o asigna el valor ml saldo
        /// </summary>
        public int ValorMLsaldo
        {
            set { valorMLsaldo = value; }
            get { return valorMLsaldo; }
        }

        /// <summary>
        /// Obtiene o asigna el valor UF de saldo
        /// </summary>
        public double ValorUFsaldo { get; set; }

        /// <summary>
        /// Obtiene o asigna el valor de cuota de saldo
        /// </summary>
        public double ValorCuotaSaldo { get; set; }

        /// <summary>
        /// Obtiene o asigna el tipo de Fondo
        /// </summary>
        public string TipoFondo
        {
            set { tipoFondo = value; }
            get { return tipoFondo; }
        }

        /// <summary>
        /// Obtiene o asigna la fecha de disponibilidad
        /// </summary>
        public string FechaDisponibilidad
        {
            set { fechaDisponibilidad = value; }
            get { return fechaDisponibilidad; }
        }

        /// <summary>
        /// Obtiene o asigna el valor UF total prima
        /// </summary>
        public double ValorUFtotalPrima { get; set; }

        /// <summary>
        /// Obtiene o asigna el id del proceso
        /// </summary>
        public string ProcesoID
        {
            set { procesoID = value; }
            get { return procesoID; }
        }

        /// <summary>
        /// Obtiene o asigna el tipo de trámite
        /// </summary>
        public string TipoTramite
        {
            set { tipoTramite = value; }
            get { return tipoTramite; }
        }

        /// <summary>
        /// Obtiene o asigna el tipo de modalidad dos
        /// </summary>
        public string TipoModalidadDos
        {
            set { tipoModalidadDos = value; }
            get { return tipoModalidadDos; }
        }

        /// <summary>
        /// Obtiene o asigna el valor uf requerido bono
        /// </summary>
        public double ValorUFrequeridoBono 
        {
            set { valorUFrequeridoBono = value; }
            get { return valorUFrequeridoBono; }
        }

        /// <summary>
        /// Obtiene o asigna el valor uf de monto traspaso prima
        /// </summary>
        public double ValorUFmontoTraspasoPrima
        {
            set { valorUFmontoTraspasoPrima = value; }
            get { return valorUFmontoTraspasoPrima; }
        }

        /// <summary>
        /// Obtiene o asigna el valor uf pension vitalicia
        /// </summary>
        public double ValorUFpensionVitalicia { get; set; }

        /// <summary>
        /// Obtiene o asigna el valor uf requerido cuenta prima
        /// </summary>
        public double ValorUFrequeridoCuentaPrima { get; set; }

        /// <summary>
        /// Obtiene o asigna el tipo de via de pago
        /// </summary>
        public string TipoViaPago
        {
            set { tipoViaPago = value; }
            get { return tipoViaPago; }
        }

        /// <summary>
        /// Obtiene o asigna el ide del receptor de pago
        /// </summary>
        public string ReceptorPagoID
        {
            set { receptorPagoID = value; }
            get { return receptorPagoID; }
        }

        /// <summary>
        /// Obtiene o asigna el codigo de la institucion financiera de deposito
        /// </summary>
        public int CodigoInstitucionFinancieraDeposito
        {
            set { codigoInstitucionFinancieraDeposito = value; }
            get { return codigoInstitucionFinancieraDeposito; }
        }

        /// <summary>
        /// Obtiene o asigna el tipo de la cuenta de deposito
        /// </summary>
        public string TipoCuentaDeposito
        {
            set { tipoCuentaDeposito = value; }
            get { return tipoCuentaDeposito; }
        }

        /// <summary>
        /// Obtiene o asigna el numero de la cuenta de deposito
        /// </summary>
        public string NumeroCuentaDeposito
        {
            set { numeroCuentaDeposito = value; }
            get { return numeroCuentaDeposito; }
        }

        /// <summary>
        /// Obtiene o asigna el codigo de la agencia de pago de regimen
        /// </summary>
        public int CodigoAgenciaPagoRegimen
        {
            set { codigoAgenciaPagoRegimen = value; }
            get { return codigoAgenciaPagoRegimen; }
        }

        /// <summary>
        /// Obtiene o asigna la descripcion
        /// </summary>
        public string Descripcion
        {
            set { descripcion = value; }
            get { return descripcion; }
        }

        /// <summary>
        /// Obtiene o asigna la direccion
        /// </summary>
        public string Direccion
        {
            set { direccion = value; }
            get { return direccion; }
        }

        /// <summary>
        /// Obtiene o asigna el codigo de la comuna
        /// </summary>
        public int CodigoComuna
        {
            set { codigoComuna = value; }
            get { return codigoComuna; }
        }

        /// <summary>
        /// Obtiene o asigna la descripcion de la comuna
        /// </summary>
        public string DescripcionComuna
        {
            set { descripcionComuna = value; }
            get { return descripcionComuna; }
        }

        /// <summary>
        /// Obtiene o asigna el id de la region
        /// </summary>
        public int RegionID
        {
            set { regionID = value; }
            get { return regionID; }
        }

        /// <summary>
        /// Obtiene o asigna la descripcion de la region
        /// </summary>
        public string DescripcionRegion
        {
            set { descripcionRegion = value; }
            get { return descripcionRegion; }
        }

        /// <summary>
        /// Obtiene o asigna la ciudad
        /// </summary>
        public string Ciudad
        {
            set { ciudad = value; }
            get { return ciudad; }
        }

        /// <summary>
        /// Obtiene o asigna el porcentaje de descuento
        /// </summary>
        public double PorcentajeDescuento { get; set; }

        /// <summary>
        /// Obtiene o asigna el id del cliente
        /// </summary>
        public int ClienteID
        {
            set { clienteID = value; }
            get { return clienteID; }
        }     

        /// <summary>
        /// Obtiene o asigna el numero de tramite
        /// </summary>
        public int NumeroTramite
        {
            set { numeroTramite = value; }
            get { return numeroTramite; }
        }

        /// <summary>
        /// Obtiene o asigna el producto
        /// </summary>
        public string Producto
        {
            set { producto = value; }
            get { return producto; }
        }

        /// <summary>
        /// Obtiene o asigna TramitePension
        /// </summary>
        public string Categoria
        {
            set { categoria = value; }
            get { return categoria; }
        }

        /// <summary>
        /// Obtiene o asigna el nombre del receptor
        /// </summary>
        public string NombreReceptor
        {
            set { nombreReceptor = value; }
            get { return nombreReceptor; }
        }

        /// <summary>
        /// Obtiene o asigna el nombre del tipo de producto
        /// </summary>
        public string NumeroTipoProducto
        {
            set { numeroTipoProducto = value; }
            get { return numeroTipoProducto; }
        }

        /// <summary>
        /// Obtiene o asigna id institucion financiera
        /// </summary>
        public string InstitucionFinancieraID
        {
            set { institucionFinancieraID = value; }
            get { return institucionFinancieraID; }
        }

        #endregion

        //#region Propiedades repiter

        //public int NroError { get; set; }

        //public string mensaje { get; set; }

        //#endregion
    }
}
