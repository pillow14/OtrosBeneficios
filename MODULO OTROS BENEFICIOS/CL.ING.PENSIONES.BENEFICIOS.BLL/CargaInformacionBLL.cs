using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cl.Ing.Pensiones.Beneficios.Bel;
using CL.ING.PENSIONES.BENEFICIOS.DAL;

namespace CL.ING.PENSIONES.BENEFICIOS.BLL
{
    public class CargaInformacionBLL
    {
        #region Métodos Públicos

        /// <summary>
        /// Método que obtiene los datos cargados de Herencia
        /// </summary>
        /// <param name="fechaContabilidad">fecha de contabilidad</param>
        /// <param name="cuentaUsuario">cuenta del usuario</param>
        /// <param name="rutaSSIS">Ruta del SSIS</param>
        /// <returns>Listado con los datos obtenidos</returns>
        public IList<CargaInformacionHerencia> ProcesoCargaBeneficioHerencia(string fechaContabilidad)
        {
            CargaInformacionDAL data = new CargaInformacionDAL();

            //Limpiamos los datos de la tabla auxiliar antes de cargar
            data.LimpiaDatosHerenciaAuxiliar();

            //Método que crea tabla temporal con los datos de la fecha indicada
            //data.IniciaProcesoCargaHerencia(fechaContabilidad);

            //Método que carga datos desde Core hacia objeto BulkCopy y luego los asigna a tabla auxiliar
            CargaInformacionDAL.CargaDatosHerenciaPackageBulkCopy(fechaContabilidad);

            //Método que inserta los datos desde tabla temporal a tabla auxiliar
            //data.InsertaHerenciaAuxiliar();

            //Método que borra la tabla temporal
            //data.BorrarTablaHerenciaTemporal();
            
            return data.ObtenerDatosBeneficiosHerencia(fechaContabilidad);
        }

        /// <summary>
        /// Método que inicia el proceso de carga de Herencia
        /// </summary>
        /// <param name="fechaContabilidad">Fecha de Contabilidad</param>
        /// <param name="cuentaUsuario">Cuenta del Usuario</param>
        /// <returns>id del proceso de carga</returns>
        public int InsertaProcesoCarga(string fechaContabilidad, string cuentaUsuario,int tipoBeneficio)
        {
            CargaInformacionDAL data = new CargaInformacionDAL();

            return data.InsertaProcesoCarga(fechaContabilidad, cuentaUsuario,tipoBeneficio);
        }

        /// <summary>
        /// Método que carga los datos de herencia
        /// </summary>
        /// <param name="idProcesoCarga">id del proceso de carga</param>
        /// <param name="listado">datos de herencia</param>
        /// <returns>Mensaje de carga</returns>
        public string CargaHerencia(int idProcesoCarga,IList<CargaInformacionHerencia> listado)
        {
            CargaInformacionDAL data = new CargaInformacionDAL();

            return data.CargaHerencia(idProcesoCarga, listado);            
        }

        
        /// <summary>
        /// Método que inserta la carga de herencia de modificacion
        /// </summary>
        /// <param name="idProcesoCarga">id del proceso de carga</param>
        public void InsertaCargaHerenciaModificacion(int idProcesoCarga)
        {
            CargaInformacionDAL data = new CargaInformacionDAL();

            data.InsertaCargaHerenciaModificacion(idProcesoCarga);
        }

        /// <summary>
        /// Método que realiza la carga de acreditación
        /// </summary>
        /// <param name="fechaContabilidad">fecha de contabilidad</param>
        /// <param name="cuentaUsuario">cuenta del usuario</param>
        /// <param name="beneficioCarga">beneficio de carga</param>
        //public void InsertaCargaAcreditacion(string fechaContabilidad, string cuentaUsuario, string beneficioCarga, int idProcesoCarga, string rutaSSIS)
        //{
        //    CargaInformacionDAL data = new CargaInformacionDAL();

        //    data.CargaAcreditacionAuxiliar(cuentaUsuario, fechaContabilidad, beneficioCarga, rutaSSIS);
        //    data.CargaAcreditacion(data.ObtieneCargaAcreditacion(cuentaUsuario, fechaContabilidad, beneficioCarga), idProcesoCarga);
        //}

