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
    public class CargaTraspasoPrimaUno : ObjetoNegocio
    {

        #region Miembros

            private int traspasoPrimaUnoID = 0;
            private int prcesoCargaID = 0;
            private string personaID = string.Empty;
            private string apellidoPaterno = string.Empty;
            private string apellidoMaterno = string.Empty;
            private string nombres = string.Empty;
            private string tipoComposicionPrimaria = string.Empty;
            private string tipoModalidad = string.Empty;
            private string tipoTramitePension = string.Empty;
            private string tipoSeleccion = string.Empty;
            private int codigoCiaSeguros = 0;
            private string fechaContabilizacion = string.Empty;
            private int valorMLsaldo = 0;
            private string tipoFondo = string.Empty;
            private string fechaDisponibilidad = string.Empty;
            private string procesoID = string.Empty;
            private string tipoTramite = string.Empty;
            private string tipoModalidadDos = string.Empty;
            private string tipoViaPago = string.Empty;
            private string receptorPagoID = string.Empty;
            private int codigoInstitucionFinancieraDeposito = 0;
            private string tipoCuentaDeposito = string.Empty;
            private string numeroCuentaDeposito = string.Empty;
            private int codigoAgenciaPagoRegimen = 0;
            private string descripcion = string.Empty;
            private string direccion = string.Empty;
            private int codigoComuna = 0;
            private string descripcionComuna = string.Empty;
            private int regionID = 0;
            private string descripcionRegion = string.Empty;
            private string ciudad = string.Empty;
            private int clienteID = 0;
            private int numeroTramite = 0;
            private string nombreReceptor = string.Empty;
            private int cantRegistros = 0;

            //Miembros adicionados para Requerimiento RQ-1731//
            private string producto = string.Empty;
            private string categoria = string.Empty;
            

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
        /// Obtiene o asigna el id de Traspaso Prima Uno
        /// </summary>
        public int TraspasoPrimaUnoID
        {
            set{ traspasoPrimaUnoID = value; }
            get{ return traspasoPrimaUnoID; }
        }

        /// <summary>
        /// Obtiene o asigna el id del proceso de carga
        /// </summary>
        public int PrcesoCargaID
        {
            set{ prcesoCargaID = value; }
            get{ return prcesoCargaID; }
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
        /// Obtiene o asigna el apellido materno
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
        /// Obtiene o asigna el tipo de composición primaria
        /// </summary>
        public string TipoComposicionPrimaria
        {
            set{ tipoComposicionPrimaria = value; }
            get{ return tipoComposicionPrimaria; }
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
        /// Obtiene o asigna el tipo de tramite pension
        /// </summary>
        public string TipoTramitePension
        {
            set{ tipoTramitePension = value; }
            get{ return tipoTramitePension; }
        }

        /// <summary>
        /// Obtiene o asigna el tipo de seleccion
        /// </summary>
        public string TipoSeleccion
        {
            set{ tipoSeleccion = value; }
            get{ return tipoSeleccion; }
        }

        /// <summary>
        /// Obtiene o asigna el codigo de compañia de seguros
        /// </summary>
        public int CodigoCiaSeguros
        {
            set{ codigoCiaSeguros = value; }
            get{ return codigoCiaSeguros; }
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
        /// Obtiene o asigna el valor ml saldo
        /// </summary>
        public int ValorMLsaldo
        {
            set{ valorMLsaldo = value; }
            get{ return valorMLsaldo; }
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
            set{ tipoFondo = value; }
            get{ return tipoFondo; }
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
        /// Obtiene o asigna el valor UF total prima
        /// </summary>
        public double ValorUFtotalPrima { get; set; }

        /// <summary>
        /// Obtiene o asigna el id del proceso
        /// </summary>
        public string ProcesoID
        {
            set{ procesoID = value; }
            get{ return procesoID; }
        }

        /// <summary>
        /// Obtiene o asigna el tipo de trámite
        /// </summary>
        public string TipoTramite
        {
            set{ tipoTramite = value; }
            get{ return tipoTramite; }
        }

        /// <summary>
        /// Obtiene o asigna el tipo de modalidad dos
        /// </summary>
        public string TipoModalidadDos
        {
            set{ tipoModalidadDos = value; }
            get{ return tipoModalidadDos; }
        }

        /// <summary>
        /// Obtiene o asigna el valor uf requerido bono
        /// </summary>
        public double ValorUFrequeridoBono { get; set; }

        /// <summary>
        /// Obtiene o asigna el valor uf de monto traspaso prima
        /// </summary>
        public double ValorUFmontoTraspasoPrima { get; set; }

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
            set{ tipoViaPago = value; }
            get{ return tipoViaPago; }
        }

        /// <summary>
        /// Obtiene o asigna el ide del receptor de pago
        /// </summary>
        public string ReceptorPagoID
        {
            set{ receptorPagoID = value; }
            get{ return receptorPagoID; }
        }

        /// <summary>
        /// Obtiene o asigna el codigo de la institucion financiera de deposito
        /// </summary>
        public int CodigoInstitucionFinancieraDeposito
        {
            set{ codigoInstitucionFinancieraDeposito = value; }
            get{ return codigoInstitucionFinancieraDeposito; }
        }

        /// <summary>
        /// Obtiene o asigna el tipo de la cuenta de deposito
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
        /// Obtiene o asigna el codigo de la agencia de pago de regimen
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
        /// Obtiene o asigna la ciudad
        /// </summary>
        public string Ciudad
        {
            set{ ciudad = value; }
            get{ return ciudad; }
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
        /// Obtiene o asigna el numero de tramite
        /// </summary>
        public int NumeroTramite
        {
            set{ numeroTramite = value; }
            get{ return numeroTramite; }
        }

        //Propiedades adicionadas segun Requerimiento RQ-1731//
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
        

        public ValidationResults Validacion
        {
            get
            {
                Validator<CargaTraspasoPrimaUno> validador = ValidationFactory.CreateValidator<CargaTraspasoPrimaUno>(this.ClaveRegla);

                return validador.Validate(this);
            }
        }        
        
        #endregion

        #region Constructor

        /// <summary>
        /// Crea una nueva instancia de la clase CargaTraspasoPrimaUno
        /// </summary>
        public CargaTraspasoPrimaUno()
        {
            this.ClaveRegla = "ReglasEntidadCargaTraspasoPrimaUno";
        }

        #endregion
    }
}
