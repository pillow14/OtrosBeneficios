using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using Microsoft.Practices.EnterpriseLibrary.Validation;
using Microsoft.Practices.EnterpriseLibrary.Validation.Validators;

namespace Cl.Ing.Pensiones.Beneficios.Bel
{
    public class EntidadProcesoCargaCoreTraspasoPrimaDos
    {
        #region Constructor

        public EntidadProcesoCargaCoreTraspasoPrimaDos()
        {
            this.correctosTraspasoPrimaDos = new Collection<CargaInformacionCoreTraspasoPrimaDos>();

            this.incorrectosTraspasoPrimaDos = new Collection<CargaInformacionCoreTraspasoPrimaDos>();

            this.listaErroresTraspasoPrimaDos = new Collection<CargaInformacionCoreTraspasoPrimaDos>();
        }

        #endregion

        #region Miembros

        public int totalCorrectos { get; set; }

        public int totalRegistros { get; set; }

        public int totalIncorrectos { get; set; }

        public int totalErrores { get; set; }

        public int procesoCargaId { get; set; }

        public string fechaContable { get; set; }

        public Collection<CargaInformacionCoreTraspasoPrimaDos> correctosTraspasoPrimaDos { get; set; }

        public Collection<CargaInformacionCoreTraspasoPrimaDos> incorrectosTraspasoPrimaDos { get; set; }

        public Collection<CargaInformacionCoreTraspasoPrimaDos> listaErroresTraspasoPrimaDos { get; set; }

        #endregion
    }
}
