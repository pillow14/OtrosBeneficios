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
    public class DatosModificacion : ObjetoNegocio
    {

        #region Miembros

            private int procesoCargaID = 0;
            private int campoModificarID = 0;
            private int tipoBeneficioID = 0;
            private string cuentaUsuario = String.Empty;
            private string nombreCampo = String.Empty;
            private string rutCliente = String.Empty;
            private string viaPago = String.Empty;
            private string sucursalPago = String.Empty;
            private string codigoSucursalBanco = "";
            private string tipoCuentaBanco = String.Empty;
            private string numeroCuentaBanco = String.Empty;
            private int pensionLiquidaAntigua = 0;
            private int pensionLiquidaNueva = 0;
            private string nombreCausante = String.Empty;
            private string tipoPension = String.Empty;
            private string rutReceptor = String.Empty;
            private string tipoModalidad = String.Empty;
            private string nombreReceptor = String.Empty;
            private string nombreSucursal = String.Empty;
            private string porcDcto = "0";
            private int tipodbr = 0;
            private string numerodbr = "0";
            private string ufvalorizado = "0";
            private double bonoactualizado = 0;
            private string rutReceptorOld = String.Empty;


        #endregion

            #region Propiedades Públicas

            /// <summary>
        /// Obtiene o asigna el nombre de la sucursal
        /// </summary>
        public string NombreSucursal
        {
            set { nombreSucursal = value; }
            get { return nombreSucursal; }
        }

        /// <summary>
        /// Obtiene o asigna el nombre del receptor
        /// </summary>
        public string NombreReceptor 
        {
            set { nombreReceptor = value;  }
            get { return nombreReceptor;  }
        }

        /// <summary>
        /// Obtiene o asigna el id del proceso de carga
        /// </summary>
        public int ProcesoCargaID
        {
            set{ procesoCargaID = value; }
            get{ return procesoCargaID; }
        }

        /// <summary>
        /// Obtiene o asigna el id del campo a modificar
        /// </summary>
        public int CampoModificarID
        {
            set{ campoModificarID = value; }
            get{ return campoModificarID; }
        }

        /// <summary>
        /// Obtiene o asigna el id del tipo de beneficio
        /// </summary>
        public int TipoBeneficioID
        {
            set{ tipoBeneficioID = value; }
            get{ return tipoBeneficioID; }
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
        /// Obtiene o asigna el nombre del campo
        /// </summary>
        public string NombreCampo
        {
            set{ nombreCampo = value; }
            get{ return nombreCampo; }
        }

        /// <summary>
        /// Obtiene o asigna el rut del cliente
        /// </summary>
        public string RutCliente
        {
            set{ rutCliente = value; }
            get{ return rutCliente; }
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
        /// Obtiene o asigna la sucursal de pago
        /// </summary>
        public string SucursalPago
        {
            set{ sucursalPago = value; }
            get{ return sucursalPago; }
        }

        /// <summary>
        /// Obtiene o asigna el codigo de sucursal del banco
        /// </summary>
        public string CodigoSucursalBanco
        {
            set{ codigoSucursalBanco = value; }
            get{ return codigoSucursalBanco; }
        }

        /// <summary>
        /// Obtiene o asigna el tipo de la cuenta del banco
        /// </summary>
        public string TipoCuentaBanco
        {
            set{ tipoCuentaBanco = value; }
            get{ return tipoCuentaBanco; }
        }

        /// <summary>
        /// Obtiene o asigna el numero de la cuenta
        /// </summary>
        public string NumeroCuentaBanco
        {
            set{ numeroCuentaBanco = value; }
            get{ return numeroCuentaBanco; }
        }

        /// <summary>
        /// Obtiene o asigna la pension liquida antigua
        /// </summary>
        public int PensionLiquidaAntigua
        {
            set{ pensionLiquidaAntigua = value; }
            get{ return pensionLiquidaAntigua; }
        }

        /// <summary>
        /// Obtiene o asigna la pension liquida nueva
        /// </summary>
        public int PensionLiquidaNueva
        {
            set{ pensionLiquidaNueva = value; }
            get{ return pensionLiquidaNueva; }
        }

        /// <summary>
        /// Obtiene o asigna el nombre del causante
        /// </summary>
        public string NombreCausante
        {
            set{ nombreCausante = value; }
            get{ return nombreCausante; }
        }

        /// <summary>
        /// Obtiene o asigna el tipo de pensión
        /// </summary>
        public string TipoPension
        {
            set{ tipoPension = value; }
            get{ return tipoPension; }
        }

        /// <summary>
        /// Obtiene o asigna el rut del receptor
        /// </summary>
        public string RutReceptor
        {
            set{ rutReceptor = value; }
            get{ return rutReceptor; }
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
        /// Obtiene o asigna el % de Descuento
        /// </summary>
        public  string PorcDcto
        {
            set { porcDcto = value; }
            get { return porcDcto; }
        }

        /// <summary>
        /// obtiene o asigna el tipo de bono asignado como dbr
        /// </summary>
        public int TipoDbr
        {
            set { tipodbr = value; }
            get { return tipodbr; }
        }
        /// <summary>
        /// obtiene o asigna el numero del bono asignado como Numero Dbr
        /// </summary>
        public string NumeroDbr
        {
            set { numerodbr = value; }
            get { return numerodbr; }
        }

        /// <summary>
        /// obtiene o asigna valor UF
        /// </summary>

        public string UfValorizado
        {
            set { ufvalorizado = value; }
            get { return ufvalorizado; }
        }

        /// <summary>
        /// obtiene o asigna bono actualizado
        /// </summary>

        public double BonoActualizado
        {
            set { bonoactualizado = value; }
            get { return bonoactualizado; }
        }

        public string RutReceptorOld
        {
            set { rutReceptorOld = value; }
            get { return rutReceptorOld; }
        }

        public ValidationResults Validacion
        {
            get
            {
                Validator<DatosModificacion> validador = ValidationFactory.CreateValidator<DatosModificacion>(this.ClaveRegla);

                return validador.Validate(this);
            }
        }

        

        #endregion

        #region Constructor

        /// <summary>
        /// Crea una nueva instancia de la clase DatosModificacion
        /// </summary>
        public DatosModificacion()
        {
            this.ClaveRegla = "ReglasEntidadDatosModificacion";
        }

        #endregion
    }
}
