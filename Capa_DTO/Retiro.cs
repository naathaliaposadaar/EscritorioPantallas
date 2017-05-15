using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_DTO
{
   public class Retiro
    {
        private string _direccion;
        private Char _estadoRetiro;

        public Char EstadoRetiro
        {
            get { return _estadoRetiro; }
            set { _estadoRetiro = value; }
        }
        
        public string Direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }
        
    }
}
