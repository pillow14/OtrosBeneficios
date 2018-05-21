using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using Microsoft.Practices.EnterpriseLibrary.Validation;
using Microsoft.Practices.EnterpriseLibrary.Validation.Validators;

namespace Cl.Ing.Pensiones.Beneficios.Bel
{
    public class EntidadProcesoCargaCoreTraspasoPrimaUno
    {
           #region Constructor

        public EntidadProcesoCargaCoreTraspasoPrimaUno()
        {
            this.correctosTraspasoPrimaUno = new Collection<CargaInformacionCoreTraspasoPrimaUno>();

            this.incorrectosTraspasoPrimaUno = new Collection<CargaInformacionCoreTraspasoPrimaUno>();

            this.listaErroresTraspasoPrimaUno = new Collection<CargaInformacionCoreTraspasoPrimaUno>();
        }

        #endregion

           #region Miembros

        public int totalCorrectos { get; set; }

        public int totalRegistros { get; set; }

        public int totalIncorrectos { get; set; }

        public int totalErrores { get; set; }

        public int procesoCargaId { get; set; }

        public string fechaContable { get; set; }

        public Collection<CargaInformacionCoreTraspasoPrimaUno> correctosTraspasoPrimaUno { get; set; }

        public Collection<CargaInformacionCoreTraspasoPrimaUno> incorrectosTraspasoPrimaUno { get; set; }

        public Collection<CargaInformacionCoreTraspasoPrimaUno> listaErroresTraspasoPrimaUno { get; set; }

        #endregion
    }
}
