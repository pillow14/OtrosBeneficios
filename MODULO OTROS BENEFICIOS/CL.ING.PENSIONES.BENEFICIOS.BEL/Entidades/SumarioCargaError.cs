using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cl.Ing.Pensiones.Beneficios.Bel
{
    public class SumarioCargaError : ObjetoNegocio
    {

        #region Miembros

            private int migracionErrorID = 0;
            private string mensaje = String.Empty;
            private string codigoError = String.Empty;

        #endregion

        #region Propiedades Públicas

        /// <summary>
        /// Identificador del registro en la tabla sumario migración error
        /// </summary>
        public int MigracionErrorID
        {
            set{ migracionErrorID = value; }
            get{ return migracionErrorID; }
        }

        /// <summary>
        /// Obtiene o asigna un mensaje indicando el estado del registro
        /// </summary>
        public string Mensaje
        {
            set{ mensaje = value; }
            get{ return mensaje; }
        }

        /// <summary>
        /// Obtiene o asigna el codigo de error
        /// </summary>
        public string CodigoError
        {
            set{ codigoError = value; }
            get{ return codigoError; }
        }


        #endregion

        #region Constructor

        public SumarioCargaError()
        {
            this.ClaveRegla = "ReglasEntidadSumarioCargaError";
        }

        #endregion
    }
}
