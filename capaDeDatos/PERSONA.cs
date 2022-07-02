using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaDeDatos
{
    public class PERSONA
    {

        private String nombre;
        private String apellido1;
        private String apellido2;
        private int edad;
        private int telefono;
        private String direccion;

        public PERSONA(String pNombre, String pApellido1, 
                       String pApellido2, int pEdad, int pTelefono,String pDireccion)
        {
            this.nombre = pNombre;
            this.apellido1 = pApellido1;
            this.apellido2 = pApellido2;
            this.edad = pEdad;
            this.telefono = pTelefono;
            this.direccion = pDireccion;
        }

        public PERSONA()
        {

        }

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }   
        }

        public String Apellido1
        {
            get { return apellido1; }
            set { apellido1 = value; }
        }

        public String Apellido2
        {
            get { return apellido2; }
            set { apellido2 = value; }
        }

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        public int Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public String Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }


    }
}
