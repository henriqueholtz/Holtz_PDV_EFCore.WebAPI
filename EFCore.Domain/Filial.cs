using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCore.Domain
{
    public class Filial
    {
        [MaxLength(8)]
        [ForeignKey("empresa")]
        public int EmpCod { get; set; }
        public Empresa empresa { get; set; }

        [MaxLength(8)][Key]
        public int FilCod { get; set; }
        [StringLength(130)]
        public string FilRaz { get; set; } = null!;
        [StringLength(130)]
        public string FilFan { get; set; } = null!;
    }
}
