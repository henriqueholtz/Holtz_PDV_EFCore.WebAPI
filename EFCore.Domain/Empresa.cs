using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Enums;
using System.ComponentModel.DataAnnotations.Schema;
using EFCore.Type;

namespace EFCore.Domain
{
    public class Empresa
    {
        //------------------------------------------------------------------------------------
        [MaxLength(8)] [Key]
        public int EmpCod { get; set; }

        //------------------------------------------------------------------------------------
        [Column(TypeName = Type.Type.VarChar150)]
        public string EmpRaz { get; set; } = null!;

        //------------------------------------------------------------------------------------
        [Column(TypeName = Type.Type.VarChar150)]
        public string EmpFan { get; set; } = null!;

        //------------------------------------------------------------------------------------
        [Column(TypeName = Type.Type.CpfCnpj)]
        public string EmpCpfCnpj { get; set; } = null!;

        //------------------------------------------------------------------------------------
        [Column(TypeName = Type.Type.Status_AtivoInativo)]
        public Status_AtivoInativo? EmpSts { get; set; }// '?' => null = true

        //------------------------------------------------------------------------------------

        public override string ToString() //override sobreescreve o método, no caso o ToString()
        {
            StringBuilder sb = new StringBuilder(); //mais eficiente que concatenar varias strings
            sb.Append(EmpCod + " - " + EmpRaz);
            return sb.ToString();
        }
    }
}
