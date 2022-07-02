using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capaDeNegocio;
using capaDeDatos;

namespace LABOR_2
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
            NEGOCIO.cargarTrabajadores();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void cargarPersona(String pNombre)
        {
            
            foreach (TRABAJADOR oTrabajador in NEGOCIO.listTrabajador)
            {
                if (pNombre == oTrabajador.Nombre)
                {
                    txtBoxNombre.Text = oTrabajador.Nombre;
                    txtBoxPrimerApellido.Text = oTrabajador.Apellido1;
                    txtBoxSegundoApellido.Text = oTrabajador.Apellido2;
                    txtBoxEdad.Text = oTrabajador.Edad.ToString();
                    txtBoxTelefono.Text = oTrabajador.Telefono.ToString();
                    txtBoxDireccion.Text = oTrabajador.Direccion;
                    txtBoxCargo.Text = oTrabajador.TipoCargo;
                    txtBoxHorasTrabajadas.Text = oTrabajador.HorasTrabajadas.ToString();
                    txtBoxHorasTrabajadas.Text = oTrabajador.TipoJornada;

                    MessageBox.Show("Persona encontrada");
                }
                else
                {
                    MessageBox.Show("Persona no encontrada");
                }

            }

        }

        private void btnBuscarEmpleado_Click(object sender, EventArgs e)
        {
            cargarPersona(txtBoxNombreBuscar.Text);
        }
    }
}
