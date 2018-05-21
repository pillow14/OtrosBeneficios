using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cl.Ing.Pensiones.Beneficios.Bel
{
    public class SolicitudPagoTesoreria : ObjetoNegocio
    {

        #region Miembros

            private string marca = String.Empty;
            private string rut = String.Empty;
            private string digitoVerificador = String.Empty;
            private string nombre = String.Empty;
            private string monto = String.Empty;
            private string codigoSucursal = String.Empty;
            private string nombreSucursal = String.Empty;
            private string codigoCentroCosto = String.Empty;
            private string nombreCentroCosto = String.Empty;
            private string codigoCargo = String.Empty;
            private string nombreCargo = String.Empty;
            private string codigoBanco = String.Empty;
            private string nombreBanco = String.Empty;
            private string numeroCuentaCorriente = String.Empty;
            private string proceso = String.Empty;
            private int RescataVoucher;
            private int _IdRegistro;
            private int numeroSolicitud;
            private string tipoSolicitud;
            private int numeroVoucher;
            private string cuentaUsuario;
            private string procesoCargaID;

            private string rutCausante = String.Empty;
            private string digitoVerificadorCausante = String.Empty;


        #endregion

        #region Propiedades Públicas

            /// <summary>
            /// Obtiene o establece Id_Registro
            /// </summary>
            public int IdRegistro
            {
                set { _IdRegistro = value; }
                get { return _IdRegistro; }
            }

        /// <summary>
        /// Obtiene o establece la Marca
        /// </summary>
        public string Marca
        {
            set{ marca = value; }
            get{ return marca; }
        }

        /// <summary>
        /// Obtiene o establece el Rut
        /// </summary>
        public string Rut
        {
            set{ rut = value; }
            get{ return rut; }
        }

        /// <summary>
        /// Obtiene o establece el digito verificador
        /// </summary>
        public string DigitoVerificador
        {
            set{ digitoVerificador = value; }
            get{ return digitoVerificador; }
        }

        /// <summary>
        /// Obtiene o establece el nombre
        /// </summary>
        public string Nombre
        {
            set{ nombre = value; }
            get{ return nombre; }
        }

        /// <summary>
        /// Obtiene o establece el monto
        /// </summary>
        public string Monto
        {
            set{ monto = value; }
            get{ return monto; }
        }

        /// <summary>
        /// Obtiene o establece Codigo Sucursal
        /// </summary>
        public string CodigoSucursal
        {
            set{ codigoSucursal = value; }
            get{ return codigoSucursal; }
        }

        /// <summary>
        /// Obtiene o establece el nombre de la sucursal
        /// </summary>
        public string NombreSucursal
        {
            set{ nombreSucursal = value; }
            get{ return nombreSucursal; }
        }

        /// <summary>
        /// Obtiene o establece el codigo del centro de costo
        /// </summary>
        public string CodigoCentroCosto
        {
            set{ codigoCentroCosto = value; }
            get{ return codigoCentroCosto; }
        }

        /// <summary>
        /// Obtiene o establece el nombre del centro de costo
        /// </summary>
        public string NombreCentroCosto
        {
            set{ nombreCentroCosto = value; }
            get{ return nombreCentroCosto; }
        }

        /// <summary>
        /// Obtiene o establece el codigo del cargo
        /// </summary>
        public string CodigoCargo
        {
            set{ codigoCargo = value; }
            get{ return codigoCargo; }
        }

        /// <summary>
        /// Obtiene o establece el nombre del cargo
        /// </summary>
        public string NombreCargo
        {
            set{ nombreCargo = value; }
            get{ return nombreCargo; }
        }

        /// <summary>
        /// Obtiene o establece el codigo de banco
        /// </summary>
        public string CodigoBanco
        {
            set{ codigoBanco = value; }
            get{ return codigoBanco; }
        }

        /// <summary>
        /// Obtiene o establece el nombre del banco
        /// </summary>
        public string NombreBanco
        {
            set{ nombreBanco = value; }
            get{ return nombreBanco; }
        }

        /// <summary>
        /// Obtiene o establece el numero de la cuenta corriente
        /// </summary>
        public string NumeroCuentaCorriente
        {
            set{ numeroCuentaCorriente = value; }
            get{ return numeroCuentaCorriente; }
        }

        /// <summary>
        /// Obtiene o establece la fecha de contabilizacion
        /// </summary>
        public String FechaContabilizacion { get; set; }

        /// <summary>
        /// Obtiene o establece el Proceso
        /// </summary>
        public string Proceso
        {
            set{ proceso = value; }
            get{ return proceso; }
        }

        /// <summary>
        /// Obtiene o establece el Voucher
        /// </summary>
        public int Voucher
        {
            set { RescataVoucher = value; }
            get { return RescataVoucher; }
        }

        /// <summary>
        /// Obtiene o establece el numero de solicitud
        /// </summary>
        public int NumeroSolicitud
        {
            set { numeroSolicitud = value; }
            get { return numeroSolicitud; }
        }

        /// <summary>
        /// Obtiene o establece el Tipo de Solicitud
        /// </summary>
        public string TipoSolicitud
        {
            set { tipoSolicitud = value; }
            get { return tipoSolicitud; }
        }

        /// <summary>
        /// Obtiene o establece el Numero de Voucher
        /// </summary>
        public int NumeroVoucher
        {
            set { numeroVoucher = value; }
            get { return numeroVoucher; }
        }

        /// <summary>
        /// Obtiene o establece la cuenta de usuario
        /// </summary>
        public string CuentaUsuario
        {
            set { cuentaUsuario = value; }
            get { return cuentaUsuario; }
        }

        /// <summary>
        /// Obtiene o establece la cuenta de usuario
        /// </summary>
        public string ProcesoCargaID
        {
            set { procesoCargaID = value; }
            get { return procesoCargaID; }
        }

        /// <summary>
        /// Parametro agregado Desarrollo OtrosBeneficios CDT
        /// Obtiene o establece el RutCausante
        /// </summary>
        public string RutCausante
        {
            set { rutCausante = value; }
            get { return rutCausante; }
        }

                /// <summary>
        /// Parametro agregado Desarrollo OtrosBeneficios CDT
        /// Obtiene o establece el DigitoVerificadorCausante
        /// </summary>
        public string DigitoVerificadorCausante
        {
            set { digitoVerificadorCausante = value; }
            get { return digitoVerificadorCausante; }
        }
        
        #endregion

        #region Constructor

        /// <summary>
        /// Crea una nueva instancia de la clase Solicitud Pago Tesoreria
        /// </summary>
        public SolicitudPagoTesoreria()
        {
            this.ClaveRegla = "ReglasEntidadSolicitudPagoTesoreria";
        }

        #endregion
    }
}
