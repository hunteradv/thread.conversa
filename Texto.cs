using System;

namespace ThreadConversa
{
    public class Texto : Mensagem
    {
        public Texto (string conteudo)
        :base (conteudo)
        {
            Tipo = TipoMensagem.TEXTO;
        }

        public Texto (string id, string conteudo, Identidade emissor)
        :base (id, conteudo, emissor)
        {
            Tipo = TipoMensagem.TEXTO;
        }
    }
}