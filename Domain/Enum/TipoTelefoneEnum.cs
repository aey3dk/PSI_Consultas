using System;

namespace Domain.Enum
{
    [Obsolete("Classe obsoleta, substituída pela nova engenharia de comunicação com a base de dados")]
    public enum TipoTelefoneEnum
    {
        Celular,
        Comercial,
        Recado,
        Residencial
    }
}
