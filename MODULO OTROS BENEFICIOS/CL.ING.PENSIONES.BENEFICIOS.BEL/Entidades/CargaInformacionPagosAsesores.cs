using System;
using Microsoft.Practices.EnterpriseLibrary.Validation;
using Microsoft.Practices.EnterpriseLibrary.Validation.Validators;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cl.Ing.Pensiones.Beneficios.Bel
{
    /// <summary>
    /// Clase que contiene las propiedades de los datos de una estructura
    /// </summary>
    public class CargaInformacionPagosAsesores : ObjetoNegocio
    {

        #region Miembros

            private int pagoAsesorID = 0;
            private int procesoCargaID = 0;
            private string fechaSolicitudComision = String.Empty;
            private string personaID = String.Empty;
            private string apellidoPaterno = String.Empty;
            private string apellidoMaterno = String.Empty;
            private string nombres = String.Empty;
            private int numeroContrato = 0;
            private string rutAsesor = String.Empty;
            private string nombreRazonSocial = String.Empty;
            private string tipoModalidad = String.Empty;
            private string tipoTramite = String.Empty;
            private string viaPago = String.Empty;
            private string tipoViaPago = String.Empty;
            private int codigoAgencia = 0;
            private int codigoAgenciaPrimerPago = 0;
            private int valorMLsaldoDisponible = 0;
            private string fechaAcreditacion = String.Empty;
            private string fechaDisponibilidad = String.Empty;
            private string fechaContabilizacion = String.Empty;
            private string fechaSeleccionModalidad = String.Empty;
            private int periodo = 0;
            private string tipoViaPago2 = String.Empty;
            private string receptorPagoID = String.Empty;
            private int codigoIntFinancieraDeposito = 0;
            private string tipoCuentaDeposito = String.Empty;
            private string numeroCuentaDeposito = String.Empty;
            private int codigoAgenciaPago = 0;
            private string descripcion = String.Empty;
            private string direccion = String.Empty;
            private int codigoComuna = 0;
            private string descripcionComuna = String.Empty;
            private int regionID = 0;
            private string descripcionRegion = String.Empty;
            private string ciudad = String.Empty;
            private int codigoACP = 0;
            private int montoPesosBruto = 0;
            private int montoCoutaBruto = 0;
            private int impuestoPesos = 0;
            private int impuestoCuotas = 0;
            private int folioCheque = 0;
            private int clienteID = 0;
            private int numeroTramite = 0;
            private string nombreReceptor = String.Empty;
            private int cantRegistros = 0;

        #endregion

        #region Propiedades Públicas
        
        /// <summary>
        /// Obtiene o asigna el nombre del receptor
        /// </summary>
        public string NombreReceptor
        {
            set { nombreReceptor = value; }
            get { return nombreReceptor; }
        }

        /// <summary>
        /// Obtiene o asigna el id de Pago de Asesores
        /// </summary>
        public int PagoAsesorID
        {
            set{ pagoAsesorID = value; }
            get{ return pagoAsesorID; }
        }

        /// <summary>
        /// Obtiene o asigna el id de Proceso de carga
        /// </summary>
        public int ProcesoCargaID
        {
            set{ procesoCargaID = value; }
            get{ return procesoCargaID; }
        }

        /// <summary>
        /// Obtiene o asigna la fecha de solicitud de comision
        /// </summary>
        public string FechaSolicitudComision
        {
            set{ fechaSolicitudComision = value; }
            get{ return fechaSolicitudComision; }
        }

        /// <summary>
        /// Obtiene o asigna el id de la persona
        /// </summary>
        public string PersonaID
        {
            set{ personaID = value; }
            get{ return personaID; }
        }

        /// <summary>
        /// Obtiene o asigna el apellido paterno
        /// </summary>
        public string ApellidoPaterno
        {
            set{ apellidoPaterno = value; }
            get{ return apellidoPaterno; }
        }

        /// <summary>
        /// Obtiene o asigna el apellido Materno
        /// </summary>
        public string ApellidoMaterno
        {
            set{ apellidoMaterno = value; }
            get{ return apellidoMaterno; }
        }

        /// <summary>
        /// Obtiene o asigna los nombres
        /// </summary>
        public string Nombres
        {
            set{ nombres = value; }
            get{ return nombres; }
        }

        /// <summary>
        /// Obtiene o asigna el numero de contrato
        /// </summary>
        public int NumeroContrato
        {
            set{ numeroContrato = value; }
            get{ return numeroContrato; }
        }

        /// <summary>
        /// Obtiene o asigna el rut del asesor
        /// </summary>
        public string RutAsesor
        {
            set{ rutAsesor = value; }
            get{ return rutAsesor; }
        }

        /// <summary>
        /// Obtiene o asigna el nombre de la razon social
        /// </summary>
        public string NombreRazonSocial
        {
            set{ nombreRazonSocial = value; }
            get{ return nombreRazonSocial; }
        }

        /// <summary>
        /// Obtiene o asigna el tipo de modalidad
        /// </summary>
        public string TipoModalidad
        {
            set{ tipoModalidad = value; }
            get{ return tipoModalidad; }
        }

        /// <summary>
        /// Obtiene o asigna el tipo de tramite
        /// </summary>
        public string TipoTramite
        {
            set{ tipoTramite = value; }
            get{ return tipoTramite; }
        }

        /// <summary>
        /// Obtiene o asigna la via de pago
        /// </summary>
        public string ViaPago
        {
            set{ viaPago = value; }
            get{ return viaPago; }
        }

        /// <summary>
        /// Obtiene o asigna el tipo de  via de pago
        /// </summary>
        public string TipoViaPago
        {
            set{ tipoViaPago = value; }
            get{ return tipoViaPago; }
        }

        /// <summary>
        /// Obtiene o asigna el codigo de agencia
        /// </summary>
        public int CodigoAgencia
        {
            set{ codigoAgencia = value; }
            get{ return codigoAgencia; }
        }

        /// <summary>
        /// Obtiene o asigna el codigo de agencia del primer pago
        /// </summary>
        public int CodigoAgenciaPrimerPago
        {
            set{ codigoAgenciaPrimerPago = value; }
            get{ return codigoAgenciaPrimerPago; }
        }

        /// <summary>
        /// Obtiene o asigna el valor de saldo disponible
        /// </summary>
        public int ValorMLsaldoDisponible
        {
            set{ valorMLsaldoDisponible = value; }
            get{ return valorMLsaldoDisponible; }
        }

        /// <summary>
        /// Obtiene o asigna el valor UF de saldo disponible
        /// </summary>
        public double ValorUFsaldoDisponible { get; set; }

        /// <summary>
        /// Obtiene o asigna la fecha de acreditacion
        /// </summary>
        public string FechaAcreditacion
        {
            set{ fechaAcreditacion = value; }
            get{ return fechaAcreditacion; }
        }

        /// <summary>
        /// Obtiene o asigna la fecha de disponibilidad
        /// </summary>
        public string FechaDisponibilidad
        {
            set{ fechaDisponibilidad = value; }
            get{ return fechaDisponibilidad; }
        }

        /// <summary>
        /// Obtiene o asigna la fecha de contabilizacion
        /// </summary>
        public string FechaContabilizacion
        {
            set{ fechaContabilizacion = value; }
            get{ return fechaContabilizacion; }
        }

        /// <summary>
        /// Obtiene o asigna el porcentaje de comision RP consumida
        /// </summary>
        public double PorcentajeComisionRPconsumida { get; set; }

        /// <summary>
        /// Obtiene o asigna la fecha de seleccion de modalidad
        /// </summary>
        public string FechaSeleccionModalidad
        {
            set{ fechaSeleccionModalidad = value; }
            get{ return fechaSeleccionModalidad; }
        }

        /// <summary>
        /// Obtiene o asigna el Periodo
        /// </summary>
        public int Periodo
        {
            set{ periodo = value; }
            get{ return periodo; }
        }

        /// <summary>
        /// Obtiene o asigna el tipo de via de pago 2
        /// </summary>
        public string TipoViaPago2
        {
            set{ tipoViaPago2 = value; }
            get{ return tipoViaPago2; }
        }

        /// <summary>
        /// Obtiene o asigna el id del receptor de pago
        /// </summary>
        public string ReceptorPagoID
        {
            set{ receptorPagoID = value; }
            get{ return receptorPagoID; }
        }

        /// <summary>
        /// Obtiene o asigna el codigo de la institucion financiera de depostio
        /// </summary>
        public int CodigoIntFinancieraDeposito
        {
            set{ codigoIntFinancieraDeposito = value; }
            get{ return codigoIntFinancieraDeposito; }
        }

        /// <summary>
        /// Obtiene o asigna el tipo de la cuenta deposito
        /// </summary>
        public string TipoCuentaDeposito
        {
            set{ tipoCuentaDeposito = value; }
            get{ return tipoCuentaDeposito; }
        }

        /// <summary>
        /// Obtiene o asigna el numero de la cuenta de deposito
        /// </summary>
        public string NumeroCuentaDeposito
        {
            set{ numeroCuentaDeposito = value; }
            get{ return numeroCuentaDeposito; }
        }

        /// <summary>
        /// Obtiene o asigna el codigo de agencia de pago
        /// </summary>
        public int CodigoAgenciaPago
        {
            set{ codigoAgenciaPago = value; }
            get{ return codigoAgenciaPago; }
        }

        /// <summary>
        /// Obtiene o asigna la descripcion
        /// </summary>
        public string Descripcion
        {
            set{ descripcion = value; }
            get{ return descripcion; }
        }

        /// <summary>
        /// Obtiene o asigna la direccion
        /// </summary>
        public string Direccion
        {
            set{ direccion = value; }
            get{ return direccion; }
        }

        /// <summary>
        /// Obtiene o asigna el codigo de la comuna
        /// </summary>
        public int CodigoComuna
        {
            set{ codigoComuna = value; }
            get{ return codigoComuna; }
        }

        /// <summary>
        /// Obtiene o asigna la descripcion de la comuna
        /// </summary>
        public string DescripcionComuna
        {
            set{ descripcionComuna = value; }
            get{ return descripcionComuna; }
        }

        /// <summary>
        /// Obtiene o asigna el id de la region
        /// </summary>
        public int RegionID
        {
            set{ regionID = value; }
            get{ return regionID; }
        }

        /// <summary>
        /// Obtiene o asigna la descripcion de la region
        /// </summary>
        public string DescripcionRegion
        {
            set{ descripcionRegion = value; }
            get{ return descripcionRegion; }
        }

        /// <summary>
        /// Obtiene o asigna la ciudad
        /// </summary>
        public string Ciudad
        {
            set{ ciudad = value; }
            get{ return ciudad; }
        }

        /// <summary>
        /// Obtiene o asigna el codigo ACP
        /// </summary>
        public int CodigoACP
        {
            set{ codigoACP = value; }
            get{ return codigoACP; }
        }

        /// <summary>
        /// Obtiene o asigna el monto bruto en pesos
        /// </summary>
        public int MontoPesosBruto
        {
            set{ montoPesosBruto = value; }
            get{ return montoPesosBruto; }
        }

        /// <summary>
        /// Obtiene o asigna el monto bruto en UF
        /// </summary>
        public double MontoUFBruto { get; set; }

        /// <summary>
        /// Obtiene o asigna el monto bruto en cuotas
        /// </summary>
        public int MontoCoutaBruto
        {
            set{ montoCoutaBruto = value; }
            get{ return montoCoutaBruto; }
        }

        /// <summary>
        /// Obtiene o asigna el impuesto en pesos
        /// </summary>
        public int ImpuestoPesos
        {
            set{ impuestoPesos = value; }
            get{ return impuestoPesos; }
        }

        /// <summary>
        /// Obtiene o asigna el impuesto en cuotas
        /// </summary>
        public int ImpuestoCuotas
        {
            set{ impuestoCuotas = value; }
            get{ return impuestoCuotas; }
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
            set{ folioCheque = value; }
            get{ return folioCheque; }
        }

        /// <summary>
        /// Obtiene o asigna el Id del Cliente
        /// </summary>
        public int ClienteID
        {
            set{ clienteID = value; }
            get{ return clienteID; }
        }

        /// <summary>
        /// Obtiene la cantidad de registros acreditados
        /// </summary>
        public int CantRegistros
        {
            set { cantRegistros = value; }
            get { return cantRegistros; }
        }

        /// <summary>
        /// Obtiene o asigna el Numero del tramite
        /// </summary>
        public int NumeroTramite
        {
            set{ numeroTramite = value; }
            get{ return numeroTramite; }
        }

         
        public ValidationResults Validacion
        {
            get
            {
                Validator<CargaInformacionPagosAsesores> validador = ValidationFactory.CreateValidator<CargaInformacionPagosAsesores>(this.ClaveRegla);

                return validador.Validate(this);
            }
        }        
        
        #endregion

        #region Constructor

        /// <summary>
        /// Crea una nueva instancia de la clase CargaInformacionPagosAsesores
        /// </summary>
        public CargaInformacionPagosAsesores()
        {
            this.ClaveRegla = "ReglasEntidadCargaInformacionPagosAsesores";
        }

        #endregion
    }
}
