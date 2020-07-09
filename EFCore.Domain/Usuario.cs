using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCore.Domain
{
    public class Usuario
    {
        //------------------------------------------------------------------------------------
        [MaxLength(8)] [Key]
        public int UsuCod { get; set; }

        //------------------------------------------------------------------------------------
        [Column(TypeName = Type.Type.VarChar75)]
        public string UsuNom { get; set; } = null!;

        //------------------------------------------------------------------------------------
        [Column(TypeName = Type.Type.Status_AtivoInativo)]
        public Status_AtivoInativo? UsuSts { get; set; }// '?' => null = true

        //------------------------------------------------------------------------------------
        [Column(TypeName = Type.Type.Tipo_Usuario)]
        public string UsuTip { get; set; } = null!;

        //------------------------------------------------------------------------------------
    }
}
