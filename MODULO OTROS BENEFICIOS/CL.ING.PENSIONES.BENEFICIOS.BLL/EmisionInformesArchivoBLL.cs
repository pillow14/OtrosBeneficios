using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CL.ING.PENSIONES.BENEFICIOS.DAL;
using Cl.Ing.Pensiones.Beneficios.Bel;

namespace CL.ING.PENSIONES.BENEFICIOS.BLL
{
    public class EmisionInformesArchivoBLL
    {
        public ArchivosTxt GenerarArchivoCiaFondoBLL(string IdCarga, string TipoBenef, string ruta)
        {
            ArchivosTxt objTxt;
            EmisionInformesArchivoDAL objDal = new EmisionInformesArchivoDAL();
            objTxt = objDal.GenerarArchivoCiaFondoDAL(IdCarga, TipoBenef, ruta);
            return objTxt;
        }

        public static IList<ObtieneViaPago> ObtieneViaPago()
        {
            IList<ObtieneViaPago> objViaPago;
            EmisionInformesArchivoDAL objDal = new EmisionInformesArchivoDAL();
            objViaPago = objDal.ObtieneViaPago();
            return objViaPago;
        }

    }
}
