using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore.Domain
{
    public class Empresa
    {
        public int EmpCod { get; set; }
        public string EmpRaz { get; set; }
        public string EmpFan { get; set; }
        public string EmpCpfCnpj { get; set; }
        public string EmpSts { get; set; }
    }
}
