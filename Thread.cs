using System.Collections.Generic;
using System.Linq;
using System;

namespace ThreadConversa
{
    public class Thread
    {
        public List<Mensagem> Mensagens {get; private set;}

        public string Origem { get; private set; }
        public string Destino { get; private set; }

        public Thread()
        {
            Mensagens = new List<Mensagem>();
        }

        public IEnumerable<Mensagem> AdicionaMensagem (Mensagem mensagem)
        {
            Mensagens.Add(mensagem);
            return Mensagens;
        }

        private IEnumerable<Mensagem> AdicionaMensagemThread (Mensagem mensagem)
        {
            Mensagens.Add(mensagem);
            return Mensagens;
        }

        private IEnumerable<Mensagem> AdicionaMensagens (IEnumerable<Mensagem> mensagens)
        {
            Mensagens.AddRange(mensagens);
            return Mensagens;
        }

        public string MostraThread()
        {
            var thread = "";
            foreach (var mensagem in Mensagens)
            {
                thread = thread + $"[{mensagem?.Tipo}] {mensagem?.Emissor?.Nome}: {mensagem?.Conteudo}\n";
            }

            return thread;
        }

    }
}