using System;
using System.Collections.Generic;
using Cl.Ing.Pensiones.Beneficios.Bel;
using CL.ING.PENSIONES.BENEFICIOS.DAL;

namespace CL.ING.PENSIONES.BENEFICIOS.BLL
{
    public static class AnalisisDatosBLL
    {

        #region Métodos Públicos

        /// <summary>
        /// Obtiene los registros correspondientes al informe de análisis estadístico
        /// </summary>
        /// <param name="fechaDesde">fecha ingresada por el usuario</param>
        /// <param name="fechaHasta">fecha ingresada por el usuario</param>
        /// <returns>retorna una lista de registros</returns>
        public static IList<CargasBeneficios> ObtenerDatosCargaBeneficios(string fechaDesde, string fechaHasta, string modulo)
        {
            //AnalisisDatosDAL data = new AnalisisDatosDAL();

            return AnalisisDatosDAL.ObtenerDatosCargaBeneficios(fechaDesde, fechaHasta, modulo);
        }

        /// <summary>
        /// Obtiene los registros correspondientes a solicitud plataforma basica
        /// </summary>
        /// <param name="fechaDesde">fecha ingresada por el usuario</param>
        /// <param name="fechaHasta">fecha ingresada por el usuario</param>
        /// <returns>retorna una lista de registros</returns>
        public static IList<CargasBeneficios> ObtenerDatosCargaBeneficiosPlataformaBasica(string fechaDesde, string fechaHasta, string modulo)
        {
             //AnalisisDatosDAL data = new AnalisisDatosDAL();


             return AnalisisDatosDAL.ObtenerDatosCargaBeneficiosPlataformaBasica(fechaDesde, fechaHasta, modulo);
            
        }

        /// <summary>
        /// Obtiene los registros correspondientes a solicitud plataforma basica en cuanto a los montos
        /// </summary>
        /// <param name="fechaDesde">fecha ingresada por el usuario</param>
        /// <param name="fechaHasta">fecha ingresada por el usuario</param>
        /// <returns>retorna una lista de registros</returns>
        public static IList<RegistrosRangos> ObtenerDatosCargaBeneficiosPlataformaBasicaMontos(int procesoCargaID, int tipoBeneficio, int tipoSolicitud)
        {
            //AnalisisDatosDAL data = new AnalisisDatosDAL();

            return AnalisisDatosDAL.ObtenerDatosCargaBeneficiosPlataformaBasicaMontos(procesoCargaID, tipoBeneficio, tipoSolicitud);
        }
        /// <summary>
        /// Obtiene los registros correspondientes al informe de análisis estadístico
        /// </summary>
        /// <param name="fechaDesde">fecha ingresada por el usuario</param>
        /// <param name="fechaHasta">fecha ingresada por el usuario</param>
        /// <returns>retorna una lista de registros</returns>
        public static IList<CargasBeneficios> ObtenerDatosCargaBeneficiosEmision(string fechaDesde, string fechaHasta, string modulo)
        {
            //AnalisisDatosDAL data = new AnalisisDatosDAL();

            return AnalisisDatosDAL.ObtenerDatosCargaBeneficiosEmision(fechaDesde, fechaHasta, modulo);
        }

        /// <summary>
        /// Obtiene los registros correspondientes al informe de análisis estadístico
        /// </summary>
        /// <param name="fechaDesde">fecha ingresada por el usuario</param>
        /// <param name="fechaHasta">fecha ingresada por el usuario</param>
        /// <returns>retorna una lista de registros</returns>
        public static IList<CargasBeneficios> ObtenerDatosCargaBeneficiosModificacion(string fechaDesde, string fechaHasta, string modulo)
        {
            //AnalisisDatosDAL data = new AnalisisDatosDAL();

            return AnalisisDatosDAL.ObtenerDatosCargaBeneficiosModificacion(fechaDesde, fechaHasta, modulo);
        }

        /// <summary>
        /// Obtiene los registros de causantes a modificar
        /// </summary>
        /// <param name="procesoCargaID">id del proceso de carga</param>
        /// <param name="tipoBeneficio">tipo del beneficio</param>
        /// <returns>listado con los registros de causantes</returns>
        public static IList<RegistrosModificacion> ObtenerRegistrosModificacion(int procesoCargaID, int tipoBeneficio)
        {
            //AnalisisDatosDAL data = new AnalisisDatosDAL();

            return AnalisisDatosDAL.ObtenerRegistrosModificacion(procesoCargaID, tipoBeneficio);
        }

