using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaDeDatos
{
    public class DUENNO : PERSONA
    {
        private String tipoCargoAdministrativo;
        private int cantidadAcciones;
        

        public DUENNO(String pNombre, String pApellido1,
                       String pApellido2, int pEdad, int pTelefono, String pDireccion,String pTipoCargoAdministrativo, int pCantidadAcciones)
            : base ( pNombre,  pApellido1,
                        pApellido2,  pEdad, pTelefono,  pDireccion)
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
