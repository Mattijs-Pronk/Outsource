using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccesLayer;

namespace BusinessLogicLayer
{
    class Vaardigheid
    {
        public int Id { get; }

        public string Vaardigheden { get; set; }

        public Vaardigheid(VaardigheidDTO vaardigheid)
        {
            this.Id = vaardigheid.Id;
            this.Vaardigheden = vaardigheid.Vaardigheid;
        }
    }
}
