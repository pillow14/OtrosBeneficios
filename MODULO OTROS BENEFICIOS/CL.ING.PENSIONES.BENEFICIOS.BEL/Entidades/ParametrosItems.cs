using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cl.Ing.Pensiones.Beneficios.Bel
{
    public class ParametrosItems
    {

        #region Miembros

            private int totalHerencia = 0;
            private int totalCuotasMortuorias = 0;
            private int totalExcedenteLibreDisposcion = 0;
            private int totalPagoAsesores = 0;
            private int totalPrimaUno = 0;
            private int totalPrimaDos = 0;
            private int marcaHerencia = 0;
            private int marcaCuotasMortuorias = 0;
            private int marcaExcedenteLibreDisposicion = 0;
            private int marcaPagoAsesores = 0;
            private int marcaPrimaUno = 0;
            private int marcaPrimaDos = 0;

        #endregion

        public int TotalHerencia
        {
            set{ totalHerencia = value; }
            get{ return totalHerencia; }
        }
        public int TotalCuotasMortuorias
        {
            set { totalCuotasMortuorias = value; }
            get { return totalCuotasMortuorias; }
        }
        public int TotalExcedenteLibreDisposcion
        {
            set{ totalExcedenteLibreDisposcion = value; }
            get{ return totalExcedenteLibreDisposcion; }
        }
        public int TotalPagoAsesores
        {
            set{ totalPagoAsesores = value; }
            get{ return totalPagoAsesores; }
        }
        public int TotalPrimaUno
        {
            set{ totalPrimaUno = value; }
            get{ return totalPrimaUno; }
        }
        public int TotalPrimaDos
        {
            set{ totalPrimaDos = value; }
            get{ return totalPrimaDos; }
        }
        public int MarcaHerencia
        {
            set{ marcaHerencia = value; }
            get{ return marcaHerencia; }
        }
        public int MarcaCuotasMortuorias
        {
            set{ marcaCuotasMortuorias = value; }
            get{ return marcaCuotasMortuorias; }
        }
        public int MarcaExcedenteLibreDisposicion
        {
            set{ marcaExcedenteLibreDisposicion = value; }
            get{ return marcaExcedenteLibreDisposicion; }
        }
        public int MarcaPagoAsesores
        {
            set{ marcaPagoAsesores = value; }
            get{ return marcaPagoAsesores; }
        }
        public int MarcaPrimaUno
        {
            set{ marcaPrimaUno = value; }
            get{ return marcaPrimaUno; }
        }
        public int MarcaPrimaDos
        {
            set{ marcaPrimaDos = value; }
            get{ return marcaPrimaDos; }
        }
    }
}