        /// <summary>
        /// Obtiene los datos a modificar
        /// </summary>
        /// <param name="registroID">id del registro a modificar</param>
        /// <param name="tipoBeneficio">tipo de beneficio</param>
        /// <returns>entidad con los datos a modificar</returns>
        public static RegistrosModificacion ObtenerRegistrosaModificar(int registroID, int tipoBeneficio, string tipoFondo)
        {
            //AnalisisDatosDAL data = new AnalisisDatosDAL();

            return AnalisisDatosDAL.ObtenerRegistroaModificar(registroID, tipoBeneficio, tipoFondo);
        }

        /// <summary>
        /// Obtiene el total de rut, agrupados por el tipo de fondo
        /// </summary>
        /// <param name="procesoCargaID">proceso de carga</param>
        /// <param name="rutCausante">rut seleccionado</param>
        /// <param name="tipoBeneficio">tipo de beneficio correspondiente al proceso de carga</param>
        /// <returns>retorna el total de registros encontrados</returns>
        public static int ObtenerTotalRutPorFondo(int procesoCargaID, string rutCausante, int tipoBeneficio)
        {
            //AnalisisDatosDAL data = new AnalisisDatosDAL();

            return AnalisisDatosDAL.ObtenerTotalRutPorFondo(procesoCargaID, rutCausante, tipoBeneficio);
        }

        /// <summary>
        /// Método que obtiene la pension liquida desde la tabla de acreditacion
        /// </summary>
        /// <param name="tipoBeneficio">tipo del beneficio</param>
        /// <param name="rutCausante">rut del causante</param>
        /// <param name="fechaContabilizacion">fecha de contabilidad</param>
        /// <returns>monto de pension liquida desde la tabla de acreditacion</returns>
        public static int ObtenerPensionLiquidaPlanilla(int tipoBeneficio, string rutCausante, int procesoCargaID)
        {
            //AnalisisDatosDAL data = new AnalisisDatosDAL();

            return AnalisisDatosDAL.ObtenerPensionLiquidaPlanilla(tipoBeneficio, rutCausante, procesoCargaID);
        }

        /// <summary>
        /// Método que actualiza los datos de tipo de beneficios
        /// </summary>
        /// <param name="listado">listado con los campos de modificacion</param>
        public static void ActualizaTipoBeneficioModificacion(DatosModificacion listado)
        {
            //AnalisisDatosDAL data = new AnalisisDatosDAL();

            AnalisisDatosDAL.ActualizaTipoBeneficioModificacion(listado);
        }

        /// <summary>
        /// Método que Inserta los datos del evento de modificacion
        /// </summary>
        /// <param name="listado">listado con los campos a insertar</param>
        public static void InsertaEventoModificacion(DatosModificacion listado)
        {
            //AnalisisDatosDAL data = new AnalisisDatosDAL();

            AnalisisDatosDAL.InsertaEventoModificacion(listado);
        }

        /// <summary>
        /// Método que actualiza los datos del cliente
        /// </summary>
        /// <param name="listado">listado con los campos a insertar</param>
        public static void InsertaModificacionCliente(DatosModificacion listado)
        {
            //AnalisisDatosDAL data = new AnalisisDatosDAL();

            AnalisisDatosDAL.InsertaModificacionCliente(listado);
        }

