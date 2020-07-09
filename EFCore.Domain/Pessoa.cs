using System;
using System.Collections.Generic;
using System.Linq;
//using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Enums;

namespace EFCore.Domain
{
    public class Pessoa
    {
        //------------------------------------------------------------------------------------
        [MaxLength(8)]
        [ForeignKey("empresa")]
        public int EmpCod { get; set; }
        public Empresa empresa { get; set; }
        //------------------------------------------------------------------------------------
        [MaxLength(8)][Key]
        public int PesCod { get; set; }
        //------------------------------------------------------------------------------------
        [Column(TypeName = Type.Type.VarChar150)]
        public string PesRaz { get; set; } = null!;
        //------------------------------------------------------------------------------------
        [Column(TypeName = Type.Type.VarChar150)]
        public string PesFan { get; set; } = null!;
        //------------------------------------------------------------------------------------
        [Column(TypeName = Type.Type.CpfCnpj)]
        public string PesCpfCnpj { get; set; } = null!;
        //------------------------------------------------------------------------------------
        [Column(TypeName = Type.Type.Status_AtivoInativo)]
        public Status_AtivoInativo? PesSts { get; set; }// '?' => null = true
        //------------------------------------------------------------------------------------
    }
}
