using System;

namespace Domain.Enum
{
    [Obsolete("Classe obsoleta, substituída pela nova engenharia de comunicação com a base de dados")]
    public enum StatusSalaEnum
    {
        Reservada,
        Ocupada,
        Disponivel
    }
}
