using System;
using System.Collections.Generic;
using System.Linq;
//using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using EFCore.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCore.Domain
{
    public class Pessoa
    {

        [MaxLength(8)]
        [ForeignKey("empresa")]
        public int EmpCod { get; set; }
        public Empresa empresa { get; set; }

        [MaxLength(8)][Key]
        public int PesCod { get; set; }
        [StringLength(130)]
        public string PesRaz { get; set; } = null!;
        [StringLength(130)]
        public string PesFan { get; set; } = null!;
        [StringLength(18)]
        public string PesCpfCnpj { get; set; } = null!;
        [StringLength(1)]
        public Status_AtivoInativo? PesSts { get; set; }// '?' => null = true
    }
}
