using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camada_Application.Dtos
{
    public class ClienteDto
    {
        public Guid? ClienteId { get; private set; }
        public string? Nome { get; private set; }
    }
}
