using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Interfaces
{
    public interface IEntidadeIdentidade
    {
        int Id { get; set; }
        DateTime Insercao { get; set; }
        DateTime Atualizacao { get; set; }
    }
}
