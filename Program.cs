using System;
using System.IO;

namespace ThreadConversa
{
    class Program
    {
        static void Main(string[] args)
        {
            var thread = new Thread();

            //no lugar de "texto.csv", insere i arquivo de texto simulando chat
            using (var reader = new StreamReader("texto.csv"))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split (';');

                    Mensagem msg = new Texto (values[0], values[1], new Identidade(values[3]));
                    thread.AdicionaMensagem (msg);
                }
            }

            Mensagem img = new Imagem (CreateByteArray(2));
            thread.AdicionaMensagem(img);

            Console.WriteLine();
             Console.WriteLine(thread.MostraThread());
        }

        public static byte[] CreateByteArray (int lenght)
        {
            var arr = new byte[lenght];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = 0x20;
            }

            return arr;
        }
    }
}
