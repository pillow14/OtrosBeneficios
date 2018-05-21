using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using Microsoft.Practices.EnterpriseLibrary.Validation;
using Microsoft.Practices.EnterpriseLibrary.Validation.Validators;

namespace Cl.Ing.Pensiones.Beneficios.Bel
{
    public class EntidadProcesoCargaCoreExcedenteLibreDisposicion
    {
        #region Constructor

        public EntidadProcesoCargaCoreExcedenteLibreDisposicion()
        {
            this.correctosExcedenteLibreDisposicion = new Collection<CargaInformacionCoreExcedenteLibreDisposicion>();

            this.incorrectosExcedenteLibreDisposicion = new Collection<CargaInformacionCoreExcedenteLibreDisposicion>();

            this.listaErroresExcedenteLibreDisposicion = new Collection<CargaInformacionCoreExcedenteLibreDisposicion>();
        }

        #endregion

        #region Miembros

        public int totalCorrectos { get; set; }

        public int totalRegistros { get; set; }

        public int totalIncorrectos { get; set; }

        public int totalErrores { get; set; }

        public int procesoCargaId { get; set; }

        public string fechaContable { get; set; }

        public Collection<CargaInformacionCoreExcedenteLibreDisposicion> correctosExcedenteLibreDisposicion { get; set; }

        public Collection<CargaInformacionCoreExcedenteLibreDisposicion> incorrectosExcedenteLibreDisposicion { get; set; }

        public Collection<CargaInformacionCoreExcedenteLibreDisposicion> listaErroresExcedenteLibreDisposicion { get; set; }

        #endregion
    }
}
