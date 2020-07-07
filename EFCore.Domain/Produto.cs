using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using EFCore.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCore.Domain
{
    public class Produto
    {
        [MaxLength(8)]
        [ForeignKey("empresa")]
        public int EmpCod { get; set; }
        public Empresa empresa { get; set; }

        [MaxLength(8)][Key]
        public int ProCod { get; set; }
        [StringLength(130)]
        public string ProNom { get; set; }
        [StringLength(1000)]
        public string ProObs { get; set; }
        [StringLength(50)]
        public string ProNcm { get; set; }
        [StringLength(1)]
        public Status_AtivoInativo? ProSts { get; set; }// '?' => null = true
    }
}
