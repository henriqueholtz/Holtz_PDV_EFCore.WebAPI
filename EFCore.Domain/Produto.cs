using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore.Domain
{
    public class Produto
    {
        public int EmpCod { get; set; }
        public int ProCod { get; set; }
        public string ProNom { get; set; }
        public string ProObs { get; set; }
        public string ProNcm { get; set; }
    }
}
