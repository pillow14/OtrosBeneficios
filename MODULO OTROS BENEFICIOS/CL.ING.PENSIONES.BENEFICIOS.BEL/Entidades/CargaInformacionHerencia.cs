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
    public class CargaInformacionHerencia : ObjetoNegocio
    {

        #region Miembros

            private int beneficioHerenciaID = 0;
            private string personaID = String.Empty;
            private string apellidoPaterno = String.Empty;
            private string apellidoMaterno = String.Empty;
            private string nombres = String.Empty;
            private string fechaSolicitud = String.Empty;
            private string fechaAcreditacion = String.Empty;
            private string fechaContabilizacion = String.Empty;
            private string fechaDisponibilidad = String.Empty;
            private string receptorPagoID = String.Empty;
            private string fechaPago = String.Empty;
            private int numeroChequePago = 0;
            private int codigoAgenciaSolicitud = 0;
            private string tipoTramite = String.Empty;
            private string tipoViaPago = String.Empty;
            private string receptorPagoID1 = String.Empty;
            private int codigoInstitucionFinacieraDeposito = 0;
            private string numeroCuentaDeposito = String.Empty;
            private int codigoAgenciaPagoRegimen = 0;
            private string descripcion = String.Empty;
            private string direccion = String.Empty;
            private int codigoComuna = 0;
            private string descripcionComuna = String.Empty;
            private int regionID = 0;
            private string descripcionRegion = String.Empty;
            private string ciudad = String.Empty;
            private string tipoModalidad = String.Empty;
            private int codigoACP = 0;
            private int montoPesosBruto = 0;
            private int montoCuotaBruto = 0;
            private int impuestoPesos = 0;
            private int impuestoCuotas = 0;
            private int folioCheque = 0;
            private string tipoCuentaDeposito = String.Empty;
            private int procesoCargaID = 0;
            private string tipoPension = String.Empty;
            private string cuentaUsuario = String.Empty;
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
        /// Obtiene o asigna el id de Beneficio Herencia
        /// </summary>
        public int BeneficioHerenciaID
        {
            set{ beneficioHerenciaID = value; }
            get{ return beneficioHerenciaID; }
        }

        /// <summary>
        /// Obtiene o asigna el id de la Persona
        /// </summary>
        public string PersonaID
        {
            set{ personaID = value; }
            get{ return personaID; }
        }

        /// <summary>
        /// Obtiene o asigna el Apellido Paterno
        /// </summary>
        public string ApellidoPaterno
        {
            set{ apellidoPaterno = value; }
            get{ return apellidoPaterno; }
        }

        /// <summary>
        /// Obtiene o asigna el Apellido Materno
        /// </summary>
        public string ApellidoMaterno
        {
            set{ apellidoMaterno = value; }
            get{ return apellidoMaterno; }
        }

        /// <summary>
        /// Obtiene o asigna los Nombres
        /// </summary>
        public string Nombres
        {
            set{ nombres = value; }
            get{ return nombres; }
        }

        /// <summary>
        /// Obtiene o asigna la Fecha de Solicitud
        /// </summary>
        public string FechaSolicitud
        {
            set{ fechaSolicitud = value; }
            get{ return fechaSolicitud; }
        }

        /// <summary>
        /// Obtiene o asigna la Fecha de Acreditacion
        /// </summary>
        public string FechaAcreditacion
        {
            set{ fechaAcreditacion = value; }
            get{ return fechaAcreditacion; }
        }

        /// <summary>
        /// Obtiene o asigna la Fecha de Contabilización
        /// </summary>
        public string FechaContabilizacion
        {
            set{ fechaContabilizacion = value; }
            get{ return fechaContabilizacion; }
        }

        /// <summary>
        /// Obtiene o asigna la Fecha de Disponibilidad
        /// </summary>
        public string FechaDisponibilidad
        {
            set{ fechaDisponibilidad = value; }
            get{ return fechaDisponibilidad; }
        }

        /// <summary>
        /// Obtiene o asigna el valor ML Saldo
        /// </summary>
        public double ValorMLSaldo { get; set; }

        /// <summary>
        /// Obtiene o asigna el valor de UF de Saldo
        /// </summary>
        public double ValorUFSaldo { get; set; }

        /// <summary>
        /// Obtiene o asigna el Receptor de Pago ID
        /// </summary>
        public string ReceptorPagoID
        {
            set{ receptorPagoID = value; }
            get{ return receptorPagoID; }
        }

        /// <summary>
        /// Obtiene o asigna la Fecha de Pago
        /// </summary>
        public string FechaPago
        {
            set{ fechaPago = value; }
            get{ return fechaPago; }
        }

        /// <summary>
        /// Obtiene o asigna el número de Cheque de pago
        /// </summary>
        public int NumeroChequePago
        {
            set{ numeroChequePago = value; }
            get{ return numeroChequePago; }
        }

        /// <summary>
        /// Obtiene o asigna el codigo de agencia de solicitud
        /// </summary>
        public int CodigoAgenciaSolicitud
        {
            set{ codigoAgenciaSolicitud = value; }
            get{ return codigoAgenciaSolicitud; }
        }

        /// <summary>
        /// Obtiene o asigna el tipo de Trámite
        /// </summary>
        public string TipoTramite
        {
            set{ tipoTramite = value; }
            get{ return tipoTramite; }
        }

        /// <summary>
        /// Obtiene o asigna el Tipo de Via de pago
        /// </summary>
        public string TipoViaPago
        {
            set{ tipoViaPago = value; }
            get{ return tipoViaPago; }
        }

        /// <summary>
        /// Obtiene o asigna el Receptor de pago ID 1
        /// </summary>
        public string ReceptorPagoID1
        {
            set{ receptorPagoID1 = value; }
            get{ return receptorPagoID1; }
        }

        /// <summary>
        /// Obtiene o asigna el Codigo de la institucion financiera deposito
        /// </summary>
        public int CodigoInstitucionFinacieraDeposito
        {
            set{ codigoInstitucionFinacieraDeposito = value; }
            get{ return codigoInstitucionFinacieraDeposito; }
        }

        /// <summary>
        /// Obtiene o asigna el Numero de cuenta de deposito
        /// </summary>
        public string NumeroCuentaDeposito
        {
            set{ numeroCuentaDeposito = value; }
            get{ return numeroCuentaDeposito; }
        }

        /// <summary>
        /// Obtiene o asigna el Codigo de Agencia de Pago de Regimen
        /// </summary>
        public int CodigoAgenciaPagoRegimen
        {
            set{ codigoAgenciaPagoRegimen = value; }
            get{ return codigoAgenciaPagoRegimen; }
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
        /// Obtiene o asigna la Ciudad
        /// </summary>
        public string Ciudad
        {
            set{ ciudad = value; }
            get{ return ciudad; }
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
        /// Obtiene o asigna el Codigo ACP
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
        /// Obtiene o asigna el monto bruto en cuota
        /// </summary>
        public int MontoCuotaBruto
        {
            set{ montoCuotaBruto = value; }
            get{ return montoCuotaBruto; }
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
        /// Obtiene o asigna el folio Cheque
        /// </summary>
        public int FolioCheque
        {
            set{ folioCheque = value; }
            get{ return folioCheque; }
        }

        /// <summary>
        /// Obtiene o asigna el tipo de Cuenta deposito
        /// </summary>
        public string TipoCuentaDeposito
        {
            set{ tipoCuentaDeposito = value; }
            get{ return tipoCuentaDeposito; }
        }

        /// <summary>
        /// Obtiene o asigna el proceso de carga ID
        /// </summary>
        public int ProcesoCargaID
        {
            set{ procesoCargaID = value; }
            get{ return procesoCargaID; }
        }

        /// <summary>
        /// Obtiene o asigna el Tipo de Pension
        /// </summary>
        public string TipoPension
        {
            set{ tipoPension = value; }
            get{ return tipoPension; }
        }

        /// <summary>
        /// Obtiene o asigna la cuenta del usuario
        /// </summary>
        public string CuentaUsuario
        {
            set{ cuentaUsuario = value; }
            get{ return cuentaUsuario; }
        }

        /// <summary>
        /// Obtiene o asigna el ID del Cliente
        /// </summary>
        public int ClienteID
        {
            set{ clienteID = value; }
            get{ return clienteID; }
        }

        /// <summary>
        /// Obtiene o asigna el proceso de carga ID
        /// </summary>
        public int NumeroTramite
        {
            set{ numeroTramite = value; }
            get{ return numeroTramite; }
        }

        /// <summary>
        /// Obtiene o asigna la cantidad de registros sin agrupar
        /// </summary>
        public int CantRegistros
        {
            set { cantRegistros = value; }
            get { return cantRegistros; }
        }
         
        public ValidationResults Validacion
        {
            get
            {
                Validator<CargaInformacionHerencia> validador = ValidationFactory.CreateValidator<CargaInformacionHerencia>(this.ClaveRegla);

                return validador.Validate(this);
            }
        }        
        
        #endregion

        #region Constructor

        /// <summary>
        /// Crea una nueva instancia de la clase CargaInformacionHerencia
        /// </summary>
        public CargaInformacionHerencia()
        {
            this.ClaveRegla = "ReglasEntidadCargaInformacionHerencia";
        }

        #endregion
    }
}
