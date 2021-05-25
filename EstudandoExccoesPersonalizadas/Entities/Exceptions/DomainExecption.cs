using System;
using System.Collections.Generic;
using System.Text;

namespace EstudandoExccoesPersonalizadas.Entities.Exceptions
{
    class DomainExecption : ApplicationException
    {
        public DomainExecption(string message) : base(message)
        {

        }
    }
}
