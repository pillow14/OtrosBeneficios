using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CL.ING.PENSIONES.BENEFICIOS.DAL;
using Cl.Ing.Pensiones.Beneficios.Bel;

namespace CL.ING.PENSIONES.BENEFICIOS.BLL
{
    public class MigracionSumarioBLL
    {
        /// <summary>
        /// Obtiene los registros correspondientes al informe de análisis estadístico
        /// </summary>
        /// <param name="fechaDesde">fecha ingresada por el usuario</param>
        /// <param name="fechaHasta">fecha ingresada por el usuario</param>
        /// <returns>retorna una lista de registros</returns>
        public IList<CargasBeneficios> ObtenerDatosDatosCargaBeneficio(string fechaDesde, string fechaHasta)
        {
            MigracionSumarioDAL data = new MigracionSumarioDAL();

            return data.ObtenerDatosCargaBeneficios(fechaDesde, fechaHasta);
        }

        /// <summary>
        /// Obtiene el sumario de carga
        /// </summary>
        /// <param name="usuarioCarga">usuario que realiza la carga</param>
        /// <param name="tipoBeneficio">tipo de beneficio</param>
        /// <param name="idProcesoCarga">identificador del proceso</param>
        /// <returns>retorna un mensaje</returns>
        public string ObtenerSumarioMigracion(string usuarioCarga, int tipoBeneficio, int idProcesoCarga)
        {
            MigracionSumarioDAL data = new MigracionSumarioDAL();
            int idProcesoSumario = 0;
            int totalRegistrosCargados = 0;
            StringBuilder mensajeRespuesta = new StringBuilder();
            SumarioCargaCorrecto entidadRegistro = null;
            SumarioCargaError entidadRegistroError = null;

            idProcesoSumario = data.ObtenerIDProcesoCargado(usuarioCarga, tipoBeneficio, idProcesoCarga);
            totalRegistrosCargados = data.ObtenerTotalRegistrosCargados(idProcesoSumario);

            if (idProcesoSumario > 0 && totalRegistrosCargados > 0)
            {
                entidadRegistro = ObtenerSumarioMigracionCorrecto(idProcesoSumario);

                if (entidadRegistro.RegistrosErroneos > 0)
                {
                    entidadRegistroError = data.ObtenerSumarioMigracionError(idProcesoSumario);

                    mensajeRespuesta.Append(UtilitariosBLL.SumarioMigracionCorrecto(entidadRegistro.FechaCarga,entidadRegistro.HoraCarga,entidadRegistro.RegistrosMigrados,entidadRegistro.RegistrosCorrectos,entidadRegistro.RegistrosErroneos));
                    mensajeRespuesta.Append(UtilitariosBLL.SumarioMigracionErroneo(entidadRegistroError.MigracionErrorID,entidadRegistroError.Mensaje,entidadRegistroError.CodigoError));        
                }
                else
                {
                    mensajeRespuesta.Append(UtilitariosBLL.SumarioMigracionCorrecto(entidadRegistro.FechaCarga, entidadRegistro.HoraCarga, entidadRegistro.RegistrosMigrados, entidadRegistro.RegistrosCorrectos, entidadRegistro.RegistrosErroneos));
                }

               return mensajeRespuesta.ToString();
            }
            else
            {
                return UtilitariosBLL.NoExistenRegistros();
            }
        }

        /// <summary>
        /// Verifica la existencia de datos cargados en la tabla de registros migrados
        /// </summary>
        /// <param name="idProcesoCarga">identificador del proceso de carga</param>
        /// <returns>retorna un 1 en caso que existan registros</returns>
        public int ExisteInformacionMigracion(int idProcesoCarga)
        {
            MigracionSumarioDAL data = new MigracionSumarioDAL();

            return data.ExistenDatosMigracion(idProcesoCarga);
        }

        /// <summary>
        /// Obtiene los datos correctos correspondientes al sumario de migracion
        /// </summary>
        /// <param name="idProcesoSumario">identificador del proceso sumario carga</param>
        /// <returns>retorna una lista con los datos obtenidos</returns>
        public SumarioCargaCorrecto ObtenerSumarioMigracionCorrecto(int idProcesoSumario)
        {
            MigracionSumarioDAL data = new MigracionSumarioDAL();

            return data.ObtenerSumarioMigracionCorrecto(idProcesoSumario);
        }

        /// <summary>
        /// Obtiene los datos erroneos correspondientes al sumario de migración erroneo
        /// </summary>
        /// <param name="idProcesoSumario">identificador del proceso sumario carga</param>
        /// <returns>retorna un mensaje con los datos que se mostraran en pantalla</returns>
        public SumarioCargaError ObtenerSumarioMigracionError(int idProcesoSumario)
        {
            MigracionSumarioDAL data = new MigracionSumarioDAL();

            return data.ObtenerSumarioMigracionError(idProcesoSumario);
        }

    }
}
