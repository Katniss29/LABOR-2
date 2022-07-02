using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaDeDatos
{
    public class TRABAJADOR : PERSONA
    {

        private String tipoCargo;
        private double horasTrabajadas;
        private String tipoJornada;

        public TRABAJADOR(String pNombre, String pApellido1,
                       String pApellido2, int pEdad, int pTelefono, String pDireccion ,String pTipoCargo, double pHorasTrabajadas, String pTipoJornada)
            : base ( pNombre,  pApellido1, pApellido2,  pEdad,  pTelefono,  pDireccion)
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
