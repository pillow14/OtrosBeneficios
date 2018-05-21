using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cl.Ing.Pensiones.Beneficios.Bel
{
    /// <summary>
    /// Clase base de entidades de negocio
    /// </summary>
    public abstract class ObjetoNegocio
    {

        #region Miembros

            private string claveRegla = String.Empty;

        #endregion

        #region Propiedades Públicas

        /// <summary>
        /// Obtiene oasigna la Clave de la regla de validacion
        /// </summary>
        public string ClaveRegla
        {
            set{ claveRegla = value; }
            get{ return claveRegla; }
        }

        #endregion
    }
}
