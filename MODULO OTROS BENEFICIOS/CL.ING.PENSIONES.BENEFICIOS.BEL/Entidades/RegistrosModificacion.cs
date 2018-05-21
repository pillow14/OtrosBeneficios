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
    public class RegistrosModificacion : ObjetoNegocio
    {

        #region Miembros

            private int procesoCargaID = 0;
            private int modificacionID = 0;
            private string rutCausante = String.Empty;
            private string rutReceptor = String.Empty;
            private string tipoPension = String.Empty;
            private string tipoModalidad = String.Empty;
            private string nombreCausante = String.Empty;
            private string nombreReceptor = String.Empty;
            private int totalLiquido = 0;
            private string opcion = String.Empty;
            private string tipoViaPago = String.Empty;
            private string codigoAgencia = String.Empty;
            private string tipoCuentaBanco = String.Empty;
            private string numeroCuentaBanco = String.Empty;
            private string numeroTramite = String.Empty;
            private string idCliente = String.Empty;
            private string nombreAgencia = String.Empty;
            private double porcDcto = 0;
            private int tipodbr =0;
            private string numerodbr = "0";
            private double ufvalorizado = 0;
            private double bonoactualizado = 0;
            private int valor_Uf_Saldo = 0;
            private int ufsaldo = 0;
            private string tipofondo = String.Empty;
            private string codigoSucursal = String.Empty;


        #endregion

        #region Propiedades Públicas

            public string CodigoSucursal
            {
                set { codigoSucursal = value; }
                get { return codigoSucursal; }
            }
        
        public string NombreAgencia
        {
            set { nombreAgencia = value; }
            get { return nombreAgencia; }
        }

        public string IdCliente
        {
            set { idCliente = value; }
            get { return idCliente; }
        }

        public string NumeroTramite 
        {
            set { numeroTramite = value; }
            get { return numeroTramite; }
        }

        /// <summary>
        /// Obtiene o asigna el número de cuenta de banco
        /// </summary>
        public string NumeroCuentaBanco
        {
            set { numeroCuentaBanco = value; }
            get { return numeroCuentaBanco; }
        }

        /// <summary>
        /// Obtiene o asigna el tipo cuenta de banco
        /// </summary>
        public string TipoCuentaBanco 
        {
            set { tipoCuentaBanco = value; }
            get { return tipoCuentaBanco; }
        }

        /// <summary>
        /// Obtiene o asigna el código de agencia
        /// </summary>
        public string CodigoAgencia
        {
            set { codigoAgencia = value; }
            get { return codigoAgencia; }
        }

        /// <summary>
        /// Obtiene o asigna el tipo de via pago
        /// </summary>
        public string TipoViaPago
        {
            set { tipoViaPago = value; }
            get { return tipoViaPago; }
        }

        /// <summary>
        /// Obtiene o asigna el nombre del receptor
        /// </summary>
        public string NombreReceptor
        {
            set { nombreReceptor = value;  }
            get { return nombreReceptor; }
        }

        /// <summary>
        /// Obtiene o asigna el id de proceso carga
        /// </summary>
        public int ProcesoCargaID
        {
            set{ procesoCargaID = value; }
            get{ return procesoCargaID; }
        }

        /// <summary>
        /// Obtiene o asigna el id del campo a modificar
        /// </summary>
        public int ModificacionID
        {
            set{ modificacionID = value; }
            get{ return modificacionID; }
        }

        /// <summary>
        /// Obtiene o asigna el rut del causante
        /// </summary>
        public string RutCausante
        {
            set{ rutCausante = value; }
            get{ return rutCausante; }
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
        /// Obtiene o asigna el tipo de Pension
        /// </summary>
        public string TipoPension
        {
            set{ tipoPension = value; }
            get{ return tipoPension; }
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
        /// Obtiene o asigna el nombre del causante
        /// </summary>
        public string NombreCausante
        {
            set{ nombreCausante = value; }
            get{ return nombreCausante; }
        }

        /// <summary>
        /// Obtiene o asigna el total liquido
        /// </summary>
        public int TotalLiquido
        {
            set{ totalLiquido = value; }
            get{ return totalLiquido; }
        }

        /// <summary>
        /// Obtiene o asigna la opcion del registro
        /// </summary>
        public string Opcion
        {
            set{ opcion = value; }
            get{ return opcion; }
        }

        /// <summary>
        /// Obtiene o asigna el % de Descuento
        /// </summary>
        public double PorcDcto
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
        public string  NumeroDbr
        {
            set { numerodbr = value; }
            get { return numerodbr; }
        }

        /// <summary>
        /// obtiene o asigna valor UF
        /// </summary>

        public double UfValorizado
        {
            set { ufvalorizado = value; }
            get { return ufvalorizado; }
        }

        /// <summary>
        /// obtiene o asigna bono actualizado
        /// </summary>

        public double BonoActualizado
        {
            set { bonoactualizado = value;}
            get { return bonoactualizado; }
        }


        public ValidationResults Validacion
        {
            get
            {
                Validator<RegistrosModificacion> validador = ValidationFactory.CreateValidator<RegistrosModificacion>(this.ClaveRegla);

                return validador.Validate(this);
            }
        }

        public int Valor_Uf_Saldo
        {
            set { valor_Uf_Saldo  = value; }
            get { return valor_Uf_Saldo; }
        }



        public int UfSaldo
        {
            set { ufsaldo = value; }
            get { return ufsaldo; }
        }

        public string TipoFondo
        {
            set { tipofondo = value; }
            get { return tipofondo; }
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Crea una nueva instancia de la clase RegistrosModificacion
        /// </summary>
        public RegistrosModificacion()
        {
            this.ClaveRegla = "ReglasEntidadRegistrosModificacion";
        }

        #endregion
    }
}
