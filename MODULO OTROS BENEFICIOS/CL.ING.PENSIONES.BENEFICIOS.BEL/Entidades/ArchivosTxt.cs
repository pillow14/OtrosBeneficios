using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cl.Ing.Pensiones.Beneficios.Bel
{
    public class ArchivosTxt
    {

        #region Miembros

            private string nombreArchivo1 = String.Empty;
            private string nombreArchivo2 = String.Empty;
            private string nombreArchivo3 = String.Empty;
            private string nombreArchivo4 = String.Empty;
            private string nombreArchivo5 = String.Empty;

        #endregion

        #region propiedadespublicas

        public string NombreArchivo1
        {
            set{ nombreArchivo1 = value; }
            get{ return nombreArchivo1; }
        }

        public string NombreArchivo2
        {
            set{ nombreArchivo2 = value; }
            get{ return nombreArchivo2; }
        }

        public string NombreArchivo3
        {
            set{ nombreArchivo3 = value; }
            get{ return nombreArchivo3; }
        }

        public string NombreArchivo4
        {
            set{ nombreArchivo4 = value; }
            get{ return nombreArchivo4; }
        }

        public string NombreArchivo5
        {
            set{ nombreArchivo5 = value; }
            get{ return nombreArchivo5; }
        }

        #endregion

        #region constructor
        public ArchivosTxt()
        {
            NombreArchivo1 = String.Empty;
            NombreArchivo2 = String.Empty;
            NombreArchivo3 = String.Empty;
            NombreArchivo4 = String.Empty;
            NombreArchivo5 = String.Empty;
        }
        #endregion


    }
}
