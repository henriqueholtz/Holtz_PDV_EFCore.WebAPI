using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Holtz_PDV_EFCore.WebAPI.Models
{
    public class Usuario
    {
        public int UsuCod { get; set; }
        public string UsuNom { get; set; }
        public string UsuSts { get; set; }
        public string UsuTip { get; set; }

    }
}
