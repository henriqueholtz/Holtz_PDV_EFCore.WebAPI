using System.ComponentModel.DataAnnotations;
using Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCore.Domain
{
    public class Produto
    {
        //------------------------------------------------------------------------------------
        [MaxLength(8)] [ForeignKey("empresa")] 
        public int EmpCod { get; set; } 
        public Empresa empresa { get; set; }

        //------------------------------------------------------------------------------------
        [MaxLength(8)][Key] 
        public int ProCod { get; set; }

        //------------------------------------------------------------------------------------
        [Column(TypeName = Type.Type.VARCHAR150)] 
        public string ProNom { get; set; }

        //------------------------------------------------------------------------------------
        [Column(TypeName = Type.Type.VARCHAR1000)] 
        public string ProObs { get; set; }

        //------------------------------------------------------------------------------------
        [Column(TypeName = Type.Type.VARCHAR50)] 
        public string ProNcm { get; set; }

        //------------------------------------------------------------------------------------
        [Column(TypeName = Type.Type.STATUS_ATIVO_INATIVO)]
        public Status_AtivoInativo? ProSts { get; set; }// '?' => null = true

        //------------------------------------------------------------------------------------
    }
}
