using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.Validation;
using Microsoft.Practices.EnterpriseLibrary.Validation.Validators;

namespace Cl.Ing.Pensiones.Beneficios.Bel
{
    public class CargaInformacionCiaSeguros : ObjetoNegocio
    {
        #region Miembros

        private int ciaSeguroId;
        private int ciaSeguroCodigoInstitucion;
        private string ciaSeguroDescripcion = string.Empty;
        private string ciaSeguroDireccion = string.Empty;
        private string ciaSeguroCodigoComuna = string.Empty;
        private string ciaSeguroRut = string.Empty;

        #endregion

        #region Propiedades públicas

        /// <summary>
        /// Obtiene o asigna Id de cia de seguro
        /// </summary>
        public int CiaSeguroId
        {
            set { ciaSeguroId = value; }
            get { return ciaSeguroId; }
        }

        /// <summary>
        /// Obtiene o asigna codigo institucion cia de seguro
        /// </summary>
        public int CiaSeguroCodigoInstitucion
        {
            set { ciaSeguroCodigoInstitucion = value; }
            get { return ciaSeguroCodigoInstitucion; }
        }

        /// <summary>
        /// Obtiene o asigna descripcion cia de seguro
        /// </summary>
        public string CiaSeguroDescripcion
        {
            set { ciaSeguroDescripcion = value; }
            get { return ciaSeguroDescripcion; }
        }

        /// <summary>
        /// Obtiene o asigna direccion cia de seguro
        /// </summary>
        public string CiaSeguroDireccion
        {
            set { ciaSeguroDireccion = value; }
            get { return ciaSeguroDireccion; }
        }

        /// <summary>
        /// Obtiene o asigna codigo de comuna cia de seguro
        /// </summary>
        public string CiaSeguroCodigoComuna
        {
            set { ciaSeguroCodigoComuna = value; }
            get { return ciaSeguroCodigoComuna; }
        }

        /// <summary>
        /// Obtiene o asigna rut cia de seguro
        /// </summary>
        public string CiaSeguroRut
        {
            set { ciaSeguroRut = value; }
            get { return ciaSeguroRut; }
        }
                
        #endregion

        #region Constructor

        /// <summary>
        /// Crea una nueva instancia de la clase CargaInformacionCiaSeguros
        /// </summary>
        public CargaInformacionCiaSeguros()
        {
            this.ClaveRegla = "ReglasEntidadCargaInformacionCiaSeguros";
        }

        #endregion

    }
}
