using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using Microsoft.Practices.EnterpriseLibrary.Validation;
using Microsoft.Practices.EnterpriseLibrary.Validation.Validators;

namespace Cl.Ing.Pensiones.Beneficios.Bel
{
    public class EntidadProcesoCargaCorePagoAsesores
    {
        #region Constructor

        public EntidadProcesoCargaCorePagoAsesores()
        {
            this.correctosPagoAsesores = new Collection<CargaInformacionCorePagoAsesores>();

            this.incorrectosPagoAsesores = new Collection<CargaInformacionCorePagoAsesores>();

            this.listaErroresPagoAsesores = new Collection<CargaInformacionCorePagoAsesores>();
        }

        #endregion

        #region Miembros

        public int totalCorrectos { get; set; }

        public int totalRegistros { get; set; }

        public int totalIncorrectos { get; set; }

        public int totalErrores { get; set; }

        public int procesoCargaId { get; set; }

        public string fechaContable { get; set; }

        public Collection<CargaInformacionCorePagoAsesores> correctosPagoAsesores { get; set; }

        public Collection<CargaInformacionCorePagoAsesores> incorrectosPagoAsesores { get; set; }

        public Collection<CargaInformacionCorePagoAsesores> listaErroresPagoAsesores { get; set; }

        #endregion
    }
}