        /// <summary>
        /// Método que realiza el proceso de carga de beneficios cuotas mortuorias
        /// </summary>
        /// <param name="fechaContabilidad">fecha de contabilidad</param>
        /// <param name="cuentaUsuario">cuenta del usuario</param>
        /// <returns>listado con los datos insertados</returns>
        public IList<CargaInformacionCuotaMortuaria> ProcesoCargaBeneficioMortuaria(string fechaContabilidad)
        {
            CargaInformacionDAL data = new CargaInformacionDAL();

            //Limpiamos los datos de la tabla auxiliar antes de cargar
            data.LimpiaDatosMortuariosAuxiliar();

            //Método que crea tabla temporal con los datos de la fecha indicada
            //data.IniciaProcesoCargaCuotaMortuaria(fechaContabilidad);

            //Método que carga datos desde Core hacia objeto BulkCopy y luego los asigna a tabla auxiliar
            CargaInformacionDAL.CargaDatosCuotaMortuoriaPackageBulkCopy(fechaContabilidad);

            //Método que inserta los datos desde tabla temporal a tabla auxiliar
            //data.InsertaProcesoCargaCuotasMortuoriasAuxiliar();

            //Método que borra la tabla temporal
            //data.BorrarTablaCuotasMortuoriasTemporal();

            return data.ObtenerDatosBeneficiosMortuarios(fechaContabilidad);
        }

        /// <summary>
        /// Método que realiza el proceso de carga de excedentes de libre disposicion
        /// </summary>
        /// <param name="fechaContabilidad">fecha de contabilidad</param>
        /// <param name="cuentaUsuario">cuenta del usuario</param>
        /// <returns>listado con los datos insertados</returns>
        public IList<CargaInformacionExcedenteLibreDisposicion> ProcesoCargaExcedenteLibreDisposicion(string fechaContabilidad)
        {
            CargaInformacionDAL data = new CargaInformacionDAL();

            //Limpiamos los datos de la tabla auxiliar antes de cargar
            data.LimpiaDatosExcedenteLibreDisposicionAuxiliar();

            //Método que crea tabla temporal con los datos de la fecha indicada
            //data.IniciaProcesoCargaExcedenteLibreDisposicion(fechaContabilidad);

            CargaInformacionDAL.CargaDatosExcedenteLibreDisposicionPackageBulkCopy(fechaContabilidad);

            //Método que inserta los datos desde tabla temporal a tabla auxiliar
            //data.InsertaProcesoCargaExcedenteLibreDisposicionAuxiliar();

            //Método que borra la tabla temporal
            //data.BorrarTablaExcedenteLibreDisposicionTemporal();

            return data.ObtenerDatosBeneficiosLibreDisposicion(fechaContabilidad);
        }

        /// <summary>
        /// Método que realiza el proceso de carga de pago asesores
        /// </summary>
        /// <param name="fechaContabilidad">fecha de contabilidad</param>
        /// <returns>listado con los datos insertados</returns>
        public IList<CargaInformacionPagosAsesores> ProcesoCargaPagoAsesores(string fechaContabilidad)
        {
            CargaInformacionDAL data = new CargaInformacionDAL();

            //Limpiamos los datos de la tabla auxiliar antes de cargar
            data.LimpiaDatosPagoAsesores();

            //Método que crea tabla temporal con los datos de la fecha indicada
            //data.IniciaProcesoCargaPagoAsesores(fechaContabilidad);

            CargaInformacionDAL.CargaDatosPagoAsesoresPackageBulkCopy(fechaContabilidad);

            //Método que inserta los datos desde tabla temporal a tabla auxiliar
            //data.InsertaProcesoCargaPagoAsesoresAuxiliar();

            //Método que borra la tabla temporal
            //data.BorrarTablaPagoAsesoresTemporal();

            return data.ObtenerDatosPagoAsesores(fechaContabilidad);
        }

