using Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCore.Domain
{
    public class Marca
    {
        //------------------------------------------------------------------------------------
        [MaxLength(8)] [ForeignKey("empresa")]
        public int EmpCod { get; set; }
        public Empresa empresa { get; set; }

        //------------------------------------------------------------------------------------
        [MaxLength(8)][Key]
        public int MarCod { get; set; }

        //------------------------------------------------------------------------------------
        [Column(TypeName = Type.Type.VarChar50)]
        public string MarNom { get; set; } = null!;

        //------------------------------------------------------------------------------------
    }
}
