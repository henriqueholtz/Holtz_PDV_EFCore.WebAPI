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
        [MaxLength(8)] [ForeignKey("empresa")]
        public int EmpCod { get; set; }
        public Empresa empresa { get; set; }
        //------------------------------------------------------------------------------------
        [MaxLength(8)][Key]
        public int PesCod { get; set; }
        //------------------------------------------------------------------------------------
        [Column(TypeName = Type.Type.VARCHAR150)]
        public string PesRaz { get; set; } = null!;
        //------------------------------------------------------------------------------------
        [Column(TypeName = Type.Type.VARCHAR150)]
        public string PesFan { get; set; } = null!;
        //------------------------------------------------------------------------------------
        [Column(TypeName = Type.Type.CPF_CNPJ)]
        public string PesCpfCnpj { get; set; } = null!;
        //------------------------------------------------------------------------------------
        [Column(TypeName = Type.Type.STATUS_ATIVO_INATIVO)]
        public Status_AtivoInativo? PesSts { get; set; }// '?' => null = true
        //------------------------------------------------------------------------------------
    }
}
