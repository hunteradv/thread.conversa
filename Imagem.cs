namespace ThreadConversa
{
    public class Imagem : Mensagem
    {
        public Imagem (byte [] conteudo)
        :base (conteudo)
        {
            Tipo = TipoMensagem.IMAGEM;
        }   

        public Imagem (string id, byte [] conteudo, Identidade emissor)
        :base (id, conteudo, emissor)
        {
            Tipo = TipoMensagem.IMAGEM;
        }

        
    }
}