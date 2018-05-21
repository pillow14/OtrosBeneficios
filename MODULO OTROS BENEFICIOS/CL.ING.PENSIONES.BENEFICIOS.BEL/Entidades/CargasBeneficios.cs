using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cl.Ing.Pensiones.Beneficios.Bel
{
    public class CargasBeneficios : ObjetoNegocio
    {

        #region Miembros

            private string fechaCarga = String.Empty;
            private string fechaContabilidad = String.Empty;
            private string horaCarga = String.Empty;
            private string usuarioCarga = String.Empty;
            private int tipoBeneficio = 0;
            private int procesoCargaID = 0;
            private string nombreBeneficio = String.Empty;
            private string opcion = String.Empty;
            private string modulo = String.Empty;


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
        /// Obtiene o establece la fecha de contabilidad
        /// </summary>
        public string FechaContabilidad
        {
            set{ fechaContabilidad = value; }
            get{ return fechaContabilidad; }
        }

        /// <summary>
        /// Obtiene o establece la hora de carga
        /// </summary>
        public string HoraCarga
        {
            set{ horaCarga = value; }
            get{ return horaCarga; }
        }

        /// <summary>
        /// Obtiene o establece el usuario que realiza la carga
        /// </summary>
        public string UsuarioCarga
        {
            set{ usuarioCarga = value; }
            get{ return usuarioCarga; }
        }

        /// <summary>
        /// Obtiene o establece el tipo de beneficio
        /// </summary>
        public int TipoBeneficio
        {
            set{ tipoBeneficio = value; }
            get{ return tipoBeneficio; }
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
        /// Obtiene o establece el nombre del beneficio
        /// </summary>
        public string NombreBeneficio
        {
            set{ nombreBeneficio = value; }
            get{ return nombreBeneficio; }
        }

        /// <summary>
        /// Obtiene o establece la opcion
        /// </summary>
        public string Opcion
        {
            set{ opcion = value; }
            get{ return opcion; }
        }

        public string Modulo
        {
            set { modulo = value; }
            get { return modulo; }
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Crea una nueva instancia de la clase Cargas Beneficiarios
        /// </summary>
        public CargasBeneficios()
        {
            this.ClaveRegla = "ReglasEntidadCargasBeneficios";
        }

        #endregion
    }
}
