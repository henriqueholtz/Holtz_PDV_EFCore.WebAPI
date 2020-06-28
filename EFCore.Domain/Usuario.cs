using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore.Domain
{
    public class Usuario
    {
        public int UsuCod { get; set; }
        public string UsuNom { get; set; }
        public string UsuSts { get; set; }
        public string UsuTip { get; set; }

    }
}
