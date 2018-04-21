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
        public List<PRONOSTICO_PORCIUDADESCIUDAD> PronosticoCiudades()
        {
            List<PRONOSTICO_PORCIUDADESCIUDAD> list = new List<PRONOSTICO_PORCIUDADESCIUDAD>();
            PRONOSTICO_PORCIUDADES pc = ws.pronosticoPorCiudad(new pronosticoCiudad()).ParseXML<PRONOSTICO_PORCIUDADES>();
            for (int i = 0; i < pc.CIUDADES.Length; i++)
            {
                list.Add(pc.CIUDADES[i] );
            }

            return list;

        }

    }
}
