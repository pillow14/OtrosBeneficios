using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cl.Ing.Pensiones.Beneficios.Bel;
using CL.ING.PENSIONES.BENEFICIOS.DAL;

namespace CL.ING.PENSIONES.BENEFICIOS.BLL
{
    public class SolicitudPagoTesoreriaBLL
    {
        #region Métodos Públicos

        /// <summary>
        /// Método que Envia la solicitud de pago a tesoreria
        /// </summary>
        /// <param name="procesoCargaID">id del proceso de carga</param>
        /// <param name="tipoBeneficio">tipo de beneficio</param>
        /// <param name="tipoSolicitud">tipo de solicitud</param>
        /// <param name="cuentaUsuario">cuenta de usuario</param>
        /// <returns>mensaje de los datos enviados</returns>
        public string EnviarSolicitud(string procesoCargaID, string tipoBeneficio, string tipoSolicitud, string idRangoMonto, string cuentaUsuario)
        {
            SolicitudPagoTesoreriaDAL data = new SolicitudPagoTesoreriaDAL();

            return data.EnviarSolicitud(data.GenerarDatosSolicitud(procesoCargaID, tipoBeneficio, tipoSolicitud, idRangoMonto), tipoSolicitud, cuentaUsuario, procesoCargaID);            
        }

        #endregion
    }
}
