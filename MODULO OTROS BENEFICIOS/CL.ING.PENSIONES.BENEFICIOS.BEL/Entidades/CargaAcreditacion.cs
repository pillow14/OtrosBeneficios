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
    public class CargaAcreditacion : ObjetoNegocio
    {

        #region Miembros

            private int cargaBeneficioID = 0;
            private string fechaContabilidad = String.Empty;
            private int beneficioCarga = 0;
            private string personaID = String.Empty;
            private int clienteID = 0;
            private int secuenciaBeneficiario = 0;
            private int numeroTramite = 0;
            private int codigoMOVTO = 0;
            private string estadoProceso = String.Empty;
            private string tipoModalidad = String.Empty;
            private string fechaDisponibilidad = String.Empty;
            private string fechaValorCuota = String.Empty;

        #endregion

        #region Propiedades Públicas

        /// <summary>
        /// Obtiene o asigna el id de de carga beneficio
        /// </summary>
        public int CargaBeneficioID
        {
            set{ cargaBeneficioID = value; }
            get{ return cargaBeneficioID; }
        }

        /// <summary>
        /// Obtiene o asigna la fecha de contabilidad
        /// </summary>
        public string FechaContabilidad
        {
            set{ fechaContabilidad = value; }
            get{ return fechaContabilidad; }
        }

        /// <summary>
        /// Obtiene o asigna el beneficio carga
        /// </summary>
        public int BeneficioCarga
        {
            set{ beneficioCarga = value; }
            get{ return beneficioCarga; }
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
        /// Obtiene o asigna el id del cliente
        /// </summary>
        public int ClienteID
        {
            set{ clienteID = value; }
            get{ return clienteID; }
        }

        /// <summary>
        /// Obtiene o asigna la secuencia del beneficiario
        /// </summary>
        public int SecuenciaBeneficiario
        {
            set{ secuenciaBeneficiario = value; }
            get{ return secuenciaBeneficiario; }
        }

        /// <summary>
        /// Obtiene o asigna el numero de tramite
        /// </summary>
        public int NumeroTramite
        {
            set{ numeroTramite = value; }
            get{ return numeroTramite; }
        }

        /// <summary>
        /// Obtiene o asigna el codigo de MOVTO
        /// </summary>
        public int CodigoMOVTO
        {
            set{ codigoMOVTO = value; }
            get{ return codigoMOVTO; }
        }

        /// <summary>
        /// Obtiene o asigna el estado del proceso
        /// </summary>
        public string EstadoProceso
        {
            set{ estadoProceso = value; }
            get{ return estadoProceso; }
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
        /// Obtiene o asigna la fecha de disponibilidad
        /// </summary>
        public string FechaDisponibilidad
        {
            set{ fechaDisponibilidad = value; }
            get{ return fechaDisponibilidad; }
        }

        /// <summary>
        /// Obtiene o asigna la fecha de valor cuota
        /// </summary>
        public string FechaValorCuota
        {
            set{ fechaValorCuota = value; }
            get{ return fechaValorCuota; }
        }

        /// <summary>
        /// Obtiene o asigna el valor ML MOVTO
        /// </summary>
        public double ValorMLMOVTO { get; set; }

         
        public ValidationResults Validacion
        {
            get
            {
                Validator<CargaAcreditacion> validador = ValidationFactory.CreateValidator<CargaAcreditacion>(this.ClaveRegla);

                return validador.Validate(this);
            }
        }        
        
        #endregion

        #region Constructor

        /// <summary>
        /// Crea una nueva instancia de la clase CargaAcreditacion
        /// </summary>
        public CargaAcreditacion()
        {
            this.ClaveRegla = "ReglasEntidadCargaAcreditacion";
        }

        #endregion
    }
}
