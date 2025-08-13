using System;

namespace ProjetoCSharp.Models
{
    public class Pessoa
    {
        public string Nome { get; set; } = string.Empty;
        public int Idade { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"Meu nome é {Nome} e tenho {Idade} anos.");
            
        }

    }
}