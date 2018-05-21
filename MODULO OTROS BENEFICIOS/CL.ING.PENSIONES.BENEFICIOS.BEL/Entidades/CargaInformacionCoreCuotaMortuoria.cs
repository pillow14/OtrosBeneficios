using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cl.Ing.Pensiones.Beneficios.Bel
{
    public class CargaInformacionCoreCuotaMortuoria
    {
        #region Miembros

        private string personaID = string.Empty;
        private string apellidoPaterno = string.Empty;
        private string apellidoMaterno = string.Empty;
        private string nombres = string.Empty;
        private int codigoAgencia;
        private string tipoTramitePension = string.Empty;
        private string fechaContabilizacion = string.Empty;
        private string fechaDisponibilidad = string.Empty;
        private string fechaSolicitud = string.Empty;
        private string solicitanteID = string.Empty;
        private string apellidoPaternoSolicitante = string.Empty;
        private string apellidoMaternoSolicitante = string.Empty;
        private string nombresSolicitante = string.Empty;
        private string tipoViaPago = string.Empty;
        private string receptorPagoID = string.Empty;
        private int codigoInstitucionFinancieraDeposito;
        private int tipoCuentaDeposito;
        private string numeroCuentaDeposito = string.Empty;
        private int codigoAgenciaRegimen;
        private string descripcion = string.Empty;
        private string direccion = string.Empty;
        private int codigoComuna;
        private string descripcionComuna = string.Empty;
        private int regionID;
        private string descripcionRegion = string.Empty;
        private string ciudad = string.Empty;
        private string tipoModalidad = string.Empty;
        private int codigoACP;
        private int montoPesosBruto;
        private string montoUfBruto = string.Empty;
        private int montoCoutaBruto;
        private int impuestoPesos;
        private int impuestoCuotas;
        private int folioCheque;
        private string tipoPension = string.Empty;
        private string cuentaUsuario = string.Empty;
        private int clienteID;
        private int numeroTramite;
        private int cantidadAcreditados;
        private string nombreReceptor = string.Empty;

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
        /// Obtiene o asigna el codigo de la agencia
        /// </summary>
        public int CodigoAgencia
        {
            set { codigoAgencia = value; }
            get { return codigoAgencia; }
        }

        /// <summary>
        /// Obtiene o asigna el valor ML saldo
        /// </summary>
        public double ValorMLSaldo { get; set; }

        /// <summary>
        /// Obtiene o asigna el valor UF de saldo
        /// </summary>
        public double ValorUFSaldo { get; set; }

        /// <summary>
        /// Obtiene o asigna el tipo de pension
        /// </summary>
        public string TipoTramitePension
        {
            set { tipoTramitePension = value; }
            get { return tipoTramitePension; }
        }

        /// <summary>
        /// Obtiene o asigna la fecha de contabilidad
        /// </summary>
        public string FechaContabilizacion
        {
            set { fechaContabilizacion = value; }
            get { return fechaContabilizacion; }
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
        /// Obtiene o asigna la fecha de solicitud
        /// </summary>
        public string FechaSolicitud
        {
            set { fechaSolicitud = value; }
            get { return fechaSolicitud; }
        }

        /// <summary>
        /// Obtiene o asigna el id del solicitante
        /// </summary>
        public string SolicitanteID
        {
            set { solicitanteID = value; }
            get { return solicitanteID; }
        }

        /// <summary>
        /// Obtiene o asigna el apellido paterno del solicitante
        /// </summary>
        public string ApellidoPaternoSolicitante
        {
            set { apellidoPaternoSolicitante = value; }
            get { return apellidoPaternoSolicitante; }
        }

        /// <summary>
        /// Obtiene o asigna el apellido materno del solicitante
        /// </summary>
        public string ApellidoMaternoSolicitante
        {
            set { apellidoMaternoSolicitante = value; }
            get { return apellidoMaternoSolicitante; }
        }

        /// <summary>
        /// Obtiene o asigna el apellido paterno del solicitante
        /// </summary>
        public string NombresSolicitante
        {
            set { nombresSolicitante = value; }
            get { return nombresSolicitante; }
        }

        /// <summary>
        /// Obtiene o asigna el tipo de via de pago
        /// </summary>
        public string TipoViaPago
        {
            set { tipoViaPago = value; }
            get { return tipoViaPago; }
        }

        /// <summary>
        /// Obtiene o asigna el id del receptor de pago
        /// </summary>
        public string ReceptorPagoID
        {
            set { receptorPagoID = value; }
            get { return receptorPagoID; }
        }

        /// <summary>
        /// Obtiene o asigna el codigo de la institucion financiera de depostio
        /// </summary>
        public int CodigoInstitucionFinancieraDeposito
        {
            set { codigoInstitucionFinancieraDeposito = value; }
            get { return codigoInstitucionFinancieraDeposito; }
        }

        /// <summary>
        /// Obtiene o asigna el tipo de la cuenta deposito
        /// </summary>
        public int TipoCuentaDeposito
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
        /// Obtiene o asigna el codigo de agencia de regimen
        /// </summary>
        public int CodigoAgenciaRegimen
        {
            set { codigoAgenciaRegimen = value; }
            get { return codigoAgenciaRegimen; }
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
        /// Obtiene o asigna el el tipo de modalidad
        /// </summary>
        public string TipoModalidad
        {
            set { tipoModalidad = value; }
            get { return tipoModalidad; }
        }

        /// <summary>
        /// Obtiene o asigna el codigo ACP
        /// </summary>
        public int CodigoACP
        {
            set { codigoACP = value; }
            get { return codigoACP; }
        }

        /// <summary>
        /// Obtiene o asigna el monto bruto en pesos
        /// </summary>
        public int MontoPesosBruto
        {
            set { montoPesosBruto = value; }
            get { return montoPesosBruto; }
        }

        /// <summary>
        /// Obtiene o asigna el monto bruto en UF
        /// </summary>
        public string MontoUFBruto 
        {
            set { montoUfBruto = value; }
            get { return montoUfBruto; }
        }

        /// <summary>
        /// Obtiene o asigna el monto bruto en cuotas
        /// </summary>
        public int MontoCoutaBruto
        {
            set { montoCoutaBruto = value; }
            get { return montoCoutaBruto; }
        }

        /// <summary>
        /// Obtiene o asigna el impuesto en pesos
        /// </summary>
        public int ImpuestoPesos
        {
            set { impuestoPesos = value; }
            get { return impuestoPesos; }
        }

        /// <summary>
        /// Obtiene o asigna el impuesto en cuotas
        /// </summary>
        public int ImpuestoCuotas
        {
            set { impuestoCuotas = value; }
            get { return impuestoCuotas; }
        }

        /// <summary>
        /// Obtiene o asigna el impuesto en UF
        /// </summary>
        public double ImpuestoUF { get; set; }

        /// <summary>
        /// Obtiene o asigna el Folio de cheque
        /// </summary>
        public int FolioCheque
        {
            set { folioCheque = value; }
            get { return folioCheque; }
        }

        /// <summary>
        /// Obtiene o asigna el tipo de pension
        /// </summary>
        public string TipoPension
        {
            set { tipoPension = value; }
            get { return tipoPension; }
        }

        /// <summary>
        /// Obtiene o asigna la cuenta del usuario
        /// </summary>
        public string CuentaUsuario
        {
            set { cuentaUsuario = value; }
            get { return cuentaUsuario; }
        }

        /// <summary>
        /// Obtiene o asigna el ID del cliente
        /// </summary>
        public int ClienteID
        {
            set { clienteID = value; }
            get { return clienteID; }
        }

        /// <summary>
        /// Obtiene o asigna el Numero del Tramite
        /// </summary>
        public int NumeroTramite
        {
            set { numeroTramite = value; }
            get { return numeroTramite; }
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
        /// Obtiene o asigna el Numero del registros Acreditados
        /// </summary>
        public int CantidadAcreditados
        {
            set { cantidadAcreditados = value; }
            get { return cantidadAcreditados; }
        }

        //public ValidationResults Validacion
        //{
        //    get
        //    {
        //        Validator<CargaInformacionCuotaMortuaria> validador = ValidationFactory.CreateValidator<CargaInformacionCuotaMortuaria>(this.claveRegla);

        //        return validador.Validate(this);
        //    }
        //}        

        #endregion

        //#region Propiedades Repiter

        //public int NroError { get; set; }

        //public string mensaje { get; set; }

        //#endregion
    }
}
