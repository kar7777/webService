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
            MessageBox.Show(list.Count.ToString());
        }

        private void bunifuDropdown1_onItemSelected(object sender, EventArgs e)
        {
          
        }
    }
}
