
using EFCore.Enums;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCore.Domain
{
    public class Duplicata
    {
        //------------------------------------------------------------------------------------
        [MaxLength(8)]
        [ForeignKey("empresa")]
        public int EmpCod { get; set; }
        public Empresa empresa { get; set; }

        //------------------------------------------------------------------------------------
        [MaxLength(8)] [Key]
        public int CreCod { get; set; }

        //------------------------------------------------------------------------------------
        public DateTime CreDtaEms { get; set; }
        public DateTime CreDtaVct { get; set; }

        //------------------------------------------------------------------------------------
        public Moeda CreVlrSdo { get; set; } = null!;
        public Moeda CreVlrDup { get; set; } = null!;

        //------------------------------------------------------------------------------------
    }
}
