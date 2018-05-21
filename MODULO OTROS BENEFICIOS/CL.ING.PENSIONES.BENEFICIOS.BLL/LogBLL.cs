using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CL.ING.PENSIONES.BENEFICIOS.DAL;



namespace CL.ING.PENSIONES.BENEFICIOS.BLL
{
    /// <summary>
    /// Clase de manejo de negocio Log de acceso
    /// </summary>
    public class LogBLL
    {
        #region Métodos Públicos

        /// <summary>
        /// Metodo que inserta y devuelve id de acceso de conexion
        /// </summary>
        /// <param name="cuentaUsuario">cuenta del usuario</param>
        /// <param name="aplicativo">nombre del aplicativo al cual se ingresa</param>
        /// <returns>id de log de acceso</returns>
        public int IniciaLogAcceso(string cuentaUsuario, string aplicativo)
        {
            LogDAL data = new LogDAL();

            return data.IniciaLogAcceso(cuentaUsuario, aplicativo);
        }

        /// <summary>
        /// Metodo que Termina el Acceso Log
        /// </summary>
        /// <param name="idLog">id Log</param>
        public void TerminaLogAcceso(int idLog)
        {
            LogDAL data = new LogDAL();

            data.TerminaLogAcceso(idLog);
        }

        /// <summary>
        /// Metodo que direcciona el inicio y termino de log
        /// </summary>
        /// <param name="aplicativo">Nombre del aplicativo que se ingresa</param>
        /// <param name="cuentaUsuario">nombre de la cuenta de usuario</param>
        /// <param name="sesionLog">id de sesion log</param>
        /// <returns>id de log</returns>
        public string LogAcceso(string aplicativo, string cuentaUsuario, string sesionLog)
        {
            string respuesta = String.Empty;

            if (sesionLog.Equals(String.Empty))
            {
                respuesta = this.IniciaLogAcceso(cuentaUsuario, aplicativo).ToString();
            }
            else
            {
                this.TerminaLogAcceso(Convert.ToInt32(sesionLog));
                respuesta = this.IniciaLogAcceso(cuentaUsuario, aplicativo).ToString();
            }
            return respuesta;
        }

        #endregion
    }
}
