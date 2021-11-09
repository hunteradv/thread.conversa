using System.Collections.Generic;
using System;
using System.Linq;

namespace ThreadConversa
{
    public interface IThread
    {
        public IEnumerable<Mensagem> AdicionaMensagem (Mensagem mensagem);
    }
}