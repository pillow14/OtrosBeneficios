using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.Validation;
using Microsoft.Practices.EnterpriseLibrary.Validation.Validators;


namespace Cl.Ing.Pensiones.Beneficios.Bel
{
    public class ObtieneViaPago : ObjetoNegocio 
    {
        #region Miembros

        private string tipoPagoID;
        private string tipoPagoDescripcion;
       
        #endregion

        #region Propiedades Públicas

        /// <summary>
        /// Obtiene o asigna el id del tipo de pago
        /// </summary>
        public string TipoPagoID
        {
            set { tipoPagoID = value; }
            get { return tipoPagoID; }
        }

        /// <summary>
        /// Obtiene o asigna la descripcion del tipo de pago
        /// </summary>
        public string TipoPagoDescripcion
        {
            set { tipoPagoDescripcion = value; }
            get { return tipoPagoDescripcion; }
        }
        
       
        #endregion

        #region Constructor

        /// <summary>
        /// Crea una nueva instancia de la clase ObtieneViaPago
        /// </summary>
        public ObtieneViaPago()
        {
            this.ClaveRegla = "ReglasEntidadObtieneViaPago";
        }

        #endregion
    }
}