        /// <summary>
        /// Método que realiza el proceso de carga de traspaso prima uno
        /// </summary>
        /// <param name="fechaContabilidad">fecha de contabilidad</param>
        /// <param name="cuentaUsuario">cuenta del usuario</param>
        /// <returns>listado con los datos insertados</returns>
        public IList<CargaTraspasoPrimaUno> ProcesoCargaTraspasoPrimaUno(string fechaContabilidad)
        {
            CargaInformacionDAL data = new CargaInformacionDAL();

            //Limpiamos los datos de la tabla auxiliar antes de cargar
            data.LimpiaDatosTraspasoPrimaUno();

            //Método que crea tabla temporal con los datos de la fecha indicada
            //data.IniciaProcesoCargaTraspasoPrimaUno(fechaContabilidad);

            CargaInformacionDAL.CargaDatosTraspasoPrimaUnoPackageBulkCopy(fechaContabilidad);

            //Método que inserta los datos desde tabla temporal a tabla auxiliar
            //data.InsertaProcesoCargaTraspasoPrima1Auxiliar();

            //Método que borra la tabla temporal
            //data.BorrarTablaTraspasoPrima1Temporal();

            return data.ObtenerDatosTraspasoPrimaUno(fechaContabilidad);
        }

        /// <summary>
        /// Método que realiza el proceso de carga de traspaso prima dos
        /// </summary>
        /// <param name="fechaContabilidad">fecha de contabilidad</param>
        /// <returns>listado con los datos insertados</returns>
        public IList<CargaTraspasoPrimaDos> ProcesoCargaTraspasoPrimaDos(string fechaContabilidad)
        {
            CargaInformacionDAL data = new CargaInformacionDAL();

            //Limpiamos los datos de la tabla auxiliar antes de cargar
            data.LimpiaDatosTraspasoPrimaDos();

            //Método que crea tabla temporal con los datos de la fecha indicada
            //data.IniciaProcesoCargaTraspasoPrimaDos(fechaContabilidad);

            CargaInformacionDAL.CargaDatosTraspasoPrimaDosPackageBulkCopy(fechaContabilidad);

            //Método que inserta los datos desde tabla temporal a tabla auxiliar
            //data.InsertaProcesoCargaTraspasoPrima2Auxiliar();

            //Método que borra la tabla temporal
            //data.BorrarTablaTraspasoPrima2Temporal();

            return data.ObtenerDatosTraspasoPrimaDos(fechaContabilidad);
        }

        /// <summary>
        /// Método que realiza la carga de Cuotas mortuorias
        /// </summary>
        /// <param name="idProcesoCarga">id del proceso de carga</param>
        /// <param name="listado">listado con los datos de la carga</param>
        /// <returns>Mensaje de confirmación de carga</returns>
        public string CargaCuotasMortuorias(int idProcesoCarga, IList<CargaInformacionCuotaMortuaria> listado)
        {
            CargaInformacionDAL data = new CargaInformacionDAL();

            return data.CargaCuotaMortuoria(idProcesoCarga, listado);
        }

        /// <summary>
        /// Método que realiza la carga de Cuotas mortuorias
        /// </summary>
        /// <param name="idProcesoCarga">id del proceso de carga</param>
        /// <param name="listado">listado con los datos de la carga</param>
        /// <returns>Mensaje de confirmación de carga</returns>
        public string CargaExcedenteLibreDisposicion(int idProcesoCarga, IList<CargaInformacionExcedenteLibreDisposicion> listado)
        {
            CargaInformacionDAL data = new CargaInformacionDAL();

            return data.CargaExcedenteLibreDisposicion(idProcesoCarga, listado);
        }

        /// <summary>
        /// Método que realiza la carga de Pagos de Asesores
        /// </summary>
        /// <param name="idProcesoCarga">id del proceso de carga</param>
        /// <param name="listado">listado con los datos de la carga</param>
        /// <returns>Mensaje de confirmación de carga</returns>
        public string CargaPagosAsesores(int idProcesoCarga, IList<CargaInformacionPagosAsesores> listado)
        {
            CargaInformacionDAL data = new CargaInformacionDAL();

            return data.CargaPagosAsesores(idProcesoCarga, listado);
        }

        /// <summary>
        /// Método que realiza la carga de Traspaso Prima Uno
        /// </summary>
        /// <param name="idProcesoCarga">id del proceso de carga</param>
        /// <param name="listado">listado con los datos de la carga</param>
        /// <returns>Mensaje de confirmación de carga</returns>
        public string CargaTraspasoPrimaUno(int idProcesoCarga, IList<CargaTraspasoPrimaUno> listado)
        {
            CargaInformacionDAL data = new CargaInformacionDAL();

            return data.CargaTraspasoPrimaUno(idProcesoCarga, listado);
        }

