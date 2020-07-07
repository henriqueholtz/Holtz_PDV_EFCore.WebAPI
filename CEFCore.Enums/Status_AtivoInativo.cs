using System;
using System.Collections.Generic;
using System.Text;

namespace EFCore.Enums
{
    public enum Status_AtivoInativo
    {
        ATIVO = 'A',
        INATIVO = 'I'
    } 
}
namespace Type
{
    public class Status_AtivoInativo
    {
        public static string Type => "VARCHAR(1)";
    }
}
