using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace Holtz_PDV_EFCore.WebAPI.Models
{
    public class Pessoa
    {
        public int EmpCod { get; set; }
        public int PesCod { get; set; }
        public string PesRaz { get; set; }
        public string PesFan { get; set; }
        public string PesCpfCnpj { get; set; }
    }
}
