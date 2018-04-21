using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamenDAO;
using Examen;

namespace ExamenBO
{  
    
    public  class PronosticoCiudadesBO
    { 
        //declarar, instacia
        private PronosticoCiudadesDAO dao;
        //inicializar instancia
        public PronosticoCiudadesBO()
        {
            dao = new PronosticoCiudadesDAO();
        }
        public List<PRONOSTICO_PORCIUDADESCIUDAD> PronosticoCiudades()
        {
            //buscar metodo de la lista
            return dao.PronosticoCiudades();
        }
        
    }
    
}
