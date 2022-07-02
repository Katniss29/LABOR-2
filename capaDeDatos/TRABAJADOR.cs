using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaDeDatos
{
    public class TRABAJADOR
    {

        private String tipoCargo;
        private double horasTrabajadas;
        private String tipoJornada;

        public TRABAJADOR( String pTipoCargo, double pHorasTrabajadas, String pTipoJornada)
        {
            this.tipoCargo = pTipoCargo;
            this.horasTrabajadas = pHorasTrabajadas;
            this.tipoJornada = pTipoJornada;
        }

        public String TipoCargo
        {
            get { return tipoCargo; }
            set { tipoCargo = value; }
        }

        public double HorasTrabajadas
        {
            get { return horasTrabajadas; }
            set { horasTrabajadas = value; }
        }
        public String TipoJornada
        {
            get { return tipoJornada; }
            set { tipoJornada= value; }
        }

    }
}
