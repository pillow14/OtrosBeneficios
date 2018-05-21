using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cl.Ing.Pensiones.Beneficios.Bel
{
    public class SumarioCargaCorrecto : ObjetoNegocio
    {

        #region Miembros

            private string fechaCarga = String.Empty;
            private string horaCarga = String.Empty;
            private int registrosMigrados = 0;
            private int registrosCorrectos = 0;
            private int registrosErroneos = 0;

        #endregion

        #region Propiedades Públicas

        /// <summary>
        /// Obtiene o establece la fecha de carga
        /// </summary>
        public string FechaCarga
        {
            set{ fechaCarga = value; }
            get{ return fechaCarga; }
        }

        /// <summary>
        /// Obtiene o establece la fecha de carga
        /// </summary>
        public string HoraCarga
        {
            set{ horaCarga = value; }
            get{ return horaCarga; }
        }

        /// <summary>
        /// Obtiene o establece los registros migrados
        /// </summary>
        public int RegistrosMigrados
        {
            set{ registrosMigrados = value; }
            get{ return registrosMigrados; }
        }

        /// <summary>
        /// Obtiene o establece los registros correctos
        /// </summary>
        public int RegistrosCorrectos
        {
            set{ registrosCorrectos = value; }
            get{ return registrosCorrectos; }
        }

        /// <summary>
        /// Obtiene o establece los registros erroneos
        /// </summary>
        public int RegistrosErroneos
        {
            set{ registrosErroneos = value; }
            get{ return registrosErroneos; }
        }

        #endregion

        #region Constructor

        public SumarioCargaCorrecto()
        {
            this.ClaveRegla = "ReglasEntidadSumarioCargaCorrecto";
        }

        #endregion
    }
}
