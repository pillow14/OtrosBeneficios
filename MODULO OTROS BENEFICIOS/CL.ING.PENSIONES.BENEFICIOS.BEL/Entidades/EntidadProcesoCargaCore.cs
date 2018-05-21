using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;

namespace Cl.Ing.Pensiones.Beneficios.Bel
{
    public class EntidadProcesoCargaCore
    {
        #region Constructor

        public EntidadProcesoCargaCore()
        {
            this.correctos = new Collection<CargaInformacionCore>();

            this.incorrectos = new Collection<CargaInformacionCore>();

            this.listaErrores = new Collection<CargaInformacionCore>();
        }

        #endregion

        #region Miembros

        public int totalCorrectos { get; set; }

        public int totalRegistros { get; set; }

        public int totalIncorrectos { get; set; }

        public int totalErrores { get; set; }

        public int procesoCargaId { get; set; }

        public string fechaContable { get; set; }

        public Collection<CargaInformacionCore> correctos { get; set; }

        public Collection<CargaInformacionCore> incorrectos { get; set; }

        public Collection<CargaInformacionCore> listaErrores { get; set; }

        #endregion
    }
}
