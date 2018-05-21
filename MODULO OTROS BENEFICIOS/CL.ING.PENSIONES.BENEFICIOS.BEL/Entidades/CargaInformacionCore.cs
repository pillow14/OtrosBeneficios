using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cl.Ing.Pensiones.Beneficios.Bel
{
   public class CargaInformacionCore
   {
       #region Miembros

       private string personaID = string.Empty;
       private string apellidoPaterno = string.Empty;
       private string apellidoMaterno = string.Empty;
       private string nombres = string.Empty;
       private string fechaSolicitud = string.Empty;
       private string fechaAcreditacion = string.Empty;
       private string fechaContabilizacion = string.Empty;
       private string fechaDisponibilidad = string.Empty;
       private double valorMlSaldo;
       private string valorUfSaldo = string.Empty;
       private string receptorPagoID = string.Empty;
       private string fechaPago = string.Empty;
       private int numeroChequePago;
       private int codigoAgenciaSolicitud;
       private string tipoTramite = string.Empty;
       private string tipoViaPago = string.Empty;
       private string receptorPagoID1 = string.Empty;
       private int codigoInstitucionFinacieraDeposito;
       private int tipoCuentaDeposito;
       private string numeroCuentaDeposito = string.Empty;
       private int codigoAgenciaPagoRegimen;
       private string descripcion = string.Empty;
       private string direccion = string.Empty;
       private int codigoComuna;
       private string descripcionComuna = string.Empty;
       private int regionID;
       private string descripcionRegion = string.Empty;
       private string ciudad = string.Empty;
       private string tipoModalidad = string.Empty;
       private int codigoACP;
       private int montoPesosBruto;
       private string montoUfBruto = string.Empty;
       private int montoCuotaBruto;
       private int impuestoPesos;
       private int impuestoCuotas;
       private string impuestoUf = string.Empty;
       private int folioCheque;
       private string tipoPension = string.Empty;
       private int clienteID;
       private int numeroTramite;
       private string nombreReceptor = string.Empty;

       #endregion

       #region Propiedades

       /// <summary>
       /// Obtiene o asigna el id de la persona
       /// </summary>
       public string PersonaID
       {
           set { personaID = value; }
           get { return personaID; }
       }

       /// <summary>
       /// Obtiene o asigna el Apellido Paterno
       /// </summary>
       public string ApellidoPaterno
       {
           set { apellidoPaterno = value; }
           get { return apellidoPaterno; }
       }

       /// <summary>
       /// Obtiene o asigna el Apellido Materno
       /// </summary>
       public string ApellidoMaterno
       {
           set { apellidoMaterno = value; }
           get { return apellidoMaterno; }
       }

       /// <summary>
       /// Obtiene o asigna los Nombres
       /// </summary>
       public string Nombres
       {
           set { nombres = value; }
           get { return nombres; }
       }

       /// <summary>
       /// Obtiene o asigna la Fecha de Solicitud
       /// </summary>
       public string FechaSolicitud
       {
           set { fechaSolicitud = value; }
           get { return fechaSolicitud; }
       }

       /// <summary>
       /// Obtiene o asigna la Fecha de Acreditacion
       /// </summary>
       public string FechaAcreditacion
       {
           set { fechaAcreditacion = value; }
           get { return fechaAcreditacion; }
       }

       /// <summary>
       /// Obtiene o asigna la Fecha de Contabilización
       /// </summary>
       public string FechaContabilizacion
       {
           set { fechaContabilizacion = value; }
           get { return fechaContabilizacion; }
       }

       /// <summary>
       /// Obtiene o asigna la Fecha de Disponibilidad
       /// </summary>
       public string FechaDisponibilidad
       {
           set { fechaDisponibilidad = value; }
           get { return fechaDisponibilidad; }
       }

       /// <summary>
       /// Obtiene o asigna el valor ML Saldo
       /// </summary>
       public double ValorMLSaldo { get; set; }

       /// <summary>
       /// Obtiene o asigna el valor de UF de Saldo
       /// </summary>
       public string ValorUFSaldo
       {
           set { valorUfSaldo = value;}
           get { return valorUfSaldo; }
       }

       /// <summary>
       /// Obtiene o asigna el Receptor de Pago ID
       /// </summary>
       public string ReceptorPagoID
       {
           set { receptorPagoID = value; }
           get { return receptorPagoID; }
       }

       /// <summary>
       /// Obtiene o asigna la Fecha de Pago
       /// </summary>
       public string FechaPago
       {
           set { fechaPago = value; }
           get { return fechaPago; }
       }

       /// <summary>
       /// Obtiene o asigna el número de Cheque de pago
       /// </summary>
       public int NumeroChequePago
       {
           set { numeroChequePago = value; }
           get { return numeroChequePago; }
       }

       /// <summary>
       /// Obtiene o asigna el codigo de agencia de solicitud
       /// </summary>
       public int CodigoAgenciaSolicitud
       {
           set { codigoAgenciaSolicitud = value; }
           get { return codigoAgenciaSolicitud; }
       }

       /// <summary>
       /// Obtiene o asigna el tipo de Trámite
       /// </summary>
       public string TipoTramite
       {
           set { tipoTramite = value; }
           get { return tipoTramite; }
       }

       /// <summary>
       /// Obtiene o asigna el Tipo de Via de pago
       /// </summary>
       public string TipoViaPago
       {
           set { tipoViaPago = value; }
           get { return tipoViaPago; }
       }

       /// <summary>
       /// Obtiene o asigna el Receptor de pago ID 1
       /// </summary>
       public string ReceptorPagoID1
       {
           set { receptorPagoID1 = value; }
           get { return receptorPagoID1; }
       }
              
       /// <summary>
       /// Obtiene o asigna el Codigo de la institucion financiera deposito
       /// </summary>
       public int CodigoInstitucionFinacieraDeposito
       {
           set { codigoInstitucionFinacieraDeposito = value; }
           get { return codigoInstitucionFinacieraDeposito; }
       }

       public int TipoCuentaDeposito
       {
           set { tipoCuentaDeposito = value; }
           get { return tipoCuentaDeposito; }
       }
       /// <summary>
       /// Obtiene o asigna el Numero de cuenta de deposito
       /// </summary>
       public string NumeroCuentaDeposito
       {
           set { numeroCuentaDeposito = value; }
           get { return numeroCuentaDeposito; }
       }

       /// <summary>
       /// Obtiene o asigna el Codigo de Agencia de Pago de Regimen
       /// </summary>
       public int CodigoAgenciaPagoRegimen
       {
           set { codigoAgenciaPagoRegimen = value; }
           get { return codigoAgenciaPagoRegimen; }
       }

       /// <summary>
       /// Obtiene o asigna la descripcion
       /// </summary>
       public string Descripcion
       {
           set { descripcion = value; }
           get { return descripcion; }
       }

       /// <summary>
       /// Obtiene o asigna la direccion
       /// </summary>
       public string Direccion
       {
           set { direccion = value; }
           get { return direccion; }
       }

       /// <summary>
       /// Obtiene o asigna el codigo de la comuna
       /// </summary>
       public int CodigoComuna
       {
           set { codigoComuna = value; }
           get { return codigoComuna; }
       }

       /// <summary>
       /// Obtiene o asigna la descripcion de la comuna
       /// </summary>
       public string DescripcionComuna
       {
           set { descripcionComuna = value; }
           get { return descripcionComuna; }
       }

       /// <summary>
       /// Obtiene o asigna el id de la region
       /// </summary>
       public int RegionID
       {
           set { regionID = value; }
           get { return regionID; }
       }

       /// <summary>
       /// Obtiene o asigna la descripcion de la region
       /// </summary>
       public string DescripcionRegion
       {
           set { descripcionRegion = value; }
           get { return descripcionRegion; }
       }

       /// <summary>
       /// Obtiene o asigna la Ciudad
       /// </summary>
       public string Ciudad
       {
           set { ciudad = value; }
           get { return ciudad; }
       }

       /// <summary>
       /// Obtiene o asigna el tipo de modalidad
       /// </summary>
       public string TipoModalidad
       {
           set { tipoModalidad = value; }
           get { return tipoModalidad; }
       }

       /// <summary>
       /// Obtiene o asigna el Codigo ACP
       /// </summary>
       public int CodigoACP
       {
           set { codigoACP = value; }
           get { return codigoACP; }
       }

       /// <summary>
       /// Obtiene o asigna el monto bruto en pesos
       /// </summary>
       public int MontoPesosBruto
       {
           set { montoPesosBruto = value; }
           get { return montoPesosBruto; }
       }

       /// <summary>
       /// Obtiene o asigna el monto bruto en UF
       /// </summary>
       public string MontoUFBruto
       {
           set { montoUfBruto = value; }
           get { return montoUfBruto; }
       }

       /// <summary>
       /// Obtiene o asigna el monto bruto en cuota
       /// </summary>
       public int MontoCuotaBruto
       {
           set { montoCuotaBruto = value; }
           get { return montoCuotaBruto; }
       }

       /// <summary>
       /// Obtiene o asigna el impuesto en pesos
       /// </summary>
       public int ImpuestoPesos
       {
           set { impuestoPesos = value; }
           get { return impuestoPesos; }
       }

       /// <summary>
       /// Obtiene o asigna el impuesto en cuotas
       /// </summary>
       public int ImpuestoCuotas
       {
           set { impuestoCuotas = value; }
           get { return impuestoCuotas; }
       }

       /// <summary>
       /// Obtiene o asigna el impuesto en UF
       /// </summary>
       public string ImpuestoUF
       {
           set { impuestoUf = value; }
           get { return impuestoUf; }
       }

       /// <summary>
       /// Obtiene o asigna el folio Cheque
       /// </summary>
       public int FolioCheque
       {
           set { folioCheque = value; }
           get { return folioCheque; }
       }      
       
       /// <summary>
       /// Obtiene o asigna el Tipo de Pension
       /// </summary>
       public string TipoPension
       {
           set { tipoPension = value; }
           get { return tipoPension; }
       }
              
       /// <summary>
       /// Obtiene o asigna el ID del Cliente
       /// </summary>
       public int ClienteID
       {
           set { clienteID = value; }
           get { return clienteID; }
       }

       /// <summary>
       /// Obtiene o asigna el proceso de carga ID
       /// </summary>
       public int NumeroTramite
       {
           set { numeroTramite = value; }
           get { return numeroTramite; }
       }

       /// <summary>
       /// Obtiene o asigna el nombre del Receptor
       /// </summary>
       public string NombreReceptor
       {
           set { nombreReceptor = value; }
           get { return nombreReceptor; }
       }

       #endregion

       //#region Miembros Repiter

       //public int NroError { get; set; }

       //public string mensaje { get; set; }

       //#endregion
   }
}