        /// <summary>
        /// Método que realiza la carga de Traspaso Prima Dos
        /// </summary>
        /// <param name="idProcesoCarga">id del proceso de carga</param>
        /// <param name="listado">listado con los datos de la carga</param>
        /// <returns>Mensaje de confirmación de carga</returns>
        public string CargaTraspasoPrimaDos(int idProcesoCarga, IList<CargaTraspasoPrimaDos> listado)
        {
            CargaInformacionDAL data = new CargaInformacionDAL();

            return data.CargaTraspasoPrimaDos(idProcesoCarga, listado);
        }

        /// <summary>
        /// Método que inserta las cuotas mortuorias modificación
        /// </summary>
        /// <param name="idProcesoCarga">id del proceso de carga</param>
        public void InsertaCargaCuotasMortuoriasModificacion(int idProcesoCarga)
        {
            CargaInformacionDAL data = new CargaInformacionDAL();

            data.InsertaCargaCuotasMortuoriasModificacion(idProcesoCarga);
        }

        /// <summary>
        /// Método que inserta los excedentes de libre disposicion modificacion
        /// </summary>
        /// <param name="idProcesoCarga">id del proceso de carga</param>
        public void InsertaCargaExcedenteLibreDisposicionModificacion(int idProcesoCarga)
        {
            CargaInformacionDAL data = new CargaInformacionDAL();

            data.InsertaCargaExcedentesLibreDisposicionModificacion(idProcesoCarga);
        }

        /// <summary>
        /// Método que inserta los pagos de asesores modificacion
        /// </summary>
        /// <param name="idProcesoCarga">id del proceso de carga</param>
        public void InsertaCargaPagosAsesoresModificacion(int idProcesoCarga)
        {
            CargaInformacionDAL data = new CargaInformacionDAL();

            data.InsertaCargaPagosAsesoresModificacion(idProcesoCarga);
        }

        /// <summary>
        /// Método que inserta la traspaso prima uno modificacion
        /// </summary>
        /// <param name="idProcesoCarga">id del proceso de carga</param>
        public void InsertaCargaTraspasoPrimaUnoModificacion(int idProcesoCarga)
        {
            CargaInformacionDAL data = new CargaInformacionDAL();

            data.InsertaCargaTraspasoPrimaUnoModificacion(idProcesoCarga);
        }

        /// <summary>
        /// Método que inserta la traspaso prima dos modificacion
        /// </summary>
        /// <param name="idProcesoCarga">id del proceso de carga</param>
        public void InsertaCargaTraspasoPrimaDosModificacion(int idProcesoCarga)
        {
            CargaInformacionDAL data = new CargaInformacionDAL();

            data.InsertaCargaTraspasoPrimaDosModificacion(idProcesoCarga);
        }

        /// <summary>
        /// Método que inserta la carga de acreditación de excedente de libre disposición
        /// </summary>
        /// <param name="fechaContabilidad">fecha de contabilidad</param>
        /// <param name="beneficioCarga">beneficio carga</param>
        public void InsertaCargaAcreditacion(string fechaContabilidad, string beneficioCarga, int idProcesoCarga)
        {
            CargaInformacionDAL data = new CargaInformacionDAL();

            //Método que limpia los datos de la tabla auxiliar de acreditación
            data.LimpiaDatosAcreditacionAuxiliar();

            //Método que crea la tabla temporal de acreditacion
            data.CreaAcreditacionTemporal(fechaContabilidad,beneficioCarga);
            
            //Método que inserta en tabla auxiliar los datos desde tabla temporal
            data.InsertaAcreditacionTemporalAuxiliar(fechaContabilidad, beneficioCarga);

            //Método que elimina la tabla temporal de acreditacion
            data.BorrarTablaAcreditacionAuxiliar();

            //Método que obtiene los datos de acreditacion de la tabla auxiliar y los inserta en la tabla de acreditacion
            data.InsertaCargaAcreditacion(data.ObtieneCargaAcreditacionTablaAuxiliar(fechaContabilidad, beneficioCarga), idProcesoCarga);
        }