        public static int ExisteInformacionReporte(string tipoReporte, string viaPago, int procesoCargaID, string tipoBeneficio)
        {
            //AnalisisDatosDAL data = new AnalisisDatosDAL();
            string nombreProcedure = string.Empty;

            switch (tipoReporte)
            {
                case "1":
                    nombreProcedure = "pa_Otros_Beneficios_Cheques_Correo";
                    break;
                case "2":
                    nombreProcedure = "pa_Otros_Beneficios_Informe_Informativo_Via_Pago";
                    break;
                case "3":
                    nombreProcedure = string.Empty;
                    break;
                case "4":
                    nombreProcedure = string.Empty;
                    break;
                case "7":
                    nombreProcedure = "pa_Otros_Beneficios_Detalle_Montos_Traspasar_Fondos";
                    break;
                case "8":
                    nombreProcedure = "pa_Otros_Beneficios_Detalle_Monto_Traspasar_Tipo_Fondo";
                    break;
                case "9":
                    nombreProcedure = "pa_Otros_Beneficios_Detalle_Endosar_Cia_Seguros";
                    break;
                case "10":
                    nombreProcedure = "pa_Otros_Beneficios_Recibo_Pago_Cancelacion";
                    break;
                case "11":
                    nombreProcedure = "";
                    break;
                case "12":
                    nombreProcedure = "pa_otros_beneficios_casos_migrados_obtener";
                    break;
                case "13":
                    nombreProcedure = "uspOtrosBeneficiosResumenCiaSeguros";
                    break;
            }

            if (!nombreProcedure.Equals(string.Empty))
            {
                return AnalisisDatosDAL.ExisteInformacionReporte(tipoReporte, viaPago, procesoCargaID, tipoBeneficio, nombreProcedure);
            }
            else
            {
                return 1;
            }

        }


     
        /// <summary>
        /// Obtiene el nombre de la sucursal de pago
        /// </summary>
        /// <param name="codigoSucursal">còdigo de la sucursal de pago</param>
        /// <returns>retorna el nombre de la sucursal de pago</returns>
        public static string ObtieneNombreSucursalPago(string codigoSucursal)
        {
            //AnalisisDatosDAL data = new AnalisisDatosDAL();

            return AnalisisDatosDAL.ObtieneNombreSucursalPago(codigoSucursal);
        }

        /// <summary>
        /// Valida la existencia del código de banco insertado por el usuario
        /// </summary>
        /// <param name="codigoBanco">código de banco ingresado por el usuario</param>
        /// <returns>retorna el total de registros obtenidos</returns>
        public static int ValidaExistenciaCodigoBanco(string codigoBanco)
        {
            //AnalisisDatosDAL data = new AnalisisDatosDAL();

            return AnalisisDatosDAL.ValidaExistenciaCodigoBanco(codigoBanco);
        }

        /// <summary>
        /// Obtiene el valor del registro que se va a modificar
        /// </summary>
        /// <param name="identificadorRegistro">identificador del registro</param>
        /// <param name="tipoBeneficio">tipo de beneficio</param>
        /// <returns>retorna el monto líquido del registro</returns>
        public static int ObtenerValorPrimerRegristroModificacion(int identificadorRegistro, int tipoBeneficio)
        {
            //AnalisisDatosDAL data = new AnalisisDatosDAL();

            return AnalisisDatosDAL.ObtenerValorPrimerRegristroModificacion(identificadorRegistro, tipoBeneficio);
        }

        /// <summary>
        /// Obtiene la sumatoria del resto de los registros correspondientes a un rut especifico. Esto es para modificacón de registros
        /// </summary>
        /// <param name="valorMl">monto líquido de un registro obtenido anteriormente</param>
        /// <param name="procesoCarga">identificador del proceso</param>
        /// <param name="rutCliente">rut cliente</param>
        /// <param name="rutReceptor">rut receptor</param>
        /// <param name="tipoBeneficio">tipo de beneficio</param>
        /// <returns>Obtiene la sumatoria de los registros menos el registro ml enviado por parametro</returns>
        public static int ObtenerSumatorioRegistrosRestantesModificacion(int valorMl, int procesoCarga, string rutCliente, string rutReceptor, int tipoBeneficio)
        {
            //AnalisisDatosDAL data = new AnalisisDatosDAL();

            return AnalisisDatosDAL.ObtenerSumatorioRegistrosRestantesModificacion(valorMl, procesoCarga, rutCliente, rutReceptor, tipoBeneficio);
        }

        /// <summary>
        /// Obtiene la sumatoria de la acreditación
        /// </summary>
        /// <param name="rutCliente">rut del cliente</param>
        /// <param name="rutReceptor">rut del receptor</param>
        /// <param name="procesoCarga">proceso de carga</param>
        /// <param name="tipoBeneficio">tipo de beneficio</param>
        /// <returns>obtiene el ml de acreditación</returns>
        public static int ObtenerValorAcreditacionRegistroAcreditacion(string rutCliente, string rutReceptor, int procesoCarga, int tipoBeneficio)
        {
            //AnalisisDatosDAL data = new AnalisisDatosDAL();

            return AnalisisDatosDAL.ObtenerValorAcreditacionRegistroAcreditacion(rutCliente, rutReceptor, procesoCarga, tipoBeneficio);
        }

