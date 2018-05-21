using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cl.Ing.Pensiones.Beneficios.Bel
{
    public class CargaInformacionCoreExcedenteLibreDisposicion
    {
        #region Miembros

        private string personaID = string.Empty;
        private string apellidoPaterno = string.Empty;
        private string apellidoMaterno = string.Empty;
        private string nombres = string.Empty;
        private string fechaSolicitud = string.Empty;
        private int codigoAgenciaSolicitud;
        private int codigoAgenciaCobro;
        private string indicadorSolicitaSaldoTotal = string.Empty;
        private string fechaAcreditacion = string.Empty;
        private string fechaContabilizacion = string.Empty;
        private string fechaDisponibilidad = string.Empty;
        private int valorMLsaldo;
        private string valorUfSaldo = string.Empty;
        private string tasaImpuesto = string.Empty;
        private string tipoOpcionTributaria = string.Empty;
        private string receptorPagoID = string.Empty;
        private string montoImpuesto = string.Empty;
        private int numeroTramiteExcedente;
        private int numeroTramitePension;
        private int estadoPagoELD;
        private string estadoPago = string.Empty;
        private string tipoTramite = string.Empty;
        private int numeroProducto;
        private int numeroTipoProducto;
        private int numeroTramite;
        private string tipoModalidad = string.Empty;
        private int secuenciaProceso;
        private string procesoID = string.Empty;
        private string procesoPagoID = string.Empty;
        private string receptorPagoID1 = string.Empty;
        private string mandatarioReceptorID = string.Empty;
        private string mandatarioSolicitudID = string.Empty;
        private string tipoOpcionTributariaLibreDisposicion = string.Empty;
        private string tipoTramitePensionLibreDisposicion = string.Empty;
        private int numeroTramiteLibreDisposicion;
        private string indicadorMandatarioRecepcion = string.Empty;
        private string tipoModalidadOrdenPago = string.Empty;
        private string tipoViaPago = string.Empty;
        private string receptorPagoID2 = string.Empty;
        private int codigoInstitucionFinancieraDeposito;
        private string tipoCuentaDeposito = string.Empty;
        private int codigoAgenciaPagoRegimen;
        private string descripcion = string.Empty;
        private string direccion = string.Empty;
        private int codigoComuna;
        private string descripcionComuna = string.Empty;
        private int regionID;
        private string descripcionRegion = string.Empty;
        private string ciudad = string.Empty;
        private int codigoACP;
        private int montoPesosBruto;
        private int montoCuotaBruto;
        private int impuestoPesos;
        private int impuestoCuotas;
        private int folioCheque;
        private int clienteID;
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
        /// Obtiene o asigna el nombre de la persona
        /// </summary>
        public string Nombres
        {
            set { nombres = value; }
            get { return nombres; }
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
        /// Obtiene o asigna el codigo de agencia de solicitud
        /// </summary>
        public int CodigoAgenciaSolicitud
        {
            set { codigoAgenciaSolicitud = value; }
            get { return codigoAgenciaSolicitud; }
        }

        /// <summary>
        /// Obtiene o asigna el codigo de agencia de cobro
        /// </summary>
        public int CodigoAgenciaCobro
        {
            set { codigoAgenciaCobro = value; }
            get { return codigoAgenciaCobro; }
        }

        /// <summary>
        /// Obtiene o asigna el indicador de saldo total
        /// </summary>
        public string IndicadorSolicitaSaldoTotal
        {
            set { indicadorSolicitaSaldoTotal = value; }
            get { return indicadorSolicitaSaldoTotal; }
        }

        /// <summary>
        /// Obtiene o asigna la fecha de acreditacion
        /// </summary>
        public string FechaAcreditacion
        {
            set { fechaAcreditacion = value; }
            get { return fechaAcreditacion; }
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
        /// Obtiene o asigna la fecha de disponibilidad
        /// </summary>
        public string FechaDisponibilidad
        {
            set { fechaDisponibilidad = value; }
            get { return fechaDisponibilidad; }
        }

        /// <summary>
        /// Obtiene o asigna el valor ML de saldo
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
        /// Obtiene o asigna la tasa de impuesto
        /// </summary>
        public double TasaImpuesto { get; set; }

        /// <summary>
        /// Obtiene o asigna el tipo de opcion tributaria
        /// </summary>
        public string TipoOpcionTributaria
        {
            set { tipoOpcionTributaria = value; }
            get { return tipoOpcionTributaria; }
        }

        /// <summary>
        /// Obtiene o asigna el receptor de pago id
        /// </summary>
        public string ReceptorPagoID
        {
            set { receptorPagoID = value; }
            get { return receptorPagoID; }
        }

        /// <summary>
        /// Obtiene o asigna el monto de impuesto
        /// </summary>
        public double MontoImpuesto { get; set; }

        /// <summary>
        /// Obtiene o asigna el numero de tramite excedente
        /// </summary>
        public int NumeroTramiteExcedente
        {
            set { numeroTramiteExcedente = value; }
            get { return numeroTramiteExcedente; }
        }

        /// <summary>
        /// Obtiene o asigna el numero de tramite pension
        /// </summary>
        public int NumeroTramitePension
        {
            set { numeroTramitePension = value; }
            get { return numeroTramitePension; }
        }

        /// <summary>
        /// Obtiene o asigna el estado de pago ELD
        /// </summary>
        public int EstadoPagoELD
        {
            set { estadoPagoELD = value; }
            get { return estadoPagoELD; }
        }

        /// <summary>
        /// Obtiene o asigna el estado de pago
        /// </summary>
        public string EstadoPago
        {
            set { estadoPago = value; }
            get { return estadoPago; }
        }

        /// <summary>
        /// Obtiene o asigna el tipo de tramite
        /// </summary>
        public string TipoTramite
        {
            set { tipoTramite = value; }
            get { return tipoTramite; }
        }

        /// <summary>
        /// Obtiene o asigna el numero de producto
        /// </summary>
        public int NumeroProducto
        {
            set { numeroProducto = value; }
            get { return numeroProducto; }
        }

        /// <summary>
        /// Obtiene o asigna el numero de tipo producto
        /// </summary>
        public int NumeroTipoProducto
        {
            set { numeroTipoProducto = value; }
            get { return numeroTipoProducto; }
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
        /// Obtiene o asigna el tipo de modalidad
        /// </summary>
        public string TipoModalidad
        {
            set { tipoModalidad = value; }
            get { return tipoModalidad; }
        }

        /// <summary>
        /// Obtiene o asigna la secuencua de proceso
        /// </summary>
        public int SecuenciaProceso
        {
            set { secuenciaProceso = value; }
            get { return secuenciaProceso; }
        }

        /// <summary>
        /// Obtiene o asigna el proceso ID
        /// </summary>
        public string ProcesoID
        {
            set { procesoID = value; }
            get { return procesoID; }
        }

        /// <summary>
        /// Obtiene o asigna el proceso de pago id
        /// </summary>
        public string ProcesoPagoID
        {
            set { procesoPagoID = value; }
            get { return procesoPagoID; }
        }

        /// <summary>
        /// Obtiene o asigna el id de receptor de pago 1
        /// </summary>
        public string ReceptorPagoID1
        {
            set { receptorPagoID1 = value; }
            get { return receptorPagoID1; }
        }

        /// <summary>
        /// Obtiene o asigna el id de receptor mandatario
        /// </summary>
        public string MandatarioReceptorID
        {
            set { mandatarioReceptorID = value; }
            get { return mandatarioReceptorID; }
        }

        /// <summary>
        /// Obtiene o asigna el id de solicitud mandatario
        /// </summary>
        public string MandatarioSolicitudID
        {
            set { mandatarioSolicitudID = value; }
            get { return mandatarioSolicitudID; }
        }

        /// <summary>
        /// Obtiene o asigna el tipo de opcion tributaria de libre disposicion
        /// </summary>
        public string TipoOpcionTributariaLibreDisposicion
        {
            set { tipoOpcionTributariaLibreDisposicion = value; }
            get { return tipoOpcionTributariaLibreDisposicion; }
        }

        /// <summary>
        /// Obtiene o asigna el tipo de tramite pension de libre disposicion
        /// </summary>
        public string TipoTramitePensionLibreDisposicion
        {
            set { tipoTramitePensionLibreDisposicion = value; }
            get { return tipoTramitePensionLibreDisposicion; }
        }

        /// <summary>
        /// Obtiene o asigna el numero de tramite de libre disposicion
        /// </summary>
        public int NumeroTramiteLibreDisposicion
        {
            set { numeroTramiteLibreDisposicion = value; }
            get { return numeroTramiteLibreDisposicion; }
        }

        /// <summary>
        /// Obtiene o asigna el indicador de mandatario de recepcion
        /// </summary>
        public string IndicadorMandatarioRecepcion
        {
            set { indicadorMandatarioRecepcion = value; }
            get { return indicadorMandatarioRecepcion; }
        }

        /// <summary>
        /// Obtiene o asigna el tipo de modalidad de origen de pago
        /// </summary>
        public string TipoModalidadOrdenPago
        {
            set { tipoModalidadOrdenPago = value; }
            get { return tipoModalidadOrdenPago; }
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
        public string ReceptorPagoID2
        {
            set { receptorPagoID2 = value; }
            get { return receptorPagoID2; }
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
        /// Obtiene o asigna el tipo de cuenta de deposito
        /// </summary>
        public string TipoCuentaDeposito
        {
            set { tipoCuentaDeposito = value; }
            get { return tipoCuentaDeposito; }
        }

        /// <summary>
        /// Obtiene o asigna el numero de la cuenta deposito
        /// </summary>
        public double NumeroCuentaDeposito { get; set; }

        /// <summary>
        /// Obtiene o asigna el codigo de agencia de pago regimen
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
        /// Obtiene o asigna el codigoACP
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
        public double MontoUFBruto { get; set; }

        /// <summary>
        /// Obtiene o asigna el monto bruto en cuotas
        /// </summary>
        public int MontoCuotaBruto
        {
            set { montoCuotaBruto = value; }
            get { return montoCuotaBruto; }
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
        /// Obtiene o asigna el folio del cheque
        /// </summary>
        public int FolioCheque
        {
            set { folioCheque = value; }
            get { return folioCheque; }
        }

        /// <summary>
        /// Obtiene o asigna el ID del Cliente
        /// </summary>
        public int ClienteID
        {
            set { clienteID = value; }
            get { return clienteID; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string NombreReceptor
        {
            set { nombreReceptor = value; }
            get { return nombreReceptor; }
        }
               
        //public ValidationResults Validacion
        //{
        //    get
        //    {
        //        Validator<CargaInformacionExcedenteLibreDisposicion> validador = ValidationFactory.CreateValidator<CargaInformacionExcedenteLibreDisposicion>(this.ClaveRegla);

        //        return validador.Validate(this);
        //    }
        //}        

        #endregion

        //#region Propiedades repiter

        //public int NroError { get; set; }

        //public string mensaje { get; set; }

        //#endregion

    }
}
