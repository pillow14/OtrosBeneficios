using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CL.ING.PENSIONES.BENEFICIOS.DAL;
using Cl.Ing.Pensiones.Beneficios.Bel;

namespace CL.ING.PENSIONES.BENEFICIOS.BLL
{
    public class GenerarReporteComparativoBLL
    {
        /// <summary>
        /// Obtiene los registros correspondientes al generador de reportes comparativos
        /// </summary>
        /// <param name="fechaPago">fecha ingresada por el usuario</param>
        /// <returns>retorna una lista de registros</returns>
        public IList<CargasBeneficios> ObtenerDatosCargaBeneficios(string fechaPago)
        {
            GenerarReporteComparativoDAL data = new GenerarReporteComparativoDAL();

            return data.ObtenerDatosCargaBeneficios(fechaPago, fechaPago, "Generar Reportes Comparativos");
        }

        /// <summary>
        /// Obtiene el total de registros correspondiente a la fecha seleccionada por el usuario
        /// </summary>
        /// <param name="fechaPago">fecha ingresada por el usuario</param>
        /// <returns>retorna el total de registros</returns>
        public int totalRegistrosEncontrados(string fechaPago)
        {
            GenerarReporteComparativoDAL data = new GenerarReporteComparativoDAL();

            return data.totalRegistrosEncontrados(fechaPago);
        }

        /// <summary>
        /// Obtiene el total de datos encontrados correspondientes a las modificaciones realizadas con anterioriadad
        /// </summary>
        /// <param name="idCarga">identificador de la carga</param>
        /// <returns>retorna el total de registross</returns>
        public int TotalRegistrosModificadosEncontrados(int idCarga)
        {
            GenerarReporteComparativoDAL data = new GenerarReporteComparativoDAL();

            return data.TotalRegistrosModificadosEncontrados(idCarga);
        }

        
        /// <summary>
        /// Determina si existen datos para generar un informe
        /// </summary>
        /// <param name="procesoCargaID">id del proceso de carga</param>
        /// <param name="tipoBeneficio">tipo del beneficio</param>
        /// <param name="tipoReporte">tipo del reporte</param>
        /// <returns>total de registros</returns>
        public int ExisteReporte(int procesoCargaID, int tipoBeneficio, int tipoReporte)
        {
            GenerarReporteComparativoDAL data = new GenerarReporteComparativoDAL();

            switch (tipoReporte)
            {
                case 1:
                    return data.ExisteReporte(procesoCargaID, tipoBeneficio, "pa_Otros_Beneficios_Informe_Diferencias_Cargo");
                case 2:
                    return data.ExisteReporte(procesoCargaID, tipoBeneficio, "pa_Otros_Beneficios_Informe_Registros_No_Coincidentes");
                case 3:
                    return data.ExisteReporte(procesoCargaID, tipoBeneficio, "pa_Otros_Beneficios_Informe_Estadistico_Total_Concepto_Detalle");
                case 4:
                    return data.ExisteReporte(procesoCargaID, tipoBeneficio, "pa_Otros_Beneficios_Informe_Total_Por_Via_Pago_V2");
                case 5:
                    return data.ExisteReporte(procesoCargaID, tipoBeneficio, "pa_Otros_Beneficios_Informe_Comparativo_Nivel_Rut");
                case 6:
                    return data.ExisteReporte(procesoCargaID, tipoBeneficio, "pa_Otros_Beneficios_Informe_Comparativo_Nivel_Totales");
                default:
                    return 0;
            }
        }
    
    }
}