        /// <summary>
        /// Verifica la existencia de registros en la tabla de traspaso prima uno
        /// </summary>
        /// <param name="fechaContabilizacion">Fecha ingresada por el usuario</param>
        /// <returns>Retorna la cantidad de registros encontrados</returns>
        public int ExisteInformacionTraspasoPrimaUno(string fechaContabilizacion)
        {
            CargaInformacionDAL data = new CargaInformacionDAL();

            return data.ExisteInformacionTraspasoPrimaUno(fechaContabilizacion);
        }

        /// <summary>
        /// Verifica la existencia de registros en la tabla de traspaso prima dos
        /// </summary>
        /// <param name="fechaContabilizacion">Fecha ingresada por el usuario</param>
        /// <returns>Retorna la cantidad de registros encontrados</returns>
        public int ExisteInformacionTraspasoPrimaDos(string fechaContabilizacion)
        {
            CargaInformacionDAL data = new CargaInformacionDAL();

            return data.ExisteInformacionTraspasoPrimaDos(fechaContabilizacion);
        }

        /// <summary>
        /// Verifica la existencia de registros en la tabla de herencia
        /// </summary>
        /// <param name="fechaContabilizacion">Fecha ingresada por el usuario</param>
        /// <returns>Retorna la cantidad de registros encontrados</returns>
        public int ExisteInformacionHerencia(string fechaContabilizacion)
        {
            CargaInformacionDAL data = new CargaInformacionDAL();

            return data.ExisteInformacionHerencia(fechaContabilizacion);
        }

        /// <summary>
        /// Verifica la existencia de registros en la tabla de cuotas mortuorias
        /// </summary>
        /// <param name="fechaContabilizacion">Fecha ingresada por el usuario</param>
        /// <returns>Retorna la cantidad de registros encontrados</returns>
        public int ExisteInformacionCuotasMortuorias(string fechaContabilizacion)
        {
            CargaInformacionDAL data = new CargaInformacionDAL();

            return data.ExisteInformacionCuotasMortuorias(fechaContabilizacion);
        }

        /// <summary>
        /// Verifica la existencia de registros en la tabla de excedente libre disposicion
        /// </summary>
        /// <param name="fechaContabilizacion">Fecha ingresada por el usuario</param>
        /// <returns>Retorna la cantidad de registros encontrados</returns>
        public int ExisteInformacionExcedenteLibreDisposicion(string fechaContabilizacion)
        {
            CargaInformacionDAL data = new CargaInformacionDAL();

            return data.ExisteInformacionExcedenteLibreDisposicion(fechaContabilizacion);
        }

        /// <summary>
        /// Verifica la existencia de registros en la tabla de pagos asesores
        /// </summary>
        /// <param name="fechaContabilizacion">Fecha ingresada por el usuario</param>
        /// <returns>Retorna la cantidad de registros encontrados</returns>
        public int ExisteInformacionPagosAsesores(string fechaContabilizacion)
        {
            CargaInformacionDAL data = new CargaInformacionDAL();

            return data.ExisteInformacionPagosAsesores(fechaContabilizacion);
        }

        /// <summary>
        /// Elimina los datos correspondientes de un tipo de beneficio. Por otra parte elimina el registro del proceso de cuando se realizo la carga para solo dejar los 
        /// registros de procesos que estan vigentes en la base de datos
        /// </summary>
        /// <param name="fechaContabilizacion">Fecha ingresada por usuario</param>
        /// <param name="tipoBeneficio">Tipo de beneficios</param>
        public void EliminarDatosTipoBeneficio(string fechaContabilizacion, int tipoBeneficio)
        {
            CargaInformacionDAL data = new CargaInformacionDAL();

            data.EliminarDatosTipoBeneficio(fechaContabilizacion, tipoBeneficio);
        }

