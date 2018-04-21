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


namespace FrmExamen
{
    public partial class FrmPronosticoCiudades : Form
    {
        private WSMeteorologicoClient ws;
        public FrmPronosticoCiudades()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void PronosticoCiudades_Load(object sender, EventArgs e)
        {
            ws = new WSMeteorologicoClient("WSMeteorologico");
            Console.WriteLine(ws.pronosticoPorCiudad(new pronosticoCiudad()));
            
        }
    }
}
