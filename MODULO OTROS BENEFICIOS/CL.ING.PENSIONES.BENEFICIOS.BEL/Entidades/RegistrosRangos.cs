using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Cl.Ing.Pensiones.Beneficios.Bel
{
    public class RegistrosRangos : ObjetoNegocio
    {
        #region Miembros

        //private int rangoMontoId, montoDesde, montoHasta, cantidadMigrar, totalMonto;
        private int rangoMontoId, cantidadMigrar;
        private string montoDesde, montoHasta, totalMonto;
       
        #endregion

        #region Propiedades Públicas

        /// <summary>
        /// Obtiene o asigna el id del rango de monto
        /// </summary>
        public int RangoMontoId
        {
            set { rangoMontoId = value; }
            get { return rangoMontoId; }
        }

        /// <summary>
        /// Obtiene o asigna el monto desde
        /// </summary>
        //public int MontoDesde
        //{
        //    set { montoDesde = value; }
        //    get { return montoDesde; }
        //}
        public string MontoDesde
        {
            set { montoDesde = value; }
            get { return montoDesde; }
        }
        /// <summary>
        /// Obtiene o asigna el monto hasta
        /// </summary>
        //public int MontoHasta
        //{
        //    set { montoHasta = value; }
        //    get { return montoHasta; }
        //}
        public string MontoHasta
        {
            set { montoHasta = value; }
            get { return montoHasta; }
        }
        /// <summary>
        /// Obtiene o asigna la cantidad de registros a migrar
        /// </summary>
        public int CantidadMigrar
        {
            set { cantidadMigrar = value; }
            get { return cantidadMigrar; }
        }

        /// <summary>
        /// Obtiene o asigna el total de monto
        /// </summary>
        //public int TotalMonto
        //{
        //    set { totalMonto = value; }
        //    get { return totalMonto; }
        //}
        public string TotalMonto
        {
            set { totalMonto = value; }
            get { return totalMonto; }
        }
      
       
        #endregion

        #region Constructor

        /// <summary>
        /// Crea una nueva instancia de la clase Cargas Beneficiarios
        /// </summary>
        public RegistrosRangos()
        {
            this.ClaveRegla = "ReglasEntidadCargasBeneficios";
        }

        #endregion

        
    }
}
