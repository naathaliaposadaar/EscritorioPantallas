using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_DTO
{
   public class Donacion
    {
        private DateTime _fechaDonacion;
        private Char _estado;
        
        
        public Char Estado
        {
            get { return _estado; }
            set { _estado = value; }
        }
        
        public DateTime FechaDonacion
        {
            get { return _fechaDonacion; }
            set { _fechaDonacion = value; }
        }
        
    }
}
