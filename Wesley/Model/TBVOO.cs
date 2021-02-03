using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wesley.Model
{
    public class TBVOO
    {
        public int ID_VOO { get; set; }
        public DateTime DATA_VOO { get; set; }
        public decimal CUSTO { get; set; }
        public int DISTANCIA { get; set; }
        public string CAPTURA { get; set; }
        public int NIVEL_DOR { get; set; }
    }
}
