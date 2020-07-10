namespace Enums
{

    /***************\
          STATUS
    \***************/
    public enum Status_AtivoInativo : byte
    {
        ATIVO = 1,
        INATIVO = 0
    }
    public enum Status_Duplicata : byte
    {
        ABERTA = 1,
        CANCELADA = 2
    }


    /***************\
         TIPOS
    \***************/
    public enum Tipo_Usuario : byte
    {
        SUPORTE = 1
    }
}
