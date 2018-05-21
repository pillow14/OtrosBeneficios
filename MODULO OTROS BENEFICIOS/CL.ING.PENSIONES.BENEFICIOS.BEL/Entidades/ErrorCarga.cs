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
    public class ErrorCarga : ObjetoNegocio
    {

        #region Miembros

            private int procesoCargaID = 0;
            private string mensajeError = String.Empty;
            private int tablaID = 0;
            private string personaID = String.Empty;
            private string tipoModalidad = String.Empty;
            private string tipoTramite = String.Empty;

        #endregion

        #region Propiedades Públicas

        /// <summary>
        /// Obtiene o asigna el id de proceso carga
        /// </summary>
        public int ProcesoCargaID
        {
            set{ procesoCargaID = value; }
            get{ return procesoCargaID; }
        }

        /// <summary>
        /// Obtiene o asigna el mensaje de error
        /// </summary>
        public string MensajeError
        {
            set{ mensajeError = value; }
            get{ return mensajeError; }
        }

        /// <summary>
        /// Obtiene o asigna el id de la tabla
        /// </summary>
        public int TablaID
        {
            set{ tablaID = value; }
            get{ return tablaID; }
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
        /// Obtiene o asigna el tipo de modalidad
        /// </summary>
        public string TipoModalidad
        {
            set{ tipoModalidad = value; }
            get{ return tipoModalidad; }
        }

        /// <summary>
        /// Obtiene o asigna el tipo de trámite
        /// </summary>
        public string TipoTramite
        {
            set{ tipoTramite = value; }
            get{ return tipoTramite; }
        }
         
        public ValidationResults Validacion
        {
            get
            {
                Validator<ErrorCarga> validador = ValidationFactory.CreateValidator<ErrorCarga>(this.ClaveRegla);

                return validador.Validate(this);
            }
        }        
        
        #endregion

        #region Constructor

        /// <summary>
        /// Crea una nueva instancia de la clase ErrorCarga
        /// </summary>
        public ErrorCarga()
        {
            this.ClaveRegla = "ReglasEntidadErrorCarga";
        }

        #endregion
    }
}
