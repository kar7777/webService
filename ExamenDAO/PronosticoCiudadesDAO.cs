using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamenDAO.WSM;
using Examen;

namespace ExamenDAO  
{

    public  class PronosticoCiudadesDAO
    {
        private WSMeteorologicoClient ws;

        public PronosticoCiudadesDAO()
        {
            ws = new WSMeteorologicoClient("WSMeteorologico");
        }   
    }
}
