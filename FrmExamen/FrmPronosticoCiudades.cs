using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrmExamen.WSM;
using ExamenBO;
using Examen;


namespace FrmExamen
{
    public partial class FrmPronosticoCiudades : Form

    {   //instancia
        private PronosticoCiudadesBO bo;
        private WSMeteorologicoClient ws;
        private List<PRONOSTICO_PORCIUDADESCIUDAD> list;

        public FrmPronosticoCiudades()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void PronosticoCiudades_Load(object sender, EventArgs e)
        {
            ws = new WSMeteorologicoClient("WSMeteorologico");
            Console.WriteLine(ws.pronosticoPorCiudad(new pronosticoCiudad()));

            //inicializar
            bo = new PronosticoCiudadesBO();
           list = bo.PronosticoCiudades();

            LlenarCbx();
            cbx.SelectedIndex = 9;
        }

        public void LlenarCbx()
        {
            foreach (PRONOSTICO_PORCIUDADESCIUDAD ciudad in list)
            {
                cbx.Items.Add(ciudad.nombre);
               
            }

        }

        private void cbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            rtxtMessage.Text = "";
            string ciudad = cbx.SelectedItem.ToString();
            foreach (PRONOSTICO_PORCIUDADESCIUDAD c in list)
            {
                if (c.nombre.Equals(ciudad))

                {
                    //if (c.ESTADOMADRUGADA != null)
                    //{
                    //    rtxtMessage.Text += Environment.NewLine + "El pronóstico para esta Madrugada es: " + c.ESTADOMADRUGADA.Value;
                    //pbxMadrugada.ImageLocation = String.Format("https://www.imn.ac.cr{0}", c.ESTADOMADRUGADA.imgPath);
                    //}
                    //if (c.ESTADOMANANA != null)
                    //{
                    //    rtxtMessage.Text += Environment.NewLine + "El pronóstico para esta Mañana es: " + c.ESTADOMANANA.Value;
                    //   pbxManana.ImageLocation = String.Format("https://www.imn.ac.cr{0}", c.ESTADOMANANA.imgPath);
                    //}
                    if (c.ESTADOTARDE != null)
                    {
                       rtxtMessage.Text += Environment.NewLine + "El pronóstico para esta Tarde es: " +c.ESTADOTARDE.Value;
                        pbxTarde.ImageLocation = String.Format("https://www.imn.ac.cr{0}", c.ESTADOTARDE.imgPath);
                    }
                   if(c.ESTADONOCHE != null)
                    {
                        rtxtMessage.Text += Environment.NewLine + "El pronóstico para esta Noche es: " + c.ESTADONOCHE.Value;
                        pbxNoche.ImageLocation = String.Format("https://www.imn.ac.cr{0}", c.ESTADONOCHE.imgPath);
                    }



                }

            }
        }
    }
}
