using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaDeDatos
{
    public class DUENNO
    {
        private String tipoCargoAdministrativo;
        private int cantidadAcciones;

        public DUENNO(String pTipoCargoAdministrativo, int pCantidadAcciones)
        {
            this.tipoCargoAdministrativo = pTipoCargoAdministrativo;
            this.cantidadAcciones = pCantidadAcciones;
        }

        public DUENNO()
        {

        }

        public String TipoCargoAdministrativo
        {
            get { return tipoCargoAdministrativo; }
            set { tipoCargoAdministrativo = value; }
        }

        public int CantidadAcciones
        {
            get { return cantidadAcciones; }
            set { cantidadAcciones = value; }
        }
    }
}
