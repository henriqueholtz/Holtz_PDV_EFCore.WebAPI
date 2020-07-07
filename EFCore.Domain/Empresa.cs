using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using EFCore.Enums;

namespace EFCore.Domain
{
    public class Empresa
    {
        [MaxLength(8)] [Key]
        public int EmpCod { get; set; }
        [StringLength(130)]
        public string EmpRaz { get; set; } = null!;
        [StringLength(130)]
        public string EmpFan { get; set; } = null!;
        [StringLength(18)]
        public string EmpCpfCnpj { get; set; } = null!;
        [StringLength(1)]
        public Status_AtivoInativo? EmpSts { get; set; }// '?' => null = true
        public override string ToString() //override sobreescreve o método, no caso o ToString()
        {
            StringBuilder sb = new StringBuilder(); //mais eficiente que concatenar varias strings
            sb.Append(EmpCod + " - " + EmpRaz);
            return sb.ToString();
        }
    }
}
