﻿using System;
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
        [Column(TypeName = Type.Type.VARCHAR75)]
        public string UsuNom { get; set; } = null!;

        //------------------------------------------------------------------------------------
        [Column(TypeName = Type.Type.STATUS_ATIVO_INATIVO)]
        public Status_AtivoInativo? UsuSts { get; set; }// '?' => null = true

        //------------------------------------------------------------------------------------
        [Column(TypeName = Type.Type.TIPO_USUARIO)]
        public Tipo_Usuario? UsuTip { get; set; }// = null!;

        //------------------------------------------------------------------------------------
    }
}
