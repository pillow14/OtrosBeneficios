
namespace Cl.Ing.Pensiones.Beneficios.Bel
{
    public class EliminarRegistrosDuplicados
    {
        #region Miembros

        //Declaración de miembros 
        public int IdCarga { get; set; }
        public string RutCausante { get; set; }
        public string RutReceptor { get; set; }
        public string ViaPago { get; set; }
        public string TipoModalidad { get; set; }
        public string TipoPension { get; set; }
        public int Sucursal { get; set; }
        public double TotalLiquido { get; set; }
        public int TipoBeneficio { get; set; }
        public string FechaContabilizacion { get; set; }
        public string Id { get; set; }
        #endregion
    }
}
