using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cl.Ing.Pensiones.Beneficios.Bel;
using CL.ING.PENSIONES.BENEFICIOS.DAL;

namespace CL.ING.PENSIONES.BENEFICIOS.BLL
{
    public class ValidacionConsistenciaBLL
    {
        #region Métodos Públicos

        /// <summary>
        /// Obtiene los registros correspondientes al informe de análisis estadístico
        /// </summary>
        /// <param name="fechaDesde">fecha ingresada por el usuario</param>
        /// <param name="fechaHasta">fecha ingresada por el usuario</param>
        /// <returns>retorna una lista de registros</returns>
        public IList<CargasBeneficios> ObtenerDatosCargaBeneficios(string fechaDesde, string fechaHasta)
        {
            ValidacionConsistenciaDAL data = new ValidacionConsistenciaDAL();

            return data.ObtenerDatosCargaBeneficios(fechaDesde, fechaHasta);
        }

        /// <summary>
        /// Obtiene la cantidad de filas devueltas por un procedimiento
        /// </summary>
        /// <param name="codigoProcedimiento"></param>
        /// <param name="parametroProcedimiento"></param>
        /// <returns></returns>
        public int ObtenerCantidadFilasAfectadas(string tipoReporte, int procesoCargaID, int tipoBeneficio)
        {
            ValidacionConsistenciaDAL data = new ValidacionConsistenciaDAL();
            string nombreProcedimiento = String.Empty;

            switch (tipoReporte)
            {
                case "1":
                    nombreProcedimiento = "pa_Otros_Beneficios_Cuenta_Bancaria_Sin_Banco_Sin_Cuota ";
                    break;
                case "2":
                    nombreProcedimiento = "pa_Otros_Beneficios_Cuenta_Bancaria_Codigo_Erroneo";
                    break;
                case "3":
                    nombreProcedimiento = "pa_Otros_Beneficios_Correo_Sin_Direccion";
                    break;
                //case "4":
                //    nombreProcedimiento = "pa_Otros_Beneficios_Giro_Sin_Ciudad_Destino";
                //    break;
                case "5":
                    nombreProcedimiento = "pa_Otros_Beneficios_Cheque_Sin_Sucursal";
                    break;
                //case "6":
                //    nombreProcedimiento = "pa_Otros_Beneficios_Servipag_Sin_Oficina_Ciudad";
                //    break;
                //case "7":
                //    nombreProcedimiento = "pa_Otros_Beneficios_Servipag_Mayor_Monto_Permitido";
                //    break;
                case "8":
                    nombreProcedimiento = "pa_Otros_Beneficios_Validar_Rut";
                    break;
            }


            return data.ObtieneNumeroDeFilasProcedimiento(nombreProcedimiento, tipoReporte, procesoCargaID, tipoBeneficio);
        }

        #endregion
    }
}
