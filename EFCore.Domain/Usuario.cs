using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFCore.Enums;
using System.ComponentModel.DataAnnotations;

namespace EFCore.Domain
{
    public class Usuario
    {
        [MaxLength(8)] [Key]
        public int UsuCod { get; set; }
        [StringLength(70)]
        public string UsuNom { get; set; } = null!;
        [StringLength(1)]
        public Status_AtivoInativo? UsuSts { get; set; }// '?' => null = true
        [StringLength(1)]
        public string UsuTip { get; set; } = null!;
    }
}