        /// <summary>
        /// verifica la existencia de informacion para el tipo de benficio especificado
        /// </summary>
        /// <param name="tipoBeneficio">Tipo de beneficio</param>
        /// <param name="fechaContabilidad">Fecha ingresada por el usuario</param>
        /// <returns></returns>
        public int ExisteInformacionRegistrosMarcados(int tipoBeneficio, string fechaContabilidad)
        {
            CargaInformacionDAL data = new CargaInformacionDAL();

            if (tipoBeneficio == 1)
            {
                return data.ExisteInformacionHerencia(fechaContabilidad);
            }
            else if(tipoBeneficio == 2)
            {
                return data.ExisteInformacionCuotasMortuorias(fechaContabilidad);
            }
            else if(tipoBeneficio == 3)
            {
                return data.ExisteInformacionExcedenteLibreDisposicion(fechaContabilidad);
            }
            else if (tipoBeneficio == 4)
            {
                return data.ExisteInformacionPagosAsesores(fechaContabilidad);
            }
            else if (tipoBeneficio == 5)
            {
                return data.ExisteInformacionTraspasoPrimaUno(fechaContabilidad);
            }
            else
            {
                return data.ExisteInformacionTraspasoPrimaDos(fechaContabilidad);    
            }
        }

        /// <summary>
        /// Obtiene el nombre correspondiente al módulo
        /// </summary>
        /// <param name="idCheckbox">id del item marcado</param>
        /// <returns>retorna el nombre del item marcado</returns>
        public string NombreItemPension(int idCheckbox)
        {
            string nombreModulo = String.Empty;

            switch (idCheckbox)
            {
                case 1:
                    nombreModulo = "Herencia";
                    break;
                case 2:
                    nombreModulo = "Cuotas Mortuorias";
                    break;
                case 3:
                    nombreModulo = "Excedente Libre Disposición";
                    break;
                case 4:
                    nombreModulo = "Pagos Asesores";
                    break;
                case 5:
                    nombreModulo = "Traspaso Prima Uno";
                    break;
                case 6:
                    nombreModulo = "Traspaso Prima Dos";
                    break;
            }

            return nombreModulo;
        }

        /// <summary>
        /// Obtiene lista de datos de cias de seguro
        /// </summary>
        /// <returns></returns>
        public static IList<CargaInformacionCiaSeguros> DesplegarDatosCiaSeguros()
        {
            CargaInformacionDAL data = new CargaInformacionDAL();
            return data.ObtenerDatosCiaSeguros();
        }

        /// <summary>
        /// Obtiene lista de datos de cias de seguro para Modal-consultar
        /// </summary>
        /// <param name="nombreCiaSeguro"></param>
        /// <returns></returns>
        public static IList<CargaInformacionCiaSeguros> DesplegarDatosModalCiaSeguros(string nombreCiaSeguro)
        {
            CargaInformacionDAL data = new CargaInformacionDAL();
            return data.ObtenerDatosModalCiaSeguros(nombreCiaSeguro);
        }

        /// <summary>
        /// Inserta nueva Cia de seguros
        /// </summary>
        /// <param name="rutCia"></param>
        /// <param name="nombreCia"></param>
        /// <param name="codigoCia"></param>
        /// <param name="direccionCia"></param>
        /// <returns>0: Exitoso, 1:Ocurrio problema</returns>
        public static int InsertarNuevaCiaSeguro(string rutCia, string nombreCia, int codigoCia, string direccionCia)
        {
            CargaInformacionDAL data = new CargaInformacionDAL();
             int resultado = data.InsertarNuevaCiaSeguro(rutCia, nombreCia, codigoCia, direccionCia);
            return resultado;
        }              
        
        /// <summary>
        /// Actualiza datos Cía de seguro
        /// </summary>
        /// <param name="rutCia"></param>
        /// <param name="nombreCia"></param>
        /// <param name="codigoCia"></param>
        /// <param name="direccionCia"></param>
        /// <returns></returns>
        public static int ActualizarDatosCiaSeguro(string rutCia, string nombreCia, int codigoCia, string direccionCia)
        {
            CargaInformacionDAL data = new CargaInformacionDAL();
            int resultado = data.ActualizarDatosCiaSeguro(rutCia, nombreCia, codigoCia, direccionCia);
            return resultado;
        }

        /// <summary>
        /// Elimina registro Cía de seguro
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns></returns>
        public static int EliminarCiaSeguro(string codigo)
        {
            CargaInformacionDAL data = new CargaInformacionDAL();
            int resultado = data.EliminarCiaSeguro(codigo);
            return resultado;
        }

        #endregion
                                
    }
}
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   