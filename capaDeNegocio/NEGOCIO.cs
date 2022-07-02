using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capaDeDatos;

namespace capaDeNegocio
{
    public  class NEGOCIO
    {
        public static List<TRABAJADOR> listTrabajador;
        public NEGOCIO()
        {
            listTrabajador = new List<TRABAJADOR>();
        }

        public static void cargarTrabajadores()
        {
            String ruta = "TRABAJADORES.TXT";

            if (File.Exists(ruta))
            {
                TextReader trabajadores = new StreamReader(ruta);
                String leerLinea = trabajadores.ReadLine();

                if (leerLinea != "")
                {
                    while (leerLinea != null)
                    {
                        string[] cargarDatos = leerLinea.Split(',');
                        listTrabajador.Add(new TRABAJADOR(cargarDatos[0], cargarDatos[1], cargarDatos[2], int.Parse(cargarDatos[3]),
                            int.Parse(cargarDatos[4]), cargarDatos[5], cargarDatos[6], int.Parse(cargarDatos[7]), cargarDatos[8]));
                        leerLinea = trabajadores.ReadLine();


                    }
                }
                else
                {
                    MessageBox.Show("NO SE ENCUENTRAN DATOS EN EL ARCHIVO");
                }
                trabajadores.Close();
            }
            else
            {
                MessageBox.Show("NO SE ENCONTRO EL ARCHIVO");
            }


        }

        public double calcularSalario(String pTipoJornada, int pHorasTrabajadas,int pHorasDiurnas, int pHorasNocturnas)
        {
            double salario = 0;
            int costoDiurno = 15;
            int costoNocturno = 25;
            if (pTipoJornada.Equals("diurna"))
            {
                salario = pHorasTrabajadas * costoDiurno;
            }else if (pTipoJornada.Equals("nocturna"))
            {
                salario = pHorasTrabajadas * costoDiurno;
            }else if (pTipoJornada.Equals("Mixta"))
            {
                salario = (pHorasDiurnas * costoDiurno) + (pHorasNocturnas * costoNocturno);
            }

            return salario;
        }

        public double impuestos(double pIngresos)
        {
            double impuestos = 0;
            double impuesto1 = 0.09;
            double impuesto2 = 0.12;
            if (pIngresos >= 3000 && pIngresos <= 5000)
            {
                double temp = pIngresos * impuesto1;
                impuestos = pIngresos + temp;
            }else if ( pIngresos > 5000)
            {
                double temp = pIngresos * impuesto2;
                impuestos = pIngresos + temp;
            }

            return impuestos;
        }
    }
}
