using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_DTO
{
    public class Papel
    {
        private string _tipoPapel;
        private int _pesoPapel;
        private int _precioPapel;

        public int PrecioPapel
        {
            get { return _precioPapel; }
            set { _precioPapel = value; }
        }
        
        public int PesoPapel
        {
            get { return _pesoPapel; }
            set { _pesoPapel = value; }
        }
        
        public string TipoPapel
        {
            get { return _tipoPapel; }
            set { _tipoPapel = value; }
        }
        
    }
}
