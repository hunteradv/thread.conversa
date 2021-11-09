using System;

namespace ThreadConversa
{
    public class Identidade
    {
        public string Id {get; set;}
        public string Nome {get; set;}

        public Identidade (string nome)
        {
            this.Nome = nome;
            this.Id = Guid.NewGuid().ToString();
        }
    }
}