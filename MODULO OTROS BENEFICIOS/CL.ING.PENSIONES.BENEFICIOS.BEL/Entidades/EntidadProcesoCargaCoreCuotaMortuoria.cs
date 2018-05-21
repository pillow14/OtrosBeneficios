using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;

namespace Cl.Ing.Pensiones.Beneficios.Bel
{
    public class EntidadProcesoCargaCoreCuotaMortuoria
    {
        #region Constructor

        public EntidadProcesoCargaCoreCuotaMortuoria()
        {
            this.correctosCuotaMortuoria = new Collection<CargaInformacionCoreCuotaMortuoria>();

            this.incorrectosCuotaMortuoria = new Collection<CargaInformacionCoreCuotaMortuoria>();

            this.listaErroresCuotaMortuoria = new Collection<CargaInformacionCoreCuotaMortuoria>();
        }

        #endregion

        #region Miembros

        public int totalCorrectos { get; set; }

        public int totalRegistros { get; set; }

        public int totalIncorrectos { get; set; }

        public int totalErrores { get; set; }

        public int procesoCargaId { get; set; }

        public string fechaContable { get; set; }

        public Collection<CargaInformacionCoreCuotaMortuoria> correctosCuotaMortuoria { get; set; }

        public Collection<CargaInformacionCoreCuotaMortuoria> incorrectosCuotaMortuoria { get; set; }

        public Collection<CargaInformacionCoreCuotaMortuoria> listaErroresCuotaMortuoria { get; set; }

        #endregion
    }
}
