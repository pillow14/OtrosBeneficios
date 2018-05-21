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
    public class CargaSucursalesAFP : ObjetoNegocio
    {
        #region Miembros

        private string scr_codigo = String.Empty;
        private string scr_descripcion = String.Empty;


        #endregion

        #region Propiedades Públicas

        /// <summary>
        /// Obtiene o asigna el Codigo del receptor
        /// </summary>
        public string SrcCodigo
        {
            set { scr_codigo = value; }
            get { return scr_codigo; }
        }
        /// <summary>
        /// Obtiene o asigna el descripcion del receptor
        /// </summary>
        public string SrcDescripcion
        {
            set { scr_descripcion = value; }
            get { return scr_descripcion; }
        }

        #endregion
        #region Constructor

        /// <summary>
        /// Crea una nueva instancia de la clase ReglasEntidadCargaSucursalesAFP
        /// </summary>
        public CargaSucursalesAFP()
        {
            this.ClaveRegla = "ReglasEntidadCargaSucursalesAFP";
        }

        #endregion

    }
}