        //Buscar cargar Sucursal
        public static IList<CargaSucursalesAFP> ObtieneSucursalAFP(string codigo_sucursal)
        {
            //AnalisisDatosDAL data = new AnalisisDatosDAL();

            return AnalisisDatosDAL.ObtenerSucursalAFP(codigo_sucursal);
        }

        /// <summary>
        /// Verifica los registros cargados por ASI
        /// </summary>
        /// <param name="idCarga">Identificadro de la carga</param>
        /// <param name="fondo">fondo de pesnsiones</param>
        /// <returns>tipo de registros existente</returns>
        public static int VerificaRegistrosASI(int idCarga, string fondo)
        {
            return AnalisisDatosDAL.VerificaRegistrosASI(idCarga, fondo);
        }

        public static bool GenerarCargaASI(int idCarga, DateTime fecha, string fondo, string usuario)
        {
            return AnalisisDatosDAL.GenerarRegistrosASI(idCarga, fecha, fondo, usuario);
        }

        /// <summary>
        /// Eliminar los registros de provisión ASI
        /// </summary>
        /// <param name="idCarga">Identificador de la carga</param>
        /// <param name="fecha">Fecha de la carga</param>
        /// <param name="fondo">Fondo de pensiones</param>
        /// <returns>Resultado ejecución</returns>
        public static bool EliminarRegistrosASI(int idCarga, DateTime fecha, string fondo) 
        {
            return AnalisisDatosDAL.EliminarRegistrosASI(idCarga, fecha, fondo);
        }

        /// <summary>
        /// Obtiene los registros 
        /// </summary>
        /// <param name="fechaDesde"></param>
        /// <param name="fechaHasta"></param>
        /// <returns>retorna una lista de registros</returns>
        public static IList<EliminarRegistrosDuplicados> ObtenerRegistrosEliminacion(string rutRecaudador, string fecha, int tipoBeneficio)
        {
            return AnalisisDatosDAL.ObtenerRegistrosEliminacion(rutRecaudador, fecha, tipoBeneficio);
        }


        /// <summary>
        /// Elimina los registros 
        /// </summary>
        /// <param name="fechaDesde"></param>
        /// <param name="fechaHasta"></param>
        /// <returns></returns>
        public static void EliminaRegistros(string rutRecaudador, string fecha, int id, int tipoBeneficio)
        {
            AnalisisDatosDAL.EliminaRegistros(rutRecaudador, fecha, id, tipoBeneficio);
        }


        /// <summary>
        /// Valida los registros 
        /// </summary>
        /// <param name="fechaDesde"></param>
        /// <param name="fechaHasta"></param>
        /// <returns></returns>
        public static int ValidaRegistros(string rutRecaudador, string fecha, int tipoBeneficio)
        {
            return AnalisisDatosDAL.ValidaRegistros(rutRecaudador, fecha, tipoBeneficio);
        }

        /// <summary>
        /// Respaldar  registros 
        /// </summary>
        /// <param name="fechaDesde"></param>
        /// <param name="fechaHasta"></param>
        /// <returns></returns>
        public static void RespaldarRegistros(int idC, string rutRecaudador, string fecha, int tipoBeneficio, string usuario)
        {
            AnalisisDatosDAL.RespaldarRegistros(idC, rutRecaudador, fecha, tipoBeneficio, usuario);
        }

        /// <summary>
        /// Obtiene el total de registros 
        /// </summary>
        /// <param name="fechaPago"></param>
        /// <returns></returns>
        public static int TotalRegistros(string rutCausante, string fechaContabilizacion, int tipoBeneficio)
        {
            return AnalisisDatosDAL.TotalRegistros(rutCausante, fechaContabilizacion, tipoBeneficio);
        }

        /// <summary>
        /// Verifica los registros cargados por ASI
        /// </summary>
        /// <param name="idCarga">Identificadro de la carga</param>
        /// <param name="fondo">fondo de pesnsiones</param>
        /// <returns>tipo de registros existente</returns>
        public static int VerificaExistenciaTraspasos(string periodo)
        {
            return AnalisisDatosDAL.VerificaExistenciaTraspasos(periodo);
        }

        #endregion
    }
}
